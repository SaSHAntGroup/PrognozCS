using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrognozCS
{
    class substanceAXOB5
    {
        //Присваивание параметров АХОВ
        public static void Empty()
        {
            Form1.M5 = 0;
            Form1.tkip5 = 0;
            Form1.Pi5 = 0;
            Form1.D5 = 0;
            Form1.p5 = 0;
        }
        //////////////////////////////////////
        public static void Chlor()
        {
            Form1.M5 = 70.91;
            Form1.tkip5 = -34.7;
            Form1.Pi5 = 101.58;
            Form1.D5 = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K75 = 0; Form1.K725 = 0.9; }
            if (Form1.t >= -20) { Form1.K75 = 0.3; Form1.K725 = 1; }
            if (Form1.t >= 0) { Form1.K75 = 0.6; Form1.K725 = 1; }
            if (Form1.t >= 20) { Form1.K75 = 1; Form1.K725 = 1; }
            if (Form1.t >= 40) { Form1.K75 = 1.4; Form1.K725 = 2; }
            //Коэффициент К1
            Form1.K15 = 0.18;
        }
        //////////////////////////////////////
        public static void Ammiak()
        {
            Form1.M5 = 17.03;
            Form1.tkip5 = -33.42;
            Form1.Pi5 = 99.7;
            Form1.D5 = 15;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K75 = 0; Form1.K725 = 0.9; }
            if (Form1.t >= -20) { Form1.K75 = 0.3; Form1.K725 = 1; }
            if (Form1.t >= 0) { Form1.K75 = 0.6; Form1.K725 = 1; }
            if (Form1.t >= 20) { Form1.K75 = 1; Form1.K725 = 1; }
            if (Form1.t >= 40) { Form1.K75 = 1.4; Form1.K725 = 1; }
            //Коэффициент К1
            Form1.K15 = 0.18;
        }
        //////////////////////////////////////
        public static void VodorodChlor()
        {
            Form1.M5 = 36.46;
            Form1.tkip5 = -85.1;
            Form1.Pi5 = 100.8;
            Form1.D5 = 2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K75 = 0.64; Form1.K725 = 1; }
            if (Form1.t >= -20) { Form1.K75 = 0.6; Form1.K725 = 1; }
            if (Form1.t >= 0) { Form1.K75 = 0.8; Form1.K725 = 1; }
            if (Form1.t >= 20) { Form1.K75 = 1; Form1.K725 = 1; }
            if (Form1.t >= 40) { Form1.K75 = 1.2; Form1.K725 = 1; }
            //Коэффициент К1
            Form1.K15 = 0.28;
        }
        //////////////////////////////////////
        public static void VodorodBrom()
        {
            Form1.M5 = 80.92;
            Form1.tkip5 = -66.77;
            Form1.Pi5 = 101.6;
            Form1.D5 = 2.4;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K75 = 0.2; Form1.K725 = 1; }
            if (Form1.t >= -20) { Form1.K75 = 0.5; Form1.K725 = 1; }
            if (Form1.t >= 0) { Form1.K75 = 0.8; Form1.K725 = 1; }
            if (Form1.t >= 20) { Form1.K75 = 1; Form1.K725 = 1; }
            if (Form1.t >= 40) { Form1.K75 = 1.2; Form1.K725 = 1; }
            //Коэффициент К1
            Form1.K15 = 0.13;
        }
        //////////////////////////////////////
        public static void Serovodorod()
        {
            Form1.M5 = 34.08;
            Form1.tkip5 = -60.35;
            Form1.Pi5 = 118.37;
            Form1.D5 = 16.1;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K75 = 0.3; Form1.K725 = 1; }
            if (Form1.t >= -20) { Form1.K75 = 0.5; Form1.K725 = 1; }
            if (Form1.t >= 0) { Form1.K75 = 0.8; Form1.K725 = 1; }
            if (Form1.t >= 20) { Form1.K75 = 1; Form1.K725 = 1; }
            if (Form1.t >= 40) { Form1.K75 = 1.2; Form1.K725 = 1; }
            //Коэффициент К1
            Form1.K15 = 0.27;
        }
        //////////////////////////////////////
        public static void Fosgen()
        {
            Form1.M5 = 98.92;
            Form1.tkip5 = 8.2;
            Form1.Pi5 = 100.9;
            Form1.D5 = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K75 = 0; Form1.K725 = 0.1; }
            if (Form1.t >= -20) { Form1.K75 = 0; Form1.K725 = 0.3; }
            if (Form1.t >= 0) { Form1.K75 = 0; Form1.K725 = 0.7; }
            if (Form1.t >= 20) { Form1.K75 = 1; Form1.K725 = 1; }
            if (Form1.t >= 40) { Form1.K75 = 2.2; Form1.K725 = 1; }
            //Коэффициент К1
            Form1.K15 = 0.05;
        }
        //////////////////////////////////////
        public static void Ftor()
        {
            Form1.M5 = 38.0;
            Form1.tkip5 = -188.2;
            Form1.Pi5 = 101.44;
            Form1.D5 = 0.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K75 = 0.7; Form1.K725 = 1; }
            if (Form1.t >= -20) { Form1.K75 = 0.8; Form1.K725 = 1; }
            if (Form1.t >= 0) { Form1.K75 = 0.9; Form1.K725 = 1; }
            if (Form1.t >= 20) { Form1.K75 = 1; Form1.K725 = 1; }
            if (Form1.t >= 40) { Form1.K75 = 1.1; Form1.K725 = 1; }
            //Коэффициент К1
            Form1.K15 = 0.95;
        }
        //////////////////////////////////////
        public static void Chlorician()
        {
            Form1.M5 = 61.47;
            Form1.tkip5 = 12.6;
            Form1.Pi5 = 100.80;
            Form1.D5 = 0.75;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K75 = 0; Form1.K725 = 0; }
            if (Form1.t >= -20) { Form1.K75 = 0; Form1.K725 = 0; }
            if (Form1.t >= 0) { Form1.K75 = 0; Form1.K725 = 0.6; }
            if (Form1.t >= 20) { Form1.K75 = 1; Form1.K725 = 1; }
            if (Form1.t >= 40) { Form1.K75 = 3.9; Form1.K725 = 1; }
            //Коэффициент К1
            Form1.K15 = 0.04;
        }
        //////////////////////////////////////====================================
        public static void VodorodFtoristiy()
        {
            Form1.M5 = 20.01;
            Form1.tkip5 = 19.52;
            Form1.Pi5 = 103;
            Form1.D5 = 4;
            Form1.p5 = 0.989;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K75 = 0.1; }
            if (Form1.t >= -20) { Form1.K75 = 0.2; }
            if (Form1.t >= 0) { Form1.K75 = 0.5; }
            if (Form1.t >= 20) { Form1.K75 = 1; }
            if (Form1.t >= 40) { Form1.K75 = 1; }
            Form1.K725 = Form1.K75;
            //Коэффициент К1
            Form1.K15 = 0;
        }
        //////////////////////////////////////
        public static void VodorodCianistiy()
        {
            Form1.M5 = 27.03;
            Form1.tkip5 = 25.7;
            Form1.p5 = 0.687;
            Form1.Pi5 = 82.25;
            Form1.D5 = 0.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K75 = 0; }
            if (Form1.t >= -20) { Form1.K75 = 0; }
            if (Form1.t >= 0) { Form1.K75 = 0.4; }
            if (Form1.t >= 20) { Form1.K75 = 1; }
            if (Form1.t >= 40) { Form1.K75 = 1.3; }
            Form1.K725 = Form1.K75;
            //Коэффициент К1
            Form1.K15 = 0;
        }
        //////////////////////////////////////
        public static void DvuokisAzota()
        {
            Form1.M5 = 46.01;
            Form1.tkip5 = 21.0;
            Form1.p5 = 1.491;
            Form1.Pi5 = 97.04;
            Form1.D5 = 1.5;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K75 = 0; }
            if (Form1.t >= -20) { Form1.K75 = 0; }
            if (Form1.t >= 0) { Form1.K75 = 0.4; }
            if (Form1.t >= 20) { Form1.K75 = 1; }
            if (Form1.t >= 40) { Form1.K75 = 1; }
            Form1.K725 = Form1.K75;
            //Коэффициент К1
            Form1.K15 = 0;
        }
        //////////////////////////////////////
        public static void SernistiyAngidrid()
        {
            Form1.M5 = 64.06;
            Form1.tkip5 = -10.1;
            Form1.p5 = 1.462;
            Form1.Pi5 = 100.8;
            Form1.D5 = 1.8;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K75 = 0; Form1.K725 = 0.2; }
            if (Form1.t >= -20) { Form1.K75 = 0; Form1.K725 = 0.5; }
            if (Form1.t >= 0) { Form1.K75 = 0.3; Form1.K725 = 1; }
            if (Form1.t >= 20) { Form1.K75 = 1; Form1.K725 = 1; }
            if (Form1.t >= 40) { Form1.K75 = 1.7; Form1.K725 = 1; }
            //Коэффициент К1
            Form1.K15 = 0.11;
        }
        //////////////////////////////////////
        public static void Serouglerod()
        {
            Form1.M5 = 76.14;
            Form1.tkip5 = 46.2;
            Form1.p5 = 1.263;
            Form1.Pi5 = 39.60;
            Form1.D5 = 45;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K75 = 0.1; }
            if (Form1.t >= -20) { Form1.K75 = 0.2; }
            if (Form1.t >= 0) { Form1.K75 = 0.4; }
            if (Form1.t >= 20) { Form1.K75 = 1; }
            if (Form1.t >= 40) { Form1.K75 = 2.1; }
            Form1.K725 = Form1.K75;
            //Коэффициент К1
            Form1.K15 = 0;
        }
        //////////////////////////////////////
        public static void SolyanayaKislota()
        {
            Form1.M5 = 36.46;
            Form1.tkip5 = 108.6;
            Form1.p5 = 1.198;
            Form1.Pi5 = 57.19;
            Form1.D5 = 2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K75 = 0; }
            if (Form1.t >= -20) { Form1.K75 = 0.1; }
            if (Form1.t >= 0) { Form1.K75 = 0.3; }
            if (Form1.t >= 20) { Form1.K75 = 1; }
            if (Form1.t >= 40) { Form1.K75 = 1.6; }
            Form1.K725 = Form1.K75;
            //Коэффициент К1
            Form1.K15 = 0;
        }
        //////////////////////////////////////
        public static void Formaldegid()
        {
            Form1.M5 = 30.03;
            Form1.tkip5 = -19.0;
            Form1.p5 = 0.815;
            Form1.Pi5 = 102.10;
            Form1.D5 = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K75 = 0; Form1.K725 = 0.4; }
            if (Form1.t >= -20) { Form1.K75 = 0; Form1.K725 = 1; }
            if (Form1.t >= 0) { Form1.K75 = 0.5; Form1.K725 = 1; }
            if (Form1.t >= 20) { Form1.K75 = 1; Form1.K725 = 1; }
            if (Form1.t >= 40) { Form1.K75 = 1.5; Form1.K725 = 1; }
            //Коэффициент К1
            Form1.K15 = 0.19;
        }
    }
}
