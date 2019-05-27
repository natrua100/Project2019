using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class Login_SQL
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;

        public Login_DTO GetData()
        {
            Login_DTO loginDTO = new Login_DTO();
            command.CommandText = "SELECT * FROM login WHERE TaiKhoan = 'quanly123'";
            command.Connection = databaseConnection.Connection;
            try {
                databaseConnection.OpenConnect();
                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while(reader.Read()) {
                        loginDTO.TaiKhoan = reader.GetString("TaiKhoan");
                        loginDTO.MatKhau = reader.GetString("MatKhau");
                    }
                }
                reader.Close();
                command.Dispose();
                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                MessageBox.Show("Loi: " + ex.Message, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                command.Dispose();
                databaseConnection.CloseConnect();
            }
            return loginDTO;
        }

        public void InsertData(Login_DTO login_DTO)
        {
            command.CommandText = "INSERT INTO login(TaiKhoan, MatKhau) VALUE (@tk, @mk)";
            command.Connection = databaseConnection.Connection;
            try {
                command.Parameters.AddWithValue("@tk", login_DTO.TaiKhoan);
                command.Parameters.AddWithValue("@mk", login_DTO.MatKhau);
                databaseConnection.OpenConnect();
                command.ExecuteNonQuery();
                command.Dispose();
                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                string mex = ex.Message;
                command.Dispose();
                databaseConnection.CloseConnect();
            }
        }
    }
}
