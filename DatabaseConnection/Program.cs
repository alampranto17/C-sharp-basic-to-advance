using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using global::System.Collections.Generic;
using global::System.Drawing;
using global::System.IO;
using global::System.Linq;
using global::System.Net.Http;
using global::System.Threading;
using global::System.Threading.Tasks;
using global::System.Windows.Forms;

namespace DatabaseConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HG04DSD\\SQLEXPRESS;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=777777;Encrypt=False;");

            SqlCommand cmd = new SqlCommand("Select * from info;", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                {
                    Console.Write(ds.Tables[0].Columns[j].ColumnName +" : "+ ds.Tables[0].Rows[i][j] + " ");
                     
                }
                Console.WriteLine(); 
            }*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new Form1());






        }
    }
}
