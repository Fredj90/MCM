using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCM
{
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
            pictureBox3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text= openFileDialog1.FileName;
            

        }

        private void savemachine_Click(object sender, EventArgs e)
        {if (textBox1.Text=="")
            {
                pictureBox3.Visible = true;
               
               
                MessageBox.Show("Choose a file that you will convert: {0}.", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                File.Move(textBox1.Text, Path.ChangeExtension(textBox1.Text, ".txt"));
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            var Lignes = System.IO.File.ReadAllLines(textBox1.Text);
            for (int i = 2; i < Lignes.Length - 1; i++) // De la ligne 3 a la dernière
            {
                textBox1.Text = Lignes[i];
               // Console.WriteLine(Lignes[i]); // Ecrit une des questions dans la console
            }
            /*Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader(textBox1.Text);
            while ((line = file.ReadLine()) != null)
            {
                textBox1.Text=line;
                counter++;
            }

            file.Close();

            // Suspend the screen.
            Console.ReadLine();*/
        }
    }
}
