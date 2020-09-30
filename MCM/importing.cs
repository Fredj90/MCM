using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCM
{
    public partial class importing : Form
    {
        public importing()
        {
            InitializeComponent();
            groupBox9.Visible = false;
            circularProgressBar3.Visible = false;
          
         
        }

        private void importing_Load(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           groupBox9.Visible = true;
            Thread t = new Thread(new ThreadStart(vide));
            t.Start();
          
            Thread.Sleep(5000);
            t.Abort();
            groupBox9.Visible  = false;
            circularProgressBar3.Visible = true;

            var Lignes = System.IO.File.ReadAllLines(textBox1.Text);

            t1.Text = Lignes[1];
            t2.Text = Lignes[2];
            t3.Text = Lignes[3];
           
            t4.Text = Lignes[4];
            t5.Text = Lignes[19];
            t6.Text = Lignes[21];
            t7.Text = Lignes[23];
            t8.Text = Lignes[27];
            t9.Text = Lignes[30];
            t10.Text = Lignes[33];
            t11.Text = Lignes[37];
            t12.Text = Lignes[40];
            t13.Text= Lignes[43];
            t14.Text = Lignes[46];
            t15.Text = Lignes[48];
            t16.Text = Lignes[50];
            t17.Text = Lignes[59];
            t18.Text = Lignes[62];

            t19.Text = Lignes[65];
            t20.Text = Lignes[70];
            t21.Text = Lignes[72];
            t22.Text = Lignes[74];
            t23.Text = Lignes[80];

            t24.Text = Lignes[84];
            t25.Text = Lignes[85];
            // Console.WriteLine(Lignes[i]); // Ecrit une des questions dans la console



        }
       
        private void vide()
        {

           wait a = new wait();

            a.Show();  
            
        }
        private void Wait()
        {

            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(20);
             
            }


        }
        private void Wait2()
        {
            
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(20);
                circularProgressBar3.Value = i;
                circularProgressBar3.Update();
            }
        }

        private void circularProgressBar3_Click(object sender, EventArgs e)
        {

        }

        private void city_TextChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
            groupBox9.Visible = true;
        }

        private void t5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
