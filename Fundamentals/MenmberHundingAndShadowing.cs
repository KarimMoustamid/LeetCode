namespace Fundamentals
{
// This namespace contains classes demonstrating member hiding and shadowing
    namespace Fundamentals
    {
        public class MenmberHundingAndShadowing
        {
            // Circle class inherits from the Shape abstract class
            public class Circle : AbstractClassesDemo.Shape
            {
                public double Radius { get; set; }

                public Circle(double radius)
                {
                    Radius = radius;
                }

                // Override the abstract method from the base Shape class
                // This method calculates the area of the circle
                public override double GetArea()
                {
                    return Math.PI * Radius * Radius;
                }

                // This method hides the DisplayInfo method from the base Shape class
                // The "new" keyword explicitly specifies that this is a new implementation
                public new void DisplayInfo()
                {
                    Console.WriteLine($"This is a circle with a radius of {Radius}.");
                }
            }

            // Square class inherits from the Shape abstract class
            public class Square : AbstractClassesDemo.Shape
            {
                public double SideLength { get; set; }

                public Square(double sideLength)
                {
                    SideLength = sideLength;
                }

                // Override the abstract method from the base Shape class
                // This method computes the area of the square
                public override double GetArea()
                {
                    return SideLength * SideLength;
                }

                // This method demonstrates shadowing by creating a method with the same name,
                // but it takes an additional parameter.
                // This is not an override, but instead a new method unrelated to the base method.
                public void DisplayInfo(string additionalInfo)
                {
                    Console.WriteLine($"This is a square with a side length of {SideLength}. Additional info: {additionalInfo}");
                }
            }
        }
    }
}