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
    public partial class meropriatia6_1 : Form
    {
        public meropriatia6_1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha6 zadacha6 = new Zadacha6();
            zadacha6.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            meropriatia6_2 meropriatia6_2 = new meropriatia6_2();
            meropriatia6_2.Show();
            this.Close();
        }
    }
}
