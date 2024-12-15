namespace Fundamentals.Lesson_34
{
    public static class StringSplitAndJoin
    {
        public static string[] SplitStringByDelimiter(string input, char delimiter)
        {
            return input.Split(delimiter);
        }

        public static string JoinStringsWithDelimiter(string[] inputArray, string delimiter)
        {
            return string.Join(delimiter, inputArray);
        }
    }
}