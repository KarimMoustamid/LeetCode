namespace InterviewPrep.Lesson1
{
    using Top_Interview_Questions.Helpers;

    public static class Casting_Boxing
    {
        public static void BasicImplicitCasting()
        {
            Log.LogMessageWithColor(
                "Implicit casting occurs automatically when a value of a smaller data type is assigned to a larger data type without data loss or explicit conversion.");

            int number = 42;
            double result = number;
            Console.WriteLine("int number = 42;");
            Console.WriteLine("double result = number;");
            Log.LogMessageWithColor($"Implicit Casting: {result}", ConsoleColor.DarkRed);
        }

        public static void ExplicitCasting()
        {
            Log.LogMessageWithColor(
                "Explicit casting is a manual type conversion using a cast operator (e.g., (targetType) value).Typically required when converting incompatible types or larger to smaller data types, with potential data loss.\n",
                ConsoleColor.DarkRed);

            double pi = 3.14159;
            int truncatedPi = (int) pi;
            int roundedPi = Convert.ToInt32(pi);
            Log.LogMessageWithColor("double pi = 3.14159;", ConsoleColor.DarkBlue);

            Console.WriteLine();
            Log.LogMessageWithColor($"int truncatedPi = pi; => {truncatedPi}\n", ConsoleColor.DarkBlue);
            Log.LogMessageWithColor(
                "This casts the double value of pi (e.g., 3.1415926) directly to an int.The fractional part of the number is simply truncated (cut off) without rounding.\n");


            Log.LogMessageWithColor($"int roundedPi = pi; => {roundedPi}\n", ConsoleColor.DarkBlue);
            Log.LogMessageWithColor(
                "This method rounds the double value to the nearest integer.but it might perform a little slower than a direct cast.\n");
        }

        public static void StringToIntConversion()
        {
            Log.LogMessageWithColor(
                "Converting a string containing a number to an int using int.Parse() and Convert.ToInt32().\n",
                ConsoleColor.DarkGreen);

            string numberString = "123";
            Log.LogMessageWithColor($"Input string: \"{numberString}\"", ConsoleColor.DarkYellow);

            // Using int.Parse()
            int parsedNumber = int.Parse(numberString);
            Log.LogMessageWithColor($"Using int.Parse(): {parsedNumber}", ConsoleColor.DarkBlue);

            // Using Convert.ToInt32()
            int convertedNumber = Convert.ToInt32(numberString);
            Log.LogMessageWithColor($"Using Convert.ToInt32(): {convertedNumber}", ConsoleColor.DarkMagenta);

            Console.WriteLine($"Parsed: {parsedNumber}, Converted: {convertedNumber}");
            Log.LogMessageWithColor($"Parsed: {parsedNumber}, Converted: {convertedNumber}\n", ConsoleColor.DarkCyan);
        }


        public static void PerformBoxingAndUnboxing()
        {
            Log.LogMessageWithColor(
                "Boxing is the process of converting a value type to an object type, while unboxing extracts the value type from the object.\n",
                ConsoleColor.Green);

            int value = 10;
            Log.LogMessageWithColor($"Original Value: {value}", ConsoleColor.Yellow);

            // Boxing
            object boxedValue = value;
            Log.LogMessageWithColor($"Boxed Value: {boxedValue}", ConsoleColor.Blue);

            // Unboxing
            int unboxedValue = (int) boxedValue;
            Log.LogMessageWithColor($"Unboxed Value: {unboxedValue}", ConsoleColor.Cyan);

            Console.WriteLine($"Boxed: {boxedValue}, Unboxed: {unboxedValue}");
        }


        public static void CheckTypeUsingIsOperator()
        {
            Log.LogMessageWithColor(
                "Using 'is' operator to check if a variable is of a specific type.\n",
                ConsoleColor.DarkGreen);

            object obj = "Hello, World!";
            Log.LogMessageWithColor($"Object value: {obj}\n", ConsoleColor.DarkYellow);

            if (obj is string)
            {
                Log.LogMessageWithColor("The object is a string.", ConsoleColor.DarkCyan);
                Console.WriteLine("The object is a string.");
            }
            else
            {
                Log.LogMessageWithColor("The object is NOT a string.", ConsoleColor.DarkRed);
                Console.WriteLine("The object is NOT a string.");
            }
        }


        public static void AttemptToCastUsingAsOperator()
        {
            Log.LogMessageWithColor(
                "Using 'as' operator to attempt casting an object to a specific type.\n",
                ConsoleColor.DarkGreen);

            object obj = "Hello, World!";
            Log.LogMessageWithColor($"Object value: {obj}\n", ConsoleColor.DarkYellow);

            string str = obj as string;

            if (str != null)
            {
                Log.LogMessageWithColor($"Casted using 'as': {str}\n", ConsoleColor.DarkCyan);
                Console.WriteLine($"Casted using 'as': {str}");
            }
            else
            {
                Log.LogMessageWithColor("The object could not be casted using 'as'.\n", ConsoleColor.DarkRed);
                Console.WriteLine("The object could not be casted using 'as'.");
            }
        }


        public static void HandleInvalidCasting()
        {
            Log.LogMessageWithColor(
                "Handling Exceptions in Casting: Demonstrating the use of try-catch block for invalid casting scenarios.\n",
                ConsoleColor.DarkGreen);

            object obj = "123";
            Log.LogMessageWithColor($"Object value for casting attempt: {obj}\n", ConsoleColor.DarkYellow);

            try
            {
                int invalidCast = (int) obj;
                Console.WriteLine(invalidCast);
                Log.LogMessageWithColor($"Successfully casted value: {invalidCast}", ConsoleColor.DarkBlue);
            }
            catch (InvalidCastException ex)
            {
                Log.LogMessageWithColor($"Exception encountered: {ex.Message}\n", ConsoleColor.DarkRed);
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }


    }
}