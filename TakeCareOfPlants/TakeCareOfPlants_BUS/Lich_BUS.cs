using System;
using System.Collections.Generic;
using TakeCareOfPlants_DAL;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_BUS
{
    public class Lich_BUS
    {
        private VatTu_SQL vatTuSQL = new VatTu_SQL();
        private CayCanh_SQL cayCanhSQL = new CayCanh_SQL();

        public List<Tuple<CayCanh_DTO, ViTri_DTO>> GetValueCayCanhViTri()
        {
            return cayCanhSQL.GetDataCayCanhViTri();
        }

        public List<Tuple<VatTu_DTO, DonVi_DTO>> GetValueVatTuDonVi()
        {
            return vatTuSQL.GetDataVatTuDonVi();
        }
    }
}
