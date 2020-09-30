using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MCM.Basecon
{
    class conn
    {
        static SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-BPVEE6B\SQLEXPRESS;Initial Catalog=HRRANettoyage;Integrated Security=True");
        //SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-BPVEE6B\SQLEXPRESS;Initial Catalog=HRRANettoyage;Integrated Security=True");


        static SqlCommand commande;
        static SqlClientFactory ff;
        static SqlDataAdapter selection;
     
        
        public static void insertTable (string requete)
        {
            cnx.Open();
            commande = new SqlCommand( requete,cnx);
            commande.ExecuteNonQuery();
            cnx.Close();

        }
       
        public static DataSet Select(string requete)
        {
            DataSet res = new DataSet();
            selection = new SqlDataAdapter();
            selection.SelectCommand = new SqlCommand(requete, cnx);

            selection.Fill(res);
            return res;

        }
        public static int autoinc(string tab, string col)
        {
            int i = 0;
            string re = "select MAX(" + col + ") from " + tab + " ";
            DataSet ds = Select(re);
            string h = ds.Tables[0].Rows[0][0].ToString();
            if (h != "")
            {
                i = int.Parse(h);
            }
            i++;
            return i;

        }
          

    }
    
}
