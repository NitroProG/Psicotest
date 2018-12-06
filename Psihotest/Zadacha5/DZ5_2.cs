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
    public partial class DZ5_2 : Form
    {
        public DZ5_2()
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
                (checkBox19.Checked == false) &&
                (checkBox20.Checked == false) &&
                (checkBox21.Checked == false) &&
                (checkBox22.Checked == false) &&
                (checkBox28.Checked == true) &&
                (checkBox29.Checked == false) &&
                (checkBox30.Checked == false) &&
                (checkBox31.Checked == false) &&
                (checkBox27.Checked == true) &&
                (checkBox33.Checked == false) &&
                (checkBox32.Checked == false)
                )
            {
                Program.zakl5OTV = 1;
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
                (checkBox19.Checked == false) &&
                (checkBox20.Checked == false) &&
                (checkBox21.Checked == false) &&
                (checkBox22.Checked == false) &&
                (checkBox28.Checked == true) &&
                (checkBox29.Checked == false) &&
                (checkBox30.Checked == false) &&
                (checkBox31.Checked == false) &&
                (checkBox27.Checked == true) &&
                (checkBox33.Checked == false) &&
                (checkBox32.Checked == false)
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
                (checkBox19.Checked == false) &&
                (checkBox20.Checked == false) &&
                (checkBox21.Checked == false) &&
                (checkBox22.Checked == false) &&
                (checkBox28.Checked == true) &&
                (checkBox29.Checked == false) &&
                (checkBox30.Checked == false) &&
                (checkBox31.Checked == false) &&
                (checkBox27.Checked == true) &&
                (checkBox33.Checked == false) &&
                (checkBox32.Checked == false)
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
                (checkBox19.Checked == false) &&
                (checkBox20.Checked == false) &&
                (checkBox21.Checked == false) &&
                (checkBox22.Checked == false) &&
                (checkBox28.Checked == false) &&
                (checkBox29.Checked == false) &&
                (checkBox30.Checked == false) &&
                (checkBox31.Checked == false) &&
                (checkBox27.Checked == true) &&
                (checkBox33.Checked == false) &&
                (checkBox32.Checked == false)
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
                (checkBox19.Checked == false) &&
                (checkBox20.Checked == false) &&
                (checkBox21.Checked == false) &&
                (checkBox22.Checked == false) &&
                (checkBox28.Checked == true) &&
                (checkBox29.Checked == false) &&
                (checkBox30.Checked == false) &&
                (checkBox31.Checked == false) &&
                (checkBox27.Checked == false) &&
                (checkBox33.Checked == false) &&
                (checkBox32.Checked == false)
                )
            {
                Program.zakl5OTV = 2;
            }
            Program.diagnoz5 = 1;
            Zadacha5 zadacha5 = new Zadacha5();
            zadacha5.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DZ5_1 dZ5_1 = new DZ5_1();
            dZ5_1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DZ5_2_Load(object sender, EventArgs e)
        {
            if (Program.zakl5OTV == 1)
            {
                checkBox4.Checked = true;
                checkBox15.Checked = true;
                checkBox27.Checked = true;
                checkBox28.Checked = true;
            }
            richTextBox4.Text = Program.zakluch5;
        }
    }
}
