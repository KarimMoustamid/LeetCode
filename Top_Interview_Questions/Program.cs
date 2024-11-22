using Top_Interview_Questions.Easy.Remove_Duplicates_from_Sorted_Array;

int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];

Solution solution = new Solution();
int k = solution.RemoveDuplicates(nums);
Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"the number of unique elements in nums is : {k}");