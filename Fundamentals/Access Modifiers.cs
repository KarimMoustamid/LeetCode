namespace Fundamentals.Lesson_41
{
    public class Access_Modifiers
    {

        // Public: Accessible from anywhere.
        public static string PublicProperty { get; set; } = "I am public and accessible from everywhere!";

        // Private: Accessible only within this class.
        private static string PrivateProperty { get; } = "I am private and only accessible within this class.";

        // Protected: Accessible within this class and derived classes.
        protected static string ProtectedProperty { get; } = "I am protected and accessible within this class and its subclasses.";

        // Internal: Accessible within the same assembly.
        internal static string InternalProperty { get; set; } = "I am internal and accessible within the same project/assembly.";

        // Protected Internal: Accessible within the same assembly and from derived classes.
        protected internal static string ProtectedInternalProperty { get; set; } = "I am protected internal and accessible within the same assembly and my derived classes.";

        // Private Protected: Accessible within this class and derived classes in the same assembly.
        private protected static string PrivateProtectedProperty { get; } = "I am private protected and accessible only in this class and derived classes within the same assembly.";

        // A method to demonstrate access to these properties.
        public static void DisplayAccessModifiers()
        {
            Console.WriteLine(PublicProperty);
            Console.WriteLine(PrivateProperty); // Accessible here
            Console.WriteLine(ProtectedProperty); // Accessible here
            Console.WriteLine(InternalProperty); // Accessible here
            Console.WriteLine(ProtectedInternalProperty); // Accessible here
            Console.WriteLine(PrivateProtectedProperty); // Accessible here
        }
    }
}