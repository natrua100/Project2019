namespace TakeCareOfPlants_DTO
{
    public class Loai_DTO
    {
        private string id;
        private string loai;

        public Loai_DTO()
        {

        }

        public Loai_DTO(string loai)
        {
            this.loai = loai;
        }

        public Loai_DTO(string id, string loai)
        {
            this.id = id;
            this.loai = loai;
        }

        public string Loai { get => loai; set => loai = value; }
        public string Id { get => id; set => id = value; }
    }
}
