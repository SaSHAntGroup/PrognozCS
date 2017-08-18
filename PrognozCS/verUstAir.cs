using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrognozCS
{
    class verUstAir
    {
        public static void Inversia()
        {
            Form1.K5 = 1.0;
            Form1.Kv = 0.081;
            if (Form1.v >= 0)
            {
                Form1.W = 5;
            }
            if (Form1.v > 1)
            {
                Form1.W = 10;
            }
            if (Form1.v > 2)
            {
                Form1.W = 16;
            }
            if (Form1.v > 3)
            {
                Form1.W = 21;
            }
        }
        public static void Izotermia()
        {
            Form1.K5 = 0.23;
            Form1.Kv = 0.0133;
            if (Form1.v <= 1)
            {
                Form1.W = 6;
            }
            if ((Form1.v > 1) && (Form1.v <= 2))
            {
                Form1.W = 12;
            }
            if ((Form1.v > 2) && (Form1.v <= 3))
            {
                Form1.W = 18;
            }
            if ((Form1.v > 3) && (Form1.v <= 4))
            {
                Form1.W = 24;
            }
            if ((Form1.v > 4) && (Form1.v <= 5))
            {
                Form1.W = 29;
            }
            if ((Form1.v > 5) && (Form1.v <= 6))
            {
                Form1.W = 35;
            }
            if ((Form1.v > 6) && (Form1.v <= 7))
            {
                Form1.W = 41;
            }
            if ((Form1.v > 7) && (Form1.v <= 8))
            {
                Form1.W = 47;
            }
            if ((Form1.v > 8) && (Form1.v <= 9))
            {
                Form1.W = 53;
            }
            if ((Form1.v > 9) && (Form1.v <= 10))
            {
                Form1.W = 59;
            }
            if ((Form1.v > 10) && (Form1.v <= 11))
            {
                Form1.W = 65;
            }
            if ((Form1.v > 11) && (Form1.v <= 12))
            {
                Form1.W = 71;
            }
            if ((Form1.v > 12) && (Form1.v <= 13))
            {
                Form1.W = 76;
            }
            if ((Form1.v > 13) && (Form1.v <= 14))
            {
                Form1.W = 82;
            }
            if (Form1.v > 14)
            {
                Form1.W = 88;
            }
        }
        public static void Konvekcia()
        {
            Form1.K5 = 0.08;
            Form1.Kv = 0.235;
            if (Form1.v <= 1)
            {
                Form1.W = 7;
            }
            if (Form1.v <= 2)
            {
                Form1.W = 14;
            }
            if (Form1.v <= 3)
            {
                Form1.W = 21;
            }
            if (Form1.v > 3)
            {
                Form1.W = 28;
            }
        }
    }
}
