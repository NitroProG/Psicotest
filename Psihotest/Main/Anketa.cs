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
    public partial class Anketa : Form
    {
        public Anketa()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if ((textBox1.Text!="")&&(textBox2.Text != "") && (textBox4.Text != "") && (textBox5.Text != "")) {
                Program.fio = textBox1.Text;
                Program.obrazov= textBox2.Text;
                Program.mestrab= textBox3.Text;
                Program.godob= textBox4.Text;
                Program.vozr= textBox5.Text;
                Privetstvie privetstvie = new Privetstvie();
                privetstvie.Show();
                this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Не все обязательные поля заполнены");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Anketa_Load(object sender, EventArgs e)
        {

        }
    }
}
