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
    public partial class _1 : Form
    {
        public _1()
        {
            InitializeComponent();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                (checkBox1.Checked == false) &&
                (checkBox2.Checked == false) &&
                (checkBox3.Checked == false) &&
                (checkBox4.Checked == false) &&
                (checkBox5.Checked == true) &&
                (checkBox6.Checked == false) &&
                (checkBox7.Checked == true) &&
                (checkBox8.Checked == false) &&
                (checkBox9.Checked == false) &&
                (checkBox10.Checked == false) &&
                (checkBox11.Checked == false) &&
                (checkBox12.Checked == false) &&
                (checkBox13.Checked == false) &&
                (checkBox14.Checked == false) &&
                (checkBox15.Checked == true) &&
                (checkBox16.Checked == false) &&
                (checkBox17.Checked == false) &&
                (checkBox18.Checked == false)
                )
            {
                Program.fenom1OTV = 1;
            }
            if (
                (checkBox1.Checked == false) &&
                (checkBox2.Checked == false) &&
                (checkBox3.Checked == false) &&
                (checkBox4.Checked == false) &&
                (checkBox5.Checked == false) &&
                (checkBox6.Checked == false) &&
                (checkBox7.Checked == true) &&
                (checkBox8.Checked == false) &&
                (checkBox9.Checked == false) &&
                (checkBox10.Checked == false) &&
                (checkBox11.Checked == false) &&
                (checkBox12.Checked == false) &&
                (checkBox13.Checked == false) &&
                (checkBox14.Checked == false) &&
                (checkBox15.Checked == true) &&
                (checkBox16.Checked == false) &&
                (checkBox17.Checked == false) &&
                (checkBox18.Checked == false)
                ||
                (checkBox1.Checked == false) &&
                (checkBox2.Checked == false) &&
                (checkBox3.Checked == false) &&
                (checkBox4.Checked == false) &&
                (checkBox5.Checked == true) &&
                (checkBox6.Checked == false) &&
                (checkBox7.Checked == false) &&
                (checkBox8.Checked == false) &&
                (checkBox9.Checked == false) &&
                (checkBox10.Checked == false) &&
                (checkBox11.Checked == false) &&
                (checkBox12.Checked == false) &&
                (checkBox13.Checked == false) &&
                (checkBox14.Checked == false) &&
                (checkBox15.Checked == true) &&
                (checkBox16.Checked == false) &&
                (checkBox17.Checked == false) &&
                (checkBox18.Checked == false)
                ||
                (checkBox1.Checked == false) &&
                (checkBox2.Checked == false) &&
                (checkBox3.Checked == false) &&
                (checkBox4.Checked == false) &&
                (checkBox5.Checked == true) &&
                (checkBox6.Checked == false) &&
                (checkBox7.Checked == true) &&
                (checkBox8.Checked == false) &&
                (checkBox9.Checked == false) &&
                (checkBox10.Checked == false) &&
                (checkBox11.Checked == false) &&
                (checkBox12.Checked == false) &&
                (checkBox13.Checked == false) &&
                (checkBox14.Checked == false) &&
                (checkBox15.Checked == false) &&
                (checkBox16.Checked == false) &&
                (checkBox17.Checked == false) &&
                (checkBox18.Checked == false)
                )
            {
                Program.fenom1OTV = 2;
            }
            Zadacha1 zadacha1 = new Zadacha1();
            zadacha1.Show();
            this.Close();
        }

        private void _1_Load(object sender, EventArgs e)
        {
            if (Program.fenom1OTV ==1)
            {
                checkBox15.Checked = true;
                checkBox5.Checked = true;
                checkBox7.Checked = true;
            }
            richTextBox3.Text = Program.fenomenologiya1;
        }

        private void _1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _1Fenomen _1Fenomen = new _1Fenomen();
            _1Fenomen.Show();
            this.Close();
        }
    }
}
