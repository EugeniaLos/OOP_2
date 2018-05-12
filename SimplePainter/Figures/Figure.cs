using System.Windows.Forms;
using System.Drawing;
using System;

namespace SimplePainter.Figures
{
    public class Figure
    {
        
        public Point firstPoint;
        public Point lastPoint;

        public void setFirstPoint(Point point)
        {
            firstPoint = point;
        }
        public void setLastPoint(Point point)
        {
            lastPoint = point;
        }

        public virtual void Draw(Graphics drawSurface){}

        protected static float GetWidthShape(Point first, Point second)
        {
            return Math.Abs(first.X - second.X);
                    }

        protected static float GetHightShape(Point first, Point second)
        {
            return Math.Abs(first.Y - second.Y);
        }

        protected static float GetSizeShape(Point first, Point second)
        {
            return (GetWidthShape(first, second) < GetHightShape(first, second) ? GetWidthShape(first, second) : GetHightShape(first, second));
        }

        protected static float GetX(Point first, Point second)
        {
            return (first.X > second.X) ? second.X : first.X;
        }

        protected static float GetY(Point first, Point second)
        {
            return (first.Y > second.Y) ? second.Y : first.Y;
        }
    }
}
