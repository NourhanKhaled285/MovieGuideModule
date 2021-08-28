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

namespace movie_guide_module_3
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VOK8FTS3;Initial Catalog=MOVIE GUIDE MODULE 1;Integrated Security=True");
            con.Open();

            //SqlCommand cmd = new SqlCommand("select title,ID from movie where director =@dir_name", con);
            SqlCommand cmd = new SqlCommand("select * from history where [movie name]=@atitle", con);
            SqlParameter actor = new SqlParameter("@atitle", textBox1.Text);
            cmd.Parameters.Add(actor);
            SqlDataReader read = cmd.ExecuteReader();


            DataTable dt = new DataTable();
            dt.Load(read);
            dataGridView1.DataSource = dt;*/
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /* SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VOK8FTS3;Initial Catalog=MOVIE GUIDE MODULE 1;Integrated Security=True");
           con.Open();

           //SqlCommand cmd = new SqlCommand("select title,ID from movie where director =@dir_name", con);
           SqlCommand cmd = new SqlCommand("select * from history where [movie name]=@atitle", con);
           SqlParameter actor = new SqlParameter("@atitle", textBox1.Text);
           cmd.Parameters.Add(actor);
           SqlDataReader read = cmd.ExecuteReader();


           DataTable dt = new DataTable();
           dt.Load(read);
           dataGridView1.DataSource = dt;*/
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
