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
    public partial class DZ5_1 : Form
    {
        public DZ5_1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha5 zadacha5 = new Zadacha5();
            zadacha5.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.zakluch5 = richTextBox4.Text;
            DZ5_2 dZ5_2 = new DZ5_2();
            dZ5_2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DZ5_1_Load(object sender, EventArgs e)
        {
            richTextBox3.Text = Program.fenomenologiya5;
            richTextBox1.Text = Program.obsledovaniya5;
            richTextBox2.Text = Program.gipotezi5;
            richTextBox4.Text = Program.zakluch5;
        }
    }
}
