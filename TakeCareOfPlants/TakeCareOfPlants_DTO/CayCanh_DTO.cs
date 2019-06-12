using System;

namespace TakeCareOfPlants_DTO
{
    public class CayCanh_DTO
    {
        private string id;
        private string tenCay;
        private Loai_DTO loai_DTO;
        private TinhTrang_DTO tinhTrang_DTO;
        private DateTime ngayTrong;

        public CayCanh_DTO()
        {
        }

        public CayCanh_DTO(string id, string tenCay)
        {
            this.id = id;
            this.tenCay = tenCay;
        }

        public CayCanh_DTO(string tenCay, Loai_DTO loai_DTO, TinhTrang_DTO tinhTrang_DTO, DateTime ngayTrong)
        {
            this.tenCay = tenCay;
            this.loai_DTO = loai_DTO;
            this.tinhTrang_DTO = tinhTrang_DTO;
            this.ngayTrong = ngayTrong;
        }

        public CayCanh_DTO(string id, string tenCay, Loai_DTO loai_DTO, TinhTrang_DTO tinhTrang_DTO, DateTime ngayTrong)
        {
            this.id = id;
            this.tenCay = tenCay;
            this.loai_DTO = loai_DTO;
            this.tinhTrang_DTO = tinhTrang_DTO;
            this.ngayTrong = ngayTrong;
        }

        public string TenCay { get => tenCay; set => tenCay = value; }
        public TinhTrang_DTO TinhTrang_DTO { get => tinhTrang_DTO; set => tinhTrang_DTO = value; }
        public Loai_DTO Loai_DTO { get => loai_DTO; set => loai_DTO = value; }
        public string Id { get => id; set => id = value; }
        public DateTime NgayTrong { get => ngayTrong; set => ngayTrong = value; }
    }
}
