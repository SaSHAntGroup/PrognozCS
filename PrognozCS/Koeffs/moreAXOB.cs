using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrognozCS
{
    class moreAXOB
    {
        public static void koefAXOB()
        {
            //Коэффициенты К2, К3 и К4
            if (Form1.K21 == 0) { Form1.K21 = 6.08 * Math.Pow(10, -5)
                    * Form1.Pi1 * Math.Pow(Form1.M1, 0.5); }
            if (Form1.K22 == 0) { Form1.K22 = 6.08 * Math.Pow(10, -5)
                    * Form1.Pi2 * Math.Pow(Form1.M2, 0.5); }
            if (Form1.K23 == 0) { Form1.K23 = 6.08 * Math.Pow(10, -5)
                    * Form1.Pi3 * Math.Pow(Form1.M3, 0.5); }
            if (Form1.K24 == 0) { Form1.K24 = 6.08 * Math.Pow(10, -5)
                    * Form1.Pi4 * Math.Pow(Form1.M4, 0.5); }
            if (Form1.K25 == 0) { Form1.K25 = 6.08 * Math.Pow(10, -5)
                    * Form1.Pi5 * Math.Pow(Form1.M5, 0.5); }
            if (Form1.K26 == 0) { Form1.K26 = 6.08 * Math.Pow(10, -5)
                    * Form1.Pi6 * Math.Pow(Form1.M6, 0.5); }
            Form1.K31 = Form1.Dhlor / Form1.D1;
            Form1.K32 = Form1.Dhlor / Form1.D2;
            Form1.K33 = Form1.Dhlor / Form1.D3;
            Form1.K34 = Form1.Dhlor / Form1.D4;
            Form1.K35 = Form1.Dhlor / Form1.D5;
            Form1.K36 = Form1.Dhlor / Form1.D6;
            if (Form1.D1 == 0) { Form1.K31 = 0; }
            if (Form1.D2 == 0) { Form1.K32 = 0; }
            if (Form1.D3 == 0) { Form1.K33 = 0; }
            if (Form1.D4 == 0) { Form1.K34 = 0; }
            if (Form1.D5 == 0) { Form1.K35 = 0; }
            if (Form1.D6 == 0) { Form1.K36 = 0; }
            Form1.K4 = Form1.v / 3 + 0.67;
        }
    }
}
