using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Database
    {
        protected SqlConnection con;

        public Database()
        {
            // Initialize the SqlConnection here or pass the connection string as a parameter to the constructor.
            // For simplicity, I'm initializing it within the constructor.
            con = new SqlConnection("Data Source=DESKTOP-AIG1MD4\\SQLEXPRESS;Initial Catalog=Hotel;Integrated Security=True");
        }

        public void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        public void ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            try
            {
                OpenConnection();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}