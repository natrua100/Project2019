namespace TakeCareOfPlants_DTO
{
    public class ViTri_DTO
    {
        private string id;
        private string tenViTri;
        private int soCayToiDa;

        public ViTri_DTO()
        {
        }       

        public ViTri_DTO(string tenViTri)
        {
            this.tenViTri = tenViTri;
        }

        public ViTri_DTO(string id, string tenViTri)
        {
            this.id = id;
            this.tenViTri = tenViTri;
        }

        public ViTri_DTO(string id, string tenViTri, int soCayToiDa)
        {
            this.id = id;
            this.tenViTri = tenViTri;
            this.soCayToiDa = soCayToiDa;
        }

        public string TenViTri { get => tenViTri; set => tenViTri = value; }
        public string Id { get => id; set => id = value; }
        public int SoCayToiDa { get => soCayToiDa; set => soCayToiDa = value; }
    }
}
