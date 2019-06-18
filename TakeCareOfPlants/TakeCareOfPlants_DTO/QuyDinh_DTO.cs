using System.Collections.Generic;

namespace TakeCareOfPlants_DTO
{
    public class QuyDinh_DTO
    {
        private string id;
        private int soLoaiVatTu;
        private long soTienToiDa;

        public QuyDinh_DTO()
        {
        }

        public QuyDinh_DTO(int soLoaiVatTu, long soTienToiDa)
        {
            this.soLoaiVatTu = soLoaiVatTu;
            this.soTienToiDa = soTienToiDa;
        }

        public QuyDinh_DTO(string id, int soLoaiVatTu, long soTienToiDa)
        {
            this.id = id;
            this.soLoaiVatTu = soLoaiVatTu;
            this.soTienToiDa = soTienToiDa;
        }

        public string Id { get => id; set => id = value; }
        public int SoLoaiVatTu { get => soLoaiVatTu; set => soLoaiVatTu = value; }
        public long SoTienToiDa { get => soTienToiDa; set => soTienToiDa = value; }
    }
}
