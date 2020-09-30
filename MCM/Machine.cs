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
    public partial class Machine : Form
    {
        int a = -1, id,x;
        string idch;
        
        public Machine()
        {
            InitializeComponent();
            panel1.Visible = true;
            groupBox6.Visible = true;
            groupBox3.Visible = false;
            listemachine();
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

        private void Machine_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSetMarque.MARQUE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.mARQUETableAdapter.Fill(this.hRRANettoyageDataSetMarque.MARQUE);
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSetMachine.MACHINE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.mACHINETableAdapter.Fill(this.hRRANettoyageDataSetMachine.MACHINE);

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            x = 1;
            savemachine.Visible = true;
            groupBox3.Visible = true;
            ADD.Visible = false;
            button4.Visible = false;
            button3.Visible = true;
            panel1.Visible = false;
        }
        private void test()
        {
            if (textBox1.Text == "")
            {
                pictureBox3.Visible = true;

            }

            if (textBox3.Text == "")
            {
                pictureBox1.Visible = true;

            }

          
        }
        private void savemachine_Click(object sender, EventArgs e)
        {
           
            int j = comboBox2.SelectedIndex + 1;
            test();
            if ((textBox3.Text != "") && (textBox1.Text != ""))
            {
                if (x == 1)
                {
                    int i = conn.autoinc("machine", "id_machine");
                    string ch1 = "insert into machine values('" + i + "','" + j + "','" + textBox3.Text + "','" + dateTimemachine.Value.ToString("dd/MM/yyyy") + "','" + textBox1.Text + "')";
                    conn.insertTable(ch1);

                    Machine0 a = new Machine0();
                    a.Show();
                    this.Hide();
                }
                else
                {
                    string req = "update machine set Registration_num ='" + textBox3.Text + "', LIBELLE= '" + textBox1.Text + "',ID_MARQUE='" + j + "' where id_machine = '" + id + "'";
                    conn.insertTable(req);
                    Machine a = new Machine();
                    a.Show();
                    this.Hide();
                }
            }
        }
        public void machineVisible()
        {
            groupBox3.Visible = true;
            groupBox6.Visible = false;
            panel1.Visible = false;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (a >= 0)
            {

               panel1.Visible = false;

              button4.Visible = false;
                groupBox3.Visible = true;
                ADD.Visible = false;
                savemachine.Visible = true;
            }
            else
            {
                MessageBox.Show(" select a Machine", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Marque a = new Marque();

            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (a >= 0)
            {
                Consumption a = new Consumption(id, comboBox2.Text, textBox1.Text, textBox3.Text);
                a.Show();



            }
            else
            {
                MessageBox.Show(" select a Machine", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Machine a = new Machine();
            a.Show();
            this.Hide();
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mACHINETableAdapter.FillBy1(this.hRRANettoyageDataSetMachine.MACHINE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex;
            if (a >= 0)
            {
                DataGridViewRow row = this.dataGridViewmachine.Rows[e.RowIndex];
             idch = row.Cells["id_machine"].Value.ToString();
               id = int.Parse(idch);

                comboBox2.Text = row.Cells["marque"].Value.ToString();
                textBox1.Text = row.Cells["wording"].Value.ToString();
                textBox3.Text = row.Cells["registration_num"].Value.ToString();
                dateTimemachine.Text = row.Cells["date_Of_Manufacture"].Value.ToString();

            }
        }
    }
}
