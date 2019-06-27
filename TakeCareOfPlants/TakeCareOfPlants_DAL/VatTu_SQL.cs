using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class VatTu_SQL
    {
        private DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<VatTu_DTO> GetDataVatTu()
        {
            List<VatTu_DTO> vatTu_DTOs = new List<VatTu_DTO>();
            command = new MySqlCommand {
                CommandText = "SELECT * FROM vattu",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();
                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        vatTu_DTOs.Add(
                            new VatTu_DTO(
                                reader.GetString("ID"),
                                reader.GetString("VatTu"),
                                reader.GetInt32("SoLuong")));
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
            return vatTu_DTOs;
        }

        public List<Tuple<VatTu_DTO, DonVi_DTO>> GetDataVatTuDonVi()
        {
            List<Tuple<VatTu_DTO, DonVi_DTO>> tuples = new List<Tuple<VatTu_DTO, DonVi_DTO>>();
            command = new MySqlCommand {
                CommandText = "SELECT a.ID, a.VatTu, b.DonVi, a.SoLuong FROM vattu AS a " +
                "INNER JOIN donvi AS b " +
                "ON a.IDDonVi = b.ID;",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();
                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        tuples.Add(
                            new Tuple<VatTu_DTO, DonVi_DTO>(
                                new VatTu_DTO(
                                    reader.GetString("ID"), 
                                    reader.GetString("VatTu"), 
                                    reader.GetInt32("SoLuong")),
                                new DonVi_DTO(reader.GetString("DonVi"))));
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
