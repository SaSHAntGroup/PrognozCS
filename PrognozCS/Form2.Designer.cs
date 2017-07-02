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
            this.glublabel = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.ploshadlabel = new System.Windows.Forms.Label();
            this.poterilabel = new System.Windows.Forms.Label();
            this.poteri1label = new System.Windows.Forms.Label();
            this.poteri2label = new System.Windows.Forms.Label();
            this.poteri3label = new System.Windows.Forms.Label();
            this.glub = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.poteri1 = new System.Windows.Forms.Label();
            this.poteri2 = new System.Windows.Forms.Label();
            this.poteri3 = new System.Windows.Forms.Label();
            this.ploshad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(511, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // glublabel
            // 
            this.glublabel.AutoSize = true;
            this.glublabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.glublabel.Location = new System.Drawing.Point(12, 9);
            this.glublabel.Name = "glublabel";
            this.glublabel.Size = new System.Drawing.Size(403, 13);
            this.glublabel.TabIndex = 1;
            this.glublabel.Text = "Глубина распространения зараженного облака АХОВ при аварии:";
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timelabel.Location = new System.Drawing.Point(12, 31);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(408, 13);
            this.timelabel.TabIndex = 2;
            this.timelabel.Text = "Время подхода облака зараженного АХОВ до населенного пункта:";
            // 
            // ploshadlabel
            // 
            this.ploshadlabel.AutoSize = true;
            this.ploshadlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ploshadlabel.Location = new System.Drawing.Point(12, 144);
            this.ploshadlabel.Name = "ploshadlabel";
            this.ploshadlabel.Size = new System.Drawing.Size(285, 13);
            this.ploshadlabel.TabIndex = 3;
            this.ploshadlabel.Text = "Площадь зоны фактическог заражения АХОВ:";
            // 
            // poterilabel
            // 
            this.poterilabel.AutoSize = true;
            this.poterilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.poterilabel.Location = new System.Drawing.Point(12, 54);
            this.poterilabel.Name = "poterilabel";
            this.poterilabel.Size = new System.Drawing.Size(401, 13);
            this.poterilabel.TabIndex = 4;
            this.poterilabel.Text = "Величина возможных потерь населения в очаге поражения АХОВ";
            // 
            // poteri1label
            // 
            this.poteri1label.AutoSize = true;
            this.poteri1label.Location = new System.Drawing.Point(28, 76);
            this.poteri1label.Name = "poteri1label";
            this.poteri1label.Size = new System.Drawing.Size(89, 13);
            this.poteri1label.TabIndex = 5;
            this.poteri1label.Text = "безвозвратные:";
            // 
            // poteri2label
            // 
            this.poteri2label.AutoSize = true;
            this.poteri2label.Location = new System.Drawing.Point(28, 99);
            this.poteri2label.Name = "poteri2label";
            this.poteri2label.Size = new System.Drawing.Size(154, 13);
            this.poteri2label.TabIndex = 6;
            this.poteri2label.Text = "тяжелые и средней тяжести:";
            // 
            // poteri3label
            // 
            this.poteri3label.AutoSize = true;
            this.poteri3label.Location = new System.Drawing.Point(28, 122);
            this.poteri3label.Name = "poteri3label";
            this.poteri3label.Size = new System.Drawing.Size(129, 13);
            this.poteri3label.TabIndex = 7;
            this.poteri3label.Text = "легкой формы тяжести:";
            // 
            // glub
            // 
            this.glub.AutoSize = true;
            this.glub.Location = new System.Drawing.Point(421, 9);
            this.glub.Name = "glub";
            this.glub.Size = new System.Drawing.Size(35, 13);
            this.glub.TabIndex = 8;
            this.glub.Text = "label1";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(421, 31);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(35, 13);
            this.time.TabIndex = 9;
            this.time.Text = "label2";
            // 
            // poteri1
            // 
            this.poteri1.AutoSize = true;
            this.poteri1.Location = new System.Drawing.Point(197, 76);
            this.poteri1.Name = "poteri1";
            this.poteri1.Size = new System.Drawing.Size(35, 13);
            this.poteri1.TabIndex = 11;
            this.poteri1.Text = "label4";
            // 
            // poteri2
            // 
            this.poteri2.AutoSize = true;
            this.poteri2.Location = new System.Drawing.Point(197, 99);
            this.poteri2.Name = "poteri2";
            this.poteri2.Size = new System.Drawing.Size(35, 13);
            this.poteri2.TabIndex = 12;
            this.poteri2.Text = "label5";
            // 
            // poteri3
            // 
            this.poteri3.AutoSize = true;
            this.poteri3.Location = new System.Drawing.Point(197, 122);
            this.poteri3.Name = "poteri3";
            this.poteri3.Size = new System.Drawing.Size(35, 13);
            this.poteri3.TabIndex = 13;
            this.poteri3.Text = "label6";
            // 
            // ploshad
            // 
            this.ploshad.AutoSize = true;
            this.ploshad.Location = new System.Drawing.Point(318, 144);
            this.ploshad.Name = "ploshad";
            this.ploshad.Size = new System.Drawing.Size(35, 13);
            this.ploshad.TabIndex = 14;
            this.ploshad.Text = "label7";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(535, 389);
            this.Controls.Add(this.ploshad);
            this.Controls.Add(this.poteri3);
            this.Controls.Add(this.poteri2);
            this.Controls.Add(this.poteri1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.glub);
            this.Controls.Add(this.poteri3label);
            this.Controls.Add(this.poteri2label);
            this.Controls.Add(this.poteri1label);
            this.Controls.Add(this.poterilabel);
            this.Controls.Add(this.ploshadlabel);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.glublabel);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прогнозирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label glublabel;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label ploshadlabel;
        private System.Windows.Forms.Label poterilabel;
        private System.Windows.Forms.Label poteri1label;
        private System.Windows.Forms.Label poteri2label;
        private System.Windows.Forms.Label poteri3label;
        private System.Windows.Forms.Label glub;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label poteri1;
        private System.Windows.Forms.Label poteri2;
        private System.Windows.Forms.Label poteri3;
        private System.Windows.Forms.Label ploshad;
    }
}