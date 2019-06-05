namespace TakeCareOfPlants_DTO
{
    public class TinhTrang_DTO
    {
        private string id;
        private string tinhTrang;

        public TinhTrang_DTO()
        {
        }

        public TinhTrang_DTO(string tinhTrang)
        {
            this.tinhTrang = tinhTrang;
        }

        public TinhTrang_DTO(string id, string tinhTrang)
        {
            this.id = id;
            this.tinhTrang = tinhTrang;
        }

        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string Id { get => id; set => id = value; }
    }
}
