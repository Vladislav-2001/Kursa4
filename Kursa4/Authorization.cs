using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kursa4
{

    public partial class Authorization : Form
    {
        private static string userId;
        
        public Authorization()
        {
            InitializeComponent(); 
        }

        private void singUp_Click(object sender, EventArgs e)
        {
            string userLogin = textBoxLogin.Text;
            string userPass = textBoxPass.Text;


            ConnectDB connect = new ConnectDB();
            connect.openConnection();

            SqlCommand command = new SqlCommand(
                "SELECT * FROM registr WHERE login = @userLogin AND password = @userPass", connect.Connection());
            command.Parameters.Add("@userLogin", SqlDbType.VarChar).Value = userLogin;
            command.Parameters.Add("@userPass", SqlDbType.VarChar).Value = userPass;

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                userId = reader[0].ToString();
                reader.Close();

                ProFile proFile = new ProFile();
                proFile.Show();
                
                this.Close();
            }    
            else
                MessageBox.Show("Неверный логин или пароль");

            connect.closeConnection();
            
        }

        public static string GetUserId() 
        { 
            return userId; 
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();

            this.Hide();
        }
    }
}
