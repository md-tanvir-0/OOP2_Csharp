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
    public partial class BloodStock : Form
    {
        int count= 0;
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Bloodbank;Integrated Security=True");
        public BloodStock()
        {
            InitializeComponent();
            BindGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            count = 0;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Donartbl where Blood_Group like '" + searchbox.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            con.Close();


            if (count == 0)
            {
                MessageBox.Show("Not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridView();
            }
        }
        void BindGridView()
        {

            string query = "select * from Donartbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);


            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;



            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;
        }
    }
}
