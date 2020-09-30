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
    public partial class Personnel : Form
    {
        int Pw, a = -1, id;
        string idch;
        bool Hided;
        public NettoyageDataSet ds = new NettoyageDataSet();
        public NettoyageDataSetTableAdapters.PERSONALTableAdapter tap = new NettoyageDataSetTableAdapters.PERSONALTableAdapter();
        public BindingSource bsp = new BindingSource();
        public DataTable dtp = new DataTable();
      

        public Personnel()
        {
            
            InitializeComponent();
            Pw = Spanel.Width;
            Hided = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            save.Visible = false;
            Machine.Visible = true;
        }
        // SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-BPVEE6B\SQLEXPRESS;Initial Catalog=HRRANettoyage;Integrated Security=True");







        private void Ajouter_Click_1(object sender, EventArgs e)
        {
           


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }



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
                Spanel.Width = Spanel.Width - 20;
                if (Spanel.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {

                int i = conn.autoinc("personal", "id_personal");
                string ch1 = "insert into personal values('" + i + "','" + t1.Text + "','" + t2.Text + "','" + t3.Text + "','" + t4.Value.ToString("dd/MM/yyyy") + "','" + t5.Text + "','" + type.Text + "','" + country.Text + "','" + zip.Text + "','" + city.Text + "')";
                conn.insertTable(ch1);

                MessageBox.Show("ok");
                Personnel a = new Personnel();
                a.Show();
                this.Hide();
            }
            else
            {
                string req = "update personal set FAMILY_NAME ='" + t2.Text + "', FIRST_NAMES= '" + t3.Text + "',MAT='" + t1.Text + "',DATE_OF_BIRTH='" + t4.Value.ToString("dd/MM/yyyy") + "',EMAIL='" + t5.Text + "',TYPE_Per='" + type.Text + "',COUNTRY='" + country.Text + "',CITY='" + city.Text + "',ZIP='" + zip.Text + "' where id_personal = '" + id + "'";
                conn.insertTable(req);
                MessageBox.Show("ok");
                Personnel a = new Personnel();
                a.Show();
                this.Hide();
            }
        }

        private void Personnel_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSetmachine1.MACHINE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.mACHINETableAdapter5.Fill(this.hRRANettoyageDataSetmachine1.MACHINE);
            // TODO: cette ligne de code charge les données dans la table 'hRRAmachine.MACHINE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.mACHINETableAdapter4.Fill(this.hRRAmachine.MACHINE);
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSetmachine.MACHINE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
          // this.mACHINETableAdapter3.Fill(this.hRRANettoyageDataSetmachine.MACHINE);
            // TODO: cette ligne de code charge les données dans la table 'nettoyageDataSet.MACHINE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
           // this.mACHINETableAdapter2.Fill(this.nettoyageDataSet.MACHINE);
            // TODO: cette ligne de code charge les données dans la table 'machine1.MACHINE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
           // this.mACHINETableAdapter1.Fill(this.machine1.MACHINE);
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSet20.MACHINE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
           // this.mACHINETableAdapter.Fill(this.hRRANettoyageDataSet20.MACHINE);
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSet41.MARQUE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.mARQUETableAdapter.Fill(this.hRRANettoyageDataSet41.MARQUE);
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSet2.MARQUE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
           // this.mARQUETableAdapter.Fill(this.hRRANettoyageDataSet2.MARQUE);
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSet3.PERSONAL'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.pERSONALTableAdapter5.Fill(this.hRRANettoyageDataSet3.PERSONAL);
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSet10.PERSONAL'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.pERSONALTableAdapter4.Fill(this.hRRANettoyageDataSet10.PERSONAL);
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSet2.PERSONAL'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.pERSONALTableAdapter3.Fill(this.hRRANettoyageDataSet2.PERSONAL);
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSet1.PERSONAL'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            // this.pERSONALTableAdapter2.Fill(this.hRRANettoyageDataSet1.PERSONAL);
            // TODO: cette ligne de code charge les données dans la table 'hRRANettoyageDataSet.PERSONAL'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //  this.pERSONALTableAdapter1.Fill(this.hRRANettoyageDataSet.PERSONAL);

        }

        private void butanul_Click(object sender, EventArgs e)
        {
            Personnel a = new Personnel();
            a.Show();
            this.Hide();

                
        }

        private void butmod_Click_1(object sender, EventArgs e)
        {
            if (a >= 0)
            {
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
                MessageBox.Show(" select a personal", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex;
            if (a >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                idch = row.Cells["id_personal"].Value.ToString();
                id = int.Parse(idch);
                t1.Text = row.Cells["MAT1"].Value.ToString();
                t2.Text = row.Cells["FAMILYNAME"].Value.ToString();
                t3.Text = row.Cells["FIRSTNAMES"].Value.ToString();
                t4.Text = row.Cells["dateofbirth"].Value.ToString();
                type.Text = row.Cells["typeper"].Value.ToString();
                country.Text = row.Cells["country1"].Value.ToString();
                t5.Text = row.Cells["email1"].Value.ToString();

                zip.Text = row.Cells["ZIP1"].Value.ToString();


            }


        }

        private void t1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
                t2.Focus();
        }

        private void t2_TextChanged(object sender, EventArgs e)
        {

        }

        private void t2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
                t3.Focus();
        }

        private void t3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
                t4.Focus();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex;
            if (a >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                idch = row.Cells["idpersonal"].Value.ToString();
                id = int.Parse(idch);
                t1.Text = row.Cells["MAT1"].Value.ToString();
                t2.Text = row.Cells["FAMILYNAME"].Value.ToString();
                t3.Text = row.Cells["FIRSTNAMES"].Value.ToString();
                t4.Text = row.Cells["dateofbirth"].Value.ToString();
                type.Text = row.Cells["typeper"].Value.ToString();
                country.Text = row.Cells["country1"].Value.ToString();
                t5.Text = row.Cells["email1"].Value.ToString();

                zip.Text = row.Cells["ZIP1"].Value.ToString();

            }




        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
                a= e.RowIndex;
                if (a >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    idch = row.Cells["idpersonal"].Value.ToString();
                    id = int.Parse(idch);
                    t1.Text = row.Cells["MAT1"].Value.ToString();
                    t2.Text = row.Cells["FAMILYNAME"].Value.ToString();
                    t3.Text = row.Cells["FIRSTNAMES"].Value.ToString();
                    t4.Text = row.Cells["dateofbirth"].Value.ToString();
                    type.Text = row.Cells["typeper"].Value.ToString();
                    country.Text = row.Cells["country1"].Value.ToString();
                    t5.Text = row.Cells["email1"].Value.ToString();

                    zip.Text = row.Cells["ZIP1"].Value.ToString();
                }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Spanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { panel1.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox5.Visible = true;
            save.Visible = false;
             dataGridView1.Visible = true;
             dataGridViewmachine.Visible = false;

            Machine.Visible = false;
        
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void butanul_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

          

           // MessageBox.Show("ok");
           
           

            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel3.Visible = false;
            Machine.Visible = true;
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false;
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            
            groupBox5.Visible = false;
            save.Visible = false;
             dataGridView1.Visible = false;
             dataGridViewmachine.Visible = true;
            Machine.Visible = true;
        }

        private void Machine_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            save.Visible = true;
            butmod.Visible = false;
            Ajouter.Visible = false;



            t1.Focus();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void visibleMachine()
        {
            groupBox3.Visible = true;
            groupBox5.Visible = false;
            save.Visible = false;
            savemachine.Visible = true;


            dataGridView1.Visible = false;
            dataGridViewmachine.Visible = false;
        }
        public void ADD_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox5.Visible = false;
            save.Visible = false;
            savemachine.Visible = true;


            dataGridView1.Visible = false;
            dataGridViewmachine.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Marque a = new Marque();
            a.Show();

            
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void savemachine_Click(object sender, EventArgs e)
        {
            int i = conn.autoinc("machine", "id_machine");
            int j = comboBox2.SelectedIndex +1;
            string ch1 = "insert into machine values('" + i + "','" +j +"','" + textBox1.Text +   "','" + dateTimemachine.Value.ToString("dd/MM/yyyy") + "')";
            conn.insertTable(ch1);

           
            Personnel a = new Personnel();
            a.Show();

            this.Hide();

            panel3.Visible = false;
            groupBox1.Visible = false;
            groupBox3.Visible = false;

            groupBox5.Visible = false;
            save.Visible = false;
            dataGridView1.Visible = false;
            dataGridViewmachine.Visible = true;
            Machine.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewmachine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

       
    }
}