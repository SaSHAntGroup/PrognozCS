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
            Pen PTurq = new Pen(Color.Turquoise, 2);
            Pen PBlue = new Pen(Color.Blue, 2);
            Pen PBlueS = new Pen(Color.Blue, 1);
            Pen PRed = new Pen(Color.Red, 2);
            Pen PGreen = new Pen(Color.Green, 1);
            Pen PRedS = new Pen(Color.Red, 1);
            Pen PBlack = new Pen(Color.Black, 2);
            Pen PSilver = new Pen(Color.Silver, 400);
            Pen PTrans = new Pen(Color.Transparent, 130);
            SolidBrush BrB = new SolidBrush(Color.Beige);
            SolidBrush BrBr = new SolidBrush(Color.SkyBlue);
            SolidBrush BrBl = new SolidBrush(Color.Blue);
            SolidBrush BrBlack = new SolidBrush(Color.Black);
            SolidBrush BrSilver = new SolidBrush(Color.Silver);
            SolidBrush BrWhite = new SolidBrush(Color.White);
            SolidBrush BrRed = new SolidBrush(Color.DarkSalmon);
            Font Font = new Font(FontFamily.GenericSerif, 9, FontStyle.Regular);
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.BackwardDiagonal, Color.Aqua, Color.Silver);

            int xm = pic.Width;
            int ym = pic.Height - 38;
            int pix = 0;
            int dist = 0, G = 5;

            if (Form1.zoom == 11) pix = Form1.pix / 5;
            if (Form1.zoom == 12) pix = (int)(Form1.pix / 2.5);

            dist = G * pix;

            if (Form1.f == 360)
            {
                mod.FillEllipse(BrBlack, 0, 0, xm, ym);
            }
            else
            {
                switch (Form2.side)
                {
                    case "n":
                        if (Form1.f == 45)
                        {
                            mod.FillEllipse(BrB, xm / 2 - dist, ym / 2 - dist, 2 * dist, 2 * dist);
                            mod.DrawEllipse(PBlack, xm / 2 - dist, ym / 2 - dist, 2 * dist, 2 * dist);
                            mod.DrawLine(PBlack, xm / 2, ym / 2, xm / 2 - dist / 4, ym / 2 - dist + G / 2);
                            mod.DrawLine(PBlack, xm / 2, ym / 2, xm / 2 + dist / 4, ym / 2 - dist + G / 2);
                            mod.DrawLine(PSilver, xm / 2 + 118, ym + 100, xm / 2 + dist / 4 + 207, ym / 2 - dist + G / 2);
                            mod.DrawLine(PSilver, xm / 2 - 118, ym + 100, xm / 2 - dist / 4 - 207, ym / 2 - dist + G / 2);
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
                            mod.FillEllipse(BrB, xm / 2 - dist, ym / 2 - dist, 2 * dist, 2 * dist);
                            mod.DrawEllipse(PBlack, xm / 2 - dist, ym / 2 - dist, 2 * dist, 2 * dist);
                            mod.DrawLine(PBlack, xm / 2, ym / 2, xm / 2 - dist / 4, ym / 2 + dist + G / 2);
                            mod.DrawLine(PBlack, xm / 2, ym / 2, xm / 2 + dist / 4, ym / 2 + dist + G / 2);
                            //mod.DrawLine(PSilver, xm / 2 - dist / 4 - 207, ym / 2 - dist + G / 2, xm / 2 - 118, ym + 100);
                            //mod.DrawLine(PSilver, -118, ym - 100, xm / 2 - dist / 4 - 207, ym / 2 - dist + G / 2);
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
