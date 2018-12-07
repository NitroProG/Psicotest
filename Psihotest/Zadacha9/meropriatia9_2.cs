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
    public partial class meropriatia9_2 : Form
    {
        public meropriatia9_2()
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
            meropriatia9_1 meropriatia9_1 = new meropriatia9_1();
            meropriatia9_1.Show();
            this.Close();
        }
    }
}
