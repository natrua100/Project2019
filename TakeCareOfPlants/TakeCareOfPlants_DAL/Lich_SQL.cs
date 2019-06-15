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
        private string idLich;

        public void InsertDataLich(Lich_DTO lich_DTO, List<string> IdCayCanh, List<VatTu_DTO> vatTu_DTOs)
        {
            try {
                databaseConnection.OpenConnect();

                command = new MySqlCommand {
                    Connection = databaseConnection.Connection,
                    CommandText = "INSERT INTO lich(NgayLapLich, ThoiGian, GhiChu) VALUE (@nll, @tg, @gc)"
                };
                command.Parameters.AddWithValue("@nll", lich_DTO.NgayLapLich);
                command.Parameters.AddWithValue("@tg", lich_DTO.ThoiGian);
                command.Parameters.AddWithValue("@gc", lich_DTO.GhiChu);
                command.ExecuteNonQuery();
                idLich = Convert.ToString(command.LastInsertedId);
                command.Dispose();

                foreach (string idCayCanh in IdCayCanh) {
                    command = new MySqlCommand {
                        Connection = databaseConnection.Connection,
                        CommandText = "INSERT INTO caycanh_lich(IDCayCanh, IDLich) VALUE (@idcc, @idl)"
                    };
                    command.Parameters.AddWithValue("@idcc", idCayCanh);
                    command.Parameters.AddWithValue("@idl", idLich);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }

                foreach (VatTu_DTO idVatTu in vatTu_DTOs) {
                    command = new MySqlCommand {
                        Connection = databaseConnection.Connection,
                        CommandText = "INSERT INTO lich_vattu(IDLich, IDVatTu, SoLuong) VALUE (@idl, @idvt, @sl)"
                    };
                    command.Parameters.AddWithValue("@idl", idLich);
                    command.Parameters.AddWithValue("@idvt", idVatTu.Id);
                    command.Parameters.AddWithValue("@sl", idVatTu.SoLuong);
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
