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
    public partial class Form1 : Form
    {
        //Заявление переменных для расчета
        public static double M,//Молекулярная масса
            p,//Плотность вещества
            P,//Давление насыщенного пара Р при tкип
            D,//Пороговая токсодоза Д, мг * мин / л
            Dhlor=0.6,////Пороговая токсодоза Д для хлора, мг * мин / л
            tkip,//Температура кипения,tкип ,0С
            Q0,//количество выброшенного (разлившегося) при аварии вещества, т.
            Cp,//удельная теплоемкость  жидкого АХОВ, кДж/(кг*град)
            dT,//разность температур жидкого АХОВ до и после разрушения емкости, 0С
            dHisp,//удельная теплота испарения жидкого АХОВ при температуре испарения, кДж/кг
            v,//значение скорости ветра, м/с
            Vh,//объем хранилища, м3
            n,//процентное содержание АХОВ в газовом потоке, %
            d,//диаметр трубопровода, м
            l,//длина секции газопровода между автоматическими отсекателями, м
            t,//температура окружающей среды, 0С
            F,//реальная площадь разлива в поддоны, м2
            T1,//
            V1,//
            Qe1,//Эквивалентное количество вещества по первичному облаку (в тоннах)
            Qe2,//Эквивалентное количество вещества по вторичному облаку (в тоннах)
            h,//Толщина слоя жидкости разлившейся свободно, постоянна, м
            H,//высота поддона (обвалования), м
            T,//продолжительность поражающего действия АХОВ
            N,//время прошедшее с момента аварии, час
            Gh,//
            Gm,//
            Gb,//
            Qb,//
            Qm,//
            Qh,//
            K1,//коэффициент, зависящий от условий хранения АХОВ
            K2,//коэффициент, зависящий от физико-химических свойств АХОВ
            K3,//коэффициент, равный отношению пороговой токсодозы хлора к пороговой токсодозе другого АХОВ
            K4,// 
            K5,//коэффициент, учитывающий влияние степени вертикальной устойчивости атмосферы 
            K6,//
            K7,//коэффициент, учитывающий влияние температуры воздуха первичное облако
            K72;//коэффициент, учитывающий влияние температуры воздуха вторичное облако

        public Form1()
        {
            InitializeComponent();
            //Добавление АХОВ
            substance.Items.Add("Хлор");
            //////////////////////////////
            //Вертикальная устойчивость атмосферы
            vertUst.Items.Add("Изотермия");
            vertUst.Items.Add("Инверсия");
            vertUst.Items.Add("Конвекция");
        }

        public void svob_CheckedChanged(object sender, EventArgs e)
        {
            h = 0.05;
            visPod.Visible = false;
            visPodlabel.Visible = false;
            plosh.Visible = false;
            ploshlabel.Visible = false;
        }
        public void sam_CheckedChanged(object sender, EventArgs e)
        {
            visPod.Visible = true;
            visPodlabel.Visible = true;
            plosh.Visible = false;
            ploshlabel.Visible = false;
        }
        public void obsh_CheckedChanged(object sender, EventArgs e)
        {
            plosh.Visible = true;
            ploshlabel.Visible = true;
            visPod.Visible = false;
            visPodlabel.Visible = false;
        }
        public void substance_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Присваивание параметров АХОВ
            if (substance.Text == "Хлор")
            {
                jid.Visible = true;
                gaz.Visible = true;
                M = 70.91;
                tkip = -34.7;
                P = 101.58;
                D = 0.6;
                //Определение К7 при температуре окружающей среды
                if (t <= -40 && t < -20)
                {
                    K7 = 0;
                    K72 = 0.9;
                }
                if (t <= -20 && t < 0)
                {
                    K7 = 0.3;
                    K72 = 1;
                }
                if (t <= 0 && t < 20)
                {
                    K7 = 0.6;
                    K72 = 1;
                }
                if (t <= 20 && t <40)
                {
                    K7 = 1;
                    K72 = 1;
                }
                else
                {
                    K7 = 1.4;
                    K72 = 2;
                }
            }
            //////////////////////////////////////
        }
        public void button1_Click(object sender, EventArgs e)
        {
            //Присваивание параметров для вертикальной устойчивости атмосферы
            if (vertUst.Text == "Инверсия")
            {
                K5 = 1.0;
            }
            if (vertUst.Text == "Изотермия")
            {
                K5 = 0.23;
            }
            if (vertUst.Text == "Конвекция")
            {
                K5 = 0.08;
            }
            //Расчет высоты/площади
            if (sam.Checked == true)
            {
                H = Convert.ToDouble(visPod.Text);
                h = H - 0.2;
            }
            if (obsh.Checked == true)
            {
                F = Convert.ToDouble(plosh.Text);
                h = Q0 / F * p;
            }
            //Коэффициенты
            K1 = Cp * dT / dHisp;
            K2 = 6.08 * Math.Pow(10,-5) * P * Math.Pow(M,0.5);
            K3 = Dhlor / D;
            K4 = v / 3 + 0.67;
            // Расчет продолжительности поражающего действия АХОВ
            T = h * p / K2 * K4 * K7;
            //Определение К6
            if (N < T)
            {
                K6 = Math.Pow(N, 0.8);
            }
            if (N > T)
            {
                K6 = Math.Pow(T, 0.8);
            }
            if (T < 1)
            {
                K6 = 1;
            }
            //Выбор АХОВ с агрегатным состоянием
            if (substance.Text == "Хлор")
            {
                if (jid.Checked) { p = 0.0032; }
                if (gaz.Checked) { p = 1.553; }
            }
            /*
             * Алгоритм проведения расчетов
            */
            //Определение эквивалентного количества вещества по первичному облаку
            if (Vh == 0)
            {
                Q0 = (n * p * 3.14 * Math.Pow(d,2) / 4 * l) * 100;
            }
            else
            {
                Q0 = p * Vh;
            }
            Qe1 = K1 * K3 * K5 * K7 * Q0;
            //Определение эквивалентного количества вещества по вторичному облаку
            Qe2 = (1 - K1) * K2 * K3 * K4 * K5 * K6 * K7 * Q0 / h * p;
            //Открытие вормы с результатом
            if (p == 0)
            {
                MessageBox.Show("Выберите вещество и введите агрегатное состояние для выбранного вещества!",
             "Расчет не возможен!", MessageBoxButtons.OK);
            }
            else
            {
                new Form2().Show();
            }
        }
        public void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}