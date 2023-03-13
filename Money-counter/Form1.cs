using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money_counter
{
    public partial class Money_Cashup : Form
    {
        public Money_Cashup()
        {
            InitializeComponent();
        }

        public double[] Getnumb = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        public void addup()
        {
            decimal addup = Convert.ToDecimal(Getnumb[0] + Getnumb[1] + Getnumb[2]+ Getnumb[3] + Getnumb[4] + Getnumb[5] + Getnumb[6] + Getnumb[7]+ Getnumb[8]+ Getnumb[9]+ Getnumb[10]);
            string addupdisplay = Convert.ToString(addup.ToString("0.00"));
            total.Text =  "Total Cash up = $" + addupdisplay;
            decimal floatsub = Convert.ToDecimal(Convert.ToDouble(addup) - Getnumb[11]);
            string addupfloatdisplay = Convert.ToString(floatsub.ToString("0.00"));
            float1.Text = "Subtracted Float = $" + addupfloatdisplay;
        }

        private void fivecentinput_ValueChanged(object sender, EventArgs e)
        {
            double fivecent = (double)fivecentinput.Value;
            double totalfivecent = fivecent * 0.05;
            Getnumb[0] = totalfivecent;
            addup();
        }

        public void tencentinput_ValueChanged(object sender, EventArgs e)
        {
            double tencent = (double)tencentinput.Value;
            double totaltencentinput = tencent * 0.10;
            Getnumb[1] = totaltencentinput;
            addup();
        }

        private void twentycentinput_ValueChanged(object sender, EventArgs e)
        {
            double twentycent = (double)twentycentinput.Value;
            double totaltwentycentinput = twentycent * 0.20;
            Getnumb[2] = totaltwentycentinput;
            addup();
        }
        private void fiftycentinput_ValueChanged(object sender, EventArgs e)
        {
            double fiftycent = (double)fiftycentinput.Value;
            double totalfiftycent = fiftycent * 0.5;
            Getnumb[3] = totalfiftycent;
            addup();
        }
        private void onedollerinput_ValueChanged(object sender, EventArgs e)
        {
            double onedoller = (double)onedollerinput.Value;
            double totalonedoller = onedoller * 1;
            Getnumb[4] = totalonedoller;
            addup();
        }

        private void twodollerinput_ValueChanged(object sender, EventArgs e)
        {
            double twodoller = (double)twodollerinput.Value;
            double totaltwodoller = twodoller * 2;
            Getnumb[5] = totaltwodoller;
            addup();
        }

        private void fivenoteinput_ValueChanged(object sender, EventArgs e)
        {
            double fivenote = (double)fivenoteinput.Value;
            double totalfivenote = fivenote * 5;
            Getnumb[6] = totalfivenote;
            addup();
        }

        private void tennoteinput_ValueChanged(object sender, EventArgs e)
        {
            double tennote = (double)tennoteinput.Value;
            double totaltennote = tennote * 10;
            Getnumb[7] = totaltennote;
            addup();
        }

        private void twentynoteinput_ValueChanged(object sender, EventArgs e)
        {
            double twentynote = (double)twentynoteinput.Value;
            double totaltwentynote = twentynote * 20;
            Getnumb[8] = totaltwentynote;
            addup();
        }

        private void fiftynoteinput_ValueChanged(object sender, EventArgs e)
        {
            double fiftynote = (double)fiftynoteinput.Value;
            double totalfiftynote = fiftynote * 50;
            Getnumb[9] = totalfiftynote;
            addup();
        }

        private void onehundrednoteinput_ValueChanged(object sender, EventArgs e)
        {
            double onehundrednote = (double)onehundrednoteinput.Value;
            double totalonehundrednote = onehundrednote * 100;
            Getnumb[10] = totalonehundrednote;
            addup();
        }

        private void floatinput_ValueChanged(object sender, EventArgs e)
        {
            double floatsub = (double)floatinput.Value;
            Getnumb[11] = floatsub;
            addup();
        }
    }
}
