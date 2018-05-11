using System.Drawing;

namespace SimplePainter.Figures
{
    public class Ellipse : Figure
    {
        protected Point start, end;

        public Ellipse(Point start, Point end)
        {
            this.start = new Point(start.X, start.Y);
            this.end = new Point(end.X, end.Y);
        }

        public override void Draw(Graphics drawSurface)
        {
            Pen pen = new Pen(Color.Black, 3);
            this.drawSurface = drawSurface;
            this.drawSurface.DrawEllipse(pen, this.start.X, this.start.Y, this.end.X - this.start.X, this.end.Y - this.start.Y);
        }
    }
}
