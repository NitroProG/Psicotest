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
    public partial class meropriatia7_2 : Form
    {
        public meropriatia7_2()
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
            meropriatia7_1 meropriatia7_1 = new meropriatia7_1();
            meropriatia7_1.Show();
            this.Close();
        }
    }
}
