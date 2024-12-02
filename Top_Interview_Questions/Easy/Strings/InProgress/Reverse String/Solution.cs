namespace Top_Interview_Questions.Easy.Strings.InProgress.Reverse_String
{
    using Helpers;

    public static class Solution
    {
        public static void ReverseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;

            Log.LogMessage($"Provided Array : {String.Join(',', s)}");
            while (left < right)
            {
                (s[left], s[right]) = (s[right], s[left]);
                left++;
                right--;
                Log.Array(s);
            }
        }
    }
}