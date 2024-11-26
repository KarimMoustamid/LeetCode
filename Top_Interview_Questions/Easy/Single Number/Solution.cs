namespace Top_Interview_Questions.Easy.Single_Number
{
    public class Solution
    {
        public static int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach (var number in nums)
            {
               result ^= number;
            }
            return result;
        }
    }
}