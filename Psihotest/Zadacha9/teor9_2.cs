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
    public partial class teor9_2 : Form
    {
        public teor9_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zadacha9 zadacha9 = new Zadacha9();
            zadacha9.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            teor9_1 teor9_1 = new teor9_1();
            teor9_1.Show();
            this.Close();
        }
    }
}
