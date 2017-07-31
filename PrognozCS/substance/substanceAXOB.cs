﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrognozCS
{
    class substanceAXOB
    {
        //Присваивание параметров АХОВ
        public static void Empty()
        {
            Form1.M = 0;
            Form1.tkip = 0;
            Form1.P = 0;
            Form1.D = 0;
            Form1.p = 0;
        }
        //////////////////////////////////////
        public static void Chlor()
        {
            Form1.M = 70.91;
            Form1.tkip = -34.7;
            Form1.P = 101.58;
            Form1.D = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0; Form1.K72 = 0.9; }
            if (Form1.t >= -20) { Form1.K7 = 0.3; Form1.K72 = 1; }
            if (Form1.t >= 0) { Form1.K7 = 0.6; Form1.K72 = 1; }
            if (Form1.t >= 20) { Form1.K7 = 1; Form1.K72 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 1.4; Form1.K72 = 2; }
            //Коэффициент К1
            Form1.K1 = 0.18;
        }
        //////////////////////////////////////
        public static void Ammiak()
        {
            Form1.M = 17.03;
            Form1.tkip = -33.42;
            Form1.P = 99.7;
            Form1.D = 15;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0; Form1.K72 = 0.9; }
            if (Form1.t >= -20) { Form1.K7 = 0.3; Form1.K72 = 1; }
            if (Form1.t >= 0) { Form1.K7 = 0.6; Form1.K72 = 1; }
            if (Form1.t >= 20) { Form1.K7 = 1; Form1.K72 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 1.4; Form1.K72 = 1; }
            //Коэффициент К1
            Form1.K1 = 0.18;
        }
        //////////////////////////////////////
        public static void VodorodChlor()
        {
            Form1.M = 36.46;
            Form1.tkip = -85.1;
            Form1.P = 100.8;
            Form1.D = 2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0.64; Form1.K72 = 1; }
            if (Form1.t >= -20) { Form1.K7 = 0.6; Form1.K72 = 1; }
            if (Form1.t >= 0) { Form1.K7 = 0.8; Form1.K72 = 1; }
            if (Form1.t >= 20) { Form1.K7 = 1; Form1.K72 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 1.2; Form1.K72 = 1; }
            //Коэффициент К1
            Form1.K1 = 0.28;
        }
        //////////////////////////////////////
        public static void VodorodBrom()
        {
            Form1.M = 80.92;
            Form1.tkip = -66.77;
            Form1.P = 101.6;
            Form1.D = 2.4;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0.2; Form1.K72 = 1; }
            if (Form1.t >= -20) { Form1.K7 = 0.5; Form1.K72 = 1; }
            if (Form1.t >= 0) { Form1.K7 = 0.8; Form1.K72 = 1; }
            if (Form1.t >= 20) { Form1.K7 = 1; Form1.K72 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 1.2; Form1.K72 = 1; }
            //Коэффициент К1
            Form1.K1 = 0.13;
        }
        //////////////////////////////////////
        public static void Serovodorod()
        {
            Form1.M = 34.08;
            Form1.tkip = -60.35;
            Form1.P = 118.37;
            Form1.D = 16.1;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0.3; Form1.K72 = 1; }
            if (Form1.t >= -20) { Form1.K7 = 0.5; Form1.K72 = 1; }
            if (Form1.t >= 0) { Form1.K7 = 0.8; Form1.K72 = 1; }
            if (Form1.t >= 20) { Form1.K7 = 1; Form1.K72 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 1.2; Form1.K72 = 1; }
            //Коэффициент К1
            Form1.K1 = 0.27;
        }
        //////////////////////////////////////
        public static void Fosgen()
        {
            Form1.M = 98.92;
            Form1.tkip = 8.2;
            Form1.P = 100.9;
            Form1.D = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0; Form1.K72 = 0.1; }
            if (Form1.t >= -20) { Form1.K7 = 0; Form1.K72 = 0.3; }
            if (Form1.t >= 0) { Form1.K7 = 0; Form1.K72 = 0.7; }
            if (Form1.t >= 20) { Form1.K7 = 1; Form1.K72 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 2.2; Form1.K72 = 1; }
            //Коэффициент К1
            Form1.K1 = 0.05;
        }
        //////////////////////////////////////
        public static void Ftor()
        {
            Form1.M = 38.0;
            Form1.tkip = -188.2;
            Form1.P = 101.44;
            Form1.D = 0.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0.7; Form1.K72 = 1; }
            if (Form1.t >= -20) { Form1.K7 = 0.8; Form1.K72 = 1; }
            if (Form1.t >= 0) { Form1.K7 = 0.9; Form1.K72 = 1; }
            if (Form1.t >= 20) { Form1.K7 = 1; Form1.K72 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 1.1; Form1.K72 = 1; }
            //Коэффициент К1
            Form1.K1 = 0.95;
        }
        //////////////////////////////////////
        public static void Chlorician()
        {
            Form1.M = 61.47;
            Form1.tkip = 12.6;
            Form1.P = 100.80;
            Form1.D = 0.75;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0; Form1.K72 = 0; }
            if (Form1.t >= -20) { Form1.K7 = 0; Form1.K72 = 0; }
            if (Form1.t >= 0) { Form1.K7 = 0; Form1.K72 = 0.6; }
            if (Form1.t >= 20) { Form1.K7 = 1; Form1.K72 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 3.9; Form1.K72 = 1; }
            //Коэффициент К1
            Form1.K1 = 0.04;
        }
        //////////////////////////////////////====================================
        public static void VodorodFtoristiy()
        {
            Form1.M = 20.01;
            Form1.tkip = 19.52;
            Form1.P = 103;
            Form1.D = 4;
            Form1.p = 0.989;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0.1; }
            if (Form1.t >= -20) { Form1.K7 = 0.2; }
            if (Form1.t >= 0) { Form1.K7 = 0.5; }
            if (Form1.t >= 20) { Form1.K7 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 1; }
            Form1.K72 = Form1.K7;
            //Коэффициент К1
            Form1.K1 = 0;
        }
        //////////////////////////////////////
        public static void VodorodCianistiy()
        {
            Form1.M = 27.03;
            Form1.tkip = 25.7;
            Form1.p = 0.687;
            Form1.P = 82.25;
            Form1.D = 0.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0; }
            if (Form1.t >= -20) { Form1.K7 = 0; }
            if (Form1.t >= 0) { Form1.K7 = 0.4; }
            if (Form1.t >= 20) { Form1.K7 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 1.3; }
            Form1.K72 = Form1.K7;
            //Коэффициент К1
            Form1.K1 = 0;
        }
        //////////////////////////////////////
        public static void DvuokisAzota()
        {
            Form1.M = 46.01;
            Form1.tkip = 21.0;
            Form1.p = 1.491;
            Form1.P = 97.04;
            Form1.D = 1.5;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0; }
            if (Form1.t >= -20) { Form1.K7 = 0; }
            if (Form1.t >= 0) { Form1.K7 = 0.4; }
            if (Form1.t >= 20) { Form1.K7 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 1; }
            Form1.K72 = Form1.K7;
            //Коэффициент К1
            Form1.K1 = 0;
        }
        //////////////////////////////////////
        public static void SernistiyAngidrid()
        {
            Form1.M = 64.06;
            Form1.tkip = -10.1;
            Form1.p = 1.462;
            Form1.P = 100.8;
            Form1.D = 1.8;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0; Form1.K72 = 0.2; }
            if (Form1.t >= -20) { Form1.K7 = 0; Form1.K72 = 0.5; }
            if (Form1.t >= 0) { Form1.K7 = 0.3; Form1.K72 = 1; }
            if (Form1.t >= 20) { Form1.K7 = 1; Form1.K72 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 1.7; Form1.K72 = 1; }
            //Коэффициент К1
            Form1.K1 = 0.11;
        }
        //////////////////////////////////////
        public static void Serouglerod()
        {
            Form1.M = 76.14;
            Form1.tkip = 46.2;
            Form1.p = 1.263;
            Form1.P = 39.60;
            Form1.D = 45;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0.1; }
            if (Form1.t >= -20) { Form1.K7 = 0.2; }
            if (Form1.t >= 0) { Form1.K7 = 0.4; }
            if (Form1.t >= 20) { Form1.K7 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 2.1; }
            Form1.K72 = Form1.K7;
            //Коэффициент К1
            Form1.K1 = 0;
        }
        //////////////////////////////////////
        public static void SolyanayaKislota()
        {
            Form1.M = 36.46;
            Form1.tkip = 108.6;
            Form1.p = 1.198;
            Form1.P = 57.19;
            Form1.D = 2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0; }
            if (Form1.t >= -20) { Form1.K7 = 0.1; }
            if (Form1.t >= 0) { Form1.K7 = 0.3; }
            if (Form1.t >= 20) { Form1.K7 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 1.6; }
            Form1.K72 = Form1.K7;
            //Коэффициент К1
            Form1.K1 = 0;
        }
        //////////////////////////////////////
        public static void Formaldegid()
        {
            Form1.M = 30.03;
            Form1.tkip = -19.0;
            Form1.p = 0.815;
            Form1.P = 102.10;
            Form1.D = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0; Form1.K72 = 0.4; }
            if (Form1.t >= -20) { Form1.K7 = 0; Form1.K72 = 1; }
            if (Form1.t >= 0) { Form1.K7 = 0.5; Form1.K72 = 1; }
            if (Form1.t >= 20) { Form1.K7 = 1; Form1.K72 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 1.5; Form1.K72 = 1; }
            //Коэффициент К1
            Form1.K1 = 0.19;
        }
        //////////////////////////////////////
        //////////////////////////////////////
        public static void VodorodMishyak()
        {
            Form1.tkip = -62.47;
            Form1.D = 0.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0.3; Form1.K72 = 1; }
            if (Form1.t >= -20) { Form1.K7 = 0.5; Form1.K72 = 1; }
            if (Form1.t >= 0) { Form1.K7 = 0.8; Form1.K72 = 1; }
            if (Form1.t >= 20) { Form1.K7 = 1; Form1.K72 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 1.2; Form1.K72 = 1; }
            //Коэффициент К1
            Form1.K1 = 0.17;
            Form1.K2 = 0.054;
        }
        //////////////////////////////////////
        public static void Dimetilamin()
        {
            Form1.tkip = 6.9;
            Form1.D = 1.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0; Form1.K72 = 0.1; }
            if (Form1.t >= -20) { Form1.K7 = 0; Form1.K72 = 0.3; }
            if (Form1.t >= 0) { Form1.K7 = 0; Form1.K72 = 0.8; }
            if (Form1.t >= 20) { Form1.K7 = 1; Form1.K72 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 2.5; Form1.K72 = 1; }
            //Коэффициент К1
            Form1.K1 = 0.06;
            Form1.K2 = 0.041;
        }
        //////////////////////////////////////
        public static void Metilamin()
        {
            Form1.tkip = -6.5;
            Form1.D = 1.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0; Form1.K72 = 0.3; }
            if (Form1.t >= -20) { Form1.K7 = 0; Form1.K72 = 0.7; }
            if (Form1.t >= 0) { Form1.K7 = 0.5; Form1.K72 = 1; }
            if (Form1.t >= 20) { Form1.K7 = 1; Form1.K72 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 2.5; Form1.K72 = 1; }
            //Коэффициент К1
            Form1.K1 = 0.13;
            Form1.K2 = 0.034;
        }
        //////////////////////////////////////
        public static void MetilChlor()
        {
            Form1.tkip = -23.76;
            Form1.D = 10.8;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0; Form1.K72 = 130.5; }
            if (Form1.t >= -20) { Form1.K7 = 0.1; Form1.K72 = 1; }
            if (Form1.t >= 0) { Form1.K7 = 0.6; Form1.K72 = 1; }
            if (Form1.t >= 20) { Form1.K7 = 1; Form1.K72 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 1.5; Form1.K72 = 1; }
            //Коэффициент К1
            Form1.K1 = 0.125;
            Form1.K2 = 0.044;
        }
        //////////////////////////////////////
        public static void NitrilAkrilKisl()
        {
            Form1.tkip = 77.3;
            Form1.p = 0.806;
            Form1.D = 0.75;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K7 = 0.04; }
            if (Form1.t >= -20) { Form1.K7 = 0.1; }
            if (Form1.t >= 0) { Form1.K7 = 0.4; }
            if (Form1.t >= 20) { Form1.K7 = 1; }
            if (Form1.t >= 40) { Form1.K7 = 2.4; }
            Form1.K72 = Form1.K7;
            //Коэффициент К1
            Form1.K1 = 0;
            Form1.K2 = 0.007;
        }
    }
}
