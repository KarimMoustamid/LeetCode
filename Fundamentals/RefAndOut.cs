namespace Fundamentals
{
    public class RefAndOut
    {
        // Example of using ref keyword
        public void IncrementRefExample(ref int number)
        {
            // The ref keyword allows a method to modify the value of the argument.
            number++; // Increment the number
        }

        // Example of using out keyword
        public void TryParseExample(string input, out int result)
        {
            // The out keyword allows a method to initialize the value of the argument,
            // even if it doesn’t have a value when passed in.
            // Standard example: Simulating parsing
            if (int.TryParse(input, out int parsedValue))
            {
                result = parsedValue; // Assign parsed value if successful
            }
            else
            {
                result = -1; // Assign a default value if parsing fails
            }
        }

        // Explanation:
        // ref: The variable must be initialized before being passed to the method. The method can modify the value, and the changes will be reflected outside the method.
        // out: The variable does not need to be initialized before being passed to the method. The method must assign a value to it before the method exits.
        // Use cases:
        // - ref is useful when you want to pass a variable by reference and modify its value.
        // - out is useful when a method needs to return multiple values or needs to provide output values not known beforehand.
    }
}