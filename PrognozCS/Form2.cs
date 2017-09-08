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
        public static double S;
        public Form2()
        {
            InitializeComponent();
            Form1.G = Math.Round(Form1.G, 2);
            Form1.Sf = Math.Round(Form1.Sf, 2);

            int Txm = (int)Form1.Txm;
            int Txm0 = (int)Form1.Txm0;
            int Txm1 = (int)Form1.Txm1;
            int Txm2 = (int)Form1.Txm2;
            int Txm3 = (int)Form1.Txm3;
            int Txm4 = (int)Form1.Txm4;
            int Txm5 = (int)Form1.Txm5;
            int Txm6 = (int)Form1.Txm6;

            glub.Text = Form1.G.ToString() + " км";
            ploshad.Text = Form1.Sf.ToString() + " км²";
            time.Text = Form1.Txh.ToString() + " часов " + Txm.ToString() + " минут";

            label00.Text = Form1.Txh0.ToString() + " часов " + Txm0.ToString() + " минут";
            label01.Text = Form1.Txh1.ToString() + " часов " + Txm1.ToString() + " минут";
            label02.Text = Form1.Txh2.ToString() + " часов " + Txm2.ToString() + " минут";
            label03.Text = Form1.Txh3.ToString() + " часов " + Txm3.ToString() + " минут";
            label04.Text = Form1.Txh4.ToString() + " часов " + Txm4.ToString() + " минут";
            label05.Text = Form1.Txh5.ToString() + " часов " + Txm5.ToString() + " минут";
            label06.Text = Form1.Txh6.ToString() + " часов " + Txm6.ToString() + " минут";

            if (Form1.Q01 == 0) { label01.Visible = false; labelTime1.Visible = false; }
            if (Form1.Q02 == 0) { label02.Visible = false; labelTime2.Visible = false; }
            if (Form1.Q03 == 0) { label03.Visible = false; labelTime3.Visible = false; }
            if (Form1.Q04 == 0) { label04.Visible = false; labelTime4.Visible = false; }
            if (Form1.Q05 == 0) { label05.Visible = false; labelTime5.Visible = false; }
            if (Form1.Q06 == 0) { label06.Visible = false; labelTime6.Visible = false; }

            poteri1.Text = Form1.P1.ToString() + " чел";
            poteri2.Text = Form1.P2.ToString() + " чел";
            poteri3.Text = Form1.P3.ToString() + " чел";

            if (Form1.lockpanel == 1) { panelAXOB.Visible = true; }
            else { panelAXOB.Visible = false; }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ploshG.Text == "") { S = 5; }
            else { S = Convert.ToDouble(ploshG.Text); }
            new Form3().Show();
        }
    }
}
