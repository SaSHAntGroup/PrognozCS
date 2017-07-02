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
            //label6.Text = Form1.K4.ToString();
            label7.Text = Form1.Ge1.ToString();
            label8.Text = Form1.Ge2.ToString();
            Form1.Ge = Math.Round(Form1.Ge,2);
            label9.Text = Form1.Ge.ToString();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
