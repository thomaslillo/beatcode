# Crystal Ball Problem

Given two crystal balls that will break if dropped from the correct distance, determine the exact spot in which it will break in the most optimized way.

## How it should be done

- you can linear search or binary + linear, but this generalized to O(N) still
- if you jump by intervals of the square root of the array's length you can get a runtime of O(sqrt(N))
