using System.Collections.Generic;

namespace PRN292_Lab1
{
    public class Rectangle : Shape
    {
        public Rectangle(Point point1, Point point2, Point point3, Point point4)
            : base("Rectangle", point1)
        {
            Points.AddRange(new List<Point> { point2, point3, point4 });
        }

        public override void Show() =>
            System.Console.WriteLine(this.ToString());

        public override string ToString()
        {
            string ret = $"{Name}: ";
            Points.ForEach(p =>
            {
                ret += $"Point[{p.posX},{p.posY}] ";
            });
            return ret;
        }
    }
}