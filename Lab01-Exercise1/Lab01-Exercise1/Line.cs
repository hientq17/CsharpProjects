namespace PRN292_Lab1
{
    public class Line : Shape
    {
        public Line(Point point1, Point point2)
            : base("Line", point1)
        {
            Points.Add(point2);
        }

        public override void Show() =>
            System.Console.WriteLine(this.ToString());

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
            string ret = $"{Name}: ";
            Points.ForEach(p =>
            {
                ret += $"Point[{p.posX},{p.posY}] ";
            });
            return ret;
        }
    }
}