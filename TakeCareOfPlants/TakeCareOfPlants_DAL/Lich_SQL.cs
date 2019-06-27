using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class Lich_SQL
    {
        private DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command;
        private MySqlDataReader reader;

        public string InsertAndGetLastIdDataLich()
        {
            string lastId = null;
            try {
                databaseConnection.OpenConnect();

                command = new MySqlCommand {
                    Connection = databaseConnection.Connection,
                    CommandText = "INSERT INTO lich(NgayLapLich) VALUE (" + DateTime.Now.Date + ");"
                };
                command.ExecuteNonQuery();
                command.Dispose();

                command = new MySqlCommand {
                    CommandText = "SELECT MAX(ID) FROM lich",
                    Connection = databaseConnection.Connection
                };
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

        public List<Tuple<Lich_DTO, TimeSpan, string, string, int, string>> GetDataLichThoiGianVatTu()
        {
            List<Tuple<Lich_DTO, TimeSpan, string, string, int, string>> tuples =
                new List<Tuple<Lich_DTO, TimeSpan, string, string, int, string>>();
            command = new MySqlCommand {
                CommandText = "SELECT a.ID, a.NgayLapLich, c.ThoiGian, d.VatTu, e.DonVi, b.SoLuong, b.GhiChu " +
                "FROM lich AS a " +
                "INNER JOIN lich_thoigian_vattu AS b " +
                "ON b.IDLich = a.ID " +
                "INNER JOIN thoigian AS c " +
                "ON b.IDThoiGian = c.ID " +
                "INNER JOIN vattu AS d " +
                "ON b.IDVatTu = d.ID " +
                "INNER JOIN donvi AS e " +
                "ON d.IDDonVi = e.ID " +
                "ORDER BY a.ID, c.ThoiGian;",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();

                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        tuples.Add(
                            new Tuple<Lich_DTO, TimeSpan, string, string, int, string>(
                                new Lich_DTO(reader.GetString("ID"), reader.GetDateTime("NgayLapLich")),
                                reader.GetTimeSpan("ThoiGian"),
                                reader.GetString("VatTu"),
                                reader.GetString("DonVi"),
                                reader.GetInt32("SoLuong"),
                                reader.GetString("GhiChu")));
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
