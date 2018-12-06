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
    public partial class katamnez3 : Form
    {
        public katamnez3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha3 zadacha3 = new Zadacha3();
            zadacha3.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zadachi zadachi = new Zadachi();
            zadachi.Show();
            this.Close();
        }
    }
}
