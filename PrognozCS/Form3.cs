﻿using System;
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
            //Создаем картинку
            Bitmap bpm2 = new Bitmap(picture2.Width, picture2.Height);
            //Импортируем созданную картинку
            Graphics Mod2 = Graphics.FromImage(bpm2);

            //Создание карандашей
            Pen PTurq = new Pen(Color.Turquoise, 2);
            Pen PBlue = new Pen(Color.Blue, 2);
            Pen PRed = new Pen(Color.Red, 2);
            Pen PBlack = new Pen(Color.Black, 1);
            Pen PSilver = new Pen(Color.Silver, 1);
            Pen PSilverB = new Pen(Color.Silver, 130);
            SolidBrush BrB = new SolidBrush(Color.Beige);
            SolidBrush BrBl = new SolidBrush(Color.Blue);
            SolidBrush BrBlack = new SolidBrush(Color.Black);
            SolidBrush BrSilver = new SolidBrush(Color.Silver);
            SolidBrush BrWhite = new SolidBrush(Color.White);

            //Указатели
            //Form1.f = 90;//////////////////////
            //Form1.X = 36;////
            string TextGlub = Form1.G.ToString() + " км";
            string TextDistance = Form1.X.ToString() + " км";

            //Переменные
            int border = 26;//Расстояние от верхней и нижней границы формы
            int point = 6;//Очаг поражения
            int r = 130;//Расстояния от края глубины поражения до очага
            int Se = r * 2;//Диаметр зоны поражения
            int O = r + border;//Расстояние от верха и края формы до очага поражения
            double S = Form1.Sp / Form1.Sf;//Отношение зоны возможного заражения от фактической

            //Масштабирование значений на рисунок
            double distance = (Form1.X / Form1.G) * r;//Расстояние до н/п в пикселях
            double Mas = r / 100;//Расчет шага 1% в пикселях от глубины
            double Plosh = Mas * S;//Площадь н/п

            //Многоугольник (населеная местность)
            //PointF[] p = new PointF[5];
            //p[0] = new Point( 1, 1);
            //p[1] = new Point( 2, 2);
            //p[2] = new Point( 3, 3);
            //p[3] = new Point( 4, 4);
            //p[4] = new Point( 5, 5);

            //Рисование
            if (Form1.f == 360)
            {
                Mod.FillEllipse(BrB, border, border, Se, Se);//Заполнение зоны поражения

                Mod.DrawLine(PBlue, O, O, O + r - 39, O - r + 39);//Линия глубины

                if (Form1.X > 0)
                {
                    Mod.DrawLine(PRed, O, O, O + (int)distance + (int)Plosh / 5, 
                        O);//Линия расстояния до н/п
                    Mod.FillEllipse(BrWhite, O + (int)distance, 
                        O - (int)Plosh / 2, (int)Plosh, (int)Plosh);//Заполнение площади н/п
                    Mod.DrawEllipse(PBlack, O + (int)distance, 
                        O - (int)Plosh / 2, (int)Plosh, (int)Plosh);//Обводка н/п
                    //Mod.FillPolygon(BrSilver, p);//Заполнение площади н/п
                    //Mod.DrawPolygon(PBlack, p);//Обводка н/п
                    Mod.DrawString(TextDistance, Font, BrBlack, O + (int)distance - 35,
                        O - 15);//Текст расстояния до н/п
                }

                Mod.DrawString(TextGlub, Font, BrBlack, O + 15, O - 60);//Текст глубины
                Mod.FillEllipse(BrBlack, O - 3, O - 3, point, point);//Очаг поражения (центр. точка)
                Mod.DrawEllipse(PTurq, border, border, Se, Se);//Круговая обводка
            }
            if (Form1.f == 180)
            {
                Mod.FillEllipse(BrB, border, border, Se, Se);//Заполнение зоны поражения
                Mod.FillRectangle(BrSilver, 0, border, O, Se);//Отрезающий квадрат, для визуала
                Mod.DrawLine(PTurq, O, border, O, Se + 27);//Отрезающая линия, для визуала
                Mod.DrawLine(PBlue, O, O, O + r - 39, O - r + 39);//Линия глубины

                if (Form1.X > 0)
                {
                    Mod.DrawLine(PRed, O, O, O + (int)distance + (int)Plosh / 5,
                        O);//Линия расстояния до н/п
                    Mod.FillEllipse(BrWhite, O + (int)distance,
                        O - (int)Plosh / 2, (int)Plosh, (int)Plosh);//Заполнение площади н/п
                    Mod.DrawEllipse(PBlack, O + (int)distance,
                        O - (int)Plosh / 2, (int)Plosh, (int)Plosh);//Обводка н/п
                    //Mod.FillPolygon(BrSilver, p);//Заполнение площади н/п
                    //Mod.DrawPolygon(PBlack, p);//Обводка н/п
                    Mod.DrawString(TextDistance, Font, BrBlack, O + (int)distance - 35,
                        O - 15);//Текст расстояния до н/п
                }

                Mod.DrawString(TextGlub, Font, BrBlack, O + 15, O - 60);//Текст глубины
                Mod.FillEllipse(BrBlack, O - 4, O - 3, point, point);//Очаг поражения (центр. точка)
                Mod.DrawArc(PTurq, border, border, Se, Se, 270, 180);//Дуговая обводка
            }
            if (Form1.f == 90)
            {
                Mod.FillEllipse(BrB, border, border, Se, Se);//Заполнение зоны поражения
                Mod.DrawLine(PSilverB, border - 25, O - 60, Se, border - 36);//Отрезающая линия, для визуала
                Mod.DrawLine(PSilverB, border - 25, O + 60, Se, Se + 62);//Отрезающая линия, для визуала 2
                Mod.DrawLine(PBlue, border + 4, O, Se + 16, O + 50);//Линия глубины
                Mod.DrawLine(PTurq, border, O, O + 93, O - 92);//Отрезающая линия, для визуала 3
                Mod.DrawLine(PTurq, border, O, O + 93, O + 92);//Отрезающая линия, для визуала 4

                if (Form1.X > 0)
                {
                    Mod.DrawLine(PRed, border, O, border + (int)distance * 2 + (int)Plosh / 2,
                        O);//Линия расстояния до н/п
                    Mod.FillEllipse(BrWhite, border + (int)distance * 2 + (int)Plosh / 2,
                        O - (int)Plosh / 2, (int)Plosh, (int)Plosh);//Заполнение площади н/п
                    Mod.DrawEllipse(PBlack, border + (int)distance * 2 + (int)Plosh / 2,
                        O - (int)Plosh / 2, (int)Plosh, (int)Plosh);//Обводка н/п
                    //Mod.FillPolygon(BrSilver, p);//Заполнение площади н/п
                    //Mod.DrawPolygon(PBlack, p);//Обводка н/п
                    Mod.DrawString(TextDistance, Font, BrBlack, border + (int)distance * 2 - 35,
                        O - 14);//Текст расстояния до н/п
                }

                Mod.DrawString(TextGlub, Font, BrBlack, O + 25, O + 37);//Текст глубины
                Mod.FillEllipse(BrBlack, border - 4, O - 4, point + 1, point + 1);//Очаг поражения (центр. точка)
                Mod.DrawArc(PTurq, border, border, Se, Se, 315, 90);//Дуговая обводка
            }
            if (Form1.f == 45)
            {
                Mod.FillEllipse(BrB, border, border, Se, Se);//Заполнение зоны поражения
                Mod.DrawLine(PSilverB, border - 13, O - 65, Se + 10, border + 18);//Отрезающая линия, для визуала
                Mod.DrawLine(PSilverB, border - 13, O + 65, Se + 10, Se + 13);//Отрезающая линия, для визуала 2
                Mod.DrawLine(PTurq, border, O, O + 120, O - 48);//Отрезающая линия, для визуала 3
                Mod.DrawLine(PTurq, border, O, O + 120, O + 51);//Отрезающая линия, для визуала 4
                Mod.DrawLine(PBlue, border + 4, O, Se + 20, O + 38);//Линия глубины

                if (Form1.X > 0)
                {
                    Mod.DrawLine(PRed, border, O, border + (int)distance * 2 + (int)Plosh / 2,
                        O);//Линия расстояния до н/п
                    Mod.FillEllipse(BrWhite, border + (int)distance * 2 + (int)Plosh / 2,
                        O - (int)Plosh / 2, (int)Plosh, (int)Plosh);//Заполнение площади н/п
                    Mod.DrawEllipse(PBlack, border + (int)distance * 2 + (int)Plosh / 2,
                        O - (int)Plosh / 2, (int)Plosh, (int)Plosh);//Обводка н/п
                    //Mod.FillPolygon(BrSilver, p);//Заполнение площади н/п
                    //Mod.DrawPolygon(PBlack, p);//Обводка н/п
                    Mod.DrawString(TextDistance, Font, BrBlack, border + (int)distance * 2 - 35,
                        O - 14);//Текст расстояния до н/п
                }
                
                Mod.DrawString(TextGlub, Font, BrBlack, O + 82, O + 37);//Текст глубины
                Mod.FillEllipse(BrBlack, border - 4, O - 4, point + 1, point + 1);//Очаг поражения (центр. точка)
                Mod.DrawArc(PTurq, border, border, Se, Se, 338, 46);//Дуговая обводка
            }
            //
            int l = r + border + 138;
            int x = border;
            int y = border;
            distance = distance / r * (l + 180);
            int m = 57;
            //Mod.DrawLine(PBlack, Se + border * 2, border - 15, Se + border * 2, l);//
            Mod.DrawLine(PBlack, border - 15, l, Se * 2 + 15, l);//

            Mod2.FillEllipse(BrB, x - 2, -10, l + 195, m + y * 4);//Заполнение зоны поражения

            //

            Mod2.DrawLine(PSilverB, x - 40, y - 18, l * 2, y - 77);//Отрезающая линия, для визуала 3
            Mod2.DrawLine(PSilverB, x - 40, y + 106, l * 2, y + 165);//Отрезающая линия, для визуала 4

            int f = 10;
            Mod2.DrawArc(PTurq, x - r, y / 2, m * 4, m * 2, 360 - f / 2, f);//Дуговая обводка
            f = 22;
            Mod2.DrawArc(PTurq, x, y / 2, m * 4, m * 2, 360 - f / 2, f);//Дуговая обводка 2
            f = 38;
            Mod2.DrawArc(PTurq, x + r, y / 2, m * 4, m * 2, 360 - f / 2, f);//Дуговая обводка 3
            f = 62;
            Mod2.DrawArc(PTurq, x + r * 2, y / 2, m * 4, m * 2, 360 - f / 2, f);//Дуговая обводка 4

            if ((Form1.X < Form1.G) || (Form1.X > 0))
            {
                Mod2.DrawLine(PRed, x - 2, m + y / 2, x + (int)distance + (int)Plosh / 3, m + y / 2);//Линия расстояния до н/п
            }

            Mod2.DrawLine(PTurq, x - 5, m + y / 2, l + 180, y / 2 + 13);//Отрезающая линия, для визуала 1
            Mod2.DrawLine(PTurq, x - 5, m + y / 2, l + 180, y / 2 + 101);//Отрезающая линия, для визуала 2
            Mod2.FillEllipse(BrBlack, x - 5, m + y / 2 - 3, point, point);//Очаг поражения (центр. точка)
            //Вывод картинки
            picture.Image = bpm;
            picture2.Image = bpm2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
