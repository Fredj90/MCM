using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCM
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.UseSystemPasswordChar = true;
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            textBox3.Select();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Personnel0 a = new Personnel0();
            a.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Personnel0 a = new Personnel0();
            a.Show();
            this.Hide();

        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
