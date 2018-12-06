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
    public partial class fenomen5_2 : Form
    {
        public fenomen5_2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fenomen5_1 fenomen5_1 = new Fenomen5_1();
            fenomen5_1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
               (checkBox1.Checked == false) &&
               (checkBox2.Checked == false) &&
               (checkBox3.Checked == false) &&
               (checkBox4.Checked == false) &&
               (checkBox5.Checked == false) &&
               (checkBox6.Checked == true) &&
               (checkBox7.Checked == false) &&
               (checkBox8.Checked == false) &&
               (checkBox9.Checked == true) &&
               (checkBox10.Checked == false) &&
               (checkBox11.Checked == false) &&
               (checkBox12.Checked == false) &&
               (checkBox13.Checked == false) &&
               (checkBox14.Checked == true) &&
               (checkBox15.Checked == true) &&
               (checkBox16.Checked == false) &&
               (checkBox17.Checked == false) &&
               (checkBox18.Checked == false)
               )
            {
                Program.fenom5OTV = 1;
            }
            if (
               (checkBox1.Checked == false) &&
               (checkBox2.Checked == false) &&
               (checkBox3.Checked == false) &&
               (checkBox4.Checked == false) &&
               (checkBox5.Checked == false) &&
               (checkBox6.Checked == false) &&
               (checkBox7.Checked == false) &&
               (checkBox8.Checked == false) &&
               (checkBox9.Checked == true) &&
               (checkBox10.Checked == false) &&
               (checkBox11.Checked == false) &&
               (checkBox12.Checked == false) &&
               (checkBox13.Checked == false) &&
               (checkBox14.Checked == true) &&
               (checkBox15.Checked == true) &&
               (checkBox16.Checked == false) &&
               (checkBox17.Checked == false) &&
               (checkBox18.Checked == false)
                ||
               (checkBox1.Checked == false) &&
               (checkBox2.Checked == false) &&
               (checkBox3.Checked == false) &&
               (checkBox4.Checked == false) &&
               (checkBox5.Checked == false) &&
               (checkBox6.Checked == true) &&
               (checkBox7.Checked == false) &&
               (checkBox8.Checked == false) &&
               (checkBox9.Checked == false) &&
               (checkBox10.Checked == false) &&
               (checkBox11.Checked == false) &&
               (checkBox12.Checked == false) &&
               (checkBox13.Checked == false) &&
               (checkBox14.Checked == true) &&
               (checkBox15.Checked == true) &&
               (checkBox16.Checked == false) &&
               (checkBox17.Checked == false) &&
               (checkBox18.Checked == false)
                ||
               (checkBox1.Checked == false) &&
               (checkBox2.Checked == false) &&
               (checkBox3.Checked == false) &&
               (checkBox4.Checked == false) &&
               (checkBox5.Checked == false) &&
               (checkBox6.Checked == true) &&
               (checkBox7.Checked == false) &&
               (checkBox8.Checked == false) &&
               (checkBox9.Checked == true) &&
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
               (checkBox5.Checked == false) &&
               (checkBox6.Checked == true) &&
               (checkBox7.Checked == false) &&
               (checkBox8.Checked == false) &&
               (checkBox9.Checked == true) &&
               (checkBox10.Checked == false) &&
               (checkBox11.Checked == false) &&
               (checkBox12.Checked == false) &&
               (checkBox13.Checked == false) &&
               (checkBox14.Checked == true) &&
               (checkBox15.Checked == false) &&
               (checkBox16.Checked == false) &&
               (checkBox17.Checked == false) &&
               (checkBox18.Checked == false)
                )
            {
                Program.fenom5OTV = 2;
            }
            Zadacha5 zadacha5 = new Zadacha5();
            zadacha5.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fenomen5_2_Load(object sender, EventArgs e)
        {
            if (Program.fenom5OTV == 1)
            {
                checkBox6.Checked = true;
                checkBox9.Checked = true;
                checkBox14.Checked = true;
                checkBox15.Checked = true;
            }
            richTextBox3.Text = Program.fenomenologiya5;
        }
    }
}
