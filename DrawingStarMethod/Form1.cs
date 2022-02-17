using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingStarMethod
{
    public partial class Form1 : Form
    {
        Point point1 = new Point(1, 33);
        Point point2 = new Point(33, 33);
        Point point3 = new Point(43, 1);
        Point point4 = new Point(54, 33);
        Point point5 = new Point(86, 33);
        Point point6 = new Point(60, 54);
        Point point7 = new Point(71, 84);
        Point point8 = new Point(43, 65);
        Point point9 = new Point(16, 84);
        Point point10 = new Point(27, 54);

        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            ///The following line of code demonstrates how to get input
            ///and convert it to a float value. Use this to help you in 
            ///Parts 2 - 4 where you need to get inputs from the 
            ///user and store them in float variables. This code is 
            ///not needed for Part 1.

            ///float size = Convert.ToSingle(sizeInput.Text); 

            //float size = Convert.ToSingle(sizeInput.Text);

            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black);

            PointF[] star = new PointF[10];
            star[0] = point1;
            star[1] = point2;
            star[2] = point3;
            star[3] = point4;
            star[4] = point5;
            star[5] = point6;
            star[6] = point7;
            star[7] = point8;
            star[8] = point9;
            star[9] = point10; 

            g.DrawPolygon(blackPen, star);
        }


        private void fillButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            PointF[] star = new PointF[10];
            star[0] = point1;
            star[1] = point2;
            star[2] = point3;
            star[3] = point4;
            star[4] = point5;
            star[5] = point6;
            star[6] = point7;
            star[7] = point8;
            star[8] = point9;
            star[9] = point10;

            g.FillPolygon(Brushes.Gold, star);
        }

        public void DrawStar(Pen starPen, float x, float y, float pixels)
        {
               
        }

    }
}
