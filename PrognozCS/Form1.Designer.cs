﻿namespace PrognozCS
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 33);
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
            this.button2.Location = new System.Drawing.Point(407, 269);
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
            this.vertUst.Size = new System.Drawing.Size(244, 21);
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
            this.timelabel.Location = new System.Drawing.Point(269, 129);
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
            this.tempAirlabel.Location = new System.Drawing.Point(269, 90);
            this.tempAirlabel.Name = "tempAirlabel";
            this.tempAirlabel.Size = new System.Drawing.Size(117, 13);
            this.tempAirlabel.TabIndex = 14;
            this.tempAirlabel.Text = "Температура воздуха";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(272, 145);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(244, 20);
            this.time.TabIndex = 15;
            // 
            // speedAir
            // 
            this.speedAir.Location = new System.Drawing.Point(272, 67);
            this.speedAir.Name = "speedAir";
            this.speedAir.Size = new System.Drawing.Size(244, 20);
            this.speedAir.TabIndex = 16;
            // 
            // tempAir
            // 
            this.tempAir.Location = new System.Drawing.Point(272, 106);
            this.tempAir.Name = "tempAir";
            this.tempAir.Size = new System.Drawing.Size(244, 20);
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
            this.distancelabel.Location = new System.Drawing.Point(269, 168);
            this.distancelabel.Name = "distancelabel";
            this.distancelabel.Size = new System.Drawing.Size(187, 13);
            this.distancelabel.TabIndex = 22;
            this.distancelabel.Text = "Расстояние до населенного пункта";
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(272, 184);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(244, 20);
            this.distance.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Значения по умолчанию для : скорости ветра = 3(м/с),";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "температура воздуха = 20(градусов цельсия),";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "время, после аварии = 4 часа. Для остальных параметров = 0!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(528, 312);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}