using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kursa4
{
    public partial class ProFile : Form
    {
        private string userId = Authorization.GetUserId();
        private string login;

        public static string nameUser;

        ConnectDB connect = new ConnectDB();
        SqlCommand command;
        SqlDataReader reader;

        public ProFile()
        {
            InitializeComponent();
        }

        private void ProFile_Load(object sender, EventArgs e)
        {
            textBoxName.ReadOnly = true;

            connect.openConnection();

            GetProFileInfo(userId);

            GetInventory(userId);

            GetFriends();

            connect.closeConnection();
        }

        private void GetProFileInfo(string id)
        {
            command = new SqlCommand(
                "SELECT * FROM profile WHERE id_User = @id", connect.Connection());
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;

            reader = command.ExecuteReader();

            while (reader.Read())
            {

                textBoxName.Text = reader["chrName"].ToString();
                userLvl.Text = $"Lvl {reader["crLvl"]}";
                labelHp.Text = $"{reader["nowHp"]}/{reader["maxHp"]}";
                labelMp.Text = $"{reader["nowMp"]}/{reader["maxMp"]}";
                labelSex.Text = $"{reader["sex"]}";
                labelExp.Text = $"{reader["exp"]}";
                labelPvpKills.Text = $"{reader["pvpKills"]}";

                
            }
            reader.Close();
        }

        private void GetInventory(string id)
        {
            command = new SqlCommand(
                "SELECT iteminfo.name, iteminfo.itemClass, iteminfo.weightItem, iteminfo.priceItem, iteminfo.upLevl, inventory.quantity " +
                "FROM iteminfo " +
                "INNER JOIN inventory ON inventory.id_Item = iteminfo.id_Item WHERE inventory.id_User=@id", connect.Connection());
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                string stroka = ("Название\tКласс\t\tВес\tЦена\tУровень\tКоличество");

                listBoxInventory.Items.Add(stroka);

                while (reader.Read())
                {

                    string name = reader.GetValue(0).ToString();
                    string itemClass = reader.GetValue(1).ToString();
                    string weightItem = reader.GetValue(2).ToString();
                    string price = reader.GetValue(3).ToString();
                    string upLevel = reader.GetValue(4).ToString();
                    string quantity = reader.GetValue(5).ToString();

                    listBoxInventory.Items.Add($"{name, -25}{itemClass,-20}{weightItem,-15}{price,-25}{upLevel,-25}{quantity,-25}");

                }
                
            }
            reader.Close();
        }

        private void GetFriends()
        {
            command = new SqlCommand(
                "SELECT  friends.id_Friend, profile.chrName, profile.crLvl FROM friends " +
                "INNER JOIN profile ON friends.id_Friend = profile.id_User " +
                "WHERE friends.id_User = @id_User", connect.Connection());
            command.Parameters.Add("@id_User", SqlDbType.VarChar).Value = userId;

            reader = command.ExecuteReader();

            listBoxFriends.Items.Add($"Имя\t\tLvl");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listBoxFriends.Items.Add($"{reader["chrName"]}\t{reader["crLvl"]}");
                }
                reader.Close();
            }
            reader.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RangTable rangTable = new RangTable();

            rangTable.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pvpKillsTable pvpKillsTable = new pvpKillsTable();

            pvpKillsTable.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxName.ReadOnly = false;
            buttonSave.Visible = true;
            buttonEdit.Visible = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            login = textBoxName.Text;

            if(login != null)
            {
                command = new SqlCommand("UPDATE profile SET chrName = @login " +
                                "WHERE id_User = @id;", connect.Connection());
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = userId;
                command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;

                connect.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Изменено успешно!");

                connect.closeConnection();
            }
            textBoxName.ReadOnly = true;
            buttonSave.Visible = false;
            buttonEdit.Visible = true;
        }

        private void buttonFoundFriend_Click(object sender, EventArgs e)
        {
            nameUser = textBoxFriendName.Text;

             FriendWin friendWin = new FriendWin();
             friendWin.Show();
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Close();
        }
    }
}
