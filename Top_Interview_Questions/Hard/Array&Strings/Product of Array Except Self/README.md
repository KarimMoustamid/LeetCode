# Product of Array Except Self

## Problem Statement

Given an integer array `nums`, return an array `answer` such that `answer[i]` is equal to the product of all the elements of `nums` except `nums[i]`.

- The product of any prefix or suffix of `nums` is guaranteed to fit in a 32-bit integer.
- You must write an algorithm that runs in `O(n)` time and does not use the division operation.

## Examples

### Example 1:
- **Input:** `nums = [1, 2, 3, 4]`
- **Output:** `[24, 12, 8, 6]`

### Example 2:
- **Input:** `nums = [-1, 1, 0, -3, 3]`
- **Output:** `[0, 0, 9, 0, 0]`

## Constraints:
- `2 <= nums.length <= 10^5`
- `-30 <= nums[i] <= 30`
- The product of any prefix or suffix of `nums` is guaranteed to fit in a 32-bit integer.

## Follow-Up:
Can you solve the problem with `O(1)` extra space complexity? (The output array does not count as extra space for space complexity analysis.)

## Approach

The solution involves calculating the product of all elements to the left and right of each position in a single pass to achieve `O(n)` time complexity. Here are the steps:

1. **Initialize Two Arrays:**
    - `left_products[i]` to store the product of all elements to the left of `i`.
    - `right_products[i]` to store the product of all elements to the right of `i`.

2. **First Pass (Left Products):**
    - Populate `left_products` such that `left_products[i]` contains the product of all elements to the left of index `i`.

3. **Second Pass (Right Products):**
    - Populate `right_products` such that `right_products[i]` contains the product of all elements to the right of index `i`.

4. **Final Array Calculation:**
    - The result for each index `i` is the product of `left_products[i]` and `right_products[i]`.

### Code Example

```csharp
public int[] ProductExceptSelf(int[] nums) {
    int n = nums.Length;
    int[] answer = new int[n];
    int[] left_products = new int[n];
    int[] right_products = new int[n];

    left_products[0] = 1;
    for (int i = 1; i < n; i++) {
        left_products[i] = nums[i - 1] * left_products[i - 1];
    }

    right_products[n - 1] = 1;
    for (int i = n - 2; i >= 0; i--) {
        right_products[i] = nums[i + 1] * right_products[i + 1];
    }

    for (int i = 0; i < n; i++) {
        answer[i] = left_products[i] * right_products[i];
    }

    return answer;
}
```

This approach ensures that the algorithm runs in `O(n)` time and does not use division, meeting the problem's constraints and complexity requirements.