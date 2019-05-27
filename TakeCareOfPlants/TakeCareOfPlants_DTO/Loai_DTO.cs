using System;

namespace TakeCareOfPlants_DTO
{
    public class Loai_DTO
    {
        private String id;
        private String loai;

        public Loai_DTO()
        {

        }

        public Loai_DTO(String loai)
        {
            this.loai = loai;
        }

        public Loai_DTO(String id, String loai)
        {
            this.id = id;
            this.loai = loai;
        }

        public String Loai { get => loai; set => loai = value; }
        public String Id { get => id; set => id = value; }
    }
}
