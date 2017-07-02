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
            Form1.G = Math.Round(Form1.G, 2);
            //label6.Text = Form1.K4.ToString();
            label7.Text = Form1.G.ToString();
            label8.Text = Form1.W.ToString();
            label9.Text = Form1.Tx.ToString();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
