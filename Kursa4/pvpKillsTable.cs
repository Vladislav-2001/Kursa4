using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kursa4
{
    public partial class pvpKillsTable : Form
    {
        ConnectDB connect = new ConnectDB();
        SqlCommand command;
        SqlDataReader reader;

        public pvpKillsTable()
        {
            InitializeComponent();
        }

        private void pvpKillsTable_Load(object sender, EventArgs e)
        {
            connect.openConnection();

            string stroka = ("Имя\tКоличество килов");

            listBoxpvpKills.Items.Add(stroka);

            GetRangData();

            connect.closeConnection();
        }

        private void GetRangData()
        {
            command = new SqlCommand(
                "SELECT chrName, pvpKills FROM profile ORDER BY pvpKills DESC", connect.Connection());

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listBoxpvpKills.Items.Add($"{reader["chrName"]}\t{reader["pvpKills"]}");
                }

                reader.Close();
            }
        }
    }
}
