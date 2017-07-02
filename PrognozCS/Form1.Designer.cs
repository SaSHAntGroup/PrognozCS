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
            this.ploshlabel = new System.Windows.Forms.TextBox();
            this.plosh = new System.Windows.Forms.Label();
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
            this.primichanie2 = new System.Windows.Forms.Label();
            this.primichanie3 = new System.Windows.Forms.Label();
            this.plotNasGlabel = new System.Windows.Forms.Label();
            this.plotNasZlabel = new System.Windows.Forms.Label();
            this.protivoGAZlabel = new System.Windows.Forms.Label();
            this.plotNasG = new System.Windows.Forms.TextBox();
            this.plotNasZ = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(8, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Расчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(409, 344);
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
            this.substance.Location = new System.Drawing.Point(12, 27);
            this.substance.Name = "substance";
            this.substance.Size = new System.Drawing.Size(254, 21);
            this.substance.TabIndex = 2;
            this.substance.SelectedIndexChanged += new System.EventHandler(this.substance_SelectedIndexChanged);
            // 
            // jid
            // 
            this.jid.AutoSize = true;
            this.jid.Location = new System.Drawing.Point(61, 48);
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
            this.gaz.Location = new System.Drawing.Point(12, 48);
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
            this.vibAXOB.Location = new System.Drawing.Point(12, 11);
            this.vibAXOB.Name = "vibAXOB";
            this.vibAXOB.Size = new System.Drawing.Size(72, 13);
            this.vibAXOB.TabIndex = 5;
            this.vibAXOB.Text = "Выбор АХОВ";
            // 
            // vertUst
            // 
            this.vertUst.FormattingEnabled = true;
            this.vertUst.Location = new System.Drawing.Point(272, 27);
            this.vertUst.Name = "vertUst";
            this.vertUst.Size = new System.Drawing.Size(255, 21);
            this.vertUst.TabIndex = 6;
            this.vertUst.Text = "Изотермия";
            // 
            // ustAtm
            // 
            this.ustAtm.AutoSize = true;
            this.ustAtm.Location = new System.Drawing.Point(269, 11);
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
            this.groupBox1.Controls.Add(this.ploshlabel);
            this.groupBox1.Controls.Add(this.plosh);
            this.groupBox1.Controls.Add(this.visPodlabel);
            this.groupBox1.Controls.Add(this.visPod);
            this.groupBox1.Controls.Add(this.svob);
            this.groupBox1.Controls.Add(this.obsh);
            this.groupBox1.Controls.Add(this.sam);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 127);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характер разлива АХОВ";
            // 
            // ploshlabel
            // 
            this.ploshlabel.Location = new System.Drawing.Point(3, 101);
            this.ploshlabel.Name = "ploshlabel";
            this.ploshlabel.Size = new System.Drawing.Size(247, 20);
            this.ploshlabel.TabIndex = 14;
            this.ploshlabel.Visible = false;
            // 
            // plosh
            // 
            this.plosh.AutoSize = true;
            this.plosh.Location = new System.Drawing.Point(6, 85);
            this.plosh.Name = "plosh";
            this.plosh.Size = new System.Drawing.Size(147, 13);
            this.plosh.TabIndex = 13;
            this.plosh.Text = "Площадь розлива в поддон";
            this.plosh.Visible = false;
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
            this.visPod.Location = new System.Drawing.Point(3, 101);
            this.visPod.Name = "visPod";
            this.visPod.Size = new System.Drawing.Size(247, 20);
            this.visPod.TabIndex = 11;
            this.visPod.Visible = false;
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Location = new System.Drawing.Point(269, 90);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(176, 13);
            this.timelabel.TabIndex = 12;
            this.timelabel.Text = "Время, прошедшее после аварии";
            // 
            // speedAirlabel
            // 
            this.speedAirlabel.AutoSize = true;
            this.speedAirlabel.Location = new System.Drawing.Point(269, 51);
            this.speedAirlabel.Name = "speedAirlabel";
            this.speedAirlabel.Size = new System.Drawing.Size(87, 13);
            this.speedAirlabel.TabIndex = 13;
            this.speedAirlabel.Text = "Скорость ветра";
            // 
            // tempAirlabel
            // 
            this.tempAirlabel.AutoSize = true;
            this.tempAirlabel.Location = new System.Drawing.Point(362, 50);
            this.tempAirlabel.Name = "tempAirlabel";
            this.tempAirlabel.Size = new System.Drawing.Size(117, 13);
            this.tempAirlabel.TabIndex = 14;
            this.tempAirlabel.Text = "Температура воздуха";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(272, 103);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(255, 20);
            this.time.TabIndex = 15;
            // 
            // speedAir
            // 
            this.speedAir.Location = new System.Drawing.Point(272, 67);
            this.speedAir.Name = "speedAir";
            this.speedAir.Size = new System.Drawing.Size(84, 20);
            this.speedAir.TabIndex = 16;
            // 
            // tempAir
            // 
            this.tempAir.Location = new System.Drawing.Point(365, 67);
            this.tempAir.Name = "tempAir";
            this.tempAir.Size = new System.Drawing.Size(162, 20);
            this.tempAir.TabIndex = 17;
            // 
            // outAXOBlabel
            // 
            this.outAXOBlabel.AutoSize = true;
            this.outAXOBlabel.Location = new System.Drawing.Point(9, 67);
            this.outAXOBlabel.Name = "outAXOBlabel";
            this.outAXOBlabel.Size = new System.Drawing.Size(225, 13);
            this.outAXOBlabel.TabIndex = 19;
            this.outAXOBlabel.Text = "АХОВ, выброшенные в окружающую среду";
            // 
            // outAXOB
            // 
            this.outAXOB.Location = new System.Drawing.Point(12, 84);
            this.outAXOB.Name = "outAXOB";
            this.outAXOB.Size = new System.Drawing.Size(254, 20);
            this.outAXOB.TabIndex = 21;
            // 
            // distancelabel
            // 
            this.distancelabel.AutoSize = true;
            this.distancelabel.Location = new System.Drawing.Point(269, 123);
            this.distancelabel.Name = "distancelabel";
            this.distancelabel.Size = new System.Drawing.Size(187, 13);
            this.distancelabel.TabIndex = 22;
            this.distancelabel.Text = "Расстояние до населенного пункта";
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(272, 139);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(255, 20);
            this.distance.TabIndex = 23;
            // 
            // primichanie1
            // 
            this.primichanie1.AutoSize = true;
            this.primichanie1.Location = new System.Drawing.Point(8, 315);
            this.primichanie1.Name = "primichanie1";
            this.primichanie1.Size = new System.Drawing.Size(281, 13);
            this.primichanie1.TabIndex = 24;
            this.primichanie1.Text = "Значения по умолчанию для : скорости ветра = 3 м/с,";
            // 
            // primichanie2
            // 
            this.primichanie2.AutoSize = true;
            this.primichanie2.Location = new System.Drawing.Point(288, 315);
            this.primichanie2.Name = "primichanie2";
            this.primichanie2.Size = new System.Drawing.Size(236, 13);
            this.primichanie2.TabIndex = 25;
            this.primichanie2.Text = "температура воздуха = 20 градусов цельсия,";
            // 
            // primichanie3
            // 
            this.primichanie3.AutoSize = true;
            this.primichanie3.Location = new System.Drawing.Point(5, 328);
            this.primichanie3.Name = "primichanie3";
            this.primichanie3.Size = new System.Drawing.Size(524, 13);
            this.primichanie3.TabIndex = 26;
            this.primichanie3.Text = "время, после аварии = 4 часа. Значение остальных не заполненых параметров будет р" +
    "авнятся нулю!";
            // 
            // plotNasGlabel
            // 
            this.plotNasGlabel.AutoSize = true;
            this.plotNasGlabel.Location = new System.Drawing.Point(269, 162);
            this.plotNasGlabel.Name = "plotNasGlabel";
            this.plotNasGlabel.Size = new System.Drawing.Size(165, 13);
            this.plotNasGlabel.TabIndex = 27;
            this.plotNasGlabel.Text = "Плотность населения в городе";
            // 
            // plotNasZlabel
            // 
            this.plotNasZlabel.AutoSize = true;
            this.plotNasZlabel.Location = new System.Drawing.Point(267, 198);
            this.plotNasZlabel.Name = "plotNasZlabel";
            this.plotNasZlabel.Size = new System.Drawing.Size(216, 13);
            this.plotNasZlabel.TabIndex = 28;
            this.plotNasZlabel.Text = "Плотность населения в загородной зоне";
            // 
            // protivoGAZlabel
            // 
            this.protivoGAZlabel.AutoSize = true;
            this.protivoGAZlabel.Location = new System.Drawing.Point(9, 240);
            this.protivoGAZlabel.Name = "protivoGAZlabel";
            this.protivoGAZlabel.Size = new System.Drawing.Size(232, 13);
            this.protivoGAZlabel.TabIndex = 29;
            this.protivoGAZlabel.Text = "Обеспеченность населения противогазами:";
            // 
            // plotNasG
            // 
            this.plotNasG.Location = new System.Drawing.Point(272, 211);
            this.plotNasG.Name = "plotNasG";
            this.plotNasG.Size = new System.Drawing.Size(255, 20);
            this.plotNasG.TabIndex = 30;
            // 
            // plotNasZ
            // 
            this.plotNasZ.Location = new System.Drawing.Point(272, 175);
            this.plotNasZ.Name = "plotNasZ";
            this.plotNasZ.Size = new System.Drawing.Size(255, 20);
            this.plotNasZ.TabIndex = 31;
            // 
            // GAZG
            // 
            this.GAZG.AutoSize = true;
            this.GAZG.Location = new System.Drawing.Point(9, 258);
            this.GAZG.Name = "GAZG";
            this.GAZG.Size = new System.Drawing.Size(55, 13);
            this.GAZG.TabIndex = 32;
            this.GAZG.Text = "В городе:";
            // 
            // GAZZ
            // 
            this.GAZZ.AutoSize = true;
            this.GAZZ.Location = new System.Drawing.Point(9, 284);
            this.GAZZ.Name = "GAZZ";
            this.GAZZ.Size = new System.Drawing.Size(106, 13);
            this.GAZZ.TabIndex = 33;
            this.GAZZ.Text = "В загородной зоне:";
            // 
            // outGAZG
            // 
            this.outGAZG.Location = new System.Drawing.Point(121, 255);
            this.outGAZG.Name = "outGAZG";
            this.outGAZG.Size = new System.Drawing.Size(66, 20);
            this.outGAZG.TabIndex = 34;
            // 
            // outGAZZ
            // 
            this.outGAZZ.Location = new System.Drawing.Point(121, 281);
            this.outGAZZ.Name = "outGAZZ";
            this.outGAZZ.Size = new System.Drawing.Size(66, 20);
            this.outGAZZ.TabIndex = 35;
            // 
            // ubejishelabel
            // 
            this.ubejishelabel.AutoSize = true;
            this.ubejishelabel.Location = new System.Drawing.Point(269, 240);
            this.ubejishelabel.Name = "ubejishelabel";
            this.ubejishelabel.Size = new System.Drawing.Size(214, 13);
            this.ubejishelabel.TabIndex = 36;
            this.ubejishelabel.Text = "Обеспеченность населения убежищами:";
            // 
            // outubejZ
            // 
            this.outubejZ.Location = new System.Drawing.Point(381, 281);
            this.outubejZ.Name = "outubejZ";
            this.outubejZ.Size = new System.Drawing.Size(64, 20);
            this.outubejZ.TabIndex = 40;
            // 
            // outubejG
            // 
            this.outubejG.Location = new System.Drawing.Point(381, 255);
            this.outubejG.Name = "outubejG";
            this.outubejG.Size = new System.Drawing.Size(64, 20);
            this.outubejG.TabIndex = 39;
            // 
            // ubejZ
            // 
            this.ubejZ.AutoSize = true;
            this.ubejZ.Location = new System.Drawing.Point(269, 284);
            this.ubejZ.Name = "ubejZ";
            this.ubejZ.Size = new System.Drawing.Size(106, 13);
            this.ubejZ.TabIndex = 38;
            this.ubejZ.Text = "В загородной зоне:";
            // 
            // ubejG
            // 
            this.ubejG.AutoSize = true;
            this.ubejG.Location = new System.Drawing.Point(269, 258);
            this.ubejG.Name = "ubejG";
            this.ubejG.Size = new System.Drawing.Size(55, 13);
            this.ubejG.TabIndex = 37;
            this.ubejG.Text = "В городе:";
            // 
            // percent1
            // 
            this.percent1.AutoSize = true;
            this.percent1.Location = new System.Drawing.Point(193, 258);
            this.percent1.Name = "percent1";
            this.percent1.Size = new System.Drawing.Size(15, 13);
            this.percent1.TabIndex = 41;
            this.percent1.Text = "%";
            // 
            // percent2
            // 
            this.percent2.AutoSize = true;
            this.percent2.Location = new System.Drawing.Point(193, 284);
            this.percent2.Name = "percent2";
            this.percent2.Size = new System.Drawing.Size(15, 13);
            this.percent2.TabIndex = 42;
            this.percent2.Text = "%";
            // 
            // percent3
            // 
            this.percent3.AutoSize = true;
            this.percent3.Location = new System.Drawing.Point(451, 258);
            this.percent3.Name = "percent3";
            this.percent3.Size = new System.Drawing.Size(15, 13);
            this.percent3.TabIndex = 43;
            this.percent3.Text = "%";
            // 
            // percent4
            // 
            this.percent4.AutoSize = true;
            this.percent4.Location = new System.Drawing.Point(451, 284);
            this.percent4.Name = "percent4";
            this.percent4.Size = new System.Drawing.Size(15, 13);
            this.percent4.TabIndex = 44;
            this.percent4.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(535, 389);
            this.Controls.Add(this.percent4);
            this.Controls.Add(this.percent3);
            this.Controls.Add(this.percent2);
            this.Controls.Add(this.percent1);
            this.Controls.Add(this.outubejZ);
            this.Controls.Add(this.outubejG);
            this.Controls.Add(this.ubejZ);
            this.Controls.Add(this.ubejG);
            this.Controls.Add(this.ubejishelabel);
            this.Controls.Add(this.outGAZZ);
            this.Controls.Add(this.outGAZG);
            this.Controls.Add(this.GAZZ);
            this.Controls.Add(this.GAZG);
            this.Controls.Add(this.plotNasZ);
            this.Controls.Add(this.plotNasG);
            this.Controls.Add(this.protivoGAZlabel);
            this.Controls.Add(this.plotNasZlabel);
            this.Controls.Add(this.plotNasGlabel);
            this.Controls.Add(this.primichanie3);
            this.Controls.Add(this.primichanie2);
            this.Controls.Add(this.primichanie1);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.distancelabel);
            this.Controls.Add(this.outAXOB);
            this.Controls.Add(this.outAXOBlabel);
            this.Controls.Add(this.tempAir);
            this.Controls.Add(this.speedAir);
            this.Controls.Add(this.time);
            this.Controls.Add(this.tempAirlabel);
            this.Controls.Add(this.speedAirlabel);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ustAtm);
            this.Controls.Add(this.vertUst);
            this.Controls.Add(this.vibAXOB);
            this.Controls.Add(this.gaz);
            this.Controls.Add(this.jid);
            this.Controls.Add(this.substance);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prognoz";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox ploshlabel;
        private System.Windows.Forms.Label plosh;
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
        private System.Windows.Forms.Label primichanie2;
        private System.Windows.Forms.Label primichanie3;
        private System.Windows.Forms.Label plotNasGlabel;
        private System.Windows.Forms.Label plotNasZlabel;
        private System.Windows.Forms.Label protivoGAZlabel;
        private System.Windows.Forms.TextBox plotNasG;
        private System.Windows.Forms.TextBox plotNasZ;
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
    }
}