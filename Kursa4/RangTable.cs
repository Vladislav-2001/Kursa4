
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kursa4
{
    public partial class RangTable : Form
    {
        ConnectDB connect = new ConnectDB();

        public RangTable()
        {
            InitializeComponent();
        }

        private void RangTable_Load(object sender, EventArgs e)
        {
            connect.openConnection();

            string stroka = ("Имя\tОчки опыта");

            listBoxRang.Items.Add(stroka);

            GetRangData();

            connect.closeConnection();
        }

        private void GetRangData()
        {
            SqlCommand command = new SqlCommand(
                "SELECT chrName, exp FROM profile ORDER BY exp DESC", connect.Connection());

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listBoxRang.Items.Add($"{reader["chrName"]}\t{reader["exp"]}");
                }
                reader.Close();
            }
        }
    }
}
