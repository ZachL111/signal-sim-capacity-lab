# Signal Sim Capacity Lab Walkthrough

The fixture is intentionally compact, so the review starts with the cases that pull farthest apart.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | input pressure | 166 | ship |
| stress | state drift | 184 | ship |
| edge | review cost | 242 | ship |
| recovery | decision risk | 214 | ship |
| stale | input pressure | 229 | ship |

Start with `edge` and `baseline`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

`edge` is the optimistic case; use it to make sure the scoring path still rewards strong signal.
