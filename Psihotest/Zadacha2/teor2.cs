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
    public partial class teor2 : Form
    {
        public teor2()
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
            Program.gipotezi2 = richTextBox1.Text;
            teor2_2 teor2_2 = new teor2_2();
            teor2_2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void teor2_Load(object sender, EventArgs e)
        {
            richTextBox3.Text = Program.fenomenologiya2;
            richTextBox1.Text = Program.gipotezi2;
        }
    }
}
