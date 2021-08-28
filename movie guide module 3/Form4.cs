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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VOK8FTS3;Initial Catalog=MOVIE GUIDE MODULE 1;Integrated Security=True") ;
            con.Open();
            
            SqlCommand cmd = new SqlCommand("select * from Username where Name = @Username and Pass=@Pass",con);
            SqlParameter name = new SqlParameter("@Username", textBox1.Text);
            cmd.Parameters.Add(name);
            SqlParameter pass = new SqlParameter("@Pass", textBox2.Text);
            cmd.Parameters.Add(pass);



            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                

                string Name = (string)rdr["Name"];
                string Pass = (string)rdr["Pass"];
                
                if (Name == textBox1.Text && Pass==textBox2.Text)
                {
                    this.Hide();
                    Form8 f = new Form8();
                    f.Show();

                    

                }
                else
                {
                    MessageBox.Show("failed");
                }

            }
                  
           
            


           
           rdr.Close();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
