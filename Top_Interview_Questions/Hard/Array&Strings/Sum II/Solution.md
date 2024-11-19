# Four Sum II Problem Solution in C#

## The Problem

Given four arrays and the need to find tuples (i, j, k, l) such that the sum of their elements equals zero:

\[ \text{nums1}[i] + \text{nums2}[j] + \text{nums3}[k] + \text{nums4}[l] = 0 \]

## Brute-Force Approach

A straightforward approach would involve four nested loops iterating over every possible combination, resulting in computational complexity of \(O(n^4)\). This becomes impractical for large n (even just \(n=200\)) due to the sheer number of iterations.

## Optimized Approach with Hash Map (Dictionary)

We optimize the problem using the idea of breaking it into two smaller subproblems:

1. **Step 1:** Iterate over pairs of the first two arrays (`nums1` and `nums2`) and store their sums in a hash map.
2. **Step 2:** Iterate over pairs of the last two arrays (`nums3` and `nums4`) and check if the negation of their sum exists in the hash map.

Using a hash map reduces the problem from \(O(n^4)\) to \(O(n^2)\).

## Detailed Explanation

### 1. Creating the Hash Map

For every possible combination of elements from `nums1` and `nums2`, we calculate their sum and store it in the hash map. The key in the hash map is the sum, and the value is the number of times this sum occurs.

Consider the hash map as a tally of how many ways we can form each possible sum using one element from `nums1` and one from `nums2`.

For example:

- `nums1 = [1, 2]`
- `nums2 = [-2, -1]`

The possible sums and their counts:
- \(1 + (-2) = -1\)
- \(1 + (-1) = 0\)
- \(2 + (-2) = 0\)
- \(2 + (-1) = 1\)

Our hash map (`sumMap`) would be:
- `sumMap[-1] = 1`
- `sumMap[0] = 2`
- `sumMap[1] = 1`

### 2. Finding Tuples Using the Hash Map

Now, for each pair of `nums3` and `nums4`, compute their sum and check if the negation of this sum exists in the hash map.

Consider the negation sums for each pair from `nums3 = [-1, 2]` and `nums4 = [0, 2]`:
- \((-1) + 0 = -1\), so we look for `1` in `sumMap`
- \((-1) + 2 = 1\), so we look for `-1` in `sumMap`
- \(2 + 0 = 2\), so we look for `-2` in `sumMap`
- \(2 + 2 = 4\), so we look for `-4` in `sumMap`

For each successful lookup, we add the frequency count from the hash map to our result count because it means we found a combination that sums to 0.