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
            Txh,Txm,Txh1,Txm1,//часы и минуты по отдельности для визуального оформления
            Tsut,//время суток
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
            Kgk,//коэффициент населения в городе
            Kzk,//коэффициент населения в загородной зоне
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

        private void substance1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (substance1.Text == "")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Хлор")
            {
                jid1.Visible = true;
                gaz1.Visible = true;
            }
            if (substance1.Text == "Аммиак")
            {
                jid1.Visible = true;
                gaz1.Visible = true;
            }
            if (substance1.Text == "Водород хлористый")
            {
                jid1.Visible = true;
                gaz1.Visible = true;
            }
            if (substance1.Text == "Водород бромистый")
            {
                jid1.Visible = true;
                gaz1.Visible = true;
            }
            if (substance1.Text == "Сероводород")
            {
                jid1.Visible = true;
                gaz1.Visible = true;
            }
            if (substance1.Text == "Фосген")
            {
                jid1.Visible = true;
                gaz1.Visible = true;
            }
            if (substance1.Text == "Фтор")
            {
                jid1.Visible = true;
                gaz1.Visible = true;
            }
            if (substance1.Text == "Хлорициан")
            {
                jid1.Visible = true;
                gaz1.Visible = true;
            }
            if (substance1.Text == "Водород мышьяковистый")
            {
                jid1.Visible = true;
                gaz1.Visible = true;
            }
            if (substance1.Text == "Диметиламин")
            {
                jid1.Visible = true;
                gaz1.Visible = true;
            }
            if (substance1.Text == "Метиламин")
            {
                jid1.Visible = true;
                gaz1.Visible = true;
            }
            if (substance1.Text == "Метил Хлористый")
            {
                jid1.Visible = true;
                gaz1.Visible = true;
            }
            if (substance1.Text == "Водород фтористый")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Водород цианистый")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Двуокись азота")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Сернистый ангидрид")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Сероуглерод")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Соляная кислота")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Формальдегид")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Акролеин")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Ацетонитрил")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Ацетонциангидрин")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Метил бромистый")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Метилакрилат")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Метилмеркаптан")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Нитрил акриловой кислоты")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Окись этилена")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Триметиламин")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Фосфор треххлористый")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Фосфора хлорокись")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Хлорпикрин")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Этиленимин")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Этиленсульфид")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
            if (substance1.Text == "Этилмеркаптан")
            {
                jid1.Visible = false;
                gaz1.Visible = false;
            }
        }

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
            substance.Items.Add("Акролеин");
            substance.Items.Add("Аммиак");
            substance.Items.Add("Ацетонитрил");
            substance.Items.Add("Ацетонциангидрин");
            substance.Items.Add("Водород мышьяковистый");
            substance.Items.Add("Водород фтористый");
            substance.Items.Add("Водород хлористый");
            substance.Items.Add("Водород бромистый");
            substance.Items.Add("Водород цианистый");
            substance.Items.Add("Диметиламин");
            substance.Items.Add("Метиламин");
            substance.Items.Add("Метил Хлористый");
            substance.Items.Add("Метил бромистый");
            substance.Items.Add("Метилакрилат");
            substance.Items.Add("Метилмеркаптан");
            substance.Items.Add("Нитрил акриловой кислоты");
            substance.Items.Add("Двуокись азота");
            substance.Items.Add("Окись этилена");
            substance.Items.Add("Сернистый ангидрид");
            substance.Items.Add("Сероводород");
            substance.Items.Add("Сероуглерод");
            substance.Items.Add("Соляная кислота");
            substance.Items.Add("Триметиламин");
            substance.Items.Add("Формальдегид");
            substance.Items.Add("Фосген");
            substance.Items.Add("Фтор");
            substance.Items.Add("Фосфор треххлористый");
            substance.Items.Add("Фосфора хлорокись");
            substance.Items.Add("Хлор");
            substance.Items.Add("Хлорпикрин");
            substance.Items.Add("Хлорциан");
            substance.Items.Add("Этиленимин");
            substance.Items.Add("Этиленсульфид");
            substance.Items.Add("Этилмеркаптан");
            //Добавление АХОВ1
            substance1.Items.Add("Акролеин");
            substance1.Items.Add("Аммиак");
            substance1.Items.Add("Ацетонитрил");
            substance1.Items.Add("Ацетонциангидрин");
            substance1.Items.Add("Водород мышьяковистый");
            substance1.Items.Add("Водород фтористый");
            substance1.Items.Add("Водород хлористый");
            substance1.Items.Add("Водород бромистый");
            substance1.Items.Add("Водород цианистый");
            substance1.Items.Add("Диметиламин");
            substance1.Items.Add("Метиламин");
            substance1.Items.Add("Метил Хлористый");
            substance1.Items.Add("Метил бромистый");
            substance1.Items.Add("Метилакрилат");
            substance1.Items.Add("Метилмеркаптан");
            substance1.Items.Add("Нитрил акриловой кислоты");
            substance1.Items.Add("Двуокись азота");
            substance1.Items.Add("Окись этилена");
            substance1.Items.Add("Сернистый ангидрид");
            substance1.Items.Add("Сероводород");
            substance1.Items.Add("Сероуглерод");
            substance1.Items.Add("Соляная кислота");
            substance1.Items.Add("Триметиламин");
            substance1.Items.Add("Формальдегид");
            substance1.Items.Add("Фосген");
            substance1.Items.Add("Фтор");
            substance1.Items.Add("Фосфор треххлористый");
            substance1.Items.Add("Фосфора хлорокись");
            substance1.Items.Add("Хлор");
            substance1.Items.Add("Хлорпикрин");
            substance1.Items.Add("Хлорциан");
            substance1.Items.Add("Этиленимин");
            substance1.Items.Add("Этиленсульфид");
            substance1.Items.Add("Этилмеркаптан");
            //Добавление АХОВ2
            substance2.Items.Add("Акролеин");
            substance2.Items.Add("Аммиак");
            substance2.Items.Add("Ацетонитрил");
            substance2.Items.Add("Ацетонциангидрин");
            substance2.Items.Add("Водород мышьяковистый");
            substance2.Items.Add("Водород фтористый");
            substance2.Items.Add("Водород хлористый");
            substance2.Items.Add("Водород бромистый");
            substance2.Items.Add("Водород цианистый");
            substance2.Items.Add("Диметиламин");
            substance2.Items.Add("Метиламин");
            substance2.Items.Add("Метил Хлористый");
            substance2.Items.Add("Метил бромистый");
            substance2.Items.Add("Метилакрилат");
            substance2.Items.Add("Метилмеркаптан");
            substance2.Items.Add("Нитрил акриловой кислоты");
            substance2.Items.Add("Двуокись азота");
            substance2.Items.Add("Окись этилена");
            substance2.Items.Add("Сернистый ангидрид");
            substance2.Items.Add("Сероводород");
            substance2.Items.Add("Сероуглерод");
            substance2.Items.Add("Соляная кислота");
            substance2.Items.Add("Триметиламин");
            substance2.Items.Add("Формальдегид");
            substance2.Items.Add("Фосген");
            substance2.Items.Add("Фтор");
            substance2.Items.Add("Фосфор треххлористый");
            substance2.Items.Add("Фосфора хлорокись");
            substance2.Items.Add("Хлор");
            substance2.Items.Add("Хлорпикрин");
            substance2.Items.Add("Хлорциан");
            substance2.Items.Add("Этиленимин");
            substance2.Items.Add("Этиленсульфид");
            substance2.Items.Add("Этилмеркаптан");
            //Добавление АХОВ3
            substance3.Items.Add("Акролеин");
            substance3.Items.Add("Аммиак");
            substance3.Items.Add("Ацетонитрил");
            substance3.Items.Add("Ацетонциангидрин");
            substance3.Items.Add("Водород мышьяковистый");
            substance3.Items.Add("Водород фтористый");
            substance3.Items.Add("Водород хлористый");
            substance3.Items.Add("Водород бромистый");
            substance3.Items.Add("Водород цианистый");
            substance3.Items.Add("Диметиламин");
            substance3.Items.Add("Метиламин");
            substance3.Items.Add("Метил Хлористый");
            substance3.Items.Add("Метил бромистый");
            substance3.Items.Add("Метилакрилат");
            substance3.Items.Add("Метилмеркаптан");
            substance3.Items.Add("Нитрил акриловой кислоты");
            substance3.Items.Add("Двуокись азота");
            substance3.Items.Add("Окись этилена");
            substance3.Items.Add("Сернистый ангидрид");
            substance3.Items.Add("Сероводород");
            substance3.Items.Add("Сероуглерод");
            substance3.Items.Add("Соляная кислота");
            substance3.Items.Add("Триметиламин");
            substance3.Items.Add("Формальдегид");
            substance3.Items.Add("Фосген");
            substance3.Items.Add("Фтор");
            substance3.Items.Add("Фосфор треххлористый");
            substance3.Items.Add("Фосфора хлорокись");
            substance3.Items.Add("Хлор");
            substance3.Items.Add("Хлорпикрин");
            substance3.Items.Add("Хлорциан");
            substance3.Items.Add("Этиленимин");
            substance3.Items.Add("Этиленсульфид");
            substance3.Items.Add("Этилмеркаптан");
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
            //Присваивание параметров АХОВ
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
            if (substance.Text == "Водород мышьяковистый")
            {
                jid.Visible = true;
                gaz.Visible = true;
            }
            if (substance.Text == "Диметиламин")
            {
                jid.Visible = true;
                gaz.Visible = true;
            }
            if (substance.Text == "Метиламин")
            {
                jid.Visible = true;
                gaz.Visible = true;
            }
            if (substance.Text == "Метил Хлористый")
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
            if (substance.Text == "Акролеин")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Ацетонитрил")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Ацетонциангидрин")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Метил бромистый")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Метилакрилат")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Метилмеркаптан")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Нитрил акриловой кислоты")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Окись этилена")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Триметиламин")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Фосфор треххлористый")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Фосфора хлорокись")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Хлорпикрин")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Этиленимин")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Этиленсульфид")
            {
                jid.Visible = false;
                gaz.Visible = false;
            }
            if (substance.Text == "Этилмеркаптан")
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
            ///
            if (timeday.Text == "") { Tsut = 0; }
            else { Tsut = Convert.ToDouble(timeday.Text); }
            //Присваивание параметров для вертикальной устойчивости атмосферы
            if (vertUst.Text == "Инверсия")
            {
                verUstAir.Inversia();
            }
            if (vertUst.Text == "Изотермия")
            {
                verUstAir.Izotermia();
            }
            if (vertUst.Text == "Конвекция")
            {
                verUstAir.Konvekcia();
            }
            //Выбор химически опасного вещества
            ///////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////
            //if (substance.Text == "")
            //{
            //    substanceAXOB.Ammiak();
            //    //Выбор АХОВ с агрегатным состоянием
            //    p = 0.681;
            //    if (t < tkip) { K7 = K72; }
            //}
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
                    p = 0.681;
                    if (t < tkip) { K7 = K72; }
                }
                if (gaz.Checked)
                {
                    p = 0.0008;
                }
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
            if (substance.Text == "Водород мышьяковистый")
            {

                //Выбор АХОВ с агрегатным состоянием
                if (jid.Checked)
                {
                    p = 1.64;
                    if (t < tkip) { K7 = K72; }
                }
                if (gaz.Checked)
                {
                    p = 0.0035;
                }
            }
            if (substance.Text == "Диметиламин")
            {

                //Выбор АХОВ с агрегатным состоянием
                if (jid.Checked)
                {
                    p = 0.680;
                    if (t < tkip) { K7 = K72; }
                }
                if (gaz.Checked)
                {
                    p = 0.0020;
                }
            }
            if (substance.Text == "Метиламин")
            {

                //Выбор АХОВ с агрегатным состоянием
                if (jid.Checked)
                {
                    p = 0.699;
                    if (t < tkip) { K7 = K72; }
                }
                if (gaz.Checked)
                {
                    p = 0.0014;
                }
            }
            if (substance.Text == "Метил Хлористый")
            {

                //Выбор АХОВ с агрегатным состоянием
                if (jid.Checked)
                {
                    p = 0.983;
                    if (t < tkip) { K7 = K72; }
                }
                if (gaz.Checked)
                {
                    p = 0.0023;
                }
            }
            if (substance.Text == "Водород фтористый")
            {
                substanceAXOB.VodorodFtoristiy();
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
            if (substance.Text == "Акролеин")
            {
                substanceAXOB.Akrolein();
            }
            if (substance.Text == "Ацетонитрил")
            {
                substanceAXOB.Azetonitril();
            }
            if (substance.Text == "Ацетонциангидрин")
            {
                substanceAXOB.Azetonziangidrin();
            }
            if (substance.Text == "Метил бромистый")
            {
                substanceAXOB.MetilBrom();
            }
            if (substance.Text == "Метилакрилат")
            {
                substanceAXOB.Metilakrilat();
            }
            if (substance.Text == "Метилмеркаптан")
            {
                substanceAXOB.Metilmerkaptan();
            }
            if (substance.Text == "Нитрил акриловой кислоты")
            {
                substanceAXOB.NitrilAkrilKisl();
            }
            if (substance.Text == "Окись этилена")
            {
                substanceAXOB.OkisEtilen();
            }
            if (substance.Text == "Триметиламин")
            {
                substanceAXOB.Trimetilamin();
            }
            if (substance.Text == "Фосфор треххлористый")
            {
                substanceAXOB.FosforTrehchlor();
            }
            if (substance.Text == "Фосфора хлорокись")
            {
                substanceAXOB.FosforaChlorokis();
            }
            if (substance.Text == "Хлорпикрин")
            {
                substanceAXOB.Chlorpikrin();
            }
            if (substance.Text == "Этиленимин")
            {
                substanceAXOB.Etilenimin();
            }
            if (substance.Text == "Этиленсульфид")
            {
                substanceAXOB.Etilensulfid();
            }
            if (substance.Text == "Этилмеркаптан")
            {
                substanceAXOB.Etilmerkaptan();
            }
            /////////////////////////////////////////
            //Выбор химически опасного вещества1/////
            /////////////////////////////////////////
            if (substance1.Text == "Хлор")
            {
                substanceAXOB1.Chlor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid1.Checked)
                {
                    p1 = 1.553;
                    if (t < tkip1) { K711 = K721; }
                }
                if (gaz1.Checked)
                {
                    p1 = 0.0032;
                }
            }
            if (substance1.Text == "Аммиак")
            {
                substanceAXOB.Ammiak();
                //Выбор АХОВ с агрегатным состоянием
                if (jid.Checked)
                {
                    p = 0.681;
                    if (t < tkip) { K7 = K72; }
                }
                if (gaz.Checked)
                {
                    p = 0.0008;
                }
            }
            if (substance1.Text == "Водород хлористый")
            {
                substanceAXOB1.VodorodChlor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid1.Checked)
                {
                    p1 = 1.191;
                    if (t < tkip1) { K711 = K721; }
                }
                if (gaz1.Checked)
                {
                    p1 = 0.0016;
                }
            }
            if (substance1.Text == "Водород бромистый")
            {
                substanceAXOB1.VodorodBrom();
                //Выбор АХОВ с агрегатным состоянием
                if (jid1.Checked)
                {
                    p1 = 1.49;
                    if (t < tkip1) { K711 = K721; }
                }
                if (gaz1.Checked)
                {
                    p1 = 0.0036;
                }
            }
            if (substance1.Text == "Фосген")
            {
                substanceAXOB1.Fosgen();
                //Выбор АХОВ с агрегатным состоянием
                if (jid1.Checked)
                {
                    p1 = 1.432;
                    if (t < tkip1) { K711 = K721; }
                }
                if (gaz1.Checked)
                {
                    p1 = 0.0035;
                }
            }
            if (substance1.Text == "Фтор")
            {
                substanceAXOB1.Ftor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid1.Checked)
                {
                    p1 = 1.512;
                    if (t < tkip1) { K711 = K721; }
                }
                if (gaz1.Checked)
                {
                    p1 = 0.0017;
                }
            }
            if (substance1.Text == "Хлорциан")
            {
                substanceAXOB1.Chlorician();
                //Выбор АХОВ с агрегатным состоянием
                if (jid1.Checked)
                {
                    p1 = 1.22;
                    if (t < tkip1) { K711 = K721; }
                }
                if (gaz1.Checked)
                {
                    p1 = 0.0021;
                }
            }
            /////////////////////////////////////////////////
            if (substance1.Text == "Водород мышьяковистый")
            {
                substanceAXOB1.VodorodMishyak();
                //Выбор АХОВ с агрегатным состоянием
                if (jid1.Checked)
                {
                    p1 = 1.64;
                    if (t < tkip1) { K711 = K721; }
                }
                if (gaz1.Checked)
                {
                    p1 = 0.0035;
                }
            }
            if (substance1.Text == "Диметиламин")
            {
                substanceAXOB1.Dimetilamin();
                //Выбор АХОВ с агрегатным состоянием
                if (jid1.Checked)
                {
                    p1 = 0.680;
                    if (t < tkip1) { K711 = K721; }
                }
                if (gaz1.Checked)
                {
                    p1 = 0.0020;
                }
            }
            if (substance1.Text == "Метиламин")
            {
                substanceAXOB1.Metilamin();
                //Выбор АХОВ с агрегатным состоянием
                if (jid1.Checked)
                {
                    p1 = 0.699;
                    if (t < tkip1) { K711 = K721; }
                }
                if (gaz1.Checked)
                {
                    p1 = 0.0014;
                }
            }
            if (substance1.Text == "Метил Хлористый")
            {
                substanceAXOB1.MetilChlor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid1.Checked)
                {
                    p1 = 0.983;
                    if (t < tkip1) { K711 = K721; }
                }
                if (gaz1.Checked)
                {
                    p1 = 0.0023;
                }
            }
            if (substance1.Text == "Водород фтористый")
            {
                substanceAXOB1.VodorodFtoristiy();
            }
            if (substance1.Text == "Водород цианистый")
            {
                substanceAXOB1.VodorodCianistiy();
            }
            if (substance1.Text == "Двуокись азота")
            {
                substanceAXOB1.DvuokisAzota();
            }
            if (substance1.Text == "Сернистый ангидрид")
            {
                substanceAXOB1.SernistiyAngidrid();
            }
            if (substance1.Text == "Сероводород")
            {
                substanceAXOB1.Serovodorod();
            }
            if (substance1.Text == "Сероуглерод")
            {
                substanceAXOB1.Serouglerod();
            }
            if (substance1.Text == "Соляная кислота")
            {
                substanceAXOB1.SolyanayaKislota();
            }
            if (substance1.Text == "Формальдегид")
            {
                substanceAXOB1.Formaldegid();
            }
            ///////////////////////////////
            if (substance1.Text == "Акролеин")
            {
                substanceAXOB1.Akrolein();
            }
            if (substance1.Text == "Ацетонитрил")
            {
                substanceAXOB1.Azetonitril();
            }
            if (substance1.Text == "Ацетонциангидрин")
            {
                substanceAXOB1.Azetonziangidrin();
            }
            if (substance1.Text == "Метил бромистый")
            {
                substanceAXOB1.MetilBrom();
            }
            if (substance1.Text == "Метилакрилат")
            {
                substanceAXOB1.Metilakrilat();
            }
            if (substance1.Text == "Метилмеркаптан")
            {
                substanceAXOB1.Metilmerkaptan();
            }
            if (substance1.Text == "Нитрил акриловой кислоты")
            {
                substanceAXOB1.NitrilAkrilKisl();
            }
            if (substance1.Text == "Окись этилена")
            {
                substanceAXOB1.OkisEtilen();
            }
            if (substance1.Text == "Триметиламин")
            {
                substanceAXOB1.Trimetilamin();
            }
            if (substance1.Text == "Фосфор треххлористый")
            {
                substanceAXOB1.FosforTrehchlor();
            }
            if (substance1.Text == "Фосфора хлорокись")
            {
                substanceAXOB1.FosforaChlorokis();
            }
            if (substance1.Text == "Хлорпикрин")
            {
                substanceAXOB1.Chlorpikrin();
            }
            if (substance1.Text == "Этиленимин")
            {
                substanceAXOB1.Etilenimin();
            }
            if (substance1.Text == "Этиленсульфид")
            {
                substanceAXOB1.Etilensulfid();
            }
            if (substance1.Text == "Этилмеркаптан")
            {
                substanceAXOB1.Etilmerkaptan();
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
                substanceAXOB.Ammiak();
                //Выбор АХОВ с агрегатным состоянием
                if (jid.Checked)
                {
                    p = 0.681;
                    if (t < tkip) { K7 = K72; }
                }
                if (gaz.Checked)
                {
                    p = 0.0008;
                }
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
            if (substance2.Text == "Водород фтористый")
            {
                substanceAXOB2.VodorodFtoristiy();
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
            if (substance2.Text == "Акролеин")
            {
                substanceAXOB2.Akrolein();
            }
            if (substance2.Text == "Ацетонитрил")
            {
                substanceAXOB2.Azetonitril();
            }
            if (substance2.Text == "Ацетонциангидрин")
            {
                substanceAXOB2.Azetonziangidrin();
            }
            if (substance2.Text == "Метил бромистый")
            {
                substanceAXOB2.MetilBrom();
            }
            if (substance2.Text == "Метилакрилат")
            {
                substanceAXOB2.Metilakrilat();
            }
            if (substance2.Text == "Метилмеркаптан")
            {
                substanceAXOB2.Metilmerkaptan();
            }
            if (substance2.Text == "Нитрил акриловой кислоты")
            {
                substanceAXOB2.NitrilAkrilKisl();
            }
            if (substance2.Text == "Окись этилена")
            {
                substanceAXOB2.OkisEtilen();
            }
            if (substance2.Text == "Триметиламин")
            {
                substanceAXOB2.Trimetilamin();
            }
            if (substance2.Text == "Фосфор треххлористый")
            {
                substanceAXOB2.FosforTrehchlor();
            }
            if (substance2.Text == "Фосфора хлорокись")
            {
                substanceAXOB2.FosforaChlorokis();
            }
            if (substance2.Text == "Хлорпикрин")
            {
                substanceAXOB2.Chlorpikrin();
            }
            if (substance2.Text == "Этиленимин")
            {
                substanceAXOB2.Etilenimin();
            }
            if (substance2.Text == "Этиленсульфид")
            {
                substanceAXOB2.Etilensulfid();
            }
            if (substance2.Text == "Этилмеркаптан")
            {
                substanceAXOB2.Etilmerkaptan();
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
                    substanceAXOB.Ammiak();
                    //Выбор АХОВ с агрегатным состоянием
                    if (jid.Checked)
                    {
                        p = 0.681;
                        if (t < tkip) { K7 = K72; }
                    }
                    if (gaz.Checked)
                    {
                        p = 0.0008;
                    }
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
                if (substance3.Text == "Водород фтористый")
                {
                    substanceAXOB3.VodorodFtoristiy();
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
                if (substance3.Text == "Акролеин")
                {
                    substanceAXOB3.Akrolein();
                }
                if (substance3.Text == "Ацетонитрил")
                {
                    substanceAXOB3.Azetonitril();
                }
                if (substance3.Text == "Ацетонциангидрин")
                {
                    substanceAXOB3.Azetonziangidrin();
                }
                if (substance3.Text == "Метил бромистый")
                {
                    substanceAXOB3.MetilBrom();
                }
                if (substance3.Text == "Метилакрилат")
                {
                    substanceAXOB3.Metilakrilat();
                }
                if (substance3.Text == "Метилмеркаптан")
                {
                    substanceAXOB3.Metilmerkaptan();
                }
                if (substance3.Text == "Нитрил акриловой кислоты")
                {
                    substanceAXOB3.NitrilAkrilKisl();
                }
                if (substance3.Text == "Окись этилена")
                {
                    substanceAXOB3.OkisEtilen();
                }
                if (substance3.Text == "Триметиламин")
                {
                    substanceAXOB3.Trimetilamin();
                }
                if (substance3.Text == "Фосфор треххлористый")
                {
                    substanceAXOB3.FosforTrehchlor();
                }
                if (substance3.Text == "Фосфора хлорокись")
                {
                    substanceAXOB3.FosforaChlorokis();
                }
                if (substance3.Text == "Хлорпикрин")
                {
                    substanceAXOB3.Chlorpikrin();
                }
                if (substance3.Text == "Этиленимин")
                {
                    substanceAXOB3.Etilenimin();
                }
                if (substance3.Text == "Этиленсульфид")
                {
                    substanceAXOB3.Etilensulfid();
                }
                if (substance3.Text == "Этилмеркаптан")
                {
                    substanceAXOB3.Etilmerkaptan();
                }
            ///////////////////////////////////////////////
            //Выбор химически опасного вещества4///////////
            ///////////////////////////////////////////////
            if (substance4.Text == "Хлор")
            {
                substanceAXOB4.Chlor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid4.Checked)
                {
                    p4 = 1.553;
                    if (t < tkip4) { K74 = K724; }
                }
                if (gaz4.Checked)
                {
                    p4 = 0.0032;
                }
            }
            if (substance4.Text == "Аммиак")
            {
                substanceAXOB.Ammiak();
                //Выбор АХОВ с агрегатным состоянием
                if (jid.Checked)
                {
                    p = 0.681;
                    if (t < tkip) { K7 = K72; }
                }
                if (gaz.Checked)
                {
                    p = 0.0008;
                }
            }
            if (substance4.Text == "Водород хлористый")
            {
                substanceAXOB4.VodorodChlor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid4.Checked)
                {
                    p4 = 1.191;
                    if (t < tkip4) { K74 = K724; }
                }
                if (gaz4.Checked)
                {
                    p4 = 0.0016;
                }
            }
            if (substance4.Text == "Водород бромистый")
            {
                substanceAXOB4.VodorodBrom();
                //Выбор АХОВ с агрегатным состоянием
                if (jid4.Checked)
                {
                    p4 = 1.49;
                    if (t < tkip4) { K74 = K724; }
                }
                if (gaz4.Checked)
                {
                    p4 = 0.0036;
                }
            }
            if (substance4.Text == "Фосген")
            {
                substanceAXOB4.Fosgen();
                //Выбор АХОВ с агрегатным состоянием
                if (jid4.Checked)
                {
                    p4 = 1.432;
                    if (t < tkip4) { K74 = K724; }
                }
                if (gaz4.Checked)
                {
                    p4 = 0.0035;
                }
            }
            if (substance4.Text == "Фтор")
            {
                substanceAXOB4.Ftor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid4.Checked)
                {
                    p4 = 1.512;
                    if (t < tkip4) { K74 = K724; }
                }
                if (gaz4.Checked)
                {
                    p4 = 0.0017;
                }
            }
            if (substance4.Text == "Хлорциан")
            {
                substanceAXOB4.Chlorician();
                //Выбор АХОВ с агрегатным состоянием
                if (jid4.Checked)
                {
                    p4 = 1.22;
                    if (t < tkip4) { K74 = K724; }
                }
                if (gaz4.Checked)
                {
                    p4 = 0.0021;
                }
            }
            /////////////////////////////////////////////////
            if (substance4.Text == "Водород мышьяковистый")
            {
                substanceAXOB4.VodorodMishyak();
                //Выбор АХОВ с агрегатным состоянием
                if (jid4.Checked)
                {
                    p4 = 1.64;
                    if (t < tkip4) { K74 = K724; }
                }
                if (gaz4.Checked)
                {
                    p4 = 0.0035;
                }
            }
            if (substance4.Text == "Диметиламин")
            {
                substanceAXOB4.Dimetilamin();
                //Выбор АХОВ с агрегатным состоянием
                if (jid4.Checked)
                {
                    p4 = 0.680;
                    if (t < tkip4) { K74 = K724; }
                }
                if (gaz4.Checked)
                {
                    p4 = 0.0020;
                }
            }
            if (substance4.Text == "Метиламин")
            {
                substanceAXOB4.Metilamin();
                //Выбор АХОВ с агрегатным состоянием
                if (jid4.Checked)
                {
                    p4 = 0.699;
                    if (t < tkip4) { K74 = K724; }
                }
                if (gaz4.Checked)
                {
                    p4 = 0.0014;
                }
            }
            if (substance4.Text == "Метил Хлористый")
            {
                substanceAXOB4.MetilChlor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid4.Checked)
                {
                    p4 = 0.983;
                    if (t < tkip4) { K74 = K724; }
                }
                if (gaz4.Checked)
                {
                    p4 = 0.0023;
                }
            }
            if (substance4.Text == "Водород фтористый")
            {
                substanceAXOB4.VodorodFtoristiy();
            }
            if (substance4.Text == "Водород цианистый")
            {
                substanceAXOB4.VodorodCianistiy();
            }
            if (substance4.Text == "Двуокись азота")
            {
                substanceAXOB4.DvuokisAzota();
            }
            if (substance4.Text == "Сернистый ангидрид")
            {
                substanceAXOB4.SernistiyAngidrid();
            }
            if (substance4.Text == "Сероводород")
            {
                substanceAXOB4.Serovodorod();
            }
            if (substance4.Text == "Сероуглерод")
            {
                substanceAXOB4.Serouglerod();
            }
            if (substance4.Text == "Соляная кислота")
            {
                substanceAXOB4.SolyanayaKislota();
            }
            if (substance4.Text == "Формальдегид")
            {
                substanceAXOB4.Formaldegid();
            }
            ///////////////////////////////
            if (substance4.Text == "Акролеин")
            {
                substanceAXOB4.Akrolein();
            }
            if (substance4.Text == "Ацетонитрил")
            {
                substanceAXOB4.Azetonitril();
            }
            if (substance4.Text == "Ацетонциангидрин")
            {
                substanceAXOB4.Azetonziangidrin();
            }
            if (substance4.Text == "Метил бромистый")
            {
                substanceAXOB4.MetilBrom();
            }
            if (substance4.Text == "Метилакрилат")
            {
                substanceAXOB4.Metilakrilat();
            }
            if (substance4.Text == "Метилмеркаптан")
            {
                substanceAXOB4.Metilmerkaptan();
            }
            if (substance4.Text == "Нитрил акриловой кислоты")
            {
                substanceAXOB4.NitrilAkrilKisl();
            }
            if (substance4.Text == "Окись этилена")
            {
                substanceAXOB4.OkisEtilen();
            }
            if (substance4.Text == "Триметиламин")
            {
                substanceAXOB4.Trimetilamin();
            }
            if (substance4.Text == "Фосфор треххлористый")
            {
                substanceAXOB4.FosforTrehchlor();
            }
            if (substance4.Text == "Фосфора хлорокись")
            {
                substanceAXOB4.FosforaChlorokis();
            }
            if (substance4.Text == "Хлорпикрин")
            {
                substanceAXOB4.Chlorpikrin();
            }
            if (substance4.Text == "Этиленимин")
            {
                substanceAXOB4.Etilenimin();
            }
            if (substance4.Text == "Этиленсульфид")
            {
                substanceAXOB4.Etilensulfid();
            }
            if (substance4.Text == "Этилмеркаптан")
            {
                substanceAXOB4.Etilmerkaptan();
            }
            ///////////////////////////////////////////////
            //Выбор химически опасного вещества5///////////
            ///////////////////////////////////////////////
            if (substance5.Text == "Хлор")
            {
                substanceAXOB5.Chlor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid5.Checked)
                {
                    p5 = 1.553;
                    if (t < tkip5) { K75 = K725; }
                }
                if (gaz5.Checked)
                {
                    p5 = 0.0032;
                }
            }
            if (substance5.Text == "Аммиак")
            {
                substanceAXOB.Ammiak();
                //Выбор АХОВ с агрегатным состоянием
                if (jid.Checked)
                {
                    p = 0.681;
                    if (t < tkip) { K7 = K72; }
                }
                if (gaz.Checked)
                {
                    p = 0.0008;
                }
            }
            if (substance5.Text == "Водород хлористый")
            {
                substanceAXOB5.VodorodChlor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid5.Checked)
                {
                    p5 = 1.191;
                    if (t < tkip5) { K75 = K725; }
                }
                if (gaz5.Checked)
                {
                    p5 = 0.0016;
                }
            }
            if (substance5.Text == "Водород бромистый")
            {
                substanceAXOB5.VodorodBrom();
                //Выбор АХОВ с агрегатным состоянием
                if (jid5.Checked)
                {
                    p5 = 1.49;
                    if (t < tkip5) { K75 = K725; }
                }
                if (gaz5.Checked)
                {
                    p5 = 0.0036;
                }
            }
            if (substance5.Text == "Фосген")
            {
                substanceAXOB5.Fosgen();
                //Выбор АХОВ с агрегатным состоянием
                if (jid5.Checked)
                {
                    p5 = 1.432;
                    if (t < tkip5) { K75 = K725; }
                }
                if (gaz5.Checked)
                {
                    p5 = 0.0035;
                }
            }
            if (substance5.Text == "Фтор")
            {
                substanceAXOB5.Ftor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid5.Checked)
                {
                    p5 = 1.512;
                    if (t < tkip5) { K75 = K725; }
                }
                if (gaz5.Checked)
                {
                    p5 = 0.0017;
                }
            }
            if (substance5.Text == "Хлорциан")
            {
                substanceAXOB5.Chlorician();
                //Выбор АХОВ с агрегатным состоянием
                if (jid5.Checked)
                {
                    p5 = 1.22;
                    if (t < tkip5) { K75 = K725; }
                }
                if (gaz5.Checked)
                {
                    p5 = 0.0021;
                }
            }
            /////////////////////////////////////////////////
            if (substance5.Text == "Водород мышьяковистый")
            {
                substanceAXOB5.VodorodMishyak();
                //Выбор АХОВ с агрегатным состоянием
                if (jid5.Checked)
                {
                    p5 = 1.64;
                    if (t < tkip5) { K75 = K725; }
                }
                if (gaz5.Checked)
                {
                    p5 = 0.0035;
                }
            }
            if (substance5.Text == "Диметиламин")
            {
                substanceAXOB5.Dimetilamin();
                //Выбор АХОВ с агрегатным состоянием
                if (jid5.Checked)
                {
                    p5 = 0.680;
                    if (t < tkip5) { K75 = K725; }
                }
                if (gaz5.Checked)
                {
                    p5 = 0.0020;
                }
            }
            if (substance5.Text == "Метиламин")
            {
                substanceAXOB5.Metilamin();
                //Выбор АХОВ с агрегатным состоянием
                if (jid5.Checked)
                {
                    p5 = 0.699;
                    if (t < tkip5) { K75 = K725; }
                }
                if (gaz5.Checked)
                {
                    p5 = 0.0014;
                }
            }
            if (substance5.Text == "Метил Хлористый")
            {
                substanceAXOB5.MetilChlor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid5.Checked)
                {
                    p5 = 0.983;
                    if (t < tkip5) { K75 = K725; }
                }
                if (gaz5.Checked)
                {
                    p5 = 0.0023;
                }
            }
            if (substance5.Text == "Водород фтористый")
            {
                substanceAXOB5.VodorodFtoristiy();
            }
            if (substance5.Text == "Водород цианистый")
            {
                substanceAXOB5.VodorodCianistiy();
            }
            if (substance5.Text == "Двуокись азота")
            {
                substanceAXOB5.DvuokisAzota();
            }
            if (substance5.Text == "Сернистый ангидрид")
            {
                substanceAXOB5.SernistiyAngidrid();
            }
            if (substance5.Text == "Сероводород")
            {
                substanceAXOB5.Serovodorod();
            }
            if (substance5.Text == "Сероуглерод")
            {
                substanceAXOB5.Serouglerod();
            }
            if (substance5.Text == "Соляная кислота")
            {
                substanceAXOB5.SolyanayaKislota();
            }
            if (substance5.Text == "Формальдегид")
            {
                substanceAXOB5.Formaldegid();
            }
            ///////////////////////////////
            if (substance5.Text == "Акролеин")
            {
                substanceAXOB5.Akrolein();
            }
            if (substance5.Text == "Ацетонитрил")
            {
                substanceAXOB5.Azetonitril();
            }
            if (substance5.Text == "Ацетонциангидрин")
            {
                substanceAXOB5.Azetonziangidrin();
            }
            if (substance5.Text == "Метил бромистый")
            {
                substanceAXOB5.MetilBrom();
            }
            if (substance5.Text == "Метилакрилат")
            {
                substanceAXOB5.Metilakrilat();
            }
            if (substance5.Text == "Метилмеркаптан")
            {
                substanceAXOB5.Metilmerkaptan();
            }
            if (substance5.Text == "Нитрил акриловой кислоты")
            {
                substanceAXOB5.NitrilAkrilKisl();
            }
            if (substance5.Text == "Окись этилена")
            {
                substanceAXOB5.OkisEtilen();
            }
            if (substance5.Text == "Триметиламин")
            {
                substanceAXOB5.Trimetilamin();
            }
            if (substance5.Text == "Фосфор треххлористый")
            {
                substanceAXOB5.FosforTrehchlor();
            }
            if (substance5.Text == "Фосфора хлорокись")
            {
                substanceAXOB5.FosforaChlorokis();
            }
            if (substance5.Text == "Хлорпикрин")
            {
                substanceAXOB5.Chlorpikrin();
            }
            if (substance5.Text == "Этиленимин")
            {
                substanceAXOB5.Etilenimin();
            }
            if (substance5.Text == "Этиленсульфид")
            {
                substanceAXOB5.Etilensulfid();
            }
            if (substance5.Text == "Этилмеркаптан")
            {
                substanceAXOB5.Etilmerkaptan();
            }
            ///////////////////////////////////////////////
            //Выбор химически опасного вещества6///////////
            ///////////////////////////////////////////////
            if (substance6.Text == "Хлор")
            {
                substanceAXOB6.Chlor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid6.Checked)
                {
                    p6 = 1.553;
                    if (t < tkip6) { K76 = K726; }
                }
                if (gaz6.Checked)
                {
                    p6 = 0.0032;
                }
            }
            if (substance6.Text == "Аммиак")
            {
                substanceAXOB.Ammiak();
                //Выбор АХОВ с агрегатным состоянием
                if (jid.Checked)
                {
                    p = 0.681;
                    if (t < tkip) { K7 = K72; }
                }
                if (gaz.Checked)
                {
                    p = 0.0008;
                }
            }
            if (substance6.Text == "Водород хлористый")
            {
                substanceAXOB6.VodorodChlor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid6.Checked)
                {
                    p6 = 1.191;
                    if (t < tkip6) { K76 = K726; }
                }
                if (gaz6.Checked)
                {
                    p6 = 0.0016;
                }
            }
            if (substance6.Text == "Водород бромистый")
            {
                substanceAXOB6.VodorodBrom();
                //Выбор АХОВ с агрегатным состоянием
                if (jid6.Checked)
                {
                    p6 = 1.49;
                    if (t < tkip6) { K76 = K726; }
                }
                if (gaz6.Checked)
                {
                    p6 = 0.0036;
                }
            }
            if (substance6.Text == "Фосген")
            {
                substanceAXOB6.Fosgen();
                //Выбор АХОВ с агрегатным состоянием
                if (jid6.Checked)
                {
                    p6 = 1.432;
                    if (t < tkip6) { K76 = K726; }
                }
                if (gaz6.Checked)
                {
                    p6 = 0.0035;
                }
            }
            if (substance6.Text == "Фтор")
            {
                substanceAXOB6.Ftor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid6.Checked)
                {
                    p6 = 1.512;
                    if (t < tkip6) { K76 = K726; }
                }
                if (gaz6.Checked)
                {
                    p6 = 0.0017;
                }
            }
            if (substance6.Text == "Хлорциан")
            {
                substanceAXOB6.Chlorician();
                //Выбор АХОВ с агрегатным состоянием
                if (jid6.Checked)
                {
                    p6 = 1.22;
                    if (t < tkip6) { K76 = K726; }
                }
                if (gaz6.Checked)
                {
                    p6 = 0.0021;
                }
            }
            /////////////////////////////////////////////////
            if (substance6.Text == "Водород мышьяковистый")
            {
                substanceAXOB6.VodorodMishyak();
                //Выбор АХОВ с агрегатным состоянием
                if (jid6.Checked)
                {
                    p6 = 1.64;
                    if (t < tkip6) { K76 = K726; }
                }
                if (gaz6.Checked)
                {
                    p6 = 0.0035;
                }
            }
            if (substance6.Text == "Диметиламин")
            {
                substanceAXOB6.Dimetilamin();
                //Выбор АХОВ с агрегатным состоянием
                if (jid6.Checked)
                {
                    p6 = 0.680;
                    if (t < tkip6) { K76 = K726; }
                }
                if (gaz6.Checked)
                {
                    p6 = 0.0020;
                }
            }
            if (substance6.Text == "Метиламин")
            {
                substanceAXOB6.Metilamin();
                //Выбор АХОВ с агрегатным состоянием
                if (jid6.Checked)
                {
                    p6 = 0.699;
                    if (t < tkip6) { K76 = K726; }
                }
                if (gaz6.Checked)
                {
                    p6 = 0.0014;
                }
            }
            if (substance6.Text == "Метил Хлористый")
            {
                substanceAXOB6.MetilChlor();
                //Выбор АХОВ с агрегатным состоянием
                if (jid6.Checked)
                {
                    p6 = 0.983;
                    if (t < tkip6) { K76 = K726; }
                }
                if (gaz6.Checked)
                {
                    p6 = 0.0023;
                }
            }
            if (substance6.Text == "Водород фтористый")
            {
                substanceAXOB6.VodorodFtoristiy();
            }
            if (substance6.Text == "Водород цианистый")
            {
                substanceAXOB6.VodorodCianistiy();
            }
            if (substance6.Text == "Двуокись азота")
            {
                substanceAXOB6.DvuokisAzota();
            }
            if (substance6.Text == "Сернистый ангидрид")
            {
                substanceAXOB6.SernistiyAngidrid();
            }
            if (substance6.Text == "Сероводород")
            {
                substanceAXOB6.Serovodorod();
            }
            if (substance6.Text == "Сероуглерод")
            {
                substanceAXOB6.Serouglerod();
            }
            if (substance6.Text == "Соляная кислота")
            {
                substanceAXOB6.SolyanayaKislota();
            }
            if (substance6.Text == "Формальдегид")
            {
                substanceAXOB6.Formaldegid();
            }
            ///////////////////////////////
            if (substance6.Text == "Акролеин")
            {
                substanceAXOB6.Akrolein();
            }
            if (substance6.Text == "Ацетонитрил")
            {
                substanceAXOB6.Azetonitril();
            }
            if (substance6.Text == "Ацетонциангидрин")
            {
                substanceAXOB6.Azetonziangidrin();
            }
            if (substance6.Text == "Метил бромистый")
            {
                substanceAXOB6.MetilBrom();
            }
            if (substance6.Text == "Метилакрилат")
            {
                substanceAXOB6.Metilakrilat();
            }
            if (substance6.Text == "Метилмеркаптан")
            {
                substanceAXOB6.Metilmerkaptan();
            }
            if (substance6.Text == "Нитрил акриловой кислоты")
            {
                substanceAXOB6.NitrilAkrilKisl();
            }
            if (substance6.Text == "Окись этилена")
            {
                substanceAXOB6.OkisEtilen();
            }
            if (substance6.Text == "Триметиламин")
            {
                substanceAXOB6.Trimetilamin();
            }
            if (substance6.Text == "Фосфор треххлористый")
            {
                substanceAXOB6.FosforTrehchlor();
            }
            if (substance6.Text == "Фосфора хлорокись")
            {
                substanceAXOB6.FosforaChlorokis();
            }
            if (substance6.Text == "Хлорпикрин")
            {
                substanceAXOB6.Chlorpikrin();
            }
            if (substance6.Text == "Этиленимин")
            {
                substanceAXOB6.Etilenimin();
            }
            if (substance6.Text == "Этиленсульфид")
            {
                substanceAXOB6.Etilensulfid();
            }
            if (substance6.Text == "Этилмеркаптан")
            {
                substanceAXOB6.Etilmerkaptan();
            }
            ///////////////////////////////////////////////////
            //Расчет высоты/площади поддона
            if (svob.Checked == true)
            {
                h = 0.05;
            }
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
            /*Коэффициенты защищенности населения в зависимости
             * от времени суток и времени года*/
            if (opovesh.Checked)
            {
                KoeffZ.GorOpovesh();
                if (periodSH.Checked)
                {
                    KoeffZ.SelOpovSH();
                }
                if (periodZIMA.Checked)
                {
                    KoeffZ.SelOpovZim();
                }
            }
            if (noopovesh.Checked)
            {
                KoeffZ.GorNeOpovesh();
                if (periodSH.Checked)
                {
                    KoeffZ.SelNeOpovSH();
                }
                if (periodZIMA.Checked)
                {
                    KoeffZ.SelNeOpovZim();
                }
            }
            //Угловые размеры возможного заражения АХОВ
            if (v <= 0.5) { f = 360; }
            if ((v > 0.5) && (v <= 1)) { f = 180; }
            if ((v > 1) && (v <= 2)) { f = 90; }
            if (v > 2) { f = 45; }
            //Расчет для одного вещества
            /////////////////////////////
            if (AXOBkolvo1.Checked)
            {
                //Коэффициенты К2, К3 и К4
                if (K2 == 0) { K2 = 6.08 * Math.Pow(10, -5) * P * Math.Pow(M, 0.5); }
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
                moreAXOB.koefAXOB();
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
                //Определение эквивалентного количества вещества по нескольким веществам
                Qe2 = (20 * K4 * K5) * 
                    (((K21 * K31 * K61 * K711 * Q01) / p + K22 * K32 * K62 * K72 * Q02) / p2 +
                    (K23 * K33 * K63 * K73 * Q03) / p3 + (K24 * K34 * K64 * K74 * Q04) / p4 +
                    (K25 * K35 * K65 * K75 * Q05) / p5 + (K26 * K36 * K66 * K76 * Q06) / p6);
                Qe1 = Qe2;
            }
            //Определение большего и меньшего кол-ва АХОВ и глубины заражения облаками 
            KolvoAndGlub.Tabl();
            //Глубина распространения первичного и вторичного облаков АХОВ
            Ge1 = Gm1 + ((Gb1 - Gm1) / (Qb1 - Qm1)) * (Qe1 - Qm1);
            Ge2 = Gm2 + ((Gb2 - Gm2) / (Qb2 - Qm2)) * (Qe2 - Qm2);
            if (Ge1 > Ge2)
            {
                Ge = Ge1 + 0.5 * Ge2;
            }
            else
            {
                Ge = Ge2 + 0.5 * Ge1;
            }
            Gp = N * W;
            if (Ge < Gp) { G = Ge; }
            else { G = Gp; }
            //Определение времени подхода облака зараженного АХОВ к населенным пунктам
            Txh1 = Math.Truncate(T);
            Txm1 = (T - Txh1) * 60;
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
                                            
                                            if ((AXOBkolvo1.Checked == false) && (AXOBkolvo2.Checked == false))
                                            {
                                                MessageBox.Show("Укажите количество АХОВ!",
                                    "Уточните параметры!", MessageBoxButtons.OK);
                                            }
                                            else
                                            {
                                                new Form3().Show();
                                            }
                                            
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