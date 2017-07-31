using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrognozCS
{
    class substanceAXOB1
    {
        //Присваивание параметров АХОВ
        public static void Empty()
        {
            Form1.M1 = 0;
            Form1.tkip1 = 0;
            Form1.Pi1 = 0;
            Form1.D1 = 0;
            Form1.p1 = 0;
        }
        //////////////////////////////////////
        public static void Chlor()
        {
            Form1.M1 = 70.91;
            Form1.tkip1 = -34.7;
            Form1.Pi1 = 101.58;
            Form1.D1 = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0; Form1.K721 = 0.9; }
            if (Form1.t >= -20) { Form1.K711 = 0.3; Form1.K721 = 1; }
            if (Form1.t >= 0) { Form1.K711 = 0.6; Form1.K721 = 1; }
            if (Form1.t >= 20) { Form1.K711 = 1; Form1.K721 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 1.4; Form1.K721 = 2; }
            //Коэффициент К1
            Form1.K11 = 0.18;
        }
        //////////////////////////////////////
        public static void Ammiak()
        {
            Form1.M1 = 17.03;
            Form1.tkip1 = -33.42;
            Form1.Pi1 = 99.7;
            Form1.D1 = 15;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0; Form1.K721 = 0.9; }
            if (Form1.t >= -20) { Form1.K711 = 0.3; Form1.K721 = 1; }
            if (Form1.t >= 0) { Form1.K711 = 0.6; Form1.K721 = 1; }
            if (Form1.t >= 20) { Form1.K711 = 1; Form1.K721 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 1.4; Form1.K721 = 1; }
            //Коэффициент К1
            Form1.K11 = 0.18;
        }
        //////////////////////////////////////
        public static void VodorodChlor()
        {
            Form1.M1 = 36.46;
            Form1.tkip1 = -85.1;
            Form1.Pi1 = 100.8;
            Form1.D1 = 2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0.64; Form1.K721 = 1; }
            if (Form1.t >= -20) { Form1.K711 = 0.6; Form1.K721 = 1; }
            if (Form1.t >= 0) { Form1.K711 = 0.8; Form1.K721 = 1; }
            if (Form1.t >= 20) { Form1.K711 = 1; Form1.K721 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 1.2; Form1.K721 = 1; }
            //Коэффициент К1
            Form1.K11 = 0.28;
        }
        //////////////////////////////////////
        public static void VodorodBrom()
        {
            Form1.M1 = 80.92;
            Form1.tkip1 = -66.77;
            Form1.Pi1 = 101.6;
            Form1.D1 = 2.4;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0.2; Form1.K721 = 1; }
            if (Form1.t >= -20) { Form1.K711 = 0.5; Form1.K721 = 1; }
            if (Form1.t >= 0) { Form1.K711 = 0.8; Form1.K721 = 1; }
            if (Form1.t >= 20) { Form1.K711 = 1; Form1.K721 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 1.2; Form1.K721 = 1; }
            //Коэффициент К1
            Form1.K11 = 0.13;
        }
        //////////////////////////////////////
        public static void Serovodorod()
        {
            Form1.M1 = 34.08;
            Form1.tkip1 = -60.35;
            Form1.Pi1 = 118.37;
            Form1.D1 = 16.1;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0.3; Form1.K721 = 1; }
            if (Form1.t >= -20) { Form1.K711 = 0.5; Form1.K721 = 1; }
            if (Form1.t >= 0) { Form1.K711 = 0.8; Form1.K721 = 1; }
            if (Form1.t >= 20) { Form1.K711 = 1; Form1.K721 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 1.2; Form1.K721 = 1; }
            //Коэффициент К1
            Form1.K11 = 0.27;
        }
        //////////////////////////////////////
        public static void Fosgen()
        {
            Form1.M1 = 98.92;
            Form1.tkip1 = 8.2;
            Form1.Pi1 = 100.9;
            Form1.D1 = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0; Form1.K721 = 0.1; }
            if (Form1.t >= -20) { Form1.K711 = 0; Form1.K721 = 0.3; }
            if (Form1.t >= 0) { Form1.K711 = 0; Form1.K721 = 0.7; }
            if (Form1.t >= 20) { Form1.K711 = 1; Form1.K721 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 2.2; Form1.K721 = 1; }
            //Коэффициент К1
            Form1.K11 = 0.05;
        }
        //////////////////////////////////////
        public static void Ftor()
        {
            Form1.M1 = 38.0;
            Form1.tkip1 = -188.2;
            Form1.Pi1 = 101.44;
            Form1.D1 = 0.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0.7; Form1.K721 = 1; }
            if (Form1.t >= -20) { Form1.K711 = 0.8; Form1.K721 = 1; }
            if (Form1.t >= 0) { Form1.K711 = 0.9; Form1.K721 = 1; }
            if (Form1.t >= 20) { Form1.K711 = 1; Form1.K721 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 1.1; Form1.K721 = 1; }
            //Коэффициент К1
            Form1.K11 = 0.95;
        }
        //////////////////////////////////////
        public static void Chlorician()
        {
            Form1.M1 = 61.47;
            Form1.tkip1 = 12.6;
            Form1.Pi1 = 100.80;
            Form1.D1 = 0.75;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0; Form1.K721 = 0; }
            if (Form1.t >= -20) { Form1.K711 = 0; Form1.K721 = 0; }
            if (Form1.t >= 0) { Form1.K711 = 0; Form1.K721 = 0.6; }
            if (Form1.t >= 20) { Form1.K711 = 1; Form1.K721 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 3.9; Form1.K721 = 1; }
            //Коэффициент К1
            Form1.K11 = 0.04;
        }
        //////////////////////////////////////====================================
        public static void VodorodFtoristiy()
        {
            Form1.M1 = 20.01;
            Form1.tkip1 = 19.52;
            Form1.Pi1 = 103;
            Form1.D1 = 4;
            Form1.p1 = 0.989;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0.1; }
            if (Form1.t >= -20) { Form1.K711 = 0.2; }
            if (Form1.t >= 0) { Form1.K711 = 0.5; }
            if (Form1.t >= 20) { Form1.K711 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 1; }
            Form1.K721 = Form1.K711;
            //Коэффициент К1
            Form1.K11 = 0;
        }
        //////////////////////////////////////
        public static void VodorodCianistiy()
        {
            Form1.M1 = 27.03;
            Form1.tkip1 = 25.7;
            Form1.p1 = 0.687;
            Form1.Pi1 = 82.25;
            Form1.D1 = 0.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0; }
            if (Form1.t >= -20) { Form1.K711 = 0; }
            if (Form1.t >= 0) { Form1.K711 = 0.4; }
            if (Form1.t >= 20) { Form1.K711 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 1.3; }
            Form1.K721 = Form1.K711;
            //Коэффициент К1
            Form1.K11 = 0;
        }
        //////////////////////////////////////
        public static void DvuokisAzota()
        {
            Form1.M1 = 46.01;
            Form1.tkip1 = 21.0;
            Form1.p1 = 1.491;
            Form1.Pi1 = 97.04;
            Form1.D1 = 1.5;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0; }
            if (Form1.t >= -20) { Form1.K711 = 0; }
            if (Form1.t >= 0) { Form1.K711 = 0.4; }
            if (Form1.t >= 20) { Form1.K711 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 1; }
            Form1.K721 = Form1.K711;
            //Коэффициент К1
            Form1.K11 = 0;
        }
        //////////////////////////////////////
        public static void SernistiyAngidrid()
        {
            Form1.M1 = 64.06;
            Form1.tkip1 = -10.1;
            Form1.p1 = 1.462;
            Form1.Pi1 = 100.8;
            Form1.D1 = 1.8;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0; Form1.K721 = 0.2; }
            if (Form1.t >= -20) { Form1.K711 = 0; Form1.K721 = 0.5; }
            if (Form1.t >= 0) { Form1.K711 = 0.3; Form1.K721 = 1; }
            if (Form1.t >= 20) { Form1.K711 = 1; Form1.K721 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 1.7; Form1.K721 = 1; }
            //Коэффициент К1
            Form1.K11 = 0.11;
        }
        //////////////////////////////////////
        public static void Serouglerod()
        {
            Form1.M1 = 76.14;
            Form1.tkip1 = 46.2;
            Form1.p1 = 1.263;
            Form1.Pi1 = 39.60;
            Form1.D1 = 45;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0.1; }
            if (Form1.t >= -20) { Form1.K711 = 0.2; }
            if (Form1.t >= 0) { Form1.K711 = 0.4; }
            if (Form1.t >= 20) { Form1.K711 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 2.1; }
            Form1.K721 = Form1.K711;
            //Коэффициент К1
            Form1.K11 = 0;
        }
        //////////////////////////////////////
        public static void SolyanayaKislota()
        {
            Form1.M1 = 36.46;
            Form1.tkip1 = 108.6;
            Form1.p1 = 1.198;
            Form1.Pi1 = 57.19;
            Form1.D1 = 2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0; }
            if (Form1.t >= -20) { Form1.K711 = 0.1; }
            if (Form1.t >= 0) { Form1.K711 = 0.3; }
            if (Form1.t >= 20) { Form1.K711 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 1.6; }
            Form1.K721 = Form1.K711;
            //Коэффициент К1
            Form1.K11 = 0;
        }
        //////////////////////////////////////
        public static void Formaldegid()
        {
            Form1.M1 = 30.03;
            Form1.tkip1 = -19.0;
            Form1.p1 = 0.815;
            Form1.Pi1 = 102.10;
            Form1.D1 = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0; Form1.K721 = 0.4; }
            if (Form1.t >= -20) { Form1.K711 = 0; Form1.K721 = 1; }
            if (Form1.t >= 0) { Form1.K711 = 0.5; Form1.K721 = 1; }
            if (Form1.t >= 20) { Form1.K711 = 1; Form1.K721 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 1.5; Form1.K721 = 1; }
            //Коэффициент К1
            Form1.K11 = 0.19;
        }
        //////////////////////////////////////
        //////////////////////////////////////
        public static void VodorodMishyak()
        {
            Form1.tkip1 = -62.47;
            Form1.D1 = 0.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0.3; Form1.K721 = 1; }
            if (Form1.t >= -20) { Form1.K711 = 0.5; Form1.K721 = 1; }
            if (Form1.t >= 0) { Form1.K711 = 0.8; Form1.K721 = 1; }
            if (Form1.t >= 20) { Form1.K711 = 1; Form1.K721 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 1.2; Form1.K721 = 1; }
            //Коэффициент К1
            Form1.K11 = 0.17;
            Form1.K21 = 0.054;
        }
        //////////////////////////////////////
        public static void Dimetilamin()
        {
            Form1.tkip1 = 6.9;
            Form1.D1 = 1.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0; Form1.K721 = 0.1; }
            if (Form1.t >= -20) { Form1.K711 = 0; Form1.K721 = 0.3; }
            if (Form1.t >= 0) { Form1.K711 = 0; Form1.K721 = 0.8; }
            if (Form1.t >= 20) { Form1.K711 = 1; Form1.K721 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 2.5; Form1.K721 = 1; }
            //Коэффициент К1
            Form1.K11 = 0.06;
            Form1.K21 = 0.041;
        }
        //////////////////////////////////////
        public static void Metilamin()
        {
            Form1.tkip1 = -6.5;
            Form1.D1 = 1.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0; Form1.K721 = 0.3; }
            if (Form1.t >= -20) { Form1.K711 = 0; Form1.K721 = 0.7; }
            if (Form1.t >= 0) { Form1.K711 = 0.5; Form1.K721 = 1; }
            if (Form1.t >= 20) { Form1.K711 = 1; Form1.K721 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 2.5; Form1.K721 = 1; }
            //Коэффициент К1
            Form1.K11 = 0.13;
            Form1.K21 = 0.034;
        }
        //////////////////////////////////////
        public static void MetilChlor()
        {
            Form1.tkip1 = -23.76;
            Form1.D1 = 10.8;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0; Form1.K721 = 130.5; }
            if (Form1.t >= -20) { Form1.K711 = 0.1; Form1.K721 = 1; }
            if (Form1.t >= 0) { Form1.K711 = 0.6; Form1.K721 = 1; }
            if (Form1.t >= 20) { Form1.K711 = 1; Form1.K721 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 1.5; Form1.K721 = 1; }
            //Коэффициент К1
            Form1.K11 = 0.125;
            Form1.K21 = 0.044;
        }
        //////////////////////////////////////
        public static void NitrilAkrilKisl()
        {
            Form1.tkip1 = 77.3;
            Form1.p1 = 0.806;
            Form1.D1 = 0.75;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K711 = 0.04; }
            if (Form1.t >= -20) { Form1.K711 = 0.1; }
            if (Form1.t >= 0) { Form1.K711 = 0.4; }
            if (Form1.t >= 20) { Form1.K711 = 1; }
            if (Form1.t >= 40) { Form1.K711 = 2.4; }
            Form1.K721 = Form1.K711;
            //Коэффициент К1
            Form1.K11 = 0;
            Form1.K21 = 0.007;
        }
        public static void
    }
}
