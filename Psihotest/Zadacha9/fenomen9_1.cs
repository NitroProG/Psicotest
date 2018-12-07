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
    public partial class fenomen9_1 : Form
    {
        public fenomen9_1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha9 zadacha9 = new Zadacha9();
            zadacha9.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fenomen9_2 fenomen9_2 = new fenomen9_2();
            fenomen9_2.Show();
            this.Close();
        }
    }
}
