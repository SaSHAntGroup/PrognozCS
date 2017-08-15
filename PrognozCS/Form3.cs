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
            Pen PBlack = new Pen(Color.Black, 1);
            Pen PSilver = new Pen(Color.Silver, 1);
            Pen PSilverB = new Pen(Color.Silver, 100);
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
            int Se = 260;//Площадь поражения
            int r = 130;//Расстояния от края глубины поражения до очага
            int O = 156;//Расстояние от верха и края формы до очага поражения
            double S = 15;

            //Масштабирование значений на рисунок
            double Mas = r / Form1.G;
            double distance = Form1.X * Mas;
            double Plosh = Mas * S;

            //Многоугольник (населеная местность)
            //PointF[] p = new PointF[5];
            //p[0] = new Point( 1, 1);
            //p[1] = new Point( 2, 2);
            //p[2] = new Point( 3, 3);
            //p[3] = new Point( 4, 4);
            //p[4] = new Point( 5, 5);
            
            Form1.f = 180;//////////////////////
            //Рисование
            if (Form1.f == 360)
            {
                distance = distance * 5;
                Mod.FillEllipse(BrB, border, border, Se, Se);//Заполнение зоны поражения
                Mod.FillEllipse(BrBl, O - 3, O - 3, point, point);//Очаг поражения (центр. точка)

                Mod.DrawLine(PBlue, O, O, O + r - 10, O + 50);//Линия глубины

                if (Form1.X > 0)
                {
                    Mod.DrawLine(PBlue, O, O, O + (int)distance - 15, 
                        O - (int)distance / 3 + (int)Plosh / 2 - 1);//Линия расстояния до н/п
                    Mod.FillEllipse(BrSilver, O + (int)distance - border, 
                        O - (int)distance / 3, 30, 30);//Заполнение площади н/п
                    Mod.DrawEllipse(PBlack, O + (int)distance - border, 
                        O - (int)distance / 3, 30, 30);//Обводка н/п
                    //Mod.FillPolygon(BrSilver, p);//Заполнение площади н/п
                    //Mod.DrawPolygon(PBlack, p);//Обводка н/п
                    Mod.DrawString(TextDistance, Font, BrBlack, (int)distance + O / 2, 
                        O - (int)distance / 3 + 10);//Текст расстояния до н/п
                }

                Mod.DrawString(TextGlub, Font, BrBlack, O + 55, O + 36);//Текст глубины
                Mod.DrawEllipse(PTurq, border, border, Se, Se);//Круговая обводка
            }
            if (Form1.f == 180)
            {
                distance = distance * 5;
                Mod.FillEllipse(BrB, border, border, Se, Se);//Заполнение зоны поражения
                Mod.FillRectangle(BrSilver, 0, border, O, Se);//Отрезающий квадрат, для визуала
                Mod.DrawLine(PTurq, O, border, O, Se + 27);//Отрезающая линия, для визуала
                Mod.FillEllipse(BrBl, O - 4, O - 3, point, point);//Очаг поражения (центр. точка)

                Mod.DrawLine(PBlue, O, O, O + r - 10, O + 50);//Линия глубины

                if (Form1.X > 0)
                {
                    Mod.DrawLine(PBlue, O, O, O + (int)distance, 
                        O - (int)distance / 3 + (int)Plosh / 2 - 1);//Линия расстояния до н/п
                    Mod.FillEllipse(BrSilver, O + (int)distance - border, 
                        O - (int)distance / 3, (int)Plosh, (int)Plosh);//Заполнение площади н/п
                    Mod.DrawEllipse(PBlack, O + (int)distance - border, 
                        O - (int)distance / 3, (int)Plosh, (int)Plosh);//Обводка н/п
                    //Mod.FillPolygon(BrSilver, p);//Заполнение площади н/п
                    //Mod.DrawPolygon(PBlack, p);//Обводка н/п
                    Mod.DrawString(TextDistance, Font, BrBlack, (int)distance / 2 + O - (float)Mas * 15,
                        O - (int)distance / 3 + (float)Mas * 2);//Текст расстояния до н/п
                }

                Mod.DrawString(TextGlub, Font, BrBlack, O + 55, O + 36);//Текст глубины
                Mod.DrawArc(PTurq, border, border, Se, Se, 270, 180);//Дуговая обводка
            }
            if (Form1.f == 90)
            {
                distance = distance * 10;
                Mod.FillEllipse(BrB, border, border, Se, Se);//Заполнение зоны поражения
                Mod.DrawLine(PSilverB, border - 20, O - 45, Se, border - 22);//Отрезающая линия, для визуала
                Mod.DrawLine(PSilverB, border - 20, O + 45, Se, Se + 48);//Отрезающая линия, для визуала 2
                Mod.DrawLine(PTurq, border, O, O + 93, O - 92);//Отрезающая линия, для визуала 3
                Mod.DrawLine(PTurq, border, O, O + 93, O + 92);//Отрезающая линия, для визуала 4
                Mod.FillEllipse(BrBl, border - 4, O - 4, point + 1, point + 1);//Очаг поражения (центр. точка)

                Mod.DrawLine(PBlue, border + 4, O - 1, Se + 21, O + 35);//Линия глубины

                if (Form1.X > 0)
                {
                    Mod.DrawLine(PBlue, border - 4, O, border + (int)distance - 15, O - (int)distance / 3 + 15);//Линия расстояния до н/п
                    Mod.FillEllipse(BrSilver, (int)distance, O - (int)distance / 3, 30, 30);//Заполнение площади н/п
                    Mod.DrawEllipse(PBlack, (int)distance, O - (int)distance / 3, 30, 30);//Обводка н/п
                    //Mod.FillPolygon(BrSilver, p);//Заполнение площади н/п
                    //Mod.DrawPolygon(PBlack, p);//Обводка н/п
                    Mod.DrawString(TextDistance, Font, BrBlack, (int)distance - 40, O - (int)distance / 3 + 26);//Текст расстояния до н/п
                }

                Mod.DrawString(TextGlub, Font, BrBlack, O, O + 23);//Текст глубины
                Mod.DrawArc(PTurq, border, border, Se, Se, 315, 90);//Дуговая обводка
            }
            if (Form1.f == 45)
            {
                distance = distance * 10;
                Mod.FillEllipse(BrB, border, border, Se, Se);//Заполнение зоны поражения
                Mod.DrawLine(PSilverB, border - 20, O - 45, Se, border - 22);//Отрезающая линия, для визуала
                Mod.DrawLine(PSilverB, border - 20, O + 45, Se, Se + 48);//Отрезающая линия, для визуала 2
                Mod.DrawLine(PTurq, border, O, O + 93, O - 92);//Отрезающая линия, для визуала 3
                Mod.DrawLine(PTurq, border, O, O + 93, O + 92);//Отрезающая линия, для визуала 4
                Mod.FillEllipse(BrBl, border - 4, O - 4, point + 1, point + 1);//Очаг поражения (центр. точка)

                Mod.DrawLine(PBlue, border + 4, O - 1, Se + 21, O + 35);//Линия глубины

                if (Form1.X > 0)
                {
                    Mod.DrawLine(PBlue, border - 4, O, border + (int)distance - 15, O - (int)distance / 3 + 15);//Линия расстояния до н/п
                    Mod.FillEllipse(BrSilver, (int)distance, O - (int)distance / 3, 30, 30);//Заполнение площади н/п
                    Mod.DrawEllipse(PBlack, (int)distance, O - (int)distance / 3, 30, 30);//Обводка н/п
                    //Mod.FillPolygon(BrSilver, p);//Заполнение площади н/п
                    //Mod.DrawPolygon(PBlack, p);//Обводка н/п
                    Mod.DrawString(TextDistance, Font, BrBlack, (int)distance - 40, O - (int)distance / 3 + 26);//Текст расстояния до н/п
                }

                Mod.DrawString(TextGlub, Font, BrBlack, O, O + 23);//Текст глубины
                Mod.DrawArc(PTurq, border, border, Se, Se, 315, 90);//Дуговая обводка
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
