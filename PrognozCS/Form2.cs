using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrognozCS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form1.M = Math.Round(Form1.M,2);
            label6.Text = Form1.h.ToString();
            label7.Text = Form1.K5.ToString();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
