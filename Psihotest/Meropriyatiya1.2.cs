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
    public partial class Meropriyatiya1 : Form
    {
        public Meropriyatiya1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Meropriyatiya meropriyatiya = new Meropriyatiya();
            meropriyatiya.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zadacha1 zadacha1 = new Zadacha1();
            zadacha1.Show();
            this.Close();
        }
    }
}
