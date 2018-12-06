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
    public partial class teor4_1 : Form
    {
        public teor4_1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha4 zadacha4 = new Zadacha4();
            zadacha4.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.gipotezi4 = richTextBox1.Text;
            teor4_2 teor4_2 = new teor4_2();
            teor4_2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void teor4_1_Load(object sender, EventArgs e)
        {
            richTextBox3.Text = Program.fenomenologiya4;
            richTextBox1.Text = Program.gipotezi4;
        }
    }
}
