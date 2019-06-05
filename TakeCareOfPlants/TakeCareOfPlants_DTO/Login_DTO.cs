namespace TakeCareOfPlants_DTO
{
    public class Login_DTO
    {
        private string id;
        private string taiKhoan;
        private string hash;
        private string salt;

        public Login_DTO()
        {
        }

        public Login_DTO(string taiKhoan, string hash, string salt)
        {
            this.taiKhoan = taiKhoan;
            this.hash = hash;
            this.salt = salt;
        }

        public Login_DTO(string id, string taiKhoan, string hash, string salt)
        {
            this.id = id;
            this.taiKhoan = taiKhoan;
            this.hash = hash;
            this.salt = salt;
        }

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string Hash { get => hash; set => hash = value; }
        public string Id { get => id; set => id = value; }
        public string Salt { get => salt; set => salt = value; }
    }
}
