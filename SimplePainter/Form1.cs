using SimplePainter.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SimplePainter
{
    public partial class mainForm : Form
    {
        List<Figure> shapesList = new List<Figure>();

        Graphics drawSurface;
        Bitmap btmFront;
        Graphics grFront;

        Boolean isMouseClick;

        public mainForm()
        {
            InitializeComponent();

            btmFront = new Bitmap(pictureDrawing.Width, pictureDrawing.Height);
            pictureDrawing.BackgroundImage = btmFront;

            grFront = Graphics.FromImage(btmFront);
            
            isMouseClick = false;
        }

        private void pictureDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseClick = true;
            shapesList.Last().setFirstPoint(new Point(e.X, e.Y));        
        }

        private void pictureDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureDrawing.Width, pictureDrawing.Height);
            Graphics g = Graphics.FromImage(bm);
            drawSurface = g;
            if (isMouseClick)
            {
                shapesList.Last().setLastPoint(new Point(e.X, e.Y));
                shapesList.Last().Draw(drawSurface);
                pictureDrawing.Image = bm;
            }
        }

        private void pictureDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseClick = false;
            Bitmap bm = new Bitmap(pictureDrawing.Width, pictureDrawing.Height);
            Graphics g = Graphics.FromImage(bm);
            drawSurface = g;
            shapesList.Last().Draw(drawSurface);
            grFront.DrawImage(bm, 0, 0);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            shapesList.Add(new Circle());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            shapesList.Add(new Ellipse());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            shapesList.Add(new Line());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            shapesList.Add(new Quadrangle());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            shapesList.Add(new Figures.Rectangle());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            shapesList.Add(new Figures.Square()); ;
        }
    }
}
