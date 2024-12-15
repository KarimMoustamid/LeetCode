namespace Fundamentals.Lesson_38
{
    public class ConstructorsDemo
    {
        // Default constructor (no parameters)
        public ConstructorsDemo()
        {
            Console.WriteLine("Default constructor called.");
        }

        // Parameterized constructor (with parameters)
        public ConstructorsDemo(string message)
        {
            Console.WriteLine($"Parameterized constructor called with message: {message}");
        }

        // Copy constructor (copying from another instance)
        public ConstructorsDemo(ConstructorsDemo other)
        {
            if (other != null)
            {
                Console.WriteLine("Copy constructor called.");
            }
            else
            {
                Console.WriteLine("Copy constructor called with null object.");
            }
        }

        // Static constructor
        static ConstructorsDemo()
        {
            Console.WriteLine("Static constructor called.");
        }

        // Private constructor (often used in singleton pattern)
        private ConstructorsDemo(bool isPrivate)
        {
            Console.WriteLine("Private constructor called.");
        }
    }
}