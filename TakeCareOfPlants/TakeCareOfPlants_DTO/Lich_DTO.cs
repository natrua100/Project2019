using System;
using System.Collections.Generic;
using System.Text;

namespace TakeCareOfPlants_DTO
{
    public class Lich_DTO
    {
        public Lich_DTO()
        {
        }

        public Lich_DTO(DateTime ngayLapLich, TimeSpan thoiGian, string ghiChu) 
            => (NgayLapLich, ThoiGian, GhiChu) = (ngayLapLich, thoiGian, ghiChu);

        public Lich_DTO(string id, DateTime ngayLapLich, TimeSpan thoiGian, string ghiChu) 
            => (Id, NgayLapLich, ThoiGian, GhiChu) = (id, ngayLapLich, thoiGian, ghiChu);

        public string Id { get; set; }
        public DateTime NgayLapLich { get; set; }
        public TimeSpan ThoiGian { get; set; }
        public string GhiChu { get; set; }
    }
}
