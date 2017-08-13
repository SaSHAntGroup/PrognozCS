using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrognozCS
{
    class KoeffZ
    {
<<<<<<< HEAD
        //Городские НЕ оповещенные !!
=======
        //Городские оповещенные
        public static void GorOpovesh()
        {
            if (Form1.N <= 0.25)
            {
                if (Form1.Tsut >= 1) { Form1.Kgk = 0.95; }
                if (Form1.Tsut >= 6) { Form1.Kgk = 0.84; }
                if (Form1.Tsut >= 7) { Form1.Kgk = 0.64; }
                if (Form1.Tsut >= 10) { Form1.Kgk = 0.69; }
                if (Form1.Tsut >= 13) { Form1.Kgk = 0.72; }
                if (Form1.Tsut >= 15) { Form1.Kgk = 0.68; }
                if (Form1.Tsut >= 17) { Form1.Kgk = 0.69; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = 0.88; }
            }
            if (Form1.N <= 0.5)
            {
                if (Form1.Tsut >= 1) { Form1.Kgk = ; }
                if (Form1.Tsut >= 6) { Form1.Kgk = ; }
                if (Form1.Tsut >= 7) { Form1.Kgk = ; }
                if (Form1.Tsut >= 10) { Form1.Kgk = ; }
                if (Form1.Tsut >= 13) { Form1.Kgk = ; }
                if (Form1.Tsut >= 15) { Form1.Kgk = ; }
                if (Form1.Tsut >= 17) { Form1.Kgk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = ; }
            }
            if (Form1.N <= 1)
            {
                if (Form1.Tsut >= 1) { Form1.Kgk = ; }
                if (Form1.Tsut >= 6) { Form1.Kgk = ; }
                if (Form1.Tsut >= 7) { Form1.Kgk = ; }
                if (Form1.Tsut >= 10) { Form1.Kgk = ; }
                if (Form1.Tsut >= 13) { Form1.Kgk = ; }
                if (Form1.Tsut >= 15) { Form1.Kgk = ; }
                if (Form1.Tsut >= 17) { Form1.Kgk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = ; }
            }
            if (Form1.N <= 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kgk = ; }
                if (Form1.Tsut >= 6) { Form1.Kgk = ; }
                if (Form1.Tsut >= 7) { Form1.Kgk = ; }
                if (Form1.Tsut >= 10) { Form1.Kgk = ; }
                if (Form1.Tsut >= 13) { Form1.Kgk = ; }
                if (Form1.Tsut >= 15) { Form1.Kgk = ; }
                if (Form1.Tsut >= 17) { Form1.Kgk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = ; }
            }
            if (Form1.N > 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kgk = ; }
                if (Form1.Tsut >= 6) { Form1.Kgk = ; }
                if (Form1.Tsut >= 7) { Form1.Kgk = ; }
                if (Form1.Tsut >= 10) { Form1.Kgk = ; }
                if (Form1.Tsut >= 13) { Form1.Kgk = ; }
                if (Form1.Tsut >= 15) { Form1.Kgk = ; }
                if (Form1.Tsut >= 17) { Form1.Kgk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = ; }
            }
        }
        //Городские не оповещенные
