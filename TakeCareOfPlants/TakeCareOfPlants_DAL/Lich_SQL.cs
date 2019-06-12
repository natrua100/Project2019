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
    }
}
