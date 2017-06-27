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
        public Form1()
        {
            InitializeComponent();
            //Добавление АХОВ в комбобокс
            substance.Items.Add("Хлор");
        }
        public static double M,d,P,D,tkip;

        private void substance_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Functions().Selection();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //Выполнение функции с присваиванием параметров вещества
            //new Functions().AXOB();
            //double Q0,//
            //    H,//
            //    T1,//
            //    V1,//
            //    Qe1,//
            //    Qe2,//
            //    h,//
            //    T,//
            //    N;//
            ////Коэффициенты для инверсии, изотермии и конвекции
            //void Koeff(double K1,double K2,double K3,double K4,
            //    double K5,double K6,double K7)
            //{
            //    ;
            //}
            //double Gh,//
            //    Gm,//
            //    Gb,//
            //    Qb,//
            //    Qm,//
            //    Qh;//
            //Открытие вормы с результатом
            new Form2().Show();
    }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
