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
            //Создаем картинку 2
            Bitmap bpm2 = new Bitmap(picture2.Width, picture2.Height);
            //Импортируем созданную картинку 2
            Graphics Mod2 = Graphics.FromImage(bpm2);

            //Создание карандашей
            Pen PTurq = new Pen(Color.Turquoise, 2);
            Pen PBlue = new Pen(Color.Blue, 2);
            Pen PBlueS = new Pen(Color.Blue, 1);
            Pen PRed = new Pen(Color.Red, 2);
            Pen PGreen = new Pen(Color.Green, 1);
            Pen PRedS = new Pen(Color.Red, 1);
            Pen PBlack = new Pen(Color.Black, 1);
            Pen PSilver = new Pen(Color.Silver, 1);
            Pen PSilverB = new Pen(Color.Silver, 130);
            SolidBrush BrB = new SolidBrush(Color.Beige);
            SolidBrush BrBr = new SolidBrush(Color.SkyBlue);
            SolidBrush BrBl = new SolidBrush(Color.Blue);
            SolidBrush BrBlack = new SolidBrush(Color.Black);
            SolidBrush BrSilver = new SolidBrush(Color.Silver);
            SolidBrush BrWhite = new SolidBrush(Color.White);
            SolidBrush BrRed = new SolidBrush(Color.DarkSalmon);
            Font Font = new Font(FontFamily.GenericSerif, 9, FontStyle.Regular);

            //Указатели
            //Значения, для упрощения отладки
            //Form1.f = 180;//////////////////////
            //Form1.X = 6;//////////////
            //Form2.S = 270;//////////////////
            Form1.G = Math.Round(Form1.G, 2);
            Form1.Sf = Math.Round(Form1.Sf, 2);
            string TextGlub = Form1.G.ToString() + " км";
            string TextDistance = Form1.X.ToString() + " км";

            //Переменные
            int border = 26;//Расстояние от верхней и нижней границы формы
            int point = 6;//Очаг поражения
            int r = 130;//Расстояния от края глубины поражения до очага
            int Se = r * 2;//Диаметр зоны поражения
            int O = r + border;//Расстояние от верха и края формы до очага поражения
            double S = 2 * Math.Sqrt(Form2.S / 3.14);//Отношение зоны возможного заражения от фактической
            S = Math.Round(S, 0);

            //Масштабирование значений на рисунок
            double distance = (Form1.X / Form1.G) * r;//Расстояние до н/п в пикселях
            double Mas = (double)r / 100;//Расчет шага 1% в пикселях от глубины
            double Plosh = Mas * S;//Площадь н/п

            //Многоугольник (населеная местность)
            //PointF[] p = new PointF[5];
            //p[0] = new Point( 1, 1);
            //p[1] = new Point( 2, 2);
            //p[2] = new Point( 3, 3);
            //p[3] = new Point( 4, 4);
            //p[4] = new Point( 5, 5);

            //Рисование
            Mod.FillRectangle(BrSilver, 0, 0, 999, 999);//Заполнение пикчербокса в рисунке

            if (Form1.f == 360)
            {
                Mod.FillEllipse(BrB, border, border, Se, Se);//Заполнение зоны поражения

                Mod.DrawLine(PBlue, O, O, O + r - 39, O - r + 39);//Линия глубины

                if (Form1.X > 0)
                {
                    Plosh = Plosh * 2;
                    Mod.DrawLine(PRed, O, O, O + (int)distance , 
                        O);//Линия расстояния до н/п
                    Mod.FillEllipse(BrWhite, O + (int)distance - point / 2, 
                        O - (int)Plosh, (int)Plosh * 2, (int)Plosh * 2);//Заполнение площади н/п
                    Mod.DrawEllipse(PBlack, O + (int)distance - point / 2,
                        O - (int)Plosh, (int)Plosh * 2, (int)Plosh * 2);//Обводка н/п
                    //Mod.FillPolygon(BrSilver, p);//Заполнение площади н/п
                    //Mod.DrawPolygon(PBlack, p);//Обводка н/п
                    Mod.DrawString(TextDistance, Font, BrBlack, O + (int)distance - 40,
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
                    Plosh = Plosh * 2;
                    Mod.DrawLine(PRed, O, O, O + (int)distance,
                        O);//Линия расстояния до н/п
                    Mod.FillEllipse(BrWhite, O + (int)distance - point / 2,
                        O - (int)Plosh, (int)Plosh * 2, (int)Plosh * 2);//Заполнение площади н/п
                    Mod.DrawEllipse(PBlack, O + (int)distance - point / 2,
                        O - (int)Plosh, (int)Plosh * 2, (int)Plosh * 2);//Обводка н/п
                    //Mod.FillPolygon(BrSilver, p);//Заполнение площади н/п
                    //Mod.DrawPolygon(PBlack, p);//Обводка н/п
                    Mod.DrawString(TextDistance, Font, BrBlack, O + (int)distance - 40,
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
                    Mod.DrawLine(PRed, border, O, border + (int)distance * 2,
                        O);//Линия расстояния до н/п
                    Mod.FillEllipse(BrWhite, border + (int)distance * 2 - point,
                        O - (int)Plosh * 2, (int)Plosh * 4, (int)Plosh * 4);//Заполнение площади н/п
                    Mod.DrawEllipse(PBlack, border + (int)distance * 2 - point,
                        O - (int)Plosh * 2, (int)Plosh * 4, (int)Plosh * 4);//Обводка н/п
                    //Mod.FillPolygon(BrSilver, p);//Заполнение площади н/п
                    //Mod.DrawPolygon(PBlack, p);//Обводка н/п
                    Mod.DrawString(TextDistance, Font, BrBlack, border + (int)distance * 2 - 45,
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
                    Mod.DrawLine(PRed, border, O, border + (int)distance * 2,
                        O);//Линия расстояния до н/п
                    Mod.FillEllipse(BrWhite, border + (int)distance * 2 - point,
                        O - (int)Plosh * 2, (int)Plosh * 4, (int)Plosh * 4);//Заполнение площади н/п
                    Mod.DrawEllipse(PBlack, border + (int)distance * 2 - point,
                        O - (int)Plosh * 2, (int)Plosh * 4, (int)Plosh * 4);//Обводка н/п
                    //Mod.FillPolygon(BrSilver, p);//Заполнение площади н/п
                    //Mod.DrawPolygon(PBlack, p);//Обводка н/п
                    Mod.DrawString(TextDistance, Font, BrBlack, border + (int)distance * 2 - 45,
                        O - 14);//Текст расстояния до н/п
                }
                
                Mod.DrawString(TextGlub, Font, BrBlack, O + 82, O + 37);//Текст глубины
                Mod.FillEllipse(BrBlack, border - 4, O - 4, point + 1, point + 1);//Очаг поражения (центр. точка)
                Mod.DrawArc(PTurq, border, border, Se, Se, 338, 46);//Дуговая обводка
            }
            Mod2.FillRectangle(BrSilver, 0, 0, 999, 999);//Заполнение пикчербокса в рисунке 2
            //Расчетные данные
            int l = r + border + 138;//Условные величины
            int x = border;//для упрощения
            int y = border;//расчета, px

            int L = l + 220;//Глубина поражения в пикселях в картинке 2
            Mas = ((double)L - x) / 100;//Расчет шага 1% в пикселях от глубины в картинке 2
            distance = ((distance / r) * L);//Расстояние до города в пикселях в картинке 2
            Plosh = (Mas * S);//Площадь н/п в картинке 2
            int m = 57;//Средняя точка по у
            double z = ((double)L - (x - 2)) / 4;//Разделение глубины поражения на 4 зоны

            if (Form1.f == 45) { Plosh = Plosh * 1.5 - 6; }
            if (Form1.f == 90) { Plosh = Plosh * 2; }
            if (Form1.f == 180) { Plosh = Plosh * 4; }
            if (Form1.f == 360) { Plosh = Plosh * 4; }

            //Mod.DrawLine(PBlack, Se + border * 2, border - 15, Se + border * 2, l);//
            Mod.DrawLine(PBlack, border - 40, l - 1, Se * 2 + 150, l - 1);//Разделяющая черта рисунков
            Mod.DrawLine(PBlack, border - 40, l, Se * 2 + 150, l);//Разделяющая черта рисунков 2
            //Mod.DrawLine(PRed, x - 2, l, L, l);//Разделяющая черта рисунков 3

            string TextDiametr = S.ToString() + " км";//Текст диаметра площади н/п
            Mod2.FillEllipse(BrBr, x - 2, -10, l + 195, m + y * 4);//Заполнение зоны поражения

            string Text = "Населенный пункт не попал в зону \nпоражения!";//
            string Text1z = "Населенный пункт попал в зону \nсмертельной " +
                "концентрации!";//
            string Text2z = "Населенный пункт попал в зону \nтяжелых поражений!";//
            string Text3z = "Населенный пункт попал в зону \nпоражений " +
                "средней тяжести!";//
            string Text4z = "Населенный пункт попал в зону \nпоражений " +
                "легкой тяжести!";//
            string Text1z2 = "Населенный пункт попал в зоны \nсмертельной " +
                "концентрации и \nтяжелых поражений!";//
            string Text2z2 = "Населенный пункт попал в зоны \nтяжелых " +
                "поражений и поражений \nсредней тяжести!";//
            string Text3z2 = "Населенный пункт попал в зоны \nпоражений " +
                "средней и легкой \nтяжести!";//
            string Text1z3 = "Населенный пункт попал в зоны \nсмертельной " +
                "концентрации, тяжелых \nпоражений и поражений средней тяжести!";//
            string Text2z3 = "Населенный пункт попал в зоны \nтяжелых поражений, " +
                "поражений средней \nи легкой тяжести!";//
            string Text1z4 = "Населенный пункт попал в зоны \nсмертельной " +
                "концентрации, тяжелых \nпоражений, поражений средней \nи легкой тяжести!";//

            string TextZ1 = "Зона \nсмертельной \nконцентрации!";//
            string TextZ2 = "Зона \nтяжелых \nпоражений!";//
            string TextZ3 = "Зона \nпоражений \nсредней \nтяжести!";//
            string TextZ4 = "Зона \nпоражений \nлегкой \nтяжести!";//

            //Н/п попадающий в 4 части зоны
            /////////////////////////////////////
            if ((int)distance + (int)Plosh >= z * 3)
            {
                if ((int)distance > 0 || ((int)distance + (int)Plosh < z * 4))
                {
                    Mod2.FillEllipse(BrRed, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrRed, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrRed, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrRed, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text1z4, Font, BrBlack, Se + 35, 
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text1z4;
                }
                if ((int)distance > z && ((int)distance + (int)Plosh >= z * 4))
                {
                    Mod2.FillEllipse(BrRed, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrRed, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrRed, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrBr, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text2z3, Font, BrBlack, Se + 35, 
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text2z3;
                }
                if ((int)distance > z * 2)
                {
                    Mod2.FillEllipse(BrRed, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrRed, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrBr, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrBr, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text3z2, Font, BrBlack, Se + 35, 
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text3z2;
                }
                if ((int)distance > z * 3)
                {
                    Mod2.FillEllipse(BrRed, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrBr, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrBr, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrBr, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text2z, Font, BrBlack, Se + 35,
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text4z;
                }
                if ((int)distance >= z * 4)
                {
                    Mod2.FillEllipse(BrBr, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrBr, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrBr, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrBr, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text, Font, BrBlack, Se + 35,
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text;
                }
            }
            //Н/п попадающий в 3 части зоны
            ///////////////////////////////////
            if (((int)distance + (int)Plosh < z * 4))
            {
                if (((int)distance > 0) && ((int)distance + (int)Plosh < z * 3))
                {
                    Mod2.FillEllipse(BrBr, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrRed, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrRed, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrRed, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text1z3, Font, BrBlack, Se + 35,
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text1z3;
                }
                if (((int)distance > z) && ((int)distance + (int)Plosh < z * 4))
                {
                    Mod2.FillEllipse(BrRed, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrRed, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrRed, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrBr, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text2z3, Font, BrBlack, Se + 35,
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text2z3;
                }
                if ((int)distance > z * 2)
                {
                    Mod2.FillEllipse(BrRed, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrRed, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrBr, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrBr, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text3z2, Font, BrBlack, Se + 35,
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text3z2;
                }
                if ((int)distance > z * 3)
                {
                    Mod2.FillEllipse(BrRed, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrBr, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrBr, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrBr, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text4z, Font, BrBlack, Se + 35,
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text4z;
                }
                if ((int)distance >= z * 4)
                {
                    Mod2.FillEllipse(BrBr, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrBr, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrBr, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrBr, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text, Font, BrBlack, Se + 35,
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text;
                }
            }
            //Н/п попадающий в 2 части зоны
            ////////////////////////////////////
            if (((int)distance + (int)Plosh < z * 3))
            {
                if (((int)distance > 0) && ((int)distance + (int)Plosh < z * 2))
                {
                    Mod2.FillEllipse(BrBr, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrBr, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrRed, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrRed, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text1z2, Font, BrBlack, Se + 35,
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text1z2;
                }
                if (((int)distance > z) && ((int)distance + (int)Plosh < z * 3))
                {
                    Mod2.FillEllipse(BrBr, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrRed, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrRed, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrBr, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text2z2, Font, BrBlack, Se + 35,
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text2z2;
                }
                if (((int)distance > z * 2) && ((int)distance + (int)Plosh < z * 4))
                {
                    Mod2.FillEllipse(BrRed, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrRed, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrBr, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrBr, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text3z2, Font, BrBlack, Se + 35,
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text3z2;
                }
                if ((int)distance > z * 3)
                {
                    Mod2.FillEllipse(BrRed, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrBr, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrBr, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrBr, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text4z, Font, BrBlack, Se + 35,
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text4z;
                }
                if ((int)distance >= z * 4)
                {
                    Mod2.FillEllipse(BrBr, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrBr, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrBr, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrBr, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text, Font, BrBlack, Se + 35,
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text;
                }
            }
            //Н/п попадающий в 1 часть зоны
            //////////////////////////////////////
            if (((int)distance + (int)Plosh < z))
            {
                if (((int)distance < z) && ((int)distance > 0))
                {
                    Mod2.FillEllipse(BrBr, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrBr, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrBr, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrRed, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text1z, Font, BrBlack, Se + 35,
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text1z;
                }
                if (((int)distance > z) && ((int)distance < z * 2))
                {
                    Mod2.FillEllipse(BrBr, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrBr, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrRed, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrBr, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text2z, Font, BrBlack, Se + 35,
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text2z;
                }
                if (((int)distance > z * 2) && ((int)distance < z * 3))
                {
                    Mod2.FillEllipse(BrBr, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrRed, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrBr, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrBr, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text3z, Font, BrBlack, Se + 35,
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text3z;
                }
                if (((int)distance > z * 3) && ((int)distance < z * 4))
                {
                    Mod2.FillEllipse(BrRed, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrBr, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    Mod2.FillEllipse(BrBr, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrBr, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    //Mod.DrawString(Text4z, Font, BrBlack, Se + 35,
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text4z;
                }
                if ((int)distance >= z * 4)
                {
                    Mod2.FillEllipse(BrBr, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                    Mod2.FillEllipse(BrBr, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                    Mod2.FillEllipse(BrBr, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                    Mod2.FillEllipse(BrBr, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
                    //Mod.DrawString(Text, Font, BrBlack, Se + 35,
                    //    border);//Текст, указывающий зону поражения н/п
                    TextZ.Text = Text;
                }
            }
            if (distance == 0)
            {
                TextZ.Text = "Не указаны данные о населенном пункте!";
                Mod2.FillEllipse(BrBr, x + r * 2, y / 2, m * 4, m * 2);//Дуговая обводка 4
                Mod2.FillEllipse(BrBr, x + r, y / 2, m * 4, m * 2);//Дуговая обводка 3
                Mod2.FillEllipse(BrBr, x, y / 2, m * 4, m * 2);//Дуговая обводка 2
                Mod2.FillEllipse(BrBr, x - r, y / 2, m * 4, m * 2);//Дуговая обводка
            }

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

            Mod2.DrawLine(PBlack, x - 2, m + y / 2, x - 2, m * 3);//Отрезающая черта для зон поражения
            Mod2.DrawLine(PBlack, L / 4, m + y / 2, L / 4, m * 3);//Отрезающая черта для зон поражения 2
            Mod2.DrawLine(PBlack, L / 2, m + y / 2, L / 2, m * 3);//Отрезающая черта для зон поражения 3
            Mod2.DrawLine(PBlack, L / 4 + L / 2 + 1, m + y / 2, 
                L / 4 + L / 2 + 1, m * 3);//Отрезающая черта для зон поражения 4
            Mod2.DrawLine(PBlack, L, m + y / 2, L, m * 3);//Отрезающая черта для зон поражения 5
            Mod2.DrawLine(PBlack, x - 2, m * 2 + 22, L, m * 2 + 22);//Линия соединяющая отрезающие черты

            Mod2.DrawLine(PTurq, x - 5, m + y / 2, l + 180, y / 2 + 13);//Отрезающая линия, для визуала 1
            Mod2.DrawLine(PTurq, x - 5, m + y / 2, l + 180, y / 2 + 101);//Отрезающая линия, для визуала 2

            Mod2.DrawString(TextZ1, Font, BrBlack, x + 5,
                       m + 35);//Текст, указывающий зону поражения н/п
            Mod2.DrawString(TextZ2, Font, BrBlack, L / 4 + 5,
                       m + 35);//Текст, указывающий зону поражения н/п
            Mod2.DrawString(TextZ3, Font, BrBlack, L / 2 + 5,
                       m + 25);//Текст, указывающий зону поражения н/п
            Mod2.DrawString(TextZ4, Font, BrBlack, L / 4 + L / 2 + 5,
                       m + 25);//Текст, указывающий зону поражения н/п

            Mod2.DrawLine(PBlack, L, 5, L, m + y / 2);//Конечный отрезок глубины
            Mod2.DrawLine(PBlack, x - 2, 5, x - 2, m + y / 2);//Начальный отрезок глубины
            Mod2.DrawLine(PBlueS, border - 2, 18, L, 18);//Линия соединяющая отрезки глубины

            if ((int)distance > 0)
            {
                Mod2.DrawLine(PGreen, (int)distance, m + y / 2,
                (int)distance + (int)Plosh, m + y / 2);//Радиус н/п
                Mod2.DrawLine(PBlack, (int)distance + (int)Plosh, m + y / 2 - 15,
                    (int)distance + (int)Plosh, m + y / 2);//Конечный отрезок радиуса н/п

                Mod2.DrawLine(PRedS, x, m + y / 2,
                    (int)distance, m + y / 2);//Линия соединяющая отрезки расстояния до н/п
                Mod2.DrawLine(PBlack, (int)distance, m + y / 2 - 15,
                    (int)distance, m + y / 2);//Конечный отрезок расстояния до н/п
                Mod2.DrawString(TextDiametr, Font, BrBlack, (int)distance + border, m + y / 2);//Текст диаметра н/п
                Mod2.DrawString(TextDistance, Font, BrBlack, x, m + y / 2 - 13);//Текст расстояния н/п
            }

            Mod2.DrawString(TextGlub, Font, BrBlack, l - 40, 5);//Текст глубины
            //Mod2.DrawLine(PBlack, x - 2, m * 2 + 10, x - 2, m + y / 2);//
            Mod2.FillEllipse(BrBlack, x - 5, m + y / 2 - 3, point, point);//Очаг поражения (центр. точка)
            
            //Вывод картинок
            picture.Image = bpm;
            picture2.Image = bpm2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
