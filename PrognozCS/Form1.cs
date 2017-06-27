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
        public static double M,//Молекулярная масса
            d,//Плотность вещества
            P,//Давление насыщенного пара Р при tкип
            D,//Пороговая токсодоза Д, мг * мин / л
            tkip;//Температура кипения,tкип ,0С
        public Form1()
        {
            InitializeComponent();
            //Добавление АХОВ в комбобокс
            substance.Items.Add("Хлор");
            //////////////////////////////
        }
        public void substance_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Выполнение функции с присваиванием параметров вещества
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
            if (substance.Text == "Хлор")
            { 
                if (jid.Checked) { d = 0.0032; }
                if (gaz.Checked) { d = 1.553; }
            }
            //double Q0,//
            //    H,//
            //    T1,//
            //    V1,//
            //    Qe1,//
            //    Qe2,//
            //    h,//
            //    T,//
            //    N;//
            //Коэффициенты для инверсии, изотермии и конвекции
            void Koeff(double K1, double K2, double K3, double K4,
                double K5, double K6, double K7)
            {
                ;
            }
            //double Gh,//
            //    Gm,//
            //    Gb,//
            //    Qb,//
            //    Qm,//
            //    Qh;//
            //Открытие вормы с результатом
            if (d == 0)
            {
                MessageBox.Show("Введите агрегатное состояние для выбранного вещества",
             "Расчет не возможен", MessageBoxButtons.OK);
            }
            else { new Form2().Show(); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
