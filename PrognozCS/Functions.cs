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
        public static void AXOB(double M,//Молекулярная масса
            double tkip,//Температура кипения,tкип ,0С
            double P,//Давление насы-щенного пара Р при tкип
            double D)//Пороговая токсодоза Д, мг * мин / л )
        {
            double d;
            Form1 combo = new Form1();
            Form1 radio = new Form1();
            if (combo.substance.Text == "Хлор")
            {
                AXOB(70.91,-34.7,101.58,0.6);
                if ( radio.jid.Checked ) { d = 0.0032; }
                if ( radio.gaz.Checked ) { d = 1.553; }
                else { MessageBox.Show("Расчет не возможен", 
                    "Введите агрегатное состояние для выбранного вещества", MessageBoxButtons.OK); }
            }
        }
    }
}
