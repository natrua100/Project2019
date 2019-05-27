using System;
using System.Collections.Generic;
using System.Text;

namespace TakeCareOfPlants_DTO
{
    class DonVi_DTO
    {
        private String id;
        private String donvi;

        DonVi_DTO(String id ,String donvi)
        {
            this.id = id;
            this.donvi = donvi;
        }

        public string Donvi { get => donvi; set => donvi = value; }
        public string Id { get => id; set => id = value; }
    }
}
