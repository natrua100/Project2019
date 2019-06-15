using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class CayCanh_SQL
    {
        private DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command;
        private MySqlDataReader reader;

        public void InsertDataCayCanh(CayCanh_DTO cayCanh_DTO, ViTri_DTO viTri_DTO)
        {
            command = new MySqlCommand {
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();
                command.CommandText = "INSERT INTO caycanh(TenCay, IDLoai, IDTinhTrang, NgayTrong) VALUE (@tc, @idlc, @idtt, @nt)";
                command.Parameters.AddWithValue("@tc", cayCanh_DTO.TenCay);
                command.Parameters.AddWithValue("@idlc", cayCanh_DTO.Loai_DTO.Id);
                command.Parameters.AddWithValue("@idtt", cayCanh_DTO.TinhTrang_DTO.Id);
                command.Parameters.AddWithValue("@nt", cayCanh_DTO.NgayTrong);
                command.ExecuteNonQuery();
                command.Dispose();
                command.CommandText = "INSERT INTO caycanh_vitri(IDCayCanh, IDViTri) VALUE (SELECT MAX(ID) FROM caycanh, @idvt)";
                command.Parameters.AddWithValue("@idvt", viTri_DTO.Id);
                command.ExecuteNonQuery();
                command.Dispose();
                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                command.Dispose();
                databaseConnection.CloseConnect();
                throw ex;
            }
        }

        public List<Tuple<CayCanh_DTO, ViTri_DTO>> GetDataCayCanhViTri()
        {
            List<Tuple<CayCanh_DTO, ViTri_DTO>> tuples = new List<Tuple<CayCanh_DTO, ViTri_DTO>>();
            command = new MySqlCommand {
                CommandText = "SELECT a.ID, a.TenCay, c.TenViTri " +
                "FROM caycanh AS a " +
                "INNER JOIN caycanh_vitri AS b " +
                "ON a.ID = b.IDCayCanh " +
                "INNER JOIN vitri AS c " +
                "ON b.IDViTri = c.ID;",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();
                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        tuples.Add(
                            new Tuple<CayCanh_DTO, ViTri_DTO>(
                                new CayCanh_DTO(reader.GetString("ID"), reader.GetString("TenCay")),
                                new ViTri_DTO(reader.GetString("TenViTri"))));
                    }
                }
                reader.Close();
                command.Dispose();
                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                command.Dispose();
                databaseConnection.CloseConnect();
                throw ex;
            }
            return tuples;
        }
    }
}
