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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vhod vhod = new Vhod();
            vhod.Show();
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ITACHI\\ZERGI;initial catalog=psihotest;Persist Security info = True; User ID = sa; Password = Qq112233! ");
            con.Open(); // подключение к БД

            SqlDataAdapter da = new SqlDataAdapter("select laginus as 'Логин', parol as 'Пароль',isadmin as 'Администратор(1 да,0 нет)' from yser", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "yser");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ITACHI\\ZERGI;initial catalog=psihotest;Persist Security info = True; User ID = sa; Password = Qq112233! ");
            con.Open(); // подключение к БД

            SqlCommand sc1 = new SqlCommand("Select * from yser where[laginus] = '" + textBox1.Text + "'", con); //выбор данных из таблицы БД 
            SqlDataReader dr1;
            dr1 = sc1.ExecuteReader();
            int count1 = 0;
            while (dr1.Read())
            {
                count1 += 1;
            }
            dr1.Close();

            if (count1 == 1)
            {
                MessageBox.Show("Такой логин уже существует");
            }
            else
            {
                if ((textBox1.Text == "") || (textBox2.Text == "")||(comboBox1.Text=="") )
                {
                    MessageBox.Show("Не все поля заполнены");
                }
                else
                {


                    SqlCommand StrPrc1 = new SqlCommand("yser_add", con);
                    StrPrc1.CommandType = CommandType.StoredProcedure;
                    StrPrc1.Parameters.AddWithValue("@laginus", textBox1.Text);
                    StrPrc1.Parameters.AddWithValue("@parol", textBox2.Text);
                    if (comboBox1.Text == "Пользователь")
                    {
                        StrPrc1.Parameters.AddWithValue("@isadmin", 1);
                    }
                    else
                    {
                        if (comboBox1.Text == "Администратор")
                        {
                            StrPrc1.Parameters.AddWithValue("@isadmin", 0);
                        }
                    }
                    StrPrc1.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("Вы успешно зарегистрировали нового пользователя");
                    Admin admin = new Admin();
                    admin.Show();
                    this.Close();
                }
            }
    }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
