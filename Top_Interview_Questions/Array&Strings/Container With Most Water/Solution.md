# Container With Most Water Problem

## Problem Statement

You are given an integer array `height` of length `n`. There are `n` vertical lines drawn such that the two endpoints of the `i-th` line are `(i, 0)` and `(i, height[i])`.

Find two lines that together with the x-axis form a container, such that the container contains the most water.

Return the maximum amount of water a container can store.

**Note:** You may not slant the container.

## Solution Approach

This problem can be efficiently solved using the two-pointer technique. The idea is to use two pointers starting from the ends of the array and move towards the center. Here’s the step-by-step logic:

1. **Initialize Two Pointers:** Start with two pointers, one at the beginning (`left = 0`) and the other at the end of the array (`right = n - 1`).

2. **Calculate Area:** For each pair of lines pointed by `left` and `right`, compute the area formed between these two lines along with the x-axis. The width is given by the difference in indices (`right - left`), and the height is the minimum value between `height[left]` and `height[right]`.

   \[
   \text{Area} = (\text{right} - \text{left}) \times \min(\text{height[left]}, \text{height[right]})
   \]

3. **Update Maximum Area:** Keep track of the maximum area encountered so far.

4. **Move Pointers:** To attempt to find a potentially larger area, move the pointer pointing to the shorter line inward. This is because the area is limited by the shorter line, and moving it inward might find a taller line that increases the area.

5. **Repeat:** Continue the process until the two pointers meet.

## Algorithm Implementation

```python
def maxArea(height):
    left, right = 0, len(height) - 1
    max_area = 0
    
    while left < right:
        # Calculate the current area
        width = right - left
        current_area = width * min(height[left], height[right])
        
        # Update the maximum area
        max_area = max(max_area, current_area)
        
        # Move the pointer pointing to the shorter line inward
        if height[left] < height[right]:
            left += 1
        else:
            right -= 1
            
    return max_area
```

## Explanation

- **Initialization:** `left` and `right` pointers are set to the start and end of the array respectively.
- **Loop Until Pointers Meet:** Calculate the area for the current position of the pointers. Update the maximum area if the current area is larger.
- **Move the Pointer:** Compare the heights at the `left` and `right` pointers. Move the pointer at the shorter line inward, hoping to find a taller line and a larger area.
- **End Condition:** The process stops when `left` meets `right`, meaning all possible containers have been considered.

This approach ensures that we examine the most promising pairs of lines without needing to check every possible pair, reducing the time complexity to `O(n)`.

## Time Complexity

The time complexity of this approach is `O(n)`, where `n` is the length of the `height` array. This is because each pointer only traverses the array once.

## Space Complexity

The space complexity is `O(1)` because no extra space proportional to the input size is used. Only a few variables are used to keep track of pointers and maximum area.