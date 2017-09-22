namespace PrognozCS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.timelabel = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ploshG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTime1 = new System.Windows.Forms.Label();
            this.labelTime2 = new System.Windows.Forms.Label();
            this.labelTime3 = new System.Windows.Forms.Label();
            this.labelTime4 = new System.Windows.Forms.Label();
            this.labelTime5 = new System.Windows.Forms.Label();
            this.labelTime6 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelAXOB = new System.Windows.Forms.Panel();
            this.label06 = new System.Windows.Forms.Label();
            this.label05 = new System.Windows.Forms.Label();
            this.label04 = new System.Windows.Forms.Label();
            this.label03 = new System.Windows.Forms.Label();
            this.label02 = new System.Windows.Forms.Label();
            this.label01 = new System.Windows.Forms.Label();
            this.label00 = new System.Windows.Forms.Label();
            this.pictureob1 = new System.Windows.Forms.PictureBox();
            this.plosh = new System.Windows.Forms.Label();
            this.panelAXOB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureob1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(534, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timelabel.Location = new System.Drawing.Point(9, 329);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(408, 13);
            this.timelabel.TabIndex = 2;
            this.timelabel.Text = "Время подхода облака зараженного АХОВ до населенного пункта:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(418, 329);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(35, 13);
            this.time.TabIndex = 9;
            this.time.Text = "label2";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(12, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(534, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "Моделирование";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ploshG
            // 
            this.ploshG.Location = new System.Drawing.Point(418, 345);
            this.ploshG.Name = "ploshG";
            this.ploshG.Size = new System.Drawing.Size(83, 20);
            this.ploshG.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Расстояние от начальной до конечной точки населенного пункта:";
            // 
            // labelTime1
            // 
            this.labelTime1.AutoSize = true;
            this.labelTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime1.Location = new System.Drawing.Point(3, 9);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(228, 13);
            this.labelTime1.TabIndex = 18;
            this.labelTime1.Text = "Время полного испарения АХОВ №1:";
            // 
            // labelTime2
            // 
            this.labelTime2.AutoSize = true;
            this.labelTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime2.Location = new System.Drawing.Point(3, 22);
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(228, 13);
            this.labelTime2.TabIndex = 19;
            this.labelTime2.Text = "Время полного испарения АХОВ №2:";
            // 
            // labelTime3
            // 
            this.labelTime3.AutoSize = true;
            this.labelTime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime3.Location = new System.Drawing.Point(3, 35);
            this.labelTime3.Name = "labelTime3";
            this.labelTime3.Size = new System.Drawing.Size(228, 13);
            this.labelTime3.TabIndex = 20;
            this.labelTime3.Text = "Время полного испарения АХОВ №3:";
            // 
            // labelTime4
            // 
            this.labelTime4.AutoSize = true;
            this.labelTime4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime4.Location = new System.Drawing.Point(3, 48);
            this.labelTime4.Name = "labelTime4";
            this.labelTime4.Size = new System.Drawing.Size(228, 13);
            this.labelTime4.TabIndex = 21;
            this.labelTime4.Text = "Время полного испарения АХОВ №4:";
            // 
            // labelTime5
            // 
            this.labelTime5.AutoSize = true;
            this.labelTime5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime5.Location = new System.Drawing.Point(3, 61);
            this.labelTime5.Name = "labelTime5";
            this.labelTime5.Size = new System.Drawing.Size(228, 13);
            this.labelTime5.TabIndex = 22;
            this.labelTime5.Text = "Время полного испарения АХОВ №5:";
            // 
            // labelTime6
            // 
            this.labelTime6.AutoSize = true;
            this.labelTime6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime6.Location = new System.Drawing.Point(3, 74);
            this.labelTime6.Name = "labelTime6";
            this.labelTime6.Size = new System.Drawing.Size(228, 13);
            this.labelTime6.TabIndex = 23;
            this.labelTime6.Text = "Время полного испарения АХОВ №6:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(9, 376);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(205, 13);
            this.labelTime.TabIndex = 24;
            this.labelTime.Text = "Время полного испарения АХОВ:";
            // 
            // panelAXOB
            // 
            this.panelAXOB.Controls.Add(this.label06);
            this.panelAXOB.Controls.Add(this.label05);
            this.panelAXOB.Controls.Add(this.label04);
            this.panelAXOB.Controls.Add(this.label03);
            this.panelAXOB.Controls.Add(this.label02);
            this.panelAXOB.Controls.Add(this.label01);
            this.panelAXOB.Controls.Add(this.labelTime3);
            this.panelAXOB.Controls.Add(this.labelTime1);
            this.panelAXOB.Controls.Add(this.labelTime6);
            this.panelAXOB.Controls.Add(this.labelTime2);
            this.panelAXOB.Controls.Add(this.labelTime5);
            this.panelAXOB.Controls.Add(this.labelTime4);
            this.panelAXOB.Location = new System.Drawing.Point(12, 368);
            this.panelAXOB.Name = "panelAXOB";
            this.panelAXOB.Size = new System.Drawing.Size(534, 95);
            this.panelAXOB.TabIndex = 25;
            // 
            // label06
            // 
            this.label06.AutoSize = true;
            this.label06.Location = new System.Drawing.Point(237, 74);
            this.label06.Name = "label06";
            this.label06.Size = new System.Drawing.Size(35, 13);
            this.label06.TabIndex = 31;
            this.label06.Text = "label7";
            // 
            // label05
            // 
            this.label05.AutoSize = true;
            this.label05.Location = new System.Drawing.Point(237, 61);
            this.label05.Name = "label05";
            this.label05.Size = new System.Drawing.Size(35, 13);
            this.label05.TabIndex = 30;
            this.label05.Text = "label7";
            // 
            // label04
            // 
            this.label04.AutoSize = true;
            this.label04.Location = new System.Drawing.Point(237, 48);
            this.label04.Name = "label04";
            this.label04.Size = new System.Drawing.Size(35, 13);
            this.label04.TabIndex = 29;
            this.label04.Text = "label7";
            // 
            // label03
            // 
            this.label03.AutoSize = true;
            this.label03.Location = new System.Drawing.Point(237, 35);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(35, 13);
            this.label03.TabIndex = 28;
            this.label03.Text = "label7";
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Location = new System.Drawing.Point(237, 22);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(35, 13);
            this.label02.TabIndex = 27;
            this.label02.Text = "label7";
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Location = new System.Drawing.Point(237, 9);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(35, 13);
            this.label01.TabIndex = 26;
            this.label01.Text = "label7";
            // 
            // label00
            // 
            this.label00.AutoSize = true;
            this.label00.Location = new System.Drawing.Point(220, 376);
            this.label00.Name = "label00";
            this.label00.Size = new System.Drawing.Size(35, 13);
            this.label00.TabIndex = 32;
            this.label00.Text = "label7";
            // 
            // pictureob1
            // 
            this.pictureob1.Location = new System.Drawing.Point(12, 12);
            this.pictureob1.Name = "pictureob1";
            this.pictureob1.Size = new System.Drawing.Size(534, 314);
            this.pictureob1.TabIndex = 33;
            this.pictureob1.TabStop = false;
            // 
            // plosh
            // 
            this.plosh.AutoSize = true;
            this.plosh.Location = new System.Drawing.Point(507, 348);
            this.plosh.Name = "plosh";
            this.plosh.Size = new System.Drawing.Size(21, 13);
            this.plosh.TabIndex = 34;
            this.plosh.Text = "км";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(558, 548);
            this.Controls.Add(this.plosh);
            this.Controls.Add(this.pictureob1);
            this.Controls.Add(this.panelAXOB);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ploshG);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label00);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прогнозирование: Результаты расчетов";
            this.panelAXOB.ResumeLayout(false);
            this.panelAXOB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureob1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ploshG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTime1;
        private System.Windows.Forms.Label labelTime2;
        private System.Windows.Forms.Label labelTime3;
        private System.Windows.Forms.Label labelTime4;
        private System.Windows.Forms.Label labelTime5;
        private System.Windows.Forms.Label labelTime6;
        private System.Windows.Forms.Label labelTime;
        public System.Windows.Forms.Panel panelAXOB;
        private System.Windows.Forms.Label label06;
        private System.Windows.Forms.Label label05;
        private System.Windows.Forms.Label label04;
        private System.Windows.Forms.Label label03;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Label label00;
        private System.Windows.Forms.PictureBox pictureob1;
        private System.Windows.Forms.Label plosh;
    }
}