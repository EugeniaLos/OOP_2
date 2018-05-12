using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePainter.Figures
{
    public class Circle : Ellipse
    {
        public Circle()
        {

        }

        public override void Draw(Graphics drawSurface)
        {
            Pen pen = new Pen(Color.Black, 3);
            
            if (this.lastPoint.X > firstPoint.X && lastPoint.Y > firstPoint.Y)
                 drawSurface.DrawEllipse(pen, firstPoint.X, firstPoint.Y, GetSizeShape(lastPoint, firstPoint), GetSizeShape(lastPoint, firstPoint));
            else 
                if (lastPoint.X > firstPoint.X && lastPoint.Y < firstPoint.Y)
                    drawSurface.DrawEllipse(pen, firstPoint.X, firstPoint.Y, GetSizeShape(lastPoint, firstPoint), -GetSizeShape(lastPoint, firstPoint));
                else 
                    if (lastPoint.X < firstPoint.X && lastPoint.Y > firstPoint.Y)
                        drawSurface.DrawEllipse(pen, firstPoint.X, firstPoint.Y, -GetSizeShape(lastPoint, firstPoint), GetSizeShape(lastPoint, firstPoint));
                    else 
                        if (lastPoint.X < firstPoint.X && lastPoint.Y < firstPoint.Y)
                            drawSurface.DrawEllipse(pen, firstPoint.X, firstPoint.Y, -GetSizeShape(lastPoint, firstPoint), -GetSizeShape(lastPoint, firstPoint));
        }
    }
}
