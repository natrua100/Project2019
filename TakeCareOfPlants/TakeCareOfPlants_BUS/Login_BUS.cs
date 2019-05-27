using System;
using System.Security.Cryptography;
using TakeCareOfPlants_DAL;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_BUS
{
    public class Login_BUS
    {
        Login_SQL loginSQL = new Login_SQL();
        public Login_DTO GetValue()
        {
            return loginSQL.GetData();
        }

        public void InsertValue(Login_DTO loginDTO)
        {
            loginSQL.InsertData(loginDTO);
        }

        public string GenerateHash(string input, string salt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            var hashAlgoritm = MD5.Create();
            bytes = hashAlgoritm.ComputeHash(bytes);
            return Convert.ToBase64String(bytes);
        }

        public string CreateSalt(int size)
        {
            var rng = RandomNumberGenerator.Create();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }
    }
}
