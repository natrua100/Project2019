using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class ThoiGian_SQL
    {
        private DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command;

        public void InsertDataThoiGian(string idLich,
                                       TimeSpan thoiGian,
                                       List<string> cayCanhs,
                                       List<Tuple<string, string, int>> vatTus,
                                       string ghiChu)
        {
            try {
                databaseConnection.OpenConnect();

                foreach (string IdCayCanh in cayCanhs) {
                    command = new MySqlCommand {
                        Connection = databaseConnection.Connection,
                        CommandText = "INSERT INTO lich_thoigian_caycanh(IDLich, IDCayCanh, IDThoiGian) VALUE (@idl, @idcc, @idtg)"
                    };
                    command.Parameters.AddWithValue("@idl", idLich);
                    command.Parameters.AddWithValue("@idcc", IdCayCanh);
                    command.Parameters.AddWithValue("@idtg", thoiGian);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }

                foreach (Tuple<string, string, int> VatTu in vatTus) {
                    command = new MySqlCommand {
                        Connection = databaseConnection.Connection,
                        CommandText = "INSERT INTO lich_thoigian_vattu(IDLich, IDThoiGian, IDVatTu, SoLuong, GhiChu) "
                                      + "VALUE (@idl, @idtg, @idvt, @sl, @gc)"
                    };
                    command.Parameters.AddWithValue("@idl", idLich);
                    command.Parameters.AddWithValue("@idtg", thoiGian);
                    command.Parameters.AddWithValue("@idvt", VatTu.Item1);
                    command.Parameters.AddWithValue("@sl", VatTu.Item3);
                    command.Parameters.AddWithValue("@gc", ghiChu);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }

                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                command.Dispose();
                databaseConnection.CloseConnect();
                throw ex;
            }
        }
    }
}
