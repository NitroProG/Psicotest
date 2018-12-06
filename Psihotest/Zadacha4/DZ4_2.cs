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
    public partial class DZ4_2 : Form
    {
        public DZ4_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                (checkBox1.Checked == false) &&
                (checkBox2.Checked == false) &&
                (checkBox3.Checked == true) &&
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
                (checkBox15.Checked == false) &&
                (checkBox19.Checked == false) &&
                (checkBox20.Checked == true) &&
                (checkBox21.Checked == false) &&
                (checkBox22.Checked == true) &&
                (checkBox28.Checked == false) &&
                (checkBox29.Checked == false) &&
                (checkBox30.Checked == false) &&
                (checkBox31.Checked == false) &&
                (checkBox27.Checked == false) &&
                (checkBox33.Checked == false) &&
                (checkBox32.Checked == false)
                )
            {
                Program.zakl4OTV = 1;
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
                (checkBox15.Checked == false) &&
                (checkBox19.Checked == false) &&
                (checkBox20.Checked == true) &&
                (checkBox21.Checked == false) &&
                (checkBox22.Checked == true) &&
                (checkBox28.Checked == false) &&
                (checkBox29.Checked == false) &&
                (checkBox30.Checked == false) &&
                (checkBox31.Checked == false) &&
                (checkBox27.Checked == false) &&
                (checkBox33.Checked == false) &&
                (checkBox32.Checked == false)
                ||
                (checkBox1.Checked == false) &&
                (checkBox2.Checked == false) &&
                (checkBox3.Checked == true) &&
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
                (checkBox15.Checked == false) &&
                (checkBox19.Checked == false) &&
                (checkBox20.Checked == false) &&
                (checkBox21.Checked == false) &&
                (checkBox22.Checked == true) &&
                (checkBox28.Checked == false) &&
                (checkBox29.Checked == false) &&
                (checkBox30.Checked == false) &&
                (checkBox31.Checked == false) &&
                (checkBox27.Checked == false) &&
                (checkBox33.Checked == false) &&
                (checkBox32.Checked == false)
                ||
                (checkBox1.Checked == false) &&
                (checkBox2.Checked == false) &&
                (checkBox3.Checked == true) &&
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
                (checkBox15.Checked == false) &&
                (checkBox19.Checked == false) &&
                (checkBox20.Checked == true) &&
                (checkBox21.Checked == false) &&
                (checkBox22.Checked == false) &&
                (checkBox28.Checked == false) &&
                (checkBox29.Checked == false) &&
                (checkBox30.Checked == false) &&
                (checkBox31.Checked == false) &&
                (checkBox27.Checked == false) &&
                (checkBox33.Checked == false) &&
                (checkBox32.Checked == false)
                )
            {
                Program.zakl4OTV = 2;
            }
            Program.diagnoz4 = 1;
            Zadacha4 zadacha4 = new Zadacha4();
            zadacha4.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DZ4_1 dZ4_1 = new DZ4_1();
            dZ4_1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DZ4_2_Load(object sender, EventArgs e)
        {
            if (Program.zakl4OTV == 1)
            {
                checkBox3.Checked = true;
                checkBox20.Checked = true;
                checkBox22.Checked = true;
            }
            richTextBox4.Text = Program.zakluch4;
        }
    }
}
