using System.Linq;

namespace PRN292_Lab1
{
    public class Circle : Shape
    {
        private int Radius { get; set; }

        public Circle(Point center, int radius)
            : base("Circle", center)
        {
            Radius = radius;
        }

        public override void Show()
        {
            System.Console.WriteLine(this.ToString());
        }

        public void Move(Point point, int x, int y)
        {
            if (Points.Contains(point))
            {
                point.posX += x;
                point.posY += y;
            }
        }

        public override string ToString()
        {
            Point p = Points.FirstOrDefault();
            string ret = $"{Name}: Point[{p.posX},{p.posY}], Radius: {Radius}";
            return ret;
        }
    }
}