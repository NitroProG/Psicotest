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
    public partial class Fenomen7_1 : Form
    {
        public Fenomen7_1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha7 zadacha7 = new Zadacha7();
            zadacha7.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fenomen7_2 fenomen7_2 = new Fenomen7_2();
            fenomen7_2.Show();
            this.Close();
        }
    }
}
