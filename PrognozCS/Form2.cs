using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace PrognozCS
{
    public partial class Form2 : Form
    {
        public static int x, y, pix, zoom;
        public static double S, xMap, yMap;
        public static string AXOB, AXOB1, AXOB2, AXOB3, AXOB4, AXOB5, AXOB6, side = "n";
        public static Point p0 = new Point();
        public static Point[] ap = new Point[3];
        public static Point pLast = new Point();
        public static Bitmap bpm;
        public static Graphics mod;
        public static Font font = new Font("Arial", 12, FontStyle.Bold);
        public static Font font1 = new Font("Arial", 7);
        public static bool placeCrash = true;

        Pen PBlack = new Pen(Color.Black, 2);
        Pen PRed = new Pen(Color.Red, 4);
        SolidBrush BrChocolate = new SolidBrush(Color.Chocolate);

        private void staticPlase_CheckedChanged(object sender, EventArgs e)
        {
            setObject.Visible = true;
            placeCrash = true;
        }

        private void dinamicPlase_CheckedChanged(object sender, EventArgs e)
        {
            setObject.Visible = false;
            placeCrash = false;
        }

        SolidBrush BrSkyBlue = new SolidBrush(Color.SkyBlue);
        SolidBrush BrRed = new SolidBrush(Color.Red);
        SolidBrush BrBlack = new SolidBrush(Color.Black);

        private void setObj_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(setObject.Text)
            {
                case "Саратоворгсинтез":
                    xMap = 51.443456;
                    yMap = 45.902397;
                    break;
                case "ВК-3":
                    xMap = 51.560110;
                    yMap = 46.089379;
                    break;
                case "ОАО 'Аппатит'":
                    xMap = 51.9222724;
                    yMap = 47.8879836;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Form1.obj == 1) MessageBox.Show("Моделирование работает только для аварии на открытой местности!",
                                "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (staticPlace.Checked && setObject.Text == "- Выберите объект -")

                        MessageBox.Show("Необходимо выбрать объект экономики, на котором произошла авария!",
                                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else new Form3().Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ввод данных не коректен! В поля ввода должны вносится только числа!" +
                    "Данные с плавающей точкой должны указываться через запятую!" +
                    "\nПодробнее смотрите ниже...\nКод ошибки:\n" + ex,
                                 "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Извините, данная опция пока в разработке!",
                                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //new Form4().Show();
        }

        public static string SIZ, SIZ1, SIZ2, SIZ3, SIZ4, SIZ5, SIZ6;

        public Form2()
        {
            InitializeComponent();
            Form1.G = Math.Round(Form1.G, 2);
            Form1.Sf = Math.Round(Form1.Sf, 2);
            x = comp.Height;
            y = comp.Width;
            //Создаем картинку
            bpm = new Bitmap(x, y);
            //Импортируем созданную картинку
            mod = Graphics.FromImage(bpm);

            int Txm = (int)Form1.Txm;
            int Txm0 = (int)Form1.Txm0;
            int Txm1 = (int)Form1.Txm1;
            int Txm2 = (int)Form1.Txm2;
            int Txm3 = (int)Form1.Txm3;
            int Txm4 = (int)Form1.Txm4;
            int Txm5 = (int)Form1.Txm5;
            int Txm6 = (int)Form1.Txm6;
            Tabl();
            Compas(bpm, mod, side, PRed, PBlack, BrChocolate, BrSkyBlue);
        }

        private void Compas(Bitmap bpm, Graphics mod, string side, Pen PRed, Pen PBlack, SolidBrush BrChocolate, SolidBrush BrSkyBlue)
        {
            p0.X = comp.Width / 2;
            p0.Y = comp.Height / 2;

            switch (side)
            {
                case "n":
                    pLast.X = comp.Width / 2;
                    pLast.Y = 21;
                    ap[0] = pLast;
                    ap[1].X = comp.Width / 2 - 3;
                    ap[1].Y = 29;
                    ap[2].X = comp.Width / 2 + 3;
                    ap[2].Y = 29;
                    break;
                case "s":
                    pLast.X = comp.Width / 2;
                    pLast.Y = comp.Height - 21;
                    ap[0] = pLast;
                    ap[1].X = comp.Width / 2 - 3;
                    ap[1].Y = comp.Height - 29;
                    ap[2].X = comp.Width / 2 + 3;
                    ap[2].Y = comp.Height - 29;
                    break;
                case "w":
                    pLast.X = 21;
                    pLast.Y = comp.Height / 2;
                    ap[0] = pLast;
                    ap[1].X = 29;
                    ap[1].Y = comp.Height / 2 - 3;
                    ap[2].X = 29;
                    ap[2].Y = comp.Height / 2 + 3;
                    break;
                case "e":
                    pLast.X = comp.Width - 21;
                    pLast.Y = comp.Height / 2;
                    ap[0] = pLast;
                    ap[1].X = comp.Width - 29;
                    ap[1].Y = comp.Height / 2 - 3;
                    ap[2].X = comp.Width - 29;
                    ap[2].Y = comp.Height / 2 + 3;
                    break;
                case "nw":
                    pLast.X = comp.Width / 3 - 6;
                    pLast.Y = 30;
                    ap[0] = pLast;
                    ap[1].X = comp.Width / 3 - 3;
                    ap[1].Y = 39;
                    ap[2].X = comp.Width / 3 + 3;
                    ap[2].Y = 34;
                    break;
                case "ne":
                    pLast.X = 2 * comp.Width / 3 + 6;
                    pLast.Y = 30;
                    ap[0] = pLast;
                    ap[1].X = 2 * comp.Width / 3 + 3;
                    ap[1].Y = 39;
                    ap[2].X = 2 * comp.Width / 3 - 3;
                    ap[2].Y = 34;
                    break;
                case "sw":
                    pLast.X = comp.Width / 3 - 6;
                    pLast.Y = comp.Height - 30;
                    ap[0] = pLast;
                    ap[1].X = comp.Width / 3 - 3;
                    ap[1].Y = comp.Height - 39;
                    ap[2].X = comp.Width / 3 + 3;
                    ap[2].Y = comp.Height - 34;
                    break;
                case "se":
                    pLast.X = 2 * comp.Width / 3 + 6;
                    pLast.Y = comp.Height - 30;
                    ap[0] = pLast;
                    ap[1].X = 2 * comp.Width / 3 + 3;
                    ap[1].Y = comp.Height - 39;
                    ap[2].X = 2 * comp.Width / 3 - 3;
                    ap[2].Y = comp.Height - 34;
                    break;
            }

            mod.FillEllipse(BrSkyBlue, 0, 0, comp.Width - 1, comp.Height - 1);
            mod.DrawLine(PRed, p0, pLast);
            mod.DrawPolygon(PRed, ap);

            mod.DrawString("С", font, BrRed, comp.Width / 2 - 8, 0);
            mod.DrawString("Ю", font, BrBlack, comp.Width / 2 - 10, comp.Height - 18);
            mod.DrawString("В", font, BrBlack, comp.Width - 16, comp.Height / 2 - 8);
            mod.DrawString("З", font, BrBlack, 0, comp.Height / 2 - 8);
            mod.DrawString("СЗ", font1, BrBlack, comp.Width / 6 - 3, comp.Width / 6);
            mod.DrawString("ЮВ", font1, BrBlack, 5 * comp.Width / 6 - 16, 5 * comp.Width / 6 - 5);
            mod.DrawString("СВ", font1, BrBlack, 5 * comp.Width / 6 - 13, comp.Width / 6);
            mod.DrawString("ЮЗ", font1, BrBlack, comp.Width / 6 - 3, 5 * comp.Width / 6 - 5);

            mod.DrawEllipse(PBlack, 0, 0, comp.Width, comp.Height);
            mod.FillEllipse(BrChocolate, comp.Width / 2 - 5, comp.Height / 2 - 5, 10, 10);

            //Вывод картинки
            comp.Image = bpm;
        }

        void comp_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X > comp.Width / 3 && e.X < 2 * comp.Width / 3 && e.Y > 0 && e.Y < comp.Height / 3) side = "n";
            if (e.X > comp.Width / 3 && e.X < 2 * comp.Width / 3 && e.Y > 2 * comp.Height / 3 && e.Y < comp.Height) side = "s";
            if (e.X > 2 * comp.Width / 3 && e.X < comp.Width && e.Y < 2 * comp.Height / 3 && e.Y > comp.Height / 3) side = "e";
            if (e.X > 0 && e.X < comp.Width / 3 && e.Y > comp.Height / 3 && e.Y < 2 * comp.Height / 3) side = "w";
            if (e.X > 0 && e.X < comp.Width / 3 && e.Y > 0 && e.Y < comp.Height / 3) side = "nw";
            if (e.X > 2 * comp.Width / 3 && e.X < comp.Width && e.Y > 0 && e.Y < comp.Height / 3) side = "ne";
            if (e.X > 0 && e.X < comp.Width / 3 && e.Y > 2 * comp.Height / 3 && e.Y < comp.Height) side = "sw";
            if (e.X > 2 * comp.Width / 3 && e.X < comp.Width && e.Y > 2 * comp.Height / 3 && e.Y < comp.Height) side = "se";
            Compas(bpm, mod, side, PRed, PBlack, BrChocolate, BrSkyBlue);
        }
                
        public void button1_Click(object sender, EventArgs e) => Close();
        
        public void Tabl()
        {
            //Условия и текст
            int K = (int)Form1.Kg + (int)Form1.Kz;
            string poteriT = K.ToString() + " чел";
            string poteriA = Form1.P0.ToString() + " чел";
            string poteriAs1 = Form1.P1.ToString() + " чел";
            string poteriAs2 = Form1.P2.ToString() + " чел";
            string poteriAs3 = Form1.P3.ToString() + " чел";
            
            string vertUst;

            string AmountSubstanceView(double Q)
            {
                string outPut;
                if (Q != 0) outPut = $"{Q.ToString()} т";
                else outPut = "Не указано!";
                return outPut;
            }

            switch (Form1.vert)
            {
                case 1:
                    vertUst = "инверсия";
                    break;
                case 2:
                    vertUst = "изотермия";
                    break;
                case 3:
                    vertUst = "конвекция";
                    break;
                default:
                    vertUst = "не указана!";
                    break;
            }

            switchCaseTabl.substA();
            switchCaseTabl.substA1();
            switchCaseTabl.substA2();
            switchCaseTabl.substA3();
            switchCaseTabl.substA4();
            switchCaseTabl.substA5();
            switchCaseTabl.substA6();

            if (Form1.obj == 0)
            {
                int P = (int)Form1.P1 + (int)Form1.P2;

                switch (P)
                {
                    case 0:
                        
                        break;
                    default:
                       
                        break;
                }
            }
            if (Form1.obj == 1)
            {
                switch (Form1.Kz)
                {
                    case 0:
                        
                        break;
                    default:
                        
                        break;
                }
                switch (Form1.Kg)
                {
                    case 0:
                        
                        break;
                    default:
                        
                        break;
                }

                if ((Form1.Kz + Form1.Kg) == 0) { poteriT = "Нет данных!"; }
            }

            resultLabel.Text = $"Аварийно химически-опасное вещество:                                          \n" +
                    $"Количество вещества:                                                                     \n" +
                    $"Толщина слоя разлившегося АХОВ:                                                          \n" +
                    $"Скорость ветра:                                                                             \n" +
                    $"Температура воздуха:                                                                     \n" +
                    $"Вертикальная устойчивость атмосферы:                                                     \n" +
                    $"Время прошедшее с момента аварии:                                                        \n" +
                    $"Время подхода зараженного облака до населенного пункта:                                  \n" +
                    $"Время полного испарения АХОВ:                                                            \n" +
                    $"Глубина распространения зараженного облака:                                              \n" +
                    $"Площадь фактического поражения:                                                          \n" +
                    $"Площадь возможного поражения:                                                            \n" +
                    $"Плотность населения:                                                                     \n" +
                    $"Возможные потери на площади фактического заражения:                                      \n" +
                    $"- легкая степень:                                                                        \n" +
                    $"- средняя степень:                                                                       \n" +
                    $"- смертельный исход:                                                                     \n" +
                    $"\nДополнительные сведенья: \n\n" +
                    $"Молекулярная масса вещества:                                                                \n" +
                    $"Плотность вещества:                                                                         \n" +
                    $"Давление насыщенного пара:                                                                  \n" +
                    $"Пороговая токсодоза:                                                                        \n" +
                    $"Температура кипения:                                                                        \n" +
                    $"Удельная теплоемкость АХОВ:                                                                 \n" +
                    $"Удельная теплота испарения АХОВ при температуре испарения:                               \n" +
                    $"Продолжительность поражаюшего действия:                                                     \n" +
                    $"Эквивалентное кол-во АХОВ в первичном облаке:                                              \n" +
                    $"Эквивалентное кол-во АХОВ во вторичном облаке:                                             \n" +
                    $"Коэф., зависящий от степени верт. уст. воздуха:                                            \n" +
                    $"Коэф., зависящий от условий хранения АХОВ:                                                 \n" +
                    $"Коэф., зависящий от физико-химических свойств АХОВ:                                        \n" +
                    $"Коэф., отношение токсодозы хлора к выбранному веществу:                                   \n" +
                    $"Дополнительный коэффициент (К4):                                                           \n" +
                    $"Коэф., влияние степени вертикальной устойчивости атмосферы:                               \n" +
                    $"Дополнительный коэффициент (К6):                                                           \n" +
                    $"Коэф., учитывающий влияние температуры воздуха (перв. облако):                            \n" +
                    $"Коэф., учитывающий влияние температуры воздуха (втор. облако):                            \n";

            result.Text = $"{AXOB} \n" +
                $"{AmountSubstanceView(Form1.Q0)} \n" +
                $"{Form1.h} м\n" +
                $"{Form1.v} м/с\n" +
                $"{Form1.t} °C\n" +
                $"{vertUst}\n" +
                $"{Form1.N} ч\n" +
                $"{Form1.Txh} часов {Math.Round(Form1.Txm, 0)} минут\n" +
                $"{Form1.Txh0} часов {Math.Round(Form1.Txm0, 0)} минут\n" +
                $"{Form1.G} км\n" +
                $"{Form1.Sf} км²\n" +
                $"{Form1.Sp} км²\n" +
                $"{Form1.Ag} чел/км²\n" +
                $"{poteriA}\n" +
                $"{poteriAs1}\n" +
                $"{poteriAs2}\n" +
                $"{poteriAs3}\n" +
                $"\n\n\n" +
                $"{Form1.M} \n" +
                $"{Form1.p} \n" +
                $"{Form1.P} \n" +
                $"{Form1.D} \n" +
                $"{Form1.tkip} \n" +
                $"{Form1.Cp} \n" +
                $"{Form1.dHisp} \n" +
                $"{Form1.T} \n" +
                $"{Form1.Qe1} \n" +
                $"{Form1.Qe2} \n" +
                $"{Form1.Kv} \n" +
                $"{Form1.K1} \n" +
                $"{Form1.K2} \n" +
                $"{Form1.K3} \n" +
                $"{Form1.K4} \n" +
                $"{Form1.K5} \n" +
                $"{Form1.K6} \n" +
                $"{Form1.K7} \n" +
                $"{Form1.K72} \n";
            
        }
    }
}
