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
    public partial class Zadacha4 : Form
    {
        string podzadacha;
        public Zadacha4()
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
                    Fenomen4_1 fenomen4_1 = new Fenomen4_1();
                    fenomen4_1.Show();
                    this.Close();
                    break;
                case "2":
                    teor4_1 teor4_1 = new teor4_1();
                    teor4_1.Show();
                    this.Close();
                    break;
                case "3":
                    DPO4 DPO4 = new DPO4();
                    DPO4.Show();
                    this.Close();
                    break;
                case "4":
                    DZ4_1 DZ4_1 = new DZ4_1();
                    DZ4_1.Show();
                    this.Close();
                    break;
                case "5":
                    meropriyatia4_1 meropriyatia4_1 = new meropriyatia4_1();
                    meropriyatia4_1.Show();
                    this.Close();
                    break;
                case "6":
                    katamnez4 katamnez4 = new katamnez4();
                    katamnez4.Show();
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

        private void Zadacha4_Load(object sender, EventArgs e)
        {
            if (Program.diagnoz4 == 1)
            {
                if (Program.zakl4OTV == 1)
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
                if (Program.zakl4OTV == 2)
                {
                    label3.Text = "Диагноз частично правильный";
                    label3.Visible = true;
                    label3.ForeColor = Color.Green;
                }
            }
        }
    }
}
