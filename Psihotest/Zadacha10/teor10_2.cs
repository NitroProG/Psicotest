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
    public partial class teor10_2 : Form
    {
        public teor10_2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            teor10_1 teor10_1 = new teor10_1();
            teor10_1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zadacha10 zadacha10 = new Zadacha10();
            zadacha10.Show();
            this.Close();
        }
    }
}
