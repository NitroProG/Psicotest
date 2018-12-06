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
    public partial class _teor1 : Form
    {
        public _teor1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha1 zadacha1 = new Zadacha1();
            zadacha1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.gipotezi1 = richTextBox1.Text;
            _1_1teor _1_1Teor = new _1_1teor();
            _1_1Teor.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _teor1_Load(object sender, EventArgs e)
        {
            richTextBox3.Text = Program.fenomenologiya1;
            richTextBox1.Text = Program.gipotezi1;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Program.time1 = Program.time1 + 1;
        }
    }
}
