using System;
using System.Drawing;

namespace ShapeDrawingSystem
{
    // Base class: Shape
    class Shape
    {
        public string Name { get; set; }
        public Color Color { get; set; }

        public virtual void Draw(Graphics graphics)
        {
            // Base implementation of drawing logic
            Console.WriteLine($"Drawing {Name} with color {Color.Name}");
        }
    }

    // Derived class: Circle
    class Circle : Shape
    {
        public int Radius { get; set; }

        public override void Draw(Graphics graphics)
        {
            // Custom implementation of drawing a circle
            base.Draw(graphics);
            graphics.DrawEllipse(new Pen(Color, 3), 0, 0, Radius * 2, Radius * 2);
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class: Square
    class Square : Shape
    {
        public int SideLength { get; set; }

        public override void Draw(Graphics graphics)
        {
            // Custom implementation of drawing a square
            base.Draw(graphics);
            graphics.DrawRectangle(new Pen(Color, 3), 0, 0, SideLength, SideLength);
        }

        public double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }

    // Derived class: Triangle
    class Triangle : Shape
    {
        public int BaseLength { get; set; }
        public int Height { get; set; }

        public override void Draw(Graphics graphics)
        {
            // Custom implementation of drawing a triangle
            base.Draw(graphics);
            Point[] points = { new Point(0, Height), new Point(BaseLength / 2, 0), new Point(BaseLength, Height) };
            graphics.DrawPolygon(new Pen(Color, 3), points);
        }

        public double CalculateArea()
        {
            return 0.5 * BaseLength * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create shape objects
            Circle circle = new Circle
            {
                Name = "Circle",
                Color = Color.Red,
                Radius = 50
            };

            Square square = new Square
            {
                Name = "Square",
                Color = Color.Blue,
                SideLength = 75
            };

            Triangle triangle = new Triangle
            {
                Name = "Triangle",
                Color = Color.Green,
                BaseLength = 100,
                Height = 50
            };

            // Draw shapes
            using (Bitmap bitmap = new Bitmap(500, 500))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    circle.Draw(graphics);
                    square.Draw(graphics);
                    triangle.Draw(graphics);
                }

                bitmap.Save("Shapes.png");
            }

            // Calculate areas
            double circleArea = circle.CalculateArea();
            double squareArea = square.CalculateArea();
            double triangleArea = triangle.CalculateArea();

            Console.WriteLine($"Circle area: {circleArea}");
            Console.WriteLine($"Square area: {squareArea}");
            Console.WriteLine($"Triangle area: {triangleArea}");
        }
    }
}
