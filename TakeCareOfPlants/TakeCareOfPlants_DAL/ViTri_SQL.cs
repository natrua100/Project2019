using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class ViTri_SQL
    {
        private DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<ViTri_DTO> GetDataViTri()
        {
            List<ViTri_DTO> viTri_DTOs = new List<ViTri_DTO>();
            command = new MySqlCommand {
                CommandText = "SELECT * FROM vitri",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();
                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        viTri_DTOs.Add(new ViTri_DTO(reader.GetString("ID"), reader.GetString("TenViTri")));
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
            return viTri_DTOs;
        }
    }
}
