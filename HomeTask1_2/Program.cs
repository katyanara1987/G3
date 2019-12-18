using System;

namespace HomeTask1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application has started.");
            InputProcessor input = new InputProcessor();

            Console.WriteLine("Please enter circle radius.");
            double circleRadius = input.takeConsoleInput();
            Circle circle = new Circle(circleRadius);

            Console.WriteLine("Please enter square side.");
            double squareSide = input.takeConsoleInput();
            Square square = new Square(squareSide);

            Console.WriteLine("Press any button.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"\nCircle radius: {circle.Radius}");
            Console.WriteLine($"Circle area: {circle.Area}");

            Console.WriteLine($"\nSquare side: {square.Side}");
            Console.WriteLine($"Square area: {square.Area}\n");

            Console.WriteLine("circle.Diameter" + circle.Diameter);
            Console.WriteLine("square.Diagonal" + square.Diagonal);
            Console.WriteLine();

            if (ShapesComparator.CircleToSquareRatio(circle.Diameter, square.Side))
            {
                Console.WriteLine("Circle fits into Square");
                Console.WriteLine("Square does not fit into Circle");
            }
            else if (ShapesComparator.SquareToCircleRatio(circle.Diameter, square.Diagonal))
            {
                Console.WriteLine("Square fits into Circle");
                Console.WriteLine("Circle does not fit into Square");
            }
            else {
                Console.WriteLine("Circle and Square are intersected");
            }
            
            Console.WriteLine("\nApplication has finished.");
        }
    }
}
