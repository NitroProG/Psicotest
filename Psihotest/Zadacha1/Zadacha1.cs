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
    public partial class Zadacha1 : Form
    {
        string podzadacha;
        public Zadacha1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            podzadacha = "5";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadachi zadachi = new Zadachi();
            zadachi.Show();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            podzadacha = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (podzadacha)
            {
                case "1":
                    _1Fenomen _1Fenomen = new _1Fenomen();
                    _1Fenomen.Show();
                    this.Close();
                    break;
                case "2":
                    _teor1 _1teor1 = new _teor1();
                    _1teor1.Show();
                    this.Close();
                    break;
                case "3":
                    DPO DPO = new DPO();
                    DPO.Show();
                    this.Close();
                    break;
                case "4":
                    DZ1 DZ1 = new DZ1();
                    DZ1.Show();
                    this.Close();
                    break;
                case "5":
                    Meropriyatiya MP = new Meropriyatiya();
                    MP.Show();
                    this.Close();
                    break;
                case "6":
                    Katamnez Katamnez = new Katamnez();
                    Katamnez.Show();
                    this.Close();
                    break;
            }
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

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            podzadacha = "6";
        }

        private void Zadacha1_Load(object sender, EventArgs e)
        {
            if (Program.diagnoz1 == 1)
            {
                if (Program.zakl1OTV == 1)
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
                if (Program.zakl1OTV == 2)
                {
                    label3.Text = "Диагноз частично правильный";
                    label3.Visible = true;
                    label3.ForeColor = Color.Green;
                }
            }
        }
    }
}
