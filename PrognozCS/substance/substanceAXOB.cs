using System;
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
            Form1.subst = 1;
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
            Form1.subst = 2;
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
            Form1.subst = 3;
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
            Form1.subst = 4;
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
            Form1.subst = 5;
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
            Form1.subst = 6;
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
            Form1.subst = 7;
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
            Form1.subst = 8;
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
            Form1.subst = 9;
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
            Form1.subst = 10;
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
            Form1.subst = 11;
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
            Form1.subst = 12;
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
            Form1.K1 = 0.021;
            Form1.subst = 13;
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
            Form1.K1 = 0.007;
            Form1.subst = 14;
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
            Form1.subst = 15;
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
            Form1.subst = 16;
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
            Form1.subst = 17;
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
            Form1.subst = 18;
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
            Form1.subst = 19;
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
            Form1.subst = 20;
        }
        public static void Akrolein()
        {
            substanceAXOB1.Akrolein();
            Form1.tkip = Form1.tkip1;
            Form1.D = Form1.D1;
            Form1.K7 = Form1.K711;
            Form1.K72 = Form1.K721;
            Form1.K1 = Form1.K11;
            Form1.K2 = Form1.K21;
            Form1.subst = 21;
        }
        public static void Azetonitril()
        {
            substanceAXOB1.Azetonitril();
            Form1.tkip = Form1.tkip1;
            Form1.D = Form1.D1;
            Form1.K7 = Form1.K711;
            Form1.K72 = Form1.K721;
            Form1.K1 = Form1.K11;
            Form1.K2 = Form1.K21;
            Form1.subst = 22;
        }
        public static void Azetonziangidrin()
        {
            substanceAXOB1.Azetonziangidrin();
            Form1.tkip = Form1.tkip1;
            Form1.D = Form1.D1;
            Form1.K7 = Form1.K711;
            Form1.K72 = Form1.K721;
            Form1.K1 = Form1.K11;
            Form1.K2 = Form1.K21;
            Form1.subst = 23;
        }
        public static void MetilBrom()
        {
            substanceAXOB1.MetilBrom();
            Form1.tkip = Form1.tkip1;
            Form1.D = Form1.D1;
            Form1.K7 = Form1.K711;
            Form1.K72 = Form1.K721;
            Form1.K1 = Form1.K11;
            Form1.K2 = Form1.K21;
            Form1.subst = 24;
        }
        public static void Metilakrilat()
        {
            substanceAXOB1.Metilakrilat();
            Form1.tkip = Form1.tkip1;
            Form1.D = Form1.D1;
            Form1.K7 = Form1.K711;
            Form1.K72 = Form1.K721;
            Form1.K1 = Form1.K11;
            Form1.K2 = Form1.K21;
            Form1.subst = 25;
        }
        public static void Metilmerkaptan()
        {
            substanceAXOB1.Metilmerkaptan();
            Form1.tkip = Form1.tkip1;
            Form1.D = Form1.D1;
            Form1.K7 = Form1.K711;
            Form1.K72 = Form1.K721;
            Form1.K1 = Form1.K11;
            Form1.K2 = Form1.K21;
            Form1.subst = 26;
        }
        public static void OkisEtilen()
        {
            substanceAXOB1.OkisEtilen();
            Form1.tkip = Form1.tkip1;
            Form1.D = Form1.D1;
            Form1.K7 = Form1.K711;
            Form1.K72 = Form1.K721;
            Form1.K1 = Form1.K11;
            Form1.K2 = Form1.K21;
            Form1.subst = 27;
        }
        public static void Trimetilamin()
        {
            substanceAXOB1.Trimetilamin();
            Form1.tkip = Form1.tkip1;
            Form1.D = Form1.D1;
            Form1.K7 = Form1.K711;
            Form1.K72 = Form1.K721;
            Form1.K1 = Form1.K11;
            Form1.K2 = Form1.K21;
            Form1.subst = 28;
        }
        public static void FosforTrehchlor()
        {
            substanceAXOB1.FosforTrehchlor();
            Form1.tkip = Form1.tkip1;
            Form1.D = Form1.D1;
            Form1.K7 = Form1.K711;
            Form1.K72 = Form1.K721;
            Form1.K1 = Form1.K11;
            Form1.K2 = Form1.K21;
            Form1.subst = 29;
        }
        public static void FosforaChlorokis()
        {
            substanceAXOB1.FosforaChlorokis();
            Form1.tkip = Form1.tkip1;
            Form1.D = Form1.D1;
            Form1.K7 = Form1.K711;
            Form1.K72 = Form1.K721;
            Form1.K1 = Form1.K11;
            Form1.K2 = Form1.K21;
            Form1.subst = 30;
        }
        public static void Chlorpikrin()
        {
            substanceAXOB1.Chlorpikrin();
            Form1.tkip = Form1.tkip1;
            Form1.D = Form1.D1;
            Form1.K7 = Form1.K711;
            Form1.K72 = Form1.K721;
            Form1.K1 = Form1.K11;
            Form1.K2 = Form1.K21;
            Form1.subst = 31;
        }
        public static void Etilenimin()
        {
            substanceAXOB1.Etilenimin();
            Form1.tkip = Form1.tkip1;
            Form1.D = Form1.D1;
            Form1.K7 = Form1.K711;
            Form1.K72 = Form1.K721;
            Form1.K1 = Form1.K11;
            Form1.K2 = Form1.K21;
            Form1.subst = 32;
        }
        public static void Etilensulfid()
        {
            substanceAXOB1.Etilensulfid();
            Form1.tkip = Form1.tkip1;
            Form1.D = Form1.D1;
            Form1.K7 = Form1.K711;
            Form1.K72 = Form1.K721;
            Form1.K1 = Form1.K11;
            Form1.K2 = Form1.K21;
            Form1.subst = 33;
        }
        public static void Etilmerkaptan()
        {
            substanceAXOB1.Etilmerkaptan();
            Form1.tkip = Form1.tkip1;
            Form1.D = Form1.D1;
            Form1.K7 = Form1.K711;
            Form1.K72 = Form1.K721;
            Form1.K1 = Form1.K11;
            Form1.K2 = Form1.K21;
            Form1.subst = 34;
        }
    }
}
