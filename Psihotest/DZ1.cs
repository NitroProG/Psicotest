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
    public partial class DZ1 : Form
    {
        public DZ1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha1 zadacha1 = new Zadacha1();
            zadacha1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.zakluch1 = richTextBox4.Text;
            DZ2 DZ2 = new DZ2();
            DZ2.Show();
            this.Close();
        }

        private void DZ1_Load(object sender, EventArgs e)
        {
            richTextBox3.Text = Program.fenomenologiya1;
            richTextBox1.Text = Program.obsledovaniya1;
            richTextBox2.Text = Program.gipotezi1;
            richTextBox4.Text = Program.zakluch1;
        }
    }
}
