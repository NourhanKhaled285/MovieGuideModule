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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6();
            f.Show();

        }

        private void button1_Click(object sender, EventArgs e)


        {
            //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VOK8FTS3;Initial Catalog=MOVIE GUIDE MODULE 1;Integrated Security=True");
            //con.Open();
            //if (radioButton1.Checked)
            //{
            //    string r = "insert into Username(comment) values(@comment)";
            //    SqlParameter comment = new SqlParameter("@comment", textBox1.Text);
            //    SqlCommand cmd = new SqlCommand(r, con);
            //    cmd.Parameters.Add(comment);
            //    cmd.ExecuteNonQuery();
            //}
            //else if (radioButton2.Checked)
            //{
            //    string r = "insert into admin(comment) values(@comment)";
            //    SqlParameter comment = new SqlParameter("@rate", textBox1.Text);
            //    SqlCommand cmd = new SqlCommand(r, con);
            //    cmd.Parameters.Add(comment);
              
            //    cmd.ExecuteNonQuery();
            //}

            //con.Close();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VOK8FTS3;Initial Catalog=MOVIE GUIDE MODULE 1;Integrated Security=True");
            //con.Open();
            //if (radioButton1.Checked)
            //{
            //    string r = "insert into Username(rate) values(@rate)";
            //    SqlParameter rate = new SqlParameter("@rate", textBox2.Text);
            //    SqlCommand cmd = new SqlCommand(r, con);
            //    cmd.Parameters.Add(rate);
            //    cmd.ExecuteNonQuery();
            //}
            //else if (radioButton2.Checked)
            //{
            //    string r = "insert into admin(rate) values(@rate)";
            //    SqlParameter rate = new SqlParameter("@rate", textBox2.Text);
            //    SqlCommand cmd = new SqlCommand(r, con);
            //    cmd.Parameters.Add(rate);
            //    cmd.ExecuteNonQuery();
            //}
            //con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VOK8FTS3;Initial Catalog=MOVIE GUIDE MODULE 1;Integrated Security=True");

             con.Open();


             if (radioButton1.Checked)
             {
                 string r = "insert into Username(comment) values(@comment)";
                 SqlParameter comment = new SqlParameter("@comment", textBox1.Text);
                 SqlCommand cmd = new SqlCommand(r, con);
                 cmd.Parameters.Add(comment);
                 cmd.ExecuteNonQuery();
             }
             else if (radioButton2.Checked)
             {
                 string r = "insert into admin(comment) values(@comment)";
                 SqlParameter comment = new SqlParameter("@rate", textBox1.Text);
                 SqlCommand cmd = new SqlCommand(r, con);
                 cmd.Parameters.Add(comment);

                 cmd.ExecuteNonQuery();
             }




             if (radioButton1.Checked)
             {
                 string r = "insert into Username(rate) values(@rate)";
                 SqlParameter rate = new SqlParameter("@rate", textBox2.Text);
                 SqlCommand cmd = new SqlCommand(r, con);
                 cmd.Parameters.Add(rate);
                 cmd.ExecuteNonQuery();
             }
             else if (radioButton2.Checked)
             {
                 string r = "insert into admin(rate) values(@rate)";
                 SqlParameter rate = new SqlParameter("@rate", textBox2.Text);
                 SqlCommand cmd = new SqlCommand(r, con);
                 cmd.Parameters.Add(rate);
                 cmd.ExecuteNonQuery();
             }




            if (radioButton1.Checked)
            {
                string r = "insert into Username([movie name]) values(@movie_name)";
                SqlParameter rate = new SqlParameter("@movie_name", textBox2.Text);
                SqlCommand cmd = new SqlCommand(r, con);
                cmd.Parameters.Add(rate);
                cmd.ExecuteNonQuery();
            }
            else if (radioButton2.Checked)
            {
                string r = "insert into admin([movie name]) values(@movie_name)";
                SqlParameter rate = new SqlParameter("@movie_name", textBox2.Text);
                SqlCommand cmd = new SqlCommand(r, con);
                cmd.Parameters.Add(rate);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("successfully");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6();
            f.Show();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
