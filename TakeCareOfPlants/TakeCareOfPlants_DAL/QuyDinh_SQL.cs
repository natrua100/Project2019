﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class QuyDinh_SQL
    {
        private DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command;
        private MySqlDataReader reader;

        public List<QuyDinh_DTO> GetDataQuyDinh()
        {
            List<QuyDinh_DTO> quyDinh_DTOs = new List<QuyDinh_DTO>();
            command = new MySqlCommand {
                CommandText = "SELECT * FROM quydinh",
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
                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                command.Dispose();
                databaseConnection.CloseConnect();
                throw ex;
            }
            return quyDinh_DTOs;
        }

        public void UpdateDataQuyDinh(QuyDinh_DTO quyDinh_DTO)
        {
            try {
                databaseConnection.OpenConnect();
                command = new MySqlCommand {
                    Connection = databaseConnection.Connection,
                    CommandText = "UPDATE quydinh AS h " +
                    "JOIN (SELECT MAX(ID) AS max_id FROM quydinh) AS m " +
                    "ON m.max_id = h.ID " +
                    "SET h.SoCayToiDa = @sctd, h.SoLoaiVatTu = @slvt, h.SoTienToiDa = @sttd;"
                };

                command.Parameters.AddWithValue("@sctd", quyDinh_DTO.SoCayToiDa);
                command.Parameters.AddWithValue("@slvt", quyDinh_DTO.SoLoaiVatTu);
                command.Parameters.AddWithValue("@sttd", quyDinh_DTO.SoTienToiDa);
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
