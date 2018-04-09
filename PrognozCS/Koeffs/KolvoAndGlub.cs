using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrognozCS
{
    class KolvoAndGlub
    {
        public static void Tabl()
        {
            if ((Form1.v >= 1) || (Form1.v < 1))
            {
                if ((Form1.Qe1 >= 0.01) && (Form1.Qe1 < 0.05)) { Form1.Gb1 = 0.85; Form1.Gm1 = 0.38; Form1.Qb1 = 0.05; Form1.Qm1 = 0.01; }
                if ((Form1.Qe2 >= 0.01) && (Form1.Qe2 < 0.05)) { Form1.Gb2 = 0.85; Form1.Gm2 = 0.38; Form1.Qb2 = 0.05; Form1.Qm2 = 0.01; }
                if ((Form1.Qe1 >= 0.05) && (Form1.Qe1 < 0.1)) { Form1.Gb1 = 1.25; Form1.Gm1 = 0.85; Form1.Qb1 = 0.1; Form1.Qm1 = 0.05; }
                if ((Form1.Qe2 >= 0.05) && (Form1.Qe2 < 0.1)) { Form1.Gb2 = 1.25; Form1.Gm2 = 0.85; Form1.Qb2 = 0.1; Form1.Qm2 = 0.05; }
                if ((Form1.Qe1 >= 0.1) && (Form1.Qe1 < 0.5)) { Form1.Gb1 = 3.16; Form1.Gm1 = 1.25; Form1.Qb1 = 0.5; Form1.Qm1 = 0.1; }
                if ((Form1.Qe2 >= 0.1) && (Form1.Qe2 < 0.5)) { Form1.Gb2 = 3.16; Form1.Gm2 = 1.25; Form1.Qb2 = 0.5; Form1.Qm2 = 0.1; }
                if ((Form1.Qe1 >= 0.5) && (Form1.Qe1 < 1)) { Form1.Gb1 = 4.75; Form1.Gm1 = 3.16; Form1.Qb1 = 1; Form1.Qm1 = 0.5; }
                if ((Form1.Qe2 >= 0.5) && (Form1.Qe2 < 1)) { Form1.Gb2 = 4.75; Form1.Gm2 = 3.16; Form1.Qb2 = 1; Form1.Qm2 = 0.5; }
                if ((Form1.Qe1 >= 1) && (Form1.Qe1 < 3)) { Form1.Gb1 = 9.18; Form1.Gm1 = 4.75; Form1.Qb1 = 3; Form1.Qm1 = 1; }
                if ((Form1.Qe2 >= 1) && (Form1.Qe2 < 3)) { Form1.Gb2 = 9.18; Form1.Gm2 = 4.75; Form1.Qb2 = 3; Form1.Qm2 = 1; }
                if ((Form1.Qe1 >= 3) && (Form1.Qe1 < 5)) { Form1.Gb1 = 12.53; Form1.Gm1 = 9.18; Form1.Qb1 = 5; Form1.Qm1 = 3; }
                if ((Form1.Qe2 >= 3) && (Form1.Qe2 < 5)) { Form1.Gb2 = 12.53; Form1.Gm2 = 9.18; Form1.Qb2 = 5; Form1.Qm2 = 3; }
                if ((Form1.Qe1 >= 5) && (Form1.Qe1 < 10)) { Form1.Gb1 = 19.2; Form1.Gm1 = 12.53; Form1.Qb1 = 10; Form1.Qm1 = 5; }
                if ((Form1.Qe2 >= 5) && (Form1.Qe2 < 10)) { Form1.Gb2 = 19.2; Form1.Gm2 = 12.53; Form1.Qb2 = 10; Form1.Qm2 = 5; }
                if ((Form1.Qe1 >= 10) && (Form1.Qe1 < 20)) { Form1.Gb1 = 29.56; Form1.Gm1 = 19.2; Form1.Qb1 = 20; Form1.Qm1 = 10; }
                if ((Form1.Qe2 >= 10) && (Form1.Qe2 < 20)) { Form1.Gb2 = 29.56; Form1.Gm2 = 19.2; Form1.Qb2 = 20; Form1.Qm2 = 10; }
                if ((Form1.Qe1 >= 20) && (Form1.Qe1 < 30)) { Form1.Gb1 = 38.13; Form1.Gm1 = 29.56; Form1.Qb1 = 30; Form1.Qm1 = 20; }
                if ((Form1.Qe2 >= 20) && (Form1.Qe2 < 30)) { Form1.Gb2 = 38.13; Form1.Gm2 = 29.56; Form1.Qb2 = 30; Form1.Qm2 = 20; }
                if ((Form1.Qe1 >= 30) && (Form1.Qe1 < 50)) { Form1.Gb1 = 52.67; Form1.Gm1 = 38.13; Form1.Qb1 = 50; Form1.Qm1 = 30; }
                if ((Form1.Qe2 >= 30) && (Form1.Qe2 < 50)) { Form1.Gb2 = 52.67; Form1.Gm2 = 38.13; Form1.Qb2 = 50; Form1.Qm2 = 30; }
                if ((Form1.Qe1 >= 50) && (Form1.Qe1 < 70)) { Form1.Gb1 = 65.23; Form1.Gm1 = 52.67; Form1.Qb1 = 70; Form1.Qm1 = 50; }
                if ((Form1.Qe2 >= 50) && (Form1.Qe2 < 70)) { Form1.Gb2 = 65.23; Form1.Gm2 = 52.67; Form1.Qb2 = 70; Form1.Qm2 = 50; }
                if ((Form1.Qe1 >= 70) && (Form1.Qe1 < 100)) { Form1.Gb1 = 81.91; Form1.Gm1 = 65.23; Form1.Qb1 = 100; Form1.Qm1 = 70; }
                if ((Form1.Qe2 >= 70) && (Form1.Qe2 < 100)) { Form1.Gb2 = 81.91; Form1.Gm2 = 65.23; Form1.Qb2 = 100; Form1.Qm2 = 70; }
                if ((Form1.Qe1 >= 100) && (Form1.Qe1 < 300)) { Form1.Gb1 = 166; Form1.Gm1 = 81.91; Form1.Qb1 = 300; Form1.Qm1 = 100; }
                if ((Form1.Qe2 >= 100) && (Form1.Qe2 < 300)) { Form1.Gb2 = 166; Form1.Gm2 = 81.91; Form1.Qb2 = 300; Form1.Qm2 = 100; }
                if ((Form1.Qe1 >= 300) && (Form1.Qe1 < 500)) { Form1.Gb1 = 231; Form1.Gm1 = 166; Form1.Qb1 = 500; Form1.Qm1 = 300; }
                if ((Form1.Qe2 >= 300) && (Form1.Qe2 < 500)) { Form1.Gb2 = 231; Form1.Gm2 = 166; Form1.Qb2 = 500; Form1.Qm2 = 300; }
                if ((Form1.Qe1 >= 500) && (Form1.Qe1 < 1000)) { Form1.Gb1 = 363; Form1.Gm1 = 231; Form1.Qb1 = 1000; Form1.Qm1 = 500; }
                if ((Form1.Qe2 >= 500) && (Form1.Qe2 < 1000)) { Form1.Gb2 = 363; Form1.Gm2 = 231; Form1.Qb2 = 1000; Form1.Qm2 = 500; }
            }
            if (Form1.v >= 2)
            {
                if ((Form1.Qe1 >= 0.01) && (Form1.Qe1 < 0.05)) { Form1.Gb1 = 0.59; Form1.Gm1 = 0.26; Form1.Qb1 = 0.05; Form1.Qm1 = 0.01; }
                if ((Form1.Qe2 >= 0.01) && (Form1.Qe2 < 0.05)) { Form1.Gb2 = 0.59; Form1.Gm2 = 0.26; Form1.Qb2 = 0.05; Form1.Qm2 = 0.01; }
                if ((Form1.Qe1 >= 0.05) && (Form1.Qe1 < 0.1)) { Form1.Gb1 = 0.84; Form1.Gm1 = 0.59; Form1.Qb1 = 0.1; Form1.Qm1 = 0.05; }
                if ((Form1.Qe2 >= 0.05) && (Form1.Qe2 < 0.1)) { Form1.Gb2 = 0.84; Form1.Gm2 = 0.59; Form1.Qb2 = 0.1; Form1.Qm2 = 0.05; }
                if ((Form1.Qe1 >= 0.1) && (Form1.Qe1 < 0.5)) { Form1.Gb1 = 1.92; Form1.Gm1 = 0.84; Form1.Qb1 = 0.5; Form1.Qm1 = 0.1; }
                if ((Form1.Qe2 >= 0.1) && (Form1.Qe2 < 0.5)) { Form1.Gb2 = 1.92; Form1.Gm2 = 0.84; Form1.Qb2 = 0.5; Form1.Qm2 = 0.1; }
                if ((Form1.Qe1 >= 0.5) && (Form1.Qe1 < 1)) { Form1.Gb1 = 2.84; Form1.Gm1 = 1.92; Form1.Qb1 = 1; Form1.Qm1 = 0.5; }
                if ((Form1.Qe2 >= 0.5) && (Form1.Qe2 < 1)) { Form1.Gb2 = 2.84; Form1.Gm2 = 1.92; Form1.Qb2 = 1; Form1.Qm2 = 0.5; }
                if ((Form1.Qe1 >= 1) && (Form1.Qe1 < 3)) { Form1.Gb1 = 5.35; Form1.Gm1 = 2.84; Form1.Qb1 = 3; Form1.Qm1 = 1; }
                if ((Form1.Qe2 >= 1) && (Form1.Qe2 < 3)) { Form1.Gb2 = 5.35; Form1.Gm2 = 2.84; Form1.Qb2 = 3; Form1.Qm2 = 1; }
                if ((Form1.Qe1 >= 3) && (Form1.Qe1 < 5)) { Form1.Gb1 = 7.2; Form1.Gm1 = 5.35; Form1.Qb1 = 5; Form1.Qm1 = 3; }
                if ((Form1.Qe2 >= 3) && (Form1.Qe2 < 5)) { Form1.Gb2 = 7.2; Form1.Gm2 = 5.35; Form1.Qb2 = 5; Form1.Qm2 = 3; }
                if ((Form1.Qe1 >= 5) && (Form1.Qe1 < 10)) { Form1.Gb1 = 10.83; Form1.Gm1 = 7.2; Form1.Qb1 = 10; Form1.Qm1 = 5; }
                if ((Form1.Qe2 >= 5) && (Form1.Qe2 < 10)) { Form1.Gb2 = 10.83; Form1.Gm2 = 7.2; Form1.Qb2 = 10; Form1.Qm2 = 5; }
                if ((Form1.Qe1 >= 10) && (Form1.Qe1 < 20)) { Form1.Gb1 = 16.44; Form1.Gm1 = 10.83; Form1.Qb1 = 20; Form1.Qm1 = 10; }
                if ((Form1.Qe2 >= 10) && (Form1.Qe2 < 20)) { Form1.Gb2 = 16.44; Form1.Gm2 = 10.83; Form1.Qb2 = 20; Form1.Qm2 = 10; }
                if ((Form1.Qe1 >= 20) && (Form1.Qe1 < 30)) { Form1.Gb1 = 21.02; Form1.Gm1 = 16.44; Form1.Qb1 = 30; Form1.Qm1 = 20; }
                if ((Form1.Qe2 >= 20) && (Form1.Qe2 < 30)) { Form1.Gb2 = 21.02; Form1.Gm2 = 16.44; Form1.Qb2 = 30; Form1.Qm2 = 20; }
                if ((Form1.Qe1 >= 30) && (Form1.Qe1 < 50)) { Form1.Gb1 = 28.73; Form1.Gm1 = 21.02; Form1.Qb1 = 50; Form1.Qm1 = 30; }
                if ((Form1.Qe2 >= 30) && (Form1.Qe2 < 50)) { Form1.Gb2 = 28.73; Form1.Gm2 = 21.02; Form1.Qb2 = 50; Form1.Qm2 = 30; }
                if ((Form1.Qe1 >= 50) && (Form1.Qe1 < 70)) { Form1.Gb1 = 35.35; Form1.Gm1 = 28.73; Form1.Qb1 = 70; Form1.Qm1 = 50; }
                if ((Form1.Qe2 >= 50) && (Form1.Qe2 < 70)) { Form1.Gb2 = 35.35; Form1.Gm2 = 28.73; Form1.Qb2 = 70; Form1.Qm2 = 50; }
                if ((Form1.Qe1 >= 70) && (Form1.Qe1 < 100)) { Form1.Gb1 = 44.09; Form1.Gm1 = 35.35; Form1.Qb1 = 100; Form1.Qm1 = 70; }
                if ((Form1.Qe2 >= 70) && (Form1.Qe2 < 100)) { Form1.Gb2 = 44.09; Form1.Gm2 = 35.35; Form1.Qb2 = 100; Form1.Qm2 = 70; }
                if ((Form1.Qe1 >= 100) && (Form1.Qe1 < 300)) { Form1.Gb1 = 87.79; Form1.Gm1 = 44.09; Form1.Qb1 = 300; Form1.Qm1 = 100; }
                if ((Form1.Qe2 >= 100) && (Form1.Qe2 < 300)) { Form1.Gb2 = 87.79; Form1.Gm2 = 44.09; Form1.Qb2 = 300; Form1.Qm2 = 100; }
                if ((Form1.Qe1 >= 300) && (Form1.Qe1 < 500)) { Form1.Gb1 = 121; Form1.Gm1 = 87.79; Form1.Qb1 = 500; Form1.Qm1 = 300; }
                if ((Form1.Qe2 >= 300) && (Form1.Qe2 < 500)) { Form1.Gb2 = 121; Form1.Gm2 = 87.79; Form1.Qb2 = 500; Form1.Qm2 = 300; }
                if ((Form1.Qe1 >= 500) && (Form1.Qe1 < 1000)) { Form1.Gb1 = 189; Form1.Gm1 = 121; Form1.Qb1 = 1000; Form1.Qm1 = 500; }
                if ((Form1.Qe2 >= 500) && (Form1.Qe2 < 1000)) { Form1.Gb2 = 189; Form1.Gm2 = 121; Form1.Qb2 = 1000; Form1.Qm2 = 500; }
            }
            if (Form1.v >= 3)
            {
                if ((Form1.Qe1 >= 0.01) && (Form1.Qe1 < 0.05)) { Form1.Gb1 = 0.48; Form1.Gm1 = 0.22; Form1.Qb1 = 0.05; Form1.Qm1 = 0.01; }
                if ((Form1.Qe2 >= 0.01) && (Form1.Qe2 < 0.05)) { Form1.Gb2 = 0.48; Form1.Gm2 = 0.22; Form1.Qb2 = 0.05; Form1.Qm2 = 0.01; }
                if ((Form1.Qe1 >= 0.05) && (Form1.Qe1 < 0.1)) { Form1.Gb1 = 0.68; Form1.Gm1 = 0.48; Form1.Qb1 = 0.1; Form1.Qm1 = 0.05; }
                if ((Form1.Qe2 >= 0.05) && (Form1.Qe2 < 0.1)) { Form1.Gb2 = 0.68; Form1.Gm2 = 0.48; Form1.Qb2 = 0.1; Form1.Qm2 = 0.05; }
                if ((Form1.Qe1 >= 0.1) && (Form1.Qe1 < 0.5)) { Form1.Gb1 = 1.53; Form1.Gm1 = 0.68; Form1.Qb1 = 0.5; Form1.Qm1 = 0.1; }
                if ((Form1.Qe2 >= 0.1) && (Form1.Qe2 < 0.5)) { Form1.Gb2 = 1.53; Form1.Gm2 = 0.68; Form1.Qb2 = 0.5; Form1.Qm2 = 0.1; }
                if ((Form1.Qe1 >= 0.5) && (Form1.Qe1 < 1)) { Form1.Gb1 = 2.17; Form1.Gm1 = 1.53; Form1.Qb1 = 1; Form1.Qm1 = 0.5; }
                if ((Form1.Qe2 >= 0.5) && (Form1.Qe2 < 1)) { Form1.Gb2 = 2.17; Form1.Gm2 = 1.53; Form1.Qb2 = 1; Form1.Qm2 = 0.5; }
                if ((Form1.Qe1 >= 1) && (Form1.Qe1 < 3)) { Form1.Gb1 = 3.99; Form1.Gm1 = 2.17; Form1.Qb1 = 3; Form1.Qm1 = 1; }
                if ((Form1.Qe2 >= 1) && (Form1.Qe2 < 3)) { Form1.Gb2 = 3.99; Form1.Gm2 = 2.17; Form1.Qb2 = 3; Form1.Qm2 = 1; }
                if ((Form1.Qe1 >= 3) && (Form1.Qe1 < 5)) { Form1.Gb1 = 5.34; Form1.Gm1 = 3.99; Form1.Qb1 = 5; Form1.Qm1 = 3; }
                if ((Form1.Qe2 >= 3) && (Form1.Qe2 < 5)) { Form1.Gb2 = 5.34; Form1.Gm2 = 3.99; Form1.Qb2 = 5; Form1.Qm2 = 3; }
                if ((Form1.Qe1 >= 5) && (Form1.Qe1 < 10)) { Form1.Gb1 = 7.96; Form1.Gm1 = 5.34; Form1.Qb1 = 10; Form1.Qm1 = 5; }
                if ((Form1.Qe2 >= 5) && (Form1.Qe2 < 10)) { Form1.Gb2 = 7.96; Form1.Gm2 = 5.34; Form1.Qb2 = 10; Form1.Qm2 = 5; }
                if ((Form1.Qe1 >= 10) && (Form1.Qe1 < 20)) { Form1.Gb1 = 11.94; Form1.Gm1 = 7.96; Form1.Qb1 = 20; Form1.Qm1 = 10; }
                if ((Form1.Qe2 >= 10) && (Form1.Qe2 < 20)) { Form1.Gb2 = 11.94; Form1.Gm2 = 7.96; Form1.Qb2 = 20; Form1.Qm2 = 10; }
                if ((Form1.Qe1 >= 20) && (Form1.Qe1 < 30)) { Form1.Gb1 = 15.18; Form1.Gm1 = 11.94; Form1.Qb1 = 30; Form1.Qm1 = 20; }
                if ((Form1.Qe2 >= 20) && (Form1.Qe2 < 30)) { Form1.Gb2 = 15.18; Form1.Gm2 = 11.94; Form1.Qb2 = 30; Form1.Qm2 = 20; }
                if ((Form1.Qe1 >= 30) && (Form1.Qe1 < 50)) { Form1.Gb1 = 20.59; Form1.Gm1 = 15.18; Form1.Qb1 = 50; Form1.Qm1 = 30; }
                if ((Form1.Qe2 >= 30) && (Form1.Qe2 < 50)) { Form1.Gb2 = 20.59; Form1.Gm2 = 15.18; Form1.Qb2 = 50; Form1.Qm2 = 30; }
                if ((Form1.Qe1 >= 50) && (Form1.Qe1 < 70)) { Form1.Gb1 = 25.21; Form1.Gm1 = 20.59; Form1.Qb1 = 70; Form1.Qm1 = 50; }
                if ((Form1.Qe2 >= 50) && (Form1.Qe2 < 70)) { Form1.Gb2 = 25.21; Form1.Gm2 = 20.59; Form1.Qb2 = 70; Form1.Qm2 = 50; }
                if ((Form1.Qe1 >= 70) && (Form1.Qe1 < 100)) { Form1.Gb1 = 31.30; Form1.Gm1 = 25.21; Form1.Qb1 = 100; Form1.Qm1 = 70; }
                if ((Form1.Qe2 >= 70) && (Form1.Qe2 < 100)) { Form1.Gb2 = 31.30; Form1.Gm2 = 25.21; Form1.Qb2 = 100; Form1.Qm2 = 70; }
                if ((Form1.Qe1 >= 100) && (Form1.Qe1 < 300)) { Form1.Gb1 = 61.47; Form1.Gm1 = 31.30; Form1.Qb1 = 300; Form1.Qm1 = 100; }
                if ((Form1.Qe2 >= 100) && (Form1.Qe2 < 300)) { Form1.Gb2 = 61.47; Form1.Gm2 = 31.30; Form1.Qb2 = 300; Form1.Qm2 = 100; }
                if ((Form1.Qe1 >= 300) && (Form1.Qe1 < 500)) { Form1.Gb1 = 84.5; Form1.Gm1 = 61.47; Form1.Qb1 = 500; Form1.Qm1 = 300; }
                if ((Form1.Qe2 >= 300) && (Form1.Qe2 < 500)) { Form1.Gb2 = 84.5; Form1.Gm2 = 61.47; Form1.Qb2 = 500; Form1.Qm2 = 300; }
                if ((Form1.Qe1 >= 500) && (Form1.Qe1 < 1000)) { Form1.Gb1 = 130; Form1.Gm1 = 84.5; Form1.Qb1 = 1000; Form1.Qm1 = 500; }
                if ((Form1.Qe2 >= 500) && (Form1.Qe2 < 1000)) { Form1.Gb2 = 130; Form1.Gm2 = 84.5; Form1.Qb2 = 1000; Form1.Qm2 = 500; }
            }
            if (Form1.v >= 4)
            {
                if ((Form1.Qe1 >= 0.01) && (Form1.Qe1 < 0.05)) { Form1.Gb1 = 0.42; Form1.Gm1 = 0.19; Form1.Qb1 = 0.05; Form1.Qm1 = 0.01; }
                if ((Form1.Qe2 >= 0.01) && (Form1.Qe2 < 0.05)) { Form1.Gb2 = 0.42; Form1.Gm2 = 0.19; Form1.Qb2 = 0.05; Form1.Qm2 = 0.01; }
                if ((Form1.Qe1 >= 0.05) && (Form1.Qe1 < 0.1)) { Form1.Gb1 = 0.59; Form1.Gm1 = 0.42; Form1.Qb1 = 0.1; Form1.Qm1 = 0.05; }
                if ((Form1.Qe2 >= 0.05) && (Form1.Qe2 < 0.1)) { Form1.Gb2 = 0.59; Form1.Gm2 = 0.42; Form1.Qb2 = 0.1; Form1.Qm2 = 0.05; }
                if ((Form1.Qe1 >= 0.1) && (Form1.Qe1 < 0.5)) { Form1.Gb1 = 1.33; Form1.Gm1 = 0.59; Form1.Qb1 = 0.5; Form1.Qm1 = 0.1; }
                if ((Form1.Qe2 >= 0.1) && (Form1.Qe2 < 0.5)) { Form1.Gb2 = 1.33; Form1.Gm2 = 0.59; Form1.Qb2 = 0.5; Form1.Qm2 = 0.1; }
                if ((Form1.Qe1 >= 0.5) && (Form1.Qe1 < 1)) { Form1.Gb1 = 1.88; Form1.Gm1 = 1.33; Form1.Qb1 = 1; Form1.Qm1 = 0.5; }
                if ((Form1.Qe2 >= 0.5) && (Form1.Qe2 < 1)) { Form1.Gb2 = 1.88; Form1.Gm2 = 1.33; Form1.Qb2 = 1; Form1.Qm2 = 0.5; }
                if ((Form1.Qe1 >= 1) && (Form1.Qe1 < 3)) { Form1.Gb1 = 3.28; Form1.Gm1 = 1.88; Form1.Qb1 = 3; Form1.Qm1 = 1; }
                if ((Form1.Qe2 >= 1) && (Form1.Qe2 < 3)) { Form1.Gb2 = 3.28; Form1.Gm2 = 1.88; Form1.Qb2 = 3; Form1.Qm2 = 1; }
                if ((Form1.Qe1 >= 3) && (Form1.Qe1 < 5)) { Form1.Gb1 = 4.36; Form1.Gm1 = 3.28; Form1.Qb1 = 5; Form1.Qm1 = 3; }
                if ((Form1.Qe2 >= 3) && (Form1.Qe2 < 5)) { Form1.Gb2 = 4.36; Form1.Gm2 = 3.28; Form1.Qb2 = 5; Form1.Qm2 = 3; }
                if ((Form1.Qe1 >= 5) && (Form1.Qe1 < 10)) { Form1.Gb1 = 6.46; Form1.Gm1 = 4.36; Form1.Qb1 = 10; Form1.Qm1 = 5; }
                if ((Form1.Qe2 >= 5) && (Form1.Qe2 < 10)) { Form1.Gb2 = 6.46; Form1.Gm2 = 4.36; Form1.Qb2 = 10; Form1.Qm2 = 5; }
                if ((Form1.Qe1 >= 10) && (Form1.Qe1 < 20)) { Form1.Gb1 = 9.62; Form1.Gm1 = 6.46; Form1.Qb1 = 20; Form1.Qm1 = 10; }
                if ((Form1.Qe2 >= 10) && (Form1.Qe2 < 20)) { Form1.Gb2 = 9.62; Form1.Gm2 = 6.46; Form1.Qb2 = 20; Form1.Qm2 = 10; }
                if ((Form1.Qe1 >= 20) && (Form1.Qe1 < 30)) { Form1.Gb1 = 12.18; Form1.Gm1 = 9.62; Form1.Qb1 = 30; Form1.Qm1 = 20; }
                if ((Form1.Qe2 >= 20) && (Form1.Qe2 < 30)) { Form1.Gb2 = 12.18; Form1.Gm2 = 9.62; Form1.Qb2 = 30; Form1.Qm2 = 20; }
                if ((Form1.Qe1 >= 30) && (Form1.Qe1 < 50)) { Form1.Gb1 = 16.43; Form1.Gm1 = 12.18; Form1.Qb1 = 50; Form1.Qm1 = 30; }
                if ((Form1.Qe2 >= 30) && (Form1.Qe2 < 50)) { Form1.Gb2 = 16.43; Form1.Gm2 = 12.18; Form1.Qb2 = 50; Form1.Qm2 = 30; }
                if ((Form1.Qe1 >= 50) && (Form1.Qe1 < 70)) { Form1.Gb1 = 20.05; Form1.Gm1 = 16.43; Form1.Qb1 = 70; Form1.Qm1 = 50; }
                if ((Form1.Qe2 >= 50) && (Form1.Qe2 < 70)) { Form1.Gb2 = 20.05; Form1.Gm2 = 16.43; Form1.Qb2 = 70; Form1.Qm2 = 50; }
                if ((Form1.Qe1 >= 70) && (Form1.Qe1 < 100)) { Form1.Gb1 = 24.80; Form1.Gm1 = 20.05; Form1.Qb1 = 100; Form1.Qm1 = 70; }
                if ((Form1.Qe2 >= 70) && (Form1.Qe2 < 100)) { Form1.Gb2 = 24.80; Form1.Gm2 = 20.05; Form1.Qb2 = 100; Form1.Qm2 = 70; }
                if ((Form1.Qe1 >= 100) && (Form1.Qe1 < 300)) { Form1.Gb1 = 48.16; Form1.Gm1 = 24.80; Form1.Qb1 = 300; Form1.Qm1 = 100; }
                if ((Form1.Qe2 >= 100) && (Form1.Qe2 < 300)) { Form1.Gb2 = 48.16; Form1.Gm2 = 24.80; Form1.Qb2 = 300; Form1.Qm2 = 100; }
                if ((Form1.Qe1 >= 300) && (Form1.Qe1 < 500)) { Form1.Gb1 = 65.92; Form1.Gm1 = 48.16; Form1.Qb1 = 500; Form1.Qm1 = 300; }
                if ((Form1.Qe2 >= 300) && (Form1.Qe2 < 500)) { Form1.Gb2 = 65.92; Form1.Gm2 = 48.16; Form1.Qb2 = 500; Form1.Qm2 = 300; }
                if ((Form1.Qe1 >= 500) && (Form1.Qe1 < 1000)) { Form1.Gb1 = 101; Form1.Gm1 = 65.92; Form1.Qb1 = 1000; Form1.Qm1 = 500; }
                if ((Form1.Qe2 >= 500) && (Form1.Qe2 < 1000)) { Form1.Gb2 = 101; Form1.Gm2 = 65.92; Form1.Qb2 = 1000; Form1.Qm2 = 500; }
            }
            if (Form1.v >= 5)
            {
                if ((Form1.Qe1 >= 0.01) && (Form1.Qe1 < 0.05)) { Form1.Gb1 = 0.38; Form1.Gm1 = 0.17; Form1.Qb1 = 0.05; Form1.Qm1 = 0.01; }
                if ((Form1.Qe2 >= 0.01) && (Form1.Qe2 < 0.05)) { Form1.Gb2 = 0.38; Form1.Gm2 = 0.17; Form1.Qb2 = 0.05; Form1.Qm2 = 0.01; }
                if ((Form1.Qe1 >= 0.05) && (Form1.Qe1 < 0.1)) { Form1.Gb1 = 0.53; Form1.Gm1 = 0.38; Form1.Qb1 = 0.1; Form1.Qm1 = 0.05; }
                if ((Form1.Qe2 >= 0.05) && (Form1.Qe2 < 0.1)) { Form1.Gb2 = 0.53; Form1.Gm2 = 0.38; Form1.Qb2 = 0.1; Form1.Qm2 = 0.05; }
                if ((Form1.Qe1 >= 0.1) && (Form1.Qe1 < 0.5)) { Form1.Gb1 = 1.19; Form1.Gm1 = 0.53; Form1.Qb1 = 0.5; Form1.Qm1 = 0.1; }
                if ((Form1.Qe2 >= 0.1) && (Form1.Qe2 < 0.5)) { Form1.Gb2 = 1.19; Form1.Gm2 = 0.53; Form1.Qb2 = 0.5; Form1.Qm2 = 0.1; }
                if ((Form1.Qe1 >= 0.5) && (Form1.Qe1 < 1)) { Form1.Gb1 = 1.68; Form1.Gm1 = 1.19; Form1.Qb1 = 1; Form1.Qm1 = 0.5; }
                if ((Form1.Qe2 >= 0.5) && (Form1.Qe2 < 1)) { Form1.Gb2 = 1.68; Form1.Gm2 = 1.19; Form1.Qb2 = 1; Form1.Qm2 = 0.5; }
                if ((Form1.Qe1 >= 1) && (Form1.Qe1 < 3)) { Form1.Gb1 = 2.91; Form1.Gm1 = 1.68; Form1.Qb1 = 3; Form1.Qm1 = 1; }
                if ((Form1.Qe2 >= 1) && (Form1.Qe2 < 3)) { Form1.Gb2 = 2.91; Form1.Gm2 = 1.68; Form1.Qb2 = 3; Form1.Qm2 = 1; }
                if ((Form1.Qe1 >= 3) && (Form1.Qe1 < 5)) { Form1.Gb1 = 3.75; Form1.Gm1 = 2.91; Form1.Qb1 = 5; Form1.Qm1 = 3; }
                if ((Form1.Qe2 >= 3) && (Form1.Qe2 < 5)) { Form1.Gb2 = 3.75; Form1.Gm2 = 2.91; Form1.Qb2 = 5; Form1.Qm2 = 3; }
                if ((Form1.Qe1 >= 5) && (Form1.Qe1 < 10)) { Form1.Gb1 = 5.53; Form1.Gm1 = 3.75; Form1.Qb1 = 10; Form1.Qm1 = 5; }
                if ((Form1.Qe2 >= 5) && (Form1.Qe2 < 10)) { Form1.Gb2 = 5.53; Form1.Gm2 = 3.75; Form1.Qb2 = 10; Form1.Qm2 = 5; }
                if ((Form1.Qe1 >= 10) && (Form1.Qe1 < 20)) { Form1.Gb1 = 8.19; Form1.Gm1 = 5.53; Form1.Qb1 = 20; Form1.Qm1 = 10; }
                if ((Form1.Qe2 >= 10) && (Form1.Qe2 < 20)) { Form1.Gb2 = 8.19; Form1.Gm2 = 5.53; Form1.Qb2 = 20; Form1.Qm2 = 10; }
                if ((Form1.Qe1 >= 20) && (Form1.Qe1 < 30)) { Form1.Gb1 = 10.33; Form1.Gm1 = 8.19; Form1.Qb1 = 30; Form1.Qm1 = 20; }
                if ((Form1.Qe2 >= 20) && (Form1.Qe2 < 30)) { Form1.Gb2 = 10.33; Form1.Gm2 = 8.19; Form1.Qb2 = 30; Form1.Qm2 = 20; }
                if ((Form1.Qe1 >= 30) && (Form1.Qe1 < 50)) { Form1.Gb1 = 13.68; Form1.Gm1 = 10.33; Form1.Qb1 = 50; Form1.Qm1 = 30; }
                if ((Form1.Qe2 >= 30) && (Form1.Qe2 < 50)) { Form1.Gb2 = 13.68; Form1.Gm2 = 10.33; Form1.Qb2 = 50; Form1.Qm2 = 30; }
                if ((Form1.Qe1 >= 50) && (Form1.Qe1 < 70)) { Form1.Gb1 = 16.89; Form1.Gm1 = 13.68; Form1.Qb1 = 70; Form1.Qm1 = 50; }
                if ((Form1.Qe2 >= 50) && (Form1.Qe2 < 70)) { Form1.Gb2 = 16.89; Form1.Gm2 = 13.68; Form1.Qb2 = 70; Form1.Qm2 = 50; }
                if ((Form1.Qe1 >= 70) && (Form1.Qe1 < 100)) { Form1.Gb1 = 20.82; Form1.Gm1 = 16.89; Form1.Qb1 = 100; Form1.Qm1 = 70; }
                if ((Form1.Qe2 >= 70) && (Form1.Qe2 < 100)) { Form1.Gb2 = 20.82; Form1.Gm2 = 16.89; Form1.Qb2 = 100; Form1.Qm2 = 70; }
                if ((Form1.Qe1 >= 100) && (Form1.Qe1 < 300)) { Form1.Gb1 = 40.11; Form1.Gm1 = 20.82; Form1.Qb1 = 300; Form1.Qm1 = 100; }
                if ((Form1.Qe2 >= 100) && (Form1.Qe2 < 300)) { Form1.Gb2 = 40.11; Form1.Gm2 = 20.82; Form1.Qb2 = 300; Form1.Qm2 = 100; }
                if ((Form1.Qe1 >= 300) && (Form1.Qe1 < 500)) { Form1.Gb1 = 54.67; Form1.Gm1 = 40.11; Form1.Qb1 = 500; Form1.Qm1 = 300; }
                if ((Form1.Qe2 >= 300) && (Form1.Qe2 < 500)) { Form1.Gb2 = 54.67; Form1.Gm2 = 40.11; Form1.Qb2 = 500; Form1.Qm2 = 300; }
                if ((Form1.Qe1 >= 500) && (Form1.Qe1 < 1000)) { Form1.Gb1 = 83.6; Form1.Gm1 = 54.67; Form1.Qb1 = 1000; Form1.Qm1 = 500; }
                if ((Form1.Qe2 >= 500) && (Form1.Qe2 < 1000)) { Form1.Gb2 = 83.6; Form1.Gm2 = 54.67; Form1.Qb2 = 1000; Form1.Qm2 = 500; }
            }
            if (Form1.v >= 6)
            {
                if ((Form1.Qe1 >= 0.01) && (Form1.Qe1 < 0.05)) { Form1.Gb1 = 0.34; Form1.Gm1 = 0.15; Form1.Qb1 = 0.05; Form1.Qm1 = 0.01; }
                if ((Form1.Qe2 >= 0.01) && (Form1.Qe2 < 0.05)) { Form1.Gb2 = 0.34; Form1.Gm2 = 0.15; Form1.Qb2 = 0.05; Form1.Qm2 = 0.01; }
                if ((Form1.Qe1 >= 0.05) && (Form1.Qe1 < 0.1)) { Form1.Gb1 = 0.48; Form1.Gm1 = 0.34; Form1.Qb1 = 0.1; Form1.Qm1 = 0.05; }
                if ((Form1.Qe2 >= 0.05) && (Form1.Qe2 < 0.1)) { Form1.Gb2 = 0.48; Form1.Gm2 = 0.34; Form1.Qb2 = 0.1; Form1.Qm2 = 0.05; }
                if ((Form1.Qe1 >= 0.1) && (Form1.Qe1 < 0.5)) { Form1.Gb1 = 1.09; Form1.Gm1 = 0.48; Form1.Qb1 = 0.5; Form1.Qm1 = 0.1; }
                if ((Form1.Qe2 >= 0.1) && (Form1.Qe2 < 0.5)) { Form1.Gb2 = 1.09; Form1.Gm2 = 0.48; Form1.Qb2 = 0.5; Form1.Qm2 = 0.1; }
                if ((Form1.Qe1 >= 0.5) && (Form1.Qe1 < 1)) { Form1.Gb1 = 1.53; Form1.Gm1 = 1.09; Form1.Qb1 = 1; Form1.Qm1 = 0.5; }
                if ((Form1.Qe2 >= 0.5) && (Form1.Qe2 < 1)) { Form1.Gb2 = 1.53; Form1.Gm2 = 1.09; Form1.Qb2 = 1; Form1.Qm2 = 0.5; }
                if ((Form1.Qe1 >= 1) && (Form1.Qe1 < 3)) { Form1.Gb1 = 2.66; Form1.Gm1 = 1.53; Form1.Qb1 = 3; Form1.Qm1 = 1; }
                if ((Form1.Qe2 >= 1) && (Form1.Qe2 < 3)) { Form1.Gb2 = 2.66; Form1.Gm2 = 1.53; Form1.Qb2 = 3; Form1.Qm2 = 1; }
                if ((Form1.Qe1 >= 3) && (Form1.Qe1 < 5)) { Form1.Gb1 = 3.43; Form1.Gm1 = 2.66; Form1.Qb1 = 5; Form1.Qm1 = 3; }
                if ((Form1.Qe2 >= 3) && (Form1.Qe2 < 5)) { Form1.Gb2 = 3.43; Form1.Gm2 = 2.66; Form1.Qb2 = 5; Form1.Qm2 = 3; }
                if ((Form1.Qe1 >= 5) && (Form1.Qe1 < 10)) { Form1.Gb1 = 4.88; Form1.Gm1 = 3.43; Form1.Qb1 = 10; Form1.Qm1 = 5; }
                if ((Form1.Qe2 >= 5) && (Form1.Qe2 < 10)) { Form1.Gb2 = 4.88; Form1.Gm2 = 3.43; Form1.Qb2 = 10; Form1.Qm2 = 5; }
                if ((Form1.Qe1 >= 10) && (Form1.Qe1 < 20)) { Form1.Gb1 = 7.20; Form1.Gm1 = 4.88; Form1.Qb1 = 20; Form1.Qm1 = 10; }
                if ((Form1.Qe2 >= 10) && (Form1.Qe2 < 20)) { Form1.Gb2 = 7.20; Form1.Gm2 = 4.88; Form1.Qb2 = 20; Form1.Qm2 = 10; }
                if ((Form1.Qe1 >= 20) && (Form1.Qe1 < 30)) { Form1.Gb1 = 9.06; Form1.Gm1 = 7.20; Form1.Qb1 = 30; Form1.Qm1 = 20; }
                if ((Form1.Qe2 >= 20) && (Form1.Qe2 < 30)) { Form1.Gb2 = 9.06; Form1.Gm2 = 7.20; Form1.Qb2 = 30; Form1.Qm2 = 20; }
                if ((Form1.Qe1 >= 30) && (Form1.Qe1 < 50)) { Form1.Gb1 = 12.14; Form1.Gm1 = 9.06; Form1.Qb1 = 50; Form1.Qm1 = 30; }
                if ((Form1.Qe2 >= 30) && (Form1.Qe2 < 50)) { Form1.Gb2 = 12.14; Form1.Gm2 = 9.06; Form1.Qb2 = 50; Form1.Qm2 = 30; }
                if ((Form1.Qe1 >= 50) && (Form1.Qe1 < 70)) { Form1.Gb1 = 14.79; Form1.Gm1 = 12.14; Form1.Qb1 = 70; Form1.Qm1 = 50; }
                if ((Form1.Qe2 >= 50) && (Form1.Qe2 < 70)) { Form1.Gb2 = 14.79; Form1.Gm2 = 12.14; Form1.Qb2 = 70; Form1.Qm2 = 50; }
                if ((Form1.Qe1 >= 70) && (Form1.Qe1 < 100)) { Form1.Gb1 = 18.13; Form1.Gm1 = 14.79; Form1.Qb1 = 100; Form1.Qm1 = 70; }
                if ((Form1.Qe2 >= 70) && (Form1.Qe2 < 100)) { Form1.Gb2 = 18.13; Form1.Gm2 = 14.79; Form1.Qb2 = 100; Form1.Qm2 = 70; }
                if ((Form1.Qe1 >= 100) && (Form1.Qe1 < 300)) { Form1.Gb1 = 34.67; Form1.Gm1 = 18.13; Form1.Qb1 = 300; Form1.Qm1 = 100; }
                if ((Form1.Qe2 >= 100) && (Form1.Qe2 < 300)) { Form1.Gb2 = 34.67; Form1.Gm2 = 18.13; Form1.Qb2 = 300; Form1.Qm2 = 100; }
                if ((Form1.Qe1 >= 300) && (Form1.Qe1 < 500)) { Form1.Gb1 = 47.09; Form1.Gm1 = 34.67; Form1.Qb1 = 500; Form1.Qm1 = 300; }
                if ((Form1.Qe2 >= 300) && (Form1.Qe2 < 500)) { Form1.Gb2 = 47.09; Form1.Gm2 = 34.67; Form1.Qb2 = 500; Form1.Qm2 = 300; }
                if ((Form1.Qe1 >= 500) && (Form1.Qe1 < 1000)) { Form1.Gb1 = 71.7; Form1.Gm1 = 47.09; Form1.Qb1 = 1000; Form1.Qm1 = 500; }
                if ((Form1.Qe2 >= 500) && (Form1.Qe2 < 1000)) { Form1.Gb2 = 71.7; Form1.Gm2 = 47.09; Form1.Qb2 = 1000; Form1.Qm2 = 500; }
            }
            if (Form1.v >= 7)
            {
                if ((Form1.Qe1 >= 0.01) && (Form1.Qe1 < 0.05)) { Form1.Gb1 = 0.32; Form1.Gm1 = 0.14; Form1.Qb1 = 0.05; Form1.Qm1 = 0.01; }
                if ((Form1.Qe2 >= 0.01) && (Form1.Qe2 < 0.05)) { Form1.Gb2 = 0.32; Form1.Gm2 = 0.14; Form1.Qb2 = 0.05; Form1.Qm2 = 0.01; }
                if ((Form1.Qe1 >= 0.05) && (Form1.Qe1 < 0.1)) { Form1.Gb1 = 0.45; Form1.Gm1 = 0.32; Form1.Qb1 = 0.1; Form1.Qm1 = 0.05; }
                if ((Form1.Qe2 >= 0.05) && (Form1.Qe2 < 0.1)) { Form1.Gb2 = 0.45; Form1.Gm2 = 0.32; Form1.Qb2 = 0.1; Form1.Qm2 = 0.05; }
                if ((Form1.Qe1 >= 0.1) && (Form1.Qe1 < 0.5)) { Form1.Gb1 = 1.0; Form1.Gm1 = 0.45; Form1.Qb1 = 0.5; Form1.Qm1 = 0.1; }
                if ((Form1.Qe2 >= 0.1) && (Form1.Qe2 < 0.5)) { Form1.Gb2 = 1.0; Form1.Gm2 = 0.45; Form1.Qb2 = 0.5; Form1.Qm2 = 0.1; }
                if ((Form1.Qe1 >= 0.5) && (Form1.Qe1 < 1)) { Form1.Gb1 = 1.42; Form1.Gm1 = 1.0; Form1.Qb1 = 1; Form1.Qm1 = 0.5; }
                if ((Form1.Qe2 >= 0.5) && (Form1.Qe2 < 1)) { Form1.Gb2 = 1.42; Form1.Gm2 = 1.0; Form1.Qb2 = 1; Form1.Qm2 = 0.5; }
                if ((Form1.Qe1 >= 1) && (Form1.Qe1 < 3)) { Form1.Gb1 = 2.46; Form1.Gm1 = 1.42; Form1.Qb1 = 3; Form1.Qm1 = 1; }
                if ((Form1.Qe2 >= 1) && (Form1.Qe2 < 3)) { Form1.Gb2 = 2.46; Form1.Gm2 = 1.42; Form1.Qb2 = 3; Form1.Qm2 = 1; }
                if ((Form1.Qe1 >= 3) && (Form1.Qe1 < 5)) { Form1.Gb1 = 3.17; Form1.Gm1 = 2.46; Form1.Qb1 = 5; Form1.Qm1 = 3; }
                if ((Form1.Qe2 >= 3) && (Form1.Qe2 < 5)) { Form1.Gb2 = 3.17; Form1.Gm2 = 2.46; Form1.Qb2 = 5; Form1.Qm2 = 3; }
                if ((Form1.Qe1 >= 5) && (Form1.Qe1 < 10)) { Form1.Gb1 = 4.49; Form1.Gm1 = 3.17; Form1.Qb1 = 10; Form1.Qm1 = 5; }
                if ((Form1.Qe2 >= 5) && (Form1.Qe2 < 10)) { Form1.Gb2 = 4.49; Form1.Gm2 = 3.17; Form1.Qb2 = 10; Form1.Qm2 = 5; }
                if ((Form1.Qe1 >= 10) && (Form1.Qe1 < 20)) { Form1.Gb1 = 6.48; Form1.Gm1 = 4.49; Form1.Qb1 = 20; Form1.Qm1 = 10; }
                if ((Form1.Qe2 >= 10) && (Form1.Qe2 < 20)) { Form1.Gb2 = 6.48; Form1.Gm2 = 4.49; Form1.Qb2 = 20; Form1.Qm2 = 10; }
                if ((Form1.Qe1 >= 20) && (Form1.Qe1 < 30)) { Form1.Gb1 = 8.14; Form1.Gm1 = 6.48; Form1.Qb1 = 30; Form1.Qm1 = 20; }
                if ((Form1.Qe2 >= 20) && (Form1.Qe2 < 30)) { Form1.Gb2 = 8.14; Form1.Gm2 = 6.48; Form1.Qb2 = 30; Form1.Qm2 = 20; }
                if ((Form1.Qe1 >= 30) && (Form1.Qe1 < 50)) { Form1.Gb1 = 10.87; Form1.Gm1 = 8.14; Form1.Qb1 = 50; Form1.Qm1 = 30; }
                if ((Form1.Qe2 >= 30) && (Form1.Qe2 < 50)) { Form1.Gb2 = 10.87; Form1.Gm2 = 8.14; Form1.Qb2 = 50; Form1.Qm2 = 30; }
                if ((Form1.Qe1 >= 50) && (Form1.Qe1 < 70)) { Form1.Gb1 = 13.17; Form1.Gm1 = 10.87; Form1.Qb1 = 70; Form1.Qm1 = 50; }
                if ((Form1.Qe2 >= 50) && (Form1.Qe2 < 70)) { Form1.Gb2 = 13.17; Form1.Gm2 = 10.87; Form1.Qb2 = 70; Form1.Qm2 = 50; }
                if ((Form1.Qe1 >= 70) && (Form1.Qe1 < 100)) { Form1.Gb1 = 16.17; Form1.Gm1 = 13.17; Form1.Qb1 = 100; Form1.Qm1 = 70; }
                if ((Form1.Qe2 >= 70) && (Form1.Qe2 < 100)) { Form1.Gb2 = 16.17; Form1.Gm2 = 13.17; Form1.Qb2 = 100; Form1.Qm2 = 70; }
                if ((Form1.Qe1 >= 100) && (Form1.Qe1 < 300)) { Form1.Gb1 = 30.73; Form1.Gm1 = 16.17; Form1.Qb1 = 300; Form1.Qm1 = 100; }
                if ((Form1.Qe2 >= 100) && (Form1.Qe2 < 300)) { Form1.Gb2 = 30.73; Form1.Gm2 = 16.17; Form1.Qb2 = 300; Form1.Qm2 = 100; }
                if ((Form1.Qe1 >= 300) && (Form1.Qe1 < 500)) { Form1.Gb1 = 41.63; Form1.Gm1 = 30.73; Form1.Qb1 = 500; Form1.Qm1 = 300; }
                if ((Form1.Qe2 >= 300) && (Form1.Qe2 < 500)) { Form1.Gb2 = 41.63; Form1.Gm2 = 30.73; Form1.Qb2 = 500; Form1.Qm2 = 300; }
                if ((Form1.Qe1 >= 500) && (Form1.Qe1 < 1000)) { Form1.Gb1 = 63.16; Form1.Gm1 = 41.63; Form1.Qb1 = 1000; Form1.Qm1 = 500; }
                if ((Form1.Qe2 >= 500) && (Form1.Qe2 < 1000)) { Form1.Gb2 = 63.16; Form1.Gm2 = 41.63; Form1.Qb2 = 1000; Form1.Qm2 = 500; }
            }
            if (Form1.v >= 8)
            {
                if ((Form1.Qe1 >= 0.01) && (Form1.Qe1 < 0.05)) { Form1.Gb1 = 0.30; Form1.Gm1 = 0.13; Form1.Qb1 = 0.05; Form1.Qm1 = 0.01; }
                if ((Form1.Qe2 >= 0.01) && (Form1.Qe2 < 0.05)) { Form1.Gb2 = 0.30; Form1.Gm2 = 0.13; Form1.Qb2 = 0.05; Form1.Qm2 = 0.01; }
                if ((Form1.Qe1 >= 0.05) && (Form1.Qe1 < 0.1)) { Form1.Gb1 = 0.42; Form1.Gm1 = 0.30; Form1.Qb1 = 0.1; Form1.Qm1 = 0.05; }
                if ((Form1.Qe2 >= 0.05) && (Form1.Qe2 < 0.1)) { Form1.Gb2 = 0.42; Form1.Gm2 = 0.30; Form1.Qb2 = 0.1; Form1.Qm2 = 0.05; }
                if ((Form1.Qe1 >= 0.1) && (Form1.Qe1 < 0.5)) { Form1.Gb1 = 0.94; Form1.Gm1 = 0.42; Form1.Qb1 = 0.5; Form1.Qm1 = 0.1; }
                if ((Form1.Qe2 >= 0.1) && (Form1.Qe2 < 0.5)) { Form1.Gb2 = 0.94; Form1.Gm2 = 0.42; Form1.Qb2 = 0.5; Form1.Qm2 = 0.1; }
                if ((Form1.Qe1 >= 0.5) && (Form1.Qe1 < 1)) { Form1.Gb1 = 1.33; Form1.Gm1 = 0.94; Form1.Qb1 = 1; Form1.Qm1 = 0.5; }
                if ((Form1.Qe2 >= 0.5) && (Form1.Qe2 < 1)) { Form1.Gb2 = 1.33; Form1.Gm2 = 0.94; Form1.Qb2 = 1; Form1.Qm2 = 0.5; }
                if ((Form1.Qe1 >= 1) && (Form1.Qe1 < 3)) { Form1.Gb1 = 2.3; Form1.Gm1 = 1.33; Form1.Qb1 = 3; Form1.Qm1 = 1; }
                if ((Form1.Qe2 >= 1) && (Form1.Qe2 < 3)) { Form1.Gb2 = 2.3; Form1.Gm2 = 1.33; Form1.Qb2 = 3; Form1.Qm2 = 1; }
                if ((Form1.Qe1 >= 3) && (Form1.Qe1 < 5)) { Form1.Gb1 = 2.97; Form1.Gm1 = 2.3; Form1.Qb1 = 5; Form1.Qm1 = 3; }
                if ((Form1.Qe2 >= 3) && (Form1.Qe2 < 5)) { Form1.Gb2 = 2.97; Form1.Gm2 = 2.3; Form1.Qb2 = 5; Form1.Qm2 = 3; }
                if ((Form1.Qe1 >= 5) && (Form1.Qe1 < 10)) { Form1.Gb1 = 4.2; Form1.Gm1 = 2.97; Form1.Qb1 = 10; Form1.Qm1 = 5; }
                if ((Form1.Qe2 >= 5) && (Form1.Qe2 < 10)) { Form1.Gb2 = 4.2; Form1.Gm2 = 2.97; Form1.Qb2 = 10; Form1.Qm2 = 5; }
                if ((Form1.Qe1 >= 10) && (Form1.Qe1 < 20)) { Form1.Gb1 = 5.92; Form1.Gm1 = 4.2; Form1.Qb1 = 20; Form1.Qm1 = 10; }
                if ((Form1.Qe2 >= 10) && (Form1.Qe2 < 20)) { Form1.Gb2 = 5.92; Form1.Gm2 = 4.2; Form1.Qb2 = 20; Form1.Qm2 = 10; }
                if ((Form1.Qe1 >= 20) && (Form1.Qe1 < 30)) { Form1.Gb1 = 7.42; Form1.Gm1 = 5.92; Form1.Qb1 = 30; Form1.Qm1 = 20; }
                if ((Form1.Qe2 >= 20) && (Form1.Qe2 < 30)) { Form1.Gb2 = 7.42; Form1.Gm2 = 5.92; Form1.Qb2 = 30; Form1.Qm2 = 20; }
                if ((Form1.Qe1 >= 30) && (Form1.Qe1 < 50)) { Form1.Gb1 = 9.9; Form1.Gm1 = 7.42; Form1.Qb1 = 50; Form1.Qm1 = 30; }
                if ((Form1.Qe2 >= 30) && (Form1.Qe2 < 50)) { Form1.Gb2 = 9.9; Form1.Gm2 = 7.42; Form1.Qb2 = 50; Form1.Qm2 = 30; }
                if ((Form1.Qe1 >= 50) && (Form1.Qe1 < 70)) { Form1.Gb1 = 11.98; Form1.Gm1 = 9.9; Form1.Qb1 = 70; Form1.Qm1 = 50; }
                if ((Form1.Qe2 >= 50) && (Form1.Qe2 < 70)) { Form1.Gb2 = 11.98; Form1.Gm2 = 9.9; Form1.Qb2 = 70; Form1.Qm2 = 50; }
                if ((Form1.Qe1 >= 70) && (Form1.Qe1 < 100)) { Form1.Gb1 = 14.68; Form1.Gm1 = 11.98; Form1.Qb1 = 100; Form1.Qm1 = 70; }
                if ((Form1.Qe2 >= 70) && (Form1.Qe2 < 100)) { Form1.Gb2 = 14.68; Form1.Gm2 = 11.98; Form1.Qb2 = 100; Form1.Qm2 = 70; }
                if ((Form1.Qe1 >= 100) && (Form1.Qe1 < 300)) { Form1.Gb1 = 27.75; Form1.Gm1 = 14.68; Form1.Qb1 = 300; Form1.Qm1 = 100; }
                if ((Form1.Qe2 >= 100) && (Form1.Qe2 < 300)) { Form1.Gb2 = 27.75; Form1.Gm2 = 14.68; Form1.Qb2 = 300; Form1.Qm2 = 100; }
                if ((Form1.Qe1 >= 300) && (Form1.Qe1 < 500)) { Form1.Gb1 = 37.49; Form1.Gm1 = 27.75; Form1.Qb1 = 500; Form1.Qm1 = 300; }
                if ((Form1.Qe2 >= 300) && (Form1.Qe2 < 500)) { Form1.Gb2 = 37.49; Form1.Gm2 = 27.75; Form1.Qb2 = 500; Form1.Qm2 = 300; }
                if ((Form1.Qe1 >= 500) && (Form1.Qe1 < 1000)) { Form1.Gb1 = 56.7; Form1.Gm1 = 37.49; Form1.Qb1 = 1000; Form1.Qm1 = 500; }
                if ((Form1.Qe2 >= 500) && (Form1.Qe2 < 1000)) { Form1.Gb2 = 56.7; Form1.Gm2 = 37.49; Form1.Qb2 = 1000; Form1.Qm2 = 500; }
            }
            if (Form1.v >= 9)
            {
                if ((Form1.Qe1 >= 0.01) && (Form1.Qe1 < 0.05)) { Form1.Gb1 = 0.28; Form1.Gm1 = 0.12; Form1.Qb1 = 0.05; Form1.Qm1 = 0.01; }
                if ((Form1.Qe2 >= 0.01) && (Form1.Qe2 < 0.05)) { Form1.Gb2 = 0.28; Form1.Gm2 = 0.12; Form1.Qb2 = 0.05; Form1.Qm2 = 0.01; }
                if ((Form1.Qe1 >= 0.05) && (Form1.Qe1 < 0.1)) { Form1.Gb1 = 0.40; Form1.Gm1 = 0.28; Form1.Qb1 = 0.1; Form1.Qm1 = 0.05; }
                if ((Form1.Qe2 >= 0.05) && (Form1.Qe2 < 0.1)) { Form1.Gb2 = 0.40; Form1.Gm2 = 0.28; Form1.Qb2 = 0.1; Form1.Qm2 = 0.05; }
                if ((Form1.Qe1 >= 0.1) && (Form1.Qe1 < 0.5)) { Form1.Gb1 = 0.88; Form1.Gm1 = 0.40; Form1.Qb1 = 0.5; Form1.Qm1 = 0.1; }
                if ((Form1.Qe2 >= 0.1) && (Form1.Qe2 < 0.5)) { Form1.Gb2 = 0.88; Form1.Gm2 = 0.40; Form1.Qb2 = 0.5; Form1.Qm2 = 0.1; }
                if ((Form1.Qe1 >= 0.5) && (Form1.Qe1 < 1)) { Form1.Gb1 = 1.25; Form1.Gm1 = 0.88; Form1.Qb1 = 1; Form1.Qm1 = 0.5; }
                if ((Form1.Qe2 >= 0.5) && (Form1.Qe2 < 1)) { Form1.Gb2 = 1.25; Form1.Gm2 = 0.88; Form1.Qb2 = 1; Form1.Qm2 = 0.5; }
                if ((Form1.Qe1 >= 1) && (Form1.Qe1 < 3)) { Form1.Gb1 = 2.17; Form1.Gm1 = 1.25; Form1.Qb1 = 3; Form1.Qm1 = 1; }
                if ((Form1.Qe2 >= 1) && (Form1.Qe2 < 3)) { Form1.Gb2 = 2.17; Form1.Gm2 = 1.25; Form1.Qb2 = 3; Form1.Qm2 = 1; }
                if ((Form1.Qe1 >= 3) && (Form1.Qe1 < 5)) { Form1.Gb1 = 2.8; Form1.Gm1 = 2.17; Form1.Qb1 = 5; Form1.Qm1 = 3; }
                if ((Form1.Qe2 >= 3) && (Form1.Qe2 < 5)) { Form1.Gb2 = 2.8; Form1.Gm2 = 2.17; Form1.Qb2 = 5; Form1.Qm2 = 3; }
                if ((Form1.Qe1 >= 5) && (Form1.Qe1 < 10)) { Form1.Gb1 = 3.96; Form1.Gm1 = 2.8; Form1.Qb1 = 10; Form1.Qm1 = 5; }
                if ((Form1.Qe2 >= 5) && (Form1.Qe2 < 10)) { Form1.Gb2 = 3.96; Form1.Gm2 = 2.8; Form1.Qb2 = 10; Form1.Qm2 = 5; }
                if ((Form1.Qe1 >= 10) && (Form1.Qe1 < 20)) { Form1.Gb1 = 5.60; Form1.Gm1 = 3.96; Form1.Qb1 = 20; Form1.Qm1 = 10; }
                if ((Form1.Qe2 >= 10) && (Form1.Qe2 < 20)) { Form1.Gb2 = 5.60; Form1.Gm2 = 3.96; Form1.Qb2 = 20; Form1.Qm2 = 10; }
                if ((Form1.Qe1 >= 20) && (Form1.Qe1 < 30)) { Form1.Gb1 = 6.86; Form1.Gm1 = 5.60; Form1.Qb1 = 30; Form1.Qm1 = 20; }
                if ((Form1.Qe2 >= 20) && (Form1.Qe2 < 30)) { Form1.Gb2 = 6.86; Form1.Gm2 = 5.60; Form1.Qb2 = 30; Form1.Qm2 = 20; }
                if ((Form1.Qe1 >= 30) && (Form1.Qe1 < 50)) { Form1.Gb1 = 9.12; Form1.Gm1 = 6.86; Form1.Qb1 = 50; Form1.Qm1 = 30; }
                if ((Form1.Qe2 >= 30) && (Form1.Qe2 < 50)) { Form1.Gb2 = 9.12; Form1.Gm2 = 6.86; Form1.Qb2 = 50; Form1.Qm2 = 30; }
                if ((Form1.Qe1 >= 50) && (Form1.Qe1 < 70)) { Form1.Gb1 = 11.03; Form1.Gm1 = 9.12; Form1.Qb1 = 70; Form1.Qm1 = 50; }
                if ((Form1.Qe2 >= 50) && (Form1.Qe2 < 70)) { Form1.Gb2 = 11.03; Form1.Gm2 = 9.12; Form1.Qb2 = 70; Form1.Qm2 = 50; }
                if ((Form1.Qe1 >= 70) && (Form1.Qe1 < 100)) { Form1.Gb1 = 13.5; Form1.Gm1 = 11.03; Form1.Qb1 = 100; Form1.Qm1 = 70; }
                if ((Form1.Qe2 >= 70) && (Form1.Qe2 < 100)) { Form1.Gb2 = 13.5; Form1.Gm2 = 11.03; Form1.Qb2 = 100; Form1.Qm2 = 70; }
                if ((Form1.Qe1 >= 100) && (Form1.Qe1 < 300)) { Form1.Gb1 = 25.39; Form1.Gm1 = 13.5; Form1.Qb1 = 300; Form1.Qm1 = 100; }
                if ((Form1.Qe2 >= 100) && (Form1.Qe2 < 300)) { Form1.Gb2 = 25.39; Form1.Gm2 = 13.5; Form1.Qb2 = 300; Form1.Qm2 = 100; }
                if ((Form1.Qe1 >= 300) && (Form1.Qe1 < 500)) { Form1.Gb1 = 34.24; Form1.Gm1 = 25.39; Form1.Qb1 = 500; Form1.Qm1 = 300; }
                if ((Form1.Qe2 >= 300) && (Form1.Qe2 < 500)) { Form1.Gb2 = 34.24; Form1.Gm2 = 25.39; Form1.Qb2 = 500; Form1.Qm2 = 300; }
                if ((Form1.Qe1 >= 500) && (Form1.Qe1 < 1000)) { Form1.Gb1 = 51.6; Form1.Gm1 = 34.24; Form1.Qb1 = 1000; Form1.Qm1 = 500; }
                if ((Form1.Qe2 >= 500) && (Form1.Qe2 < 1000)) { Form1.Gb2 = 51.6; Form1.Gm2 = 34.24; Form1.Qb2 = 1000; Form1.Qm2 = 500; }
            }
            if (Form1.v >= 10)
            {
                if ((Form1.Qe1 >= 0.01) && (Form1.Qe1 < 0.05)) { Form1.Gb1 = 0.26; Form1.Gm1 = 0.12; Form1.Qb1 = 0.05; Form1.Qm1 = 0.01; }
                if ((Form1.Qe2 >= 0.01) && (Form1.Qe2 < 0.05)) { Form1.Gb2 = 0.26; Form1.Gm2 = 0.12; Form1.Qb2 = 0.05; Form1.Qm2 = 0.01; }
                if ((Form1.Qe1 >= 0.05) && (Form1.Qe1 < 0.1)) { Form1.Gb1 = 0.38; Form1.Gm1 = 0.26; Form1.Qb1 = 0.1; Form1.Qm1 = 0.05; }
                if ((Form1.Qe2 >= 0.05) && (Form1.Qe2 < 0.1)) { Form1.Gb2 = 0.38; Form1.Gm2 = 0.26; Form1.Qb2 = 0.1; Form1.Qm2 = 0.05; }
                if ((Form1.Qe1 >= 0.1) && (Form1.Qe1 < 0.5)) { Form1.Gb1 = 0.84; Form1.Gm1 = 0.38; Form1.Qb1 = 0.5; Form1.Qm1 = 0.1; }
                if ((Form1.Qe2 >= 0.1) && (Form1.Qe2 < 0.5)) { Form1.Gb2 = 0.84; Form1.Gm2 = 0.38; Form1.Qb2 = 0.5; Form1.Qm2 = 0.1; }
                if ((Form1.Qe1 >= 0.5) && (Form1.Qe1 < 1)) { Form1.Gb1 = 1.19; Form1.Gm1 = 0.84; Form1.Qb1 = 1; Form1.Qm1 = 0.5; }
                if ((Form1.Qe2 >= 0.5) && (Form1.Qe2 < 1)) { Form1.Gb2 = 1.19; Form1.Gm2 = 0.84; Form1.Qb2 = 1; Form1.Qm2 = 0.5; }
                if ((Form1.Qe1 >= 1) && (Form1.Qe1 < 3)) { Form1.Gb1 = 2.06; Form1.Gm1 = 1.19; Form1.Qb1 = 3; Form1.Qm1 = 1; }
                if ((Form1.Qe2 >= 1) && (Form1.Qe2 < 3)) { Form1.Gb2 = 2.06; Form1.Gm2 = 1.19; Form1.Qb2 = 3; Form1.Qm2 = 1; }
                if ((Form1.Qe1 >= 3) && (Form1.Qe1 < 5)) { Form1.Gb1 = 2.66; Form1.Gm1 = 2.06; Form1.Qb1 = 5; Form1.Qm1 = 3; }
                if ((Form1.Qe2 >= 3) && (Form1.Qe2 < 5)) { Form1.Gb2 = 2.66; Form1.Gm2 = 2.06; Form1.Qb2 = 5; Form1.Qm2 = 3; }
                if ((Form1.Qe1 >= 5) && (Form1.Qe1 < 10)) { Form1.Gb1 = 3.76; Form1.Gm1 = 2.66; Form1.Qb1 = 10; Form1.Qm1 = 5; }
                if ((Form1.Qe2 >= 5) && (Form1.Qe2 < 10)) { Form1.Gb2 = 3.76; Form1.Gm2 = 2.66; Form1.Qb2 = 10; Form1.Qm2 = 5; }
                if ((Form1.Qe1 >= 10) && (Form1.Qe1 < 20)) { Form1.Gb1 = 5.31; Form1.Gm1 = 3.76; Form1.Qb1 = 20; Form1.Qm1 = 10; }
                if ((Form1.Qe2 >= 10) && (Form1.Qe2 < 20)) { Form1.Gb2 = 5.31; Form1.Gm2 = 3.76; Form1.Qb2 = 20; Form1.Qm2 = 10; }
                if ((Form1.Qe1 >= 20) && (Form1.Qe1 < 30)) { Form1.Gb1 = 6.50; Form1.Gm1 = 5.31; Form1.Qb1 = 30; Form1.Qm1 = 20; }
                if ((Form1.Qe2 >= 20) && (Form1.Qe2 < 30)) { Form1.Gb2 = 6.50; Form1.Gm2 = 5.31; Form1.Qb2 = 30; Form1.Qm2 = 20; }
                if ((Form1.Qe1 >= 30) && (Form1.Qe1 < 50)) { Form1.Gb1 = 8.50; Form1.Gm1 = 6.50; Form1.Qb1 = 50; Form1.Qm1 = 30; }
                if ((Form1.Qe2 >= 30) && (Form1.Qe2 < 50)) { Form1.Gb2 = 8.50; Form1.Gm2 = 6.50; Form1.Qb2 = 50; Form1.Qm2 = 30; }
                if ((Form1.Qe1 >= 50) && (Form1.Qe1 < 70)) { Form1.Gb1 = 10.23; Form1.Gm1 = 8.50; Form1.Qb1 = 70; Form1.Qm1 = 50; }
                if ((Form1.Qe2 >= 50) && (Form1.Qe2 < 70)) { Form1.Gb2 = 10.23; Form1.Gm2 = 8.50; Form1.Qb2 = 70; Form1.Qm2 = 50; }
                if ((Form1.Qe1 >= 70) && (Form1.Qe1 < 100)) { Form1.Gb1 = 12.54; Form1.Gm1 = 10.23; Form1.Qb1 = 100; Form1.Qm1 = 70; }
                if ((Form1.Qe2 >= 70) && (Form1.Qe2 < 100)) { Form1.Gb2 = 12.54; Form1.Gm2 = 10.23; Form1.Qb2 = 100; Form1.Qm2 = 70; }
                if ((Form1.Qe1 >= 100) && (Form1.Qe1 < 300)) { Form1.Gb1 = 23.49; Form1.Gm1 = 12.54; Form1.Qb1 = 300; Form1.Qm1 = 100; }
                if ((Form1.Qe2 >= 100) && (Form1.Qe2 < 300)) { Form1.Gb2 = 23.49; Form1.Gm2 = 12.54; Form1.Qb2 = 300; Form1.Qm2 = 100; }
                if ((Form1.Qe1 >= 300) && (Form1.Qe1 < 500)) { Form1.Gb1 = 31.61; Form1.Gm1 = 23.49; Form1.Qb1 = 500; Form1.Qm1 = 300; }
                if ((Form1.Qe2 >= 300) && (Form1.Qe2 < 500)) { Form1.Gb2 = 31.61; Form1.Gm2 = 23.49; Form1.Qb2 = 500; Form1.Qm2 = 300; }
                if ((Form1.Qe1 >= 500) && (Form1.Qe1 < 1000)) { Form1.Gb1 = 47.53; Form1.Gm1 = 31.61; Form1.Qb1 = 1000; Form1.Qm1 = 500; }
                if ((Form1.Qe2 >= 500) && (Form1.Qe2 < 1000)) { Form1.Gb2 = 47.53; Form1.Gm2 = 31.61; Form1.Qb2 = 1000; Form1.Qm2 = 500; }
            }
            if (Form1.v >= 11)
            {
                if ((Form1.Qe1 >= 0.01) && (Form1.Qe1 < 0.05)) { Form1.Gb1 = 0.25; Form1.Gm1 = 0.11; Form1.Qb1 = 0.05; Form1.Qm1 = 0.01; }
                if ((Form1.Qe2 >= 0.01) && (Form1.Qe2 < 0.05)) { Form1.Gb2 = 0.25; Form1.Gm2 = 0.11; Form1.Qb2 = 0.05; Form1.Qm2 = 0.01; }
                if ((Form1.Qe1 >= 0.05) && (Form1.Qe1 < 0.1)) { Form1.Gb1 = 0.36; Form1.Gm1 = 0.25; Form1.Qb1 = 0.1; Form1.Qm1 = 0.05; }
                if ((Form1.Qe2 >= 0.05) && (Form1.Qe2 < 0.1)) { Form1.Gb2 = 0.36; Form1.Gm2 = 0.25; Form1.Qb2 = 0.1; Form1.Qm2 = 0.05; }
                if ((Form1.Qe1 >= 0.1) && (Form1.Qe1 < 0.5)) { Form1.Gb1 = 0.80; Form1.Gm1 = 0.36; Form1.Qb1 = 0.5; Form1.Qm1 = 0.1; }
                if ((Form1.Qe2 >= 0.1) && (Form1.Qe2 < 0.5)) { Form1.Gb2 = 0.80; Form1.Gm2 = 0.36; Form1.Qb2 = 0.5; Form1.Qm2 = 0.1; }
                if ((Form1.Qe1 >= 0.5) && (Form1.Qe1 < 1)) { Form1.Gb1 = 1.13; Form1.Gm1 = 0.80; Form1.Qb1 = 1; Form1.Qm1 = 0.5; }
                if ((Form1.Qe2 >= 0.5) && (Form1.Qe2 < 1)) { Form1.Gb2 = 1.13; Form1.Gm2 = 0.80; Form1.Qb2 = 1; Form1.Qm2 = 0.5; }
                if ((Form1.Qe1 >= 1) && (Form1.Qe1 < 3)) { Form1.Gb1 = 1.96; Form1.Gm1 = 1.13; Form1.Qb1 = 3; Form1.Qm1 = 1; }
                if ((Form1.Qe2 >= 1) && (Form1.Qe2 < 3)) { Form1.Gb2 = 1.96; Form1.Gm2 = 1.13; Form1.Qb2 = 3; Form1.Qm2 = 1; }
                if ((Form1.Qe1 >= 3) && (Form1.Qe1 < 5)) { Form1.Gb1 = 2.53; Form1.Gm1 = 1.96; Form1.Qb1 = 5; Form1.Qm1 = 3; }
                if ((Form1.Qe2 >= 3) && (Form1.Qe2 < 5)) { Form1.Gb2 = 2.53; Form1.Gm2 = 1.96; Form1.Qb2 = 5; Form1.Qm2 = 3; }
                if ((Form1.Qe1 >= 5) && (Form1.Qe1 < 10)) { Form1.Gb1 = 3.58; Form1.Gm1 = 2.53; Form1.Qb1 = 10; Form1.Qm1 = 5; }
                if ((Form1.Qe2 >= 5) && (Form1.Qe2 < 10)) { Form1.Gb2 = 3.58; Form1.Gm2 = 2.53; Form1.Qb2 = 10; Form1.Qm2 = 5; }
                if ((Form1.Qe1 >= 10) && (Form1.Qe1 < 20)) { Form1.Gb1 = 5.06; Form1.Gm1 = 3.58; Form1.Qb1 = 20; Form1.Qm1 = 10; }
                if ((Form1.Qe2 >= 10) && (Form1.Qe2 < 20)) { Form1.Gb2 = 5.06; Form1.Gm2 = 3.58; Form1.Qb2 = 20; Form1.Qm2 = 10; }
                if ((Form1.Qe1 >= 20) && (Form1.Qe1 < 30)) { Form1.Gb1 = 6.20; Form1.Gm1 = 5.06; Form1.Qb1 = 30; Form1.Qm1 = 20; }
                if ((Form1.Qe2 >= 20) && (Form1.Qe2 < 30)) { Form1.Gb2 = 6.20; Form1.Gm2 = 5.06; Form1.Qb2 = 30; Form1.Qm2 = 20; }
                if ((Form1.Qe1 >= 30) && (Form1.Qe1 < 50)) { Form1.Gb1 = 8.01; Form1.Gm1 = 6.20; Form1.Qb1 = 50; Form1.Qm1 = 30; }
                if ((Form1.Qe2 >= 30) && (Form1.Qe2 < 50)) { Form1.Gb2 = 8.01; Form1.Gm2 = 6.20; Form1.Qb2 = 50; Form1.Qm2 = 30; }
                if ((Form1.Qe1 >= 50) && (Form1.Qe1 < 70)) { Form1.Gb1 = 9.61; Form1.Gm1 = 8.01; Form1.Qb1 = 70; Form1.Qm1 = 50; }
                if ((Form1.Qe2 >= 50) && (Form1.Qe2 < 70)) { Form1.Gb2 = 9.61; Form1.Gm2 = 8.01; Form1.Qb2 = 70; Form1.Qm2 = 50; }
                if ((Form1.Qe1 >= 70) && (Form1.Qe1 < 100)) { Form1.Gb1 = 11.74; Form1.Gm1 = 9.61; Form1.Qb1 = 100; Form1.Qm1 = 70; }
                if ((Form1.Qe2 >= 70) && (Form1.Qe2 < 100)) { Form1.Gb2 = 11.74; Form1.Gm2 = 9.61; Form1.Qb2 = 100; Form1.Qm2 = 70; }
                if ((Form1.Qe1 >= 100) && (Form1.Qe1 < 300)) { Form1.Gb1 = 21.91; Form1.Gm1 = 11.74; Form1.Qb1 = 300; Form1.Qm1 = 100; }
                if ((Form1.Qe2 >= 100) && (Form1.Qe2 < 300)) { Form1.Gb2 = 21.91; Form1.Gm2 = 11.74; Form1.Qb2 = 300; Form1.Qm2 = 100; }
                if ((Form1.Qe1 >= 300) && (Form1.Qe1 < 500)) { Form1.Gb1 = 29.44; Form1.Gm1 = 21.91; Form1.Qb1 = 500; Form1.Qm1 = 300; }
                if ((Form1.Qe2 >= 300) && (Form1.Qe2 < 500)) { Form1.Gb2 = 29.44; Form1.Gm2 = 21.91; Form1.Qb2 = 500; Form1.Qm2 = 300; }
                if ((Form1.Qe1 >= 500) && (Form1.Qe1 < 1000)) { Form1.Gb1 = 44.15; Form1.Gm1 = 29.44; Form1.Qb1 = 1000; Form1.Qm1 = 500; }
                if ((Form1.Qe2 >= 500) && (Form1.Qe2 < 1000)) { Form1.Gb2 = 44.15; Form1.Gm2 = 29.44; Form1.Qb2 = 1000; Form1.Qm2 = 500; }
            }
            if (Form1.v >= 12)
            {
                if ((Form1.Qe1 >= 0.01) && (Form1.Qe1 < 0.05)) { Form1.Gb1 = 0.24; Form1.Gm1 = 0.11; Form1.Qb1 = 0.05; Form1.Qm1 = 0.01; }
                if ((Form1.Qe2 >= 0.01) && (Form1.Qe2 < 0.05)) { Form1.Gb2 = 0.24; Form1.Gm2 = 0.11; Form1.Qb2 = 0.05; Form1.Qm2 = 0.01; }
                if ((Form1.Qe1 >= 0.05) && (Form1.Qe1 < 0.1)) { Form1.Gb1 = 0.34; Form1.Gm1 = 0.24; Form1.Qb1 = 0.1; Form1.Qm1 = 0.05; }
                if ((Form1.Qe2 >= 0.05) && (Form1.Qe2 < 0.1)) { Form1.Gb2 = 0.34; Form1.Gm2 = 0.24; Form1.Qb2 = 0.1; Form1.Qm2 = 0.05; }
                if ((Form1.Qe1 >= 0.1) && (Form1.Qe1 < 0.5)) { Form1.Gb1 = 0.76; Form1.Gm1 = 0.34; Form1.Qb1 = 0.5; Form1.Qm1 = 0.1; }
                if ((Form1.Qe2 >= 0.1) && (Form1.Qe2 < 0.5)) { Form1.Gb2 = 0.76; Form1.Gm2 = 0.34; Form1.Qb2 = 0.5; Form1.Qm2 = 0.1; }
                if ((Form1.Qe1 >= 0.5) && (Form1.Qe1 < 1)) { Form1.Gb1 = 1.08; Form1.Gm1 = 0.76; Form1.Qb1 = 1; Form1.Qm1 = 0.5; }
                if ((Form1.Qe2 >= 0.5) && (Form1.Qe2 < 1)) { Form1.Gb2 = 1.08; Form1.Gm2 = 0.76; Form1.Qb2 = 1; Form1.Qm2 = 0.5; }
                if ((Form1.Qe1 >= 1) && (Form1.Qe1 < 3)) { Form1.Gb1 = 1.88; Form1.Gm1 = 1.08; Form1.Qb1 = 3; Form1.Qm1 = 1; }
                if ((Form1.Qe2 >= 1) && (Form1.Qe2 < 3)) { Form1.Gb2 = 1.88; Form1.Gm2 = 1.08; Form1.Qb2 = 3; Form1.Qm2 = 1; }
                if ((Form1.Qe1 >= 3) && (Form1.Qe1 < 5)) { Form1.Gb1 = 2.42; Form1.Gm1 = 1.88; Form1.Qb1 = 5; Form1.Qm1 = 3; }
                if ((Form1.Qe2 >= 3) && (Form1.Qe2 < 5)) { Form1.Gb2 = 2.42; Form1.Gm2 = 1.88; Form1.Qb2 = 5; Form1.Qm2 = 3; }
                if ((Form1.Qe1 >= 5) && (Form1.Qe1 < 10)) { Form1.Gb1 = 3.43; Form1.Gm1 = 2.42; Form1.Qb1 = 10; Form1.Qm1 = 5; }
                if ((Form1.Qe2 >= 5) && (Form1.Qe2 < 10)) { Form1.Gb2 = 3.43; Form1.Gm2 = 2.42; Form1.Qb2 = 10; Form1.Qm2 = 5; }
                if ((Form1.Qe1 >= 10) && (Form1.Qe1 < 20)) { Form1.Gb1 = 4.85; Form1.Gm1 = 3.43; Form1.Qb1 = 20; Form1.Qm1 = 10; }
                if ((Form1.Qe2 >= 10) && (Form1.Qe2 < 20)) { Form1.Gb2 = 4.85; Form1.Gm2 = 3.43; Form1.Qb2 = 20; Form1.Qm2 = 10; }
                if ((Form1.Qe1 >= 20) && (Form1.Qe1 < 30)) { Form1.Gb1 = 5.94; Form1.Gm1 = 4.85; Form1.Qb1 = 30; Form1.Qm1 = 20; }
                if ((Form1.Qe2 >= 20) && (Form1.Qe2 < 30)) { Form1.Gb2 = 5.94; Form1.Gm2 = 4.85; Form1.Qb2 = 30; Form1.Qm2 = 20; }
                if ((Form1.Qe1 >= 30) && (Form1.Qe1 < 50)) { Form1.Gb1 = 7.67; Form1.Gm1 = 5.94; Form1.Qb1 = 50; Form1.Qm1 = 30; }
                if ((Form1.Qe2 >= 30) && (Form1.Qe2 < 50)) { Form1.Gb2 = 7.67; Form1.Gm2 = 5.94; Form1.Qb2 = 50; Form1.Qm2 = 30; }
                if ((Form1.Qe1 >= 50) && (Form1.Qe1 < 70)) { Form1.Gb1 = 9.07; Form1.Gm1 = 7.67; Form1.Qb1 = 70; Form1.Qm1 = 50; }
                if ((Form1.Qe2 >= 50) && (Form1.Qe2 < 70)) { Form1.Gb2 = 9.07; Form1.Gm2 = 7.67; Form1.Qb2 = 70; Form1.Qm2 = 50; }
                if ((Form1.Qe1 >= 70) && (Form1.Qe1 < 100)) { Form1.Gb1 = 11.06; Form1.Gm1 = 9.07; Form1.Qb1 = 100; Form1.Qm1 = 70; }
                if ((Form1.Qe2 >= 70) && (Form1.Qe2 < 100)) { Form1.Gb2 = 11.06; Form1.Gm2 = 9.07; Form1.Qb2 = 100; Form1.Qm2 = 70; }
                if ((Form1.Qe1 >= 100) && (Form1.Qe1 < 300)) { Form1.Gb1 = 20.58; Form1.Gm1 = 11.06; Form1.Qb1 = 300; Form1.Qm1 = 100; }
                if ((Form1.Qe2 >= 100) && (Form1.Qe2 < 300)) { Form1.Gb2 = 20.58; Form1.Gm2 = 11.06; Form1.Qb2 = 300; Form1.Qm2 = 100; }
                if ((Form1.Qe1 >= 300) && (Form1.Qe1 < 500)) { Form1.Gb1 = 27.61; Form1.Gm1 = 20.58; Form1.Qb1 = 500; Form1.Qm1 = 300; }
                if ((Form1.Qe2 >= 300) && (Form1.Qe2 < 500)) { Form1.Gb2 = 27.61; Form1.Gm2 = 20.58; Form1.Qb2 = 500; Form1.Qm2 = 300; }
                if ((Form1.Qe1 >= 500) && (Form1.Qe1 < 1000)) { Form1.Gb1 = 41.30; Form1.Gm1 = 27.61; Form1.Qb1 = 1000; Form1.Qm1 = 500; }
                if ((Form1.Qe2 >= 500) && (Form1.Qe2 < 1000)) { Form1.Gb2 = 41.30; Form1.Gm2 = 27.61; Form1.Qb2 = 1000; Form1.Qm2 = 500; }
            }
            if (Form1.v >= 13)
            {
                if ((Form1.Qe1 >= 0.01) && (Form1.Qe1 < 0.05)) { Form1.Gb1 = 0.23; Form1.Gm1 = 0.10; Form1.Qb1 = 0.05; Form1.Qm1 = 0.01; }
                if ((Form1.Qe2 >= 0.01) && (Form1.Qe2 < 0.05)) { Form1.Gb2 = 0.23; Form1.Gm2 = 0.10; Form1.Qb2 = 0.05; Form1.Qm2 = 0.01; }
                if ((Form1.Qe1 >= 0.05) && (Form1.Qe1 < 0.1)) { Form1.Gb1 = 0.33; Form1.Gm1 = 0.23; Form1.Qb1 = 0.1; Form1.Qm1 = 0.05; }
                if ((Form1.Qe2 >= 0.05) && (Form1.Qe2 < 0.1)) { Form1.Gb2 = 0.33; Form1.Gm2 = 0.23; Form1.Qb2 = 0.1; Form1.Qm2 = 0.05; }
                if ((Form1.Qe1 >= 0.1) && (Form1.Qe1 < 0.5)) { Form1.Gb1 = 0.74; Form1.Gm1 = 0.33; Form1.Qb1 = 0.5; Form1.Qm1 = 0.1; }
                if ((Form1.Qe2 >= 0.1) && (Form1.Qe2 < 0.5)) { Form1.Gb2 = 0.74; Form1.Gm2 = 0.33; Form1.Qb2 = 0.5; Form1.Qm2 = 0.1; }
                if ((Form1.Qe1 >= 0.5) && (Form1.Qe1 < 1)) { Form1.Gb1 = 1.04; Form1.Gm1 = 0.74; Form1.Qb1 = 1; Form1.Qm1 = 0.5; }
                if ((Form1.Qe2 >= 0.5) && (Form1.Qe2 < 1)) { Form1.Gb2 = 1.04; Form1.Gm2 = 0.74; Form1.Qb2 = 1; Form1.Qm2 = 0.5; }
                if ((Form1.Qe1 >= 1) && (Form1.Qe1 < 3)) { Form1.Gb1 = 1.80; Form1.Gm1 = 1.04; Form1.Qb1 = 3; Form1.Qm1 = 1; }
                if ((Form1.Qe2 >= 1) && (Form1.Qe2 < 3)) { Form1.Gb2 = 1.80; Form1.Gm2 = 1.04; Form1.Qb2 = 3; Form1.Qm2 = 1; }
                if ((Form1.Qe1 >= 3) && (Form1.Qe1 < 5)) { Form1.Gb1 = 2.37; Form1.Gm1 = 1.80; Form1.Qb1 = 5; Form1.Qm1 = 3; }
                if ((Form1.Qe2 >= 3) && (Form1.Qe2 < 5)) { Form1.Gb2 = 2.37; Form1.Gm2 = 1.80; Form1.Qb2 = 5; Form1.Qm2 = 3; }
                if ((Form1.Qe1 >= 5) && (Form1.Qe1 < 10)) { Form1.Gb1 = 3.29; Form1.Gm1 = 2.37; Form1.Qb1 = 10; Form1.Qm1 = 5; }
                if ((Form1.Qe2 >= 5) && (Form1.Qe2 < 10)) { Form1.Gb2 = 3.29; Form1.Gm2 = 2.37; Form1.Qb2 = 10; Form1.Qm2 = 5; }
                if ((Form1.Qe1 >= 10) && (Form1.Qe1 < 20)) { Form1.Gb1 = 4.66; Form1.Gm1 = 3.29; Form1.Qb1 = 20; Form1.Qm1 = 10; }
                if ((Form1.Qe2 >= 10) && (Form1.Qe2 < 20)) { Form1.Gb2 = 4.66; Form1.Gm2 = 3.29; Form1.Qb2 = 20; Form1.Qm2 = 10; }
                if ((Form1.Qe1 >= 20) && (Form1.Qe1 < 30)) { Form1.Gb1 = 5.70; Form1.Gm1 = 4.66; Form1.Qb1 = 30; Form1.Qm1 = 20; }
                if ((Form1.Qe2 >= 20) && (Form1.Qe2 < 30)) { Form1.Gb2 = 5.70; Form1.Gm2 = 4.66; Form1.Qb2 = 30; Form1.Qm2 = 20; }
                if ((Form1.Qe1 >= 30) && (Form1.Qe1 < 50)) { Form1.Gb1 = 7.37; Form1.Gm1 = 5.70; Form1.Qb1 = 50; Form1.Qm1 = 30; }
                if ((Form1.Qe2 >= 30) && (Form1.Qe2 < 50)) { Form1.Gb2 = 7.37; Form1.Gm2 = 5.70; Form1.Qb2 = 50; Form1.Qm2 = 30; }
                if ((Form1.Qe1 >= 50) && (Form1.Qe1 < 70)) { Form1.Gb1 = 8.72; Form1.Gm1 = 7.37; Form1.Qb1 = 70; Form1.Qm1 = 50; }
                if ((Form1.Qe2 >= 50) && (Form1.Qe2 < 70)) { Form1.Gb2 = 8.72; Form1.Gm2 = 7.37; Form1.Qb2 = 70; Form1.Qm2 = 50; }
                if ((Form1.Qe1 >= 70) && (Form1.Qe1 < 100)) { Form1.Gb1 = 10.48; Form1.Gm1 = 8.72; Form1.Qb1 = 100; Form1.Qm1 = 70; }
                if ((Form1.Qe2 >= 70) && (Form1.Qe2 < 100)) { Form1.Gb2 = 10.48; Form1.Gm2 = 8.72; Form1.Qb2 = 100; Form1.Qm2 = 70; }
                if ((Form1.Qe1 >= 100) && (Form1.Qe1 < 300)) { Form1.Gb1 = 19.45; Form1.Gm1 = 10.48; Form1.Qb1 = 300; Form1.Qm1 = 100; }
                if ((Form1.Qe2 >= 100) && (Form1.Qe2 < 300)) { Form1.Gb2 = 19.45; Form1.Gm2 = 10.48; Form1.Qb2 = 300; Form1.Qm2 = 100; }
                if ((Form1.Qe1 >= 300) && (Form1.Qe1 < 500)) { Form1.Gb1 = 26.04; Form1.Gm1 = 19.45; Form1.Qb1 = 500; Form1.Qm1 = 300; }
                if ((Form1.Qe2 >= 300) && (Form1.Qe2 < 500)) { Form1.Gb2 = 26.04; Form1.Gm2 = 19.45; Form1.Qb2 = 500; Form1.Qm2 = 300; }
                if ((Form1.Qe1 >= 500) && (Form1.Qe1 < 1000)) { Form1.Gb1 = 38.90; Form1.Gm1 = 26.04; Form1.Qb1 = 1000; Form1.Qm1 = 500; }
                if ((Form1.Qe2 >= 500) && (Form1.Qe2 < 1000)) { Form1.Gb2 = 38.90; Form1.Gm2 = 26.04; Form1.Qb2 = 1000; Form1.Qm2 = 500; }
            }
            if (Form1.v >= 14)
            {
                if ((Form1.Qe1 >= 0.01) && (Form1.Qe1 < 0.05)) { Form1.Gb1 = 0.22; Form1.Gm1 = 0.10; Form1.Qb1 = 0.05; Form1.Qm1 = 0.01; }
                if ((Form1.Qe2 >= 0.01) && (Form1.Qe2 < 0.05)) { Form1.Gb2 = 0.22; Form1.Gm2 = 0.10; Form1.Qb2 = 0.05; Form1.Qm2 = 0.01; }
                if ((Form1.Qe1 >= 0.05) && (Form1.Qe1 < 0.1)) { Form1.Gb1 = 0.32; Form1.Gm1 = 0.22; Form1.Qb1 = 0.1; Form1.Qm1 = 0.05; }
                if ((Form1.Qe2 >= 0.05) && (Form1.Qe2 < 0.1)) { Form1.Gb2 = 0.32; Form1.Gm2 = 0.22; Form1.Qb2 = 0.1; Form1.Qm2 = 0.05; }
                if ((Form1.Qe1 >= 0.1) && (Form1.Qe1 < 0.5)) { Form1.Gb1 = 0.71; Form1.Gm1 = 0.32; Form1.Qb1 = 0.5; Form1.Qm1 = 0.1; }
                if ((Form1.Qe2 >= 0.1) && (Form1.Qe2 < 0.5)) { Form1.Gb2 = 0.71; Form1.Gm2 = 0.32; Form1.Qb2 = 0.5; Form1.Qm2 = 0.1; }
                if ((Form1.Qe1 >= 0.5) && (Form1.Qe1 < 1)) { Form1.Gb1 = 1.0; Form1.Gm1 = 0.71; Form1.Qb1 = 1; Form1.Qm1 = 0.5; }
                if ((Form1.Qe2 >= 0.5) && (Form1.Qe2 < 1)) { Form1.Gb2 = 1.0; Form1.Gm2 = 0.71; Form1.Qb2 = 1; Form1.Qm2 = 0.5; }
                if ((Form1.Qe1 >= 1) && (Form1.Qe1 < 3)) { Form1.Gb1 = 1.74; Form1.Gm1 = 1.0; Form1.Qb1 = 3; Form1.Qm1 = 1; }
                if ((Form1.Qe2 >= 1) && (Form1.Qe2 < 3)) { Form1.Gb2 = 1.74; Form1.Gm2 = 1.0; Form1.Qb2 = 3; Form1.Qm2 = 1; }
                if ((Form1.Qe1 >= 3) && (Form1.Qe1 < 5)) { Form1.Gb1 = 2.24; Form1.Gm1 = 1.74; Form1.Qb1 = 5; Form1.Qm1 = 3; }
                if ((Form1.Qe2 >= 3) && (Form1.Qe2 < 5)) { Form1.Gb2 = 2.24; Form1.Gm2 = 1.74; Form1.Qb2 = 5; Form1.Qm2 = 3; }
                if ((Form1.Qe1 >= 5) && (Form1.Qe1 < 10)) { Form1.Gb1 = 3.17; Form1.Gm1 = 2.24; Form1.Qb1 = 10; Form1.Qm1 = 5; }
                if ((Form1.Qe2 >= 5) && (Form1.Qe2 < 10)) { Form1.Gb2 = 3.17; Form1.Gm2 = 2.24; Form1.Qb2 = 10; Form1.Qm2 = 5; }
                if ((Form1.Qe1 >= 10) && (Form1.Qe1 < 20)) { Form1.Gb1 = 4.49; Form1.Gm1 = 3.17; Form1.Qb1 = 20; Form1.Qm1 = 10; }
                if ((Form1.Qe2 >= 10) && (Form1.Qe2 < 20)) { Form1.Gb2 = 4.49; Form1.Gm2 = 3.17; Form1.Qb2 = 20; Form1.Qm2 = 10; }
                if ((Form1.Qe1 >= 20) && (Form1.Qe1 < 30)) { Form1.Gb1 = 5.50; Form1.Gm1 = 4.49; Form1.Qb1 = 30; Form1.Qm1 = 20; }
                if ((Form1.Qe2 >= 20) && (Form1.Qe2 < 30)) { Form1.Gb2 = 5.50; Form1.Gm2 = 4.49; Form1.Qb2 = 30; Form1.Qm2 = 20; }
                if ((Form1.Qe1 >= 30) && (Form1.Qe1 < 50)) { Form1.Gb1 = 7.10; Form1.Gm1 = 5.50; Form1.Qb1 = 50; Form1.Qm1 = 30; }
                if ((Form1.Qe2 >= 30) && (Form1.Qe2 < 50)) { Form1.Gb2 = 7.10; Form1.Gm2 = 5.50; Form1.Qb2 = 50; Form1.Qm2 = 30; }
                if ((Form1.Qe1 >= 50) && (Form1.Qe1 < 70)) { Form1.Gb1 = 8.40; Form1.Gm1 = 7.10; Form1.Qb1 = 70; Form1.Qm1 = 50; }
                if ((Form1.Qe2 >= 50) && (Form1.Qe2 < 70)) { Form1.Gb2 = 8.40; Form1.Gm2 = 7.10; Form1.Qb2 = 70; Form1.Qm2 = 50; }
                if ((Form1.Qe1 >= 70) && (Form1.Qe1 < 100)) { Form1.Gb1 = 10.04; Form1.Gm1 = 8.40; Form1.Qb1 = 100; Form1.Qm1 = 70; }
                if ((Form1.Qe2 >= 70) && (Form1.Qe2 < 100)) { Form1.Gb2 = 10.04; Form1.Gm2 = 8.40; Form1.Qb2 = 100; Form1.Qm2 = 70; }
                if ((Form1.Qe1 >= 100) && (Form1.Qe1 < 300)) { Form1.Gb1 = 18.46; Form1.Gm1 = 10.04; Form1.Qb1 = 300; Form1.Qm1 = 100; }
                if ((Form1.Qe2 >= 100) && (Form1.Qe2 < 300)) { Form1.Gb2 = 18.46; Form1.Gm2 = 10.04; Form1.Qb2 = 300; Form1.Qm2 = 100; }
                if ((Form1.Qe1 >= 300) && (Form1.Qe1 < 500)) { Form1.Gb1 = 24.69; Form1.Gm1 = 18.46; Form1.Qb1 = 500; Form1.Qm1 = 300; }
                if ((Form1.Qe2 >= 300) && (Form1.Qe2 < 500)) { Form1.Gb2 = 24.69; Form1.Gm2 = 18.46; Form1.Qb2 = 500; Form1.Qm2 = 300; }
                if ((Form1.Qe1 >= 500) && (Form1.Qe1 < 1000)) { Form1.Gb1 = 36.81; Form1.Gm1 = 24.69; Form1.Qb1 = 1000; Form1.Qm1 = 500; }
                if ((Form1.Qe2 >= 500) && (Form1.Qe2 < 1000)) { Form1.Gb2 = 36.81; Form1.Gm2 = 24.69; Form1.Qb2 = 1000; Form1.Qm2 = 500; }
            }
            if (Form1.v >= 15)
            {
                if ((Form1.Qe1 >= 0.01) && (Form1.Qe1 < 0.05)) { Form1.Gb1 = 0.22; Form1.Gm1 = 0.10; Form1.Qb1 = 0.05; Form1.Qm1 = 0.01; }
                if ((Form1.Qe2 >= 0.01) && (Form1.Qe2 < 0.05)) { Form1.Gb2 = 0.22; Form1.Gm2 = 0.10; Form1.Qb2 = 0.05; Form1.Qm2 = 0.01; }
                if ((Form1.Qe1 >= 0.05) && (Form1.Qe1 < 0.1)) { Form1.Gb1 = 0.31; Form1.Gm1 = 0.22; Form1.Qb1 = 0.1; Form1.Qm1 = 0.05; }
                if ((Form1.Qe2 >= 0.05) && (Form1.Qe2 < 0.1)) { Form1.Gb2 = 0.31; Form1.Gm2 = 0.22; Form1.Qb2 = 0.1; Form1.Qm2 = 0.05; }
                if ((Form1.Qe1 >= 0.1) && (Form1.Qe1 < 0.5)) { Form1.Gb1 = 0.69; Form1.Gm1 = 0.31; Form1.Qb1 = 0.5; Form1.Qm1 = 0.1; }
                if ((Form1.Qe2 >= 0.1) && (Form1.Qe2 < 0.5)) { Form1.Gb2 = 0.69; Form1.Gm2 = 0.31; Form1.Qb2 = 0.5; Form1.Qm2 = 0.1; }
                if ((Form1.Qe1 >= 0.5) && (Form1.Qe1 < 1)) { Form1.Gb1 = 0.97; Form1.Gm1 = 0.69; Form1.Qb1 = 1; Form1.Qm1 = 0.5; }
                if ((Form1.Qe2 >= 0.5) && (Form1.Qe2 < 1)) { Form1.Gb2 = 0.97; Form1.Gm2 = 0.69; Form1.Qb2 = 1; Form1.Qm2 = 0.5; }
                if ((Form1.Qe1 >= 1) && (Form1.Qe1 < 3)) { Form1.Gb1 = 1.68; Form1.Gm1 = 0.97; Form1.Qb1 = 3; Form1.Qm1 = 1; }
                if ((Form1.Qe2 >= 1) && (Form1.Qe2 < 3)) { Form1.Gb2 = 1.68; Form1.Gm2 = 0.97; Form1.Qb2 = 3; Form1.Qm2 = 1; }
                if ((Form1.Qe1 >= 3) && (Form1.Qe1 < 5)) { Form1.Gb1 = 2.17; Form1.Gm1 = 1.68; Form1.Qb1 = 5; Form1.Qm1 = 3; }
                if ((Form1.Qe2 >= 3) && (Form1.Qe2 < 5)) { Form1.Gb2 = 2.17; Form1.Gm2 = 1.68; Form1.Qb2 = 5; Form1.Qm2 = 3; }
                if ((Form1.Qe1 >= 5) && (Form1.Qe1 < 10)) { Form1.Gb1 = 3.07; Form1.Gm1 = 2.17; Form1.Qb1 = 10; Form1.Qm1 = 5; }
                if ((Form1.Qe2 >= 5) && (Form1.Qe2 < 10)) { Form1.Gb2 = 3.07; Form1.Gm2 = 2.17; Form1.Qb2 = 10; Form1.Qm2 = 5; }
                if ((Form1.Qe1 >= 10) && (Form1.Qe1 < 20)) { Form1.Gb1 = 4.34; Form1.Gm1 = 3.07; Form1.Qb1 = 20; Form1.Qm1 = 10; }
                if ((Form1.Qe2 >= 10) && (Form1.Qe2 < 20)) { Form1.Gb2 = 4.34; Form1.Gm2 = 3.07; Form1.Qb2 = 20; Form1.Qm2 = 10; }
                if ((Form1.Qe1 >= 20) && (Form1.Qe1 < 30)) { Form1.Gb1 = 5.31; Form1.Gm1 = 4.34; Form1.Qb1 = 30; Form1.Qm1 = 20; }
                if ((Form1.Qe2 >= 20) && (Form1.Qe2 < 30)) { Form1.Gb2 = 5.31; Form1.Gm2 = 4.34; Form1.Qb2 = 30; Form1.Qm2 = 20; }
                if ((Form1.Qe1 >= 30) && (Form1.Qe1 < 50)) { Form1.Gb1 = 6.86; Form1.Gm1 = 5.31; Form1.Qb1 = 50; Form1.Qm1 = 30; }
                if ((Form1.Qe2 >= 30) && (Form1.Qe2 < 50)) { Form1.Gb2 = 6.86; Form1.Gm2 = 5.31; Form1.Qb2 = 50; Form1.Qm2 = 30; }
                if ((Form1.Qe1 >= 50) && (Form1.Qe1 < 70)) { Form1.Gb1 = 8.11; Form1.Gm1 = 6.86; Form1.Qb1 = 70; Form1.Qm1 = 50; }
                if ((Form1.Qe2 >= 50) && (Form1.Qe2 < 70)) { Form1.Gb2 = 8.11; Form1.Gm2 = 6.86; Form1.Qb2 = 70; Form1.Qm2 = 50; }
                if ((Form1.Qe1 >= 70) && (Form1.Qe1 < 100)) { Form1.Gb1 = 9.70; Form1.Gm1 = 8.11; Form1.Qb1 = 100; Form1.Qm1 = 70; }
                if ((Form1.Qe2 >= 70) && (Form1.Qe2 < 100)) { Form1.Gb2 = 9.70; Form1.Gm2 = 8.11; Form1.Qb2 = 100; Form1.Qm2 = 70; }
                if ((Form1.Qe1 >= 100) && (Form1.Qe1 < 300)) { Form1.Gb1 = 17.6; Form1.Gm1 = 9.70; Form1.Qb1 = 300; Form1.Qm1 = 100; }
                if ((Form1.Qe2 >= 100) && (Form1.Qe2 < 300)) { Form1.Gb2 = 17.6; Form1.Gm2 = 9.70; Form1.Qb2 = 300; Form1.Qm2 = 100; }
                if ((Form1.Qe1 >= 300) && (Form1.Qe1 < 500)) { Form1.Gb1 = 23.5; Form1.Gm1 = 17.6; Form1.Qb1 = 500; Form1.Qm1 = 300; }
                if ((Form1.Qe2 >= 300) && (Form1.Qe2 < 500)) { Form1.Gb2 = 23.5; Form1.Gm2 = 17.6; Form1.Qb2 = 500; Form1.Qm2 = 300; }
                if ((Form1.Qe1 >= 500) && (Form1.Qe1 < 1000)) { Form1.Gb1 = 34.98; Form1.Gm1 = 23.5; Form1.Qb1 = 1000; Form1.Qm1 = 500; }
                if ((Form1.Qe2 >= 500) && (Form1.Qe2 < 1000)) { Form1.Gb2 = 34.98; Form1.Gm2 = 23.5; Form1.Qb2 = 1000; Form1.Qm2 = 500; }
            }
        }
    }
}
