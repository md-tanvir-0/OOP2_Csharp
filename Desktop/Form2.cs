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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Bloodbank;Integrated Security=True");
        
        public Form2()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
              

            if (name.Text != ""&& email.Text != "" && gender.Text!= "" && dob.Text != "" && blood.Text != "" && userName.Text != "" && pass.Text != "" )
            {
                string query = "insert into userlog Values (@Name,@Email_Mob_No,@Gender,@Date_of_Birth,@Select_Blood_Group,@Username,@Password)";
                SqlCommand cmd = new SqlCommand(query, con); 
                
                cmd.Parameters.AddWithValue("@Name", name.Text); 
                cmd.Parameters.AddWithValue("@Email_Mob_No", email.Text);
                cmd.Parameters.AddWithValue("@Gender", gender.Text);
                cmd.Parameters.AddWithValue("@Date_of_Birth", dob.Text);
                cmd.Parameters.AddWithValue("@Select_Blood_Group", blood.Text);
                cmd.Parameters.AddWithValue("@Username", userName.Text);
                cmd.Parameters.AddWithValue("@Password", pass.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if(a!= 0)
                {
                    MessageBox.Show("SignUp Successfull ", " Suceess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Form3().Show();
                }
                else
                {
                    MessageBox.Show("Password Not Matched . Try Again. ", "Failed",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("SignUp Not Succesfull ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
