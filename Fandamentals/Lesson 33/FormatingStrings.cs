namespace Fandamentals.Lesson_33
{
    public static class FormatingStrings
    {
        public static string FormatWithStringInterpolation(string name, int age)
        {
            return $"Name: {name}, Age: {age}";
        }

        public static string FormatWithStringFormat(string name, int age)
        {
            return string.Format("Name: {0}, Age: {1}", name, age);
        }

        public static string FormatWithConcatenation(string name, int age)
        {
            return "Name: " + name + ", Age: " + age;
        }

        public static string FormatWithStringJoin(string[] elements, string separator = ", ")
        {
            return string.Join(separator, elements);
        }

        public static string FormatWithCompositeFormatting(int x, int y)
        {
            return string.Format("Coordinates: ({0}, {1})", x, y);
        }

        public static string FormatWithStringPadding(int number)
        {
            return number.ToString("D5"); // Pads the number with zeroes (e.g., 42 -> "00042")
        }
    }
}