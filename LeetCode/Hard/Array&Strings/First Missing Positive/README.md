# First Missing Positive

## Problem Statement

Given an unsorted integer array `nums`, return the smallest positive integer that is not present in `nums`.

You must implement an algorithm that runs in O(n) time and uses O(1) auxiliary space.

## Examples

### Example 1:
**Input:** `[1, 2, 0]`  
**Output:** `3`  
**Explanation:** The numbers in the range `[1, 2]` are all in the array.

### Example 2:
**Input:** `[3, 4, -1, 1]`  
**Output:** `2`  
**Explanation:** `1` is in the array but `2` is missing.

### Example 3:
**Input:** `[7, 8, 9, 11, 12]`  
**Output:** `1`  
**Explanation:** The smallest positive integer `1` is missing.

## Constraints

- \(1 \leq \text{nums.length} \leq 10^5\)
- \(-2^{31} \leq \text{nums}[i] \leq 2^{31} - 1\)