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


namespace Desktop
{
   

    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=bloodbank;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Admin")
            {
                if (userName.Text == "admin123" && pass.Text == "12345")
                {
                    MessageBox.Show("Signin Sucessful", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Form4().Show();
                }
                else
                {
                    MessageBox.Show("Signin Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (comboBox1.Text == "User")
            {
                if  (userName.Text !="" && pass.Text != "")
                {
                    string query = "select * from userlog where Username=@Username and Password=@Password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", userName.Text);
                    cmd.Parameters.AddWithValue("@Password", pass.Text);
                    con.Open();
                    SqlDataReader sda = cmd.ExecuteReader();
                    if (sda.HasRows == true)
                    {
                        MessageBox.Show("Signin Sucessful", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        new Form11().Show();

                    }
                    else
                    {
                        MessageBox.Show("Signin Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();

                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


