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
            Form1.Sf = Math.Round(Form1.Sf, 2);
            Form1.Txm = Math.Round(Form1.Txm, 0);
            glub.Text = Form1.G.ToString() + " км";
            ploshad.Text = Form1.Sf.ToString() + " км²";
            time.Text = Form1.Txh.ToString() + " часов " + Form1.Txm.ToString() + " минут";
            poteri1.Text = Form1.P1.ToString() + " чел";
            poteri2.Text = Form1.P2.ToString() + " чел";
            poteri3.Text = Form1.P3.ToString() + " чел";

        }
    public void button1_Click(object sender, EventArgs e)
    {
        Close();
    }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }
    }
}
