using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MCM.Basecon;
using System.Data.SqlClient;
namespace MCM
{
    public partial class Personnel0 : Form
    {
        int Pw;
       
        bool Hided;
       

        public Personnel0()
        {
            
            InitializeComponent();
            Pw = Spanel.Width;
            Hided = false;
      
            //    circularProgressBar1.Value += 20;
           // circularProgressBar2.Text = "70";
            chart();
        }
        // SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-BPVEE6B\SQLEXPRESS;Initial Catalog=HRRANettoyage;Integrated Security=True");







       




        private void button1_Click(object sender, EventArgs e)
        {
            if (Hided) button1.Text = "M\nE\nN\nU";
            else button1.Text = "S\nH\nO\nW";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hided)
            {
                Spanel.Width = Spanel.Width + 20;
                if (Pw <= Spanel.Width)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                }

            }
            else
            {
                Spanel.Width = Spanel.Width -20;
                if (Spanel.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Personal1 a = new Personal1();
            a.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Machine m = new Machine();
            m.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Consumption x = new Consumption();
            x.Show();
            
        }

        private void Personnel_Load(object sender, EventArgs e)
        {

        }
        public void chart()
        {

            chart1.Series["Works"].Points.AddXY("Jan", 10);
            chart1.Series["Works"].Points.AddXY("Fev", 60);
            chart1.Series["Works"].Points.AddXY("Mar", 90);
            chart1.Series["Works"].Points.AddXY("Apr", 50);
            chart1.Series["Works"].Points.AddXY("May", 41);
            chart1.Series["Works"].Points.AddXY("JUi", 10);
            chart1.Series["Works"].Points.AddXY("Jul", 15);
            chart1.Series["Works"].Points.AddXY("Aug", 75);
            chart1.Series["Works"].Points.AddXY("Sep", 85);
            chart1.Series["Works"].Points.AddXY("Oct", 53);
            chart1.Series["Works"].Points.AddXY("Nov", 45);
            chart1.Series["Works"].Points.AddXY("Dec", 66);
        

        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Transfer a = new Transfer();
            a.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            importing a=new importing();
            a.Show();
        }

        private void circularProgressBar12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

       

       

       
    
}