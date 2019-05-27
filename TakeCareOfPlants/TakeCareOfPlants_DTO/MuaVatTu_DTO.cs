using System;
using System.Collections.Generic;
using System.Text;

namespace TakeCareOfPlants_DTO
{
    class MuaVatTu_DTO
    {
        private String diaChi;
        private DateTime ngayMua;
        private int soLuong;
        private long soTien;

        public MuaVatTu_DTO()
        {
        }

        public MuaVatTu_DTO(string diaChi, DateTime ngayMua, int soLuong, long soTien)
        {
            this.diaChi = diaChi;
            this.ngayMua = ngayMua;
            this.soLuong = soLuong;
            this.soTien = soTien;
        }

        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgayMua { get => ngayMua; set => ngayMua = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public long SoTien { get => soTien; set => soTien = value; }
    }
}
