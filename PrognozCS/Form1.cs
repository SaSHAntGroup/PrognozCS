using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PrognozCS
{
    public partial class Form1 : Form
    {
        //Заявление переменных для расчета
        public static double M,M1,M2,M3,M4,M5,M6,//Молекулярная масса
            p,p1,p2,p3,p4,p5,p6,//Плотность вещества
            P,Pi1,Pi2,Pi3,Pi4,Pi5,Pi6,//Давление насыщенного пара Р при tкип
            D,D1,D2,D3,D4,D5,D6,//Пороговая токсодоза Д, мг * мин / л
            Dhlor=0.6,////Пороговая токсодоза Д для хлора, мг * мин / л
            tkip,tkip1,tkip2,tkip3,tkip4,tkip5,tkip6,//Температура кипения,tкип ,0С
            Q0,Q01,Q02,Q03,Q04,Q05,Q06,//количество выброшенного (разлившегося) при аварии вещества, т.
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
            T,T1,T2,T3,T4,T5,T6,//продолжительность поражающего действия АХОВ
            N,//время прошедшее с момента аварии, час
            L,//расстояния от химически опасного объекта до объекта попадающего в зону риска, км
            Tx,//время подхода облака зараженного воздуха к населенному пункту, час
            Txh,Txm,//часы и минуты по отдельности для визуального оформления
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
            Sf,//площадь фактического заражения АХОВ
            Sp,//площадь возможного заражения АХОВ
            f,//угловые размеры возможного заражения АХОВ
            Ag,//плотность населения в городе, чел/кв. км
            Az,//плотность населения в загородной зоне, чел/кв. км
            n1g,//обеспеченость населения противогазами в городе, %
            n1z,//обеспеченость населения противогазами в загородной зоне, %
            n2g,//обеспеченость населения убежищами в городе, %
            n2z,//обеспеченость населения убежищами в загородной зоне, %
            Kg,//доля незащищенного населения в городе
            Kz,//доля незащищенного населения в загородной зоне
            Pg,Pz,//сокращение действий в выраженний для расчета P0
            P0,//величина возможных потерь населения в очаге поражения АХОВ
            P1,P2,P3,//для оперативных расчетов вычисление потерь: безвозвратные, санитарные и легкой формы
            N11,N12,N21,N22,//перевод процентов в десятичные значения
            Kv,//коэффициент, зависящий от степени вертикальной устойчивости воздуха
            K1,K11,K12,K13,K14,K15,K16,//коэффициент, зависящий от условий хранения АХОВ
            K2,K21,K22,K23,K24,K25,K26,//коэффициент, зависящий от физико-химических свойств АХОВ
            K3,K31,K32,K33,K34,K35,K36,//коэффициент, равный отношению пороговой токсодозы хлора к пороговой токсодозе другого АХОВ
            K4,//доп. коэф.
            K5,//коэффициент, учитывающий влияние степени вертикальной устойчивости атмосферы 
            K6,K61,K62,K63,K64,K65,K66,//доп. коэф.
            K7,K711,K712,K73,K74,K75,K76,//коэффициент, учитывающий влияние температуры воздуха первичное облако
            K72,K721,K722,K723,K724,K725,K726;//коэффициент, учитывающий влияние температуры воздуха вторичное облако

        private void AXOBkolvo2_CheckedChanged(object sender, EventArgs e)
        {
            vibAXOB.Visible = false;
            substance.Visible = false;
            outAXOBlabel.Visible = false;
            outAXOB.Visible = false;
            kolvoTOHHlabel.Visible = false;
            viborAXOB.Visible = true;
        }

        private void AXOBkolvo1_CheckedChanged(object sender, EventArgs e)
        {
            vibAXOB.Visible = true;
            substance.Visible = true;
            outAXOBlabel.Visible = true;
            outAXOB.Visible = true;
            kolvoTOHHlabel.Visible = true;
            viborAXOB.Visible = false;
        }

        public Form1()
        {
            InitializeComponent();
            //Добавление АХОВ
            substance.Items.Add("Аммиак");
            substance.Items.Add("Водород фтористый");
            substance.Items.Add("Водород хлористый");
            substance.Items.Add("Водород бромистый");
            substance.Items.Add("Водород цианистый");
            substance.Items.Add("Двуокись азота");
            substance.Items.Add("Сернистый ангидрид");
            substance.Items.Add("Сероводород");
            substance.Items.Add("Сероуглерод");
            substance.Items.Add("Соляная кислота");
            substance.Items.Add("Формальдегид");
            substance.Items.Add("Фосген");
            substance.Items.Add("Фтор");
            substance.Items.Add("Хлор");
            substance.Items.Add("Хлорциан");
            //Добавление АХОВ1
            substance1.Items.Add("Аммиак");
            substance1.Items.Add("Водород фтористый");
            substance1.Items.Add("Водород хлористый");
            substance1.Items.Add("Водород бромистый");
            substance1.Items.Add("Водород цианистый");
            substance1.Items.Add("Двуокись азота");
            substance1.Items.Add("Сернистый ангидрид");
            substance1.Items.Add("Сероводород");
            substance1.Items.Add("Сероуглерод");
            substance1.Items.Add("Соляная кислота");
            substance1.Items.Add("Формальдегид");
            substance1.Items.Add("Фосген");
            substance1.Items.Add("Фтор");
            substance1.Items.Add("Хлор");
            substance1.Items.Add("Хлорциан");
            //Добавление АХОВ2
            substance2.Items.Add("Аммиак");
            substance2.Items.Add("Водород фтористый");
            substance2.Items.Add("Водород хлористый");
            substance2.Items.Add("Водород бромистый");
            substance2.Items.Add("Водород цианистый");
            substance2.Items.Add("Двуокись азота");
            substance2.Items.Add("Сернистый ангидрид");
            substance2.Items.Add("Сероводород");
            substance2.Items.Add("Сероуглерод");
            substance2.Items.Add("Соляная кислота");
            substance2.Items.Add("Формальдегид");
            substance2.Items.Add("Фосген");
            substance2.Items.Add("Фтор");
            substance2.Items.Add("Хлор");
            substance2.Items.Add("Хлорциан");
            //Добавление АХОВ3
            substance3.Items.Add("Аммиак");
            substance3.Items.Add("Водород фтористый");
            substance3.Items.Add("Водород хлористый");
            substance3.Items.Add("Водород бромистый");
            substance3.Items.Add("Водород цианистый");
            substance3.Items.Add("Двуокись азота");
            substance3.Items.Add("Сернистый ангидрид");
            substance3.Items.Add("Сероводород");
            substance3.Items.Add("Сероуглерод");
            substance3.Items.Add("Соляная кислота");
            substance3.Items.Add("Формальдегид");
            substance3.Items.Add("Фосген");
            substance3.Items.Add("Фтор");
            substance3.Items.Add("Хлор");
            substance3.Items.Add("Хлорциан");
            //Добавление АХОВ4
            substance4.Items.Add("Аммиак");
            substance4.Items.Add("Водород фтористый");
            substance4.Items.Add("Водород хлористый");
            substance4.Items.Add("Водород бромистый");
            substance4.Items.Add("Водород цианистый");
            substance4.Items.Add("Двуокись азота");
            substance4.Items.Add("Сернистый ангидрид");
            substance4.Items.Add("Сероводород");
            substance4.Items.Add("Сероуглерод");
            substance4.Items.Add("Соляная кислота");
            substance4.Items.Add("Формальдегид");
            substance4.Items.Add("Фосген");
            substance4.Items.Add("Фтор");
            substance4.Items.Add("Хлор");
            substance4.Items.Add("Хлорциан");
            //Добавление АХОВ5
            substance5.Items.Add("Аммиак");
            substance5.Items.Add("Водород фтористый");
            substance5.Items.Add("Водород хлористый");
            substance5.Items.Add("Водород бромистый");
            substance5.Items.Add("Водород цианистый");
            substance5.Items.Add("Двуокись азота");
            substance5.Items.Add("Сернистый ангидрид");
            substance5.Items.Add("Сероводород");
            substance5.Items.Add("Сероуглерод");
            substance5.Items.Add("Соляная кислота");
            substance5.Items.Add("Формальдегид");
            substance5.Items.Add("Фосген");
            substance5.Items.Add("Фтор");
            substance5.Items.Add("Хлор");
            substance5.Items.Add("Хлорциан");
            //Добавление АХОВ6
            substance6.Items.Add("Аммиак");
            substance6.Items.Add("Водород фтористый");
            substance6.Items.Add("Водород хлористый");
            substance6.Items.Add("Водород бромистый");
            substance6.Items.Add("Водород цианистый");
            substance6.Items.Add("Двуокись азота");
            substance6.Items.Add("Сернистый ангидрид");
            substance6.Items.Add("Сероводород");
            substance6.Items.Add("Сероуглерод");
            substance6.Items.Add("Соляная кислота");
            substance6.Items.Add("Формальдегид");
            substance6.Items.Add("Фосген");
            substance6.Items.Add("Фтор");
            substance6.Items.Add("Хлор");
            substance6.Items.Add("Хлорциан");
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
            ploshlabel.Visible = false;
            plosh.Visible = false;
            meter.Visible = false;
        }
        public void sam_CheckedChanged(object sender, EventArgs e)
        {
            visPod.Visible = true;
            visPodlabel.Visible = true;
            meter.Visible = true;
            ploshlabel.Visible = false;
            plosh.Visible = false;
        }
        public void obsh_CheckedChanged(object sender, EventArgs e)
        {
            ploshlabel.Visible = true;
            plosh.Visible = true;
            meter.Visible = true;
            visPod.Visible = false;
            visPodlabel.Visible = false;
        }
        
        public void substance_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Присваивание параметров АХОВ1
            ///////////////////////////////////////////////
            if (substance.Text == "")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Хлор")
            {
                jid.Visible = true;
                gaz.Visible = true;
            }
            if (substance.Text == "Аммиак")
            {
                jid.Visible = true;
                gaz.Visible = true;
            }
            if (substance.Text == "Водород хлористый")
            {
                jid.Visible = true;
                gaz.Visible = true;
            }
            if (substance.Text == "Водород бромистый")
            {
                jid.Visible = true;
                gaz.Visible = true;
            }
            if (substance.Text == "Сероводород")
            {
                jid.Visible = true;
                gaz.Visible = true;
            }
            if (substance.Text == "Фосген")
            {
                jid.Visible = true;
                gaz.Visible = true;
            }
            if (substance.Text == "Фтор")
            {
                jid.Visible = true;
                gaz.Visible = true;
            }
            if (substance.Text == "Хлорициан")
            {
                jid.Visible = true;
                gaz.Visible = true;
            }
            if (substance.Text == "Водород фтористый")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Водород цианистый")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Двуокись азота")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Сернистый ангидрид")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Сероуглерод")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Соляная кислота")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Формальдегид")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
        }
        public void substance2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Присваивание параметров АХОВ2
            //////////////////////////////////////////////////
            if (substance2.Text == "")
            {
                jid2.Visible = false;
                gaz2.Visible = false;
            }
            if (substance2.Text == "Хлор")
            {
                jid2.Visible = true;
                gaz2.Visible = true;
            }
            if (substance2.Text == "Аммиак")
            {
                jid2.Visible = true;
                gaz2.Visible = true;
            }
            if (substance2.Text == "Водород хлористый")
            {
                jid2.Visible = true;
                gaz2.Visible = true;
            }
            if (substance2.Text == "Водород бромистый")
            {
                jid2.Visible = true;
                gaz2.Visible = true;
            }
            if (substance2.Text == "Сероводород")
            {
                jid2.Visible = true;
                gaz2.Visible = true;
            }
            if (substance2.Text == "Фосген")
            {
                jid2.Visible = true;
                gaz2.Visible = true;
            }
            if (substance2.Text == "Фтор")
            {
                jid2.Visible = true;
                gaz2.Visible = true;
            }
            if (substance2.Text == "Хлорициан")
            {
                jid2.Visible = true;
                gaz2.Visible = true;
            }
            if (substance2.Text == "Водород фтористый")
            {
                jid2.Visible = false;
                gaz2.Visible = false;
            }
            if (substance2.Text == "Водород цианистый")
            {
                jid2.Visible = false;
                gaz2.Visible = false;
            }
            if (substance2.Text == "Двуокись азота")
            {
                jid2.Visible = false;
                gaz2.Visible = false;
            }
            if (substance2.Text == "Сернистый ангидрид")
            {
                jid2.Visible = false;
                gaz2.Visible = false;
            }
            if (substance2.Text == "Сероуглерод")
            {
                jid2.Visible = false;
                gaz2.Visible = false;
            }
            if (substance2.Text == "Соляная кислота")
            {
                jid2.Visible = false;
                gaz2.Visible = false;
            }
            if (substance2.Text == "Формальдегид")
            {
                jid2.Visible = false;
                gaz2.Visible = false;
            }
        }
        public void substance3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Присваивание параметров АХОВ3
            /////////////////////////////////////////////
            if (substance3.Text == "")
            {
                jid3.Visible = false;
                gaz3.Visible = false;
            }
            if (substance3.Text == "Хлор")
            {
                jid3.Visible = true;
                gaz3.Visible = true;
            }
            if (substance3.Text == "Аммиак")
            {
                jid3.Visible = true;
                gaz3.Visible = true;
            }
            if (substance3.Text == "Водород хлористый")
            {
                jid3.Visible = true;
                gaz3.Visible = true;
            }
            if (substance3.Text == "Водород бромистый")
            {
                jid3.Visible = true;
                gaz3.Visible = true;
            }
            if (substance3.Text == "Сероводород")
            {
                jid3.Visible = true;
                gaz3.Visible = true;
            }
            if (substance3.Text == "Фосген")
            {
                jid3.Visible = true;
                gaz3.Visible = true;
            }
            if (substance3.Text == "Фтор")
            {
                jid3.Visible = true;
                gaz3.Visible = true;
            }
            if (substance3.Text == "Хлорициан")
            {
                jid3.Visible = true;
                gaz3.Visible = true;
            }
            if (substance3.Text == "Водород фтористый")
            {
                jid3.Visible = false;
                gaz3.Visible = false;
            }
            if (substance3.Text == "Водород цианистый")
            {
                jid3.Visible = false;
                gaz3.Visible = false;
            }
            if (substance3.Text == "Двуокись азота")
            {
                jid3.Visible = false;
                gaz3.Visible = false;
            }
            if (substance3.Text == "Сернистый ангидрид")
            {
                jid3.Visible = false;
                gaz3.Visible = false;
            }
            if (substance3.Text == "Сероуглерод")
            {
                jid3.Visible = false;
                gaz3.Visible = false;
            }
            if (substance3.Text == "Соляная кислота")
            {
                jid3.Visible = false;
                gaz3.Visible = false;
            }
            if (substance3.Text == "Формальдегид")
            {
                jid3.Visible = false;
                gaz3.Visible = false;
            }
        }
        public void substance4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Присваивание параметров АХОВ4
            ////////////////////////////////////////
            if (substance4.Text == "")
            {
                jid4.Visible = false;
                gaz4.Visible = false;
            }
            if (substance4.Text == "Хлор")
            {
                jid4.Visible = true;
                gaz4.Visible = true;
            }
            if (substance4.Text == "Аммиак")
            {
                jid4.Visible = true;
                gaz4.Visible = true;
            }
            if (substance4.Text == "Водород хлористый")
            {
                jid4.Visible = true;
                gaz4.Visible = true;
            }
            if (substance4.Text == "Водород бромистый")
            {
                jid4.Visible = true;
                gaz4.Visible = true;
            }
            if (substance4.Text == "Сероводород")
            {
                jid4.Visible = true;
                gaz4.Visible = true;
            }
            if (substance4.Text == "Фосген")
            {
                jid4.Visible = true;
                gaz4.Visible = true;
            }
            if (substance4.Text == "Фтор")
            {
                jid4.Visible = true;
                gaz4.Visible = true;
            }
            if (substance4.Text == "Хлорициан")
            {
                jid4.Visible = true;
                gaz4.Visible = true;
            }
            if (substance4.Text == "Водород фтористый")
            {
                jid4.Visible = false;
                gaz4.Visible = false;
            }
            if (substance4.Text == "Водород цианистый")
            {
                jid4.Visible = false;
                gaz4.Visible = false;
            }
            if (substance4.Text == "Двуокись азота")
            {
                jid4.Visible = false;
                gaz4.Visible = false;
            }
            if (substance4.Text == "Сернистый ангидрид")
            {
                jid4.Visible = false;
                gaz4.Visible = false;
            }
            if (substance4.Text == "Сероуглерод")
            {
                jid4.Visible = false;
                gaz4.Visible = false;
            }
            if (substance4.Text == "Соляная кислота")
            {
                jid4.Visible = false;
                gaz4.Visible = false;
            }
            if (substance4.Text == "Формальдегид")
            {
                jid4.Visible = false;
                gaz4.Visible = false;
            }
        }
        public void substance5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Присваивание параметров АХОВ5
            ////////////////////////////////////////////
            if (substance5.Text == "")
            {
                jid5.Visible = false;
                gaz5.Visible = false;
            }
            if (substance5.Text == "Хлор")
            {
                jid5.Visible = true;
                gaz5.Visible = true;
            }
            if (substance5.Text == "Аммиак")
            {
                jid5.Visible = true;
                gaz5.Visible = true;
            }
            if (substance5.Text == "Водород хлористый")
            {
                jid5.Visible = true;
                gaz5.Visible = true;
            }
            if (substance5.Text == "Водород бромистый")
            {
                jid5.Visible = true;
                gaz5.Visible = true;
            }
            if (substance5.Text == "Сероводород")
            {
                jid5.Visible = true;
                gaz5.Visible = true;
            }
            if (substance5.Text == "Фосген")
            {
                jid5.Visible = true;
                gaz5.Visible = true;
            }
            if (substance5.Text == "Фтор")
            {
                jid5.Visible = true;
                gaz5.Visible = true;
            }
            if (substance5.Text == "Хлорициан")
            {
                jid5.Visible = true;
                gaz5.Visible = true;
            }
            if (substance5.Text == "Водород фтористый")
            {
                jid5.Visible = false;
                gaz5.Visible = false;
            }
            if (substance5.Text == "Водород цианистый")
            {
                jid5.Visible = false;
                gaz5.Visible = false;
            }
            if (substance5.Text == "Двуокись азота")
            {
                jid5.Visible = false;
                gaz5.Visible = false;
            }
            if (substance5.Text == "Сернистый ангидрид")
            {
                jid5.Visible = false;
                gaz5.Visible = false;
            }
            if (substance5.Text == "Сероуглерод")
            {
                jid5.Visible = false;
                gaz5.Visible = false;
            }
            if (substance5.Text == "Соляная кислота")
            {
                jid5.Visible = false;
                gaz5.Visible = false;
            }
            if (substance5.Text == "Формальдегид")
            {
                jid5.Visible = false;
                gaz5.Visible = false;
            }
        }
        public void substance6_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Присваивание параметров АХОВ6
            /////////////////////////////////////////
            if (substance6.Text == "")
            {
                jid6.Visible = false;
                gaz6.Visible = false;
            }
            if (substance6.Text == "Хлор")
            {
                jid6.Visible = true;
                gaz6.Visible = true;
            }
            if (substance6.Text == "Аммиак")
            {
                jid6.Visible = true;
                gaz6.Visible = true;
            }
            if (substance6.Text == "Водород хлористый")
            {
                jid6.Visible = true;
                gaz6.Visible = true;
            }
            if (substance6.Text == "Водород бромистый")
            {
                jid6.Visible = true;
                gaz6.Visible = true;
            }
            if (substance6.Text == "Сероводород")
            {
                jid6.Visible = true;
                gaz6.Visible = true;
            }
            if (substance6.Text == "Фосген")
            {
                jid6.Visible = true;
                gaz6.Visible = true;
            }
            if (substance6.Text == "Фтор")
            {
                jid6.Visible = true;
                gaz6.Visible = true;
            }
            if (substance6.Text == "Хлорициан")
            {
                jid6.Visible = true;
                gaz6.Visible = true;
            }
            if (substance6.Text == "Водород фтористый")
            {
                jid6.Visible = false;
                gaz6.Visible = false;
            }
            if (substance6.Text == "Водород цианистый")
            {
                jid6.Visible = false;
                gaz6.Visible = false;
            }
            if (substance6.Text == "Двуокись азота")
            {
                jid6.Visible = false;
                gaz6.Visible = false;
            }
            if (substance6.Text == "Сернистый ангидрид")
            {
                jid6.Visible = false;
                gaz6.Visible = false;
            }
            if (substance6.Text == "Сероуглерод")
            {
                jid6.Visible = false;
                gaz6.Visible = false;
            }
            if (substance6.Text == "Соляная кислота")
            {
                jid6.Visible = false;
                gaz6.Visible = false;
            }
            if (substance6.Text == "Формальдегид")
            {
                jid6.Visible = false;
                gaz6.Visible = false;
            }
        }
        public void RASCHETbutt_Click(object sender, EventArgs e)
        {
            //Определение случаев когда пользователь не ввел значения в текстовые поля
            if (distance.Text == "") { X = 0; }
            else { X = Convert.ToDouble(distance.Text); }
            ///
            if (visPod.Text == "") { H = 0; }
            ///
            if (ploshlabel.Text == "") { F = 0; }
            ///
            if (outAXOB.Text == "") { Q0 = 0; }
            else { Q0 = Convert.ToDouble(outAXOB.Text); }
            ///
            if (outAXOB2.Text == "") { Q02 = 0; }
            else { Q02 = Convert.ToDouble(outAXOB2.Text); }
            ///
            if (outAXOB3.Text == "") { Q03 = 0; }
            else { Q03 = Convert.ToDouble(outAXOB3.Text); }
            ///
            if (outAXOB4.Text == "") { Q04 = 0; }
            else { Q04 = Convert.ToDouble(outAXOB4.Text); }
            ///
            if (outAXOB5.Text == "") { Q05 = 0; }
            else { Q05 = Convert.ToDouble(outAXOB5.Text); }
            ///
            if (outAXOB6.Text == "") { Q06 = 0; }
            else { Q06 = Convert.ToDouble(outAXOB6.Text); }
            ///
            if (time.Text == "") { N = 4; }
            else { N = Convert.ToDouble(time.Text); }
            ///
            if (speedAir.Text == "") { v = 3; }
            else { v = Convert.ToDouble(speedAir.Text); }
            ///
            if (tempAir.Text == "") { t = 20; }
            else { t = Convert.ToDouble(tempAir.Text); }
            //////
            if (plotNasG.Text == "") { Ag = 0; }
            else { Ag = Convert.ToDouble(plotNasG.Text); }
            ///
            if (plotNasZ.Text == "") { Az = 0; }
            else { Az = Convert.ToDouble(plotNasZ.Text); }
            ///
            if (outGAZG.Text == "") { n1g = 0; }
            else { n1g = Convert.ToDouble(outGAZG.Text); }
            ///
            if (outGAZZ.Text == "") { n1z = 0; }
            else { n1z = Convert.ToDouble(outGAZZ.Text); }
            ///
            if (outubejG.Text == "") { n2g = 0; }
            else { n2g = Convert.ToDouble(outubejG.Text); }
            ///
            if (outubejZ.Text == "") { n2z = 0; }
            else { n2z = Convert.ToDouble(outubejZ.Text); }
            //Угловые размеры возможного заражения АХОВ
            if (v <= 0.5) { f = 360; }
            if ((v > 0.5) && (v <= 1)) { f = 180; }
            if ((v > 1) && (v <= 2)) { f = 90; }
            if (v > 2) { f = 45; }
            //Присваивание параметров для вертикальной устойчивости атмосферы
            if (vertUst.Text == "Инверсия")
            {
                K5 = 1.0;
                Kv = 0.081;
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
                Kv = 0.0133;
                if (v <= 1)
                {
                    W = 6;
                }
                if ((v > 1) && (v <= 2))
                {
                    W = 12;
                }
                if ((v > 2) && (v <= 3))
                {
                    W = 18;
                }
                if ((v > 3) && (v <= 4))
                {
                    W = 24;
                }
                if ((v > 4) && (v <= 5))
                {
                    W = 29;
                }
                if ((v > 5) && (v <= 6))
                {
                    W = 35;
                }
                if ((v > 6) && (v <= 7))
                {
                    W = 41;
                }
                if ((v > 7) && (v <= 8))
                {
                    W = 47;
                }
                if ((v > 8) && (v <= 9))
                {
                    W = 53;
                }
                if ((v > 9) && (v <= 10))
                {
                    W = 59;
                }
                if ((v > 10) && (v <= 11))
                {
                    W = 65;
                }
                if ((v > 11) && (v <= 12))
                {
                    W = 71;
                }
                if ((v > 12) && (v <= 13))
                {
                    W = 76;
                }
                if ((v > 13) && (v <= 14))
                {
                    W = 82;
                }
                if (v > 14)
                {
                    W = 88;
                }
            }
            if (vertUst.Text == "Конвекция")
            {
                K5 = 0.08;
                Kv = 0.235;
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
            //Выбор химически опасного вещества
            if (substance.Text == "Хлор")
            {
                substanceAXOB.Chlor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid.Checked)
                {
                    p = 1.553;
                    if (t < tkip) { K7 = K72; }
                }
                if (gaz.Checked)
                {
                    p = 0.0032;
                }
            }
            if (substance.Text == "Аммиак")
            {
                substanceAXOB.Ammiak();
                //Выбор АХОВ с агрегатным состоянием
                if (jid.Checked)
                {
                    p = 1.553;
                    if (t < tkip) { K7 = K72; }
                }
                if (gaz.Checked)
                {
                    p = 0.0032;
                }
            }
            if (substance.Text == "Водород фтористый")
            {
                substanceAXOB.VodorodFtoristiy();
            }
            if (substance.Text == "Водород хлористый")
            {
                substanceAXOB.VodorodChlor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid.Checked)
                {
                    p = 1.191;
                    if (t < tkip) { K7 = K72; }
                }
                if (gaz.Checked)
                {
                    p = 0.0016;
                }
            }
            if (substance.Text == "Водород бромистый")
            {
                substanceAXOB.VodorodBrom();
                //Выбор АХОВ с агрегатным состоянием
                if (jid.Checked)
                {
                    p = 1.49;
                    if (t < tkip) { K7 = K72; }
                }
                if (gaz.Checked)
                {
                    p = 0.0036;
                }
            }
            if (substance.Text == "Водород цианистый")
            {
                substanceAXOB.VodorodCianistiy();
            }
            if (substance.Text == "Двуокись азота")
            {
                substanceAXOB.DvuokisAzota();
            }
            if (substance.Text == "Сернистый ангидрид")
            {
                substanceAXOB.SernistiyAngidrid();
            }
            if (substance.Text == "Сероводород")
            {
                substanceAXOB.Serovodorod();
            }
            if (substance.Text == "Сероуглерод")
            {
                substanceAXOB.Serouglerod();
            }
            if (substance.Text == "Соляная кислота")
            {
                substanceAXOB.SolyanayaKislota();
            }
            if (substance.Text == "Формальдегид")
            {
                substanceAXOB.Formaldegid();
            }
            if (substance.Text == "Фосген")
            {
                substanceAXOB.Fosgen();
                //Выбор АХОВ с агрегатным состоянием
                if (jid.Checked)
                {
                    p = 1.432;
                    if (t < tkip) { K7 = K72; }
                }
                if (gaz.Checked)
                {
                    p = 0.0035;
                }
            }
            if (substance.Text == "Фтор")
            {
                substanceAXOB.Ftor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid.Checked)
                {
                    p = 1.512;
                    if (t < tkip) { K7 = K72; }
                }
                if (gaz.Checked)
                {
                    p = 0.0017;
                }
            }
            if (substance.Text == "Хлорциан")
            {
                substanceAXOB.Chlorician();
                //Выбор АХОВ с агрегатным состоянием
                if (jid.Checked)
                {
                    p = 1.22;
                    if (t < tkip) { K7 = K72; }
                }
                if (gaz.Checked)
                {
                    p = 0.0021;
                }
            }
            /////////////////////////////////////////
            //Выбор химически опасного вещества2/////
            /////////////////////////////////////////
            if (substance2.Text == "Хлор")
            {
                substanceAXOB2.Chlor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid2.Checked)
                {
                    p2 = 1.553;
                    if (t < tkip2) { K712 = K722; }
                }
                if (gaz2.Checked)
                {
                    p2 = 0.0032;
                }
            }
            if (substance2.Text == "Аммиак")
            {
                substanceAXOB2.Ammiak();
                //Выбор АХОВ с агрегатным состоянием
                if (jid2.Checked)
                {
                    p2 = 1.553;
                    if (t < tkip2) { K712 = K722; }
                }
                if (gaz2.Checked)
                {
                    p2 = 0.0032;
                }
            }
            if (substance2.Text == "Водород фтористый")
            {
                substanceAXOB2.VodorodFtoristiy();
            }
            if (substance2.Text == "Водород хлористый")
            {
                substanceAXOB2.VodorodChlor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid2.Checked)
                {
                    p2 = 1.191;
                    if (t < tkip2) { K7 = K72; }
                }
                if (gaz2.Checked)
                {
                    p2 = 0.0016;
                }
            }
            if (substance2.Text == "Водород бромистый")
            {
                substanceAXOB2.VodorodBrom();
                //Выбор АХОВ с агрегатным состоянием
                if (jid2.Checked)
                {
                    p2 = 1.49;
                    if (t < tkip2) { K712 = K722; }
                }
                if (gaz2.Checked)
                {
                    p2 = 0.0036;
                }
            }
            if (substance2.Text == "Водород цианистый")
            {
                substanceAXOB2.VodorodCianistiy();
            }
            if (substance.Text == "Двуокись азота")
            {
                substanceAXOB2.DvuokisAzota();
            }
            if (substance.Text == "Сернистый ангидрид")
            {
                substanceAXOB2.SernistiyAngidrid();
            }
            if (substance2.Text == "Сероводород")
            {
                substanceAXOB2.Serovodorod();
            }
            if (substance2.Text == "Сероуглерод")
            {
                substanceAXOB2.Serouglerod();
            }
            if (substance2.Text == "Соляная кислота")
            {
                substanceAXOB2.SolyanayaKislota();
            }
            if (substance2.Text == "Формальдегид")
            {
                substanceAXOB2.Formaldegid();
            }
            if (substance2.Text == "Фосген")
            {
                substanceAXOB2.Fosgen();
                //Выбор АХОВ с агрегатным состоянием
                if (jid2.Checked)
                {
                    p2 = 1.432;
                    if (t < tkip2) { K712 = K722; }
                }
                if (gaz2.Checked)
                {
                    p2 = 0.0035;
                }
            }
            if (substance2.Text == "Фтор")
            {
                substanceAXOB2.Ftor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid2.Checked)
                {
                    p2 = 1.512;
                    if (t < tkip2) { K712 = K722; }
                }
                if (gaz2.Checked)
                {
                    p2 = 0.0017;
                }
            }
            if (substance2.Text == "Хлорциан")
            {
                substanceAXOB2.Chlorician();
                //Выбор АХОВ с агрегатным состоянием
                if (jid2.Checked)
                {
                    p2 = 1.22;
                    if (t < tkip2) { K712 = K722; }
                }
                if (gaz2.Checked)
                {
                    p2 = 0.0021;
                }
            }
            ///////////////////////////////////////////////
            //Выбор химически опасного вещества3///////////
            ///////////////////////////////////////////////
            if (substance3.Text == "Хлор")
            {
                substanceAXOB3.Chlor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid3.Checked)
                {
                    p3 = 1.553;
                    if (t < tkip3) { K73 = K723; }
                }
                if (gaz3.Checked)
                {
                    p3 = 0.0032;
                }
            }
            if (substance3.Text == "Аммиак")
            {
                substanceAXOB3.Ammiak();
                //Выбор АХОВ с агрегатным состоянием
                if (jid3.Checked)
                {
                    p3 = 1.553;
                    if (t < tkip3) { K73 = K723; }
                }
                if (gaz3.Checked)
                {
                    p3 = 0.0032;
                }
            }
            if (substance3.Text == "Водород фтористый")
            {
                substanceAXOB3.VodorodFtoristiy();
            }
            if (substance3.Text == "Водород хлористый")
            {
                substanceAXOB3.VodorodChlor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid3.Checked)
                {
                    p3 = 1.191;
                    if (t < tkip3) { K73 = K723; }
                }
                if (gaz3.Checked)
                {
                    p3 = 0.0016;
                }
            }
            if (substance3.Text == "Водород бромистый")
            {
                substanceAXOB3.VodorodBrom();
                //Выбор АХОВ с агрегатным состоянием
                if (jid3.Checked)
                {
                    p3 = 1.49;
                    if (t < tkip3) { K73 = K723; }
                }
                if (gaz3.Checked)
                {
                    p3 = 0.0036;
                }
            }
            if (substance3.Text == "Водород цианистый")
            {
                substanceAXOB3.VodorodCianistiy();
            }
            if (substance3.Text == "Двуокись азота")
            {
                substanceAXOB3.DvuokisAzota();
            }
            if (substance.Text == "Сернистый ангидрид")
            {
                substanceAXOB3.SernistiyAngidrid();
            }
            if (substance3.Text == "Сероводород")
            {
                substanceAXOB3.Serovodorod();
            }
            if (substance3.Text == "Сероуглерод")
            {
                substanceAXOB3.Serouglerod();
            }
            if (substance3.Text == "Соляная кислота")
            {
                substanceAXOB3.SolyanayaKislota();
            }
            if (substance3.Text == "Формальдегид")
            {
                substanceAXOB3.Formaldegid();
            }
            if (substance3.Text == "Фосген")
            {
                substanceAXOB3.Fosgen();
                //Выбор АХОВ с агрегатным состоянием
                if (jid3.Checked)
                {
                    p3 = 1.432;
                    if (t < tkip3) { K73 = K723; }
                }
                if (gaz3.Checked)
                {
                    p3 = 0.0035;
                }
            }
            if (substance3.Text == "Фтор")
            {
                substanceAXOB3.Ftor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid3.Checked)
                {
                    p3 = 1.512;
                    if (t < tkip3) { K73 = K723; }
                }
                if (gaz3.Checked)
                {
                    p3 = 0.0017;
                }
            }
            if (substance3.Text == "Хлорциан")
            {
                substanceAXOB3.Chlorician();
                //Выбор АХОВ с агрегатным состоянием
                if (jid3.Checked)
                {
                    p3 = 1.22;
                    if (t < tkip3) { K73 = K723; }
                }
                if (gaz3.Checked)
                {
                    p3 = 0.0021;
                }
            }
            ///////////////////////////////////////////////
            //Выбор химически опасного вещества4///////////
            ///////////////////////////////////////////////

            ///////////////////////////////////////////////
            //Выбор химически опасного вещества5///////////
            ///////////////////////////////////////////////

            ///////////////////////////////////////////////
            //Выбор химически опасного вещества6///////////
            ///////////////////////////////////////////////

            ///////////////////////////////////////////////////
            //Расчет высоты/площади поддона
            if (sam.Checked == true)
            {
                if (visPod.Text == "") { H = 0; }
                else
                {
                    H = Convert.ToDouble(visPod.Text);
                }
                h = H - 0.2;
            }
            if (obsh.Checked == true)
            {
                if (plosh.Text == "") { F = 0; }
                else
                {
                    F = Convert.ToDouble(plosh.Text);
                }
                h = Q0 / F * p;
            }
            //Расчет для одного вещества
            /////////////////////////////
            if (AXOBkolvo2.Checked)
            {
                //Коэффициенты К2, К3 и К4
                K2 = 6.08 * Math.Pow(10, -5) * P * Math.Pow(M, 0.5);
                K3 = Dhlor / D;
                if (D == 0) { K3 = 0; }
                K4 = v / 3 + 0.67;
                //Определение эквивалентного количества вещества по первичному облаку
                Qe1 = K1 * K3 * K5 * K7 * Q0;
                //Время испарения АХОВ
                if (gaz.Checked) { T = 0; }
                else
                {
                    T = (h * p) / (K2 * K4 * K72);
                }
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
            }
            //Расчет для нескольких веществ
            ////////////////////////////////
            if (AXOBkolvo2.Checked)
            {
                //Коэффициенты К2, К3 и К4
                K21 = 6.08 * Math.Pow(10, -5) * Pi1 * Math.Pow(M1, 0.5);
                K22 = 6.08 * Math.Pow(10, -5) * Pi2 * Math.Pow(M2, 0.5);
                K23 = 6.08 * Math.Pow(10, -5) * Pi3 * Math.Pow(M3, 0.5);
                K24 = 6.08 * Math.Pow(10, -5) * Pi4 * Math.Pow(M4, 0.5);
                K25 = 6.08 * Math.Pow(10, -5) * Pi5 * Math.Pow(M5, 0.5);
                K26 = 6.08 * Math.Pow(10, -5) * Pi6 * Math.Pow(M6, 0.5);
                K31 = Dhlor / D1;
                K32 = Dhlor / D2;
                K33 = Dhlor / D3;
                K34 = Dhlor / D4;
                K35 = Dhlor / D5;
                K36 = Dhlor / D6;
                if (D1 == 0) { K31 = 0; }
                if (D2 == 0) { K32 = 0; }
                if (D3 == 0) { K33 = 0; }
                if (D4 == 0) { K34 = 0; }
                if (D5 == 0) { K35 = 0; }
                if (D6 == 0) { K36 = 0; }
                //Время испарения АХОВ1
                if (gaz1.Checked) { T1 = 0; }
                else
                {
                    T1 = (h * p1) / (K21 * K4 * K721);
                }
                //Определение коэффициента К6
                if (N < T1)
                {
                    K61 = Math.Pow(N, 0.8);
                }
                if (N > T2)
                {
                    K61 = Math.Pow(T1, 0.8);
                }
                if (T1 < 1)
                {
                    K61 = 1;
                }
                //Время испарения АХОВ2
                if (gaz2.Checked) { T2 = 0; }
                else
                {
                    T2 = (h * p2) / (K22 * K4 * K722);
                }
                //Определение коэффициента К6
                if (N < T2)
                {
                    K62 = Math.Pow(N, 0.8);
                }
                if (N > T2)
                {
                    K62 = Math.Pow(T2, 0.8);
                }
                if (T2 < 1)
                {
                    K62 = 1;
                }
                //Время испарения АХОВ3
                if (gaz3.Checked) { T3 = 0; }
                else
                {
                    T3 = (h * p3) / (K23 * K4 * K723);
                }
                //Определение коэффициента К6
                if (N < T3)
                {
                    K63 = Math.Pow(N, 0.8);
                }
                if (N > T3)
                {
                    K63 = Math.Pow(T3, 0.8);
                }
                if (T3 < 1)
                {
                    K63 = 1;
                }
                //Время испарения АХОВ4
                if (gaz4.Checked) { T4 = 0; }
                else
                {
                    T4 = (h * p4) / (K24 * K4 * K724);
                }
                //Определение коэффициента К6
                if (N < T4)
                {
                    K64 = Math.Pow(N, 0.8);
                }
                if (N > T4)
                {
                    K64 = Math.Pow(T4, 0.8);
                }
                if (T4 < 1)
                {
                    K64 = 1;
                }
                //Время испарения АХОВ5
                if (gaz5.Checked) { T5 = 0; }
                else
                {
                    T5 = (h * p5) / (K25 * K4 * K725);
                }
                //Определение коэффициента К6
                if (N < T5)
                {
                    K65 = Math.Pow(N, 0.8);
                }
                if (N > T5)
                {
                    K65 = Math.Pow(T5, 0.8);
                }
                if (T5 < 1)
                {
                    K65 = 1;
                }
                //Время испарения АХОВ6
                if (gaz6.Checked) { T6 = 0; }
                else
                {
                    T6 = (h * p6) / (K26 * K4 * K726);
                }
                //Определение коэффициента К6
                if (N < T6)
                {
                    K66 = Math.Pow(N, 0.8);
                }
                if (N > T6)
                {
                    K66 = Math.Pow(T6, 0.8);
                }
                if (T6 < 1)
                {
                    K66 = 1;
                }
                ////Определение эквивалентного количества вещества по нескольким веществам
                Qe2 = (20 * K4 * K5) * (((K2 * K3 * K6 * K7 * Q0) / p + K22 * K32 * K62 * K72 * Q02) / p2 +
                    (K23 * K33 * K63 * K73 * Q03) / p3 + (K24 * K34 * K64 * K74 * Q04) / p4 +
                    (K25 * K35 * K65 * K75 * Q05) / p5 + (K26 * K36 * K66 * K76 * Q06) / p6);
                Qe1 = Qe2;
            }
            //Определение большего и меньшего кол-ва АХОВ и глубины заражения облаками 
            if ((v >= 1) && (v < 1))
            {
                if ((Qe1 >= 0.01) && (Qe1 < 0.05)) { Gb1 = 0.85; Gm1 = 0.38; Qb1 = 0.05; Qm1 = 0.01; }
                if ((Qe2 >= 0.01) && (Qe2 < 0.05)) { Gb2 = 0.85; Gm2 = 0.38; Qb2 = 0.05; Qm2 = 0.01; }
                if ((Qe1 >= 0.05) && (Qe1 < 0.1)) { Gb1 = 1.25; Gm1 = 0.85; Qb1 = 0.1; Qm1 = 0.05; }
                if ((Qe2 >= 0.05) && (Qe2 < 0.1)) { Gb2 = 1.25; Gm2 = 0.85; Qb2 = 0.1; Qm2 = 0.05; }
                if ((Qe1 >= 0.1) && (Qe1 < 0.5)) { Gb1 = 3.16; Gm1 = 1.25; Qb1 = 0.5; Qm1 = 0.1; }
                if ((Qe2 >= 0.1) && (Qe2 < 0.5)) { Gb2 = 3.16; Gm2 = 1.25; Qb2 = 0.5; Qm2 = 0.1; }
                if ((Qe1 >= 0.5) && (Qe1 < 1)) { Gb1 = 4.75; Gm1 = 3.16; Qb1 = 1; Qm1 = 0.5; }
                if ((Qe2 >= 0.5) && (Qe2 < 1)) { Gb2 = 4.75; Gm2 = 3.16; Qb2 = 1; Qm2 = 0.5; }
                if ((Qe1 >= 1) && (Qe1 < 3)) { Gb1 = 9.18; Gm1 = 4.75; Qb1 = 3; Qm1 = 1; }
                if ((Qe2 >= 1) && (Qe2 < 3)) { Gb2 = 9.18; Gm2 = 4.75; Qb2 = 3; Qm2 = 1; }
                if ((Qe1 >= 3) && (Qe1 < 5)) { Gb1 = 12.53; Gm1 = 9.18; Qb1 = 5; Qm1 = 3; }
                if ((Qe2 >= 3) && (Qe2 < 5)) { Gb2 = 12.53; Gm2 = 9.18; Qb2 = 5; Qm2 = 3; }
                if ((Qe1 >= 5) && (Qe1 < 10)) { Gb1 = 19.2; Gm1 = 12.53; Qb1 = 10; Qm1 = 5; }
                if ((Qe2 >= 5) && (Qe2 < 10)) { Gb2 = 19.2; Gm2 = 12.53; Qb2 = 10; Qm2 = 5; }
                if ((Qe1 >= 10) && (Qe1 < 20)) { Gb1 = 29.56; Gm1 = 19.2; Qb1 = 20; Qm1 = 10; }
                if ((Qe2 >= 10) && (Qe2 < 20)) { Gb2 = 29.56; Gm2 = 19.2; Qb2 = 20; Qm2 = 10; }
                if ((Qe1 >= 20) && (Qe1 < 30)) { Gb1 = 38.13; Gm1 = 29.56; Qb1 = 30; Qm1 = 20; }
                if ((Qe2 >= 20) && (Qe2 < 30)) { Gb2 = 38.13; Gm2 = 29.56; Qb2 = 30; Qm2 = 20; }
                if ((Qe1 >= 30) && (Qe1 < 50)) { Gb1 = 52.67; Gm1 = 38.13; Qb1 = 50; Qm1 = 30; }
                if ((Qe2 >= 30) && (Qe2 < 50)) { Gb2 = 52.67; Gm2 = 38.13; Qb2 = 50; Qm2 = 30; }
                if ((Qe1 >= 50) && (Qe1 < 70)) { Gb1 = 65.23; Gm1 = 52.67; Qb1 = 70; Qm1 = 50; }
                if ((Qe2 >= 50) && (Qe2 < 70)) { Gb2 = 65.23; Gm2 = 52.67; Qb2 = 70; Qm2 = 50; }
                if ((Qe1 >= 70) && (Qe1 < 100)) { Gb1 = 81.91; Gm1 = 65.23; Qb1 = 100; Qm1 = 70; }
                if ((Qe2 >= 70) && (Qe2 < 100)) { Gb2 = 81.91; Gm2 = 65.23; Qb2 = 100; Qm2 = 70; }
                if ((Qe1 >= 100) && (Qe1 < 300)) { Gb1 = 166; Gm1 = 81.91; Qb1 = 300; Qm1 = 100; }
                if ((Qe2 >= 100) && (Qe2 < 300)) { Gb2 = 166; Gm2 = 81.91; Qb2 = 300; Qm2 = 100; }
                if ((Qe1 >= 300) && (Qe1 < 500)) { Gb1 = 231; Gm1 = 166; Qb1 = 500; Qm1 = 300; }
                if ((Qe2 >= 300) && (Qe2 < 500)) { Gb2 = 231; Gm2 = 166; Qb2 = 500; Qm2 = 300; }
                if ((Qe1 >= 500) && (Qe1 < 1000)) { Gb1 = 363; Gm1 = 231; Qb1 = 1000; Qm1 = 500; }
                if ((Qe2 >= 500) && (Qe2 < 1000)) { Gb2 = 363; Gm2 = 231; Qb2 = 1000; Qm2 = 500; }
            }
            if (v >= 2)
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
            if (v >= 3)
            {
                if ((Qe1 >= 0.01) && (Qe1 < 0.05)) { Gb1 = 0.48; Gm1 = 0.22; Qb1 = 0.05; Qm1 = 0.01; }
                if ((Qe2 >= 0.01) && (Qe2 < 0.05)) { Gb2 = 0.48; Gm2 = 0.22; Qb2 = 0.05; Qm2 = 0.01; }
                if ((Qe1 >= 0.05) && (Qe1 < 0.1)) { Gb1 = 0.68; Gm1 = 0.48; Qb1 = 0.1; Qm1 = 0.05; }
                if ((Qe2 >= 0.05) && (Qe2 < 0.1)) { Gb2 = 0.68; Gm2 = 0.48; Qb2 = 0.1; Qm2 = 0.05; }
                if ((Qe1 >= 0.1) && (Qe1 < 0.5)) { Gb1 = 1.53; Gm1 = 0.68; Qb1 = 0.5; Qm1 = 0.1; }
                if ((Qe2 >= 0.1) && (Qe2 < 0.5)) { Gb2 = 1.53; Gm2 = 0.68; Qb2 = 0.5; Qm2 = 0.1; }
                if ((Qe1 >= 0.5) && (Qe1 < 1)) { Gb1 = 2.17; Gm1 = 1.53; Qb1 = 1; Qm1 = 0.5; }
                if ((Qe2 >= 0.5) && (Qe2 < 1)) { Gb2 = 2.17; Gm2 = 1.53; Qb2 = 1; Qm2 = 0.5; }
                if ((Qe1 >= 1) && (Qe1 < 3)) { Gb1 = 3.99; Gm1 = 2.17; Qb1 = 3; Qm1 = 1; }
                if ((Qe2 >= 1) && (Qe2 < 3)) { Gb2 = 3.99; Gm2 = 2.17; Qb2 = 3; Qm2 = 1; }
                if ((Qe1 >= 3) && (Qe1 < 5)) { Gb1 = 5.34; Gm1 = 3.99; Qb1 = 5; Qm1 = 3; }
                if ((Qe2 >= 3) && (Qe2 < 5)) { Gb2 = 5.34; Gm2 = 3.99; Qb2 = 5; Qm2 = 3; }
                if ((Qe1 >= 5) && (Qe1 < 10)) { Gb1 = 7.96; Gm1 = 5.34; Qb1 = 10; Qm1 = 5; }
                if ((Qe2 >= 5) && (Qe2 < 10)) { Gb2 = 7.96; Gm2 = 5.34; Qb2 = 10; Qm2 = 5; }
                if ((Qe1 >= 10) && (Qe1 < 20)) { Gb1 = 11.94; Gm1 = 7.96; Qb1 = 20; Qm1 = 10; }
                if ((Qe2 >= 10) && (Qe2 < 20)) { Gb2 = 11.94; Gm2 = 7.96; Qb2 = 20; Qm2 = 10; }
                if ((Qe1 >= 20) && (Qe1 < 30)) { Gb1 = 15.18; Gm1 = 11.94; Qb1 = 30; Qm1 = 20; }
                if ((Qe2 >= 20) && (Qe2 < 30)) { Gb2 = 15.18; Gm2 = 11.94; Qb2 = 30; Qm2 = 20; }
                if ((Qe1 >= 30) && (Qe1 < 50)) { Gb1 = 20.59; Gm1 = 15.18; Qb1 = 50; Qm1 = 30; }
                if ((Qe2 >= 30) && (Qe2 < 50)) { Gb2 = 20.59; Gm2 = 15.18; Qb2 = 50; Qm2 = 30; }
                if ((Qe1 >= 50) && (Qe1 < 70)) { Gb1 = 25.21; Gm1 = 20.59; Qb1 = 70; Qm1 = 50; }
                if ((Qe2 >= 50) && (Qe2 < 70)) { Gb2 = 25.21; Gm2 = 20.59; Qb2 = 70; Qm2 = 50; }
                if ((Qe1 >= 70) && (Qe1 < 100)) { Gb1 = 31.30; Gm1 = 25.21; Qb1 = 100; Qm1 = 70; }
                if ((Qe2 >= 70) && (Qe2 < 100)) { Gb2 = 31.30; Gm2 = 25.21; Qb2 = 100; Qm2 = 70; }
                if ((Qe1 >= 100) && (Qe1 < 300)) { Gb1 = 61.47; Gm1 = 31.30; Qb1 = 300; Qm1 = 100; }
                if ((Qe2 >= 100) && (Qe2 < 300)) { Gb2 = 61.47; Gm2 = 31.30; Qb2 = 300; Qm2 = 100; }
                if ((Qe1 >= 300) && (Qe1 < 500)) { Gb1 = 84.5; Gm1 = 61.47; Qb1 = 500; Qm1 = 300; }
                if ((Qe2 >= 300) && (Qe2 < 500)) { Gb2 = 84.5; Gm2 = 61.47; Qb2 = 500; Qm2 = 300; }
                if ((Qe1 >= 500) && (Qe1 < 1000)) { Gb1 = 130; Gm1 = 84.5; Qb1 = 1000; Qm1 = 500; }
                if ((Qe2 >= 500) && (Qe2 < 1000)) { Gb2 = 130; Gm2 = 84.5; Qb2 = 1000; Qm2 = 500; }
            }
            if (v >= 4)
            {
                if ((Qe1 >= 0.01) && (Qe1 < 0.05)) { Gb1 = 0.42; Gm1 = 0.19; Qb1 = 0.05; Qm1 = 0.01; }
                if ((Qe2 >= 0.01) && (Qe2 < 0.05)) { Gb2 = 0.42; Gm2 = 0.19; Qb2 = 0.05; Qm2 = 0.01; }
                if ((Qe1 >= 0.05) && (Qe1 < 0.1)) { Gb1 = 0.59; Gm1 = 0.42; Qb1 = 0.1; Qm1 = 0.05; }
                if ((Qe2 >= 0.05) && (Qe2 < 0.1)) { Gb2 = 0.59; Gm2 = 0.42; Qb2 = 0.1; Qm2 = 0.05; }
                if ((Qe1 >= 0.1) && (Qe1 < 0.5)) { Gb1 = 1.33; Gm1 = 0.59; Qb1 = 0.5; Qm1 = 0.1; }
                if ((Qe2 >= 0.1) && (Qe2 < 0.5)) { Gb2 = 1.33; Gm2 = 0.59; Qb2 = 0.5; Qm2 = 0.1; }
                if ((Qe1 >= 0.5) && (Qe1 < 1)) { Gb1 = 1.88; Gm1 = 1.33; Qb1 = 1; Qm1 = 0.5; }
                if ((Qe2 >= 0.5) && (Qe2 < 1)) { Gb2 = 1.88; Gm2 = 1.33; Qb2 = 1; Qm2 = 0.5; }
                if ((Qe1 >= 1) && (Qe1 < 3)) { Gb1 = 3.28; Gm1 = 1.88; Qb1 = 3; Qm1 = 1; }
                if ((Qe2 >= 1) && (Qe2 < 3)) { Gb2 = 3.28; Gm2 = 1.88; Qb2 = 3; Qm2 = 1; }
                if ((Qe1 >= 3) && (Qe1 < 5)) { Gb1 = 4.36; Gm1 = 3.28; Qb1 = 5; Qm1 = 3; }
                if ((Qe2 >= 3) && (Qe2 < 5)) { Gb2 = 4.36; Gm2 = 3.28; Qb2 = 5; Qm2 = 3; }
                if ((Qe1 >= 5) && (Qe1 < 10)) { Gb1 = 6.46; Gm1 = 4.36; Qb1 = 10; Qm1 = 5; }
                if ((Qe2 >= 5) && (Qe2 < 10)) { Gb2 = 6.46; Gm2 = 4.36; Qb2 = 10; Qm2 = 5; }
                if ((Qe1 >= 10) && (Qe1 < 20)) { Gb1 = 9.62; Gm1 = 6.46; Qb1 = 20; Qm1 = 10; }
                if ((Qe2 >= 10) && (Qe2 < 20)) { Gb2 = 9.62; Gm2 = 6.46; Qb2 = 20; Qm2 = 10; }
                if ((Qe1 >= 20) && (Qe1 < 30)) { Gb1 = 12.18; Gm1 = 9.62; Qb1 = 30; Qm1 = 20; }
                if ((Qe2 >= 20) && (Qe2 < 30)) { Gb2 = 12.18; Gm2 = 9.62; Qb2 = 30; Qm2 = 20; }
                if ((Qe1 >= 30) && (Qe1 < 50)) { Gb1 = 16.43; Gm1 = 12.18; Qb1 = 50; Qm1 = 30; }
                if ((Qe2 >= 30) && (Qe2 < 50)) { Gb2 = 16.43; Gm2 = 12.18; Qb2 = 50; Qm2 = 30; }
                if ((Qe1 >= 50) && (Qe1 < 70)) { Gb1 = 20.05; Gm1 = 16.43; Qb1 = 70; Qm1 = 50; }
                if ((Qe2 >= 50) && (Qe2 < 70)) { Gb2 = 20.05; Gm2 = 16.43; Qb2 = 70; Qm2 = 50; }
                if ((Qe1 >= 70) && (Qe1 < 100)) { Gb1 = 24.80; Gm1 = 20.05; Qb1 = 100; Qm1 = 70; }
                if ((Qe2 >= 70) && (Qe2 < 100)) { Gb2 = 24.80; Gm2 = 20.05; Qb2 = 100; Qm2 = 70; }
                if ((Qe1 >= 100) && (Qe1 < 300)) { Gb1 = 48.16; Gm1 = 24.80; Qb1 = 300; Qm1 = 100; }
                if ((Qe2 >= 100) && (Qe2 < 300)) { Gb2 = 48.16; Gm2 = 24.80; Qb2 = 300; Qm2 = 100; }
                if ((Qe1 >= 300) && (Qe1 < 500)) { Gb1 = 65.92; Gm1 = 48.16; Qb1 = 500; Qm1 = 300; }
                if ((Qe2 >= 300) && (Qe2 < 500)) { Gb2 = 65.92; Gm2 = 48.16; Qb2 = 500; Qm2 = 300; }
                if ((Qe1 >= 500) && (Qe1 < 1000)) { Gb1 = 101; Gm1 = 65.92; Qb1 = 1000; Qm1 = 500; }
                if ((Qe2 >= 500) && (Qe2 < 1000)) { Gb2 = 101; Gm2 = 65.92; Qb2 = 1000; Qm2 = 500; }
            }
            if (v >= 5)
            {
                if ((Qe1 >= 0.01) && (Qe1 < 0.05)) { Gb1 = 0.38; Gm1 = 0.17; Qb1 = 0.05; Qm1 = 0.01; }
                if ((Qe2 >= 0.01) && (Qe2 < 0.05)) { Gb2 = 0.38; Gm2 = 0.17; Qb2 = 0.05; Qm2 = 0.01; }
                if ((Qe1 >= 0.05) && (Qe1 < 0.1)) { Gb1 = 0.53; Gm1 = 0.38; Qb1 = 0.1; Qm1 = 0.05; }
                if ((Qe2 >= 0.05) && (Qe2 < 0.1)) { Gb2 = 0.53; Gm2 = 0.38; Qb2 = 0.1; Qm2 = 0.05; }
                if ((Qe1 >= 0.1) && (Qe1 < 0.5)) { Gb1 = 1.19; Gm1 = 0.53; Qb1 = 0.5; Qm1 = 0.1; }
                if ((Qe2 >= 0.1) && (Qe2 < 0.5)) { Gb2 = 1.19; Gm2 = 0.53; Qb2 = 0.5; Qm2 = 0.1; }
                if ((Qe1 >= 0.5) && (Qe1 < 1)) { Gb1 = 1.68; Gm1 = 1.19; Qb1 = 1; Qm1 = 0.5; }
                if ((Qe2 >= 0.5) && (Qe2 < 1)) { Gb2 = 1.68; Gm2 = 1.19; Qb2 = 1; Qm2 = 0.5; }
                if ((Qe1 >= 1) && (Qe1 < 3)) { Gb1 = 2.91; Gm1 = 1.68; Qb1 = 3; Qm1 = 1; }
                if ((Qe2 >= 1) && (Qe2 < 3)) { Gb2 = 2.91; Gm2 = 1.68; Qb2 = 3; Qm2 = 1; }
                if ((Qe1 >= 3) && (Qe1 < 5)) { Gb1 = 3.75; Gm1 = 2.91; Qb1 = 5; Qm1 = 3; }
                if ((Qe2 >= 3) && (Qe2 < 5)) { Gb2 = 3.75; Gm2 = 2.91; Qb2 = 5; Qm2 = 3; }
                if ((Qe1 >= 5) && (Qe1 < 10)) { Gb1 = 5.53; Gm1 = 3.75; Qb1 = 10; Qm1 = 5; }
                if ((Qe2 >= 5) && (Qe2 < 10)) { Gb2 = 5.53; Gm2 = 3.75; Qb2 = 10; Qm2 = 5; }
                if ((Qe1 >= 10) && (Qe1 < 20)) { Gb1 = 8.19; Gm1 = 5.53; Qb1 = 20; Qm1 = 10; }
                if ((Qe2 >= 10) && (Qe2 < 20)) { Gb2 = 8.19; Gm2 = 5.53; Qb2 = 20; Qm2 = 10; }
                if ((Qe1 >= 20) && (Qe1 < 30)) { Gb1 = 10.33; Gm1 = 8.19; Qb1 = 30; Qm1 = 20; }
                if ((Qe2 >= 20) && (Qe2 < 30)) { Gb2 = 10.33; Gm2 = 8.19; Qb2 = 30; Qm2 = 20; }
                if ((Qe1 >= 30) && (Qe1 < 50)) { Gb1 = 13.68; Gm1 = 10.33; Qb1 = 50; Qm1 = 30; }
                if ((Qe2 >= 30) && (Qe2 < 50)) { Gb2 = 13.68; Gm2 = 10.33; Qb2 = 50; Qm2 = 30; }
                if ((Qe1 >= 50) && (Qe1 < 70)) { Gb1 = 16.89; Gm1 = 13.68; Qb1 = 70; Qm1 = 50; }
                if ((Qe2 >= 50) && (Qe2 < 70)) { Gb2 = 16.89; Gm2 = 13.68; Qb2 = 70; Qm2 = 50; }
                if ((Qe1 >= 70) && (Qe1 < 100)) { Gb1 = 20.82; Gm1 = 16.89; Qb1 = 100; Qm1 = 70; }
                if ((Qe2 >= 70) && (Qe2 < 100)) { Gb2 = 20.82; Gm2 = 16.89; Qb2 = 100; Qm2 = 70; }
                if ((Qe1 >= 100) && (Qe1 < 300)) { Gb1 = 40.11; Gm1 = 20.82; Qb1 = 300; Qm1 = 100; }
                if ((Qe2 >= 100) && (Qe2 < 300)) { Gb2 = 40.11; Gm2 = 20.82; Qb2 = 300; Qm2 = 100; }
                if ((Qe1 >= 300) && (Qe1 < 500)) { Gb1 = 54.67; Gm1 = 40.11; Qb1 = 500; Qm1 = 300; }
                if ((Qe2 >= 300) && (Qe2 < 500)) { Gb2 = 54.67; Gm2 = 40.11; Qb2 = 500; Qm2 = 300; }
                if ((Qe1 >= 500) && (Qe1 < 1000)) { Gb1 = 83.6; Gm1 = 54.67; Qb1 = 1000; Qm1 = 500; }
                if ((Qe2 >= 500) && (Qe2 < 1000)) { Gb2 = 83.6; Gm2 = 54.67; Qb2 = 1000; Qm2 = 500; }
            }
            if (v >= 6)
            {
                if ((Qe1 >= 0.01) && (Qe1 < 0.05)) { Gb1 = 0.34; Gm1 = 0.15; Qb1 = 0.05; Qm1 = 0.01; }
                if ((Qe2 >= 0.01) && (Qe2 < 0.05)) { Gb2 = 0.34; Gm2 = 0.15; Qb2 = 0.05; Qm2 = 0.01; }
                if ((Qe1 >= 0.05) && (Qe1 < 0.1)) { Gb1 = 0.48; Gm1 = 0.34; Qb1 = 0.1; Qm1 = 0.05; }
                if ((Qe2 >= 0.05) && (Qe2 < 0.1)) { Gb2 = 0.48; Gm2 = 0.34; Qb2 = 0.1; Qm2 = 0.05; }
                if ((Qe1 >= 0.1) && (Qe1 < 0.5)) { Gb1 = 1.09; Gm1 = 0.48; Qb1 = 0.5; Qm1 = 0.1; }
                if ((Qe2 >= 0.1) && (Qe2 < 0.5)) { Gb2 = 1.09; Gm2 = 0.48; Qb2 = 0.5; Qm2 = 0.1; }
                if ((Qe1 >= 0.5) && (Qe1 < 1)) { Gb1 = 1.53; Gm1 = 1.09; Qb1 = 1; Qm1 = 0.5; }
                if ((Qe2 >= 0.5) && (Qe2 < 1)) { Gb2 = 1.53; Gm2 = 1.09; Qb2 = 1; Qm2 = 0.5; }
                if ((Qe1 >= 1) && (Qe1 < 3)) { Gb1 = 2.66; Gm1 = 1.53; Qb1 = 3; Qm1 = 1; }
                if ((Qe2 >= 1) && (Qe2 < 3)) { Gb2 = 2.66; Gm2 = 1.53; Qb2 = 3; Qm2 = 1; }
                if ((Qe1 >= 3) && (Qe1 < 5)) { Gb1 = 3.43; Gm1 = 2.66; Qb1 = 5; Qm1 = 3; }
                if ((Qe2 >= 3) && (Qe2 < 5)) { Gb2 = 3.43; Gm2 = 2.66; Qb2 = 5; Qm2 = 3; }
                if ((Qe1 >= 5) && (Qe1 < 10)) { Gb1 = 4.88; Gm1 = 3.43; Qb1 = 10; Qm1 = 5; }
                if ((Qe2 >= 5) && (Qe2 < 10)) { Gb2 = 4.88; Gm2 = 3.43; Qb2 = 10; Qm2 = 5; }
                if ((Qe1 >= 10) && (Qe1 < 20)) { Gb1 = 7.20; Gm1 = 4.88; Qb1 = 20; Qm1 = 10; }
                if ((Qe2 >= 10) && (Qe2 < 20)) { Gb2 = 7.20; Gm2 = 4.88; Qb2 = 20; Qm2 = 10; }
                if ((Qe1 >= 20) && (Qe1 < 30)) { Gb1 = 9.06; Gm1 = 7.20; Qb1 = 30; Qm1 = 20; }
                if ((Qe2 >= 20) && (Qe2 < 30)) { Gb2 = 9.06; Gm2 = 7.20; Qb2 = 30; Qm2 = 20; }
                if ((Qe1 >= 30) && (Qe1 < 50)) { Gb1 = 12.14; Gm1 = 9.06; Qb1 = 50; Qm1 = 30; }
                if ((Qe2 >= 30) && (Qe2 < 50)) { Gb2 = 12.14; Gm2 = 9.06; Qb2 = 50; Qm2 = 30; }
                if ((Qe1 >= 50) && (Qe1 < 70)) { Gb1 = 14.79; Gm1 = 12.14; Qb1 = 70; Qm1 = 50; }
                if ((Qe2 >= 50) && (Qe2 < 70)) { Gb2 = 14.79; Gm2 = 12.14; Qb2 = 70; Qm2 = 50; }
                if ((Qe1 >= 70) && (Qe1 < 100)) { Gb1 = 18.13; Gm1 = 14.79; Qb1 = 100; Qm1 = 70; }
                if ((Qe2 >= 70) && (Qe2 < 100)) { Gb2 = 18.13; Gm2 = 14.79; Qb2 = 100; Qm2 = 70; }
                if ((Qe1 >= 100) && (Qe1 < 300)) { Gb1 = 34.67; Gm1 = 18.13; Qb1 = 300; Qm1 = 100; }
                if ((Qe2 >= 100) && (Qe2 < 300)) { Gb2 = 34.67; Gm2 = 18.13; Qb2 = 300; Qm2 = 100; }
                if ((Qe1 >= 300) && (Qe1 < 500)) { Gb1 = 47.09; Gm1 = 34.67; Qb1 = 500; Qm1 = 300; }
                if ((Qe2 >= 300) && (Qe2 < 500)) { Gb2 = 47.09; Gm2 = 34.67; Qb2 = 500; Qm2 = 300; }
                if ((Qe1 >= 500) && (Qe1 < 1000)) { Gb1 = 71.7; Gm1 = 47.09; Qb1 = 1000; Qm1 = 500; }
                if ((Qe2 >= 500) && (Qe2 < 1000)) { Gb2 = 71.7; Gm2 = 47.09; Qb2 = 1000; Qm2 = 500; }
            }
            if (v >= 7)
            {
                if ((Qe1 >= 0.01) && (Qe1 < 0.05)) { Gb1 = 0.32; Gm1 = 0.14; Qb1 = 0.05; Qm1 = 0.01; }
                if ((Qe2 >= 0.01) && (Qe2 < 0.05)) { Gb2 = 0.32; Gm2 = 0.14; Qb2 = 0.05; Qm2 = 0.01; }
                if ((Qe1 >= 0.05) && (Qe1 < 0.1)) { Gb1 = 0.45; Gm1 = 0.32; Qb1 = 0.1; Qm1 = 0.05; }
                if ((Qe2 >= 0.05) && (Qe2 < 0.1)) { Gb2 = 0.45; Gm2 = 0.32; Qb2 = 0.1; Qm2 = 0.05; }
                if ((Qe1 >= 0.1) && (Qe1 < 0.5)) { Gb1 = 1.0; Gm1 = 0.45; Qb1 = 0.5; Qm1 = 0.1; }
                if ((Qe2 >= 0.1) && (Qe2 < 0.5)) { Gb2 = 1.0; Gm2 = 0.45; Qb2 = 0.5; Qm2 = 0.1; }
                if ((Qe1 >= 0.5) && (Qe1 < 1)) { Gb1 = 1.42; Gm1 = 1.0; Qb1 = 1; Qm1 = 0.5; }
                if ((Qe2 >= 0.5) && (Qe2 < 1)) { Gb2 = 1.42; Gm2 = 1.0; Qb2 = 1; Qm2 = 0.5; }
                if ((Qe1 >= 1) && (Qe1 < 3)) { Gb1 = 2.46; Gm1 = 1.42; Qb1 = 3; Qm1 = 1; }
                if ((Qe2 >= 1) && (Qe2 < 3)) { Gb2 = 2.46; Gm2 = 1.42; Qb2 = 3; Qm2 = 1; }
                if ((Qe1 >= 3) && (Qe1 < 5)) { Gb1 = 3.17; Gm1 = 2.46; Qb1 = 5; Qm1 = 3; }
                if ((Qe2 >= 3) && (Qe2 < 5)) { Gb2 = 3.17; Gm2 = 2.46; Qb2 = 5; Qm2 = 3; }
                if ((Qe1 >= 5) && (Qe1 < 10)) { Gb1 = 4.49; Gm1 = 3.17; Qb1 = 10; Qm1 = 5; }
                if ((Qe2 >= 5) && (Qe2 < 10)) { Gb2 = 4.49; Gm2 = 3.17; Qb2 = 10; Qm2 = 5; }
                if ((Qe1 >= 10) && (Qe1 < 20)) { Gb1 = 6.48; Gm1 = 4.49; Qb1 = 20; Qm1 = 10; }
                if ((Qe2 >= 10) && (Qe2 < 20)) { Gb2 = 6.48; Gm2 = 4.49; Qb2 = 20; Qm2 = 10; }
                if ((Qe1 >= 20) && (Qe1 < 30)) { Gb1 = 8.14; Gm1 = 6.48; Qb1 = 30; Qm1 = 20; }
                if ((Qe2 >= 20) && (Qe2 < 30)) { Gb2 = 8.14; Gm2 = 6.48; Qb2 = 30; Qm2 = 20; }
                if ((Qe1 >= 30) && (Qe1 < 50)) { Gb1 = 10.87; Gm1 = 8.14; Qb1 = 50; Qm1 = 30; }
                if ((Qe2 >= 30) && (Qe2 < 50)) { Gb2 = 10.87; Gm2 = 8.14; Qb2 = 50; Qm2 = 30; }
                if ((Qe1 >= 50) && (Qe1 < 70)) { Gb1 = 13.17; Gm1 = 10.87; Qb1 = 70; Qm1 = 50; }
                if ((Qe2 >= 50) && (Qe2 < 70)) { Gb2 = 13.17; Gm2 = 10.87; Qb2 = 70; Qm2 = 50; }
                if ((Qe1 >= 70) && (Qe1 < 100)) { Gb1 = 16.17; Gm1 = 13.17; Qb1 = 100; Qm1 = 70; }
                if ((Qe2 >= 70) && (Qe2 < 100)) { Gb2 = 16.17; Gm2 = 13.17; Qb2 = 100; Qm2 = 70; }
                if ((Qe1 >= 100) && (Qe1 < 300)) { Gb1 = 30.73; Gm1 = 16.17; Qb1 = 300; Qm1 = 100; }
                if ((Qe2 >= 100) && (Qe2 < 300)) { Gb2 = 30.73; Gm2 = 16.17; Qb2 = 300; Qm2 = 100; }
                if ((Qe1 >= 300) && (Qe1 < 500)) { Gb1 = 41.63; Gm1 = 30.73; Qb1 = 500; Qm1 = 300; }
                if ((Qe2 >= 300) && (Qe2 < 500)) { Gb2 = 41.63; Gm2 = 30.73; Qb2 = 500; Qm2 = 300; }
                if ((Qe1 >= 500) && (Qe1 < 1000)) { Gb1 = 63.16; Gm1 = 41.63; Qb1 = 1000; Qm1 = 500; }
                if ((Qe2 >= 500) && (Qe2 < 1000)) { Gb2 = 63.16; Gm2 = 41.63; Qb2 = 1000; Qm2 = 500; }
            }
            if (v >= 8)
            {
                if ((Qe1 >= 0.01) && (Qe1 < 0.05)) { Gb1 = 0.30; Gm1 = 0.13; Qb1 = 0.05; Qm1 = 0.01; }
                if ((Qe2 >= 0.01) && (Qe2 < 0.05)) { Gb2 = 0.30; Gm2 = 0.13; Qb2 = 0.05; Qm2 = 0.01; }
                if ((Qe1 >= 0.05) && (Qe1 < 0.1)) { Gb1 = 0.42; Gm1 = 0.30; Qb1 = 0.1; Qm1 = 0.05; }
                if ((Qe2 >= 0.05) && (Qe2 < 0.1)) { Gb2 = 0.42; Gm2 = 0.30; Qb2 = 0.1; Qm2 = 0.05; }
                if ((Qe1 >= 0.1) && (Qe1 < 0.5)) { Gb1 = 0.94; Gm1 = 0.42; Qb1 = 0.5; Qm1 = 0.1; }
                if ((Qe2 >= 0.1) && (Qe2 < 0.5)) { Gb2 = 0.94; Gm2 = 0.42; Qb2 = 0.5; Qm2 = 0.1; }
                if ((Qe1 >= 0.5) && (Qe1 < 1)) { Gb1 = 1.33; Gm1 = 0.94; Qb1 = 1; Qm1 = 0.5; }
                if ((Qe2 >= 0.5) && (Qe2 < 1)) { Gb2 = 1.33; Gm2 = 0.94; Qb2 = 1; Qm2 = 0.5; }
                if ((Qe1 >= 1) && (Qe1 < 3)) { Gb1 = 2.3; Gm1 = 1.33; Qb1 = 3; Qm1 = 1; }
                if ((Qe2 >= 1) && (Qe2 < 3)) { Gb2 = 2.3; Gm2 = 1.33; Qb2 = 3; Qm2 = 1; }
                if ((Qe1 >= 3) && (Qe1 < 5)) { Gb1 = 2.97; Gm1 = 2.3; Qb1 = 5; Qm1 = 3; }
                if ((Qe2 >= 3) && (Qe2 < 5)) { Gb2 = 2.97; Gm2 = 2.3; Qb2 = 5; Qm2 = 3; }
                if ((Qe1 >= 5) && (Qe1 < 10)) { Gb1 = 4.2; Gm1 = 2.97; Qb1 = 10; Qm1 = 5; }
                if ((Qe2 >= 5) && (Qe2 < 10)) { Gb2 = 4.2; Gm2 = 2.97; Qb2 = 10; Qm2 = 5; }
                if ((Qe1 >= 10) && (Qe1 < 20)) { Gb1 = 5.92; Gm1 = 4.2; Qb1 = 20; Qm1 = 10; }
                if ((Qe2 >= 10) && (Qe2 < 20)) { Gb2 = 5.92; Gm2 = 4.2; Qb2 = 20; Qm2 = 10; }
                if ((Qe1 >= 20) && (Qe1 < 30)) { Gb1 = 7.42; Gm1 = 5.92; Qb1 = 30; Qm1 = 20; }
                if ((Qe2 >= 20) && (Qe2 < 30)) { Gb2 = 7.42; Gm2 = 5.92; Qb2 = 30; Qm2 = 20; }
                if ((Qe1 >= 30) && (Qe1 < 50)) { Gb1 = 9.9; Gm1 = 7.42; Qb1 = 50; Qm1 = 30; }
                if ((Qe2 >= 30) && (Qe2 < 50)) { Gb2 = 9.9; Gm2 = 7.42; Qb2 = 50; Qm2 = 30; }
                if ((Qe1 >= 50) && (Qe1 < 70)) { Gb1 = 11.98; Gm1 = 9.9; Qb1 = 70; Qm1 = 50; }
                if ((Qe2 >= 50) && (Qe2 < 70)) { Gb2 = 11.98; Gm2 = 9.9; Qb2 = 70; Qm2 = 50; }
                if ((Qe1 >= 70) && (Qe1 < 100)) { Gb1 = 14.68; Gm1 = 11.98; Qb1 = 100; Qm1 = 70; }
                if ((Qe2 >= 70) && (Qe2 < 100)) { Gb2 = 14.68; Gm2 = 11.98; Qb2 = 100; Qm2 = 70; }
                if ((Qe1 >= 100) && (Qe1 < 300)) { Gb1 = 27.75; Gm1 = 14.68; Qb1 = 300; Qm1 = 100; }
                if ((Qe2 >= 100) && (Qe2 < 300)) { Gb2 = 27.75; Gm2 = 14.68; Qb2 = 300; Qm2 = 100; }
                if ((Qe1 >= 300) && (Qe1 < 500)) { Gb1 = 37.49; Gm1 = 27.75; Qb1 = 500; Qm1 = 300; }
                if ((Qe2 >= 300) && (Qe2 < 500)) { Gb2 = 37.49; Gm2 = 27.75; Qb2 = 500; Qm2 = 300; }
                if ((Qe1 >= 500) && (Qe1 < 1000)) { Gb1 = 56.7; Gm1 = 37.49; Qb1 = 1000; Qm1 = 500; }
                if ((Qe2 >= 500) && (Qe2 < 1000)) { Gb2 = 56.7; Gm2 = 37.49; Qb2 = 1000; Qm2 = 500; }
            }
            if (v >= 9)
            {
                if ((Qe1 >= 0.01) && (Qe1 < 0.05)) { Gb1 = 0.28; Gm1 = 0.12; Qb1 = 0.05; Qm1 = 0.01; }
                if ((Qe2 >= 0.01) && (Qe2 < 0.05)) { Gb2 = 0.28; Gm2 = 0.12; Qb2 = 0.05; Qm2 = 0.01; }
                if ((Qe1 >= 0.05) && (Qe1 < 0.1)) { Gb1 = 0.40; Gm1 = 0.28; Qb1 = 0.1; Qm1 = 0.05; }
                if ((Qe2 >= 0.05) && (Qe2 < 0.1)) { Gb2 = 0.40; Gm2 = 0.28; Qb2 = 0.1; Qm2 = 0.05; }
                if ((Qe1 >= 0.1) && (Qe1 < 0.5)) { Gb1 = 0.88; Gm1 = 0.40; Qb1 = 0.5; Qm1 = 0.1; }
                if ((Qe2 >= 0.1) && (Qe2 < 0.5)) { Gb2 = 0.88; Gm2 = 0.40; Qb2 = 0.5; Qm2 = 0.1; }
                if ((Qe1 >= 0.5) && (Qe1 < 1)) { Gb1 = 1.25; Gm1 = 0.88; Qb1 = 1; Qm1 = 0.5; }
                if ((Qe2 >= 0.5) && (Qe2 < 1)) { Gb2 = 1.25; Gm2 = 0.88; Qb2 = 1; Qm2 = 0.5; }
                if ((Qe1 >= 1) && (Qe1 < 3)) { Gb1 = 2.17; Gm1 = 1.25; Qb1 = 3; Qm1 = 1; }
                if ((Qe2 >= 1) && (Qe2 < 3)) { Gb2 = 2.17; Gm2 = 1.25; Qb2 = 3; Qm2 = 1; }
                if ((Qe1 >= 3) && (Qe1 < 5)) { Gb1 = 2.8; Gm1 = 2.17; Qb1 = 5; Qm1 = 3; }
                if ((Qe2 >= 3) && (Qe2 < 5)) { Gb2 = 2.8; Gm2 = 2.17; Qb2 = 5; Qm2 = 3; }
                if ((Qe1 >= 5) && (Qe1 < 10)) { Gb1 = 3.96; Gm1 = 2.8; Qb1 = 10; Qm1 = 5; }
                if ((Qe2 >= 5) && (Qe2 < 10)) { Gb2 = 3.96; Gm2 = 2.8; Qb2 = 10; Qm2 = 5; }
                if ((Qe1 >= 10) && (Qe1 < 20)) { Gb1 = 5.60; Gm1 = 3.96; Qb1 = 20; Qm1 = 10; }
                if ((Qe2 >= 10) && (Qe2 < 20)) { Gb2 = 5.60; Gm2 = 3.96; Qb2 = 20; Qm2 = 10; }
                if ((Qe1 >= 20) && (Qe1 < 30)) { Gb1 = 6.86; Gm1 = 5.60; Qb1 = 30; Qm1 = 20; }
                if ((Qe2 >= 20) && (Qe2 < 30)) { Gb2 = 6.86; Gm2 = 5.60; Qb2 = 30; Qm2 = 20; }
                if ((Qe1 >= 30) && (Qe1 < 50)) { Gb1 = 9.12; Gm1 = 6.86; Qb1 = 50; Qm1 = 30; }
                if ((Qe2 >= 30) && (Qe2 < 50)) { Gb2 = 9.12; Gm2 = 6.86; Qb2 = 50; Qm2 = 30; }
                if ((Qe1 >= 50) && (Qe1 < 70)) { Gb1 = 11.03; Gm1 = 9.12; Qb1 = 70; Qm1 = 50; }
                if ((Qe2 >= 50) && (Qe2 < 70)) { Gb2 = 11.03; Gm2 = 9.12; Qb2 = 70; Qm2 = 50; }
                if ((Qe1 >= 70) && (Qe1 < 100)) { Gb1 = 13.5; Gm1 = 11.03; Qb1 = 100; Qm1 = 70; }
                if ((Qe2 >= 70) && (Qe2 < 100)) { Gb2 = 13.5; Gm2 = 11.03; Qb2 = 100; Qm2 = 70; }
                if ((Qe1 >= 100) && (Qe1 < 300)) { Gb1 = 25.39; Gm1 = 13.5; Qb1 = 300; Qm1 = 100; }
                if ((Qe2 >= 100) && (Qe2 < 300)) { Gb2 = 25.39; Gm2 = 13.5; Qb2 = 300; Qm2 = 100; }
                if ((Qe1 >= 300) && (Qe1 < 500)) { Gb1 = 34.24; Gm1 = 25.39; Qb1 = 500; Qm1 = 300; }
                if ((Qe2 >= 300) && (Qe2 < 500)) { Gb2 = 34.24; Gm2 = 25.39; Qb2 = 500; Qm2 = 300; }
                if ((Qe1 >= 500) && (Qe1 < 1000)) { Gb1 = 51.6; Gm1 = 34.24; Qb1 = 1000; Qm1 = 500; }
                if ((Qe2 >= 500) && (Qe2 < 1000)) { Gb2 = 51.6; Gm2 = 34.24; Qb2 = 1000; Qm2 = 500; }
            }
            if (v >= 10)
            {
                if ((Qe1 >= 0.01) && (Qe1 < 0.05)) { Gb1 = 0.26; Gm1 = 0.12; Qb1 = 0.05; Qm1 = 0.01; }
                if ((Qe2 >= 0.01) && (Qe2 < 0.05)) { Gb2 = 0.26; Gm2 = 0.12; Qb2 = 0.05; Qm2 = 0.01; }
                if ((Qe1 >= 0.05) && (Qe1 < 0.1)) { Gb1 = 0.38; Gm1 = 0.26; Qb1 = 0.1; Qm1 = 0.05; }
                if ((Qe2 >= 0.05) && (Qe2 < 0.1)) { Gb2 = 0.38; Gm2 = 0.26; Qb2 = 0.1; Qm2 = 0.05; }
                if ((Qe1 >= 0.1) && (Qe1 < 0.5)) { Gb1 = 0.84; Gm1 = 0.38; Qb1 = 0.5; Qm1 = 0.1; }
                if ((Qe2 >= 0.1) && (Qe2 < 0.5)) { Gb2 = 0.84; Gm2 = 0.38; Qb2 = 0.5; Qm2 = 0.1; }
                if ((Qe1 >= 0.5) && (Qe1 < 1)) { Gb1 = 1.19; Gm1 = 0.84; Qb1 = 1; Qm1 = 0.5; }
                if ((Qe2 >= 0.5) && (Qe2 < 1)) { Gb2 = 1.19; Gm2 = 0.84; Qb2 = 1; Qm2 = 0.5; }
                if ((Qe1 >= 1) && (Qe1 < 3)) { Gb1 = 2.06; Gm1 = 1.19; Qb1 = 3; Qm1 = 1; }
                if ((Qe2 >= 1) && (Qe2 < 3)) { Gb2 = 2.06; Gm2 = 1.19; Qb2 = 3; Qm2 = 1; }
                if ((Qe1 >= 3) && (Qe1 < 5)) { Gb1 = 2.66; Gm1 = 2.06; Qb1 = 5; Qm1 = 3; }
                if ((Qe2 >= 3) && (Qe2 < 5)) { Gb2 = 2.66; Gm2 = 2.06; Qb2 = 5; Qm2 = 3; }
                if ((Qe1 >= 5) && (Qe1 < 10)) { Gb1 = 3.76; Gm1 = 2.66; Qb1 = 10; Qm1 = 5; }
                if ((Qe2 >= 5) && (Qe2 < 10)) { Gb2 = 3.76; Gm2 = 2.66; Qb2 = 10; Qm2 = 5; }
                if ((Qe1 >= 10) && (Qe1 < 20)) { Gb1 = 5.31; Gm1 = 3.76; Qb1 = 20; Qm1 = 10; }
                if ((Qe2 >= 10) && (Qe2 < 20)) { Gb2 = 5.31; Gm2 = 3.76; Qb2 = 20; Qm2 = 10; }
                if ((Qe1 >= 20) && (Qe1 < 30)) { Gb1 = 6.50; Gm1 = 5.31; Qb1 = 30; Qm1 = 20; }
                if ((Qe2 >= 20) && (Qe2 < 30)) { Gb2 = 6.50; Gm2 = 5.31; Qb2 = 30; Qm2 = 20; }
                if ((Qe1 >= 30) && (Qe1 < 50)) { Gb1 = 8.50; Gm1 = 6.50; Qb1 = 50; Qm1 = 30; }
                if ((Qe2 >= 30) && (Qe2 < 50)) { Gb2 = 8.50; Gm2 = 6.50; Qb2 = 50; Qm2 = 30; }
                if ((Qe1 >= 50) && (Qe1 < 70)) { Gb1 = 10.23; Gm1 = 8.50; Qb1 = 70; Qm1 = 50; }
                if ((Qe2 >= 50) && (Qe2 < 70)) { Gb2 = 10.23; Gm2 = 8.50; Qb2 = 70; Qm2 = 50; }
                if ((Qe1 >= 70) && (Qe1 < 100)) { Gb1 = 12.54; Gm1 = 10.23; Qb1 = 100; Qm1 = 70; }
                if ((Qe2 >= 70) && (Qe2 < 100)) { Gb2 = 12.54; Gm2 = 10.23; Qb2 = 100; Qm2 = 70; }
                if ((Qe1 >= 100) && (Qe1 < 300)) { Gb1 = 23.49; Gm1 = 12.54; Qb1 = 300; Qm1 = 100; }
                if ((Qe2 >= 100) && (Qe2 < 300)) { Gb2 = 23.49; Gm2 = 12.54; Qb2 = 300; Qm2 = 100; }
                if ((Qe1 >= 300) && (Qe1 < 500)) { Gb1 = 31.61; Gm1 = 23.49; Qb1 = 500; Qm1 = 300; }
                if ((Qe2 >= 300) && (Qe2 < 500)) { Gb2 = 31.61; Gm2 = 23.49; Qb2 = 500; Qm2 = 300; }
                if ((Qe1 >= 500) && (Qe1 < 1000)) { Gb1 = 47.53; Gm1 = 31.61; Qb1 = 1000; Qm1 = 500; }
                if ((Qe2 >= 500) && (Qe2 < 1000)) { Gb2 = 47.53; Gm2 = 31.61; Qb2 = 1000; Qm2 = 500; }
            }
            if (v >= 11)
            {
                if ((Qe1 >= 0.01) && (Qe1 < 0.05)) { Gb1 = 0.25; Gm1 = 0.11; Qb1 = 0.05; Qm1 = 0.01; }
                if ((Qe2 >= 0.01) && (Qe2 < 0.05)) { Gb2 = 0.25; Gm2 = 0.11; Qb2 = 0.05; Qm2 = 0.01; }
                if ((Qe1 >= 0.05) && (Qe1 < 0.1)) { Gb1 = 0.36; Gm1 = 0.25; Qb1 = 0.1; Qm1 = 0.05; }
                if ((Qe2 >= 0.05) && (Qe2 < 0.1)) { Gb2 = 0.36; Gm2 = 0.25; Qb2 = 0.1; Qm2 = 0.05; }
                if ((Qe1 >= 0.1) && (Qe1 < 0.5)) { Gb1 = 0.80; Gm1 = 0.36; Qb1 = 0.5; Qm1 = 0.1; }
                if ((Qe2 >= 0.1) && (Qe2 < 0.5)) { Gb2 = 0.80; Gm2 = 0.36; Qb2 = 0.5; Qm2 = 0.1; }
                if ((Qe1 >= 0.5) && (Qe1 < 1)) { Gb1 = 1.13; Gm1 = 0.80; Qb1 = 1; Qm1 = 0.5; }
                if ((Qe2 >= 0.5) && (Qe2 < 1)) { Gb2 = 1.13; Gm2 = 0.80; Qb2 = 1; Qm2 = 0.5; }
                if ((Qe1 >= 1) && (Qe1 < 3)) { Gb1 = 1.96; Gm1 = 1.13; Qb1 = 3; Qm1 = 1; }
                if ((Qe2 >= 1) && (Qe2 < 3)) { Gb2 = 1.96; Gm2 = 1.13; Qb2 = 3; Qm2 = 1; }
                if ((Qe1 >= 3) && (Qe1 < 5)) { Gb1 = 2.53; Gm1 = 1.96; Qb1 = 5; Qm1 = 3; }
                if ((Qe2 >= 3) && (Qe2 < 5)) { Gb2 = 2.53; Gm2 = 1.96; Qb2 = 5; Qm2 = 3; }
                if ((Qe1 >= 5) && (Qe1 < 10)) { Gb1 = 3.58; Gm1 = 2.53; Qb1 = 10; Qm1 = 5; }
                if ((Qe2 >= 5) && (Qe2 < 10)) { Gb2 = 3.58; Gm2 = 2.53; Qb2 = 10; Qm2 = 5; }
                if ((Qe1 >= 10) && (Qe1 < 20)) { Gb1 = 5.06; Gm1 = 3.58; Qb1 = 20; Qm1 = 10; }
                if ((Qe2 >= 10) && (Qe2 < 20)) { Gb2 = 5.06; Gm2 = 3.58; Qb2 = 20; Qm2 = 10; }
                if ((Qe1 >= 20) && (Qe1 < 30)) { Gb1 = 6.20; Gm1 = 5.06; Qb1 = 30; Qm1 = 20; }
                if ((Qe2 >= 20) && (Qe2 < 30)) { Gb2 = 6.20; Gm2 = 5.06; Qb2 = 30; Qm2 = 20; }
                if ((Qe1 >= 30) && (Qe1 < 50)) { Gb1 = 8.01; Gm1 = 6.20; Qb1 = 50; Qm1 = 30; }
                if ((Qe2 >= 30) && (Qe2 < 50)) { Gb2 = 8.01; Gm2 = 6.20; Qb2 = 50; Qm2 = 30; }
                if ((Qe1 >= 50) && (Qe1 < 70)) { Gb1 = 9.61; Gm1 = 8.01; Qb1 = 70; Qm1 = 50; }
                if ((Qe2 >= 50) && (Qe2 < 70)) { Gb2 = 9.61; Gm2 = 8.01; Qb2 = 70; Qm2 = 50; }
                if ((Qe1 >= 70) && (Qe1 < 100)) { Gb1 = 11.74; Gm1 = 9.61; Qb1 = 100; Qm1 = 70; }
                if ((Qe2 >= 70) && (Qe2 < 100)) { Gb2 = 11.74; Gm2 = 9.61; Qb2 = 100; Qm2 = 70; }
                if ((Qe1 >= 100) && (Qe1 < 300)) { Gb1 = 21.91; Gm1 = 11.74; Qb1 = 300; Qm1 = 100; }
                if ((Qe2 >= 100) && (Qe2 < 300)) { Gb2 = 21.91; Gm2 = 11.74; Qb2 = 300; Qm2 = 100; }
                if ((Qe1 >= 300) && (Qe1 < 500)) { Gb1 = 29.44; Gm1 = 21.91; Qb1 = 500; Qm1 = 300; }
                if ((Qe2 >= 300) && (Qe2 < 500)) { Gb2 = 29.44; Gm2 = 21.91; Qb2 = 500; Qm2 = 300; }
                if ((Qe1 >= 500) && (Qe1 < 1000)) { Gb1 = 44.15; Gm1 = 29.44; Qb1 = 1000; Qm1 = 500; }
                if ((Qe2 >= 500) && (Qe2 < 1000)) { Gb2 = 44.15; Gm2 = 29.44; Qb2 = 1000; Qm2 = 500; }
            }
            if (v >= 12)
            {
                if ((Qe1 >= 0.01) && (Qe1 < 0.05)) { Gb1 = 0.24; Gm1 = 0.11; Qb1 = 0.05; Qm1 = 0.01; }
                if ((Qe2 >= 0.01) && (Qe2 < 0.05)) { Gb2 = 0.24; Gm2 = 0.11; Qb2 = 0.05; Qm2 = 0.01; }
                if ((Qe1 >= 0.05) && (Qe1 < 0.1)) { Gb1 = 0.34; Gm1 = 0.24; Qb1 = 0.1; Qm1 = 0.05; }
                if ((Qe2 >= 0.05) && (Qe2 < 0.1)) { Gb2 = 0.34; Gm2 = 0.24; Qb2 = 0.1; Qm2 = 0.05; }
                if ((Qe1 >= 0.1) && (Qe1 < 0.5)) { Gb1 = 0.76; Gm1 = 0.34; Qb1 = 0.5; Qm1 = 0.1; }
                if ((Qe2 >= 0.1) && (Qe2 < 0.5)) { Gb2 = 0.76; Gm2 = 0.34; Qb2 = 0.5; Qm2 = 0.1; }
                if ((Qe1 >= 0.5) && (Qe1 < 1)) { Gb1 = 1.08; Gm1 = 0.76; Qb1 = 1; Qm1 = 0.5; }
                if ((Qe2 >= 0.5) && (Qe2 < 1)) { Gb2 = 1.08; Gm2 = 0.76; Qb2 = 1; Qm2 = 0.5; }
                if ((Qe1 >= 1) && (Qe1 < 3)) { Gb1 = 1.88; Gm1 = 1.08; Qb1 = 3; Qm1 = 1; }
                if ((Qe2 >= 1) && (Qe2 < 3)) { Gb2 = 1.88; Gm2 = 1.08; Qb2 = 3; Qm2 = 1; }
                if ((Qe1 >= 3) && (Qe1 < 5)) { Gb1 = 2.42; Gm1 = 1.88; Qb1 = 5; Qm1 = 3; }
                if ((Qe2 >= 3) && (Qe2 < 5)) { Gb2 = 2.42; Gm2 = 1.88; Qb2 = 5; Qm2 = 3; }
                if ((Qe1 >= 5) && (Qe1 < 10)) { Gb1 = 3.43; Gm1 = 2.42; Qb1 = 10; Qm1 = 5; }
                if ((Qe2 >= 5) && (Qe2 < 10)) { Gb2 = 3.43; Gm2 = 2.42; Qb2 = 10; Qm2 = 5; }
                if ((Qe1 >= 10) && (Qe1 < 20)) { Gb1 = 4.85; Gm1 = 3.43; Qb1 = 20; Qm1 = 10; }
                if ((Qe2 >= 10) && (Qe2 < 20)) { Gb2 = 4.85; Gm2 = 3.43; Qb2 = 20; Qm2 = 10; }
                if ((Qe1 >= 20) && (Qe1 < 30)) { Gb1 = 5.94; Gm1 = 4.85; Qb1 = 30; Qm1 = 20; }
                if ((Qe2 >= 20) && (Qe2 < 30)) { Gb2 = 5.94; Gm2 = 4.85; Qb2 = 30; Qm2 = 20; }
                if ((Qe1 >= 30) && (Qe1 < 50)) { Gb1 = 7.67; Gm1 = 5.94; Qb1 = 50; Qm1 = 30; }
                if ((Qe2 >= 30) && (Qe2 < 50)) { Gb2 = 7.67; Gm2 = 5.94; Qb2 = 50; Qm2 = 30; }
                if ((Qe1 >= 50) && (Qe1 < 70)) { Gb1 = 9.07; Gm1 = 7.67; Qb1 = 70; Qm1 = 50; }
                if ((Qe2 >= 50) && (Qe2 < 70)) { Gb2 = 9.07; Gm2 = 7.67; Qb2 = 70; Qm2 = 50; }
                if ((Qe1 >= 70) && (Qe1 < 100)) { Gb1 = 11.06; Gm1 = 9.07; Qb1 = 100; Qm1 = 70; }
                if ((Qe2 >= 70) && (Qe2 < 100)) { Gb2 = 11.06; Gm2 = 9.07; Qb2 = 100; Qm2 = 70; }
                if ((Qe1 >= 100) && (Qe1 < 300)) { Gb1 = 20.58; Gm1 = 11.06; Qb1 = 300; Qm1 = 100; }
                if ((Qe2 >= 100) && (Qe2 < 300)) { Gb2 = 20.58; Gm2 = 11.06; Qb2 = 300; Qm2 = 100; }
                if ((Qe1 >= 300) && (Qe1 < 500)) { Gb1 = 27.61; Gm1 = 20.58; Qb1 = 500; Qm1 = 300; }
                if ((Qe2 >= 300) && (Qe2 < 500)) { Gb2 = 27.61; Gm2 = 20.58; Qb2 = 500; Qm2 = 300; }
                if ((Qe1 >= 500) && (Qe1 < 1000)) { Gb1 = 41.30; Gm1 = 27.61; Qb1 = 1000; Qm1 = 500; }
                if ((Qe2 >= 500) && (Qe2 < 1000)) { Gb2 = 41.30; Gm2 = 27.61; Qb2 = 1000; Qm2 = 500; }
            }
            if (v >= 13)
            {
                if ((Qe1 >= 0.01) && (Qe1 < 0.05)) { Gb1 = 0.23; Gm1 = 0.10; Qb1 = 0.05; Qm1 = 0.01; }
                if ((Qe2 >= 0.01) && (Qe2 < 0.05)) { Gb2 = 0.23; Gm2 = 0.10; Qb2 = 0.05; Qm2 = 0.01; }
                if ((Qe1 >= 0.05) && (Qe1 < 0.1)) { Gb1 = 0.33; Gm1 = 0.23; Qb1 = 0.1; Qm1 = 0.05; }
                if ((Qe2 >= 0.05) && (Qe2 < 0.1)) { Gb2 = 0.33; Gm2 = 0.23; Qb2 = 0.1; Qm2 = 0.05; }
                if ((Qe1 >= 0.1) && (Qe1 < 0.5)) { Gb1 = 0.74; Gm1 = 0.33; Qb1 = 0.5; Qm1 = 0.1; }
                if ((Qe2 >= 0.1) && (Qe2 < 0.5)) { Gb2 = 0.74; Gm2 = 0.33; Qb2 = 0.5; Qm2 = 0.1; }
                if ((Qe1 >= 0.5) && (Qe1 < 1)) { Gb1 = 1.04; Gm1 = 0.74; Qb1 = 1; Qm1 = 0.5; }
                if ((Qe2 >= 0.5) && (Qe2 < 1)) { Gb2 = 1.04; Gm2 = 0.74; Qb2 = 1; Qm2 = 0.5; }
                if ((Qe1 >= 1) && (Qe1 < 3)) { Gb1 = 1.80; Gm1 = 1.04; Qb1 = 3; Qm1 = 1; }
                if ((Qe2 >= 1) && (Qe2 < 3)) { Gb2 = 1.80; Gm2 = 1.04; Qb2 = 3; Qm2 = 1; }
                if ((Qe1 >= 3) && (Qe1 < 5)) { Gb1 = 2.37; Gm1 = 1.80; Qb1 = 5; Qm1 = 3; }
                if ((Qe2 >= 3) && (Qe2 < 5)) { Gb2 = 2.37; Gm2 = 1.80; Qb2 = 5; Qm2 = 3; }
                if ((Qe1 >= 5) && (Qe1 < 10)) { Gb1 = 3.29; Gm1 = 2.37; Qb1 = 10; Qm1 = 5; }
                if ((Qe2 >= 5) && (Qe2 < 10)) { Gb2 = 3.29; Gm2 = 2.37; Qb2 = 10; Qm2 = 5; }
                if ((Qe1 >= 10) && (Qe1 < 20)) { Gb1 = 4.66; Gm1 = 3.29; Qb1 = 20; Qm1 = 10; }
                if ((Qe2 >= 10) && (Qe2 < 20)) { Gb2 = 4.66; Gm2 = 3.29; Qb2 = 20; Qm2 = 10; }
                if ((Qe1 >= 20) && (Qe1 < 30)) { Gb1 = 5.70; Gm1 = 4.66; Qb1 = 30; Qm1 = 20; }
                if ((Qe2 >= 20) && (Qe2 < 30)) { Gb2 = 5.70; Gm2 = 4.66; Qb2 = 30; Qm2 = 20; }
                if ((Qe1 >= 30) && (Qe1 < 50)) { Gb1 = 7.37; Gm1 = 5.70; Qb1 = 50; Qm1 = 30; }
                if ((Qe2 >= 30) && (Qe2 < 50)) { Gb2 = 7.37; Gm2 = 5.70; Qb2 = 50; Qm2 = 30; }
                if ((Qe1 >= 50) && (Qe1 < 70)) { Gb1 = 8.72; Gm1 = 7.37; Qb1 = 70; Qm1 = 50; }
                if ((Qe2 >= 50) && (Qe2 < 70)) { Gb2 = 8.72; Gm2 = 7.37; Qb2 = 70; Qm2 = 50; }
                if ((Qe1 >= 70) && (Qe1 < 100)) { Gb1 = 10.48; Gm1 = 8.72; Qb1 = 100; Qm1 = 70; }
                if ((Qe2 >= 70) && (Qe2 < 100)) { Gb2 = 10.48; Gm2 = 8.72; Qb2 = 100; Qm2 = 70; }
                if ((Qe1 >= 100) && (Qe1 < 300)) { Gb1 = 19.45; Gm1 = 10.48; Qb1 = 300; Qm1 = 100; }
                if ((Qe2 >= 100) && (Qe2 < 300)) { Gb2 = 19.45; Gm2 = 10.48; Qb2 = 300; Qm2 = 100; }
                if ((Qe1 >= 300) && (Qe1 < 500)) { Gb1 = 26.04; Gm1 = 19.45; Qb1 = 500; Qm1 = 300; }
                if ((Qe2 >= 300) && (Qe2 < 500)) { Gb2 = 26.04; Gm2 = 19.45; Qb2 = 500; Qm2 = 300; }
                if ((Qe1 >= 500) && (Qe1 < 1000)) { Gb1 = 38.90; Gm1 = 26.04; Qb1 = 1000; Qm1 = 500; }
                if ((Qe2 >= 500) && (Qe2 < 1000)) { Gb2 = 38.90; Gm2 = 26.04; Qb2 = 1000; Qm2 = 500; }
            }
            if (v >= 14)
            {
                if ((Qe1 >= 0.01) && (Qe1 < 0.05)) { Gb1 = 0.22; Gm1 = 0.10; Qb1 = 0.05; Qm1 = 0.01; }
                if ((Qe2 >= 0.01) && (Qe2 < 0.05)) { Gb2 = 0.22; Gm2 = 0.10; Qb2 = 0.05; Qm2 = 0.01; }
                if ((Qe1 >= 0.05) && (Qe1 < 0.1)) { Gb1 = 0.32; Gm1 = 0.22; Qb1 = 0.1; Qm1 = 0.05; }
                if ((Qe2 >= 0.05) && (Qe2 < 0.1)) { Gb2 = 0.32; Gm2 = 0.22; Qb2 = 0.1; Qm2 = 0.05; }
                if ((Qe1 >= 0.1) && (Qe1 < 0.5)) { Gb1 = 0.71; Gm1 = 0.32; Qb1 = 0.5; Qm1 = 0.1; }
                if ((Qe2 >= 0.1) && (Qe2 < 0.5)) { Gb2 = 0.71; Gm2 = 0.32; Qb2 = 0.5; Qm2 = 0.1; }
                if ((Qe1 >= 0.5) && (Qe1 < 1)) { Gb1 = 1.0; Gm1 = 0.71; Qb1 = 1; Qm1 = 0.5; }
                if ((Qe2 >= 0.5) && (Qe2 < 1)) { Gb2 = 1.0; Gm2 = 0.71; Qb2 = 1; Qm2 = 0.5; }
                if ((Qe1 >= 1) && (Qe1 < 3)) { Gb1 = 1.74; Gm1 = 1.0; Qb1 = 3; Qm1 = 1; }
                if ((Qe2 >= 1) && (Qe2 < 3)) { Gb2 = 1.74; Gm2 = 1.0; Qb2 = 3; Qm2 = 1; }
                if ((Qe1 >= 3) && (Qe1 < 5)) { Gb1 = 2.24; Gm1 = 1.74; Qb1 = 5; Qm1 = 3; }
                if ((Qe2 >= 3) && (Qe2 < 5)) { Gb2 = 2.24; Gm2 = 1.74; Qb2 = 5; Qm2 = 3; }
                if ((Qe1 >= 5) && (Qe1 < 10)) { Gb1 = 3.17; Gm1 = 2.24; Qb1 = 10; Qm1 = 5; }
                if ((Qe2 >= 5) && (Qe2 < 10)) { Gb2 = 3.17; Gm2 = 2.24; Qb2 = 10; Qm2 = 5; }
                if ((Qe1 >= 10) && (Qe1 < 20)) { Gb1 = 4.49; Gm1 = 3.17; Qb1 = 20; Qm1 = 10; }
                if ((Qe2 >= 10) && (Qe2 < 20)) { Gb2 = 4.49; Gm2 = 3.17; Qb2 = 20; Qm2 = 10; }
                if ((Qe1 >= 20) && (Qe1 < 30)) { Gb1 = 5.50; Gm1 = 4.49; Qb1 = 30; Qm1 = 20; }
                if ((Qe2 >= 20) && (Qe2 < 30)) { Gb2 = 5.50; Gm2 = 4.49; Qb2 = 30; Qm2 = 20; }
                if ((Qe1 >= 30) && (Qe1 < 50)) { Gb1 = 7.10; Gm1 = 5.50; Qb1 = 50; Qm1 = 30; }
                if ((Qe2 >= 30) && (Qe2 < 50)) { Gb2 = 7.10; Gm2 = 5.50; Qb2 = 50; Qm2 = 30; }
                if ((Qe1 >= 50) && (Qe1 < 70)) { Gb1 = 8.40; Gm1 = 7.10; Qb1 = 70; Qm1 = 50; }
                if ((Qe2 >= 50) && (Qe2 < 70)) { Gb2 = 8.40; Gm2 = 7.10; Qb2 = 70; Qm2 = 50; }
                if ((Qe1 >= 70) && (Qe1 < 100)) { Gb1 = 10.04; Gm1 = 8.40; Qb1 = 100; Qm1 = 70; }
                if ((Qe2 >= 70) && (Qe2 < 100)) { Gb2 = 10.04; Gm2 = 8.40; Qb2 = 100; Qm2 = 70; }
                if ((Qe1 >= 100) && (Qe1 < 300)) { Gb1 = 18.46; Gm1 = 10.04; Qb1 = 300; Qm1 = 100; }
                if ((Qe2 >= 100) && (Qe2 < 300)) { Gb2 = 18.46; Gm2 = 10.04; Qb2 = 300; Qm2 = 100; }
                if ((Qe1 >= 300) && (Qe1 < 500)) { Gb1 = 24.69; Gm1 = 18.46; Qb1 = 500; Qm1 = 300; }
                if ((Qe2 >= 300) && (Qe2 < 500)) { Gb2 = 24.69; Gm2 = 18.46; Qb2 = 500; Qm2 = 300; }
                if ((Qe1 >= 500) && (Qe1 < 1000)) { Gb1 = 36.81; Gm1 = 24.69; Qb1 = 1000; Qm1 = 500; }
                if ((Qe2 >= 500) && (Qe2 < 1000)) { Gb2 = 36.81; Gm2 = 24.69; Qb2 = 1000; Qm2 = 500; }
            }
            if (v >= 15)
            {
                if ((Qe1 >= 0.01) && (Qe1 < 0.05)) { Gb1 = 0.22; Gm1 = 0.10; Qb1 = 0.05; Qm1 = 0.01; }
                if ((Qe2 >= 0.01) && (Qe2 < 0.05)) { Gb2 = 0.22; Gm2 = 0.10; Qb2 = 0.05; Qm2 = 0.01; }
                if ((Qe1 >= 0.05) && (Qe1 < 0.1)) { Gb1 = 0.31; Gm1 = 0.22; Qb1 = 0.1; Qm1 = 0.05; }
                if ((Qe2 >= 0.05) && (Qe2 < 0.1)) { Gb2 = 0.31; Gm2 = 0.22; Qb2 = 0.1; Qm2 = 0.05; }
                if ((Qe1 >= 0.1) && (Qe1 < 0.5)) { Gb1 = 0.69; Gm1 = 0.31; Qb1 = 0.5; Qm1 = 0.1; }
                if ((Qe2 >= 0.1) && (Qe2 < 0.5)) { Gb2 = 0.69; Gm2 = 0.31; Qb2 = 0.5; Qm2 = 0.1; }
                if ((Qe1 >= 0.5) && (Qe1 < 1)) { Gb1 = 0.97; Gm1 = 0.69; Qb1 = 1; Qm1 = 0.5; }
                if ((Qe2 >= 0.5) && (Qe2 < 1)) { Gb2 = 0.97; Gm2 = 0.69; Qb2 = 1; Qm2 = 0.5; }
                if ((Qe1 >= 1) && (Qe1 < 3)) { Gb1 = 1.68; Gm1 = 0.97; Qb1 = 3; Qm1 = 1; }
                if ((Qe2 >= 1) && (Qe2 < 3)) { Gb2 = 1.68; Gm2 = 0.97; Qb2 = 3; Qm2 = 1; }
                if ((Qe1 >= 3) && (Qe1 < 5)) { Gb1 = 2.17; Gm1 = 1.68; Qb1 = 5; Qm1 = 3; }
                if ((Qe2 >= 3) && (Qe2 < 5)) { Gb2 = 2.17; Gm2 = 1.68; Qb2 = 5; Qm2 = 3; }
                if ((Qe1 >= 5) && (Qe1 < 10)) { Gb1 = 3.07; Gm1 = 2.17; Qb1 = 10; Qm1 = 5; }
                if ((Qe2 >= 5) && (Qe2 < 10)) { Gb2 = 3.07; Gm2 = 2.17; Qb2 = 10; Qm2 = 5; }
                if ((Qe1 >= 10) && (Qe1 < 20)) { Gb1 = 4.34; Gm1 = 3.07; Qb1 = 20; Qm1 = 10; }
                if ((Qe2 >= 10) && (Qe2 < 20)) { Gb2 = 4.34; Gm2 = 3.07; Qb2 = 20; Qm2 = 10; }
                if ((Qe1 >= 20) && (Qe1 < 30)) { Gb1 = 5.31; Gm1 = 4.34; Qb1 = 30; Qm1 = 20; }
                if ((Qe2 >= 20) && (Qe2 < 30)) { Gb2 = 5.31; Gm2 = 4.34; Qb2 = 30; Qm2 = 20; }
                if ((Qe1 >= 30) && (Qe1 < 50)) { Gb1 = 6.86; Gm1 = 5.31; Qb1 = 50; Qm1 = 30; }
                if ((Qe2 >= 30) && (Qe2 < 50)) { Gb2 = 6.86; Gm2 = 5.31; Qb2 = 50; Qm2 = 30; }
                if ((Qe1 >= 50) && (Qe1 < 70)) { Gb1 = 8.11; Gm1 = 6.86; Qb1 = 70; Qm1 = 50; }
                if ((Qe2 >= 50) && (Qe2 < 70)) { Gb2 = 8.11; Gm2 = 6.86; Qb2 = 70; Qm2 = 50; }
                if ((Qe1 >= 70) && (Qe1 < 100)) { Gb1 = 9.70; Gm1 = 8.11; Qb1 = 100; Qm1 = 70; }
                if ((Qe2 >= 70) && (Qe2 < 100)) { Gb2 = 9.70; Gm2 = 8.11; Qb2 = 100; Qm2 = 70; }
                if ((Qe1 >= 100) && (Qe1 < 300)) { Gb1 = 17.6; Gm1 = 9.70; Qb1 = 300; Qm1 = 100; }
                if ((Qe2 >= 100) && (Qe2 < 300)) { Gb2 = 17.6; Gm2 = 9.70; Qb2 = 300; Qm2 = 100; }
                if ((Qe1 >= 300) && (Qe1 < 500)) { Gb1 = 23.5; Gm1 = 17.6; Qb1 = 500; Qm1 = 300; }
                if ((Qe2 >= 300) && (Qe2 < 500)) { Gb2 = 23.5; Gm2 = 17.6; Qb2 = 500; Qm2 = 300; }
                if ((Qe1 >= 500) && (Qe1 < 1000)) { Gb1 = 34.98; Gm1 = 23.5; Qb1 = 1000; Qm1 = 500; }
                if ((Qe2 >= 500) && (Qe2 < 1000)) { Gb2 = 34.98; Gm2 = 23.5; Qb2 = 1000; Qm2 = 500; }
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
            Txh = Math.Truncate(Tx);
            Txm = (Tx - Txh) * 60;
            //Площадь возможного заражения
            Sp = 8.72 * Math.Pow(10,-3) * Math.Pow(G,2) * f;
            //Площадь фактического зажения АХОВ
            Sf = Kv * Math.Pow(G, 2) * Math.Pow(N, 0.2);
            //Вычисляем долю незащищенного населения в городе и загородной зоне
            N11 = n1g * 0.01; N12 = n1z * 0.01;
            N21 = n2g * 0.01; N22 = n2z * 0.01;
            Kg = 1 - N11 - N21;
            Kz = 1 - N12 - N22;
            //Величина возможных потерь населения в очаге поражения АХОВ
            Pg = (X / G) * Ag * Kg;
            Pz = (1 - (X / G)) * Az * Kz;
            P0 = Math.Truncate(Sf * (Pg + Pz));
            P1 = Math.Truncate(P0 * 0.35);
            P2 = Math.Truncate(P0 * 0.4);
            P3 = Math.Truncate(P0 * 0.25);
            //Открытие формы с результатом
            if (F < 0)
            {
                MessageBox.Show("Укажите реальную площадь общего поддона (обвалования)!",
                    "Уточните параметры!", MessageBoxButtons.OK);
            }
            else
            {

                if (H < 0)
                {
                    MessageBox.Show("Укажите реальную высоту поддона (обвалования)!",
                        "Уточните параметры!", MessageBoxButtons.OK);
                }
                else 
                {
                    if ((n1g < 0) || (n1g > 100))
                    {
                        MessageBox.Show("Введите реальные данные для " +
                            "'Обеспеченные противогазами населения в городе'!",
                        "Уточните параметры!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if ((n1z < 0) || (n1z > 100))
                        {
                            MessageBox.Show("Введите реальные данные для " +
                                "'Обеспеченные противогазами населения в загoродной зоне'!",
                            "Уточните параметры!", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if ((n2g < 0) || (n2g > 100))
                            {
                                MessageBox.Show("Введите реальные данные для " +
                                    "'Обеспеченные убежищами населения в городе'!",
                                "Уточните параметры!", MessageBoxButtons.OK);
                            }
                            else
                            {
                                if ((n2z < 0) || (n2z > 100))
                                {
                                    MessageBox.Show("Введите реальные данные для " +
                                        "'Обеспеченные убежищами населения в загородной зоне'!",
                                    "Уточните параметры!", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    if (v < 0)
                                    {
                                        MessageBox.Show("Введите реальные данные для " +
                                        "параметра 'Скорость ветра'!",
                                    "Уточните параметры!", MessageBoxButtons.OK);
                                    }
                                    else
                                    {
                                        if (Q0 < 0)
                                        {
                                            MessageBox.Show("Введите реальные данные для " +
                                            "поля 'АХОВ, выброшеные в окружающую среду'!",
                                        "Уточните параметры!", MessageBoxButtons.OK);
                                        }
                                        else
                                        {
                                            new Form2().Show();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public void EXITbutt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}