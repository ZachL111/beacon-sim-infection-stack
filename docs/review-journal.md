# Review Journal

I treated `beacon-sim-infection-stack` as a project where the smallest useful behavior should still be inspectable.

The local checks classify each case as `ship`, `watch`, or `hold`. That gives the project a small review vocabulary that matches its simulations focus without claiming live deployment or external usage.

## Cases

- `baseline`: `input pressure`, score 134, lane `watch`
- `stress`: `state drift`, score 202, lane `ship`
- `edge`: `review cost`, score 200, lane `ship`
- `recovery`: `decision risk`, score 190, lane `ship`
- `stale`: `input pressure`, score 136, lane `watch`

## Note

This file is intentionally plain so the fixture remains the source of truth.
