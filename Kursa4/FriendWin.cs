using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kursa4
{
    public partial class FriendWin : Form
    {
        ConnectDB connect = new ConnectDB();
        SqlCommand command;
        SqlDataReader reader;

        private string id;

        public FriendWin()
        {
            InitializeComponent();
        }
        private void FriendWin_Load(object sender, EventArgs e)
        {
            string userName = ProFile.nameUser;

            FoundFiend(userName);
            
        }

        public void FoundFiend(string login)
        {
            command = new SqlCommand(
                "SELECT * FROM profile WHERE chrName = @login ", connect.Connection());
            command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;

            connect.openConnection();

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                labelName.Text = reader["chrName"].ToString();
                labelLvl.Text = $"Lvl {reader["crLvl"]}";
                labelHp.Text = $"{reader["nowHp"]}/{reader["maxHp"]}";
                labelMp.Text = $"{reader["nowMp"]}/{reader["maxMp"]}";
                labelSex.Text = $"{reader["sex"]}";
                labelExp.Text = $"{reader["exp"]}";
                labelPvpKills.Text = $"{reader["pvpKills"]}";

                id = reader["id_User"].ToString();
                reader.Close();
            }
            else
            {
                MessageBox.Show("Пользователь с таким именем не найден");
                this.Close();
            }

            connect.closeConnection();
        }

        private void buttonAddFriend_Click(object sender, EventArgs e)
        {
            string id_User = Authorization.GetUserId();
            string id_Friend = id;

            connect.openConnection();

            if (FriendOrNo(id))
            {
                command = new SqlCommand(
                    "INSERT INTO friends (id_User, id_Friend) VALUES (@id_User, @id_Friend)", connect.Connection());
                command.Parameters.Add("@id_User", SqlDbType.VarChar).Value = id_User;
                command.Parameters.Add("@id_Friend", SqlDbType.VarChar).Value = id_Friend;
                command.ExecuteNonQuery();

                MessageBox.Show("Пользователь добавлен в друзья");
            }
            else { MessageBox.Show("Пользователь уже у вас в друзьях"); }

            connect.closeConnection();
        }


        private void buttonDeleteFriend_Click(object sender, EventArgs e)
        {
            connect.openConnection();
            if (!FriendOrNo(id))
            {
                command = new SqlCommand("DELETE FROM friends WHERE id_Friend = @id", connect.Connection());
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                command.ExecuteNonQuery();

                MessageBox.Show("Пользователь удален из друзей");
            }
            else { MessageBox.Show("Пользователь не в друзьях"); }
            connect.closeConnection();
        }

        private bool FriendOrNo(string id)
        {
            command = new SqlCommand("SELECT id_Friend FROM friends WHERE id_Friend = @id", connect.Connection());
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();

                return false;
            }
            reader.Close();

            return true;
        }

    }
}
