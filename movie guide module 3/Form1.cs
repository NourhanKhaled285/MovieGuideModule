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
    public partial class regestration : Form
    {
        public regestration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            this.Hide();
            Form2 f = new Form2();
            f.Show();
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
