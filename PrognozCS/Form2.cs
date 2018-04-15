using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrognozCS
{
    public partial class Form2 : Form
    {
        public static double S;
        public static string AXOB, AXOB1, AXOB2, AXOB3, AXOB4, AXOB5, AXOB6;

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Извините, данная опция пока в разработке!",
                                "Внимание", MessageBoxButtons.OK);
            //new Form4().Show();
        }

        public static string SIZ, SIZ1, SIZ2, SIZ3, SIZ4, SIZ5, SIZ6;

        public Form2()
        {
            InitializeComponent();
            Form1.G = Math.Round(Form1.G, 2);
            Form1.Sf = Math.Round(Form1.Sf, 2);

            int Txm = (int)Form1.Txm;
            int Txm0 = (int)Form1.Txm0;
            int Txm1 = (int)Form1.Txm1;
            int Txm2 = (int)Form1.Txm2;
            int Txm3 = (int)Form1.Txm3;
            int Txm4 = (int)Form1.Txm4;
            int Txm5 = (int)Form1.Txm5;
            int Txm6 = (int)Form1.Txm6;
            
            if (Form1.p1 == 0) { label01.Text = "Вещество не указано!"; }
            else { label01.Text = Form1.Txh1.ToString() + " часов " + Txm1.ToString() + " минут"; }
            if (Form1.p2 == 0) { label02.Text = "Вещество не указано!"; }
            else { label02.Text = Form1.Txh2.ToString() + " часов " + Txm2.ToString() + " минут"; }
            if (Form1.p3 == 0) { label03.Text = "Вещество не указано!"; }
            else { label03.Text = Form1.Txh3.ToString() + " часов " + Txm3.ToString() + " минут"; }
            if (Form1.p4 == 0) { label04.Text = "Вещество не указано!"; }
            else { label04.Text = Form1.Txh4.ToString() + " часов " + Txm4.ToString() + " минут"; }
            if (Form1.p5 == 0) { label05.Text = "Вещество не указано!"; }
            else { label05.Text = Form1.Txh5.ToString() + " часов " + Txm5.ToString() + " минут"; }
            if (Form1.p6 == 0) { label06.Text = "Вещество не указано!"; }
            else { label06.Text = Form1.Txh6.ToString() + " часов " + Txm6.ToString() + " минут"; }

            if (Form1.Q01 == 0) { label01.Visible = false; labelTime1.Visible = false; }
            if (Form1.Q02 == 0) { label02.Visible = false; labelTime2.Visible = false; }
            if (Form1.Q03 == 0) { label03.Visible = false; labelTime3.Visible = false; }
            if (Form1.Q04 == 0) { label04.Visible = false; labelTime4.Visible = false; }
            if (Form1.Q05 == 0) { label05.Visible = false; labelTime5.Visible = false; }
            if (Form1.Q06 == 0) { label06.Visible = false; labelTime6.Visible = false; }

            if (Form1.lockpanel == 1) { panelAXOB.Visible = true; }
            else { panelAXOB.Visible = false; }
            Tabl();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ploshG.Text == "") { S = 5; }
                else { S = Convert.ToDouble(ploshG.Text); }
                if (Form1.obj == 1)
                {
                    MessageBox.Show("Моделирование работает только для аварии на открытой местности!",
                                "Внимание!", MessageBoxButtons.OK);
                }
                else
                {
                    new Form3().Show();
                }
            }
            catch
            {
                MessageBox.Show("Ввод данных не коректен! В поля ввода должны вносится только числа!" +
                    " Данные с плавающей точкой должны указываться через запятую!",
                                 "Ошибка!", MessageBoxButtons.OK);
            }
        }

        public void Tabl()
        {
            //Условия и текст
            int K = (int)Form1.Kg + (int)Form1.Kz;
            string poteriT = K.ToString() + " чел";
            string poteriA = Form1.P0.ToString() + " чел";
            string poteriAs1 = Form1.P1.ToString() + " чел";
            string poteriAs2 = Form1.P2.ToString() + " чел";
            string poteriAs3 = Form1.P3.ToString() + " чел";

            string Zaraj;
            string vertUst;
            string ukr;
            string open;
            string obj;

            string AmountSubstanceView(double Q)
            {
                string outPut;
                if (Q != 0) outPut = $"{Q.ToString()} т";
                else outPut = "Не указано!";
                return outPut;
            }

            switch (Form1.pron)
            {
                case 1:
                    ukr = "0,5 кг / м * ч";
                    break;
                case 2:
                    ukr = "1,0 кг / м * ч";
                    break;
                case 3:
                    ukr = "1,5 кг / м * ч";
                    break;
                case 4:
                    ukr = "10,0 кг / м * ч";
                    break;
                case 5:
                    ukr = "15,0 кг / м * ч";
                    break;
                case 6:
                    ukr = "30,0 кг / м * ч";
                    break;
                case 7:
                    ukr = "0,5 кг / м * ч";
                    break;
                default:
                    ukr = "Не указано!";
                    break;
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

            switch (Form1.podd)
            {
                case 0:
                    Zaraj = "Разрушена\nемкость\n(обвалована)!";
                    break;
                case 1:
                    Zaraj = "Вещество\nпопало в\nсамостоятельную\nобваловку!";
                    break;
                case 2:
                    Zaraj = "Вещества\nпопали в\nобщую обваловку!";
                    break;
                default:
                    Zaraj = "Нет данных!";
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
                        open = "Не достаточно данных для расчета количества пострадавшего населения!";
                        poteriAs1 = "Не указано!";
                        poteriAs2 = "Не указано!";
                        poteriAs3 = "Не указано!";
                        break;
                    default:
                        open = "Всего со смертельным исходом и потерявших работоспособность " +
                    "- " + P.ToString() + " чел.";
                        break;
                }

                label2.Text = open;
                label3.Text = "";
            }
            if (Form1.obj == 1)
            {
                switch (Form1.Kz)
                {
                    case 0:
                        open = "Не достаточно данных для расчета пострадавшего населения!";
                        break;
                    default:
                        open = "Всего со смертельным исходом и потерявших работоспособность " +
                        "на открытых площадках - " + Form1.Kz.ToString() + " чел.";
                        break;
                }
                switch (Form1.Kg)
                {
                    case 0:
                        obj = "Не достаточно данных для расчета пострадавшего населения!";
                        break;
                    default:
                        obj = "Всего со смертельным исходом и потерявших работоспособность " +
                        "на объекте - " + Form1.Kg.ToString() + " чел.";
                        break;
                }

                label2.Text = open;
                label3.Text = obj;

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
                    $"Фактическая глубина распространения зараженного облака:                                  \n" +
                    $"Предельная глубина распространения зараженного облака:                                   \n" +
                    $"Площадь фактического поражения:                                                          \n" +
                    $"Площадь возможного поражения:                                                            \n" +
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
                    $"Удельная теплота испарения АХОВ при температуре испарения:                                  \n" +
                    $"Продолжительность поражаюшего действия:                                                     \n" +
                    $"Эквивалентное кол-во АХОВ в первичном облаке:                                              \n" +
                    $"Эквивалентное кол-во АХОВ во вторичном облаке:                                             \n" +
                    $"Коэф., зависящий от степени верт. уст. воздуха:                                            \n" +
                    $"Коэф., зависящий от условий хранения АХОВ:                                                 \n" +
                    $"Коэф., зависящий от физико-химических свойств АХОВ:                                        \n" +
                    $"Коэф., отношение токсодозы хлора к выбранному веществу:                                    \n" +
                    $"Дополнительный коэффициент (К4):                                                           \n" +
                    $"Коэф., влияние степени вертикальной устойчивости атмосферы:                                \n" +
                    $"Дополнительный коэффициент (К6):                                                           \n" +
                    $"Коэф., учитывающий влияние температуры воздуха (перв. облако):                             \n" +
                    $"Коэф., учитывающий влияние температуры воздуха (втор. облако):                             \n";

            result.Text = $"{AXOB} \n" +
                $"{AmountSubstanceView(Form1.Q0)} \n" +
                $"{Form1.h} м\n" +
                $"{Form1.v} м/с\n" +
                $"{Form1.t} °C\n" +
                $"{vertUst}\n" +
                $"{Form1.N} ч\n" +
                $"{Form1.Txh} часов {Math.Round(Form1.Txm, 0)} минут\n" +
                $"{Form1.Txh0} часов {Math.Round(Form1.Txm0, 0)} минут\n" +
                $"{Form1.Ge} км\n" +
                $"{Form1.Gp} км\n" +
                $"{Form1.Sf} км²\n" +
                $"{Form1.Sp} км²\n" +
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
