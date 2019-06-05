using System;

namespace TakeCareOfPlants_DTO
{
    public class MuaVatTu_DTO
    {
        private string id;
        private string diaChi;
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

        public MuaVatTu_DTO(string id, string diaChi, DateTime ngayMua, int soLuong, long soTien)
        {
            this.id = id;
            this.diaChi = diaChi;
            this.ngayMua = ngayMua;
            this.soLuong = soLuong;
            this.soTien = soTien;
        }

        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgayMua { get => ngayMua; set => ngayMua = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public long SoTien { get => soTien; set => soTien = value; }
        public string Id { get => id; set => id = value; }
    }
}
