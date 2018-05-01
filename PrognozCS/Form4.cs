using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PrognozCS
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            TopMost = true;
            InitializeComponent();
            Drawing();
        }

        public void Drawing()
        {
            //Создаем картинку
            Bitmap bpm = new Bitmap(pic.Width, pic.Height);
            //Импортируем созданную картинку
            Graphics mod = Graphics.FromImage(bpm);

            //Создание карандашей
            Pen PBlue = new Pen(Color.Blue, 2);
            Pen PRed = new Pen(Color.Red, 2);
            Pen PGreen = new Pen(Color.Green, 1);
            Pen PBlack = new Pen(Color.Black, 2);
            Pen PSilver = new Pen(Color.Silver, 400);
            Pen PTrans = new Pen(Color.Transparent, 130);
            SolidBrush BrB = new SolidBrush(Color.Beige);
            SolidBrush BrBr = new SolidBrush(Color.SkyBlue);
            SolidBrush BrBlack = new SolidBrush(Color.Black);
            SolidBrush BrRed = new SolidBrush(Color.DarkRed);
            Font Font = new Font(FontFamily.GenericSerif, 9, FontStyle.Regular);

            int xm = pic.Width;
            int ym = pic.Height - 38;
            int pix = 0;
            int dist = 0, G = 5;

            if (Form1.zoom == 11) pix = Form1.pix / 5;
            if (Form1.zoom == 12) pix = (int)(Form1.pix / 2.5);

            dist = G * pix;

            if (Form1.f == 360)
            {
                mod.FillEllipse(BrB, xm / 2 - dist, ym / 2 - dist, 2 * dist, 2 * dist);
                mod.DrawEllipse(PBlack, xm / 2 - dist, ym / 2 - dist, 2 * dist, 2 * dist);
            }
            else
            {
                switch (Form2.side)
                {
                    case "n":
                        if (Form1.f == 45)
                        {
                            mod.FillPie(BrB, xm / 2 - dist, ym / 2 - dist, 2 * dist, 2 * dist, 248, 45);
                            mod.DrawPie(PBlack, xm / 2 - dist, ym / 2 - dist, 2 * dist, 2 * dist, 248, 45);
                        }
                        if (Form1.f == 90)
                        {
                            mod.FillEllipse(BrBlack, 0, 0, xm, ym);
                        }
                        if (Form1.f == 180)
                        {
                            mod.FillEllipse(BrBlack, 0, 0, xm, ym);
                        }
                        break;
                    case "s":
                        if (Form1.f == 45)
                        {
                            mod.FillPie(BrB, xm / 2 - dist, ym / 2 - dist, 2 * dist, 2 * dist, 68, 45);
                            mod.DrawPie(PBlack, xm / 2 - dist, ym / 2 - dist, 2 * dist, 2 * dist, 68, 45);
                        }
                        if (Form1.f == 90)
                        {

                        }
                        if (Form1.f == 180)
                        {

                        }
                        break;
                    case "w":
                        if (Form1.f == 45)
                        {
                            mod.FillPie(BrB, xm / 2 - dist, ym / 2 - dist, 2 * dist, 2 * dist, 158, 45);
                            mod.DrawPie(PBlack, xm / 2 - dist, ym / 2 - dist, 2 * dist, 2 * dist, 158, 45);
                        }
                        if (Form1.f == 90)
                        {

                        }
                        if (Form1.f == 180)
                        {

                        }
                        break;
                    case "e":
                        if (Form1.f == 45)
                        {
                            mod.FillPie(BrB, xm / 2 - dist, ym / 2 - dist, 2 * dist, 2 * dist, 338, 45);
                            mod.DrawPie(PBlack, xm / 2 - dist, ym / 2 - dist, 2 * dist, 2 * dist, 338, 45);
                        }
                        if (Form1.f == 90)
                        {

                        }
                        if (Form1.f == 180)
                        {

                        }
                        break;
                    case "nw":
                        if (Form1.f == 45)
                        {

                        }
                        if (Form1.f == 90)
                        {

                        }
                        if (Form1.f == 180)
                        {

                        }
                        break;
                    case "ne":
                        if (Form1.f == 45)
                        {

                        }
                        if (Form1.f == 90)
                        {

                        }
                        if (Form1.f == 180)
                        {

                        }
                        break;
                    case "sw":
                        if (Form1.f == 45)
                        {

                        }
                        if (Form1.f == 90)
                        {

                        }
                        if (Form1.f == 180)
                        {

                        }
                        break;
                    case "se":
                        if (Form1.f == 45)
                        {

                        }
                        if (Form1.f == 90)
                        {

                        }
                        if (Form1.f == 180)
                        {

                        }
                        break;
                }
            }
            
            //Вывод картинки
            pic.Image = bpm;
        }

        private void pic_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
