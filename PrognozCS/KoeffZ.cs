using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrognozCS
{
    class KoeffZ
    {
        //Городские оповещенные
        public static void GorOpovesh()
        {
            //if (Form1.N <= 0.25)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kgk = 0.95; }
            //    if (Form1.Tsut >= 6) { Form1.Kgk = 0.84; }
            //    if (Form1.Tsut >= 7) { Form1.Kgk = 0.64; }
            //    if (Form1.Tsut >= 10) { Form1.Kgk = 0.69; }
            //    if (Form1.Tsut >= 13) { Form1.Kgk = 0.72; }
            //    if (Form1.Tsut >= 15) { Form1.Kgk = 0.68; }
            //    if (Form1.Tsut >= 17) { Form1.Kgk = 0.69; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = 0.88; }
            //}
            //if (Form1.N <= 0.5)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kgk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = ; }
            //}
            //if (Form1.N <= 1)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kgk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = ; }
            //}
            //if (Form1.N <= 2)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kgk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = ; }
            //}
            //if (Form1.N > 2)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kgk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = ; }
            //}
        }
        //Городские не оповещенные
        public static void GorNeOpovesh()
        {
            //if (Form1.N <= 0.25)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kgk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = ; }
            //}
            //if (Form1.N <= 0.5)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kgk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = ; }
            //}
            //if (Form1.N <= 1)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kgk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = ; }
            //}
            //if (Form1.N <= 2)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kgk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = ; }
            //}
            //if (Form1.N > 2)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kgk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kgk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = ; }
            //}
        }
        //Загородная зона, зимой, оповещенные
        public static void SelOpovZim()
        {
            //if (Form1.N <= 0.25)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
            //if (Form1.N <= 0.5)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
            //if (Form1.N <= 1)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
            //if (Form1.N <= 2)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
            //if (Form1.N > 2)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
        }
        //Загородная зона, зимой, не оповещенные
        public static void SelNeOpovZim()
        {
            //if (Form1.N <= 0.25)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
            //if (Form1.N <= 0.5)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
            //if (Form1.N <= 1)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
            //if (Form1.N <= 2)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
            //if (Form1.N > 2)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
        }
        //Загородная зона, с\х период, оповещенные
        public static void SelOpovSH()
        {
            //if (Form1.N <= 0.25)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
            //if (Form1.N <= 0.5)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
            //if (Form1.N <= 1)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
            //if (Form1.N <= 2)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
            //if (Form1.N > 2)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
        }
        //Загородная зона, с\х период, не оповещенные
        public static void SelNeOpovSH()
        {
            //if (Form1.N <= 0.25)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
            //if (Form1.N <= 0.5)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
            //if (Form1.N <= 1)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
            //if (Form1.N <= 2)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
            //if (Form1.N > 2)
            //{
            //    if (Form1.Tsut >= 1) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 6) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 7) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 10) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 13) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 15) { Form1.Kzk = ; }
            //    if (Form1.Tsut >= 17) { Form1.Kzk = ; }
            //    if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            //}
        }

    }
}
