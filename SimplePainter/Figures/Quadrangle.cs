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

        public Quadrangle()
        {
            
        }

        public override void Draw(Graphics drawSurface)
        {
            Pen pen = new Pen(Color.Black, 3);
            Point g_1 = new Point((int)(firstPoint.X - 30), (int)(firstPoint.Y - 30));
            Point g_2 = new Point((int)(lastPoint.X + 30), (int)(lastPoint.Y + 30));
            Point g_3 = new Point((int)(firstPoint.X), (int)(firstPoint.Y));
            Point g_4 = new Point((int)(lastPoint.X), (int)(lastPoint.Y));


            points = new List<Point>() { g_3, g_1, g_4, g_2 };
            drawSurface.DrawPolygon(pen, points.ToArray());
        }
    }
}
