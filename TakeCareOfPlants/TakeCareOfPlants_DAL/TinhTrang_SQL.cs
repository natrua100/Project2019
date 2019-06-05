using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class TinhTrang_SQL
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;

        public List<TinhTrang_DTO> GetDataTinhTrang()
        {
            List<TinhTrang_DTO> tinhTrang_DTOs = new List<TinhTrang_DTO>();
            command.CommandText = "SELECT * FROM tinhtrang";
            command.Connection = databaseConnection.Connection;
            try {
                databaseConnection.OpenConnect();
                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        tinhTrang_DTOs.Add(new TinhTrang_DTO(reader.GetString("TinhTrang")));
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
            return tinhTrang_DTOs;
        }
    }
}
