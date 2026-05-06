# signal-sim-capacity-lab

`signal-sim-capacity-lab` keeps a focused C# implementation around simulations. The project goal is to create a C# reference implementation for capacity workflows, centered on constraint solving, bounded scenario files, and conflict explanations.

## Why This Exists

The project exists to keep a narrow engineering decision visible and testable. For this repo, that decision is how input pressure and review cost should influence a review result.

## Signal Sim Capacity Lab Review Notes

`edge` and `baseline` are the cases worth reading first. They show the optimistic and cautious ends of the fixture.

## Capabilities

- `fixtures/domain_review.csv` adds cases for input pressure and state drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/signal-sim-capacity-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `review cost` and `input pressure`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Implementation Shape

The core code exposes a scoring path and the added review layer uses `signal`, `slack`, `drag`, and `confidence`. The domain terms are `input pressure`, `state drift`, `review cost`, and `decision risk`.

The C# code keeps the review rule close to the tests.

## Local Usage

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Verification

The verifier is intentionally local. It should fail if the fixture score math, lane assignment, or language-specific test drifts.

## Roadmap

This remains a local project with deterministic fixtures. It does not depend on credentials, hosted services, or live data. Future work should add richer malformed inputs before widening the public API.
