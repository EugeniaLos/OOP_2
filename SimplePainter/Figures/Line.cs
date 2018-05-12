using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePainter.Figures
{
    public class Line : Figure
    {
        public Line()
        {
        }

        public override void Draw(Graphics drawSurface)
        {
            Pen pen = new Pen(Color.Black, 3);
            drawSurface.DrawLine(pen, firstPoint, lastPoint);
        }
    }
}
