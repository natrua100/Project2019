using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TakeCareOfPlants_DAL
{
    class DatabaseConnection
    {
        private MySqlConnection connection;

        public DatabaseConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBQLCC"].ConnectionString;
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection Connection { get => connection; set => connection = value; }

        public bool OpenConnect()
        {
            try {
                if (connection.State.ToString().Equals("Closed")) {
                    connection.Open();
                }
            } catch (Exception ex) {
                MessageBox.Show("Loi: " + ex.Message, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CloseConnect()
        {
            try {
                if (connection.State.ToString().Equals("Open")) {
                    connection.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show("Loi: " + ex.Message, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
