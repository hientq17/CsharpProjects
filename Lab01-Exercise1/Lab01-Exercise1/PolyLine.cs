using System;
using System.Collections.Generic;

namespace PRN292_Lab1
{
    public class PolyLine : Shape
    {
        public PolyLine() : base("PolyLine") { }

        public PolyLine(Point startPoint)
            : base("PolyLine", startPoint) { }

        public override void Show() =>
            System.Console.WriteLine(this.ToString());

        public void AddPoint(Point point)
        {
            Points.Add(point);
        }

        public void AddRangePoint(IEnumerable<Point> points)
        {
            Points.AddRange(points);
        }

        public void Move(Point point, int xAsis, int yAsis)
        {
            if (Points.Contains(point))
            {

                point.posX += xAsis;
                point.posY += yAsis;
            }
        }

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
