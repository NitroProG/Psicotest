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
    public partial class Zadacha5 : Form
    {
        string podzadacha;
        public Zadacha5()
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
                    Fenomen5_1 fenomen5_1 = new Fenomen5_1();
                    fenomen5_1.Show();
                    this.Close();
                    break;
                case "2":
                    teor5_1 teor5_1 = new teor5_1();
                    teor5_1.Show();
                    this.Close();
                    break;
                case "3":
                    DPO5 DPO5 = new DPO5();
                    DPO5.Show();
                    this.Close();
                    break;
                case "4":
                    DZ5_1 DZ5_1 = new DZ5_1();
                    DZ5_1.Show();
                    this.Close();
                    break;
                case "5":
                    meropriyatia5_1 meropriyatia5_1 = new meropriyatia5_1();
                    meropriyatia5_1.Show();
                    this.Close();
                    break;
                case "6":
                    katamnez5 katamnez5 = new katamnez5();
                    katamnez5.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Zadacha5_Load(object sender, EventArgs e)
        {
            if (Program.diagnoz5 == 1)
            {
                if (Program.zakl5OTV == 1)
                {
                    radioButton3.Enabled = true;
                    radioButton11.Enabled = true;
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
                if (Program.zakl5OTV == 2)
                {
                    label3.Text = "Диагноз частично правильный";
                    label3.Visible = true;
                    label3.ForeColor = Color.Green;
                }
            }
        }
    }
}
