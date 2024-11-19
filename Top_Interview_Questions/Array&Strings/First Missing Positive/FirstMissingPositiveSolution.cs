namespace Top_Interview_Questions.Array_Strings.First_Missing_Positive
{
    public class FirstMissingPositiveSolution
    {
        public int FirstMissingPositive(int[] nums)
        {
            int n = nums.Length;

            // Step 1: Clean the data
            for (int i = 0; i < n; i++)
            {
                if (nums[i] <= 0 || nums[i] > n)
                {
                    nums[i] = n + 1; // Replace irrelevant numbers
                }
            }

            // Step 2: Use indices as markers
            for (int i = 0; i < n; i++)
            {
                {
                    int num = Math.Abs(nums[i]);
                    // Only mark numbers within the range [1, n]
                    if (num <= n)
                    {
                        int index = num - 1;
                        nums[index] = -Math.Abs(nums[index]); // Mark the index as negative
                    }
                }
            }

            // Step 3: Find the first unmarked index
            for (int i = 0; i < n; i++)
            {
                if (nums[i] > 0)
                {
                    return i + 1; // i + 1 is the missing positive number
                }
            }

            // If all indices are marked, return n + 1
            return n + 1;
        }
    }
}