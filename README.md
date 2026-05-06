# beacon-sim-infection-stack

`beacon-sim-infection-stack` is a C# project in simulations. Its focus is to create a C# reference implementation for infection workflows, centered on security rule linting, safe and unsafe fixtures, and remediation hints.

## Why I Keep It Small

I want this repository to be useful as a quick reading exercise: fixtures first, implementation second, verifier last.

## Beacon Sim Infection Stack Review Notes

The first comparison I would make is `state drift` against `input pressure` because it shows where the rule is most opinionated.

## Included Behavior

- `fixtures/domain_review.csv` adds cases for input pressure and state drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/beacon-sim-infection-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `state drift` and `input pressure`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Internal Model

The implementation keeps the scoring rule plain: reward signal and confidence, preserve slack, penalize drag, then classify the result into a review lane.

The C# implementation avoids hidden state so fixture changes are easy to reason about.

## Try It Locally

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Validation

That command is also the regression path. It verifies the domain cases and catches mismatches between the CSV, metadata, and code.

## Scope

This remains a local project with deterministic fixtures. It does not depend on credentials, hosted services, or live data. Future work should add richer malformed inputs before widening the public API.
