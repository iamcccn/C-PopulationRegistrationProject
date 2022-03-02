using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PopulationCountry.so
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          Application.Run(new Form1());

        }
    }
    public class MyConnection
    {
        public SqlConnection Con = new SqlConnection ("Data Source=DESKTOP-EECPGAI;Initial Catalog=Citizens;Integrated Security=True");     
        public SqlCommand cmd;
        public SqlDataReader dr;
        public String quy;
        
    }
}
