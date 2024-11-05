namespace Top_Interview_Questions.Array_Strings.Product_of_Array_Except_Self
{
    using System.Runtime.InteropServices;

    public class ArrayProductExcludingSelf
    {
        public void ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] answer = new int[n];

            // Initialize the answer array with 1s ,This is an essential step for setting up the multiplication logic.
            for (int i = 0; i < n; i++)
            {
                answer[i] = 1;
            }

            // Calculate prefix products

            int prefix = 1; // Set the first element to the prefix value, effectively multiplying by 1

            for (int i = 0; i < n; i++)
            {
                answer[i] = prefix;
                prefix *= nums[i]; // Each element at index i will be the product of all preceding elements (prefix product)
            }


            // Calculate suffix products and update the answer array

            int suffix = 1; // Set the last element to the suffix value, effectively multiplying by 1
            for (int i = n - 1; i >= 0; i--)
            {
                answer[i] *= suffix;
                suffix *= nums[i]; // Multiply suffix by the element at index i (suffix product)
            }

            LogAnswer(answer);
        }


        private static void LogAnswer(int[] answer)
        {
            foreach (var item in answer)
            {
                Console.Write($"{item} ");
            }
        }
    }
}