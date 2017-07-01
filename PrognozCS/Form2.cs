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
            label6.Text = Form1.K4.ToString();
            label7.Text = Form1.K5.ToString();
            label8.Text = Form1.K6.ToString();
            label9.Text = Form1.T.ToString();
            label10.Text = Form1.Qe1.ToString();
            label1.Text = Form1.Qe2.ToString();
            label2.Text = Form1.Ge1.ToString();
            label3.Text = Form1.Ge2.ToString();
            Form1.Ge = Math.Round(Form1.Ge,2);
            label4.Text = Form1.Ge.ToString();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
