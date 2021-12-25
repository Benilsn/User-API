using System;
using System.Data.SqlClient;

namespace User_API.database
{
    public class Database
    {

        private static SqlConnection con;

        public Database(string connectinString)
        {
            con = new SqlConnection(connectinString);
        }

        public SqlConnection GetConnection()
        {
            return con;
        }

        public void Connect()
        {
            try
            {
                con.Open();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Disconnect()
        {
            try
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
