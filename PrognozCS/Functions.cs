using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrognozCS
{
    public class Functions
    {
        public void AXOB(double M,//Молекулярная масса
                double tkip,//Температура кипения,tкип ,0С
                double P,//Давление насы-щенного пара Р при tкип
                double D)//Пороговая токсодоза Д, мг * мин / л )
        {
            //
            //Параметры веществ
            //
            Form1 form = new Form1();
            if (form.substance.Text == "Хлор")
            {
                AXOB(70.91, -34.7, 101.58, 0.6);
            }
        }

        public void Selection()
        {
            Form1 form = new Form1();
            double d;
            if (form.substance.Text == "Хлор")
            {
                form.jid.Visible = true;
                form.gaz.Visible = true;
                if (form.jid.Checked) { d = 0.0032; }
                if (form.gaz.Checked) { d = 1.553; }
                else
                {
                    MessageBox.Show("Расчет не возможен",
                 "Введите агрегатное состояние для выбранного вещества", MessageBoxButtons.OK);
                }
            }
        }
    }
}
