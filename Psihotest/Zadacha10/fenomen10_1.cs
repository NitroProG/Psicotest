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
    public partial class fenomen10_1 : Form
    {
        public fenomen10_1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha10 zadacha10 = new Zadacha10();
            zadacha10.Show();
            this.Close();
        }

        private void fenomen10_1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fenomen10_2 fenomen10_2 = new fenomen10_2();
            fenomen10_2.Show();
            this.Close();
        }
    }
}
