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

namespace MCM
{
    public partial class Consumption : Form
    {
        int a = -1, id,id1,x,k ;
        string idch ,idacc,aa,bb,cc;
        public Consumption()
        {
            InitializeComponent();
            listemachine();
            listeConsumption2();
            groupBox4.Visible = false;
            panel1.Visible = true;
            button3.Visible = false;
        }
        public Consumption(int x)
        {
            InitializeComponent();
            this.k = x;
            listeConsumption2();
            groupBox4.Visible = false;
            panel1.Visible = true;
            button3.Visible = false;
        }
        public Consumption(int k1,string a,string b,string c )
        {
            InitializeComponent();
            groupBox4.Visible = true;
            panel1.Visible = false;
            ADD.Visible = false;
            button4.Visible = false;
            button3.Visible = true;
            
            x = 1;
            m1.Text = c;
            this.k = k1;
            this.aa = a;
            this.bb = b;
             cc = c;
            //listeConsumption2();
        }
        private void listeConsumption()
        {
            string q = "SELECT *  FROM dbo.conssomer co,dbo.MACHINE m,dbo.accesoire ac , dbo.marque ma where co.id_acc=ac.id_acc and co.id_machine=m.id_machine and m.id_marque=ma.id_marque ";
            DataSet ds = conn.Select(q);
            int i = ds.Tables[0].Rows.Count;

            for (int j = 0; j < i; j++)
            {
                dataGridView1.Rows.Add(ds.Tables[0].Rows[j][5].ToString(), ds.Tables[0].Rows[j][7].ToString(), ds.Tables[0].Rows[j][11].ToString(), ds.Tables[0].Rows[j][9].ToString(), ds.Tables[0].Rows[j][2].ToString(), ds.Tables[0].Rows[j][1].ToString(), ds.Tables[0].Rows[j][0].ToString());

            }
        }
        private void listeConsumption2()
        {

            string q = "SELECT *  FROM dbo.conssomer co,dbo.MACHINE m,dbo.accesoire ac , dbo.marque ma where co.id_acc=ac.id_acc and co.id_machine=m.id_machine and m.id_marque=ma.id_marque  ";
                //co,dbo.MACHINE m,dbo.accesoire ac , dbo.marque ma where co.id_acc=ac.id_acc and co.id_machine=m.id_machine and m.id_marque=ma.id_marque and m.id_machine="+k +"";
            DataSet ds = conn.Select(q);
            int i = ds.Tables[0].Rows.Count;

            for (int j = 0; j < i; j++)
            {
                dataGridView1.Rows.Add(ds.Tables[0].Rows[j][5].ToString(), ds.Tables[0].Rows[j][7].ToString(), ds.Tables[0].Rows[j][11].ToString(), ds.Tables[0].Rows[j][9].ToString(), ds.Tables[0].Rows[j][2].ToString(), ds.Tables[0].Rows[j][1].ToString(), ds.Tables[0].Rows[j][0].ToString());

            }
        }

        private void Consumption_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSetAccesoire.ACCESOIRE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.aCCESOIRETableAdapter.Fill(this.hRRANettoyageDataSetAccesoire.ACCESOIRE);
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSetMachine.MACHINE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.mACHINETableAdapter.Fill(this.hRRANettoyageDataSetMachine.MACHINE);

        }