>>>>>>> parent of 78227da... Поправки..
        public static void GorNeOpovesh()
        {
            if (Form1.N <= 0.25)
            {
<<<<<<< HEAD
                if (Form1.Tsut >= 1) { Form1.Kgk = 0.95; }
                if (Form1.Tsut >= 6) { Form1.Kgk = 0.84; }
                if (Form1.Tsut >= 7) { Form1.Kgk = 0.64; }
                if (Form1.Tsut >= 10) { Form1.Kgk = 0.69; }
                if (Form1.Tsut >= 13) { Form1.Kgk = 0.72; }
                if (Form1.Tsut >= 15) { Form1.Kgk = 0.68; }
                if (Form1.Tsut >= 17) { Form1.Kgk = 0.69; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = 0.88; }
            }
            if (Form1.N <= 0.5)
            {
                if (Form1.Tsut >= 1) { Form1.Kgk = 0.89; }
                if (Form1.Tsut >= 6) { Form1.Kgk = 0.72; }
                if (Form1.Tsut >= 7) { Form1.Kgk = 0.54; }
                if (Form1.Tsut >= 10) { Form1.Kgk = 0.38; }
                if (Form1.Tsut >= 13) { Form1.Kgk = 0.64; }
                if (Form1.Tsut >= 15) { Form1.Kgk = 0.58; }
                if (Form1.Tsut >= 17) { Form1.Kgk = 0.62; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = 0.82; }
            }
            if (Form1.N <= 1)
            {
                if (Form1.Tsut >= 1) { Form1.Kgk = 0.76; }
                if (Form1.Tsut >= 6) { Form1.Kgk = 0.64; }
                if (Form1.Tsut >= 7) { Form1.Kgk = 0.35; }
                if (Form1.Tsut >= 10) { Form1.Kgk = 0.37; }
                if (Form1.Tsut >= 13) { Form1.Kgk = 0.47; }
                if (Form1.Tsut >= 15) { Form1.Kgk = 0.37; }
                if (Form1.Tsut >= 17) { Form1.Kgk = 0.47; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = 0.67; }
            }
            if (Form1.N <= 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kgk = 0.36; }
                if (Form1.Tsut >= 6) { Form1.Kgk = 0.29; }
                if (Form1.Tsut >= 7) { Form1.Kgk = 0.13; }
                if (Form1.Tsut >= 10) { Form1.Kgk = 0.15; }
                if (Form1.Tsut >= 13) { Form1.Kgk = 0.20; }
                if (Form1.Tsut >= 15) { Form1.Kgk = 0.15; }
                if (Form1.Tsut >= 17) { Form1.Kgk = 0.19; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = 0.30; }
            }
            if (Form1.N > 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kgk = 0.09; }
                if (Form1.Tsut >= 6) { Form1.Kgk = 0.07; }
                if (Form1.Tsut >= 7) { Form1.Kgk = 0.02; }
                if (Form1.Tsut >= 10) { Form1.Kgk = 0.03; }
                if (Form1.Tsut >= 13) { Form1.Kgk = 0.04; }
                if (Form1.Tsut >= 15) { Form1.Kgk = 0.03; }
                if (Form1.Tsut >= 17) { Form1.Kgk = 0.04; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = 0.07; }
=======
                if (Form1.Tsut >= 1) { Form1.Kgk = ; }
                if (Form1.Tsut >= 6) { Form1.Kgk = ; }
                if (Form1.Tsut >= 7) { Form1.Kgk = ; }
                if (Form1.Tsut >= 10) { Form1.Kgk = ; }
                if (Form1.Tsut >= 13) { Form1.Kgk = ; }
                if (Form1.Tsut >= 15) { Form1.Kgk = ; }
                if (Form1.Tsut >= 17) { Form1.Kgk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = ; }
            }
            if (Form1.N <= 0.5)
            {
                if (Form1.Tsut >= 1) { Form1.Kgk = ; }
                if (Form1.Tsut >= 6) { Form1.Kgk = ; }
                if (Form1.Tsut >= 7) { Form1.Kgk = ; }
                if (Form1.Tsut >= 10) { Form1.Kgk = ; }
                if (Form1.Tsut >= 13) { Form1.Kgk = ; }
                if (Form1.Tsut >= 15) { Form1.Kgk = ; }
                if (Form1.Tsut >= 17) { Form1.Kgk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = ; }
            }
            if (Form1.N <= 1)
            {
                if (Form1.Tsut >= 1) { Form1.Kgk = ; }
                if (Form1.Tsut >= 6) { Form1.Kgk = ; }
                if (Form1.Tsut >= 7) { Form1.Kgk = ; }
                if (Form1.Tsut >= 10) { Form1.Kgk = ; }
                if (Form1.Tsut >= 13) { Form1.Kgk = ; }
                if (Form1.Tsut >= 15) { Form1.Kgk = ; }
                if (Form1.Tsut >= 17) { Form1.Kgk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = ; }
            }
            if (Form1.N <= 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kgk = ; }
                if (Form1.Tsut >= 6) { Form1.Kgk = ; }
                if (Form1.Tsut >= 7) { Form1.Kgk = ; }
                if (Form1.Tsut >= 10) { Form1.Kgk = ; }
                if (Form1.Tsut >= 13) { Form1.Kgk = ; }
                if (Form1.Tsut >= 15) { Form1.Kgk = ; }
                if (Form1.Tsut >= 17) { Form1.Kgk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = ; }
            }
            if (Form1.N > 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kgk = ; }
                if (Form1.Tsut >= 6) { Form1.Kgk = ; }
                if (Form1.Tsut >= 7) { Form1.Kgk = ; }
                if (Form1.Tsut >= 10) { Form1.Kgk = ; }
                if (Form1.Tsut >= 13) { Form1.Kgk = ; }
                if (Form1.Tsut >= 15) { Form1.Kgk = ; }
                if (Form1.Tsut >= 17) { Form1.Kgk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = ; }
