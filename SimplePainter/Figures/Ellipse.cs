using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePainter.Figures
{
    public class Ellipse : Figure
    {
        private int x, y, height, width;

        public Ellipse(int x, int y, int height, int width)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
        }

        public override void Draw(Graphics drawSurface)
        {
            Pen pen = new Pen(Color.Black, 3);
            this.drawSurface = drawSurface;
            this.drawSurface.DrawEllipse(pen, x, y, height, width);
        }
    }
}
