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
    public partial class meropriatia8_1 : Form
    {
        public meropriatia8_1()
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
            meropriatia8_2 meropriatia8_2 = new meropriatia8_2();
            meropriatia8_2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
