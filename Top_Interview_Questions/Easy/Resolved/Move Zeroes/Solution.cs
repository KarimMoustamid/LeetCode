namespace Top_Interview_Questions.Easy.Move_Zeroes
{
    using Helpers;
    using Microsoft.VisualBasic.CompilerServices;

    public static class Solution
    {
        public static void MoveZeroes(int[] nums)
        {
            Log.LogMessage("Provided Array :");
            Log.Array(nums);

            int n = nums.Length;
            // Pointer to track the position for non-zero elements
            int nonZeroIndex = 0;

            Log.LogMessage("Step 1: Move non-zero elements to the front");
            Log.LogMessage($"nonZeroIndex = {nonZeroIndex}");
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != 0)
                {
                    nums[nonZeroIndex] = nums[i];
                    nonZeroIndex++;
                }
            }

            Log.Array(nums);
            Log.LogMessage($"nonZeroIndex = {nonZeroIndex}");
            Log.LogMessage("Step 2: Fill the rest of the array with zeros");

            for (int i = nonZeroIndex; i < n; i++)
            {
                nums[i] = 0;
            }

            Log.Array(nums);
            Log.LogMessage($"nonZeroIndex = {nonZeroIndex}");


        }
    }
}