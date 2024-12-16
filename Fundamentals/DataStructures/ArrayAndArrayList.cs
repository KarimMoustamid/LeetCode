namespace Fundamentals.DataStructures
{
    public static class ArrayAndArrayList
    {
        /// <summary>
        /// Demonstrates the use of arrays with examples and explanations.
        /// </summary>
        public static void DemoArrays()
        {
            // Example 1: Create and initialize an array
            int[] numbers = {1, 2, 3, 4, 5};
            Console.WriteLine("Array Elements:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Example 2: Access and modify array elements
            Console.WriteLine("\nAccessing and Modifying Array Elements:");
            Console.WriteLine($"Before modification: numbers[0] = {numbers[0]}");
            numbers[0] = 10; // Modifying the first element
            Console.WriteLine($"After modification: numbers[0] = {numbers[0]}");

            // Example 3: Multi-dimensional array
            int[,] matrix = new int[2, 2] {{1, 2}, {3, 4}};
            Console.WriteLine("\nMulti-dimensional Array:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Demonstrates the use of ArrayList with examples and explanations.
        /// </summary>
        public static void DemoArrayList()
        {
            // Example 1: Create an ArrayList and add elements
            var arrayList = new System.Collections.ArrayList();
            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(3.14);
            Console.WriteLine("\nArrayList Elements:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            // Example 2: Access and modify ArrayList elements
            Console.WriteLine("\nAccessing and Modifying ArrayList Elements:");
            Console.WriteLine($"Before modification: arrayList[1] = {arrayList[1]}");
            arrayList[1] = "World"; // Modifying the second element
            Console.WriteLine($"After modification: arrayList[1] = {arrayList[1]}");

            // Example 3: Removing elements
            Console.WriteLine("\nRemoving Elements from ArrayList:");
            arrayList.RemoveAt(0); // Removing the first element
            Console.WriteLine("ArrayList after removal:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }


        /// <summary>
        /// Demonstrates casting types when using an ArrayList.
        /// </summary>
        public static void DemoArrayListCasting()
        {
            // Example: Casting types in ArrayList
            var arrayList = new System.Collections.ArrayList();
            arrayList.Add(42); // Adding an integer
            arrayList.Add("Sample String"); // Adding a string
            arrayList.Add(12.34); // Adding a double

            Console.WriteLine("\nCasting Types in ArrayList:");
            foreach (var item in arrayList)
            {
                if (item is int intValue)
                {
                    Console.WriteLine($"Integer value: {intValue}");
                }
                else if (item is string stringValue)
                {
                    Console.WriteLine($"String value: {stringValue}");
                }
                else if (item is double doubleValue)
                {
                    Console.WriteLine($"Double value: {doubleValue}");
                }
                else
                {
                    Console.WriteLine($"Other type: {item}");
                }
            }
        }
    }
}