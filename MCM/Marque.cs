using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MCM.Basecon;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCM
{
    public partial class Marque : Form
    {
        public Marque()
        {
            InitializeComponent();
        }

        private void savemarque_Click(object sender, EventArgs e)
        {
            int i = conn.autoinc("marque", "ID_MARQUE");
            string ch1 = "insert into marque values('" + i + "','" + wording.Text + "')";
            conn.insertTable(ch1);
            Machine a = new Machine();
            a.Show();
            this.Hide();
            a.machineVisible();

            
        }
    }
}
