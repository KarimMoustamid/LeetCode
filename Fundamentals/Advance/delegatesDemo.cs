namespace Fundamentals.Advance
{
    public class delegatesDemo
    {
        // This section demonstrates the use of delegates in C#

        // Delegate declaration
        // A delegate is a type that represents references to methods with a specific parameter list and return type.
        public delegate int MathOperation(int a, int b);

        // Example of methods that match the MathOperation delegate signature
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        // Example of using a delegate
        public void DemoMathOperation()
        {
            // Assign the Add method to the delegate instance
            MathOperation operation = Add;
            Console.WriteLine("Add(5, 3): " + operation(5, 3));

            // Change the method the delegate points to, now to Subtract
            operation = Subtract;
            Console.WriteLine("Subtract(5, 3): " + operation(5, 3));
        }

        // Example of using a delegate as a method parameter
        public void PerformOperation(int a, int b, MathOperation operation)
        {
            Console.WriteLine("Performing operation result: " + operation(a, b));
        }

        public void DemoDelegateAsParameter()
        {
            // Pass the Add method as a delegate instance
            PerformOperation(10, 20, Add);

            // Pass the Subtract method as a delegate instance
            PerformOperation(10, 20, Subtract);
        }

        // Example of using Action and Func delegates
        public void DemoActionAndFunc()
        {
            // Action delegate (no return value)
            Action<string> printMessage = message => Console.WriteLine("Message: " + message);
            printMessage("Hello with Action!");

            // Func delegate (returns a value)
            Func<int, int, int> multiply = (x, y) => x * y;
            Console.WriteLine("Multiply(3, 4) using Func: " + multiply(3, 4));
        }

        // Example to showcase multiple delegates (multicast)
        public void DemoMulticastDelegates()
        {
            Action displayMessages = () => Console.WriteLine("Message 1");
            displayMessages += () => Console.WriteLine("Message 2");
            displayMessages += () => Console.WriteLine("Message 3");

            // Invoking multicast delegate, all methods are called
            displayMessages();
        }

        /* Explanation:
         * - A delegate works like a pointer to a method and can dynamically associate with different methods at runtime.
         * - Func<> is a built-in generic delegate for methods that return a value.
         * - Action<> is a built-in generic delegate for methods that do not return a value.
         * - Multicast delegates allow a single delegate to reference multiple methods, invoking them in order.
         */
    }
}