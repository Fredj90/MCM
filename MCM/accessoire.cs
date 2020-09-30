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
    public partial class accessoire : Form
    {
        int x1; string y1,z1,c1;
        public accessoire( int x,string y,string z,string c)
        {
            InitializeComponent();
            this.x1 = x;
            this.y1 = y;
            this.z1 = z;
            c1 = c;
        }

        private void savemarque_Click(object sender, EventArgs e)
        {
            int i = conn.autoinc("accesoire", "ID_ACC");
            string ch1 = "insert into accesoire values('" + i + "','" + wording.Text + "')";
            conn.insertTable(ch1);
            Consumption a = new Consumption(x1,y1,z1,c1);
            a.Show();
            this.Hide();
            a.consVisible();
        }
    }
}
