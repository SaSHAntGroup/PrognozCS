﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrognozCS
{
    class substanceAXOB4
    {
        //Присваивание параметров АХОВ
        public static void Empty()
        {
            Form1.M4 = 0;
            Form1.tkip4 = 0;
            Form1.Pi4 = 0;
            Form1.D4 = 0;
            Form1.p4 = 0;
        }
        //////////////////////////////////////
        public static void Chlor()
        {
            Form1.M4 = 70.91;
            Form1.tkip4 = -34.7;
            Form1.Pi4 = 101.58;
            Form1.D4 = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K74 = 0; Form1.K724 = 0.9; }
            if (Form1.t >= -20) { Form1.K74 = 0.3; Form1.K724 = 1; }
            if (Form1.t >= 0) { Form1.K74 = 0.6; Form1.K724 = 1; }
            if (Form1.t >= 20) { Form1.K74 = 1; Form1.K724 = 1; }
            if (Form1.t >= 40) { Form1.K74 = 1.4; Form1.K724 = 2; }
            //Коэффициент К1
            Form1.K14 = 0.18;
            Form1.subst4 = 1;
        }
        //////////////////////////////////////
        public static void Ammiak()
        {
            Form1.M4 = 17.03;
            Form1.tkip4 = -33.42;
            Form1.Pi4 = 99.7;
            Form1.D4 = 15;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K74 = 0; Form1.K724 = 0.9; }
            if (Form1.t >= -20) { Form1.K74 = 0.3; Form1.K724 = 1; }
            if (Form1.t >= 0) { Form1.K74 = 0.6; Form1.K724 = 1; }
            if (Form1.t >= 20) { Form1.K74 = 1; Form1.K724 = 1; }
            if (Form1.t >= 40) { Form1.K74 = 1.4; Form1.K724 = 1; }
            //Коэффициент К1
            Form1.K14 = 0.18;
            Form1.subst4 = 2;
        }
        //////////////////////////////////////
        public static void VodorodChlor()
        {
            Form1.M4 = 36.46;
            Form1.tkip4 = -85.1;
            Form1.Pi4 = 100.8;
            Form1.D4 = 2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K74 = 0.64; Form1.K724 = 1; }
            if (Form1.t >= -20) { Form1.K74 = 0.6; Form1.K724 = 1; }
            if (Form1.t >= 0) { Form1.K74 = 0.8; Form1.K724 = 1; }
            if (Form1.t >= 20) { Form1.K74 = 1; Form1.K724 = 1; }
            if (Form1.t >= 40) { Form1.K74 = 1.2; Form1.K724 = 1; }
            //Коэффициент К1
            Form1.K14 = 0.28;
            Form1.subst4 = 3;
        }
        //////////////////////////////////////
        public static void VodorodBrom()
        {
            Form1.M4 = 80.92;
            Form1.tkip4 = -66.77;
            Form1.Pi4 = 101.6;
            Form1.D4 = 2.4;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K74 = 0.2; Form1.K724 = 1; }
            if (Form1.t >= -20) { Form1.K74 = 0.5; Form1.K724 = 1; }
            if (Form1.t >= 0) { Form1.K74 = 0.8; Form1.K724 = 1; }
            if (Form1.t >= 20) { Form1.K74 = 1; Form1.K724 = 1; }
            if (Form1.t >= 40) { Form1.K74 = 1.2; Form1.K724 = 1; }
            //Коэффициент К1
            Form1.K14 = 0.13;
            Form1.subst4 = 4;
        }
        //////////////////////////////////////
        public static void Serovodorod()
        {
            Form1.M4 = 34.08;
            Form1.tkip4 = -60.35;
            Form1.Pi4 = 118.37;
            Form1.D4 = 16.1;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K74 = 0.3; Form1.K724 = 1; }
            if (Form1.t >= -20) { Form1.K74 = 0.5; Form1.K724 = 1; }
            if (Form1.t >= 0) { Form1.K74 = 0.8; Form1.K724 = 1; }
            if (Form1.t >= 20) { Form1.K74 = 1; Form1.K724 = 1; }
            if (Form1.t >= 40) { Form1.K74 = 1.2; Form1.K724 = 1; }
            //Коэффициент К1
            Form1.K14 = 0.27;
            Form1.subst4 = 5;
        }
        //////////////////////////////////////
        public static void Fosgen()
        {
            Form1.M4 = 98.92;
            Form1.tkip4 = 8.2;
            Form1.Pi4 = 100.9;
            Form1.D4 = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K74 = 0; Form1.K724 = 0.1; }
            if (Form1.t >= -20) { Form1.K74 = 0; Form1.K724 = 0.3; }
            if (Form1.t >= 0) { Form1.K74 = 0; Form1.K724 = 0.7; }
            if (Form1.t >= 20) { Form1.K74 = 1; Form1.K724 = 1; }
            if (Form1.t >= 40) { Form1.K74 = 2.2; Form1.K724 = 1; }
            //Коэффициент К1
            Form1.K14 = 0.05;
            Form1.subst4 = 6;
        }
        //////////////////////////////////////
        public static void Ftor()
        {
            Form1.M4 = 38.0;
            Form1.tkip4 = -188.2;
            Form1.Pi4 = 101.44;
            Form1.D4 = 0.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K74 = 0.7; Form1.K724 = 1; }
            if (Form1.t >= -20) { Form1.K74 = 0.8; Form1.K724 = 1; }
            if (Form1.t >= 0) { Form1.K74 = 0.9; Form1.K724 = 1; }
            if (Form1.t >= 20) { Form1.K74 = 1; Form1.K724 = 1; }
            if (Form1.t >= 40) { Form1.K74 = 1.1; Form1.K724 = 1; }
            //Коэффициент К1
            Form1.K14 = 0.95;
            Form1.subst4 = 7;
        }
        //////////////////////////////////////
        public static void Chlorician()
        {
            Form1.M4 = 61.47;
            Form1.tkip4 = 12.6;
            Form1.Pi4 = 100.80;
            Form1.D4 = 0.75;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K74 = 0; Form1.K724 = 0; }
            if (Form1.t >= -20) { Form1.K74 = 0; Form1.K724 = 0; }
            if (Form1.t >= 0) { Form1.K74 = 0; Form1.K724 = 0.6; }
            if (Form1.t >= 20) { Form1.K74 = 1; Form1.K724 = 1; }
            if (Form1.t >= 40) { Form1.K74 = 3.9; Form1.K724 = 1; }
            //Коэффициент К1
            Form1.K14 = 0.04;
            Form1.subst4 = 8;
        }
        //////////////////////////////////////====================================
        public static void VodorodFtoristiy()
        {
            Form1.M4 = 20.01;
            Form1.tkip4 = 19.52;
            Form1.Pi4 = 103;
            Form1.D4 = 4;
            Form1.p4 = 0.989;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K74 = 0.1; }
            if (Form1.t >= -20) { Form1.K74 = 0.2; }
            if (Form1.t >= 0) { Form1.K74 = 0.5; }
            if (Form1.t >= 20) { Form1.K74 = 1; }
            if (Form1.t >= 40) { Form1.K74 = 1; }
            Form1.K724 = Form1.K74;
            //Коэффициент К1
            Form1.K14 = 0;
            Form1.subst4 = 9;
        }
        //////////////////////////////////////
        public static void VodorodCianistiy()
        {
            Form1.M4 = 27.03;
            Form1.tkip4 = 25.7;
            Form1.p4 = 0.687;
            Form1.Pi4 = 82.25;
            Form1.D4 = 0.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K74 = 0; }
            if (Form1.t >= -20) { Form1.K74 = 0; }
            if (Form1.t >= 0) { Form1.K74 = 0.4; }
            if (Form1.t >= 20) { Form1.K74 = 1; }
            if (Form1.t >= 40) { Form1.K74 = 1.3; }
            Form1.K724 = Form1.K74;
            //Коэффициент К1
            Form1.K14 = 0;
            Form1.subst4 = 10;
        }
        //////////////////////////////////////
        public static void DvuokisAzota()
        {
            Form1.M4 = 46.01;
            Form1.tkip4 = 21.0;
            Form1.p4 = 1.491;
            Form1.Pi4 = 97.04;
            Form1.D4 = 1.5;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K74 = 0; }
            if (Form1.t >= -20) { Form1.K74 = 0; }
            if (Form1.t >= 0) { Form1.K74 = 0.4; }
            if (Form1.t >= 20) { Form1.K74 = 1; }
            if (Form1.t >= 40) { Form1.K74 = 1; }
            Form1.K724 = Form1.K74;
            //Коэффициент К1
            Form1.K14 = 0;
            Form1.subst4 = 11;
        }
        //////////////////////////////////////
        public static void SernistiyAngidrid()
        {
            Form1.M4 = 64.06;
            Form1.tkip4 = -10.1;
            Form1.p4 = 1.462;
            Form1.Pi4 = 100.8;
            Form1.D4 = 1.8;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K74 = 0; Form1.K724 = 0.2; }
            if (Form1.t >= -20) { Form1.K74 = 0; Form1.K724 = 0.5; }
            if (Form1.t >= 0) { Form1.K74 = 0.3; Form1.K724 = 1; }
            if (Form1.t >= 20) { Form1.K74 = 1; Form1.K724 = 1; }
            if (Form1.t >= 40) { Form1.K74 = 1.7; Form1.K724 = 1; }
            //Коэффициент К1
            Form1.K14 = 0.11;
            Form1.subst4 = 12;
        }
        //////////////////////////////////////
        public static void Serouglerod()
        {
            Form1.M4 = 76.14;
            Form1.tkip4 = 46.2;
            Form1.p4 = 1.263;
            Form1.Pi4 = 39.60;
            Form1.D4 = 45;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K74 = 0.1; }
            if (Form1.t >= -20) { Form1.K74 = 0.2; }
            if (Form1.t >= 0) { Form1.K74 = 0.4; }
            if (Form1.t >= 20) { Form1.K74 = 1; }
            if (Form1.t >= 40) { Form1.K74 = 2.1; }
            Form1.K724 = Form1.K74;
            //Коэффициент К1
            Form1.K14 = 0;
            Form1.subst4 = 13;
        }
        //////////////////////////////////////
        public static void SolyanayaKislota()
        {
            Form1.M4 = 36.46;
            Form1.tkip4 = 108.6;
            Form1.p4 = 1.198;
            Form1.Pi4 = 57.19;
            Form1.D4 = 2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K74 = 0; }
            if (Form1.t >= -20) { Form1.K74 = 0.1; }
            if (Form1.t >= 0) { Form1.K74 = 0.3; }
            if (Form1.t >= 20) { Form1.K74 = 1; }
            if (Form1.t >= 40) { Form1.K74 = 1.6; }
            Form1.K724 = Form1.K74;
            //Коэффициент К1
            Form1.K14 = 0;
            Form1.subst4 = 14;
        }
        //////////////////////////////////////
        public static void Formaldegid()
        {
            Form1.M4 = 30.03;
            Form1.tkip4 = -19.0;
            Form1.p4 = 0.815;
            Form1.Pi4 = 102.10;
            Form1.D4 = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K74 = 0; Form1.K724 = 0.4; }
            if (Form1.t >= -20) { Form1.K74 = 0; Form1.K724 = 1; }
            if (Form1.t >= 0) { Form1.K74 = 0.5; Form1.K724 = 1; }
            if (Form1.t >= 20) { Form1.K74 = 1; Form1.K724 = 1; }
            if (Form1.t >= 40) { Form1.K74 = 1.5; Form1.K724 = 1; }
            //Коэффициент К1
            Form1.K14 = 0.19;
            Form1.subst4 = 15;
        }
        /// <summary>
        /// /////////////////////////
        /// </summary>
        public static void VodorodMishyak()
        {
            substanceAXOB1.VodorodMishyak();
            Form1.tkip4 = Form1.tkip1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
        //////////////////////////////////////
        public static void Dimetilamin()
        {
            substanceAXOB1.Dimetilamin();
            Form1.tkip4 = Form1.tkip1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
        //////////////////////////////////////
        public static void Metilamin()
        {
            substanceAXOB1.Metilamin();
            Form1.tkip4 = Form1.tkip1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
        //////////////////////////////////////
        public static void MetilChlor()
        {
            substanceAXOB1.MetilChlor();
            Form1.tkip4 = Form1.tkip1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
        //////////////////////////////////////
        public static void NitrilAkrilKisl()
        {
            substanceAXOB1.NitrilAkrilKisl();
            Form1.tkip4 = Form1.tkip1;
            Form1.p4 = Form1.p1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
        public static void Akrolein()
        {
            substanceAXOB1.Akrolein();
            Form1.tkip4 = Form1.tkip1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
        public static void Azetonitril()
        {
            substanceAXOB1.Azetonitril();
            Form1.tkip4 = Form1.tkip1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
        public static void Azetonziangidrin()
        {
            substanceAXOB1.Azetonziangidrin();
            Form1.tkip4 = Form1.tkip1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
        public static void MetilBrom()
        {
            substanceAXOB1.MetilBrom();
            Form1.tkip4 = Form1.tkip1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
        public static void Metilakrilat()
        {
            substanceAXOB1.Metilakrilat();
            Form1.tkip4 = Form1.tkip1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
        public static void Metilmerkaptan()
        {
            substanceAXOB1.Metilmerkaptan();
            Form1.tkip4 = Form1.tkip1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
        public static void OkisEtilen()
        {
            substanceAXOB1.OkisEtilen();
            Form1.tkip4 = Form1.tkip1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
        public static void Trimetilamin()
        {
            substanceAXOB1.Trimetilamin();
            Form1.tkip4 = Form1.tkip1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
        public static void FosforTrehchlor()
        {
            substanceAXOB1.FosforTrehchlor();
            Form1.tkip4 = Form1.tkip1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
        public static void FosforaChlorokis()
        {
            substanceAXOB1.FosforaChlorokis();
            Form1.tkip4 = Form1.tkip1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
        public static void Chlorpikrin()
        {
            substanceAXOB1.Chlorpikrin();
            Form1.tkip4 = Form1.tkip1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
        public static void Etilenimin()
        {
            substanceAXOB1.Etilenimin();
            Form1.tkip4 = Form1.tkip1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
        public static void Etilensulfid()
        {
            substanceAXOB1.Etilensulfid();
            Form1.tkip4 = Form1.tkip1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
        public static void Etilmerkaptan()
        {
            substanceAXOB1.Etilmerkaptan();
            Form1.tkip4 = Form1.tkip1;
            Form1.D4 = Form1.D1;
            Form1.K74 = Form1.K711;
            Form1.K724 = Form1.K721;
            Form1.K14 = Form1.K11;
            Form1.K24 = Form1.K21;
            Form1.subst4 = Form1.subst1;
        }
    }
}
