using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kursa4
{
    public partial class Registration : Form
    {
        ConnectDB connect = new ConnectDB();
        SqlCommand command;

        private string userLogin;
        private string userPass;
        private string userEmail;
        private string userSex;

        private DateTime userBithday;


        public Registration()
        {
            InitializeComponent();
        }

        private void SingUp_Click(object sender, EventArgs e)
        {
            Authorization form = new Authorization();
            form.Show();

            this.Hide();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            userLogin = textBoxLogin.Text;
            userPass = textBoxPass.Text;
            userEmail = maskedTextBoxMail.Text;
            userBithday = dateBithday.Value;
            userSex = comboBoxSex.Text;

            connect.openConnection();

            if (!string.IsNullOrWhiteSpace(userPass) && !string.IsNullOrWhiteSpace(userLogin) 
                && !string.IsNullOrWhiteSpace(userEmail) && !string.IsNullOrWhiteSpace(userSex))
            {
                if (CheckUnick(userLogin))
                {
                    SetDataRegistr(userLogin, userPass, userEmail, userBithday);
                    object id = GetUserID();
                    SetDataProfile(id);
                }
                else { MessageBox.Show("Логин уже занят"); }
            }
            else { MessageBox.Show("Введите данные"); }

            connect.closeConnection();
        }

        private void SetDataRegistr(string userLogin, string userPass, string userEmail, DateTime userBithday)
        {
            command = new SqlCommand(
                "INSERT INTO registr (login, password, dateReg, [e-mail]) " +
                "VALUES (@login, @pass, @date, @mail);", connect.Connection());
            command.Parameters.Add("@login", SqlDbType.VarChar).Value = userLogin;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = userPass;
            command.Parameters.Add("@date", SqlDbType.VarChar).Value = userBithday.ToShortDateString();
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = userEmail;

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Успешная регестрация");
        }

        private void SetDataProfile(object id)
        {
             command = new SqlCommand(
                "INSERT INTO profile (id_User, chrName, crLvl, maxHp, nowHp, maxMp, nowMp, sex, exp, pvpKills) " +
                "VALUES (@id, @login, 1, 1000, 1000, 500, 500, @sex, 0, 0)", connect.Connection());
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            command.Parameters.Add("@login", SqlDbType.VarChar).Value = userLogin;
            command.Parameters.Add("@sex", SqlDbType.VarChar).Value = userSex;

            command.ExecuteNonQuery();
        }

        private bool CheckUnick(string login)
        {
            command = new SqlCommand("SELECT login FROM registr WHERE login = @login", connect.Connection());
            command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                return false;
            }
            reader.Close();
            return true;
        }

        private object GetUserID()
        {
            object id;
            string login = textBoxLogin.Text;

            command = new SqlCommand(
                "SELECT id_User FROM registr WHERE login = @login", connect.Connection());
            command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            id = reader["id_User"];

            reader.Close();
            return id;
        }
    }
}
