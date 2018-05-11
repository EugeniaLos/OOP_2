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
        public Circle(Point start, Point end)
            : base(start, end)
        {

        }

        public override void Draw(Graphics drawSurface)
        {
            Pen pen = new Pen(Color.Black, 3);
            this.drawSurface = drawSurface;
            int sizeCircle = Math.Abs(start.X - end.X);
            if (end.X > start.X && end.Y > start.Y)
                 drawSurface.DrawEllipse(pen, start.X, start.Y, sizeCircle, sizeCircle);
            else 
                if (end.X > start.X && end.Y < start.Y)
                    drawSurface.DrawEllipse(pen, start.X, start.Y, sizeCircle, -sizeCircle);
                else 
                    if (end.X < start.X && end.Y > start.Y)
                        drawSurface.DrawEllipse(pen, start.X, start.Y, -sizeCircle, sizeCircle);
                    else 
                        if (end.X < start.X && end.Y < start.Y)
                            drawSurface.DrawEllipse(pen, start.X, start.Y, -sizeCircle, -sizeCircle);
        }
    }
}
