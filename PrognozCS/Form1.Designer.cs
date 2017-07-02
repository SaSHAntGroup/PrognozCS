namespace PrognozCS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.substance = new System.Windows.Forms.ComboBox();
            this.jid = new System.Windows.Forms.RadioButton();
            this.gaz = new System.Windows.Forms.RadioButton();
            this.vibAXOB = new System.Windows.Forms.Label();
            this.vertUst = new System.Windows.Forms.ComboBox();
            this.ustAtm = new System.Windows.Forms.Label();
            this.svob = new System.Windows.Forms.RadioButton();
            this.sam = new System.Windows.Forms.RadioButton();
            this.obsh = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.meter = new System.Windows.Forms.Label();
            this.plosh = new System.Windows.Forms.TextBox();
            this.ploshlabel = new System.Windows.Forms.Label();
            this.visPodlabel = new System.Windows.Forms.Label();
            this.visPod = new System.Windows.Forms.TextBox();
            this.timelabel = new System.Windows.Forms.Label();
            this.speedAirlabel = new System.Windows.Forms.Label();
            this.tempAirlabel = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.speedAir = new System.Windows.Forms.TextBox();
            this.tempAir = new System.Windows.Forms.TextBox();
            this.outAXOBlabel = new System.Windows.Forms.Label();
            this.outAXOB = new System.Windows.Forms.TextBox();
            this.distancelabel = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.TextBox();
            this.primichanie1 = new System.Windows.Forms.Label();
            this.primichanie3 = new System.Windows.Forms.Label();
            this.plotNasGlabel = new System.Windows.Forms.Label();
            this.plotNasZlabel = new System.Windows.Forms.Label();
            this.protivoGAZlabel = new System.Windows.Forms.Label();
            this.plotNasZ = new System.Windows.Forms.TextBox();
            this.plotNasG = new System.Windows.Forms.TextBox();
            this.GAZG = new System.Windows.Forms.Label();
            this.GAZZ = new System.Windows.Forms.Label();
            this.outGAZG = new System.Windows.Forms.TextBox();
            this.outGAZZ = new System.Windows.Forms.TextBox();
            this.ubejishelabel = new System.Windows.Forms.Label();
            this.outubejZ = new System.Windows.Forms.TextBox();
            this.outubejG = new System.Windows.Forms.TextBox();
            this.ubejZ = new System.Windows.Forms.Label();
            this.ubejG = new System.Windows.Forms.Label();
            this.percent1 = new System.Windows.Forms.Label();
            this.percent2 = new System.Windows.Forms.Label();
            this.percent3 = new System.Windows.Forms.Label();
            this.percent4 = new System.Windows.Forms.Label();
            this.celsium = new System.Windows.Forms.Label();
            this.MvS = new System.Windows.Forms.Label();
            this.kolvoTOHHlabel = new System.Windows.Forms.Label();
            this.menkm1 = new System.Windows.Forms.Label();
            this.menkm2 = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.km = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(10, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Произвести расчет";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(411, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // substance
            // 
            this.substance.FormattingEnabled = true;
            this.substance.Location = new System.Drawing.Point(14, 25);
            this.substance.Name = "substance";
            this.substance.Size = new System.Drawing.Size(254, 21);
            this.substance.TabIndex = 2;
            this.substance.SelectedIndexChanged += new System.EventHandler(this.substance_SelectedIndexChanged);
            // 
            // jid
            // 
            this.jid.AutoSize = true;
            this.jid.Location = new System.Drawing.Point(63, 46);
            this.jid.Name = "jid";
            this.jid.Size = new System.Drawing.Size(77, 17);
            this.jid.TabIndex = 3;
            this.jid.TabStop = true;
            this.jid.Text = "Жидкость";
            this.jid.UseVisualStyleBackColor = true;
            this.jid.Visible = false;
            // 
            // gaz
            // 
            this.gaz.AutoSize = true;
            this.gaz.Location = new System.Drawing.Point(14, 46);
            this.gaz.Name = "gaz";
            this.gaz.Size = new System.Drawing.Size(43, 17);
            this.gaz.TabIndex = 4;
            this.gaz.TabStop = true;
            this.gaz.Text = "Газ";
            this.gaz.UseVisualStyleBackColor = true;
            this.gaz.Visible = false;
            // 
            // vibAXOB
            // 
            this.vibAXOB.AutoSize = true;
            this.vibAXOB.Location = new System.Drawing.Point(14, 9);
            this.vibAXOB.Name = "vibAXOB";
            this.vibAXOB.Size = new System.Drawing.Size(72, 13);
            this.vibAXOB.TabIndex = 5;
            this.vibAXOB.Text = "Выбор АХОВ";
            // 
            // vertUst
            // 
            this.vertUst.FormattingEnabled = true;
            this.vertUst.Location = new System.Drawing.Point(274, 25);
            this.vertUst.Name = "vertUst";
            this.vertUst.Size = new System.Drawing.Size(255, 21);
            this.vertUst.TabIndex = 6;
            this.vertUst.Text = "Изотермия";
            // 
            // ustAtm
            // 
            this.ustAtm.AutoSize = true;
            this.ustAtm.Location = new System.Drawing.Point(271, 9);
            this.ustAtm.Name = "ustAtm";
            this.ustAtm.Size = new System.Drawing.Size(212, 13);
            this.ustAtm.TabIndex = 7;
            this.ustAtm.Text = "Вертикальная устойчивость атмосферы";
            // 
            // svob
            // 
            this.svob.AutoSize = true;
            this.svob.Location = new System.Drawing.Point(6, 19);
            this.svob.Name = "svob";
            this.svob.Size = new System.Drawing.Size(74, 17);
            this.svob.TabIndex = 8;
            this.svob.TabStop = true;
            this.svob.Text = "Свободно";
            this.svob.UseVisualStyleBackColor = true;
            this.svob.CheckedChanged += new System.EventHandler(this.svob_CheckedChanged);
            // 
            // sam
            // 
            this.sam.AutoSize = true;
            this.sam.Location = new System.Drawing.Point(6, 42);
            this.sam.Name = "sam";
            this.sam.Size = new System.Drawing.Size(169, 17);
            this.sam.TabIndex = 9;
            this.sam.TabStop = true;
            this.sam.Text = "В самостоятельный поддон ";
            this.sam.UseVisualStyleBackColor = true;
            this.sam.CheckedChanged += new System.EventHandler(this.sam_CheckedChanged);
            // 
            // obsh
            // 
            this.obsh.AutoSize = true;
            this.obsh.Location = new System.Drawing.Point(6, 65);
            this.obsh.Name = "obsh";
            this.obsh.Size = new System.Drawing.Size(244, 17);
            this.obsh.TabIndex = 10;
            this.obsh.TabStop = true;
            this.obsh.Text = "В общий поддон от нескольких источников";
            this.obsh.UseVisualStyleBackColor = true;
            this.obsh.CheckedChanged += new System.EventHandler(this.obsh_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.meter);
            this.groupBox1.Controls.Add(this.plosh);
            this.groupBox1.Controls.Add(this.ploshlabel);
            this.groupBox1.Controls.Add(this.visPodlabel);
            this.groupBox1.Controls.Add(this.visPod);
            this.groupBox1.Controls.Add(this.svob);
            this.groupBox1.Controls.Add(this.obsh);
            this.groupBox1.Controls.Add(this.sam);
            this.groupBox1.Location = new System.Drawing.Point(14, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 127);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характер разлива АХОВ";
            // 
            // meter
            // 
            this.meter.AutoSize = true;
            this.meter.Location = new System.Drawing.Point(192, 104);
            this.meter.Name = "meter";
            this.meter.Size = new System.Drawing.Size(56, 13);
            this.meter.TabIndex = 15;
            this.meter.Text = "метра(ов)";
            this.meter.Visible = false;
            // 
            // plosh
            // 
            this.plosh.Location = new System.Drawing.Point(9, 101);
            this.plosh.Name = "plosh";
            this.plosh.Size = new System.Drawing.Size(183, 20);
            this.plosh.TabIndex = 14;
            this.plosh.Visible = false;
            // 
            // ploshlabel
            // 
            this.ploshlabel.AutoSize = true;
            this.ploshlabel.Location = new System.Drawing.Point(3, 85);
            this.ploshlabel.Name = "ploshlabel";
            this.ploshlabel.Size = new System.Drawing.Size(147, 13);
            this.ploshlabel.TabIndex = 13;
            this.ploshlabel.Text = "Площадь розлива в поддон";
            this.ploshlabel.Visible = false;
            // 
            // visPodlabel
            // 
            this.visPodlabel.AutoSize = true;
            this.visPodlabel.Location = new System.Drawing.Point(6, 85);
            this.visPodlabel.Name = "visPodlabel";
            this.visPodlabel.Size = new System.Drawing.Size(90, 13);
            this.visPodlabel.TabIndex = 12;
            this.visPodlabel.Text = "Высота поддона";
            this.visPodlabel.Visible = false;
            // 
            // visPod
            // 
            this.visPod.Location = new System.Drawing.Point(9, 101);
            this.visPod.Name = "visPod";
            this.visPod.Size = new System.Drawing.Size(183, 20);
            this.visPod.TabIndex = 11;
            this.visPod.Visible = false;
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Location = new System.Drawing.Point(271, 88);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(176, 13);
            this.timelabel.TabIndex = 12;
            this.timelabel.Text = "Время, прошедшее после аварии";
            // 
            // speedAirlabel
            // 
            this.speedAirlabel.AutoSize = true;
            this.speedAirlabel.Location = new System.Drawing.Point(271, 49);
            this.speedAirlabel.Name = "speedAirlabel";
            this.speedAirlabel.Size = new System.Drawing.Size(87, 13);
            this.speedAirlabel.TabIndex = 13;
            this.speedAirlabel.Text = "Скорость ветра";
            // 
            // tempAirlabel
            // 
            this.tempAirlabel.AutoSize = true;
            this.tempAirlabel.Location = new System.Drawing.Point(394, 50);
            this.tempAirlabel.Name = "tempAirlabel";
            this.tempAirlabel.Size = new System.Drawing.Size(117, 13);
            this.tempAirlabel.TabIndex = 14;
            this.tempAirlabel.Text = "Температура воздуха";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(274, 101);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(203, 20);
            this.time.TabIndex = 15;
            // 
            // speedAir
            // 
            this.speedAir.Location = new System.Drawing.Point(274, 65);
            this.speedAir.Name = "speedAir";
            this.speedAir.Size = new System.Drawing.Size(88, 20);
            this.speedAir.TabIndex = 16;
            // 
            // tempAir
            // 
            this.tempAir.Location = new System.Drawing.Point(400, 66);
            this.tempAir.Name = "tempAir";
            this.tempAir.Size = new System.Drawing.Size(87, 20);
            this.tempAir.TabIndex = 17;
            // 
            // outAXOBlabel
            // 
            this.outAXOBlabel.AutoSize = true;
            this.outAXOBlabel.Location = new System.Drawing.Point(11, 65);
            this.outAXOBlabel.Name = "outAXOBlabel";
            this.outAXOBlabel.Size = new System.Drawing.Size(225, 13);
            this.outAXOBlabel.TabIndex = 19;
            this.outAXOBlabel.Text = "АХОВ, выброшенные в окружающую среду";
            // 
            // outAXOB
            // 
            this.outAXOB.Location = new System.Drawing.Point(14, 82);
            this.outAXOB.Name = "outAXOB";
            this.outAXOB.Size = new System.Drawing.Size(176, 20);
            this.outAXOB.TabIndex = 21;
            // 
            // distancelabel
            // 
            this.distancelabel.AutoSize = true;
            this.distancelabel.Location = new System.Drawing.Point(271, 121);
            this.distancelabel.Name = "distancelabel";
            this.distancelabel.Size = new System.Drawing.Size(187, 13);
            this.distancelabel.TabIndex = 22;
            this.distancelabel.Text = "Расстояние до населенного пункта";
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(274, 137);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(203, 20);
            this.distance.TabIndex = 23;
            // 
            // primichanie1
            // 
            this.primichanie1.AutoSize = true;
            this.primichanie1.Location = new System.Drawing.Point(7, 313);
            this.primichanie1.Name = "primichanie1";
            this.primichanie1.Size = new System.Drawing.Size(526, 13);
            this.primichanie1.TabIndex = 24;
            this.primichanie1.Text = "Значения по умолчанию для: скорости ветра = 3 м/с, температура воздуха = 20 °C, в" +
    "ремя прошедшее";
            // 
            // primichanie3
            // 
            this.primichanie3.AutoSize = true;
            this.primichanie3.Location = new System.Drawing.Point(7, 326);
            this.primichanie3.Name = "primichanie3";
            this.primichanie3.Size = new System.Drawing.Size(486, 13);
            this.primichanie3.TabIndex = 26;
            this.primichanie3.Text = "после аварии = 4 часа. Значение остальных не заполненых параметров будет равнятся" +
    " нулю!";
            // 
            // plotNasGlabel
            // 
            this.plotNasGlabel.AutoSize = true;
            this.plotNasGlabel.Location = new System.Drawing.Point(271, 160);
            this.plotNasGlabel.Name = "plotNasGlabel";
            this.plotNasGlabel.Size = new System.Drawing.Size(165, 13);
            this.plotNasGlabel.TabIndex = 27;
            this.plotNasGlabel.Text = "Плотность населения в городе";
            // 
            // plotNasZlabel
            // 
            this.plotNasZlabel.AutoSize = true;
            this.plotNasZlabel.Location = new System.Drawing.Point(269, 196);
            this.plotNasZlabel.Name = "plotNasZlabel";
            this.plotNasZlabel.Size = new System.Drawing.Size(216, 13);
            this.plotNasZlabel.TabIndex = 28;
            this.plotNasZlabel.Text = "Плотность населения в загородной зоне";
            // 
            // protivoGAZlabel
            // 
            this.protivoGAZlabel.AutoSize = true;
            this.protivoGAZlabel.Location = new System.Drawing.Point(11, 238);
            this.protivoGAZlabel.Name = "protivoGAZlabel";
            this.protivoGAZlabel.Size = new System.Drawing.Size(232, 13);
            this.protivoGAZlabel.TabIndex = 29;
            this.protivoGAZlabel.Text = "Обеспеченность населения противогазами:";
            // 
            // plotNasZ
            // 
            this.plotNasZ.Location = new System.Drawing.Point(274, 209);
            this.plotNasZ.Name = "plotNasZ";
            this.plotNasZ.Size = new System.Drawing.Size(203, 20);
            this.plotNasZ.TabIndex = 30;
            // 
            // plotNasG
            // 
            this.plotNasG.Location = new System.Drawing.Point(274, 173);
            this.plotNasG.Name = "plotNasG";
            this.plotNasG.Size = new System.Drawing.Size(203, 20);
            this.plotNasG.TabIndex = 31;
            // 
            // GAZG
            // 
            this.GAZG.AutoSize = true;
            this.GAZG.Location = new System.Drawing.Point(11, 256);
            this.GAZG.Name = "GAZG";
            this.GAZG.Size = new System.Drawing.Size(55, 13);
            this.GAZG.TabIndex = 32;
            this.GAZG.Text = "В городе:";
            // 
            // GAZZ
            // 
            this.GAZZ.AutoSize = true;
            this.GAZZ.Location = new System.Drawing.Point(11, 282);
            this.GAZZ.Name = "GAZZ";
            this.GAZZ.Size = new System.Drawing.Size(106, 13);
            this.GAZZ.TabIndex = 33;
            this.GAZZ.Text = "В загородной зоне:";
            // 
            // outGAZG
            // 
            this.outGAZG.Location = new System.Drawing.Point(123, 253);
            this.outGAZG.Name = "outGAZG";
            this.outGAZG.Size = new System.Drawing.Size(66, 20);
            this.outGAZG.TabIndex = 34;
            // 
            // outGAZZ
            // 
            this.outGAZZ.Location = new System.Drawing.Point(123, 279);
            this.outGAZZ.Name = "outGAZZ";
            this.outGAZZ.Size = new System.Drawing.Size(66, 20);
            this.outGAZZ.TabIndex = 35;
            // 
            // ubejishelabel
            // 
            this.ubejishelabel.AutoSize = true;
            this.ubejishelabel.Location = new System.Drawing.Point(271, 238);
            this.ubejishelabel.Name = "ubejishelabel";
            this.ubejishelabel.Size = new System.Drawing.Size(214, 13);
            this.ubejishelabel.TabIndex = 36;
            this.ubejishelabel.Text = "Обеспеченность населения убежищами:";
            // 
            // outubejZ
            // 
            this.outubejZ.Location = new System.Drawing.Point(383, 279);
            this.outubejZ.Name = "outubejZ";
            this.outubejZ.Size = new System.Drawing.Size(64, 20);
            this.outubejZ.TabIndex = 40;
            // 
            // outubejG
            // 
            this.outubejG.Location = new System.Drawing.Point(383, 253);
            this.outubejG.Name = "outubejG";
            this.outubejG.Size = new System.Drawing.Size(64, 20);
            this.outubejG.TabIndex = 39;
            // 
            // ubejZ
            // 
            this.ubejZ.AutoSize = true;
            this.ubejZ.Location = new System.Drawing.Point(271, 282);
            this.ubejZ.Name = "ubejZ";
            this.ubejZ.Size = new System.Drawing.Size(106, 13);
            this.ubejZ.TabIndex = 38;
            this.ubejZ.Text = "В загородной зоне:";
            // 
            // ubejG
            // 
            this.ubejG.AutoSize = true;
            this.ubejG.Location = new System.Drawing.Point(271, 256);
            this.ubejG.Name = "ubejG";
            this.ubejG.Size = new System.Drawing.Size(55, 13);
            this.ubejG.TabIndex = 37;
            this.ubejG.Text = "В городе:";
            // 
            // percent1
            // 
            this.percent1.AutoSize = true;
            this.percent1.Location = new System.Drawing.Point(195, 256);
            this.percent1.Name = "percent1";
            this.percent1.Size = new System.Drawing.Size(15, 13);
            this.percent1.TabIndex = 41;
            this.percent1.Text = "%";
            // 
            // percent2
            // 
            this.percent2.AutoSize = true;
            this.percent2.Location = new System.Drawing.Point(195, 282);
            this.percent2.Name = "percent2";
            this.percent2.Size = new System.Drawing.Size(15, 13);
            this.percent2.TabIndex = 42;
            this.percent2.Text = "%";
            // 
            // percent3
            // 
            this.percent3.AutoSize = true;
            this.percent3.Location = new System.Drawing.Point(453, 256);
            this.percent3.Name = "percent3";
            this.percent3.Size = new System.Drawing.Size(15, 13);
            this.percent3.TabIndex = 43;
            this.percent3.Text = "%";
            // 
            // percent4
            // 
            this.percent4.AutoSize = true;
            this.percent4.Location = new System.Drawing.Point(453, 282);
            this.percent4.Name = "percent4";
            this.percent4.Size = new System.Drawing.Size(15, 13);
            this.percent4.TabIndex = 44;
            this.percent4.Text = "%";
            // 
            // celsium
            // 
            this.celsium.AutoSize = true;
            this.celsium.Location = new System.Drawing.Point(493, 68);
            this.celsium.Name = "celsium";
            this.celsium.Size = new System.Drawing.Size(18, 13);
            this.celsium.TabIndex = 45;
            this.celsium.Text = "°C";
            // 
            // MvS
            // 
            this.MvS.AutoSize = true;
            this.MvS.Location = new System.Drawing.Point(368, 68);
            this.MvS.Name = "MvS";
            this.MvS.Size = new System.Drawing.Size(26, 13);
            this.MvS.TabIndex = 46;
            this.MvS.Text = "м/с";
            // 
            // kolvoTOHHlabel
            // 
            this.kolvoTOHHlabel.AutoSize = true;
            this.kolvoTOHHlabel.Location = new System.Drawing.Point(192, 85);
            this.kolvoTOHHlabel.Name = "kolvoTOHHlabel";
            this.kolvoTOHHlabel.Size = new System.Drawing.Size(72, 13);
            this.kolvoTOHHlabel.TabIndex = 47;
            this.kolvoTOHHlabel.Text = ", кол-во тонн";
            // 
            // menkm1
            // 
            this.menkm1.AutoSize = true;
            this.menkm1.Location = new System.Drawing.Point(481, 180);
            this.menkm1.Name = "menkm1";
            this.menkm1.Size = new System.Drawing.Size(46, 13);
            this.menkm1.TabIndex = 48;
            this.menkm1.Text = "чел/км²";
            // 
            // menkm2
            // 
            this.menkm2.AutoSize = true;
            this.menkm2.Location = new System.Drawing.Point(481, 216);
            this.menkm2.Name = "menkm2";
            this.menkm2.Size = new System.Drawing.Size(46, 13);
            this.menkm2.TabIndex = 49;
            this.menkm2.Text = "чел/км²";
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Location = new System.Drawing.Point(481, 108);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(30, 13);
            this.hours.TabIndex = 50;
            this.hours.Text = "часа";
            // 
            // km
            // 
            this.km.AutoSize = true;
            this.km.Location = new System.Drawing.Point(483, 144);
            this.km.Name = "km";
            this.km.Size = new System.Drawing.Size(21, 13);
            this.km.TabIndex = 51;
            this.km.Text = "км";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vibAXOB);
            this.panel1.Controls.Add(this.km);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.hours);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.menkm2);
            this.panel1.Controls.Add(this.substance);
            this.panel1.Controls.Add(this.menkm1);
            this.panel1.Controls.Add(this.jid);
            this.panel1.Controls.Add(this.kolvoTOHHlabel);
            this.panel1.Controls.Add(this.gaz);
            this.panel1.Controls.Add(this.MvS);
            this.panel1.Controls.Add(this.vertUst);
            this.panel1.Controls.Add(this.celsium);
            this.panel1.Controls.Add(this.ustAtm);
            this.panel1.Controls.Add(this.percent4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.percent3);
            this.panel1.Controls.Add(this.timelabel);
            this.panel1.Controls.Add(this.percent2);
            this.panel1.Controls.Add(this.speedAirlabel);
            this.panel1.Controls.Add(this.percent1);
            this.panel1.Controls.Add(this.tempAirlabel);
            this.panel1.Controls.Add(this.outubejZ);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.outubejG);
            this.panel1.Controls.Add(this.speedAir);
            this.panel1.Controls.Add(this.ubejZ);
            this.panel1.Controls.Add(this.tempAir);
            this.panel1.Controls.Add(this.ubejG);
            this.panel1.Controls.Add(this.outAXOBlabel);
            this.panel1.Controls.Add(this.ubejishelabel);
            this.panel1.Controls.Add(this.outAXOB);
            this.panel1.Controls.Add(this.outGAZZ);
            this.panel1.Controls.Add(this.distancelabel);
            this.panel1.Controls.Add(this.outGAZG);
            this.panel1.Controls.Add(this.distance);
            this.panel1.Controls.Add(this.GAZZ);
            this.panel1.Controls.Add(this.primichanie1);
            this.panel1.Controls.Add(this.GAZG);
            this.panel1.Controls.Add(this.primichanie3);
            this.panel1.Controls.Add(this.plotNasG);
            this.panel1.Controls.Add(this.plotNasGlabel);
            this.panel1.Controls.Add(this.plotNasZ);
            this.panel1.Controls.Add(this.plotNasZlabel);
            this.panel1.Controls.Add(this.protivoGAZlabel);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 387);
            this.panel1.TabIndex = 52;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(543, 388);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прогнозирование";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox substance;
        public System.Windows.Forms.RadioButton jid;
        public System.Windows.Forms.RadioButton gaz;
        private System.Windows.Forms.Label vibAXOB;
        private System.Windows.Forms.ComboBox vertUst;
        private System.Windows.Forms.Label ustAtm;
        private System.Windows.Forms.RadioButton svob;
        private System.Windows.Forms.RadioButton sam;
        private System.Windows.Forms.RadioButton obsh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label visPodlabel;
        private System.Windows.Forms.TextBox visPod;
        private System.Windows.Forms.TextBox plosh;
        private System.Windows.Forms.Label ploshlabel;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label speedAirlabel;
        private System.Windows.Forms.Label tempAirlabel;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.TextBox speedAir;
        private System.Windows.Forms.TextBox tempAir;
        private System.Windows.Forms.Label outAXOBlabel;
        private System.Windows.Forms.TextBox outAXOB;
        private System.Windows.Forms.Label distancelabel;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.Label primichanie1;
        private System.Windows.Forms.Label primichanie3;
        private System.Windows.Forms.Label plotNasGlabel;
        private System.Windows.Forms.Label plotNasZlabel;
        private System.Windows.Forms.Label protivoGAZlabel;
        private System.Windows.Forms.TextBox plotNasZ;
        private System.Windows.Forms.TextBox plotNasG;
        private System.Windows.Forms.Label GAZG;
        private System.Windows.Forms.Label GAZZ;
        private System.Windows.Forms.TextBox outGAZG;
        private System.Windows.Forms.TextBox outGAZZ;
        private System.Windows.Forms.Label ubejishelabel;
        private System.Windows.Forms.TextBox outubejZ;
        private System.Windows.Forms.TextBox outubejG;
        private System.Windows.Forms.Label ubejZ;
        private System.Windows.Forms.Label ubejG;
        private System.Windows.Forms.Label percent1;
        private System.Windows.Forms.Label percent2;
        private System.Windows.Forms.Label percent3;
        private System.Windows.Forms.Label percent4;
        private System.Windows.Forms.Label celsium;
        private System.Windows.Forms.Label MvS;
        private System.Windows.Forms.Label kolvoTOHHlabel;
        private System.Windows.Forms.Label menkm1;
        private System.Windows.Forms.Label menkm2;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Label km;
        private System.Windows.Forms.Label meter;
        private System.Windows.Forms.Panel panel1;
    }
}