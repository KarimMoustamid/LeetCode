namespace Top_Interview_Questions.Easy.Contains_Duplicate
{
    public class Solution
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            // Initialize a HashSet to track seen numbers
            HashSet<int> seenNumbers = new HashSet<int>();

            // Iterate through the array
            foreach (int num in nums)
            {
                // Check if the number is already in the set
                if (!seenNumbers.Add(num))
                {
                    return true; // Duplicate found
                }
            }

            // If no duplicates are found
            return false;
        }
    }
}