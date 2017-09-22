using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrognozCS
{
    class substanceAXOB6
    {
        //Присваивание параметров АХОВ
        public static void Empty()
        {
            Form1.M6 = 0;
            Form1.tkip6 = 0;
            Form1.Pi6 = 0;
            Form1.D6 = 0;
            Form1.p6 = 0;
        }
        //////////////////////////////////////
        public static void Chlor()
        {
            Form1.M6 = 70.91;
            Form1.tkip6 = -34.7;
            Form1.Pi6 = 101.58;
            Form1.D6 = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K76 = 0; Form1.K726 = 0.9; }
            if (Form1.t >= -20) { Form1.K76 = 0.3; Form1.K726 = 1; }
            if (Form1.t >= 0) { Form1.K76 = 0.6; Form1.K726 = 1; }
            if (Form1.t >= 20) { Form1.K76 = 1; Form1.K726 = 1; }
            if (Form1.t >= 40) { Form1.K76 = 1.4; Form1.K726 = 2; }
            //Коэффициент К1
            Form1.K16 = 0.18;
            Form1.subst6 = 1;
        }
        //////////////////////////////////////
        public static void Ammiak()
        {
            Form1.M6 = 17.03;
            Form1.tkip6 = -33.42;
            Form1.Pi6 = 99.7;
            Form1.D6 = 15;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K76 = 0; Form1.K726 = 0.9; }
            if (Form1.t >= -20) { Form1.K76 = 0.3; Form1.K726 = 1; }
            if (Form1.t >= 0) { Form1.K76 = 0.6; Form1.K726 = 1; }
            if (Form1.t >= 20) { Form1.K76 = 1; Form1.K726 = 1; }
            if (Form1.t >= 40) { Form1.K76 = 1.4; Form1.K726 = 1; }
            //Коэффициент К1
            Form1.K16 = 0.18;
            Form1.subst6 = 2;
        }
        //////////////////////////////////////
        public static void VodorodChlor()
        {
            Form1.M6 = 36.46;
            Form1.tkip6 = -85.1;
            Form1.Pi6 = 100.8;
            Form1.D6 = 2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K76 = 0.64; Form1.K726 = 1; }
            if (Form1.t >= -20) { Form1.K76 = 0.6; Form1.K726 = 1; }
            if (Form1.t >= 0) { Form1.K76 = 0.8; Form1.K726 = 1; }
            if (Form1.t >= 20) { Form1.K76 = 1; Form1.K726 = 1; }
            if (Form1.t >= 40) { Form1.K76 = 1.2; Form1.K726 = 1; }
            //Коэффициент К1
            Form1.K16 = 0.28;
            Form1.subst6 = 3;
        }
        //////////////////////////////////////
        public static void VodorodBrom()
        {
            Form1.M6 = 80.92;
            Form1.tkip6 = -66.77;
            Form1.Pi6 = 101.6;
            Form1.D6 = 2.4;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K76 = 0.2; Form1.K726 = 1; }
            if (Form1.t >= -20) { Form1.K76 = 0.5; Form1.K726 = 1; }
            if (Form1.t >= 0) { Form1.K76 = 0.8; Form1.K726 = 1; }
            if (Form1.t >= 20) { Form1.K76 = 1; Form1.K726 = 1; }
            if (Form1.t >= 40) { Form1.K76 = 1.2; Form1.K726 = 1; }
            //Коэффициент К1
            Form1.K16 = 0.13;
            Form1.subst6 = 4;
        }
        //////////////////////////////////////
        public static void Serovodorod()
        {
            Form1.M6 = 34.08;
            Form1.tkip6 = -60.35;
            Form1.Pi6 = 118.37;
            Form1.D6 = 16.1;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K76 = 0.3; Form1.K726 = 1; }
            if (Form1.t >= -20) { Form1.K76 = 0.5; Form1.K726 = 1; }
            if (Form1.t >= 0) { Form1.K76 = 0.8; Form1.K726 = 1; }
            if (Form1.t >= 20) { Form1.K76 = 1; Form1.K726 = 1; }
            if (Form1.t >= 40) { Form1.K76 = 1.2; Form1.K726 = 1; }
            //Коэффициент К1
            Form1.K16 = 0.27;
            Form1.subst6 = 5;
        }
        //////////////////////////////////////
        public static void Fosgen()
        {
            Form1.M6 = 98.92;
            Form1.tkip6 = 8.2;
            Form1.Pi6 = 100.9;
            Form1.D6 = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K76 = 0; Form1.K726 = 0.1; }
            if (Form1.t >= -20) { Form1.K76 = 0; Form1.K726 = 0.3; }
            if (Form1.t >= 0) { Form1.K76 = 0; Form1.K726 = 0.7; }
            if (Form1.t >= 20) { Form1.K76 = 1; Form1.K726 = 1; }
            if (Form1.t >= 40) { Form1.K76 = 2.2; Form1.K726 = 1; }
            //Коэффициент К1
            Form1.K16 = 0.05;
            Form1.subst6 = 6;
        }
        //////////////////////////////////////
        public static void Ftor()
        {
            Form1.M6 = 38.0;
            Form1.tkip6 = -188.2;
            Form1.Pi6 = 101.44;
            Form1.D6 = 0.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K76 = 0.7; Form1.K726 = 1; }
            if (Form1.t >= -20) { Form1.K76 = 0.8; Form1.K726 = 1; }
            if (Form1.t >= 0) { Form1.K76 = 0.9; Form1.K726 = 1; }
            if (Form1.t >= 20) { Form1.K76 = 1; Form1.K726 = 1; }
            if (Form1.t >= 40) { Form1.K76 = 1.1; Form1.K726 = 1; }
            //Коэффициент К1
            Form1.K16 = 0.95;
            Form1.subst6 = 7;
        }
        //////////////////////////////////////
        public static void Chlorician()
        {
            Form1.M6 = 61.47;
            Form1.tkip6 = 12.6;
            Form1.Pi6 = 100.80;
            Form1.D6 = 0.75;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K76 = 0; Form1.K726 = 0; }
            if (Form1.t >= -20) { Form1.K76 = 0; Form1.K726 = 0; }
            if (Form1.t >= 0) { Form1.K76 = 0; Form1.K726 = 0.6; }
            if (Form1.t >= 20) { Form1.K76 = 1; Form1.K726 = 1; }
            if (Form1.t >= 40) { Form1.K76 = 3.9; Form1.K726 = 1; }
            //Коэффициент К1
            Form1.K16 = 0.04;
            Form1.subst6 = 8;
        }
        //////////////////////////////////////====================================
        public static void VodorodFtoristiy()
        {
            Form1.M6 = 20.01;
            Form1.tkip6 = 19.52;
            Form1.Pi6 = 103;
            Form1.D6 = 4;
            Form1.p6 = 0.989;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K76 = 0.1; }
            if (Form1.t >= -20) { Form1.K76 = 0.2; }
            if (Form1.t >= 0) { Form1.K76 = 0.5; }
            if (Form1.t >= 20) { Form1.K76 = 1; }
            if (Form1.t >= 40) { Form1.K76 = 1; }
            Form1.K726 = Form1.K76;
            //Коэффициент К1
            Form1.K16 = 0;
            Form1.subst6 = 9;
        }
        //////////////////////////////////////
        public static void VodorodCianistiy()
        {
            Form1.M6 = 27.03;
            Form1.tkip6 = 25.7;
            Form1.p6 = 0.687;
            Form1.Pi6 = 82.25;
            Form1.D6 = 0.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K76 = 0; }
            if (Form1.t >= -20) { Form1.K76 = 0; }
            if (Form1.t >= 0) { Form1.K76 = 0.4; }
            if (Form1.t >= 20) { Form1.K76 = 1; }
            if (Form1.t >= 40) { Form1.K76 = 1.3; }
            Form1.K726 = Form1.K76;
            //Коэффициент К1
            Form1.K16 = 0;
            Form1.subst6 = 10;
        }
        //////////////////////////////////////
        public static void DvuokisAzota()
        {
            Form1.M6 = 46.01;
            Form1.tkip6 = 21.0;
            Form1.p6 = 1.491;
            Form1.Pi6 = 97.04;
            Form1.D6 = 1.5;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K76 = 0; }
            if (Form1.t >= -20) { Form1.K76 = 0; }
            if (Form1.t >= 0) { Form1.K76 = 0.4; }
            if (Form1.t >= 20) { Form1.K76 = 1; }
            if (Form1.t >= 40) { Form1.K76 = 1; }
            Form1.K726 = Form1.K76;
            //Коэффициент К1
            Form1.K16 = 0;
            Form1.subst6 = 11;
        }
        //////////////////////////////////////
        public static void SernistiyAngidrid()
        {
            Form1.M6 = 64.06;
            Form1.tkip6 = -10.1;
            Form1.p6 = 1.462;
            Form1.Pi6 = 100.8;
            Form1.D6 = 1.8;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K76 = 0; Form1.K726 = 0.2; }
            if (Form1.t >= -20) { Form1.K76 = 0; Form1.K726 = 0.5; }
            if (Form1.t >= 0) { Form1.K76 = 0.3; Form1.K726 = 1; }
            if (Form1.t >= 20) { Form1.K76 = 1; Form1.K726 = 1; }
            if (Form1.t >= 40) { Form1.K76 = 1.7; Form1.K726 = 1; }
            //Коэффициент К1
            Form1.K16 = 0.11;
            Form1.subst6 = 12;
        }
        //////////////////////////////////////
        public static void Serouglerod()
        {
            Form1.M6 = 76.14;
            Form1.tkip6 = 46.2;
            Form1.p6 = 1.263;
            Form1.Pi6 = 39.60;
            Form1.D6 = 45;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K76 = 0.1; }
            if (Form1.t >= -20) { Form1.K76 = 0.2; }
            if (Form1.t >= 0) { Form1.K76 = 0.4; }
            if (Form1.t >= 20) { Form1.K76 = 1; }
            if (Form1.t >= 40) { Form1.K76 = 2.1; }
            Form1.K726 = Form1.K76;
            //Коэффициент К1
            Form1.K16 = 0;
            Form1.subst6 = 13;
        }
        //////////////////////////////////////
        public static void SolyanayaKislota()
        {
            Form1.M6 = 36.46;
            Form1.tkip6 = 108.6;
            Form1.p6 = 1.198;
            Form1.Pi6 = 57.19;
            Form1.D6 = 2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K76 = 0; }
            if (Form1.t >= -20) { Form1.K76 = 0.1; }
            if (Form1.t >= 0) { Form1.K76 = 0.3; }
            if (Form1.t >= 20) { Form1.K76 = 1; }
            if (Form1.t >= 40) { Form1.K76 = 1.6; }
            Form1.K726 = Form1.K76;
            //Коэффициент К1
            Form1.K16 = 0;
            Form1.subst6 = 14;
        }
        //////////////////////////////////////
        public static void Formaldegid()
        {
            Form1.M6 = 30.03;
            Form1.tkip6 = -19.0;
            Form1.p6 = 0.815;
            Form1.Pi6 = 102.10;
            Form1.D6 = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K76 = 0; Form1.K726 = 0.4; }
            if (Form1.t >= -20) { Form1.K76 = 0; Form1.K726 = 1; }
            if (Form1.t >= 0) { Form1.K76 = 0.5; Form1.K726 = 1; }
            if (Form1.t >= 20) { Form1.K76 = 1; Form1.K726 = 1; }
            if (Form1.t >= 40) { Form1.K76 = 1.5; Form1.K726 = 1; }
            //Коэффициент К1
            Form1.K16 = 0.19;
            Form1.subst6 = 15;
        }
        /// <summary>
        /// /////////////////////////
        /// </summary>
        public static void VodorodMishyak()
        {
            substanceAXOB1.VodorodMishyak();
            Form1.tkip6 = Form1.tkip1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
        //////////////////////////////////////
        public static void Dimetilamin()
        {
            substanceAXOB1.Dimetilamin();
            Form1.tkip6 = Form1.tkip1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
        //////////////////////////////////////
        public static void Metilamin()
        {
            substanceAXOB1.Metilamin();
            Form1.tkip6 = Form1.tkip1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
        //////////////////////////////////////
        public static void MetilChlor()
        {
            substanceAXOB1.MetilChlor();
            Form1.tkip6 = Form1.tkip1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
        //////////////////////////////////////
        public static void NitrilAkrilKisl()
        {
            substanceAXOB1.NitrilAkrilKisl();
            Form1.tkip6 = Form1.tkip1;
            Form1.p6 = Form1.p1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
        public static void Akrolein()
        {
            substanceAXOB1.Akrolein();
            Form1.tkip6 = Form1.tkip1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
        public static void Azetonitril()
        {
            substanceAXOB1.Azetonitril();
            Form1.tkip6 = Form1.tkip1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
        public static void Azetonziangidrin()
        {
            substanceAXOB1.Azetonziangidrin();
            Form1.tkip6 = Form1.tkip1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
        public static void MetilBrom()
        {
            substanceAXOB1.MetilBrom();
            Form1.tkip6 = Form1.tkip1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
        public static void Metilakrilat()
        {
            substanceAXOB1.Metilakrilat();
            Form1.tkip6 = Form1.tkip1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
        public static void Metilmerkaptan()
        {
            substanceAXOB1.Metilmerkaptan();
            Form1.tkip6 = Form1.tkip1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
        public static void OkisEtilen()
        {
            substanceAXOB1.OkisEtilen();
            Form1.tkip6 = Form1.tkip1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
        public static void Trimetilamin()
        {
            substanceAXOB1.Trimetilamin();
            Form1.tkip6 = Form1.tkip1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
        public static void FosforTrehchlor()
        {
            substanceAXOB1.FosforTrehchlor();
            Form1.tkip6 = Form1.tkip1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
        public static void FosforaChlorokis()
        {
            substanceAXOB1.FosforaChlorokis();
            Form1.tkip6 = Form1.tkip1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
        public static void Chlorpikrin()
        {
            substanceAXOB1.Chlorpikrin();
            Form1.tkip6 = Form1.tkip1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
        public static void Etilenimin()
        {
            substanceAXOB1.Etilenimin();
            Form1.tkip6 = Form1.tkip1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
        public static void Etilensulfid()
        {
            substanceAXOB1.Etilensulfid();
            Form1.tkip6 = Form1.tkip1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
        public static void Etilmerkaptan()
        {
            substanceAXOB1.Etilmerkaptan();
            Form1.tkip6 = Form1.tkip1;
            Form1.D6 = Form1.D1;
            Form1.K76 = Form1.K711;
            Form1.K726 = Form1.K721;
            Form1.K16 = Form1.K11;
            Form1.K26 = Form1.K21;
            Form1.subst6 = Form1.subst1;
        }
    }
}
