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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Form8 f = new Form8();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f = new Form9();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f = new Form10();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 f = new Form11();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 f = new Form13();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
