namespace Top_Interview_Questions.Easy.Rotate_Array
{
    public class Solution
    {
        public static void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n; // Handle cases where k is greater than n

            // Step 1: Reverse the entire array
            Reverse(nums, 0, n - 1);
            LogArray(nums, "Step 1: Reverse the entire array");

            // Step 2: Reverse the first k elements
            Reverse(nums, 0, k - 1);
            LogArray(nums, "Step 2: Reverse the first k elements");

            // Step 3: Reverse the remaining elements
            Reverse(nums, k, n - 1);
            LogArray(nums, "Step 3: Reverse the remaining elements");
        }

        private static void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                // Swap nums[start] and nums[end]
                (nums[start], nums[end]) = (nums[end], nums[start]);

                start++;
                end--;
            }
        }

        public static void LogArray(int[] array, string message = "")
        {
            if (array == null)
            {
                Console.WriteLine("Array is null.");
                return;
            }

            var originalBackgroundColor = Console.BackgroundColor;
            var originalForegroundColor = Console.ForegroundColor;

            try
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Console.WriteLine(message);
                }

                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(string.Join(", ", array));
            }
            finally
            {
                Console.BackgroundColor = originalBackgroundColor;
                Console.ForegroundColor = originalForegroundColor;
            }
        }
    }
}