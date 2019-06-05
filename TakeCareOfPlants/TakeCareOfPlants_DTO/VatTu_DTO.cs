namespace TakeCareOfPlants_DTO
{
    internal class VatTu_DTO
    {
        private string id;
        private string tenVatTu;
        private string donVi;
        private int soLuong;

        public VatTu_DTO()
        {
        }

        public VatTu_DTO(string tenVatTu, string donVi, int soLuong)
        {
            this.tenVatTu = tenVatTu;
            this.donVi = donVi;
            this.soLuong = soLuong;
        }

        public VatTu_DTO(string id, string tenVatTu, string donVi, int soLuong)
        {
            this.id = id;
            this.tenVatTu = tenVatTu;
            this.donVi = donVi;
            this.soLuong = soLuong;
        }

        public string TenVatTu { get => tenVatTu; set => tenVatTu = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string Id { get => id; set => id = value; }
    }
}
