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
            
            time.Text = Form1.Txh.ToString() + " часов " + Txm.ToString() + " минут";

            if (Form1.p == 0) { label00.Text = "Вещество не указано!"; }
            else { label00.Text = Form1.Txh0.ToString() + " часов " + Txm0.ToString() + " минут"; }
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
                if (ploshG.Text == "") { S = 15; }
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
            //Создаем картинку
            Bitmap bpm = new Bitmap(pictureob1.Width, pictureob1.Height);
            //Импортируем созданную картинку
            Graphics tbl = Graphics.FromImage(bpm);
            //Карандаши
            Pen PBlack = new Pen(Color.Black, 1);
            SolidBrush BrBlack = new SolidBrush(Color.Black);
            SolidBrush BrSilver = new SolidBrush(Color.Silver);

            //Условия и текст
            int K = (int)Form1.Kg + (int)Form1.Kz;

            string istZaraj = "Источник\nзаражения";
            string tipAXOB = "Тип АХОВ";
            string kolAXOBl = "Кол-во АХОВ";
            string glubZonel = "Глубина зоны\nзаражения";
            string poteri = "Потери от\nАХОВ";
            string tipSIZ = "Тип СИЗ.";
            string primNIS = "Примечание\nНИС";
            string ukritie = "Проницаемость\nчерез укрытие.";
            string potA = "Структура\nпотерь:";
            string potAs1 = "Со сметрельным\nисходом:";
            string potAs2 = "Средней и тяжелой\nстепени:";
            string potAs3 = "Легкой степени:";
            string PloshZar = "Общая площадь\nзоны заражения";
            
            string glubZone = Form1.G.ToString() + " км";
            string obshPloshZar = Form1.Sf.ToString() + " км²";
            string poteriT = K.ToString() + " чел";
            string poteriA = Form1.P0.ToString() + " чел";
            string poteriAs1 = Form1.P1.ToString() + " чел";
            string poteriAs2 = Form1.P2.ToString() + " чел";
            string poteriAs3 = Form1.P3.ToString() + " чел";

            string Zaraj;
            string kolvoAXOB, kolvoAXOB1, kolvoAXOB2, kolvoAXOB3, kolvoAXOB4, kolvoAXOB5, kolvoAXOB6;
            string vertUst;
            string ukr;
            string open;
            string obj;

            switch (Form1.Q0)
            {
                case 0:
                    kolvoAXOB = "Не указано!";
                    break;
                default:
                    kolvoAXOB = Form1.Q0.ToString() + " т";
                    break;
            }
            switch (Form1.Q01)
            {
                case 0:
                    kolvoAXOB1 = "Не указано!";
                    break;
                default:
                    kolvoAXOB1 = Form1.Q01.ToString() + " т";
                    break;
            }
            switch (Form1.Q02)
            {
                case 0:
                    kolvoAXOB2 = "Не указано!";
                    break;
                default:
                    kolvoAXOB2 = Form1.Q02.ToString() + " т";
                    break;
            }
            switch (Form1.Q03)
            {
                case 0:
                    kolvoAXOB3 = "Не указано!";
                    break;
                default:
                    kolvoAXOB3 = Form1.Q03.ToString() + " т";
                    break;
            }
            switch (Form1.Q04)
            {
                case 0:
                    kolvoAXOB4 = "Не указано!";
                    break;
                default:
                    kolvoAXOB4 = Form1.Q04.ToString() + " т";
                    break;
            }
            switch (Form1.Q05)
            {
                case 0:
                    kolvoAXOB5 = "Не указано!";
                    break;
                default:
                    kolvoAXOB5 = Form1.Q05.ToString() + " т";
                    break;
            }
            switch (Form1.Q06)
            {
                case 0:
                    kolvoAXOB6 = "Не указано!";
                    break;
                default:
                    kolvoAXOB6 = Form1.Q06.ToString() + " т";
                    break;
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

            string NIS = "Верт. уст.воздуха:\n" + vertUst + ", V =" + Form1.v.ToString() + 
                " м/с,\n t = " + Form1.t.ToString() + " °C";

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

            tbl.FillRectangle(BrSilver, 0, 0, 999, 999);//Заполнение пикчербокса в рисунке
            if (Form1.obj == 0)
            {
                int P = (int)Form1.P1 + (int)Form1.P2;

                switch (P)
                {
                    case 0:
                        open = "Не достаточно данных для расчета пострадавшего населения!";
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

                //Таблица
                tbl.DrawLine(PBlack, 0, 0, 534, 0);//
                tbl.DrawLine(PBlack, 0, 1, 534, 1);//
                tbl.DrawLine(PBlack, 0, 50, 534, 50);//
                tbl.DrawLine(PBlack, 0, 100, 534, 100);//
                tbl.DrawLine(PBlack, 0, 101, 534, 101);//
                tbl.DrawLine(PBlack, 0, 150, 534, 150);//
                tbl.DrawLine(PBlack, 0, 200, 534, 200);//
                tbl.DrawLine(PBlack, 0, 201, 534, 201);//

                tbl.DrawLine(PBlack, 0, 0, 0, 200);//
                tbl.DrawLine(PBlack, 1, 0, 1, 200);//
                tbl.DrawLine(PBlack, 107, 0, 107, 200);//
                tbl.DrawLine(PBlack, 213, 0, 213, 200);//
                tbl.DrawLine(PBlack, 320, 0, 320, 200);//
                tbl.DrawLine(PBlack, 427, 0, 427, 200);//
                tbl.DrawLine(PBlack, 533, 0, 533, 200);//
                tbl.DrawLine(PBlack, 534, 0, 534, 200);//

                //Текст в таблице
                tbl.DrawString(istZaraj, Font, BrBlack, 1, 1);//
                tbl.DrawString(glubZonel, Font, BrBlack, 107, 1);//
                tbl.DrawString(PloshZar, Font, BrBlack, 213, 1);//
                tbl.DrawString(primNIS, Font, BrBlack, 320, 1);//
                tbl.DrawString(potA + "\n" + potAs3, Font, BrBlack, 1, 101);//
                tbl.DrawString(potAs2, Font, BrBlack, 107, 101);//
                tbl.DrawString(potAs1, Font, BrBlack, 213, 101);//
                

                tbl.DrawString(Zaraj, Font, BrBlack, 1, 51);//
                tbl.DrawString(glubZone, Font, BrBlack, 107, 51);//
                tbl.DrawString(obshPloshZar, Font, BrBlack, 213, 51);//
                tbl.DrawString(NIS, Font, BrBlack, 320, 51);//
                tbl.DrawString(poteriAs3, Font, BrBlack, 1, 151);//
                tbl.DrawString(poteriAs2, Font, BrBlack, 107, 151);//
                tbl.DrawString(poteriAs1, Font, BrBlack, 213, 151);//
                

                if (Form1.lockpanel == 0)
                {
                    //Текст в таблице
                    tbl.DrawString(tipAXOB, Font, BrBlack, 320, 101);//
                    tbl.DrawString(kolAXOBl, Font, BrBlack, 427, 101);//
                    tbl.DrawString(tipSIZ + "\n" + ukritie, Font, BrBlack, 427, 1);//

                    tbl.DrawString(AXOB, Font, BrBlack, 320, 151);//
                    tbl.DrawString(kolvoAXOB, Font, BrBlack, 427, 151);//
                    tbl.DrawString(SIZ + "\n" + ukr, Font, BrBlack, 427, 51);//
                }
                else
                {
                    //Таблица
                    tbl.DrawLine(PBlack, 0, 280, 0, 200);//
                    tbl.DrawLine(PBlack, 1, 280, 1, 200);//
                    tbl.DrawLine(PBlack, 178, 280, 178, 200);//
                    tbl.DrawLine(PBlack, 356, 280, 356, 200);//
                    tbl.DrawLine(PBlack, 533, 280, 533, 200);//
                    tbl.DrawLine(PBlack, 534, 280, 534, 200);//

                    tbl.DrawLine(PBlack, 0, 280, 0, 360);//
                    tbl.DrawLine(PBlack, 1, 280, 1, 360);//
                    tbl.DrawLine(PBlack, 267, 280, 267, 360);//
                    tbl.DrawLine(PBlack, 533, 280, 533, 360);//
                    tbl.DrawLine(PBlack, 534, 280, 534, 360);//

                    tbl.DrawLine(PBlack, 0, 280, 534, 280);//
                    tbl.DrawLine(PBlack, 0, 281, 534, 281);//
                    tbl.DrawLine(PBlack, 0, 360, 534, 360);//
                    tbl.DrawLine(PBlack, 0, 361, 534, 361);//

                    //Текст в таблице
                    tbl.DrawString(tipAXOB + " №1", Font, BrBlack, 320, 101);//
                    tbl.DrawString(kolAXOBl + " №1", Font, BrBlack, 427, 101);//
                    tbl.DrawString(tipSIZ + " №1" + "\n" + ukritie, Font, BrBlack, 427, 1);//
                    tbl.DrawString(AXOB1, Font, BrBlack, 320, 151);//
                    tbl.DrawString(kolvoAXOB1, Font, BrBlack, 427, 151);//
                    tbl.DrawString(SIZ1 + "\n" + ukr, Font, BrBlack, 427, 51);//

                    tbl.DrawString(tipAXOB + " №2: ", Font, BrBlack, 2, 201);//
                    tbl.DrawString("\n" + tipSIZ + "\n" + kolAXOBl + "\n№2: ", Font, BrBlack, 2, 225);//
                    tbl.DrawString(AXOB2, Font, BrBlack, 80, 201);//
                    tbl.DrawString("\n" + SIZ2 + "\n" + kolvoAXOB2, Font, BrBlack, 75, 225);//

                    tbl.DrawString(tipAXOB + " №3: ", Font, BrBlack, 179, 201);//
                    tbl.DrawString("\n" + tipSIZ + "\n" + kolAXOBl + "\n№3: ", Font, BrBlack, 179, 225);//
                    tbl.DrawString(AXOB3, Font, BrBlack, 259, 201);//
                    tbl.DrawString("\n" + SIZ3 + "\n" + kolvoAXOB3, Font, BrBlack, 254, 225);//

                    tbl.DrawString(tipAXOB + " №4: ", Font, BrBlack, 357, 201);//
                    tbl.DrawString("\n" + tipSIZ + "\n" + kolAXOBl + "\n№4: ", Font, BrBlack, 357, 225);//
                    tbl.DrawString(AXOB4, Font, BrBlack, 437, 201);//
                    tbl.DrawString("\n" + SIZ4 + "\n" + kolvoAXOB4, Font, BrBlack, 432, 225);//

                    tbl.DrawString(tipAXOB + " №5: ", Font, BrBlack, 2, 282);//
                    tbl.DrawString("\n" + tipSIZ + "\n" + kolAXOBl + "\n№5: ", Font, BrBlack, 2, 306);//
                    tbl.DrawString(AXOB5, Font, BrBlack, 80, 282);//
                    tbl.DrawString("\n" + SIZ5 + "\n" + kolvoAXOB5, Font, BrBlack, 75, 306);//

                    tbl.DrawString(tipAXOB + " №6: ", Font, BrBlack, 269, 282);//
                    tbl.DrawString("\n" + tipSIZ + "\n" + kolAXOBl + "\n№6: ", Font, BrBlack, 269, 306);//
                    tbl.DrawString(AXOB6, Font, BrBlack, 349, 282);//
                    tbl.DrawString("\n" + SIZ6 + "\n" + kolvoAXOB6, Font, BrBlack, 344, 306);//
                }
                
                //tbl.DrawString(open, Font, BrBlack, 0, 285);//
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
                
                //Таблица
                tbl.DrawLine(PBlack, 0, 0, 534, 0);//
                tbl.DrawLine(PBlack, 0, 1, 534, 1);//
                tbl.DrawLine(PBlack, 0, 50, 534, 50);//
                tbl.DrawLine(PBlack, 0, 100, 534, 100);//
                tbl.DrawLine(PBlack, 0, 101, 534, 101);//
                tbl.DrawLine(PBlack, 0, 150, 534, 150);//
                tbl.DrawLine(PBlack, 0, 200, 534, 200);//
                tbl.DrawLine(PBlack, 0, 201, 534, 201);//

                tbl.DrawLine(PBlack, 0, 0, 0, 200);//
                tbl.DrawLine(PBlack, 1, 0, 1, 200);//
                tbl.DrawLine(PBlack, 107, 0, 107, 200);//
                tbl.DrawLine(PBlack, 213, 0, 213, 200);//
                tbl.DrawLine(PBlack, 320, 0, 320, 200);//
                tbl.DrawLine(PBlack, 427, 0, 427, 200);//
                tbl.DrawLine(PBlack, 533, 0, 533, 200);//
                tbl.DrawLine(PBlack, 534, 0, 534, 200);//

                //Текст в таблице
                tbl.DrawString(istZaraj, Font, BrBlack, 1, 1);//
                tbl.DrawString(tipAXOB, Font, BrBlack, 107, 1);//
                tbl.DrawString(kolAXOBl, Font, BrBlack, 213, 1);//
                tbl.DrawString(glubZonel, Font, BrBlack, 320, 1);//
                //tbl.DrawString(PloshZar, Font, BrBlack, 427, 1);//
                tbl.DrawString(ukritie, Font, BrBlack, 1, 101);//
                tbl.DrawString(poteri, Font, BrBlack, 107, 101);//
                tbl.DrawString(primNIS, Font, BrBlack, 213, 101);//
                //tbl.DrawString(tipSIZ, Font, BrBlack, 320, 101);//

                tbl.DrawString(Zaraj, Font, BrBlack, 1, 51);//
                tbl.DrawString(AXOB, Font, BrBlack, 107, 51);//
                tbl.DrawString(kolvoAXOB, Font, BrBlack, 213, 51);//
                tbl.DrawString(glubZone, Font, BrBlack, 320, 51);//
                //tbl.DrawString(obshPloshZar, Font, BrBlack, 427, 51);//
                tbl.DrawString(ukr, Font, BrBlack, 1, 151);//
                tbl.DrawString(poteriT, Font, BrBlack, 107, 151);//
                tbl.DrawString(NIS, Font, BrBlack, 213, 151);//
                //tbl.DrawString(SIZ, Font, BrBlack, 320, 151);//

                //tbl.DrawString(obj, Font, BrBlack, 0, 283);//
                //tbl.DrawString(open, Font, BrBlack, 0, 300);//

                if (Form1.lockpanel == 0)
                {
                    //Текст в таблице
                    tbl.DrawString(tipAXOB, Font, BrBlack, 320, 101);//
                    tbl.DrawString(kolAXOBl, Font, BrBlack, 427, 101);//
                    tbl.DrawString(tipSIZ + "\n" + ukritie, Font, BrBlack, 427, 1);//

                    tbl.DrawString(AXOB, Font, BrBlack, 320, 151);//
                    tbl.DrawString(kolvoAXOB, Font, BrBlack, 427, 151);//
                    tbl.DrawString(SIZ + "\n" + ukr, Font, BrBlack, 427, 51);//
                }
                else
                {
                    //Таблица
                    tbl.DrawLine(PBlack, 0, 280, 0, 200);//
                    tbl.DrawLine(PBlack, 1, 280, 1, 200);//
                    tbl.DrawLine(PBlack, 178, 280, 178, 200);//
                    tbl.DrawLine(PBlack, 356, 280, 356, 200);//
                    tbl.DrawLine(PBlack, 533, 280, 533, 200);//
                    tbl.DrawLine(PBlack, 534, 280, 534, 200);//

                    tbl.DrawLine(PBlack, 0, 280, 0, 360);//
                    tbl.DrawLine(PBlack, 1, 280, 1, 360);//
                    tbl.DrawLine(PBlack, 267, 280, 267, 360);//
                    tbl.DrawLine(PBlack, 533, 280, 533, 360);//
                    tbl.DrawLine(PBlack, 534, 280, 534, 360);//

                    tbl.DrawLine(PBlack, 0, 280, 534, 280);//
                    tbl.DrawLine(PBlack, 0, 281, 534, 281);//
                    tbl.DrawLine(PBlack, 0, 360, 534, 360);//
                    tbl.DrawLine(PBlack, 0, 361, 534, 361);//

                    //Текст в таблице
                    tbl.DrawString(tipAXOB + " №1", Font, BrBlack, 320, 101);//
                    tbl.DrawString(kolAXOBl + " №1", Font, BrBlack, 427, 101);//
                    tbl.DrawString(tipSIZ + " №1" + "\n" + ukritie, Font, BrBlack, 427, 1);//
                    tbl.DrawString(AXOB1, Font, BrBlack, 320, 151);//
                    tbl.DrawString(kolvoAXOB1, Font, BrBlack, 427, 151);//
                    tbl.DrawString(SIZ1 + "\n" + ukr, Font, BrBlack, 427, 51);//

                    tbl.DrawString(tipAXOB + " №2: ", Font, BrBlack, 2, 201);//
                    tbl.DrawString("\n" + tipSIZ + "\n" + kolAXOBl + "\n№2: ", Font, BrBlack, 2, 225);//
                    tbl.DrawString(AXOB2, Font, BrBlack, 80, 201);//
                    tbl.DrawString("\n" + SIZ2 + "\n" + kolvoAXOB2, Font, BrBlack, 75, 225);//

                    tbl.DrawString(tipAXOB + " №3: ", Font, BrBlack, 179, 201);//
                    tbl.DrawString("\n" + tipSIZ + "\n" + kolAXOBl + "\n№3: ", Font, BrBlack, 179, 225);//
                    tbl.DrawString(AXOB3, Font, BrBlack, 259, 201);//
                    tbl.DrawString("\n" + SIZ3 + "\n" + kolvoAXOB3, Font, BrBlack, 254, 225);//

                    tbl.DrawString(tipAXOB + " №4: ", Font, BrBlack, 357, 201);//
                    tbl.DrawString("\n" + tipSIZ + "\n" + kolAXOBl + "\n№4: ", Font, BrBlack, 357, 225);//
                    tbl.DrawString(AXOB4, Font, BrBlack, 437, 201);//
                    tbl.DrawString("\n" + SIZ4 + "\n" + kolvoAXOB4, Font, BrBlack, 432, 225);//

                    tbl.DrawString(tipAXOB + " №5: ", Font, BrBlack, 2, 282);//
                    tbl.DrawString("\n" + tipSIZ + "\n" + kolAXOBl + "\n№5: ", Font, BrBlack, 2, 306);//
                    tbl.DrawString(AXOB5, Font, BrBlack, 80, 282);//
                    tbl.DrawString("\n" + SIZ5 + "\n" + kolvoAXOB5, Font, BrBlack, 75, 306);//

                    tbl.DrawString(tipAXOB + " №6: ", Font, BrBlack, 269, 282);//
                    tbl.DrawString("\n" + tipSIZ + "\n" + kolAXOBl + "\n№6: ", Font, BrBlack, 269, 306);//
                    tbl.DrawString(AXOB6, Font, BrBlack, 349, 282);//
                    tbl.DrawString("\n" + SIZ6 + "\n" + kolvoAXOB6, Font, BrBlack, 344, 306);//
                }
            }
            //Вывод картинок
            pictureob1.Image = bpm;
        }
    }
}
