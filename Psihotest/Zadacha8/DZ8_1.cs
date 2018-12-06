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
    public partial class DZ8_1 : Form
    {
        public DZ8_1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha8 zadacha8 = new Zadacha8();
            zadacha8.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DZ8_2 dZ8_2 = new DZ8_2();
            dZ8_2.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
