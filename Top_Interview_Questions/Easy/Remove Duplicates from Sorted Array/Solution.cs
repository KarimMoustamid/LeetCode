namespace Top_Interview_Questions.Easy.Remove_Duplicates_from_Sorted_Array
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int unique = 0; // Pointer for the position of unique elements

            // Iterate through the array
            for (int current = 1; current < nums.Length; current++) {
                // If a new unique value is found
                if (nums[current] != nums[unique]) {
                    unique++; // Move the unique pointer forward
                    nums[unique] = nums[current]; // Place the unique value at the new position
                }
            }

            // The number of unique elements is `unique + 1`
            return unique + 1;
        }


        public void LogArray(int[] nums)
        {
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}