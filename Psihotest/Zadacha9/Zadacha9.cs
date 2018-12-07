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
    public partial class Zadacha9 : Form
    {
        string podzadacha;
        public Zadacha9()
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
                    fenomen9_1 fenomen9_1 = new fenomen9_1();
                    fenomen9_1.Show();
                    this.Close();
                    break;
                case "2":
                    teor9_1 teor9_1 = new teor9_1();
                    teor9_1.Show();
                    this.Close();
                    break;
                case "3":
                    DPO9 DPO9 = new DPO9();
                    DPO9.Show();
                    this.Close();
                    break;
                case "4":
                    DZ9_1 DZ9_1 = new DZ9_1();
                    DZ9_1.Show();
                    this.Close();
                    break;
                case "5":
                    meropriatia9_1 meropriatia9_1 = new meropriatia9_1();
                    meropriatia9_1.Show();
                    this.Close();
                    break;
                case "6":
                    Katamnez9 katamnez9 = new Katamnez9();
                    katamnez9.Show();
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
    }
}
