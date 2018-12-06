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
    public partial class fenomen3_2 : Form
    {
        public fenomen3_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
               (checkBox1.Checked == false) &&
               (checkBox2.Checked == false) &&
               (checkBox3.Checked == false) &&
               (checkBox4.Checked == false) &&
               (checkBox5.Checked == false) &&
               (checkBox6.Checked == false) &&
               (checkBox7.Checked == false) &&
               (checkBox8.Checked == false) &&
               (checkBox9.Checked == false) &&
               (checkBox10.Checked == true) &&
               (checkBox11.Checked == true) &&
               (checkBox12.Checked == false) &&
               (checkBox13.Checked == false) &&
               (checkBox14.Checked == false) &&
               (checkBox15.Checked == false) &&
               (checkBox16.Checked == true) &&
               (checkBox17.Checked == false) &&
               (checkBox18.Checked == false)
               )
            {
                Program.fenom3OTV = 1;
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
               (checkBox9.Checked == false) &&
               (checkBox10.Checked == false) &&
               (checkBox11.Checked == true) &&
               (checkBox12.Checked == false) &&
               (checkBox13.Checked == false) &&
               (checkBox14.Checked == false) &&
               (checkBox15.Checked == false) &&
               (checkBox16.Checked == true) &&
               (checkBox17.Checked == false) &&
               (checkBox18.Checked == false)
                ||
               (checkBox1.Checked == false) &&
               (checkBox2.Checked == false) &&
               (checkBox3.Checked == false) &&
               (checkBox4.Checked == false) &&
               (checkBox5.Checked == false) &&
               (checkBox6.Checked == false) &&
               (checkBox7.Checked == false) &&
               (checkBox8.Checked == false) &&
               (checkBox9.Checked == false) &&
               (checkBox10.Checked == true) &&
               (checkBox11.Checked == false) &&
               (checkBox12.Checked == false) &&
               (checkBox13.Checked == false) &&
               (checkBox14.Checked == false) &&
               (checkBox15.Checked == false) &&
               (checkBox16.Checked == true) &&
               (checkBox17.Checked == false) &&
               (checkBox18.Checked == false)
                ||
               (checkBox1.Checked == false) &&
               (checkBox2.Checked == false) &&
               (checkBox3.Checked == false) &&
               (checkBox4.Checked == false) &&
               (checkBox5.Checked == false) &&
               (checkBox6.Checked == false) &&
               (checkBox7.Checked == false) &&
               (checkBox8.Checked == false) &&
               (checkBox9.Checked == false) &&
               (checkBox10.Checked == true) &&
               (checkBox11.Checked == true) &&
               (checkBox12.Checked == false) &&
               (checkBox13.Checked == false) &&
               (checkBox14.Checked == false) &&
               (checkBox15.Checked == false) &&
               (checkBox16.Checked == false) &&
               (checkBox17.Checked == false) &&
               (checkBox18.Checked == false)
                )
            {
                Program.fenom3OTV = 2;
            }
            Zadacha3 zadacha3 = new Zadacha3();
            zadacha3.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fenomen3_1 fenomen3_1 = new Fenomen3_1();
            fenomen3_1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fenomen3_2_Load(object sender, EventArgs e)
        {
            if (Program.fenom3OTV == 1)
            {
                checkBox10.Checked = true;
                checkBox11.Checked = true;
                checkBox16.Checked = true;
            }
            richTextBox3.Text = Program.fenomenologiya3;
        }
    }
}
