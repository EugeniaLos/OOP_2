using SimplePainter.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimplePainter
{
    enum TTools { RECTANGLE, CIRCLE, ELLIPSE, NONE, LINE, QUADRANGLE, SQUARE};
    public partial class mainForm : Form
    {
        Point startCoords = new Point(0, 0);
        Point endCoords = new Point(0, 0);

        Graphics drawSurface;
        Bitmap btmFront;
        Graphics grFront;

        Boolean isMouseClick;
        TTools currTool = TTools.NONE;

        public mainForm()
        {
            InitializeComponent();
            btmFront = new Bitmap(pictureDrawing.Width, pictureDrawing.Height);
            grFront = Graphics.FromImage(btmFront);
            pictureDrawing.BackgroundImage = btmFront;

            isMouseClick = false;
        }

        private void ToolDraw()
        {
            switch (currTool)
            {
                case TTools.QUADRANGLE:
                    Point point_3 = new Point(startCoords.X - 10, startCoords.Y - 10);
                    Point point_4 = new Point(startCoords.X + 10, startCoords.Y + 10);
                    Figures.Quadrangle quadrangle = new Figures.Quadrangle(startCoords, point_3, startCoords, point_4);
                    quadrangle.Draw(drawSurface);
                    break;
                case TTools.RECTANGLE:
                    Figures.Rectangle rectangle = new Figures.Rectangle(startCoords.X, startCoords.Y, endCoords.X, endCoords.Y);
                    rectangle.Draw(drawSurface);
                    break;
                case TTools.ELLIPSE:
                    Ellipse ellipse = new Ellipse(startCoords.X, startCoords.Y,  endCoords.X - startCoords.X, endCoords.X - startCoords.Y);
                    ellipse.Draw(drawSurface);
                    break;
                case TTools.LINE:
                    Line line = new Line(startCoords, endCoords);
                    line.Draw(drawSurface);
                    break;
                case TTools.CIRCLE:
                    Circle circle = new Circle(startCoords.X, startCoords.Y, endCoords.X - startCoords.X);
                    circle.Draw(drawSurface);
                    break;
                case TTools.SQUARE:
                    Square square= new Square(startCoords.X, startCoords.Y, endCoords.X - startCoords.X);
                    square.Draw(drawSurface);
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currTool = TTools.CIRCLE;
        }

        private void pictureDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            startCoords.X = e.X;
            startCoords.Y = e.Y;
            isMouseClick = true;
        }

        private void pictureDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureDrawing.Width, pictureDrawing.Height);
            Graphics g = Graphics.FromImage(bm);
            drawSurface = g;
            if (isMouseClick)
            {
                ToolDraw();
                pictureDrawing.Image = bm;
            }

            endCoords.X = e.X;
            endCoords.Y = e.Y;
        }

        private void pictureDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseClick = false;
            Bitmap bm = new Bitmap(pictureDrawing.Width, pictureDrawing.Height);
            Graphics g = Graphics.FromImage(bm);
            drawSurface = g;
            ToolDraw();
            grFront.DrawImage(bm, 0, 0);
        }
    }
}
