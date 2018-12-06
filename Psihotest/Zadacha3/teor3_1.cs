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
    public partial class teor3_1 : Form
    {
        public teor3_1()
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
            Program.gipotezi3 = richTextBox1.Text;
            teor3_2 teor3_2 = new teor3_2();
            teor3_2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void teor3_1_Load(object sender, EventArgs e)
        {
            richTextBox3.Text = Program.fenomenologiya3;
            richTextBox1.Text = Program.gipotezi3;
        }
    }
}
