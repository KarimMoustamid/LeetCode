namespace Fundamentals.Advance
{
    public static class ExtentionMethodsDemo
    {

        // Extension method to demonstrate adding functionality to a string
        public static string ReverseString(this string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Extension method to demonstrate adding functionality to an integer
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static void RunDemo()
        {
            // Example of extending a string
            string original = "ExtensionMethods";
            string reversed = original.ReverseString();
            Console.WriteLine($"Original: {original}, Reversed: {reversed}");

            // Example of extending an integer
            int number = 10;
            Console.WriteLine($"{number} is even: {number.IsEven()}");

            number = 7;
            Console.WriteLine($"{number} is even: {number.IsEven()}");
        }
    }
}