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
    public partial class DZ3_1 : Form
    {
        public DZ3_1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha3 zadacha3 = new Zadacha3();
            zadacha3.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.zakluch3 = richTextBox4.Text;
            DZ3_2 dZ3_2 = new DZ3_2();
            dZ3_2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DZ3_1_Load(object sender, EventArgs e)
        {
            richTextBox3.Text = Program.fenomenologiya3;
            richTextBox1.Text = Program.obsledovaniya3;
            richTextBox2.Text = Program.gipotezi3;
            richTextBox4.Text = Program.zakluch3;
        }
    }
}
