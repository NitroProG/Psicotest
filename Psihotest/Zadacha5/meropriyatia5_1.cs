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
    public partial class meropriyatia5_1 : Form
    {
        public meropriyatia5_1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha5 zadacha5 = new Zadacha5();
            zadacha5.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            meropriyatia5_2 meropriyatia5_2 = new meropriyatia5_2();
            meropriyatia5_2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
