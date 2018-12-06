using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psihotest
{
    public partial class Zadacha3 : Form
    {
        string podzadacha;
        public Zadacha3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (podzadacha)
            {
                case "1":
                    Fenomen3_1 fenomen3_1 = new Fenomen3_1();
                    fenomen3_1.Show();
                    this.Close();
                    break;
                case "2":
                    teor3_1 teor3_1 = new teor3_1();
                    teor3_1.Show();
                    this.Close();
                    break;
                case "3":
                    DPO3 DPO3 = new DPO3();
                    DPO3.Show();
                    this.Close();
                    break;
                case "4":
                    DZ3_1 DZ3_1 = new DZ3_1();
                    DZ3_1.Show();
                    this.Close();
                    break;
                case "5":
                    meropriyatia3_1 meropriyatia3_1 = new meropriyatia3_1();
                    meropriyatia3_1.Show();
                    this.Close();
                    break;
                case "6":
                    katamnez3 katamnez3 = new katamnez3();
                    katamnez3.Show();
                    this.Close();
                    break;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            podzadacha = "6";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            podzadacha = "4";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            podzadacha = "2";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            podzadacha = "5";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            podzadacha = "3";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            podzadacha = "1";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadachi zadachi = new Zadachi();
            zadachi.Show();
            this.Close();
        }

        private void Zadacha3_Load(object sender, EventArgs e)
        {
            if (Program.diagnoz3 == 1)
            {
                if (Program.zakl3OTV == 1)
                {
                    radioButton3.Enabled = true;
                    radioButton6.Enabled = true;
                    label3.Text = "Диагноз правильный";
                    label3.Visible = true;
                    label3.ForeColor = Color.Lime;
                }
                else
                {
                    label3.Text = "Диагноз не правильный";
                    label3.Visible = true;
                    label3.ForeColor = Color.Red;
                }
                if (Program.zakl3OTV == 2)
                {
                    label3.Text = "Диагноз частично правильный";
                    label3.Visible = true;
                    label3.ForeColor = Color.Green;
                }
            }
        }
    }
}
