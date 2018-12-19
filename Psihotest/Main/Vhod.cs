using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Psihotest
{
    public partial class Vhod : Form
    {
        public Vhod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-38O7FKR\\FILESBD;initial catalog=psihotest; Persist Security info = True; User ID = sa; Password = D6747960f");
            //con.Open(); // подключение к БД

            //SqlCommand sc = new SqlCommand("Select * from yser where[laginus] = '" + textBox1.Text + "' and[parol] = '" + textBox2.Text + "'and [isadmin]='1'", con); //выбор данных из таблицы БД 
            //SqlDataReader dr;
            //dr = sc.ExecuteReader();
            //int count = 0;
            //while (dr.Read())
            //{
            //    count += 1;
            //}
            //dr.Close();

            //if (count == 1)
            //{
            //    Admin admin = new Admin();
            //    admin.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    SqlCommand sc1 = new SqlCommand("Select * from yser where[laginus] = '" + textBox1.Text + "' and[parol] = '" + textBox2.Text + "'and [isadmin]='0'", con); //выбор данных из таблицы БД 
            //    SqlDataReader dr1;
            //    dr1 = sc1.ExecuteReader();
            //    int count1 = 0;
            //    while (dr1.Read())
            //    {
            //        count1 += 1;
            //    }
            //    dr1.Close();

            //    if (count1 == 1)
            //    {
                    Anketa anketa = new Anketa();
                    anketa.Show();
                    this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Данные введены не верно");
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
