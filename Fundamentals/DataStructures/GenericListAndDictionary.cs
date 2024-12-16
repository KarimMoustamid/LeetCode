namespace Fundamentals.DataStructures
{
    public static class GenericListAndDictionary
    {
        public static void DemoGenericList()
        {
            // Example 1: Using a generic List<T>
            var numbers = new List<int> {1, 2, 3, 4, 5};
            Console.WriteLine("Generic List Example:");
            Console.WriteLine("Initial List:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Add(6); // Adding an element
            numbers.Remove(2); // Removing an element

            Console.WriteLine("Modified List:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void DemoGenericDictionary()
        {
            // Example 2: Using a generic Dictionary<TKey, TValue>
            var studentGrades = new Dictionary<string, char>
            {
                {"Alice", 'A'},
                {"Bob", 'B'},
                {"Charlie", 'C'}
            };

            Console.WriteLine("\nGeneric Dictionary Example:");
            Console.WriteLine("Initial Dictionary:");
            foreach (var kvp in studentGrades)
            {
                Console.WriteLine($"Student: {kvp.Key}, Grade: {kvp.Value}");
            }

            studentGrades["Alice"] = 'A'; // Updating a value
            studentGrades.Add("Diana", 'A'); // Adding a new key-value pair

            Console.WriteLine("Modified Dictionary:");
            foreach (var kvp in studentGrades)
            {
                Console.WriteLine($"Student: {kvp.Key}, Grade: {kvp.Value}");
            }
        }
    }
}