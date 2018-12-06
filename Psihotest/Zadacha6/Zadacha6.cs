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
    public partial class Zadacha6 : Form
    {
        string podzadacha;
        public Zadacha6()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadachi zadachi = new Zadachi();
            zadachi.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (podzadacha)
            {
                case "1":
                    Fenomen6_1 fenomen6_1 = new Fenomen6_1();
                    fenomen6_1.Show();
                    this.Close();
                    break;
                case "2":
                    teor6_1 teor6_1 = new teor6_1();
                    teor6_1.Show();
                    this.Close();
                    break;
                case "3":
                    DPO6 DPO6 = new DPO6();
                    DPO6.Show();
                    this.Close();
                    break;
                case "4":
                    DZ6_1 DZ6_1 = new DZ6_1();
                    DZ6_1.Show();
                    this.Close();
                    break;
                case "5":
                    meropriatia6_1 meropriatia6_1 = new meropriatia6_1();
                    meropriatia6_1.Show();
                    this.Close();
                    break;
                case "6":
                    katamnez6 katamnez6 = new katamnez6();
                    katamnez6.Show();
                    this.Close();
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            podzadacha = "1";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            podzadacha = "2";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            podzadacha = "3";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            podzadacha = "4";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            podzadacha = "5";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            podzadacha = "6";
        }

        private void Zadacha6_Load(object sender, EventArgs e)
        {
            if (Program.diagnoz6 == 1)
            {
                if (Program.zakl6OTV == 1)
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
                if (Program.zakl6OTV == 2)
                {
                    label3.Text = "Диагноз частично правильный";
                    label3.Visible = true;
                    label3.ForeColor = Color.Green;
                }
            }
        }
    }
}
