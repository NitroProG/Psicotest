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
    public partial class protokol : Form
    {
        public protokol()
        {
            InitializeComponent();
        }

        private void protokol_Load(object sender, EventArgs e)
        {
            label7.Text = Program.fio;
            label8.Text = Program.obrazov;
            label9.Text = Program.mestrab;
            label10.Text = Program.godob;
            label11.Text = Program.vozr;
            label12.Text = (Program.time1).ToString();
            label19.Text = (Program.fenomt1).ToString();
            label20.Text = (Program.teort1).ToString();
            label21.Text = (Program.dpot1).ToString();
            label22.Text = (Program.dzt1).ToString();
            label23.Text = (Program.meroprt).ToString();
            label24.Text = (Program.katamt1).ToString();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zadachi zadachi = new Zadachi();
            zadachi.Show();
            this.Close();
        }
    }
}
