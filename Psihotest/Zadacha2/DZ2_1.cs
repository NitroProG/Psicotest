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
    public partial class DZ2_1 : Form
    {
        public DZ2_1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha2 zadacha2 = new Zadacha2();
            zadacha2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.zakluch2 = richTextBox4.Text;
            DZ2_2 dZ2_2 = new DZ2_2();
            dZ2_2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DZ2_1_Load(object sender, EventArgs e)
        {
            richTextBox3.Text = Program.fenomenologiya2;
            richTextBox1.Text = Program.obsledovaniya2;
            richTextBox2.Text = Program.gipotezi2;
            richTextBox4.Text = Program.zakluch2;
        }
    }
}
