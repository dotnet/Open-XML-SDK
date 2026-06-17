---
emoji: "🛠️"
name: Dependabot PR Fixer
description: Reviews a single Dependabot pull request, assesses risk, and applies safe repo-local fixes when possible.
on:
  pull_request:
    types: [opened, reopened, synchronize]
  workflow_dispatch:
    inputs:
      pr_number:
        description: Pull request number to inspect manually
        required: false
      group:
        description: Optional group key carried from the bundler run
        required: false
permissions:
  contents: read
  pull-requests: read
  issues: read
  actions: read
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
      EXPR_GITHUB_REPOSITORY: ${{ github.repository }}
      EXPR_PR_NUMBER: ${{ github.event.pull_request.number }}
      INPUT_PR_NUMBER: ${{ inputs.pr_number }}
      INPUT_GROUP: ${{ inputs.group }}
    run: |
      set -euo pipefail
      mkdir -p /tmp/gh-aw/data

      PR_NUMBER="${INPUT_PR_NUMBER:-${EXPR_PR_NUMBER:-}}"
      GROUP_KEY="${INPUT_GROUP:-}"

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
        --arg mode "worker" \
        --arg group_key "$GROUP_KEY" \
        --slurpfile pr /tmp/gh-aw/data/pr.json \
        --slurpfile files /tmp/gh-aw/data/files.json \
        --slurpfile comments /tmp/gh-aw/data/comments.json \
        --slurpfile reviews /tmp/gh-aw/data/reviews.json \
        '{
          mode: $mode,
          group_key: (if $group_key == "" then null else $group_key end),
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

1. Read `/tmp/gh-aw/data/summary.json` first.
2. Use `/tmp/gh-aw/data/pr.json`, `/tmp/gh-aw/data/files.json`, `/tmp/gh-aw/data/comments.json`, and `/tmp/gh-aw/data/reviews.json` as your primary context.
3. If the PR is not clearly from Dependabot, call `noop` with a short reason and stop.
4. Assign exactly one bucket:
   - `ready-to-merge`: no repo changes needed; remaining work is waiting for CI or maintainer approval.
   - `safe-auto-fix`: a known-safe repo-local fix can be applied automatically.
   - `manual-breaking-change`: the update appears to need a human design or compatibility decision.
   - `blocked-external`: failures are caused by flaky CI, branch protection, missing permissions, or unrelated external breakage.
   - `unsupported`: the change falls outside the safe auto-fix patterns below.
5. Assign a risk level of `low`, `medium`, or `high` before commenting:
   - `low`: routine dependency bump or tightly scoped follow-up with clear verification and no design uncertainty.
   - `medium`: touches multiple repo areas, needs source changes beyond version alignment, or has partial uncertainty even if a safe fix may still exist.
   - `high`: likely breaking change, workflow/security-sensitive surface, unclear remediation, or broad impact requiring human review.
6. Always inspect the changed files, current checks, and the likely source of failure before choosing a bucket and risk level.
7. When you need repository changes, check out the PR branch, make the smallest correct fix, and verify it with the narrowest existing commands that give confidence. Prefer targeted restore/build/test commands over broad full-repo runs when possible.

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
- If there is nothing useful to change or say beyond an explicit skip, call `noop`.

## Comment format

When commenting, keep it short and structured:

- bucket
- risk
- root cause
- changes made or why no safe fix was applied
- verification run
- next step
