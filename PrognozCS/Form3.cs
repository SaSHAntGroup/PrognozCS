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
            Model();
        }

        public void Model()
        {
            //Создаем картинку
            Bitmap bpm = new Bitmap(picture.Width, picture.Height);
            //Импортируем созданную картинку
            Graphics Mod = Graphics.FromImage(bpm);

            //Создание карандашей
            Pen PTurq = new Pen(Color.Turquoise, 2);
            Pen PBlue = new Pen(Color.Blue, 2);
            Pen PBlack = new Pen(Color.Black, 2);
            Pen PSilver = new Pen(Color.Silver, 2);
            SolidBrush BrB = new SolidBrush(Color.Beige);
            SolidBrush BrBl = new SolidBrush(Color.Blue);
            SolidBrush BrBlack = new SolidBrush(Color.Black);
            SolidBrush BrSilver = new SolidBrush(Color.Silver);

            //Указатели
            string TextGlub = Form1.G.ToString() + " км";
            string TextDistance = Form1.X.ToString() + " км";

            //Переменные
            int border = 26;//Расстояние от верхней и нижней границы формы
            int point = 6;//Очаг поражения
            int pointG = 200;//Центр населенного пункта
            int Se = 260;//Площадь поражения
            int Ge = 130;//Расстояния от края глубины поражения до очага
            int Ges = 159;//Расстояние от верха и края формы до очага поражения
            PointF[] p = new PointF[5];
            p[0] = new Point(60, 178);
            p[1] = new Point(130, 196);
            p[2] = new Point(136, 250);
            p[3] = new Point(50, 240);
            p[4] = new Point(40, 197);

            //Масштабирование значений на рисунок
            int glubina = (int)Form1.G;
            int dist = (int)Form1.X;

            Form1.f = 180;//////////////////////
            //Рисование
            if (Form1.f == 360)
            {
                Mod.FillEllipse(BrB, border, border, Se, Se);
                Mod.FillEllipse(BrBl, Ges - 3, Ges - 3, point, point);

                Mod.DrawLine(PBlue, Ges, Ges, Ges - Ge, Ges);
                Mod.DrawString(TextGlub, Font, BrBlack, Ges - 63, Ges - 16);

                Mod.FillPolygon(BrSilver, p);
                Mod.DrawPolygon(PBlack, p);
                Mod.DrawLine(PBlue, pointG - 107, pointG + 23, Ges, Ges);
                Mod.FillEllipse(BrBl, pointG - 110, pointG + 20, point, point);
                Mod.DrawString(TextDistance, Font, BrBlack, Ge - 27, pointG - 30);

                Mod.DrawEllipse(PTurq, border, border, Se, Se);
            }
            if (Form1.f == 180)
            {
                Mod.FillEllipse(BrB, border, border, Se, Se);
                Mod.FillRectangle(BrSilver, Ges - 2, border, Se, Se);
                Mod.DrawLine(PBlue, Ges - 3, border, Ges - 3, Se + 27);
                Mod.FillEllipse(BrBl, Ges - 6, Ges - 3, point, point);

                Mod.DrawLine(PBlue, Ges - 3, Ges, Ges - Ge - 3, Ges);
                Mod.DrawString(TextGlub, Font, BrBlack, Ges - 103, Ges - 16);

                Mod.FillPolygon(BrSilver, p);
                Mod.DrawPolygon(PBlack, p);
                Mod.DrawLine(PBlue, pointG - 107, pointG + 22, Ges - 3, Ges);
                Mod.FillEllipse(BrBl, pointG - 110, pointG + 20, point, point);
                Mod.DrawString(TextDistance, Font, BrBlack, Ge - 27, pointG - 30);

                Mod.DrawArc(PBlue, border, border, Se, Se, 90, 180);
            }
            if ((Form1.f == 90) || (Form1.f == 45))
            {

            }
            //Вывод картинки
            picture.Image = bpm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
