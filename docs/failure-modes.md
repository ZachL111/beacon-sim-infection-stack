# Failure Modes

For `beacon-sim-infection-stack`, I would look first for these mistakes:

- `input pressure` cases moving lanes without a matching threshold change.
- `review cost` scoring higher after drag increases.
- Duplicate fixture ids hiding a stale golden row.
- README examples drifting away from the verifier.

The local checks are intentionally strict about these cases.
