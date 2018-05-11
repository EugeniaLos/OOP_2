using System.Windows.Forms;
using System.Drawing;

namespace SimplePainter.Figures
{
    public class Figure
    {
        protected Graphics drawSurface;

        public virtual void Draw(Graphics drawSurface)
        {

        }
    }
}
