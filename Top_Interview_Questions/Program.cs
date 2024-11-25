using Top_Interview_Questions.Easy.Contains_Duplicate;

int[] nums1 = { 1, 2, 3, 1 };
int[] nums2 = { 1, 2, 3, 4 };
int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

Console.WriteLine("Test 1: " + Solution.ContainsDuplicate(nums1)); // Output: true
Console.WriteLine("Test 2: " + Solution.ContainsDuplicate(nums2)); // Output: false
Console.WriteLine("Test 3: " + Solution.ContainsDuplicate(nums3)); // Output: true