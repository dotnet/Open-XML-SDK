---
emoji: "🛠️"
name: Dependabot PR Fixer
description: Scans open Dependabot pull requests, groups them by ecosystem and area, and fans out single-PR fixer runs.
on:
  pull_request:
    types: [opened, reopened, synchronize]
  workflow_dispatch:
    inputs:
      pr_number:
        description: Pull request number to inspect manually
        required: false
      group:
        description: Optional group key to scan, such as nuget:product or github-actions:workflows
        required: false
      max_prs:
        description: Maximum PRs to fan out in scan mode
        required: false
permissions:
  contents: read
  pull-requests: read
  issues: read
  actions: read
  copilot-requests: write
checkout:
  fetch: ["refs/pulls/*", "refs/heads/*"]
  fetch-depth: 0
network:
  allowed: [defaults, dotnet]
tools:
  github:
    mode: gh-proxy
    toolsets: [pull_requests, issues, actions, repos]
steps:
  - name: Prepare Dependabot context
    env:
      GH_TOKEN: ${{ secrets.GH_AW_GITHUB_MCP_SERVER_TOKEN || secrets.GH_AW_GITHUB_TOKEN || secrets.GITHUB_TOKEN }}
      DISPATCH_TOKEN: ${{ secrets.GH_AW_CI_TRIGGER_TOKEN || secrets.GH_AW_GITHUB_TOKEN || secrets.GITHUB_TOKEN }}
      EXPR_GITHUB_REPOSITORY: ${{ github.repository }}
      EXPR_EVENT_NAME: ${{ github.event_name }}
      EXPR_PR_NUMBER: ${{ github.event.pull_request.number }}
      EXPR_RUN_ID: ${{ github.run_id }}
      INPUT_PR_NUMBER: ${{ inputs.pr_number }}
      INPUT_GROUP: ${{ inputs.group }}
      INPUT_MAX_PRS: ${{ inputs.max_prs }}
    run: |
      set -euo pipefail
      mkdir -p /tmp/gh-aw/data /tmp/gh-aw/data/pr-files

      PR_NUMBER="${INPUT_PR_NUMBER:-${EXPR_PR_NUMBER:-}}"
      GROUP_KEY="${INPUT_GROUP:-}"
      GROUP_LABEL=""

      if [ -n "$PR_NUMBER" ] || [ "$EXPR_EVENT_NAME" = "pull_request" ]; then
        MODE="worker"
      else
        MODE="scan"
      fi

      if [ "$MODE" = "worker" ]; then
        if [ -z "$PR_NUMBER" ]; then
          echo "Missing PR number" >&2
          exit 1
        fi

        gh pr view "$PR_NUMBER" --repo "$EXPR_GITHUB_REPOSITORY" \
          --json number,title,url,author,headRefName,headRefOid,baseRefName,mergeStateStatus,reviewDecision,isDraft,labels,statusCheckRollup \
          > /tmp/gh-aw/data/pr.json

        gh api "repos/$EXPR_GITHUB_REPOSITORY/pulls/$PR_NUMBER/files?per_page=100" \
          --jq 'map({filename,status,additions,deletions,changes})' \
          > /tmp/gh-aw/data/files.json

        gh api "repos/$EXPR_GITHUB_REPOSITORY/issues/$PR_NUMBER/comments?per_page=20" \
          --jq 'map({author:(.user.login // "unknown"), created_at, body})' \
          > /tmp/gh-aw/data/comments.json

        gh api "repos/$EXPR_GITHUB_REPOSITORY/pulls/$PR_NUMBER/reviews?per_page=20" \
          --jq 'map({author:(.user.login // "unknown"), state, submitted_at, body})' \
          > /tmp/gh-aw/data/reviews.json

        jq -n \
          --arg mode "$MODE" \
          --arg group_key "$GROUP_KEY" \
          --arg group_label "$GROUP_LABEL" \
          --slurpfile pr /tmp/gh-aw/data/pr.json \
          --slurpfile files /tmp/gh-aw/data/files.json \
          --slurpfile comments /tmp/gh-aw/data/comments.json \
          --slurpfile reviews /tmp/gh-aw/data/reviews.json \
          '{
            mode: $mode,
            group_key: (if $group_key == "" then null else $group_key end),
            group_label: (if $group_label == "" then null else $group_label end),
            pr: $pr[0],
            changed_files: ($files[0] | map(.filename)),
            changed_file_count: ($files[0] | length),
            latest_comment_author: (if (($comments[0] | length) > 0) then $comments[0][-1].author else null end),
            review_states: ($reviews[0] | group_by(.state) | map({state: .[0].state, count: length})),
            likely_dependabot: (
              (($pr[0].author.login // "") == "app/dependabot")
              or (($pr[0].author.login // "") == "dependabot[bot]")
              or (($pr[0].title // "") | test("^Bump "; "i"))
              or (($pr[0].headRefName // "") | contains("dependabot/"))
            )
          }' > /tmp/gh-aw/data/summary.json

        exit 0
      fi

      MAX_PRS_RAW="${INPUT_MAX_PRS:-5}"
      case "$MAX_PRS_RAW" in
        ''|*[!0-9]*) MAX_PRS=5 ;;
        *) MAX_PRS="$MAX_PRS_RAW" ;;
      esac
      if [ "$MAX_PRS" -lt 1 ]; then
        MAX_PRS=1
      fi

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

      if [ "$(jq 'length' /tmp/gh-aw/data/open-prs.json)" -eq 0 ]; then
        jq -n \
          --arg mode "$MODE" \
          --arg group_filter "$GROUP_KEY" \
          --argjson max_prs "$MAX_PRS" \
          '{
            mode: $mode,
            group_filter: (if $group_filter == "" then null else $group_filter end),
            max_prs: $max_prs,
            total_open_dependabot_prs: 0,
            filtered_pr_count: 0,
            dispatched_count: 0,
            dispatch_enabled: false,
            groups: [],
            dispatched_prs: []
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
          --arg head_ref "$head_ref" \
          --arg ecosystem "$ecosystem" \
          --arg area "$area" \
          --arg group_key "$group_key" \
          --arg group_label "$group_label" \
          '{
            number: $number,
            title: $title,
            url: $url,
            head_ref: $head_ref,
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
      : > /tmp/gh-aw/data/dispatched-prs.jsonl

      if [ -n "${DISPATCH_TOKEN:-}" ]; then
        while IFS= read -r pr; do
          number="$(jq -r '.number' <<< "$pr")"
          dispatch_group_key="$(jq -r '.group_key' <<< "$pr")"
          head_ref="$(jq -r '.head_ref' <<< "$pr")"

          GH_TOKEN="$DISPATCH_TOKEN" gh api \
            "repos/$EXPR_GITHUB_REPOSITORY/actions/workflows/dependabot-pr-bundler.lock.yml/dispatches" \
            --method POST \
            -f ref="$head_ref" \
            -F inputs[pr_number]="$number" \
            -F inputs[group]="$dispatch_group_key" \
            -F inputs[max_prs]="1" >/dev/null

          printf '%s\n' "$pr" >> /tmp/gh-aw/data/dispatched-prs.jsonl
        done < <(jq -c '.[]' /tmp/gh-aw/data/dispatch-queue.json)
        DISPATCH_ENABLED=true
      else
        DISPATCH_ENABLED=false
      fi

      if [ -s /tmp/gh-aw/data/dispatched-prs.jsonl ]; then
        jq -s '.' /tmp/gh-aw/data/dispatched-prs.jsonl > /tmp/gh-aw/data/dispatched-prs.json
      else
        printf '[]\n' > /tmp/gh-aw/data/dispatched-prs.json
      fi

      jq -n \
        --arg mode "$MODE" \
        --arg group_filter "$GROUP_KEY" \
        --argjson max_prs "$MAX_PRS" \
        --argjson total_open_dependabot_prs "$(jq 'length' /tmp/gh-aw/data/open-prs.json)" \
        --argjson filtered_pr_count "$(jq 'length' /tmp/gh-aw/data/scan-prs.filtered.json)" \
        --argjson dispatched_count "$(jq 'length' /tmp/gh-aw/data/dispatched-prs.json)" \
        --argjson dispatch_enabled "$DISPATCH_ENABLED" \
        --slurpfile groups /tmp/gh-aw/data/groups.json \
        --slurpfile dispatched /tmp/gh-aw/data/dispatched-prs.json \
        '{
          mode: $mode,
          group_filter: (if $group_filter == "" then null else $group_filter end),
          max_prs: $max_prs,
          total_open_dependabot_prs: $total_open_dependabot_prs,
          filtered_pr_count: $filtered_pr_count,
          dispatched_count: $dispatched_count,
          dispatch_enabled: $dispatch_enabled,
          groups: $groups[0],
          dispatched_prs: $dispatched[0]
        }' > /tmp/gh-aw/data/summary.json
safe-outputs:
  add-comment:
    max: 2
    hide-older-comments: true
  push-to-pull-request-branch:
    if-no-changes: ignore
    commit-title-suffix: " [dependabot-pr-fixer]"
    protected-files: fallback-to-issue
    allowed-files:
      - "src/**"
      - "test/**"
      - "gen/**"
      - "samples/**"
      - "data/**"
      - "*.sln"
      - "*.slnx"
      - "global.json"
      - "nuget.config"
      - "Directory.Build.props"
      - "Directory.Build.targets"
      - "Directory.Packages.props"
  noop:
timeout-minutes: 25
---

# Dependabot PR Fixer

## Task

You operate in exactly one of two modes based on `/tmp/gh-aw/data/summary.json`.

1. Read `/tmp/gh-aw/data/summary.json` first.
2. If `summary.mode` is `scan`, treat this run as an orchestrator only:
   - use `summary.groups` and `summary.dispatched_prs` as the full context
   - do not inspect or modify repository files
   - do not add PR comments
   - call `noop` with a short summary of the grouped PRs found, which group filter was used if any, and how many worker runs were dispatched
3. If `summary.mode` is `worker`, then use `/tmp/gh-aw/data/pr.json`, `/tmp/gh-aw/data/files.json`, `/tmp/gh-aw/data/comments.json`, and `/tmp/gh-aw/data/reviews.json` as your primary context.
4. In worker mode, if the PR is not clearly from Dependabot, call `noop` with a short reason and stop.
5. In worker mode, assign exactly one bucket:
   - `ready-to-merge`: no repo changes needed; remaining work is waiting for CI or maintainer approval.
   - `safe-auto-fix`: a known-safe repo-local fix can be applied automatically.
   - `manual-breaking-change`: the update appears to need a human design or compatibility decision.
   - `blocked-external`: failures are caused by flaky CI, branch protection, missing permissions, or unrelated external breakage.
   - `unsupported`: the change falls outside the safe auto-fix patterns below.
6. In worker mode, assign a risk level of `low`, `medium`, or `high` before commenting:
   - `low`: routine dependency bump or tightly scoped follow-up with clear verification and no design uncertainty.
   - `medium`: touches multiple repo areas, needs source changes beyond version alignment, or has partial uncertainty even if a safe fix may still exist.
   - `high`: likely breaking change, workflow/security-sensitive surface, unclear remediation, or broad impact requiring human review.
7. In worker mode, always inspect the changed files, current checks, and the likely source of failure before choosing a bucket and risk level.
8. When you need repository changes in worker mode, check out the PR branch, make the smallest correct fix, and verify it with the narrowest existing commands that give confidence. Prefer targeted restore/build/test commands over broad full-repo runs when possible.

## Safe auto-fix patterns

Only push changes for patterns that are clearly low-risk and local to this repository:

- simple dependency-version follow-up edits in project or solution files needed to keep versions aligned
- small source fixes caused by well-understood API or package rename/signature changes
- generated-file refreshes that are required after a safe source change
- Dependabot PRs for generated workflow manifests under `.github/workflows/`: **never fix those by editing generated manifest files directly**.

For workflow-manifest Dependabot PRs, follow this rule set:

- Treat `.github/workflows/package.json`, `.github/workflows/package-lock.json`, `.github/workflows/requirements.txt`, and `.github/workflows/go.mod` as generated artifacts.
- Explain in the summary comment which source `.md` workflow or shared component should be updated.
- Because this workflow is not allowed to push `.github/workflows/**` changes without an app-backed workflow token, bucket these as `unsupported` unless the required source change is outside `.github/workflows/**`.

## Guardrails

- Never make speculative or large refactors.
- Never force-push, merge the PR, or edit unrelated files.
- If the correct fix is unclear, stop and use `manual-breaking-change` or `unsupported`.
- If a push would touch protected or disallowed files, do not work around it; comment instead.
- Do not use a GitHub App or any app-backed token flow.
- Prefer one concise summary comment over multiple comments.
- If you push a fix, also leave a comment summarizing the bucket, risk level, what changed, and what verification you ran.
- If you do not push a fix, leave a comment with the bucket, risk level, the blocker, and the smallest useful next step for a maintainer.
- In scan mode, never try to repair PRs directly in the orchestrator run; let the dispatched workflow-dispatch worker runs handle the per-PR fixes.
- If there is nothing useful to change or say beyond an explicit skip, call `noop`.

## Comment format

When commenting, keep it short and structured:

- bucket
- risk
- root cause
- changes made or why no safe fix was applied
- verification run
- next step
