using System.Drawing;

namespace SimplePainter.Figures
{
    public class Ellipse : Figure
    {
        public Ellipse()
        {
        }

        public override void Draw(Graphics drawSurface)
        {
            Pen pen = new Pen(Color.Black, 3);
            drawSurface.DrawEllipse(pen, this.firstPoint.X, this.firstPoint.Y, this.lastPoint.X - this.firstPoint.X, this.lastPoint.Y - this.firstPoint.Y);
        }
    }
}
