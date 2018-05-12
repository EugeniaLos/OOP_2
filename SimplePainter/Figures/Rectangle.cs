using System.Drawing;

namespace SimplePainter.Figures
{
    public class Rectangle:Figure
    {
        
        public Rectangle()
        {

        }

        public override void Draw(Graphics drawSurface)
        {
            Pen pen = new Pen(Color.Black, 3);
            drawSurface.DrawRectangle(pen, GetX(firstPoint, lastPoint), GetY(firstPoint, lastPoint), GetWidthShape(firstPoint, lastPoint), GetHightShape(firstPoint, lastPoint));
        }
    }
}
