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
    public partial class DZ4_1 : Form
    {
        public DZ4_1()
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
            Program.zakluch4 = richTextBox4.Text;
            DZ4_2 dZ4_2 = new DZ4_2();
            dZ4_2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DZ4_1_Load(object sender, EventArgs e)
        {
            richTextBox3.Text = Program.fenomenologiya4;
            richTextBox1.Text = Program.obsledovaniya4;
            richTextBox2.Text = Program.gipotezi4;
            richTextBox4.Text = Program.zakluch4;
        }
    }
}
