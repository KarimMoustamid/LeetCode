namespace Top_Interview_Questions.Easy.Plus_One
{
    using Helpers;

    public static class Solution
    {
        public static int[] PlusOne(int[] digits)
        {
            Log.Array(digits);
            Log.LogMessage("Traverse the array from the last digit");
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i]++; // Add 1 to the current digit
                if (digits[i] < 10)
                {
                    Log.Array(digits);
                    return digits; // No carry, return the result
                }

                digits[i] = 0; // Reset to 0 and propagate the carry
            }

            Log.Array(digits);

            Log.LogMessage("If we exit the loop, it means there was a carry for all digits");
            int[] result = new int[digits.Length + 1];

            Log.LogMessage("Creating a new Array :");
            Log.Array(result);
            result[0] = 1; // Prepend 1 to the result
            Log.Array(result);
            return result;
        }
    }
}