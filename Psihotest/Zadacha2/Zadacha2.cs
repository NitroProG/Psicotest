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
    public partial class Zadacha2 : Form
    {
        string podzadacha;

        public Zadacha2()
        {
            InitializeComponent();
        }

        private void Zadacha2_Load(object sender, EventArgs e)
        {
            if (Program.diagnoz2 == 1)
            {
                if (Program.zakl2OTV == 1)
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
                if  (Program.zakl2OTV == 2)
                {
                    label3.Text = "Диагноз частично правильный";
                    label3.Visible = true;
                    label3.ForeColor = Color.Green;
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Zadachi zadachi = new Zadachi();
            zadachi.Show();
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            switch (podzadacha)
            {
                case "1":
                    Fenomen2 fenomen2 = new Fenomen2();
                    fenomen2.Show();
                    this.Close();
                    break;
                case "2":
                    teor2 teor2 = new teor2();
                    teor2.Show();
                    this.Close();
                    break;
                case "3":
                    DPO2 DPO2 = new DPO2();
                    DPO2.Show();
                    this.Close();
                    break;
                case "4":
                    DZ2_1 DZ2_1 = new DZ2_1();
                    DZ2_1.Show();
                    this.Close();
                    break;
                case "5":
                    Meropriatiya2_1 meropriatiya2_1 = new Meropriatiya2_1();
                    meropriatiya2_1.Show();
                    this.Close();
                    break;
                case "6":
                    katamnes2 katamnes2 = new katamnes2();
                    katamnes2.Show();
                    this.Close();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
