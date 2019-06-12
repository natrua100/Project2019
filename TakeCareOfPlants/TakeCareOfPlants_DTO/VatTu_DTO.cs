namespace TakeCareOfPlants_DTO
{
    public class VatTu_DTO
    {
        private string id;
        private string tenVatTu;
        private int soLuong;

        public VatTu_DTO()
        {
        }

        public VatTu_DTO(string id, string tenVatTu)
        {
            this.id = id;
            this.tenVatTu = tenVatTu;
        }

        public VatTu_DTO(string tenVatTu, int soLuong)
        {
            this.tenVatTu = tenVatTu;
            this.soLuong = soLuong;
        }

        public VatTu_DTO(string id, string tenVatTu, int soLuong)
        {
            this.id = id;
            this.tenVatTu = tenVatTu;
            this.soLuong = soLuong;
        }

        public string TenVatTu { get => tenVatTu; set => tenVatTu = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string Id { get => id; set => id = value; }
    }
}
