using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movie_guide_module_3
{
    public partial class Form7 : Form
    {
        public Form7()
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
            Form12 f = new Form12();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 f = new Form13();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 f = new Form14();
            f.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
