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
            label12.Text = (Program.time1/1000).ToString(); 
        }
    }
}
