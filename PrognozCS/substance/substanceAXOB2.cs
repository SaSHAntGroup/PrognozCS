using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrognozCS
{
    class substanceAXOB2
    {
        //Присваивание параметров АХОВ
        public static void Empty()
        {
            Form1.M2 = 0;
            Form1.tkip2 = 0;
            Form1.Pi2 = 0;
            Form1.D2 = 0;
            Form1.p2 = 0;
        }
        //////////////////////////////////////
        public static void Chlor()
        {
            Form1.M2 = 70.91;
            Form1.tkip2 = -34.7;
            Form1.Pi2 = 101.58;
            Form1.D2 = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K712 = 0; Form1.K722 = 0.9; }
            if (Form1.t >= -20) { Form1.K712 = 0.3; Form1.K722 = 1; }
            if (Form1.t >= 0) { Form1.K712 = 0.6; Form1.K722 = 1; }
            if (Form1.t >= 20) { Form1.K712 = 1; Form1.K722 = 1; }
            if (Form1.t >= 40) { Form1.K712 = 1.4; Form1.K722 = 2; }
            //Коэффициент К1
            Form1.K12 = 0.18;
        }
        //////////////////////////////////////
        public static void Ammiak()
        {
            Form1.M2 = 17.03;
            Form1.tkip2 = -33.42;
            Form1.Pi2 = 99.7;
            Form1.D2 = 15;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K712 = 0; Form1.K722 = 0.9; }
            if (Form1.t >= -20) { Form1.K712 = 0.3; Form1.K722 = 1; }
            if (Form1.t >= 0) { Form1.K712 = 0.6; Form1.K722 = 1; }
            if (Form1.t >= 20) { Form1.K712 = 1; Form1.K722 = 1; }
            if (Form1.t >= 40) { Form1.K712 = 1.4; Form1.K722 = 1; }
            //Коэффициент К1
            Form1.K12 = 0.18;
        }
        //////////////////////////////////////
        public static void VodorodChlor()
        {
            Form1.M2 = 36.46;
            Form1.tkip2 = -85.1;
            Form1.Pi2 = 100.8;
            Form1.D2 = 2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K712 = 0.64; Form1.K722 = 1; }
            if (Form1.t >= -20) { Form1.K712 = 0.6; Form1.K722 = 1; }
            if (Form1.t >= 0) { Form1.K712 = 0.8; Form1.K722 = 1; }
            if (Form1.t >= 20) { Form1.K712 = 1; Form1.K722 = 1; }
            if (Form1.t >= 40) { Form1.K712 = 1.2; Form1.K722 = 1; }
            //Коэффициент К1
            Form1.K12 = 0.28;
        }
        //////////////////////////////////////
        public static void VodorodBrom()
        {
            Form1.M2 = 80.92;
            Form1.tkip2 = -66.77;
            Form1.Pi2 = 101.6;
            Form1.D2 = 2.4;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K712 = 0.2; Form1.K722 = 1; }
            if (Form1.t >= -20) { Form1.K712 = 0.5; Form1.K722 = 1; }
            if (Form1.t >= 0) { Form1.K712 = 0.8; Form1.K722 = 1; }
            if (Form1.t >= 20) { Form1.K712 = 1; Form1.K722 = 1; }
            if (Form1.t >= 40) { Form1.K712 = 1.2; Form1.K722 = 1; }
            //Коэффициент К1
            Form1.K12 = 0.13;
        }
        //////////////////////////////////////
        public static void Serovodorod()
        {
            Form1.M2 = 34.08;
            Form1.tkip2 = -60.35;
            Form1.Pi2 = 118.37;
            Form1.D2 = 16.1;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K712 = 0.3; Form1.K722 = 1; }
            if (Form1.t >= -20) { Form1.K712 = 0.5; Form1.K722 = 1; }
            if (Form1.t >= 0) { Form1.K712 = 0.8; Form1.K722 = 1; }
            if (Form1.t >= 20) { Form1.K712 = 1; Form1.K722 = 1; }
            if (Form1.t >= 40) { Form1.K712 = 1.2; Form1.K722 = 1; }
            //Коэффициент К1
            Form1.K12 = 0.27;
        }
        //////////////////////////////////////
        public static void Fosgen()
        {
            Form1.M2 = 98.92;
            Form1.tkip2 = 8.2;
            Form1.Pi2 = 100.9;
            Form1.D2 = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K712 = 0; Form1.K722 = 0.1; }
            if (Form1.t >= -20) { Form1.K712 = 0; Form1.K722 = 0.3; }
            if (Form1.t >= 0) { Form1.K712 = 0; Form1.K722 = 0.7; }
            if (Form1.t >= 20) { Form1.K712 = 1; Form1.K722 = 1; }
            if (Form1.t >= 40) { Form1.K712 = 2.2; Form1.K722 = 1; }
            //Коэффициент К1
            Form1.K12 = 0.05;
        }
        //////////////////////////////////////
        public static void Ftor()
        {
            Form1.M2 = 38.0;
            Form1.tkip2 = -188.2;
            Form1.Pi2 = 101.44;
            Form1.D2 = 0.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K712 = 0.7; Form1.K722 = 1; }
            if (Form1.t >= -20) { Form1.K712 = 0.8; Form1.K722 = 1; }
            if (Form1.t >= 0) { Form1.K712 = 0.9; Form1.K722 = 1; }
            if (Form1.t >= 20) { Form1.K712 = 1; Form1.K722 = 1; }
            if (Form1.t >= 40) { Form1.K712 = 1.1; Form1.K722 = 1; }
            //Коэффициент К1
            Form1.K12 = 0.95;
        }
        //////////////////////////////////////
        public static void Chlorician()
        {
            Form1.M2 = 61.47;
            Form1.tkip2 = 12.6;
            Form1.Pi2 = 100.80;
            Form1.D2 = 0.75;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K712 = 0; Form1.K722 = 0; }
            if (Form1.t >= -20) { Form1.K712 = 0; Form1.K722 = 0; }
            if (Form1.t >= 0) { Form1.K712 = 0; Form1.K722 = 0.6; }
            if (Form1.t >= 20) { Form1.K712 = 1; Form1.K722 = 1; }
            if (Form1.t >= 40) { Form1.K712 = 3.9; Form1.K722 = 1; }
            //Коэффициент К1
            Form1.K12 = 0.04;
        }
        //////////////////////////////////////====================================
        public static void VodorodFtoristiy()
        {
            Form1.M2 = 20.01;
            Form1.tkip2 = 19.52;
            Form1.Pi2 = 103;
            Form1.D2 = 4;
            Form1.p2 = 0.989;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K712 = 0.1; }
            if (Form1.t >= -20) { Form1.K712 = 0.2; }
            if (Form1.t >= 0) { Form1.K712 = 0.5; }
            if (Form1.t >= 20) { Form1.K712 = 1; }
            if (Form1.t >= 40) { Form1.K712 = 1; }
            Form1.K722 = Form1.K712;
            //Коэффициент К1
            Form1.K12 = 0;
        }
        //////////////////////////////////////
        public static void VodorodCianistiy()
        {
            Form1.M2 = 27.03;
            Form1.tkip2 = 25.7;
            Form1.p2 = 0.687;
            Form1.Pi2 = 82.25;
            Form1.D2 = 0.2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K712 = 0; }
            if (Form1.t >= -20) { Form1.K712 = 0; }
            if (Form1.t >= 0) { Form1.K712 = 0.4; }
            if (Form1.t >= 20) { Form1.K712 = 1; }
            if (Form1.t >= 40) { Form1.K712 = 1.3; }
            Form1.K722 = Form1.K712;
            //Коэффициент К1
            Form1.K12 = 0;
        }
        //////////////////////////////////////
        public static void DvuokisAzota()
        {
            Form1.M2 = 46.01;
            Form1.tkip2 = 21.0;
            Form1.p2 = 1.491;
            Form1.Pi2 = 97.04;
            Form1.D2 = 1.5;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K712 = 0; }
            if (Form1.t >= -20) { Form1.K712 = 0; }
            if (Form1.t >= 0) { Form1.K712 = 0.4; }
            if (Form1.t >= 20) { Form1.K712 = 1; }
            if (Form1.t >= 40) { Form1.K712 = 1; }
            Form1.K722 = Form1.K712;
            //Коэффициент К1
            Form1.K12 = 0;
        }
        //////////////////////////////////////
        public static void SernistiyAngidrid()
        {
            Form1.M2 = 64.06;
            Form1.tkip2 = -10.1;
            Form1.p2 = 1.462;
            Form1.Pi2 = 100.8;
            Form1.D2 = 1.8;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K712 = 0; Form1.K722 = 0.2; }
            if (Form1.t >= -20) { Form1.K712 = 0; Form1.K722 = 0.5; }
            if (Form1.t >= 0) { Form1.K712 = 0.3; Form1.K722 = 1; }
            if (Form1.t >= 20) { Form1.K712 = 1; Form1.K722 = 1; }
            if (Form1.t >= 40) { Form1.K712 = 1.7; Form1.K722 = 1; }
            //Коэффициент К1
            Form1.K12 = 0.11;
        }
        //////////////////////////////////////
        public static void Serouglerod()
        {
            Form1.M2 = 76.14;
            Form1.tkip2 = 46.2;
            Form1.p2 = 1.263;
            Form1.Pi2 = 39.60;
            Form1.D2 = 45;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K712 = 0.1; }
            if (Form1.t >= -20) { Form1.K712 = 0.2; }
            if (Form1.t >= 0) { Form1.K712 = 0.4; }
            if (Form1.t >= 20) { Form1.K712 = 1; }
            if (Form1.t >= 40) { Form1.K712 = 2.1; }
            Form1.K722 = Form1.K712;
            //Коэффициент К1
            Form1.K12 = 0;
        }
        //////////////////////////////////////
        public static void SolyanayaKislota()
        {
            Form1.M2 = 36.46;
            Form1.tkip2 = 108.6;
            Form1.p2 = 1.198;
            Form1.Pi2 = 57.19;
            Form1.D2 = 2;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K712 = 0; }
            if (Form1.t >= -20) { Form1.K712 = 0.1; }
            if (Form1.t >= 0) { Form1.K712 = 0.3; }
            if (Form1.t >= 20) { Form1.K712 = 1; }
            if (Form1.t >= 40) { Form1.K712 = 1.6; }
            Form1.K722 = Form1.K712;
            //Коэффициент К1
            Form1.K12 = 0;
        }
        //////////////////////////////////////
        public static void Formaldegid()
        {
            Form1.M2 = 30.03;
            Form1.tkip2 = -19.0;
            Form1.p2 = 0.815;
            Form1.Pi2 = 102.10;
            Form1.D2 = 0.6;
            //Определение К7 при температуре окружающей среды
            if ((Form1.t >= -40) || (Form1.t < -40)) { Form1.K712 = 0; Form1.K722 = 0.4; }
            if (Form1.t >= -20) { Form1.K712 = 0; Form1.K722 = 1; }
            if (Form1.t >= 0) { Form1.K712 = 0.5; Form1.K722 = 1; }
            if (Form1.t >= 20) { Form1.K712 = 1; Form1.K722 = 1; }
            if (Form1.t >= 40) { Form1.K712 = 1.5; Form1.K722 = 1; }
            //Коэффициент К1
            Form1.K12 = 0.19;
        }
        /// <summary>
        /// /////////////////////////
        /// </summary>
        public static void VodorodMishyak()
        {
            substanceAXOB1.VodorodMishyak();
            Form1.tkip2 = Form1.tkip1;
            Form1.D2 = Form1.D1;
            Form1.K712 = Form1.K711;
            Form1.K722 = Form1.K721;
            Form1.K12 = Form1.K11;
            Form1.K22 = Form1.K21;
        }
        //////////////////////////////////////
        public static void Dimetilamin()
        {
            substanceAXOB1.Dimetilamin();
            Form1.tkip2 = Form1.tkip1;
            Form1.D2 = Form1.D1;
            Form1.K712 = Form1.K711;
            Form1.K722 = Form1.K721;
            Form1.K12 = Form1.K11;
            Form1.K22 = Form1.K21;
        }
        //////////////////////////////////////
        public static void Metilamin()
        {
            substanceAXOB1.Metilamin();
            Form1.tkip2 = Form1.tkip1;
            Form1.D2 = Form1.D1;
            Form1.K712 = Form1.K711;
            Form1.K722 = Form1.K721;
            Form1.K12 = Form1.K11;
            Form1.K22 = Form1.K21;
        }
        //////////////////////////////////////
        public static void MetilChlor()
        {
            substanceAXOB1.MetilChlor();
            Form1.tkip2 = Form1.tkip1;
            Form1.D2 = Form1.D1;
            Form1.K712 = Form1.K711;
            Form1.K722 = Form1.K721;
            Form1.K12 = Form1.K11;
            Form1.K22 = Form1.K21;
        }
        //////////////////////////////////////
        public static void NitrilAkrilKisl()
        {
            substanceAXOB1.NitrilAkrilKisl();
            Form1.tkip2 = Form1.tkip1;
            Form1.p2 = Form1.p1;
            Form1.D2 = Form1.D1;
            Form1.K712 = Form1.K711;
            Form1.K722 = Form1.K721;
            Form1.K12 = Form1.K11;
            Form1.K22 = Form1.K21;
        }
        public static void Akrolein()
        {
            
        }
        public static void Azetonitril()
        {
            
        }
        public static void Azetonziangidrin()
        {
            
        }
        public static void MetilBrom()
        {
            
        }
        public static void Metilakrilat()
        {
            
        }
        public static void Metilmerkaptan()
        {
            
        }
        public static void OkisEtilen()
        {
            
        }
        public static void Trimetilamin()
        {
            
        }
        public static void FosforTrehchlor()
        {
            
        }
        public static void FosforaChlorokis()
        {
            
        }
        public static void Chlorpikrin()
        {
            
        }
        public static void Etilenimin()
        {
            
        }
        public static void Etilensulfid()
        {
            
        }
        public static void Etilmerkaptan()
        {
            
        }
    }
}
