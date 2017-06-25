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
            label6.Text = Form1.M.ToString();
            label7.Text = Form1.tkip.ToString();
            label8.Text = Form1.P.ToString();
            label9.Text = Form1.D.ToString();
            label10.Text = Form1.d.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
