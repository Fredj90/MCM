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

namespace MCM
{
    public partial class Machine0 : Form
    {
        int a = -1 , id;
        string idch;
        public Machine0()
        {
            InitializeComponent();
            dataGridViewmachine.Visible = true;
            groupBox6.Visible = true;
                 groupBox3.Visible = false;
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            Marque a = new Marque();
            
            a.Show();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            
            savemachine.Visible = true;
            groupBox3.Visible = true;
            groupBox6.Visible = false;
            button3.Visible = true;
            dataGridViewmachine.Visible = false;

        }
        public void machineVisible()
        {
            groupBox3.Visible = true;
            groupBox6.Visible = false;
            dataGridViewmachine.Visible = false;

        }
        private void savemachine_Click(object sender, EventArgs e)
        {
            int i = conn.autoinc("machine", "id_machine");
            int j = comboBox2.SelectedIndex + 1;
            if ( textBox3.Text=="")
            { 
            string ch1 = "insert into machine values('" + i + "','" + j + "','" + textBox3.Text + "','" + dateTimemachine.Value.ToString("dd/MM/yyyy") + "','" + textBox1.Text + "')";
            conn.insertTable(ch1);

            Machine0 a = new Machine0();
            a.Show();
            this.Hide();
} else
            {
                string req = "update machine set Registration_num ='" + textBox3.Text + "', LIBELLE= '" + textBox1.Text + "',ID_MARQUE='" + j +  "' where id_machine = '" + id + "'";
                conn.insertTable(req);
                Machine0 a = new Machine0();
                a.Show();
                this.Hide();
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mARQUETableAdapter.FillBy(this.hRRANettoyageDataSetMarque.MARQUE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Machine0 a = new Machine0();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (a >= 0)
            {
                
                dataGridViewmachine.Visible = false;
              
                groupBox3.Visible = true;
              
                savemachine.Visible = true;
            }
            else
            {
                MessageBox.Show(" select a Machine", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewmachine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex;
            if (a >= 0)
            {
                DataGridViewRow row = this.dataGridViewmachine .Rows[e.RowIndex];
                idch = row.Cells["idmachine"].Value.ToString();
               id = int.Parse(idch);
              
                comboBox2.Text = row.Cells["marque"].Value.ToString();
                textBox1.Text = row.Cells["libelle"].Value.ToString();
                textBox3.Text = row.Cells["registrationnum"].Value.ToString();
                dateTimemachine.Text = row.Cells["dateOfManufacture"].Value.ToString();
            
            }
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Machine_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSetMarque1.MARQUE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.mARQUETableAdapter1.Fill(this.hRRANettoyageDataSetMarque1.MARQUE);
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSetMachine.MACHINE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.mACHINETableAdapter.Fill(this.hRRANettoyageDataSetMachine.MACHINE);

        }
    }
}
