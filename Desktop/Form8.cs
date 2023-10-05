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
    public partial class Form8 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Bloodbank;Integrated Security=True");
        public Form8()
        {
            InitializeComponent();
            BindGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "delete from Donartbl where Donor_ID=@Donor_ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Donor_ID", donarId.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a != 0)
            {
                MessageBox.Show("Donor Deleted", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridView();
                ClearData();
            }
            else
            {
                MessageBox.Show("Data  not deleted ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            con.Close();


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
        private void ClearData()
        {
            donarId.Text = "";
            
        }

        private void donarId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();

        }
    }

}

            