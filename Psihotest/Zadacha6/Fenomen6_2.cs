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
    public partial class Fenomen6_2 : Form
    {
        public Fenomen6_2()
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
                (checkBox5.Checked == true) &&
                (checkBox6.Checked == false) &&
                (checkBox7.Checked == false) &&
                (checkBox8.Checked == false) &&
                (checkBox9.Checked == true) &&
                (checkBox10.Checked == false) &&
                (checkBox11.Checked == false) &&
                (checkBox12.Checked == false) &&
                (checkBox13.Checked == false) &&
                (checkBox14.Checked == false) &&
                (checkBox15.Checked == false) &&
                (checkBox16.Checked == false) &&
                (checkBox17.Checked == true) &&
                (checkBox18.Checked == false) &&
                (checkBox19.Checked == false) &&
                (checkBox20.Checked == false) &&
                (checkBox24.Checked == false) &&
                (checkBox25.Checked == false) &&
                (checkBox26.Checked == false) &&
                (checkBox30.Checked == false) 
                )
            {
                Program.fenom6OTV = 1;
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
                (checkBox14.Checked == false) &&
                (checkBox15.Checked == false) &&
                (checkBox16.Checked == false) &&
                (checkBox17.Checked == true) &&
                (checkBox18.Checked == false) &&
                (checkBox19.Checked == false) &&
                (checkBox20.Checked == false) &&
                (checkBox24.Checked == false) &&
                (checkBox25.Checked == false) &&
                (checkBox26.Checked == false) &&
                (checkBox30.Checked == false)
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
                (checkBox15.Checked == false) &&
                (checkBox16.Checked == false) &&
                (checkBox17.Checked == true) &&
                (checkBox18.Checked == false) &&
                (checkBox19.Checked == false) &&
                (checkBox20.Checked == false) &&
                (checkBox24.Checked == false) &&
                (checkBox25.Checked == false) &&
                (checkBox26.Checked == false) &&
                (checkBox30.Checked == false)
                ||
                (checkBox1.Checked == false) &&
                (checkBox2.Checked == false) &&
                (checkBox3.Checked == false) &&
                (checkBox4.Checked == false) &&
                (checkBox5.Checked == true) &&
                (checkBox6.Checked == false) &&
                (checkBox7.Checked == false) &&
                (checkBox8.Checked == false) &&
                (checkBox9.Checked == true) &&
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
                (checkBox24.Checked == false) &&
                (checkBox25.Checked == false) &&
                (checkBox26.Checked == false) &&
                (checkBox30.Checked == false)
                )
            {
                Program.fenom6OTV = 2;
            }
            Zadacha6 zadacha6 = new Zadacha6();
            zadacha6.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fenomen6_1 fenomen6_1 = new Fenomen6_1();
            fenomen6_1.Show();
            this.Close();
        }

        private void Fenomen6_2_Load(object sender, EventArgs e)
        {
            if (Program.fenom6OTV == 1)
            {
                checkBox5.Checked = true;
                checkBox9.Checked = true;
                checkBox17.Checked = true;
            }
            richTextBox3.Text = Program.fenomenologiya6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
