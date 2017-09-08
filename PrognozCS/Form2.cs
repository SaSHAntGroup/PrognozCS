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
    public partial class Form2 : Form
    {
        public static double S;
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

            glub.Text = Form1.G.ToString() + " км";
            ploshad.Text = Form1.Sf.ToString() + " км²";
            time.Text = Form1.Txh.ToString() + " часов " + Txm.ToString() + " минут";

            if (Form1.p == 0) { label00.Text = "Вещество не указано"; }
            else { label00.Text = Form1.Txh0.ToString() + " часов " + Txm0.ToString() + " минут"; }
            if (Form1.p1 == 0) { label01.Text = "Вещество не указано"; }
            else { label01.Text = Form1.Txh1.ToString() + " часов " + Txm1.ToString() + " минут"; }
            if (Form1.p2 == 0) { label02.Text = "Вещество не указано"; }
            else { label02.Text = Form1.Txh2.ToString() + " часов " + Txm2.ToString() + " минут"; }
            if (Form1.p3 == 0) { label03.Text = "Вещество не указано"; }
            else { label03.Text = Form1.Txh3.ToString() + " часов " + Txm3.ToString() + " минут"; }
            if (Form1.p4 == 0) { label04.Text = "Вещество не указано"; }
            else { label04.Text = Form1.Txh4.ToString() + " часов " + Txm4.ToString() + " минут"; }
            if (Form1.p5 == 0) { label05.Text = "Вещество не указано"; }
            else { label05.Text = Form1.Txh5.ToString() + " часов " + Txm5.ToString() + " минут"; }
            if (Form1.p6 == 0) { label06.Text = "Вещество не указано"; }
            else { label06.Text = Form1.Txh6.ToString() + " часов " + Txm6.ToString() + " минут"; }
            
            if (Form1.Q01 == 0) { label01.Visible = false; labelTime1.Visible = false; }
            if (Form1.Q02 == 0) { label02.Visible = false; labelTime2.Visible = false; }
            if (Form1.Q03 == 0) { label03.Visible = false; labelTime3.Visible = false; }
            if (Form1.Q04 == 0) { label04.Visible = false; labelTime4.Visible = false; }
            if (Form1.Q05 == 0) { label05.Visible = false; labelTime5.Visible = false; }
            if (Form1.Q06 == 0) { label06.Visible = false; labelTime6.Visible = false; }

            poteri1.Text = Form1.P1.ToString() + " чел";
            poteri2.Text = Form1.P2.ToString() + " чел";
            poteri3.Text = Form1.P3.ToString() + " чел";

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
            string istZaraj = "Источник\nзаражения";
            string tipAXOB = "Тип\nАХОВ";
            string kolAXOBl = "Кол-во\nАХОВ";
            string glubZonel = "Глубина\nзоны\nзаражения";
            string poteri = "Потери\nот\nАХОВ";
            string tipSIZ = "Тип СИЗ";
            string primNIS = "Примечание\nНИС";
            string ukritie = "Укрытие.\nПроница-\nемость,\nкг / м * ч";
            string kolvoAXOB = Convert.ToString(Form1.Q0) + " т";
            string glubZone = Form1.G.ToString() + " км";
            string obshPloshZar = Form1.Sf.ToString() + " км²";
            string Zaraj;
            string AXOB;
            string SIZ;
            string vertUst;
            string ukr;

            switch (Form1.vert)
            {
                case 1:
                    vertUst = "Инверсия";
                    break;
                case 2:
                    vertUst = "Изотермия";
                    break;
                case 3:
                    vertUst = "Конвекция";
                    break;
                default:
                    vertUst = "Не указано!";
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

            switch (Form1.AXOB)
            {
                case 1:
                    AXOB = "Хлор";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 2:
                    AXOB = "Аммиак";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 3:
                    AXOB = "Водород хлористый";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 4:
                    AXOB = "Водород бромистый";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 5:
                    AXOB = "Сероводород";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 6:
                    AXOB = "Фосген";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 7:
                    AXOB = "Фтор";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 8:
                    AXOB = "Хлорициан";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 9:
                    AXOB = "Водород фтористый";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 10:
                    AXOB = "Водород цианистый";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 11:
                    AXOB = "Двуокись азота";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 12:
                    AXOB = "Сернистый ангидрид";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 13:
                    AXOB = "Сероуглерод";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 14:
                    AXOB = "Соляная кислота";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 15:
                    AXOB = "Формальдегид";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 16:
                    AXOB = "Водород мышьяковистый";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 17:
                    AXOB = "Диметиламин";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 18:
                    AXOB = "Метиламин";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 19:
                    AXOB = "Метил хлористый";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 20:
                    AXOB = "Нитрил акриловая кислота";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 21:
                    AXOB = "Акролеин";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 22:
                    AXOB = "Ацетонитрил";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 23:
                    AXOB = "Ацетонциангидрид";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 24:
                    AXOB = "Метил бромистый";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 25:
                    AXOB = "Метилакрилат";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 26:
                    AXOB = "Метилмеркаптан";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 27:
                    AXOB = "Окись этилена";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 28:
                    AXOB = "Триметиламин";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 29:
                    AXOB = "Фосфор треххлористый";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 30:
                    AXOB = "Фосфора хлорокись";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 31:
                    AXOB = "Хлорпикрин";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 32:
                    AXOB = "Этиленимин";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 33:
                    AXOB = "Этиленсульфид";
                    SIZ = "ГП-5\nГП-7";
                    break;
                case 34:
                    AXOB = "Этилмеркаптан";
                    SIZ = "ГП-5\nГП-7";
                    break;
                default:
                    AXOB = "Нет данных!";
                    SIZ = "Не \nисполь-\nзуется!";
                    break;
            }

            tbl.FillRectangle(BrSilver, 0, 0, 999, 999);//Заполнение пикчербокса в рисунке
            if (Form1.obj == 1)
            {
                //Таблица
                tbl.DrawLine(PBlack, 0, 0, 522, 0);//
                tbl.DrawLine(PBlack, 0, 50, 522, 50);//
                tbl.DrawLine(PBlack, 0, 100, 522, 100);//

                tbl.DrawLine(PBlack, 0, 0, 0, 100);//
                tbl.DrawLine(PBlack, 100, 0, 100, 100);//
                tbl.DrawLine(PBlack, 167, 0, 167, 100);//
                tbl.DrawLine(PBlack, 210, 0, 210, 100);//
                tbl.DrawLine(PBlack, 270, 0, 270, 100);//
                tbl.DrawLine(PBlack, 320, 0, 320, 100);//
                tbl.DrawLine(PBlack, 360, 0, 360, 100);//
                tbl.DrawLine(PBlack, 410, 0, 410, 100);//
                tbl.DrawLine(PBlack, 521, 0, 521, 100);//

                //Текст в таблице
                tbl.DrawString(istZaraj, Font, BrBlack, 0, 0);//
                tbl.DrawString(tipAXOB, Font, BrBlack, 100, 0);//
                tbl.DrawString(kolAXOBl, Font, BrBlack, 167, 0);//
                tbl.DrawString(glubZonel, Font, BrBlack, 210, 0);//
                tbl.DrawString(ukritie, Font, BrBlack, 270, 0);//
                tbl.DrawString(poteri, Font, BrBlack, 320, 0);//
                tbl.DrawString(tipSIZ, Font, BrBlack, 360, 0);//
                tbl.DrawString(primNIS, Font, BrBlack, 410, 0);//

                tbl.DrawString(Zaraj, Font, BrBlack, 0, 50);//
                tbl.DrawString(AXOB, Font, BrBlack, 100, 60);//
                tbl.DrawString(kolvoAXOB, Font, BrBlack, 170, 60);//
                tbl.DrawString(glubZone, Font, BrBlack, 215, 60);//
                tbl.DrawString("ukr", Font, BrBlack, 270, 60);//
                tbl.DrawString("poteri", Font, BrBlack, 320, 60);//
                tbl.DrawString(SIZ, Font, BrBlack, 360, 50);//
                tbl.DrawString(NIS, Font, BrBlack, 410, 50);//
            }
            //Вывод картинок
            pictureob1.Image = bpm;
        }
    }
}
