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
    public partial class Fenomen8_2 : Form
    {
        public Fenomen8_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zadacha8 zadacha8 = new Zadacha8();
            zadacha8.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fenomen8_1 fenomen8_1 = new Fenomen8_1();
            fenomen8_1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
