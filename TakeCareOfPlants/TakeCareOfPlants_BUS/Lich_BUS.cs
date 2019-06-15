using System;
using System.Collections.Generic;
using System.Linq;
using TakeCareOfPlants_DAL;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_BUS
{
    public class Lich_BUS
    {
        private VatTu_SQL vatTuSQL = new VatTu_SQL();
        private CayCanh_SQL cayCanhSQL = new CayCanh_SQL();
        private Lich_SQL lichSQL = new Lich_SQL();

        public List<Tuple<CayCanh_DTO, ViTri_DTO>> GetValueCayCanhViTri()
        {
            return cayCanhSQL.GetDataCayCanhViTri();
        }

        public List<Tuple<VatTu_DTO, DonVi_DTO>> GetValueVatTuDonVi()
        {
            return vatTuSQL.GetDataVatTuDonVi();
        }

        public void InsertValueLich(Lich_DTO lich_DTO, List<string> listId, List<Tuple<VatTu_DTO, DonVi_DTO>> tuples)
        {
            lichSQL.InsertDataLich(
                lich_DTO, 
                listId, 
                tuples.Select(
                    t => new VatTu_DTO(
                        id: t.Item1.Id,
                        tenVatTu: t.Item1.TenVatTu,
                        soLuong: t.Item1.SoLuong)).ToList()
            );
        }
    }
}
