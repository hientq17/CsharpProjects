using System.Collections.Generic;

namespace PRN292_Lab1
{
    public abstract class Shape
    {
        private List<Point> points;

        protected List<Point> Points
        {
            get
            {
                return points ??= new List<Point>();
            }
        }

        public string Name { get; set; } = "Shape";

        public Shape(string name)
        {
            Name = name;
        }

        public Shape(string name, Point point) : this(name)
        {
            Points.Add(point);
        }

        public abstract void Show();

        public virtual void Move(int x, int y)
        {
            Points.ForEach(p =>
            {
                p.posX += x;
                p.posY += y;
            });
        }
    }
}