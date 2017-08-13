using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrognozCS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Pen black = new Pen(Color.Black);

        static int G = (int)Form1.G;

        System.Drawing.SolidBrush FillBlack = new System.Drawing.SolidBrush(Color.Black);

        Rectangle rect = new Rectangle(200, 200, 80, 70);// город
        Rectangle circle = new Rectangle(200, 200, G, G);// область поражения
        public void Form3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(black, rect);
            g.DrawEllipse(black, circle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
