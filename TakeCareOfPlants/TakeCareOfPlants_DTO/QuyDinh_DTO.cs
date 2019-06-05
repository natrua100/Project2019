namespace TakeCareOfPlants_DTO
{
    public class QuyDinh_DTO
    {
        private string id;
        private int soCayToiDa;
        private int soLoaiVatTu;
        private long soTienToiDa;

        public QuyDinh_DTO()
        {
        }

        public QuyDinh_DTO(int soCayToiDa, int soLoaiVatTu, long soTienToiDa)
        {
            this.soCayToiDa = soCayToiDa;
            this.soLoaiVatTu = soLoaiVatTu;
            this.soTienToiDa = soTienToiDa;
        }

        public QuyDinh_DTO(string id, int soCayToiDa, int soLoaiVatTu, long soTienToiDa)
        {
            this.id = id;
            this.soCayToiDa = soCayToiDa;
            this.soLoaiVatTu = soLoaiVatTu;
            this.soTienToiDa = soTienToiDa;
        }

        public string Id { get => id; set => id = value; }
        public int SoCayToiDa { get => soCayToiDa; set => soCayToiDa = value; }
        public int SoLoaiVatTu { get => soLoaiVatTu; set => soLoaiVatTu = value; }
        public long SoTienToiDa { get => soTienToiDa; set => soTienToiDa = value; }
    }
}
