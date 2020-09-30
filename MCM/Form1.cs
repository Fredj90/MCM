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


namespace MCM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-BPVEE6B\SQLEXPRESS;Initial Catalog=HRRANettoyage;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        { 
            DataSet ds = new DataSet();
            cnx.Open();
           String a = "select * from users";
          ds= Basecon.conn.Select(a);
        LOGIN b = new LOGIN();
          b.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
