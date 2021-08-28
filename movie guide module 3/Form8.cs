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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VOK8FTS3;Initial Catalog=MOVIE GUIDE MODULE 1;Integrated Security=True");
            con.Open();

            //SqlCommand cmd = new SqlCommand("select title,ID from movie where director =@dir_name", con);
            SqlCommand cmd = new SqlCommand("select * from movie where director=@actor", con);
            SqlParameter actor = new SqlParameter("@actor", textBox1.Text);
            cmd.Parameters.Add(actor);
            SqlDataReader read = cmd.ExecuteReader();


            DataTable dt = new DataTable();
            dt.Load(read);
            dataGridView1.DataSource = dt;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VOK8FTS3;Initial Catalog=MOVIE GUIDE MODULE 1;Integrated Security=True");
            con.Open();

            //SqlCommand cmd = new SqlCommand("select title,ID from movie where director =@dir_name", con);
            SqlCommand cmd = new SqlCommand("select * from movie where director=@dir_name", con);
            SqlParameter director = new SqlParameter("@dir_name", textBox1.Text);
            cmd.Parameters.Add(director);
            SqlDataReader read = cmd.ExecuteReader();


            DataTable dt = new DataTable();
            dt.Load(read);
            dataGridView1.DataSource = dt;







            read.Close();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VOK8FTS3;Initial Catalog=MOVIE GUIDE MODULE 1;Integrated Security=True");
            con.Open();

            //SqlCommand cmd = new SqlCommand("select title,ID from movie where director =@dir_name", con);
            SqlCommand cmd = new SqlCommand("select * from movie where genre=@genre", con);
            SqlParameter category = new SqlParameter("@genre", textBox1.Text);
            cmd.Parameters.Add(category);
            SqlDataReader read = cmd.ExecuteReader();


            DataTable dt = new DataTable();
            dt.Load(read);
            dataGridView1.DataSource = dt;







            read.Close();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VOK8FTS3;Initial Catalog=MOVIE GUIDE MODULE 1;Integrated Security=True");
            con.Open();

            //SqlCommand cmd = new SqlCommand("select title,ID from movie where director =@dir_name", con);
            SqlCommand cmd = new SqlCommand("select * from movie where title=@title", con);
            SqlParameter title = new SqlParameter("@title", textBox1.Text);
            cmd.Parameters.Add(title);
            SqlDataReader read = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
            dataGridView1.DataSource = dt;


          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

