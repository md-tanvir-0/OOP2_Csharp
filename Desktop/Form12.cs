using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form9().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form7().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form10().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form5().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form11().Show();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
