using System;
using System.Collections.Generic;
using System.Text;

namespace TakeCareOfPlants_DTO
{
    public class Lich_DTO
    {
        private string id;
        private DateTime ngayLapLich;
        private TimeSpan thoiGian;
        private String ghiChu;

        public Lich_DTO()
        {
        }

        public Lich_DTO(DateTime ngayLapLich, TimeSpan thoiGian, string ghiChu)
        {
            this.ngayLapLich = ngayLapLich;
            this.thoiGian = thoiGian;
            this.ghiChu = ghiChu;
        }

        public Lich_DTO(string id, DateTime ngayLapLich, TimeSpan thoiGian, string ghiChu)
        {
            this.id = id;
            this.ngayLapLich = ngayLapLich;
            this.thoiGian = thoiGian;
            this.ghiChu = ghiChu;
        }

        public DateTime NgayLapLich { get => ngayLapLich; set => ngayLapLich = value; }
        public TimeSpan ThoiGian { get => thoiGian; set => thoiGian = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string Id { get => id; set => id = value; }
    }
}