>>>>>>> parent of 78227da... Поправки..
            }
        }
        //Городские  оповещенные !!!
        public static void GorOpovesh()
        {
            if (Form1.N <= 0.25)
            {
<<<<<<< HEAD
                if (Form1.Tsut >= 1) { Form1.Kgk = 0.95; }
                if (Form1.Tsut >= 6) { Form1.Kgk = 0.93; }
                if (Form1.Tsut >= 7) { Form1.Kgk = 0.78; }
                if (Form1.Tsut >= 10) { Form1.Kgk = 0.79; }
                if (Form1.Tsut >= 13) { Form1.Kgk = 0.83; }
                if (Form1.Tsut >= 15) { Form1.Kgk = 0.79; }
                if (Form1.Tsut >= 17) { Form1.Kgk = 0.86; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = 0.91; }
            }
            if (Form1.N <= 0.5)
            {
                if (Form1.Tsut >= 1) { Form1.Kgk = 0.89; }
                if (Form1.Tsut >= 6) { Form1.Kgk = 0.87; }
                if (Form1.Tsut >= 7) { Form1.Kgk = 0.68; }
                if (Form1.Tsut >= 10) { Form1.Kgk = 0.67; }
                if (Form1.Tsut >= 13) { Form1.Kgk = 0.74; }
                if (Form1.Tsut >= 15) { Form1.Kgk = 0.69; }
                if (Form1.Tsut >= 17) { Form1.Kgk = 0.78; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = 0.85; }
            }
            if (Form1.N <= 1)
            {
                if (Form1.Tsut >= 1) { Form1.Kgk = 0.80; }
                if (Form1.Tsut >= 6) { Form1.Kgk = 0.74; }
                if (Form1.Tsut >= 7) { Form1.Kgk = 0.49; }
                if (Form1.Tsut >= 10) { Form1.Kgk = 0.47; }
                if (Form1.Tsut >= 13) { Form1.Kgk = 0.56; }
                if (Form1.Tsut >= 15) { Form1.Kgk = 0.49; }
                if (Form1.Tsut >= 17) { Form1.Kgk = 0.63; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = 0.71; }
            }
            if (Form1.N <= 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kgk = 0.36; }
                if (Form1.Tsut >= 6) { Form1.Kgk = 0.35; }
                if (Form1.Tsut >= 7) { Form1.Kgk = 0.22; }
                if (Form1.Tsut >= 10) { Form1.Kgk = 0.21; }
                if (Form1.Tsut >= 13) { Form1.Kgk = 0.25; }
                if (Form1.Tsut >= 15) { Form1.Kgk = 0.22; }
                if (Form1.Tsut >= 17) { Form1.Kgk = 0.28; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = 0.34; }
            }
            if (Form1.N > 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kgk = 0.09; }
                if (Form1.Tsut >= 6) { Form1.Kgk = 0.10; }
                if (Form1.Tsut >= 7) { Form1.Kgk = 0.06; }
                if (Form1.Tsut >= 10) { Form1.Kgk = 0.04; }
                if (Form1.Tsut >= 13) { Form1.Kgk = 0.05; }
                if (Form1.Tsut >= 15) { Form1.Kgk = 0.04; }
                if (Form1.Tsut >= 17) { Form1.Kgk = 0.06; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kgk = 0.09; }
=======
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            }
            if (Form1.N <= 0.5)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            }
            if (Form1.N <= 1)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            }
            if (Form1.N <= 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            }
            if (Form1.N > 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
>>>>>>> parent of 78227da... Поправки..
            }
        }
        //Загородная зона,  НЕ зимой, оповещенные !!!
        public static void SelNeOpovZim()
        {
            if (Form1.N <= 0.25)
            {
<<<<<<< HEAD
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.87; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.59; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.24; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.19; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.24; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.48; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.59; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.78; }
            }
            if (Form1.N <= 0.5)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.84; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.57; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.23; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.18; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.23; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.46; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.57; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.78; }
            }
            if (Form1.N <= 1)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.72; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.48; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.20; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.16; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.20; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.40; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.48; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.64; }
            }
            if (Form1.N <= 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.33; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.23; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.10; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.08; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.10; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.19; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.23; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.30; }
            }
            if (Form1.N > 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.15; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.05; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.02; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.02; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.02; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.05; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.05; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.07; }
