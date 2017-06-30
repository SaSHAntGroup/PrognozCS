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
        //
        public static double M,//Молекулярная масса
            p,//Плотность вещества
            P,//Давление насыщенного пара Р при tкип
            D,//Пороговая токсодоза Д, мг * мин / л
            Dhlor=0.6,////Пороговая токсодоза Д для хлора, мг * мин / л
            tkip,//Температура кипения,tкип ,0С
            Q0,//количество выброшенного (разлившегося) при аварии вещества, т.
            Cp,//удельная теплоемкость  жидкого АХОВ, кДж/(кг*град)
            dT,//разность температур жидкого АХОВ до и после разрушения емкости, oС
            dHisp,//удельная теплота испарения жидкого АХОВ при температуре испарения, кДж/кг
            T1,//
            V1,//
            Qe1,//Эквивалентное количество вещества по первичному облаку (в тоннах)
            Qe2,//Эквивалентное количество вещества по вторичному облаку (в тоннах)
            h,//
            T,//
            N,//
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
            K7;//коэффициент, учитывающий влияние температуры воздуха

        public Form1()
        {
            InitializeComponent();
            //АХОВ
            substance.Items.Add("Хлор");
            //////////////////////////////
            //Вертикальная устойчивость атмосферы
            vertUst.Items.Add("Изотермия");
            vertUst.Items.Add("Инверсия");
            vertUst.Items.Add("Конвекция");
        }
        public void vertUst_SelectedIndexChanged(object sender, EventArgs e)
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
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //Коэффициенты для инверсии, изотермии и конвекции
            K1 = Cp * dT / dHisp;
            K3 = Dhlor / D;
            //Выбор АХОВ с агрегатным состоянием
            if (substance.Text == "Хлор")
            { 
                if (jid.Checked) { p = 0.0032; }
                if (gaz.Checked) { p = 1.553; K1 = K7 = 1.0; }
            }
            //Алгоритм проведения расчетов
            Qe1 = K1 * K3 * K5 * K7 * Q0;

            //Открытие вормы с результатом
            if (p == 0)
            {
                MessageBox.Show("Введите агрегатное состояние для выбранного вещества!",
             "Расчет не возможен!", MessageBoxButtons.OK);
            }
            else { new Form2().Show(); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
