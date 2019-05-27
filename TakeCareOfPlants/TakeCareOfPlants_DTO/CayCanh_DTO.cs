using System;
using System.Collections.Generic;
using System.Text;

namespace TakeCareOfPlants_DTO
{
    public class CayCanh_DTO
    {
        private String id;
        private String tenCay;
        private Loai_DTO loai_DTO;
        private String tinhTrang;
        private DateTime ngayTrong;

        public CayCanh_DTO()
        {
        }

        public CayCanh_DTO(String tenCay, Loai_DTO loai_DTO, DateTime ngayTrong)
        {
            this.tenCay = tenCay;
            this.loai_DTO = loai_DTO;
            this.ngayTrong = ngayTrong;
        }

        public CayCanh_DTO(String tenCay, Loai_DTO loai_DTO, String tinhTrang, DateTime ngayTrong)
        {
            this.tenCay = tenCay;
            this.loai_DTO = loai_DTO;
            this.tinhTrang = tinhTrang;
            this.ngayTrong = ngayTrong;
        }

        public CayCanh_DTO(String id, String tenCay, Loai_DTO loai_DTO, String tinhTrang, DateTime ngayTrong)
        {
            this.id = id;
            this.tenCay = tenCay;
            this.loai_DTO = loai_DTO;
            this.tinhTrang = tinhTrang;
            this.ngayTrong = ngayTrong;
        }

        public String TenCay { get => tenCay; set => tenCay = value; }
        public String TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public Loai_DTO Loai_DTO { get => loai_DTO; set => loai_DTO = value; }
        public String Id { get => id; set => id = value; }
        public DateTime NgayTrong { get => ngayTrong; set => ngayTrong = value; }
    }
}
