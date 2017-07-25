using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrognozCS
{
    class substanceAXOB3
    {
        //Присваивание параметров АХОВ
        public static void Empty()
        {
            Form1.M3 = 0;
            Form1.tkip3 = 0;
            Form1.Pi3 = 0;
            Form1.D3 = 0;
            Form1.p3 = 0;
        }
        //////////////////////////////////////
        public static void Chlor()
        {
            Form1.M3 = 70.91;
            Form1.tkip3 = -34.7;
            Form1.Pi3 = 101.58;
            Form1.D3 = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K73 = 0; Form1.K723 = 0.9; }
            if (Form1.t >= -20) { Form1.K73 = 0.3; Form1.K723 = 1; }
            if (Form1.t >= 0) { Form1.K73 = 0.6; Form1.K723 = 1; }
            if (Form1.t >= 20) { Form1.K73 = 1; Form1.K723 = 1; }
            if (Form1.t >= 40) { Form1.K73 = 1.4; Form1.K723 = 2; }
            //Коэффициент К1
            Form1.K13 = 0.18;
        }
        //////////////////////////////////////
        public static void Ammiak()
        {
            Form1.M3 = 17.03;
            Form1.tkip3 = -33.42;
            Form1.Pi3 = 99.7;
            Form1.D3 = 15;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K73 = 0; Form1.K723 = 0.9; }
            if (Form1.t >= -20) { Form1.K73 = 0.3; Form1.K723 = 1; }
            if (Form1.t >= 0) { Form1.K73 = 0.6; Form1.K723 = 1; }
            if (Form1.t >= 20) { Form1.K73 = 1; Form1.K723 = 1; }
            if (Form1.t >= 40) { Form1.K73 = 1.4; Form1.K723 = 1; }
            //Коэффициент К1
            Form1.K13 = 0.18;
        }
        //////////////////////////////////////
        public static void VodorodChlor()
        {
            Form1.M3 = 36.46;
            Form1.tkip3 = -85.1;
            Form1.Pi3 = 100.8;
            Form1.D3 = 2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K73 = 0.64; Form1.K723 = 1; }
            if (Form1.t >= -20) { Form1.K73 = 0.6; Form1.K723 = 1; }
            if (Form1.t >= 0) { Form1.K73 = 0.8; Form1.K723 = 1; }
            if (Form1.t >= 20) { Form1.K73 = 1; Form1.K723 = 1; }
            if (Form1.t >= 40) { Form1.K73 = 1.2; Form1.K723 = 1; }
            //Коэффициент К1
            Form1.K13 = 0.28;
        }
        //////////////////////////////////////
        public static void VodorodBrom()
        {
            Form1.M3 = 80.92;
            Form1.tkip3 = -66.77;
            Form1.Pi3 = 101.6;
            Form1.D3 = 2.4;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K73 = 0.2; Form1.K723 = 1; }
            if (Form1.t >= -20) { Form1.K73 = 0.5; Form1.K723 = 1; }
            if (Form1.t >= 0) { Form1.K73 = 0.8; Form1.K723 = 1; }
            if (Form1.t >= 20) { Form1.K73 = 1; Form1.K723 = 1; }
            if (Form1.t >= 40) { Form1.K73 = 1.2; Form1.K723 = 1; }
            //Коэффициент К1
            Form1.K13 = 0.13;
        }
        //////////////////////////////////////
        public static void Serovodorod()
        {
            Form1.M3 = 34.08;
            Form1.tkip3 = -60.35;
            Form1.Pi3 = 118.37;
            Form1.D3 = 16.1;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K73 = 0.3; Form1.K723 = 1; }
            if (Form1.t >= -20) { Form1.K73 = 0.5; Form1.K723 = 1; }
            if (Form1.t >= 0) { Form1.K73 = 0.8; Form1.K723 = 1; }
            if (Form1.t >= 20) { Form1.K73 = 1; Form1.K723 = 1; }
            if (Form1.t >= 40) { Form1.K73 = 1.2; Form1.K723 = 1; }
            //Коэффициент К1
            Form1.K13 = 0.27;
        }
        //////////////////////////////////////
        public static void Fosgen()
        {
            Form1.M3 = 98.92;
            Form1.tkip3 = 8.2;
            Form1.Pi3 = 100.9;
            Form1.D3 = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K73 = 0; Form1.K723 = 0.1; }
            if (Form1.t >= -20) { Form1.K73 = 0; Form1.K723 = 0.3; }
            if (Form1.t >= 0) { Form1.K73 = 0; Form1.K723 = 0.7; }
            if (Form1.t >= 20) { Form1.K73 = 1; Form1.K723 = 1; }
            if (Form1.t >= 40) { Form1.K73 = 2.2; Form1.K723 = 1; }
            //Коэффициент К1
            Form1.K13 = 0.05;
        }
        //////////////////////////////////////
        public static void Ftor()
        {
            Form1.M3 = 38.0;
            Form1.tkip3 = -188.2;
            Form1.Pi3 = 101.44;
            Form1.D3 = 0.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K73 = 0.7; Form1.K723 = 1; }
            if (Form1.t >= -20) { Form1.K73 = 0.8; Form1.K723 = 1; }
            if (Form1.t >= 0) { Form1.K73 = 0.9; Form1.K723 = 1; }
            if (Form1.t >= 20) { Form1.K73 = 1; Form1.K723 = 1; }
            if (Form1.t >= 40) { Form1.K73 = 1.1; Form1.K723 = 1; }
            //Коэффициент К1
            Form1.K13 = 0.95;
        }
        //////////////////////////////////////
        public static void Chlorician()
        {
            Form1.M3 = 61.47;
            Form1.tkip3 = 12.6;
            Form1.Pi3 = 100.80;
            Form1.D3 = 0.75;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K73 = 0; Form1.K723 = 0; }
            if (Form1.t >= -20) { Form1.K73 = 0; Form1.K723 = 0; }
            if (Form1.t >= 0) { Form1.K73 = 0; Form1.K723 = 0.6; }
            if (Form1.t >= 20) { Form1.K73 = 1; Form1.K723 = 1; }
            if (Form1.t >= 40) { Form1.K73 = 3.9; Form1.K723 = 1; }
            //Коэффициент К1
            Form1.K13 = 0.04;
        }
        //////////////////////////////////////====================================
        public static void VodorodFtoristiy()
        {
            Form1.M3 = 20.01;
            Form1.tkip3 = 19.52;
            Form1.Pi3 = 103;
            Form1.D3 = 4;
            Form1.p3 = 0.989;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K73 = 0.1; }
            if (Form1.t >= -20) { Form1.K73 = 0.2; }
            if (Form1.t >= 0) { Form1.K73 = 0.5; }
            if (Form1.t >= 20) { Form1.K73 = 1; }
            if (Form1.t >= 40) { Form1.K73 = 1; }
            Form1.K723 = Form1.K73;
            //Коэффициент К1
            Form1.K13 = 0;
        }
        //////////////////////////////////////
        public static void VodorodCianistiy()
        {
            Form1.M3 = 27.03;
            Form1.tkip3 = 25.7;
            Form1.p3 = 0.687;
            Form1.Pi3 = 82.25;
            Form1.D3 = 0.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K73 = 0; }
            if (Form1.t >= -20) { Form1.K73 = 0; }
            if (Form1.t >= 0) { Form1.K73 = 0.4; }
            if (Form1.t >= 20) { Form1.K73 = 1; }
            if (Form1.t >= 40) { Form1.K73 = 1.3; }
            Form1.K723 = Form1.K73;
            //Коэффициент К1
            Form1.K13 = 0;
        }
        //////////////////////////////////////
        public static void DvuokisAzota()
        {
            Form1.M3 = 46.01;
            Form1.tkip3 = 21.0;
            Form1.p3 = 1.491;
            Form1.Pi3 = 97.04;
            Form1.D3 = 1.5;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K73 = 0; }
            if (Form1.t >= -20) { Form1.K73 = 0; }
            if (Form1.t >= 0) { Form1.K73 = 0.4; }
            if (Form1.t >= 20) { Form1.K73 = 1; }
            if (Form1.t >= 40) { Form1.K73 = 1; }
            Form1.K723 = Form1.K73;
            //Коэффициент К1
            Form1.K13 = 0;
        }
        //////////////////////////////////////
        public static void SernistiyAngidrid()
        {
            Form1.M3 = 64.06;
            Form1.tkip3 = -10.1;
            Form1.p3 = 1.462;
            Form1.Pi3 = 100.8;
            Form1.D3 = 1.8;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K73 = 0; Form1.K723 = 0.2; }
            if (Form1.t >= -20) { Form1.K73 = 0; Form1.K723 = 0.5; }
            if (Form1.t >= 0) { Form1.K73 = 0.3; Form1.K723 = 1; }
            if (Form1.t >= 20) { Form1.K73 = 1; Form1.K723 = 1; }
            if (Form1.t >= 40) { Form1.K73 = 1.7; Form1.K723 = 1; }
            //Коэффициент К1
            Form1.K13 = 0.11;
        }
        //////////////////////////////////////
        public static void Serouglerod()
        {
            Form1.M3 = 76.14;
            Form1.tkip3 = 46.2;
            Form1.p3 = 1.263;
            Form1.Pi3 = 39.60;
            Form1.D3 = 45;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K73 = 0.1; }
            if (Form1.t >= -20) { Form1.K73 = 0.2; }
            if (Form1.t >= 0) { Form1.K73 = 0.4; }
            if (Form1.t >= 20) { Form1.K73 = 1; }
            if (Form1.t >= 40) { Form1.K73 = 2.1; }
            Form1.K723 = Form1.K73;
            //Коэффициент К1
            Form1.K13 = 0;
        }
        //////////////////////////////////////
        public static void SolyanayaKislota()
        {
            Form1.M3 = 36.46;
            Form1.tkip3 = 108.6;
            Form1.p3 = 1.198;
            Form1.Pi3 = 57.19;
            Form1.D3 = 2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K73 = 0; }
            if (Form1.t >= -20) { Form1.K73 = 0.1; }
            if (Form1.t >= 0) { Form1.K73 = 0.3; }
            if (Form1.t >= 20) { Form1.K73 = 1; }
            if (Form1.t >= 40) { Form1.K73 = 1.6; }
            Form1.K723 = Form1.K73;
            //Коэффициент К1
            Form1.K13 = 0;
        }
        //////////////////////////////////////
        public static void Formaldegid()
        {
            Form1.M3 = 30.03;
            Form1.tkip3 = -19.0;
            Form1.p3 = 0.815;
            Form1.Pi3 = 102.10;
            Form1.D3 = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) && (Form1.t < -40)) { Form1.K73 = 0; Form1.K723 = 0.4; }
            if (Form1.t >= -20) { Form1.K73 = 0; Form1.K723 = 1; }
            if (Form1.t >= 0) { Form1.K73 = 0.5; Form1.K723 = 1; }
            if (Form1.t >= 20) { Form1.K73 = 1; Form1.K723 = 1; }
            if (Form1.t >= 40) { Form1.K73 = 1.5; Form1.K723 = 1; }
            //Коэффициент К1
            Form1.K13 = 0.19;
        }
    }
}
