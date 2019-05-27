using System;
using System.Collections.Generic;
using System.Text;

namespace TakeCareOfPlants_DTO
{
    public class ViTri_DTO
    {
        private String id;
        private String tenViTri;

        public ViTri_DTO()
        {
        }

        public ViTri_DTO(String tenViTri)
        {
            this.tenViTri = tenViTri;
        }

        public ViTri_DTO(String id, String tenViTri)
        {
            this.id = id;
            this.tenViTri = tenViTri;
        }

        public String TenViTri { get => tenViTri; set => tenViTri = value; }
        public String Id { get => id; set => id = value; }
    }
}
