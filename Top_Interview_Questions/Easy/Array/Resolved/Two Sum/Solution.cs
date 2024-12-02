namespace Top_Interview_Questions.Easy.Two_Sum
{
    using Helpers;

    public static class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            Log.LogMessage($"Provided array :[{string.Join(", ", nums)}]");

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    Log.LogMessage($"Found complement {complement} for target - Nums({i}) = {target} - {nums[i]}");
                    return new int[] {map[complement], i};
                }

                // Add the current number and its index to the dictionary
                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = i;
                }
            }

            return null; // No solution, though the problem guarantees one.
        }
    }
}

/*
 * Difference Between map.Add() and map[nums[i]] = i

   map.Add(key, value):
   Adds the key-value pair to the dictionary.
   Throws an exception if the key already exists.

   map[nums[i]] = i:
   If the key exists, it updates the value.
   If the key does not exist, it adds the key-value pair.
 */