# Review Journal

I treated `signal-sim-capacity-lab` as a project where the smallest useful behavior should still be inspectable.

The local checks classify each case as `ship`, `watch`, or `hold`. That gives the project a small review vocabulary that matches its simulations focus without claiming live deployment or external usage.

## Cases

- `baseline`: `input pressure`, score 166, lane `ship`
- `stress`: `state drift`, score 184, lane `ship`
- `edge`: `review cost`, score 242, lane `ship`
- `recovery`: `decision risk`, score 214, lane `ship`
- `stale`: `input pressure`, score 229, lane `ship`

## Note

The repository should be understandable without pretending it is larger than it is.
