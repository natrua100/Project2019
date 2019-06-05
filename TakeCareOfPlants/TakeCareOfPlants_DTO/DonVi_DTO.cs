using System;
using System.Collections.Generic;
using System.Text;

namespace TakeCareOfPlants_DTO
{
    public class DonVi_DTO
    {
        private String id;
        private String donvi;

        public DonVi_DTO()
        {
        }

        public DonVi_DTO(string donvi)
        {
            this.donvi = donvi;
        }

        public DonVi_DTO(string id , string donvi)
        {
            this.id = id;
            this.donvi = donvi;
        }

        public string Donvi { get => donvi; set => donvi = value; }
        public string Id { get => id; set => id = value; }
    }
}
