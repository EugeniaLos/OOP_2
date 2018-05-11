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
        private List<Point> points;

        public Line(Point point1, Point point2)
        {
            points = new List<Point> { point1, point2 };
        }

        public override void Draw(Graphics drawSurface)
        {
            Pen pen = new Pen(Color.Black, 3);
            this.drawSurface = drawSurface;
            this.drawSurface.DrawLine(pen, points[0], points[1]);
        }
    }
}
