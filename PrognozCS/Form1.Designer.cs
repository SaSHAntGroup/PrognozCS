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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 237);
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
            this.button2.Location = new System.Drawing.Point(170, 237);
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
            this.substance.Location = new System.Drawing.Point(12, 30);
            this.substance.Name = "substance";
            this.substance.Size = new System.Drawing.Size(267, 21);
            this.substance.TabIndex = 2;
            // 
            // jid
            // 
            this.jid.AutoSize = true;
            this.jid.Location = new System.Drawing.Point(12, 57);
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
            this.gaz.Location = new System.Drawing.Point(95, 57);
            this.gaz.Name = "gaz";
            this.gaz.Size = new System.Drawing.Size(43, 17);
            this.gaz.TabIndex = 4;
            this.gaz.TabStop = true;
            this.gaz.Text = "Газ";
            this.gaz.UseVisualStyleBackColor = true;
            this.gaz.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(291, 282);
            this.Controls.Add(this.gaz);
            this.Controls.Add(this.jid);
            this.Controls.Add(this.substance);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prognoz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox substance;
        public System.Windows.Forms.RadioButton jid;
        public System.Windows.Forms.RadioButton gaz;
    }
}