using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class CayCanh_SQL
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();
        MySqlCommand command;

        public void InsertDataCayCanh(CayCanh_DTO cayCanh_DTO, ViTri_DTO viTri_DTO)
        {
            databaseConnection.OpenConnect();
            command = new MySqlCommand {
                Connection = databaseConnection.Connection
            };
            try {
                command.CommandText = "INSERT INTO caycanh(TenCay, IDLoai, NgayTrong) VALUE (@tc, @idlc, @nt)";
                command.Parameters.AddWithValue("@tc", cayCanh_DTO.TenCay);
                command.Parameters.AddWithValue("@idlc", cayCanh_DTO.Loai_DTO.Id);
                command.Parameters.AddWithValue("@nt", cayCanh_DTO.NgayTrong);
                command.ExecuteNonQuery();
                command.Dispose();
                command.CommandText = "INSERT INTO caycanh_vitri(IDCayCanh, IDViTri) VALUE (LAST_INSERT_ID(), @idvt)";
                command.Parameters.AddWithValue("@idvt", viTri_DTO.Id);
                command.ExecuteNonQuery();
                command.Dispose();
                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                string mex = ex.Message;
                command.Dispose();
                databaseConnection.CloseConnect();
            }
        }

        public List<CayCanh_DTO> GetAllDataCayCanh()
        {
            return null;
        }
    }
}
