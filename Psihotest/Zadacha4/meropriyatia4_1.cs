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
    public partial class meropriyatia4_1 : Form
    {
        public meropriyatia4_1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha4 zadacha4 = new Zadacha4();
            zadacha4.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            meropriyatia4_2 meropriyatia4_2 = new meropriyatia4_2();
            meropriyatia4_2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
