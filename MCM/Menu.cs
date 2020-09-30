using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCM
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'nettoyageDataSet.USERS'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
           // this.uSERSTableAdapter.Fill(this.nettoyageDataSet.USERS);

        }
    }
}
