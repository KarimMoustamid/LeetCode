namespace Top_Interview_Questions.Easy.Strings.InProgress.Reverse_Integer
{
    using System.Security.Cryptography.X509Certificates;

    public static class Solution
    {
        public static int Reverse(int x)
        {
            int reversed = 0;

            while (x != 0)
            {
                int pop = x % 10;
                x = x / 10;

                // Check for overflow before updating the reversed number
                if (reversed > int.MaxValue / 10 || (reversed == int.MaxValue / 10 && pop > 7)) return 0;
                if (reversed < int.MinValue / 10 || (reversed == int.MinValue / 10 && pop < -8)) return 0;

                reversed = reversed * 10 + pop;
            }

            return reversed;
        }
    }
}