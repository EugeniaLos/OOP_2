
using System.Drawing;

namespace SimplePainter.Figures
{
    public class Square : Figure
    {
        public Square()
        {

        }

        public override void Draw(Graphics drawSurface)
        {
            Pen pen = new Pen(Color.Black, 3);
            this.drawSurface = drawSurface;
            if (this.lastPoint.X > firstPoint.X && lastPoint.Y > firstPoint.Y)
                drawSurface.DrawRectangle(pen, firstPoint.X, firstPoint.Y, GetSizeShape(lastPoint, firstPoint), GetSizeShape(lastPoint, firstPoint));
            else
                if (lastPoint.X > firstPoint.X && lastPoint.Y < firstPoint.Y)
                drawSurface.DrawRectangle(pen, firstPoint.X, lastPoint.Y, GetSizeShape(lastPoint, firstPoint), GetSizeShape(lastPoint, firstPoint));
            else
                    if (lastPoint.X < firstPoint.X && lastPoint.Y > firstPoint.Y)
                drawSurface.DrawRectangle(pen, firstPoint.X - GetSizeShape(lastPoint, firstPoint), firstPoint.Y, GetSizeShape(lastPoint, firstPoint), GetSizeShape(lastPoint, firstPoint));
            else
                        if (lastPoint.X < firstPoint.X && lastPoint.Y < firstPoint.Y)
                            drawSurface.DrawRectangle(pen, firstPoint.X - GetSizeShape(lastPoint, firstPoint), firstPoint.Y - GetSizeShape(lastPoint, firstPoint), GetSizeShape(lastPoint, firstPoint), GetSizeShape(lastPoint, firstPoint));
        }
    }
}
