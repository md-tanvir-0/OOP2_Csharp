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
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Bloodbank;Integrated Security=True");
        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dnorid.Text != "" && name.Text != "" && gender.Text != "" && dob.Text != "" && occupation.Text != "" && mobNum.Text != "" && email.Text != "" && blodgrp.Text != "" && city.Text != "" && address.Text != "")
            {
                string query = "insert into Donartbl Values (@Donor_ID,@Name,@Gender,@Date_of_Birth,@Ocupation,@Mobile_Nub,@Email,@Blood_Group,@Current_City,@Current_Address)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Donor_ID", dnorid.Text);
                cmd.Parameters.AddWithValue("@Name", name.Text);
                cmd.Parameters.AddWithValue("@Gender", gender.Text);
                cmd.Parameters.AddWithValue("@Date_of_Birth", dob.Text);
                cmd.Parameters.AddWithValue("@Ocupation", occupation.Text);
                cmd.Parameters.AddWithValue("@Mobile_Nub", mobNum.Text);
                cmd.Parameters.AddWithValue("@Email", email.Text);
                cmd.Parameters.AddWithValue("@Blood_Group", blodgrp.Text);
                cmd.Parameters.AddWithValue("@Current_City", city.Text);
                cmd.Parameters.AddWithValue("@Current_Address", address.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a != 0)
                {
                    MessageBox.Show("Apply Successfull ", " Suceess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Form14().Show();
                }
                else
                {
                    MessageBox.Show("Password Not Matched . Try Again. ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    
            }
            else
            {
                MessageBox.Show("Apply Not Succesfull ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form13().Show();
        }
    }
}
