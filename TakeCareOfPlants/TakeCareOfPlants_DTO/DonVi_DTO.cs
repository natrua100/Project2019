using System;
using System.Collections.Generic;
using System.Text;

namespace TakeCareOfPlants_DTO
{
    public class DonVi_DTO
    {
        private String id;
        private String donVi;

        public DonVi_DTO()
        {
        }

        public DonVi_DTO(string donVi)
        {
            this.donVi = donVi;
        }

        public DonVi_DTO(string id , string donVi)
        {
            this.id = id;
            this.donVi = donVi;
        }

        public string DonVi { get => donVi; set => donVi = value; }
        public string Id { get => id; set => id = value; }
    }
}
