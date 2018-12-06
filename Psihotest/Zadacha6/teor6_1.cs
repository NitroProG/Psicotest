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
    public partial class teor6_1 : Form
    {
        public teor6_1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha6 zadacha6 = new Zadacha6();
            zadacha6.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.gipotezi6 = richTextBox1.Text;
            teor6_2 teor6_2 = new teor6_2();
            teor6_2.Show();
            this.Close();
        }

        private void teor6_1_Load(object sender, EventArgs e)
        {
            richTextBox3.Text = Program.fenomenologiya6;
            richTextBox1.Text = Program.gipotezi6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
