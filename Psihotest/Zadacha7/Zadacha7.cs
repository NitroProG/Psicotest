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
    public partial class Zadacha7 : Form
    {
        string podzadacha;
        public Zadacha7()
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
                    Fenomen7_1 fenomen7_1 = new Fenomen7_1();
                    fenomen7_1.Show();
                    this.Close();
                    break;
                case "2":
                    teor7_1 teor7_1 = new teor7_1();
                    teor7_1.Show();
                    this.Close();
                    break;
                case "3":
                    DPO7 DPO7 = new DPO7();
                    DPO7.Show();
                    this.Close();
                    break;
                case "4":
                    DZ7_1 DZ7_1 = new DZ7_1();
                    DZ7_1.Show();
                    this.Close();
                    break;
                case "5":
                    meropriatia7_1 meropriatia7_1 = new meropriatia7_1();
                    meropriatia7_1.Show();
                    this.Close();
                    break;
                case "6":
                    katamnez7 katamnez7 = new katamnez7();
                    katamnez7.Show();
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

        private void Zadacha7_Load(object sender, EventArgs e)
        {
            if (Program.diagnoz7 == 1)
            {
                if (Program.zakl7OTV == 1)
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
                if (Program.zakl7OTV == 2)
                {
                    label3.Text = "Диагноз частично правильный";
                    label3.Visible = true;
                    label3.ForeColor = Color.Green;
                }
            }
        }
    }
}
