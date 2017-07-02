﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrognozCS
{
    public partial class Form1 : Form
    {
        //Заявление переменных для расчета
        public static double M,//Молекулярная масса
            p,//Плотность вещества
            P,//Давление насыщенного пара Р при tкип
            D,//Пороговая токсодоза Д, мг * мин / л
            Dhlor=0.6,////Пороговая токсодоза Д для хлора, мг * мин / л
            tkip,//Температура кипения,tкип ,0С
            Q0,//количество выброшенного (разлившегося) при аварии вещества, т.
            Cp,//удельная теплоемкость  жидкого АХОВ, кДж/(кг*град)
            dT,//разность температур жидкого АХОВ до и после разрушения емкости, 0С
            dHisp,//удельная теплота испарения жидкого АХОВ при температуре испарения, кДж/кг
            v,//значение скорости ветра, м/с
            W,//скорость переноса переднего фронта облака зараженного АХОВ воздуха, км/час
            Vh,//объем хранилища, м3
            n,//процентное содержание АХОВ в газовом потоке, %
            d,//диаметр трубопровода, м
            l,//длина секции газопровода между автоматическими отсекателями, м
            t,//температура окружающей среды, 0С
            tp,//температура почвы, 0С
            F,//реальная площадь разлива в поддоны, м2
            Qe1,//Эквивалентное количество вещества по первичному облаку (в тоннах)
            Qe2,//Эквивалентное количество вещества по вторичному облаку (в тоннах)
            h,//Толщина слоя жидкости разлившейся свободно, постоянна, м
            H,//высота поддона (обвалования), м
            T,//продолжительность поражающего действия АХОВ
            N,//время прошедшее с момента аварии, час
            L,//расстояния от химически опасного объекта до объекта попадающего в зону риска, км
            Tx,//время подхода облака зараженного воздуха к населенному пункту, час
            //первичное облако
            Ge1,//искомое значение глубины распространения зараженного АХОВ воздуха, км
            Gm1,//меньшее значение глубины распространения зараженного АХОВ воздуха, км
            Gb1,//большее значение глубины распространения зараженного АХОВ воздуха, км
            Qb1,//большее перешедшее в облако эквивалентное количество АХОВ, т
            Qm1,//меньшее перешедшее в облако эквивалентное количество АХОВ, т
            //вторичное облако
            Ge2,//искомое значение глубины распространения зараженного АХОВ воздуха, км
            Gm2,//меньшее значение глубины распространения зараженного АХОВ воздуха, км
            Gb2,//большее значение глубины распространения зараженного АХОВ воздуха, км
            Qb2,//большее перешедшее в облако эквивалентное количество АХОВ, т
            Qm2,//меньшее перешедшее в облако эквивалентное количество АХОВ, т
            Ge,//глубина распространения зараженного воздуха, км
            Gp,//предельная глубина поражения АХОВ, км
            G,//искомая глубина поражения АХОВ, км
            X,//расстояние до населенного пункта, км
            K1,//коэффициент, зависящий от условий хранения АХОВ
            K2,//коэффициент, зависящий от физико-химических свойств АХОВ
            K3,//коэффициент, равный отношению пороговой токсодозы хлора к пороговой токсодозе другого АХОВ
            K4,// 
            K5,//коэффициент, учитывающий влияние степени вертикальной устойчивости атмосферы 
            K6,//
            K7,//коэффициент, учитывающий влияние температуры воздуха первичное облако
            K72;//коэффициент, учитывающий влияние температуры воздуха вторичное облако

        public Form1()
        {
            InitializeComponent();
            //Добавление АХОВ
            substance.Items.Add("Хлор");
            //////////////////////////////
            //Вертикальная устойчивость атмосферы
            vertUst.Items.Add("Изотермия");
            vertUst.Items.Add("Инверсия");
            vertUst.Items.Add("Конвекция");
        }

        public void svob_CheckedChanged(object sender, EventArgs e)
        {
            h = 0.05;
            visPod.Visible = false;
            visPodlabel.Visible = false;
            plosh.Visible = false;
            ploshlabel.Visible = false;
        }
        public void sam_CheckedChanged(object sender, EventArgs e)
        {
            visPod.Visible = true;
            visPodlabel.Visible = true;
            plosh.Visible = false;
            ploshlabel.Visible = false;
        }
        public void obsh_CheckedChanged(object sender, EventArgs e)
        {
            plosh.Visible = true;
            ploshlabel.Visible = true;
            visPod.Visible = false;
            visPodlabel.Visible = false;
        }
        public void substance_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Присваивание параметров АХОВ
            if (substance.Text == "Хлор")
            {
                jid.Visible = true;
                gaz.Visible = true;
                M = 70.91;
                tkip = -34.7;
                P = 101.58;
                D = 0.6;
            }
            //////////////////////////////////////
        }
        public void button1_Click(object sender, EventArgs e)
        {
            //Определение случаев когда пользователь не ввел значения в текстовые поля
            if (distance.Text == "") { X = 0; }
            else { X = Convert.ToDouble(distance.Text); }
            if (visPod.Text == "") { H = 0; }
            if (plosh.Text == "") { F = 0; }
            if (outAXOB.Text == "") { Q0 = 0; }
            else { Q0 = Convert.ToDouble(outAXOB.Text); }
            if (time.Text == "") { N = 4; }
            else { N = Convert.ToDouble(time.Text); }
            if (speedAir.Text == "") { v = 3; }
            else { v = Convert.ToDouble(speedAir.Text); }
            if (tempAir.Text == "") { t = 20; }
            else { t = Convert.ToDouble(tempAir.Text); }
            //Определение К7 при температуре окружающей среды и присваевание веществу коэф. К1
            if (substance.Text == "Хлор")
            {
                if (t <= -40) { K7 = 0; K72 = 0.9; }
                if ((t < -20) && (t < -20)) { K7 = 0.15; K72 = 0.95; }
                if (t == -20) { K7 = 0.3; K72 = 1; }
                if ((t > -20) && (t < 0)) { K7 = 0.45; K72 = 1; }
                if (t == 0) { K7 = 0.6; K72 = 1; }
                if ((t > 0) && (t < 20)) { K7 = 0.8; K72 = 1; }
                if (t == 20) { K7 = 1; K72 = 1; }
                if ((t > 20) && (t < 40)) { K7 = 1.2; K72 = 1.5; }
                if (t >= 40) { K7 = 1.4; K72 = 2; }
                K1 = 0.18;
            }
            //Присваивание параметров для вертикальной устойчивости атмосферы
            if (vertUst.Text == "Инверсия")
            {
                K5 = 1.0;
                if (v <= 1)
                {
                    W = 5;
                }
                if (v <= 2)
                {
                    W = 10;
                }
                if (v <= 3)
                {
                    W = 16;
                }
                if (v > 3)
                {
                    W = 21;
                }
            }
            if (vertUst.Text == "Изотермия")
            {
                K5 = 0.23;
                if (v <= 1)
                {
                    W = 6;
                }
                if (v == 2)
                {
                    W = 12;
                }
                if (v == 3)
                {
                    W = 18;
                }
                if (v == 4)
                {
                    W = 24;
                }
                if (v == 5)
                {
                    W = 29;
                }
                if (v == 6)
                {
                    W = 35;
                }
                if (v == 7)
                {
                    W = 41;
                }
                if (v == 8)
                {
                    W = 47;
                }
                if (v == 9)
                {
                    W = 53;
                }
                if (v == 10)
                {
                    W = 59;
                }
                if (v == 11)
                {
                    W = 65;
                }
                if (v == 12)
                {
                    W = 71;
                }
                if (v == 13)
                {
                    W = 76;
                }
                if (v == 14)
                {
                    W = 82;
                }
                if (v == 15)
                {
                    W = 88;
                }
            }
            if (vertUst.Text == "Конвекция")
            {
                K5 = 0.08;
                if (v <= 1)
                {
                    W = 7;
                }
                if (v <= 2)
                {
                    W = 14;
                }
                if (v <= 3)
                {
                    W = 21;
                }
                if (v > 3)
                {
                    W = 28;
                }
            }
            //Расчет высоты/площади
            if (sam.Checked == true)
            {
                if (visPod.Text == "") { H = 0; }
                else { H = Convert.ToDouble(visPod.Text); }
                h = H - 0.2;
            }
            if (obsh.Checked == true)
            {
                if (plosh.Text == "") { F = 0; }
                else { F = Convert.ToDouble(plosh.Text); }
                h = Q0 / F * p;
            }
            //Коэффициенты К2, К3 и К4
            K2 = 6.08 * Math.Pow(10,-5) * P * Math.Pow(M,0.5);
            K3 = Dhlor / D;
            K4 = v / 3 + 0.67;
            //Выбор АХОВ с агрегатным состоянием
            if (substance.Text == "Хлор")
            {
                if (jid.Checked)
                {
                    p = 1.553;
                }
                if (gaz.Checked)
                {
                    p = 0.0032;
                }
            }
            //Определение эквивалентного количества вещества по первичному облаку
            Qe1 = K1 * K3 * K5 * K7 * Q0;
            //Время испарения АХОВ
            T = (h * p) / (K2 * K4 * K72);
            //Определение коэффициента К6
            if (N < T)
            {
                K6 = Math.Pow(N, 0.8);
            }
            if (N > T)
            {
                K6 = Math.Pow(T, 0.8);
            }
            if (T < 1)
            {
                K6 = 1;
            }
            //Определение эквивалентного количества вещества по вторичному облаку
            Qe2 = ((1 - K1) * K2 * K3 * K4 * K5 * K6 * K72 * Q0) / (h * p);
            //Определение большего и меньшего кол-ва АХОВ и глубины заражения облаками 
            if (v <= 1)
            {
                
            }
            if (v <= 2)
            {
                if ((Qe1 >= 0.01) && (Qe1 < 0.05)) { Gb1 = 0.59; Gm1 = 0.26; Qb1 = 0.05; Qm1 = 0.01; }
                if ((Qe2 >= 0.01) && (Qe2 < 0.05)) { Gb2 = 0.59; Gm2 = 0.26; Qb2 = 0.05; Qm2 = 0.01; }
                if ((Qe1 >= 0.05) && (Qe1 < 0.1)) { Gb1 = 0.84; Gm1 = 0.59; Qb1 = 0.1; Qm1 = 0.05; }
                if ((Qe2 >= 0.05) && (Qe2 < 0.1)) { Gb2 = 0.84; Gm2 = 0.59; Qb2 = 0.1; Qm2 = 0.05; }
                if ((Qe1 >= 0.1) && (Qe1 < 0.5)) { Gb1 = 1.92; Gm1 = 0.84; Qb1 = 0.5; Qm1 = 0.1; }
                if ((Qe2 >= 0.1) && (Qe2 < 0.5)) { Gb2 = 1.92; Gm2 = 0.84; Qb2 = 0.5; Qm2 = 0.1; }
                if ((Qe1 >= 0.5) && (Qe1 < 1)) { Gb1 = 2.84; Gm1 = 1.92; Qb1 = 1; Qm1 = 0.5; }
                if ((Qe2 >= 0.5) && (Qe2 < 1)) { Gb2 = 2.84; Gm2 = 1.92; Qb2 = 1; Qm2 = 0.5; }
                if ((Qe1 >= 1) && (Qe1 < 3)) { Gb1 = 5.35; Gm1 = 2.84; Qb1 = 3; Qm1 = 1; }
                if ((Qe2 >= 1) && (Qe2 < 3)) { Gb2 = 5.35; Gm2 = 2.84; Qb2 = 3; Qm2 = 1; }
                if ((Qe1 >= 3) && (Qe1 < 5)) { Gb1 = 7.2; Gm1 = 5.35; Qb1 = 5; Qm1 = 3; }
                if ((Qe2 >= 3) && (Qe2 < 5)) { Gb2 = 7.2; Gm2 = 5.35; Qb2 = 5; Qm2 = 3; }
                if ((Qe1 >= 5) && (Qe1 < 10)) { Gb1 = 10.83; Gm1 = 7.2; Qb1 = 10; Qm1 = 5; }
                if ((Qe2 >= 5) && (Qe2 < 10)) { Gb2 = 10.83; Gm2 = 7.2; Qb2 = 10; Qm2 = 5; }
                if ((Qe1 >= 10) && (Qe1 < 20)) { Gb1 = 16.44; Gm1 = 10.83; Qb1 = 20; Qm1 = 10; }
                if ((Qe2 >= 10) && (Qe2 < 20)) { Gb2 = 16.44; Gm2 = 10.83; Qb2 = 20; Qm2 = 10; }
                if ((Qe1 >= 20) && (Qe1 < 30)) { Gb1 = 21.02; Gm1 = 16.44; Qb1 = 30; Qm1 = 20; }
                if ((Qe2 >= 20) && (Qe2 < 30)) { Gb2 = 21.02; Gm2 = 16.44; Qb2 = 30; Qm2 = 20; }
                if ((Qe1 >= 30) && (Qe1 < 50)) { Gb1 = 28.73; Gm1 = 21.02; Qb1 = 50; Qm1 = 30; }
                if ((Qe2 >= 30) && (Qe2 < 50)) { Gb2 = 28.73; Gm2 = 21.02; Qb2 = 50; Qm2 = 30; }
                if ((Qe1 >= 50) && (Qe1 < 70)) { Gb1 = 35.35; Gm1 = 28.73; Qb1 = 70; Qm1 = 50; }
                if ((Qe2 >= 50) && (Qe2 < 70)) { Gb2 = 35.35; Gm2 = 28.73; Qb2 = 70; Qm2 = 50; }
                if ((Qe1 >= 70) && (Qe1 < 100)) { Gb1 = 44.09; Gm1 = 35.35; Qb1 = 100; Qm1 = 70; }
                if ((Qe2 >= 70) && (Qe2 < 100)) { Gb2 = 44.09; Gm2 = 35.35; Qb2 = 100; Qm2 = 70; }
                if ((Qe1 >= 100) && (Qe1 < 300)) { Gb1 = 87.79; Gm1 = 44.09; Qb1 = 300; Qm1 = 100; }
                if ((Qe2 >= 100) && (Qe2 < 300)) { Gb2 = 87.79; Gm2 = 44.09; Qb2 = 300; Qm2 = 100; }
                if ((Qe1 >= 300) && (Qe1 < 500)) { Gb1 = 121; Gm1 = 87.79; Qb1 = 500; Qm1 = 300; }
                if ((Qe2 >= 300) && (Qe2 < 500)) { Gb2 = 121; Gm2 = 87.79; Qb2 = 500; Qm2 = 300; }
                if ((Qe1 >= 500) && (Qe1 < 1000)) { Gb1 = 189; Gm1 = 121; Qb1 = 1000; Qm1 = 500; }
                if ((Qe2 >= 500) && (Qe2 < 1000)) { Gb2 = 189; Gm2 = 121; Qb2 = 1000; Qm2 = 500; }
            }
            if (v <= 3)
            {

            }
            if (v <= 4)
            {

            }
            if (v <= 5)
            {

            }
            if (v <= 6)
            {

            }
            if (v <= 7)
            {

            }
            if (v <= 8)
            {

            }
            if (v <= 9)
            {

            }
            if (v <= 10)
            {

            }
            if (v <= 11)
            {

            }
            if (v <= 12)
            {

            }
            if (v <= 13)
            {

            }
            if (v <= 14)
            {

            }
            if (v <= 15 && v > 15)
            {

            }
            //Глубина распространения первичного и вторичного облаков АХОВ
            Ge1 = Gm1 + ((Gb1 - Gm1) / (Qb1 - Qm1)) * (Qe1 - Qm1);
            Ge2 = Gm2 + ((Gb2 - Gm2) / (Qb2 - Qm2)) * (Qe2 - Qm2);
            Ge = Ge1 + 0.5 * Ge2;
            Gp = N * W;
            if (Ge < Gp) { G = Ge; }
            else { G = Gp; }
            //Определение времени подхода облака зараженного АХОВ к населенным пунктам
            Tx = X / W;
            //Открытие формы с результатом
            if (substance.Text == "")
            {
                MessageBox.Show("Выберите аварийно химически опасное вещество!",
             "Уточните параметры!", MessageBoxButtons.OK);
            }
            else
            {
                if (p == 0)
                {
                    MessageBox.Show("Выберите агрегатное состояние для выбранного вещества!",
                 "Уточните параметры!", MessageBoxButtons.OK);
                }
                else
                { 
                    new Form2().Show();
                }
            }
        }
        public void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}