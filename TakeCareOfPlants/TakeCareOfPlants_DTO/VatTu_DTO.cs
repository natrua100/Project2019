namespace TakeCareOfPlants_DTO
{
    public class VatTu_DTO
    {
        public VatTu_DTO() {}

        public VatTu_DTO(string tenVatTu) => (TenVatTu) = (tenVatTu); 

        public VatTu_DTO(string tenVatTu, int soLuong) => (TenVatTu, SoLuong) = (tenVatTu, soLuong);

        public VatTu_DTO(string id, string tenVatTu, int soLuong) => (Id, TenVatTu, SoLuong) = (id, tenVatTu, soLuong);

        public string Id { get; set; }
        public string TenVatTu { get; set; }
        public int SoLuong { get; set; }
    }
}
