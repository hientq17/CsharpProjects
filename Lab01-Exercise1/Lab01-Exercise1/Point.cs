using System;
namespace PRN292_Lab1
{
    public class Point
    {
        public float posX { get; set; }
        public float posY { get; set; }

        public Point() { }

        public Point(float posX, float posY)
        {
            this.posX = posX;
            this.posY = posY;
        }
    }
}
