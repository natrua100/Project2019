using System.Collections.Generic;
using TakeCareOfPlants_DAL;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_BUS
{
    public class CayCanh_BUS
    {
        private CayCanh_SQL cayCanhSQL = new CayCanh_SQL();
        private ViTri_SQL viTriSQL = new ViTri_SQL();
        private Loai_SQL loaiSQL = new Loai_SQL();
        private TinhTrang_SQL tinhTrangDTO = new TinhTrang_SQL();

        public void InsertValueCayCanh(CayCanh_DTO cayCanh_DTO, ViTri_DTO viTri_DTO)
        {
            cayCanhSQL.InsertDataCayCanh(cayCanh_DTO, viTri_DTO);
        }

        public List<ViTri_DTO> GetValueViTri()
        {
            return viTriSQL.GetDataViTri();
        }

        public List<Loai_DTO> GetValueLoai()
        {
            return loaiSQL.GetDataLoai();
        }

        public List<TinhTrang_DTO> GetValueTinhTrang()
        {
            return tinhTrangDTO.GetDataTinhTrang();
        }
    }
}
