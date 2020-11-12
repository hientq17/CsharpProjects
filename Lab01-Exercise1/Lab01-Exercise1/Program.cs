using System;
using System.Collections.Generic;

namespace PRN292_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Line();
            Console.WriteLine("-----------------------------------------------");
            Circle();
            Console.WriteLine("-----------------------------------------------");
            Rectangle();
            Console.WriteLine("-----------------------------------------------");
            PolyLine();
            Console.WriteLine("-----------------------------------------------");
        }

        static void Shape(Shape shape)
        {
            Console.WriteLine("Before move:");
            shape.Show();
            shape.Move(5, 3);
            Console.WriteLine("After move:");
            shape.Show();
        }

        static void Line()
        {
            int x, y;
            Console.WriteLine("Line: ");
            System.Console.Write("  Point 1: x = ");
            x = int.Parse(Console.ReadLine());
            System.Console.Write("  Point 1: y = ");
            y = int.Parse(Console.ReadLine());
            var point1 = new Point(x, y);
            System.Console.Write("  Point 2: x = ");
            x = int.Parse(Console.ReadLine());
            System.Console.Write("  Point 2: y = ");
            y = int.Parse(Console.ReadLine());
            var point2 = new Point(x, y);
            Line line = new Line(point1, point2);
            Shape(line);
        }

        static void Circle()
        {
            int x, y;
            Console.WriteLine("Circle ");
            System.Console.Write("  Center point: x = ");
            x = int.Parse(Console.ReadLine());
            System.Console.Write("  Center point: y = ");
            y = int.Parse(Console.ReadLine());
            var center = new Point(x, y);
            System.Console.Write("  Radius = ");
            x = int.Parse(Console.ReadLine());
            Circle circle = new Circle(center, radius: x);
            Shape(circle);
        }

        static void Rectangle()
        {
            int x, y;

            Console.WriteLine("Rectangle ");
            System.Console.Write("  Point 1: x = ");
            x = int.Parse(Console.ReadLine());
            System.Console.Write("  Point 1: y =");
            y = int.Parse(Console.ReadLine());
            var point1 = new Point(x, y);
            System.Console.Write("  Point 2: x = ");
            x = int.Parse(Console.ReadLine());
            System.Console.Write("  Point 2: y =");
            y = int.Parse(Console.ReadLine());
            var point2 = new Point(x, y);
            System.Console.Write("  Point 3: x = ");
            x = int.Parse(Console.ReadLine());
            System.Console.Write("  Point 3: y =");
            y = int.Parse(Console.ReadLine());
            var point3 = new Point(x, y);
            System.Console.Write("  Point 4: x = ");
            x = int.Parse(Console.ReadLine());
            System.Console.Write("  Point 4: y = ");
            y = int.Parse(Console.ReadLine());
            var point4 = new Point(x, y);
            var rectangle = new Rectangle(point1, point2, point3, point4);
            Shape(rectangle);
        }

        static void PolyLine()
        {
            var polyLine = new PolyLine();

            polyLine.AddPoint(new Point
            {
                posX = 3,
                posY = 3
            });

            polyLine.AddRangePoint(
                new List<Point> {
                    new Point(posX: 1, posY: 2),
                    new Point(posX: 3, posY: 6),
                    new Point(posX: 9, posY: 4),
                    new Point(posX: 5, posY: 7),
                    new Point(posX: 6, posY: 1),
                });

            Shape(polyLine);
        }
    }
}
