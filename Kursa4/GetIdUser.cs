
using System.Data.SqlClient;
using System.Data;

namespace Kursa4
{
    class GetIdUser
    {
        ConnectDB connect = new ConnectDB();
        private object userId;
        public void SetIdUser(string login)
        {
            SqlCommand command = new SqlCommand("SELECT id_User FROM registr WHERE login = @login", connect.Connection());
            command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;

            connect.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            userId = reader[0].ToString();
            reader.Close();

            connect.closeConnection();
        }

        public object GetId()
        {
            return userId;
        }
    }
}
