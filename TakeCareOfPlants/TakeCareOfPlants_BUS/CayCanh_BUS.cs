using System.Collections.Generic;
using TakeCareOfPlants_DAL;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_BUS
{
    public class CayCanh_BUS
    {
        CayCanh_SQL cayCanhSQL = new CayCanh_SQL();
        public void InsertValueCayCanh(CayCanh_DTO cayCanh_DTO, ViTri_DTO viTri_DTO)
        {
            cayCanhSQL.InsertDataCayCanh(cayCanh_DTO, viTri_DTO);
        }

        ViTri_SQL viTriSQL = new ViTri_SQL();
        public List<ViTri_DTO> GetValueViTri()
        {
            return viTriSQL.GetDataViTri();
        }

        Loai_SQL loaiSQL = new Loai_SQL();
        public List<Loai_DTO> GetValueLoai()
        {
            return loaiSQL.GetDataLoai();
        }
    }
}
