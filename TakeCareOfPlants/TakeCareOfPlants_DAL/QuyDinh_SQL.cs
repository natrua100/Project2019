using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class QuyDinh_SQL
    {
        private DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command;
        private MySqlCommand command1;
        private MySqlDataReader reader;

        public List<QuyDinh_DTO> GetDataQuyDinh()
        {
            List<QuyDinh_DTO> quyDinh_DTOs = new List<QuyDinh_DTO>();
            command = new MySqlCommand {
                CommandText = "SELECT * FROM quydinh ORDER BY ID LIMIT 1",
                Connection = databaseConnection.Connection
            };
            command1 = new MySqlCommand {
                CommandText = "SELECT * FROM quydinh ORDER BY ID DESC LIMIT 1",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();
                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        quyDinh_DTOs.Add(new QuyDinh_DTO(
                            reader.GetInt32("SoCayToiDa"),
                            reader.GetInt32("SoLoaiVatTu"),
                            reader.GetInt64("SoTienToiDa")));
                    }
                }
                reader.Close();
                command.Dispose();
                reader = command1.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        quyDinh_DTOs.Add(new QuyDinh_DTO(
                            reader.GetInt32("SoCayToiDa"),
                            reader.GetInt32("SoLoaiVatTu"),
                            reader.GetInt64("SoTienToiDa")));
                    }
                }
                reader.Close();
                command1.Dispose();
                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                MessageBox.Show("Loi: " + ex.Message, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                command.Dispose();
                command1.Dispose();
                databaseConnection.CloseConnect();
            }
            return quyDinh_DTOs;
        }

        public void InsertDataQuyDinh(QuyDinh_DTO quyDinh_DTO)
        {
            command = new MySqlCommand {
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();
                command.CommandText = "INSERT INTO quydinh(SoCayToiDa, SoLoaiVatTu, SoTienToiDa) VALUE (@sctd, @slvt, @sttd)";
                command.Parameters.AddWithValue("@sctd", quyDinh_DTO.SoCayToiDa);
                command.Parameters.AddWithValue("@slvt", quyDinh_DTO.SoLoaiVatTu);
                command.Parameters.AddWithValue("@sttd", quyDinh_DTO.SoTienToiDa);
                command.ExecuteNonQuery();
                command.Dispose();
                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                MessageBox.Show("Loi: " + ex.Message, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                command.Dispose();
                databaseConnection.CloseConnect();
            }
        }
    }
}
