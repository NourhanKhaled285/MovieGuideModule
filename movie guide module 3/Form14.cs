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
using System.IO;

namespace movie_guide_module_3
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* ID title actor rate poster year genre author director*/
            
           
            

            
            byte[] imageBt = null;
            FileStream fstream = new FileStream(this.textBox9.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);
            
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VOK8FTS3;Initial Catalog=MOVIE GUIDE MODULE 1;Integrated Security=True");
                con.Open();
                string insertmovie = "insert into movie(ID, title,actor,rate,poster,year,genre,author,director) values(@ID, @title,@actor,@rate,@poster,@year,@genre,@author,@director)";
                SqlCommand cmd = new SqlCommand(insertmovie, con);
                SqlParameter id = new SqlParameter("@ID", textBox1.Text);
                cmd.Parameters.Add(id);
                SqlParameter name = new SqlParameter("title", textBox2.Text);
                cmd.Parameters.Add(name);
                SqlParameter act = new SqlParameter("@actor", textBox3.Text);
                cmd.Parameters.Add(act);
                SqlParameter r = new SqlParameter("@rate", textBox4.Text);
                cmd.Parameters.Add(r);
                SqlParameter year = new SqlParameter("@year", textBox5.Text);
                cmd.Parameters.Add(year);
                SqlParameter type = new SqlParameter("genre", textBox6.Text);
                cmd.Parameters.Add(type);
                SqlParameter author = new SqlParameter("@author", textBox7.Text);
                cmd.Parameters.Add(author);
                SqlParameter dir = new SqlParameter("@director", textBox8.Text);
                cmd.Parameters.Add(dir);
                SqlParameter pic = new SqlParameter("@poster", imageBt);
                cmd.Parameters.Add(pic);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           


         
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (d.ShowDialog() == DialogResult.OK)
            {
                string picpath = d.FileName.ToString();
                textBox9.Text = picpath;
                pictureBox1.ImageLocation = picpath;

            

            }
            
            
           
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
        }
        
    }
}
