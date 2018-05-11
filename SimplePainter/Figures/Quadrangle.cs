using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePainter.Figures
{
    public class Quadrangle : Figure
    {
        private List<Point> points;

        public Quadrangle(Point point1, Point point2, Point point3, Point point4)
        {
            points = new List<Point>() { point1, point2, point3, point4 };
        }

        public override void Draw(Graphics drawSurface)
        {
            Pen pen = new Pen(Color.Black, 3);
            this.drawSurface = drawSurface;
            this.drawSurface.DrawPolygon(pen, points.ToArray());
        }
    }
}
