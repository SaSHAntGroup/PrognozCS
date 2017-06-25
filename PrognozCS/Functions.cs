using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrognozCS
{
    public class Functions
    {
        //
        //Параметры веществ
        //
        double d;
        public void AXOB(double M,//Молекулярная масса
            double tkip,//Температура кипения,tкип ,0С
            double P,//Давление насы-щенного пара Р при tкип
            double D)//Пороговая токсодоза Д, мг * мин / л )
        {
            Form1 func = new Form1();
            if (func.substance.Text == "Хлор")
            {
                func.jid.Visible = true;
                func.gaz.Visible = true;
                AXOB(70.91,-34.7,101.58,0.6);
                if (func.jid.Checked) { d = 0.0032; }
                if (func.gaz.Checked) { d = 1.553; }
                else { MessageBox.Show("Расчет не возможен", 
                    "Введите агрегатное состояние для выбранного вещества", MessageBoxButtons.OK); }
            }
        }
    }
}
