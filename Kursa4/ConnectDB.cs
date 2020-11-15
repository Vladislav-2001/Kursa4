using System.Data.SqlClient;

namespace Kursa4
{
    class ConnectDB
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UHQOC44;Initial Catalog=gamedata;Integrated Security=True");
        public void openConnection()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public SqlConnection Connection()
        {
            return conn;
        }
    }
}
