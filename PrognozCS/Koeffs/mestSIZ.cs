using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrognozCS
{
    class mestSIZ
    {
        static public void percentOpenMest()
        {
            /*
             * Для города 
             */
            //В противогазах на открытой месtности
            if (Form1.n1g >= 0 || Form1.n1g < 10) { Form1.N11 = 1; }
            if (Form1.n1g >= 10 || Form1.n1g < 20) { Form1.N11 = 0.9; }
            if (Form1.n1g >= 20 || Form1.n1g < 30) { Form1.N11 = 0.75; }
            if (Form1.n1g >= 30 || Form1.n1g < 40) { Form1.N11 = 0.65; }
            if (Form1.n1g >= 40 || Form1.n1g < 50) { Form1.N11 = 0.58; }
            if (Form1.n1g >= 50 || Form1.n1g < 60) { Form1.N11 = 0.50; }
            if (Form1.n1g >= 60 || Form1.n1g < 70) { Form1.N11 = 0.40; }
            if (Form1.n1g >= 70 || Form1.n1g < 80) { Form1.N11 = 0.35; }
            if (Form1.n1g >= 80 || Form1.n1g < 90) { Form1.N11 = 0.25; }
            if (Form1.n1g >= 90 || Form1.n1g < 100) { Form1.N11 = 0.18; }
            if (Form1.n1g == 100) { Form1.N11 = 0.10; }
            //В противогазах в зданиях
            if (Form1.n3g >= 0 || Form1.n3g < 10) { Form1.N31 = 0.50; }
            if (Form1.n3g >= 10 || Form1.n3g < 20) { Form1.N31 = 0.50; }
            if (Form1.n3g >= 20 || Form1.n3g < 30) { Form1.N31 = 0.40; }
            if (Form1.n3g >= 30 || Form1.n3g < 40) { Form1.N31 = 0.35; }
            if (Form1.n3g >= 40 || Form1.n3g < 50) { Form1.N31 = 0.30; }
            if (Form1.n3g >= 50 || Form1.n3g < 60) { Form1.N31 = 0.27; }
            if (Form1.n3g >= 60 || Form1.n3g < 70) { Form1.N31 = 0.22; }
            if (Form1.n3g >= 70 || Form1.n3g < 80) { Form1.N31 = 0.18; }
            if (Form1.n3g >= 80 || Form1.n3g < 90) { Form1.N31 = 0.14; }
            if (Form1.n3g >= 90 || Form1.n3g < 100) { Form1.N31 = 0.09; }
            if (Form1.n3g == 100) { Form1.N31 = 0.04; }
            //В убежищах
            if (Form1.n2g >= 0 || Form1.n2g < 20) { Form1.N21 = 1; }
            if (Form1.n2g >= 20 || Form1.n2g < 100) { Form1.N21 = 1; }
            /*
             * Для загородной зоны
             */
            //В противогазах на открытой месtности
            if (Form1.n1z >= 0 || Form1.n1z < 10) { Form1.N12 = 1; }
            if (Form1.n1z >= 10 || Form1.n1z < 20) { Form1.N12 = 0.9; }
            if (Form1.n1z >= 20 || Form1.n1z < 30) { Form1.N12 = 0.75; }
            if (Form1.n1z >= 30 || Form1.n1z < 40) { Form1.N12 = 0.65; }
            if (Form1.n1z >= 40 || Form1.n1z < 50) { Form1.N12 = 0.58; }
            if (Form1.n1z >= 50 || Form1.n1z < 60) { Form1.N12 = 0.50; }
            if (Form1.n1z >= 60 || Form1.n1z < 70) { Form1.N12 = 0.40; }
            if (Form1.n1z >= 70 || Form1.n1z < 80) { Form1.N12 = 0.35; }
            if (Form1.n1z >= 80 || Form1.n1z < 90) { Form1.N12 = 0.25; }
            if (Form1.n1z >= 90 || Form1.n1z < 100) { Form1.N12 = 0.18; }
            if (Form1.n1z == 100) { Form1.N12 = 0.10; }
            //В противогазах в зданиях
            if (Form1.n3z >= 0 || Form1.n3z < 10) { Form1.N32 = 0.50; }
            if (Form1.n3z >= 10 || Form1.n3z < 20) { Form1.N32 = 0.50; }
            if (Form1.n3z >= 20 || Form1.n3z < 30) { Form1.N32 = 0.40; }
            if (Form1.n3z >= 30 || Form1.n3z < 40) { Form1.N32 = 0.35; }
            if (Form1.n3z >= 40 || Form1.n3z < 50) { Form1.N32 = 0.30; }
            if (Form1.n3z >= 50 || Form1.n3z < 60) { Form1.N32 = 0.27; }
            if (Form1.n3z >= 60 || Form1.n3z < 70) { Form1.N32 = 0.22; }
            if (Form1.n3z >= 70 || Form1.n3z < 80) { Form1.N32 = 0.18; }
            if (Form1.n3z >= 80 || Form1.n3z < 90) { Form1.N32 = 0.14; }
            if (Form1.n3z >= 90 || Form1.n3z < 100) { Form1.N32 = 0.09; }
            if (Form1.n3z == 100) { Form1.N32 = 0.04; }
            //В убежищах
            if (Form1.n2z >= 0 || Form1.n2z < 20) { Form1.N22 = 1; }
            if (Form1.n2z >= 20 || Form1.n2z < 100) { Form1.N22 = 1; }
        }

        static public void percentInObject()
        {
            //В противогазах на открытой месtности
            if (Form1.n1o >= 0 || Form1.n1o < 10) { Form1.N13 = 1; }
            if (Form1.n1o >= 10 || Form1.n1o < 20) { Form1.N13 = 0.9; }
            if (Form1.n1o >= 20 || Form1.n1o < 30) { Form1.N13 = 0.75; }
            if (Form1.n1o >= 30 || Form1.n1o < 40) { Form1.N13 = 0.65; }
            if (Form1.n1o >= 40 || Form1.n1o < 50) { Form1.N13 = 0.58; }
            if (Form1.n1o >= 50 || Form1.n1o < 60) { Form1.N13 = 0.50; }
            if (Form1.n1o >= 60 || Form1.n1o < 70) { Form1.N13 = 0.40; }
            if (Form1.n1o >= 70 || Form1.n1o < 80) { Form1.N13 = 0.35; }
            if (Form1.n1o >= 80 || Form1.n1o < 90) { Form1.N13 = 0.25; }
            if (Form1.n1o >= 90 || Form1.n1o < 100) { Form1.N13 = 0.18; }
            if (Form1.n1o == 100) { Form1.N13 = 0.10; }
            //В противогазах в зданиях
            if (Form1.n2o >= 0 || Form1.n2o < 10) { Form1.N23 = 0.50; }
            if (Form1.n2o >= 10 || Form1.n2o < 20) { Form1.N23 = 0.50; }
            if (Form1.n2o >= 20 || Form1.n2o < 30) { Form1.N23 = 0.40; }
            if (Form1.n2o >= 30 || Form1.n2o < 40) { Form1.N23 = 0.35; }
            if (Form1.n2o >= 40 || Form1.n2o < 50) { Form1.N23 = 0.30; }
            if (Form1.n2o >= 50 || Form1.n2o < 60) { Form1.N23 = 0.27; }
            if (Form1.n2o >= 60 || Form1.n2o < 70) { Form1.N23 = 0.22; }
            if (Form1.n2o >= 70 || Form1.n2o < 80) { Form1.N23 = 0.18; }
            if (Form1.n2o >= 80 || Form1.n2o < 90) { Form1.N23 = 0.14; }
            if (Form1.n2o >= 90 || Form1.n2o < 100) { Form1.N23 = 0.09; }
            if (Form1.n2o == 100) { Form1.N23 = 0.04; }
        }
    }
}
