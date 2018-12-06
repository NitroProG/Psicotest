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
    public partial class teor5_2 : Form
    {
        public teor5_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                (checkBox1.Checked == false) &&
                (checkBox2.Checked == false) &&
                (checkBox3.Checked == false) &&
                (checkBox4.Checked == true) &&
                (checkBox5.Checked == false) &&
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
                (checkBox18.Checked == false) &&
                (checkBox19.Checked == false) &&
                (checkBox20.Checked == false) &&
                (checkBox21.Checked == false) &&
                (checkBox22.Checked == false) &&
                (checkBox23.Checked == false) &&
                (checkBox24.Checked == true) &&
                (checkBox25.Checked == false) &&
                (checkBox26.Checked == true)
                )
            {
                Program.teor5OTV = 1;
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
                (checkBox11.Checked == false) &&
                (checkBox12.Checked == false) &&
                (checkBox13.Checked == false) &&
                (checkBox14.Checked == false) &&
                (checkBox15.Checked == true) &&
                (checkBox16.Checked == false) &&
                (checkBox17.Checked == false) &&
                (checkBox18.Checked == false) &&
                (checkBox19.Checked == false) &&
                (checkBox20.Checked == false) &&
                (checkBox21.Checked == false) &&
                (checkBox22.Checked == false) &&
                (checkBox23.Checked == false) &&
                (checkBox24.Checked == true) &&
                (checkBox25.Checked == false) &&
                (checkBox26.Checked == true)
                ||
                (checkBox1.Checked == false) &&
                (checkBox2.Checked == false) &&
                (checkBox3.Checked == false) &&
                (checkBox4.Checked == true) &&
                (checkBox5.Checked == false) &&
                (checkBox6.Checked == false) &&
                (checkBox7.Checked == false) &&
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
                (checkBox18.Checked == false) &&
                (checkBox19.Checked == false) &&
                (checkBox20.Checked == false) &&
                (checkBox21.Checked == false) &&
                (checkBox22.Checked == false) &&
                (checkBox23.Checked == false) &&
                (checkBox24.Checked == true) &&
                (checkBox25.Checked == false) &&
                (checkBox26.Checked == true)
                ||
                (checkBox1.Checked == false) &&
                (checkBox2.Checked == false) &&
                (checkBox3.Checked == false) &&
                (checkBox4.Checked == true) &&
                (checkBox5.Checked == false) &&
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
                (checkBox18.Checked == false) &&
                (checkBox19.Checked == false) &&
                (checkBox20.Checked == false) &&
                (checkBox21.Checked == false) &&
                (checkBox22.Checked == false) &&
                (checkBox23.Checked == false) &&
                (checkBox24.Checked == false) &&
                (checkBox25.Checked == false) &&
                (checkBox26.Checked == true)
                ||
                (checkBox1.Checked == false) &&
                (checkBox2.Checked == false) &&
                (checkBox3.Checked == false) &&
                (checkBox4.Checked == true) &&
                (checkBox5.Checked == false) &&
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
                (checkBox18.Checked == false) &&
                (checkBox19.Checked == false) &&
                (checkBox20.Checked == false) &&
                (checkBox21.Checked == false) &&
                (checkBox22.Checked == false) &&
                (checkBox23.Checked == false) &&
                (checkBox24.Checked == true) &&
                (checkBox25.Checked == false) &&
                (checkBox26.Checked == false)
                )
            {
                Program.teor5OTV = 2;
            }
            Zadacha5 zadacha5 = new Zadacha5();
            zadacha5.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            teor5_1 teor5_1 = new teor5_1();
            teor5_1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void teor5_2_Load(object sender, EventArgs e)
        {
            if (Program.teor5OTV == 1)
            {
                checkBox4.Checked = true;
                checkBox15.Checked = true;
                checkBox24.Checked = true;
                checkBox26.Checked = true;
            }
            richTextBox3.Text = Program.gipotezi5;
        }
    }
}
