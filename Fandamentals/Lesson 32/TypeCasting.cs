namespace Fandamentals.Lesson_32
{
    public static class TypeCasting
    {
        // Implicit casting (no data loss, smaller type to larger type)
        public static void ImplicitCasting()
        {
            int integer = 5;
            double implicitCast = integer;
        }

        // Explicit casting (possible data loss, larger type to smaller type)
        public static void ExplicitCasting()
        {
            double doubleValue = 9.78;
            int explicitCast = (int) doubleValue;
        }

        // Using Convert class
        public static void ConvertStringToInt()
        {
            string str = "123";
            int convertedInt = Convert.ToInt32(str);
            // Convert handles null values and will throw System.ArgumentNullException for null.
            int parseInt = int.Parse(str);
            // Parse assumes the input is non-null and will throw System.ArgumentNullException if null.
        }

        // Using Parse method
        public static void ParseMethod()
        {
            string parseStr = "456";
            int parsedInt = int.Parse(parseStr);
        }

        // Using TryParse method
        public static void TryParseMethod()
        {
            string tryParseStr = "789";
            if (int.TryParse(tryParseStr, out int tryParsedInt))
            {
                // Successfully parsed
            }
        }

        // Boxing (value type to object type)
        public static void BoxingExample()
        {
            int boxValue = 10;
            object boxedValue = boxValue;
        }

        // Unboxing (object type to value type, requires explicit casting)
        public static void UnboxingExample()
        {
            object objValue = 15;
            int unboxedValue = (int) objValue;
        }

        // Casting between compatible reference types
        public class Animal
        {
        }

        public class Dog : Animal
        {
        }

        public static void ReferenceTypeCasting()
        {
            Dog dog = new Dog();
            Animal animal = dog; // Upcasting (implicit)
            Dog castedDog = (Dog) animal; // Downcasting (explicit)
        }
    }
}