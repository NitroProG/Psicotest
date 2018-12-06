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
    
    public partial class Zadachi : Form
    {
        string zadacha;
        public Zadachi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (zadacha)
            {
                case "1":
                    Zadacha1 zadacha1 = new Zadacha1();
                    zadacha1.Show();
                    this.Close();
                    break;
                case "2":
                    Zadacha2 zadacha2 = new Zadacha2();
                    zadacha2.Show();
                    this.Close();
                    break;
                case "3":
                    Zadacha3 zadacha3 = new Zadacha3();
                    zadacha3.Show();
                    this.Close();
                    break;
                case "4":
                    Zadacha4 zadacha4 = new Zadacha4();
                    zadacha4.Show();
                    this.Close();
                    break;
                case "5":
                    Zadacha5 zadacha5 = new Zadacha5();
                    zadacha5.Show();
                    this.Close();
                    break;
                case "6":
                    Zadacha6 zadacha6 = new Zadacha6();
                    zadacha6.Show();
                    this.Close();
                    break;
                case "7":
                    Zadacha7 zadacha7 = new Zadacha7();
                    zadacha7.Show();
                    this.Close();
                    break;
                case "8":
                    Zadacha8 zadacha8 = new Zadacha8();
                    zadacha8.Show();
                    this.Close();
                    break;
                case "9":
                    Zadacha9 zadacha9 = new Zadacha9();
                    zadacha9.Show();
                    this.Close();
                    break;
                case "10":
                    Zadacha10 zadacha10 = new Zadacha10();
                    zadacha10.Show();
                    this.Close();
                    break;
                case "11":
                    Zadacha11 zadacha11 = new Zadacha11();
                    zadacha11.Show();
                    this.Close();
                    break;
                case "12":
                    Zadacha12 zadacha12 = new Zadacha12();
                    zadacha12.Show();
                    this.Close();
                    break;
                case "13":
                    Zadacha13 zadacha13 = new Zadacha13();
                    zadacha13.Show();
                    this.Close();
                    break;
                case "14":
                    Zadacha14 zadacha14 = new Zadacha14();
                    zadacha14.Show();
                    this.Close();
                    break;
                case "15":
                    Zadacha15 zadacha15 = new Zadacha15();
                    zadacha15.Show();
                    this.Close();
                    break;
                case "16":
                    Zadacha16 zadacha16 = new Zadacha16();
                    zadacha16.Show();
                    this.Close();
                    break;

            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            zadacha = "1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            zadacha = "2";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            zadacha = "3";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            zadacha = "4";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            zadacha = "5";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            zadacha = "6";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            zadacha = "7";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            zadacha = "8";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            zadacha = "9";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            zadacha = "10";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            zadacha = "11";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            zadacha = "12";
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            zadacha = "13";
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            zadacha = "14";
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            zadacha = "15";
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            zadacha = "16";
        }

        private void Zadachi_Load(object sender, EventArgs e)
        {
            if (Program.zakl1OTV == 1)
            {
                Program.fenomenologiya1 = "";
                Program.gipotezi1 = "";
                Program.obsledovaniya1 = "";
                Program.zakluch1 = "";
                Program.fenom1OTV = 0;
                Program.teor1OTV = 0;
                Program.zakl1OTV = 0;
                Program.diagnoz1 = 0;
                label1.Text = "Решено";
            }
            if (Program.zakl2OTV == 1)
            {
                Program.fenomenologiya2 = "";
                Program.gipotezi2 = "";
                Program.obsledovaniya2 = "";
                Program.zakluch2 = "";
                Program.fenom2OTV = 0;
                Program.teor2OTV = 0;
                Program.zakl2OTV = 0;
                Program.diagnoz2 = 0;
                label2.Text = "Решено";
            }
            if (Program.zakl3OTV == 1)
            {
                Program.fenomenologiya3 = "";
                Program.gipotezi3 = "";
                Program.obsledovaniya3 = "";
                Program.zakluch3 = "";
                Program.fenom3OTV = 0;
                Program.teor3OTV = 0;
                Program.zakl3OTV = 0;
                Program.diagnoz3 = 0;
                label3.Text = "Решено";
            }
            if (Program.zakl4OTV == 1)
            {
                Program.fenomenologiya4 = "";
                Program.gipotezi4 = "";
                Program.obsledovaniya4 = "";
                Program.zakluch4 = "";
                Program.fenom4OTV = 0;
                Program.teor4OTV = 0;
                Program.zakl4OTV = 0;
                Program.diagnoz4 = 0;
                label4.Text = "Решено";
            }
            if (Program.zakl5OTV == 1)
            {
                Program.fenomenologiya5 = "";
                Program.gipotezi5 = "";
                Program.obsledovaniya5 = "";
                Program.zakluch5 = "";
                Program.fenom5OTV = 0;
                Program.teor5OTV = 0;
                Program.zakl5OTV = 0;
                Program.diagnoz5 = 0;
                label5.Text = "Решено";
            }
            if (Program.zakl6OTV == 1)
            {
                Program.fenomenologiya6 = "";
                Program.gipotezi6 = "";
                Program.obsledovaniya6 = "";
                Program.zakluch6 = "";
                Program.fenom6OTV = 0;
                Program.teor6OTV = 0;
                Program.zakl6OTV = 0;
                Program.diagnoz6 = 0;
                label6.Text = "Решено";
            }
            if (Program.zakl7OTV == 1)
            {
                Program.fenomenologiya7 = "";
                Program.gipotezi7 = "";
                Program.obsledovaniya7 = "";
                Program.zakluch7 = "";
                Program.fenom7OTV = 0;
                Program.teor7OTV = 0;
                Program.zakl7OTV = 0;
                Program.diagnoz7 = 0;
                label7.Text = "Решено";
            }
            if (Program.zakl8OTV == 1)
            {
                Program.fenomenologiya8 = "";
                Program.gipotezi8 = "";
                Program.obsledovaniya8 = "";
                Program.zakluch8 = "";
                Program.fenom8OTV = 0;
                Program.teor8OTV = 0;
                Program.zakl8OTV = 0;
                Program.diagnoz8 = 0;
                label8.Text = "Решено";
            }
        }
    }
}
