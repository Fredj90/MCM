using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCM.Basecon;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MCM
{
    public partial class Users : Form
    {
        int Pw, a = -1, id,k;
        string idch;
        bool ch;
        public Users()
        {
            InitializeComponent();
            dataGridView1.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox5.Visible = true;
            save.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        private void Personal1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSetUsers.USERS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.uSERSTableAdapter1.Fill(this.hRRANettoyageDataSetUsers.USERS);
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSettous.USERS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.uSERSTableAdapter.Fill(this.hRRANettoyageDataSettous.USERS);
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSet.PERSONAL'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.pERSONALTableAdapter.Fill(this.hRRANettoyageDataSet.PERSONAL);

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            k = 1;
            dataGridView1.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            save.Visible = true;
            butmod.Visible = false;
            Ajouter.Visible = false;
            panel1.Visible = false;



            t1.Focus();
        }

        private void butmod_Click(object sender, EventArgs e)
        {
            if (a >= 0)
            {
                k = 2;
                panel1.Visible = false;
                dataGridView1.Visible = false;
                Ajouter.Visible = false;
                butmod.Visible = false;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                save.Visible = true;
            }
            else
            {
                MessageBox.Show(" select a User", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void save_Click(object sender, EventArgs e)
        {
            if ((k == 1 ))
            {
                test();
                if ((t1.Text != "") && (t2.Text != "") && (t3.Text != "")&&(t5.Text != "") && (Login.Text != "") && (pass.Text != "") && (type.Text != ""))
                {

                    int i = conn.autoinc("Users", "id_personal");
                string ch1 = "insert into Users values('" + i + "','" + t1.Text + "','" + t2.Text + "','" + t3.Text + "','" + t5.Text + "','" + type.Text + "','" + Login.Text + "','" + pass.Text + "')";
                conn.insertTable(ch1);


               Users a = new Users();
                a.Show();
                this.Hide();
             }
                else
                {
                    //pictureBox1.Image = MCM.Properties.
                }
            }
            else
            {
                string req = "update Users set FAMILY_NAME ='" + t2.Text + "', FIRST_NAMES= '" + t3.Text + "',MAT='" + t1.Text + "',EMAIL='" + t5.Text + "',TYPE_Per='" + type.Text + "',login_per='" + Login.Text + "',Pwd_per='" + pass.Text + "' where id_personal = '" + id + "'";
                conn.insertTable(req);

                Users a = new Users();
                a.Show();
                this.Hide();
            }
        }

        private void test()
        {
            if (t1.Text == "")
            {
                pictureBox1.Visible = true;

            }

            if (t2.Text == "")
            {
                pictureBox2.Visible = true;

            }

            if (t3.Text == "")
            {
                pictureBox3.Visible = true;

            }
            if (t5.Text == "")
            {
                pictureBox4.Visible = true;

            }
            if (Login.Text == "")
            {
                pictureBox5.Visible = true;

            }
            if (pass.Text == "")
            {
                pictureBox6.Visible = true;

            }
            if (type.Text == "")
            {
                pictureBox7.Visible = true;

            }
        }

        private void t2_TextChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void t3_TextChanged(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }

        private void t5_TextChanged(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = 0;


            string x = comboBox1.Text;

            string ch = "select * from users where " + x + " LIKE '" + textBox2.Text + "%' ";
            DataSet ds = conn.Select(ch);
            int i = ds.Tables[0].Rows.Count;

            for (int j = 0; j < i; j++)
            {
                dataGridView1.Rows.Add(ds.Tables[0].Rows[j][0].ToString(), ds.Tables[0].Rows[j][1].ToString(), ds.Tables[0].Rows[j][2].ToString(), ds.Tables[0].Rows[j][3].ToString(), ds.Tables[0].Rows[j][4].ToString(), ds.Tables[0].Rows[j][5].ToString(), ds.Tables[0].Rows[j][6].ToString(), ds.Tables[0].Rows[j][7].ToString(), ds.Tables[0].Rows[j][8].ToString());

            }

        

    } 
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex;
            if (a >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                idch = row.Cells["idpersonal1"].Value.ToString();
                id = int.Parse(idch);
                t1.Text = row.Cells["MAT1"].Value.ToString();
                t2.Text = row.Cells["FAMILYNAME1"].Value.ToString();
                t3.Text = row.Cells["FIRSTNAMES1"].Value.ToString();
                type.Text = row.Cells["typeper1"].Value.ToString();
                t5.Text = row.Cells["email1"].Value.ToString();
               Login.Text = row.Cells["loginper1"].Value.ToString();
                pass.Text = row.Cells["passper1"].Value.ToString();

            }
        }

        private void t1_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
