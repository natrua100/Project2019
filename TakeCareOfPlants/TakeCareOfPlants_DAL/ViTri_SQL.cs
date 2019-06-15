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
                command.Dispose();
                databaseConnection.CloseConnect();
                throw ex;
            }
            return viTri_DTOs;
        }

        public List<Tuple<string, int>> GetAvailableLocation()
        {
            List<Tuple<string, int>> tuples = new List<Tuple<string, int>>();
            command = new MySqlCommand {
                CommandText = "SELECT a.ID, COUNT(*) AS 'COUNT(ID)' FROM vitri AS a " +
                "INNER JOIN caycanh_vitri AS b " +
                "ON a.ID = b.IDViTri " +
                "GROUP BY a.ID;",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();
                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        tuples.Add(new Tuple<string, int>(reader.GetString("ID"), reader.GetInt32("COUNT(ID)")));
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
