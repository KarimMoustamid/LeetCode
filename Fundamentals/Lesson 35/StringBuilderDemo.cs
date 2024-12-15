namespace Fundamentals.Lesson35
{
    public static class StringBuilderDemo
    {
        public static void StringBuilderExamples()
        {
            // Create a new StringBuilder
            var sb = new System.Text.StringBuilder("Hello, World!");

            // Append text to the StringBuilder
            sb.Append(" This is an example of using StringBuilder.");

            // Insert text at a specific index
            sb.Insert(13, " C# developers,");

            // Replace a substring with another string
            sb.Replace("Hello", "Hi");

            // Remove a specific range of characters
            sb.Remove(27, 19);

            // Get the final string from the StringBuilder
            string result = sb.ToString();

            // Output the result
            Console.WriteLine(result);
        }

/*
Explanation:
1. A `StringBuilder` is used when you need to manipulate strings efficiently, especially inside loops or when performing many concatenations.
2. `Append` adds text to the end of the current `StringBuilder`.
3. `Insert` allows adding text at a specified index.
4. `Replace` finds a substring and replaces it with another string.
5. `Remove` deletes a range of characters starting at a specific index.
6. Finally, `ToString` converts the `StringBuilder` content to a standard string.

In this example:
- "Hello, World!" becomes "Hi, C# developers, World!" after `Insert` and `Replace`.
- The `Remove` eliminates unwanted characters for trimming purposes.
- The output will be: `Hi, C# developers! This is an example of using StringBuilder.`
*/
    }
}