        private void m1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            accessoire c = new accessoire(k, aa, bb, cc);
            c.Show();
        }

        private void dataGridViewmachine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex;
            if (a >= 0)
            {
                DataGridViewRow row = this.dataGridViewmachine.Rows[e.RowIndex];
                idch = row.Cells["id_machine1"].Value.ToString();
                id = int.Parse(idch);

           
                textBox2.Text = row.Cells["wording1"].Value.ToString();
                textBox1.Text = row.Cells["registration_num"].Value.ToString();
               
            }
        }

        private void listemachine()
        {
            string q = "SELECT *  FROM dbo.MACHINE m,dbo.MARQUE m1 where m.id_marque=m1.id_marque";
            DataSet ds = conn.Select(q);
            int i = ds.Tables[0].Rows.Count;

            for (int j = 0; j < i; j++)
            {
                dataGridViewmachine.Rows.Add(ds.Tables[0].Rows[j][2].ToString(), ds.Tables[0].Rows[j][3].ToString(), ds.Tables[0].Rows[j][4].ToString(), ds.Tables[0].Rows[j][6].ToString(), ds.Tables[0].Rows[j][0].ToString(), ds.Tables[0].Rows[j][1].ToString());

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            dataGridViewmachine.DataSource = 0;
            dataGridViewmachine.DataSource = null;


            //string ch = "select * from machine where " + x + " LIKE '" + textBox3.Text + "%' ";
            string q = "SELECT *  FROM dbo.MACHINE m,dbo.MARQUE m1 where m.id_marque=m1.id_marque and m.LIBELLE  LIKE '" + textBox3.Text + "%'  ";
            DataSet ds = conn.Select(q);
            int i = ds.Tables[0].Rows.Count;

            for (int j = 0; j < i; j++)
            {
                dataGridViewmachine.Rows.Add(ds.Tables[0].Rows[j][2].ToString(), ds.Tables[0].Rows[j][3].ToString(), ds.Tables[0].Rows[j][4].ToString(), ds.Tables[0].Rows[j][6].ToString(), ds.Tables[0].Rows[j][0].ToString(), ds.Tables[0].Rows[j][1].ToString());

            }
        }

        public void consVisible()
        {
            groupBox4.Visible = true;
            panel1.Visible = false;
            ADD.Visible = false;
            button4.Visible = false;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            accessoire c = new accessoire(k,aa,bb,cc );
                c.Show();
        }
        private void test()
        {
            if (textBox1.Text == "")
            {
                pictureBox1.Visible = true;

            }

            if (textBox2.Text == "")
            {
                pictureBox2.Visible = true;

            } }
        private void savemarque_Click(object sender, EventArgs e)
        {
            int j = comboBox2.SelectedIndex + 1;

            if (x == 1)

            {

                test();
                if ((textBox1.Text != "") && (textBox2.Text != ""))
                {



                    string ch1 = "insert into conssomer values('" + j + "','" + k + "','" + dateTimeuse.Value.ToString("dd/MM/yyyy") + "')";
                    conn.insertTable(ch1);

                    Consumption a = new Consumption(k);
                    a.Show();
                    this.Hide();

                }
                else
                {
                    string req = "update conssomer set date_use ='" + dateTimeuse.Value.ToString("dd/MM/yyyy") + "', id_acc= '" + j + "' where id_machine = '" + id + "'";
                    conn.insertTable(req);
                    Consumption a = new Consumption();
                    a.Show();
                    this.Hide(); ;
                }


            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            panel1.Visible = false;
            ADD.Visible = false;
            button4.Visible = false;
            button3.Visible = true;
            x = 1;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consumption c = new Consumption();
            c.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex;
            if (a >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                idch = row.Cells["id_machine"].Value.ToString();
                idacc = row.Cells["id_acc"].Value.ToString();
                id = int.Parse(idch);
                id1 = int.Parse(idacc);

                comboBox2.Text = row.Cells["use"].Value.ToString();

               textBox1.Text = row.Cells["registrationnum"].Value.ToString();
                textBox2.Text = row.Cells["wording"].Value.ToString();

                dateTimeuse.Text = row.Cells["date_use"].Value.ToString();

            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            x = 0;
            if (a >= 0)
            {
                groupBox4.Visible = true;
                panel1.Visible = false;
                ADD.Visible = false;
                button4.Visible = false;
                button3.Visible = true;
            }
            else
            {
                MessageBox.Show("Please, Select a Machine ", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
