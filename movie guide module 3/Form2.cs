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
    public partial class Form2 : Form
    {
        int i = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VOK8FTS3;Initial Catalog=MOVIE GUIDE MODULE 1;Integrated Security=True");
            con.Open();
            if (radioButton1.Checked)
            {
                string insertuser = "insert into Username(Name, Pass,gender,ID) values(@Name, @Pass,@gender,@id)";
                SqlCommand cmd = new SqlCommand(insertuser, con);
                SqlParameter name = new SqlParameter("@name", textBox1.Text);
                cmd.Parameters.Add(name);
                SqlParameter pass = new SqlParameter("@Pass", textBox2.Text);
                cmd.Parameters.Add(pass);
                SqlParameter gender = new SqlParameter("@gender", textBox3.Text);
                cmd.Parameters.Add(gender);
                SqlParameter id = new SqlParameter("@id", textBox4.Text);
                cmd.Parameters.Add(id);
                cmd.ExecuteNonQuery();
            }
            else if (radioButton2.Checked) {
                string insertadmin = "insert into admin(Name, Pass,gender,ID) values(@Name, @Pass,@gender,@id)";
                SqlCommand cmd = new SqlCommand(insertadmin, con);

                SqlParameter adname = new SqlParameter("@name", textBox1.Text);
                cmd.Parameters.Add(adname);
                SqlParameter adpass = new SqlParameter("@Pass", textBox2.Text);
                cmd.Parameters.Add(adpass);
                SqlParameter adgender = new SqlParameter("@gender", textBox3.Text);
                cmd.Parameters.Add(adgender);
                SqlParameter adid = new SqlParameter("@id", textBox4.Text);
                cmd.Parameters.Add(adid);
                cmd.ExecuteNonQuery();
            }
            
            con.Close();
            
            //this.Hide();
            //Form3 f = new Form3();
            //f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {



        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            regestration f = new regestration();
            f.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            regestration f = new regestration();
            f.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

         
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }


       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            //if (i % 2 == 0)
            //{
            //    textBox1.Text = "";
            //}
            //else
            //{
            //    textBox1.Text = "User Name";

            //}
            //i++;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            
        }

     

       
    }
}
