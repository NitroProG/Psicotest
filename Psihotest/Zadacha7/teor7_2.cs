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
    public partial class teor7_2 : Form
    {
        public teor7_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zadacha7 zadacha7 = new Zadacha7();
            zadacha7.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            teor7_1 teor7_1 = new teor7_1();
            teor7_1.Show();
            this.Close();
        }
    }
}
