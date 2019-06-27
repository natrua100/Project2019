using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class CayCanh_SQL
    {
        private DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command;
        private MySqlDataReader reader;

        public string GetLastIDCayCanh()
        {
            string lastId = null;
            command = new MySqlCommand {
                CommandText = "SELECT MAX(ID) FROM caycanh",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();

                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        lastId = reader.GetString("MAX(ID)");
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
            return lastId;
        }

        public List<Tuple<CayCanh_DTO, ViTri_DTO>> GetDataCayCanhViTri()
        {
            List<Tuple<CayCanh_DTO, ViTri_DTO>> tuples = new List<Tuple<CayCanh_DTO, ViTri_DTO>>();
            command = new MySqlCommand {
                CommandText = "SELECT a.ID, a.TenCay, c.ID AS 'IDViTri', c.TenViTri " +
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
                                new ViTri_DTO(reader.GetString("IDViTri"), reader.GetString("TenViTri"))));
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

        public void InsertDataCayCanh(CayCanh_DTO cayCanh_DTO, string idViTri)
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

                command.CommandText = "INSERT INTO caycanh_vitri(IDCayCanh, IDViTri) VALUE (@lastId, @idvt)";
                command.Parameters.AddWithValue("@lastId", GetLastIDCayCanh());
                command.Parameters.AddWithValue("@idvt", idViTri);
                command.ExecuteNonQuery();
                command.Dispose();

                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                command.Dispose();
                databaseConnection.CloseConnect();
                throw ex;
            }
        }
    }
}
