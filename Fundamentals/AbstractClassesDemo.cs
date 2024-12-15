namespace Fundamentals
{
    public class AbstractClassesDemo
    {

        // This class provides an example to explain abstract classes in C#.
        // Abstract classes serve as a blueprint for other classes. They cannot be instantiated
        // directly and often contain both abstract members (methods, properties, etc.)
        // that must be implemented by derived classes, and concrete members that can be inherited.

        // Let's demonstrate:
        // Define an abstract class called Shape.
        public abstract class Shape
        {
            // Abstract method: Must be implemented by derived classes
            public abstract double GetArea();

            // Concrete method: Can be used directly by derived classes
            public void DisplayInfo()
            {
                Console.WriteLine("This is a shape.");
            }
        }

        // Circle is a derived class of Shape that implements the GetArea method.
        public class Circle : Shape
        {
            private readonly double _radius;

            // Constructor for Circle
            public Circle(double radius)
            {
                _radius = radius;
            }

            // Implements the abstract method from Shape
            public override double GetArea()
            {
                return Math.PI * _radius * _radius;
            }
        }

        // Rectangle is another derived class of Shape that implements the GetArea method.
        public class Rectangle : Shape
        {
            private readonly double _width;
            private readonly double _height;

            // Constructor for Rectangle
            public Rectangle(double width, double height)
            {
                _width = width;
                _height = height;
            }

            // Implements the abstract method from Shape
            public override double GetArea()
            {
                return _width * _height;
            }
        }

        // Example usage
        public static void Main()
        {
            // Instantiate derived classes
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            // Work with the derived classes
            circle.DisplayInfo();
            Console.WriteLine($"Circle Area: {circle.GetArea()}");

            rectangle.DisplayInfo();
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
        }
    }
}