using System;
using System.Collections.Generic;
using System.Text;

namespace TakeCareOfPlants_DTO
{
    public class Login_DTO
    {
        private String id;
        private String taiKhoan;
        private String matKhau;

        public Login_DTO()
        {
        }

        public Login_DTO(String taiKhoan, String matKhau)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
        }

        public Login_DTO(String id, String taiKhoan, String matKhau)
        {
            this.id = id;
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
        }

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public String Id { get => id; set => id = value; }
    }
}
