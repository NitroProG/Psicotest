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
    public partial class Meropriatiya2_1 : Form
    {
        public Meropriatiya2_1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha2 zadacha2 = new Zadacha2();
            zadacha2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meropriatiya2_2 meropriatiya2_2 = new Meropriatiya2_2();
            meropriatiya2_2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
