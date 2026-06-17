---
emoji: "🧭"
name: Dependabot PR Bundler
description: Scans open Dependabot pull requests, groups them by ecosystem and area, and dispatches worker runs.
on:
  workflow_dispatch:
    inputs:
      pr_number:
        description: Optional pull request number to target directly
        required: false
      group:
        description: Optional group key to scan, such as nuget:product or github-actions:workflows
        required: false
      max_prs:
        description: Maximum PRs to fan out in one run (up to 3)
        required: false
permissions:
  contents: read
  pull-requests: read
  issues: read
  actions: read
  copilot-requests: write
checkout:
  fetch-depth: 0
network:
  allowed: [defaults]
tools:
  github:
    mode: gh-proxy
    toolsets: [pull_requests, actions, repos]
steps:
  - name: Prepare Dependabot context
    env:
      GH_TOKEN: ${{ secrets.GH_AW_GITHUB_MCP_SERVER_TOKEN || secrets.GH_AW_GITHUB_TOKEN || secrets.GITHUB_TOKEN }}
      EXPR_GITHUB_REPOSITORY: ${{ github.repository }}
      INPUT_PR_NUMBER: ${{ inputs.pr_number }}
      INPUT_GROUP: ${{ inputs.group }}
      INPUT_MAX_PRS: ${{ inputs.max_prs }}
    run: |
      set -euo pipefail
      mkdir -p /tmp/gh-aw/data /tmp/gh-aw/data/pr-files

      PR_NUMBER="${INPUT_PR_NUMBER:-}"
      GROUP_KEY="${INPUT_GROUP:-}"
      MAX_PRS_RAW="${INPUT_MAX_PRS:-3}"

      case "$MAX_PRS_RAW" in
        ''|*[!0-9]*) MAX_PRS=3 ;;
        *) MAX_PRS="$MAX_PRS_RAW" ;;
      esac
      if [ "$MAX_PRS" -lt 1 ]; then
        MAX_PRS=1
      elif [ "$MAX_PRS" -gt 3 ]; then
        MAX_PRS=3
      fi

      if [ -n "$PR_NUMBER" ]; then
        gh pr view "$PR_NUMBER" --repo "$EXPR_GITHUB_REPOSITORY" \
          --json number,title,url,headRefName,author \
          | jq -s '.' > /tmp/gh-aw/data/open-prs.json
      else
        gh pr list --repo "$EXPR_GITHUB_REPOSITORY" --state open --limit 100 \
          --json number,title,url,headRefName,author \
          > /tmp/gh-aw/data/open-prs.raw.json

        jq '[.[] | select(
            ((.author.login // "") == "app/dependabot")
            or ((.author.login // "") == "dependabot[bot]")
            or ((.title // "") | test("^Bump "; "i"))
            or ((.headRefName // "") | contains("dependabot/"))
          )]' \
          /tmp/gh-aw/data/open-prs.raw.json > /tmp/gh-aw/data/open-prs.json
      fi

      if [ "$(jq 'length' /tmp/gh-aw/data/open-prs.json)" -eq 0 ]; then
        jq -n \
          --arg group_filter "$GROUP_KEY" \
          --argjson max_prs "$MAX_PRS" \
          '{
            mode: "scan",
            group_filter: (if $group_filter == "" then null else $group_filter end),
            max_prs: $max_prs,
            total_open_dependabot_prs: 0,
            filtered_pr_count: 0,
            dispatch_count: 0,
            groups: [],
            dispatch_queue: []
          }' > /tmp/gh-aw/data/summary.json
        exit 0
      fi

      : > /tmp/gh-aw/data/scan-prs.jsonl
      while IFS= read -r pr; do
        number="$(jq -r '.number' <<< "$pr")"
        title="$(jq -r '.title' <<< "$pr")"
        url="$(jq -r '.url' <<< "$pr")"
        head_ref="$(jq -r '.headRefName // ""' <<< "$pr")"

        gh api "repos/$EXPR_GITHUB_REPOSITORY/pulls/$number/files?per_page=100" \
          --jq 'map(.filename)' > "/tmp/gh-aw/data/pr-files/$number.json"

        ecosystem="$(jq -rn --arg head_ref "$head_ref" '
          if ($head_ref | test("^dependabot/[^/]+/")) then
            ($head_ref | capture("^dependabot/(?<ecosystem>[^/]+)/").ecosystem)
          else
            "unknown"
          end
        ')"

        area="$(jq -r '
          if any(.[]; startswith(".github/workflows/")) then "workflows"
          elif any(.[]; startswith("src/")) or any(.[]; startswith("gen/")) then "product"
          elif any(.[]; startswith("test/")) then "tests"
          elif any(.[]; startswith("samples/")) then "samples"
          elif any(.[]; startswith("data/")) then "data"
          else "repo"
          end
        ' "/tmp/gh-aw/data/pr-files/$number.json")"

        group_key="$ecosystem:$area"
        group_label="$ecosystem / $area"

        jq -n \
          --argjson number "$number" \
          --arg title "$title" \
          --arg url "$url" \
          --arg ecosystem "$ecosystem" \
          --arg area "$area" \
          --arg group_key "$group_key" \
          --arg group_label "$group_label" \
          '{
            number: $number,
            title: $title,
            url: $url,
            ecosystem: $ecosystem,
            area: $area,
            group_key: $group_key,
            group_label: $group_label
          }' >> /tmp/gh-aw/data/scan-prs.jsonl
      done < <(jq -c '.[]' /tmp/gh-aw/data/open-prs.json)

      jq -s '.' /tmp/gh-aw/data/scan-prs.jsonl > /tmp/gh-aw/data/scan-prs.json

      if [ -n "$GROUP_KEY" ]; then
        jq --arg group_key "$GROUP_KEY" '[.[] | select(.group_key == $group_key or .ecosystem == $group_key or .area == $group_key)]' \
          /tmp/gh-aw/data/scan-prs.json > /tmp/gh-aw/data/scan-prs.filtered.json
      else
        cp /tmp/gh-aw/data/scan-prs.json /tmp/gh-aw/data/scan-prs.filtered.json
      fi

      jq 'sort_by(.group_key, .number) | group_by(.group_key) | map({
          group_key: .[0].group_key,
          group_label: .[0].group_label,
          ecosystem: .[0].ecosystem,
          area: .[0].area,
          count: length,
          prs: map({number, title, url})
        })' /tmp/gh-aw/data/scan-prs.filtered.json > /tmp/gh-aw/data/groups.json

      jq "sort_by(.group_key, .number)[:$MAX_PRS]" /tmp/gh-aw/data/scan-prs.filtered.json > /tmp/gh-aw/data/dispatch-queue.json

      jq -n \
        --arg group_filter "$GROUP_KEY" \
        --argjson max_prs "$MAX_PRS" \
        --argjson total_open_dependabot_prs "$(jq 'length' /tmp/gh-aw/data/open-prs.json)" \
        --argjson filtered_pr_count "$(jq 'length' /tmp/gh-aw/data/scan-prs.filtered.json)" \
        --argjson dispatch_count "$(jq 'length' /tmp/gh-aw/data/dispatch-queue.json)" \
        --slurpfile groups /tmp/gh-aw/data/groups.json \
        --slurpfile dispatch_queue /tmp/gh-aw/data/dispatch-queue.json \
        '{
          mode: "scan",
          group_filter: (if $group_filter == "" then null else $group_filter end),
          max_prs: $max_prs,
          total_open_dependabot_prs: $total_open_dependabot_prs,
          filtered_pr_count: $filtered_pr_count,
          dispatch_count: $dispatch_count,
          groups: $groups[0],
          dispatch_queue: $dispatch_queue[0]
        }' > /tmp/gh-aw/data/summary.json
safe-outputs:
  dispatch-workflow:
    workflows: [dependabot-pr-fixer-worker]
    max: 3
  noop:
timeout-minutes: 15
---

# Dependabot PR Bundler

## Task

1. Read `/tmp/gh-aw/data/summary.json` first.
2. Treat this run as an orchestrator only:
   - use `summary.groups` and `summary.dispatch_queue` as the full context
   - do not inspect or modify repository files
   - do not add PR comments
3. If `summary.dispatch_queue` is empty, call `noop` with a short summary of the grouped PRs found and why no worker runs were dispatched.
4. Otherwise, for each PR in `summary.dispatch_queue`, call `dispatch_workflow` with:
   - `workflow_name: "dependabot-pr-fixer-worker"`
   - `inputs.pr_number`: the PR number as a string
   - `inputs.group`: the PR group key
5. After dispatching, call `noop` with a short summary of the grouped PRs found, which group filter was used if any, and how many worker runs you dispatched.
6. Never try to repair PRs directly in this orchestrator run.
7. Never dispatch workers with direct `gh api` writes from the agent job; use `dispatch_workflow` only.
