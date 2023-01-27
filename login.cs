using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Xml.Linq;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace terserah
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create connection
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HDDLAL19\SQLEXPRESS;Initial Catalog=db_latihan;Integrated Security=True");
            //create command
            SqlCommand cmd = new SqlCommand("select * from tb_login where username=@username and paswword=@password", con);
            //add parameter
            cmd.Parameters.AddWithValue("@username", tbname.Text);
            cmd.Parameters.AddWithValue("@password", tbkey.Text);
            //open connection
            con.Open();
            //create data reader and execute the command
            SqlDataReader dr = cmd.ExecuteReader();
            //read the data and store them in the list
            if (dr.Read())
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
            //close connection
            con.Close();

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbkey_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
