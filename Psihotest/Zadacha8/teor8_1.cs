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
    public partial class teor8_1 : Form
    {
        public teor8_1()
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
            teor8_2 teor8_2 = new teor8_2();
            teor8_2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
