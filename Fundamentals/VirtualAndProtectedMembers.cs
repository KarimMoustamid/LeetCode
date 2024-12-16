namespace Fundamentals
{
    public class VirtualAndProtectedMembers
    {
        public abstract class Shape
        {
            // Abstract method: Must be implemented by derived classes
            public abstract double GetArea();

            // Concrete method: Can be used directly by derived classes
            public void DisplayInfo()
            {
                Console.WriteLine("This is a shape.");
            }

            // Virtual method: Can be overridden by derived classes
            public virtual string GetDescription()
            {
                return "This is a generic shape.";
            }

            // Protected method: Can be accessed by derived classes
            protected void CommonShapeLogic()
            {
                Console.WriteLine("Executing common logic for shapes.");
            }

            // Example derived class showing usage of virtual and protected members
            public class Circle : Shape
            {
                private double _radius;

                public Circle(double radius)
                {
                    _radius = radius;
                }

                // Implementation of abstract method
                public override double GetArea()
                {
                    return Math.PI * _radius * _radius;
                }

                // Overriding the virtual method
                public override string GetDescription()
                {
                    return $"This is a circle with radius {_radius}.";
                }

                // Method demonstrating use of protected member
                public void ShowCommonLogic()
                {
                    CommonShapeLogic();
                }

            }

            public class Rectangle : Shape
            {
                private double _width;
                private double _height;

                public Rectangle(double width, double height)
                {
                    _width = width;
                    _height = height;
                }

                // Implementation of abstract method
                public override double GetArea()
                {
                    return _width * _height;
                }

                // Overriding the virtual method
                public override string GetDescription()
                {
                    return $"This is a rectangle with width {_width} and height {_height}.";
                }

                // Method demonstrating use of protected member
                public void ShowCommonLogic()
                {
                    CommonShapeLogic();
                }
            }
        }
    }
}