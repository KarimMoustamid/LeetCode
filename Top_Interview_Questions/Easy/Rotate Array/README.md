# Rotate Array

Given an integer array `nums`, rotate the array to the right by `k` steps, where `k` is non-negative.

## Example 1:

**Input:**
```plaintext
nums = [1,2,3,4,5,6,7], k = 3
```
**Output:**
```plaintext
[5,6,7,1,2,3,4]
```
**Explanation:**

## Example 2:

**Input:**
```plaintext
nums = [-1,-100,3,99], k = 2
```
**Output:**
```plaintext
[3,99,-1,-100]
```
**Explanation:**

## Constraints:

- \(1 \leq \text{nums.length} \leq 10^5\)
- \(-2^{31} \leq \text{nums[i]} \leq 2^{31} - 1\)
- \(0 \leq k \leq 10^5\)

## Follow up:

- Try to come up with as many solutions as you can. There are at least three different ways to solve this problem.
- Could you do it in-place with \(O(1)\) extra space?