=======
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            }
            if (Form1.N <= 0.5)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            }
            if (Form1.N <= 1)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            }
            if (Form1.N <= 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            }
            if (Form1.N > 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
>>>>>>> parent of 78227da... Поправки..
            }
        }
        //Загородная зона, зимой, оповещенные !!!
        public static void SelOpovZim()
        {
            if (Form1.N <= 0.25)
            {
<<<<<<< HEAD
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.89; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.81; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.39; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.33; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.39; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.59; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.66; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.81; }
            }
            if (Form1.N <= 0.5)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.85; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.77; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.37; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.31; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.37; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.57; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.62; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.77; }
            }
            if (Form1.N <= 1)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.74; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.67; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.32; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.27; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.32; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.48; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.55; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.67; }
            }
            if (Form1.N <= 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.35; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.20; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.15; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.13; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.15; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.23; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.26; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.32; }
            }
            if (Form1.N > 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.09; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.08; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.04; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.03; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.04; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.05; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.04; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.06; }
=======
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            }
            if (Form1.N <= 0.5)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            }
            if (Form1.N <= 1)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            }
            if (Form1.N <= 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            }
            if (Form1.N > 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
>>>>>>> parent of 78227da... Поправки..
            }
        }
        //Загородная зона, с\х период,  НЕ оповещенные !!
        public static void SelNeOpovSH()
        {
            if (Form1.N <= 0.25)
            {
<<<<<<< HEAD
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.72; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.39; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.24; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.19; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.17; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.15; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.19; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.48; }
            }
            if (Form1.N <= 0.5)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.69; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.37; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.23; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.18; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.14; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.14; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.18; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.46; }
            }
            if (Form1.N <= 1)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.60; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.32; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.20; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.16; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.12; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.12; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.16; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.40; }
            }
            if (Form1.N <= 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.28; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.15; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.10; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.08; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.06; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.06; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.08; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.19; }
            }
            if (Form1.N > 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.07; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.10; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.02; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.03; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.02; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.02; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.02; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.05; }
            }
        }
        //Загородная зона, с\х период, оповещенные !!
        public static void SelOpovSH()
        {
            if (Form1.N <= 0.25)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.78; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.50; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.39; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.33; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.31; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.31; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.35; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.59; }
            }
            if (Form1.N <= 0.5)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.73; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.48; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.37; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.31; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.30; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.30; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.33; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.57; }
            }
            if (Form1.N <= 1)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.64; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.42; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.32; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.27; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.26; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.26; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.29; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.48; }
            }
            if (Form1.N <= 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.30; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.21; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.13; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.13; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.12; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.12; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.14; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.23; }
            }
            if (Form1.N > 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = 0.08; }
                if (Form1.Tsut >= 6) { Form1.Kzk = 0.07; }
                if (Form1.Tsut >= 7) { Form1.Kzk = 0.4; }
                if (Form1.Tsut >= 10) { Form1.Kzk = 0.03; }
                if (Form1.Tsut >= 13) { Form1.Kzk = 0.03; }
                if (Form1.Tsut >= 15) { Form1.Kzk = 0.05; }
                if (Form1.Tsut >= 17) { Form1.Kzk = 0.03; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = 0.7; }
=======
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            }
            if (Form1.N <= 0.5)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            }
            if (Form1.N <= 1)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            }
            if (Form1.N <= 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
            }
            if (Form1.N > 2)
            {
                if (Form1.Tsut >= 1) { Form1.Kzk = ; }
                if (Form1.Tsut >= 6) { Form1.Kzk = ; }
                if (Form1.Tsut >= 7) { Form1.Kzk = ; }
                if (Form1.Tsut >= 10) { Form1.Kzk = ; }
                if (Form1.Tsut >= 13) { Form1.Kzk = ; }
                if (Form1.Tsut >= 15) { Form1.Kzk = ; }
                if (Form1.Tsut >= 17) { Form1.Kzk = ; }
                if ((Form1.Tsut >= 19) || (Form1.Tsut < 1)) { Form1.Kzk = ; }
>>>>>>> parent of 78227da... Поправки..
            }
        }
    }
}
