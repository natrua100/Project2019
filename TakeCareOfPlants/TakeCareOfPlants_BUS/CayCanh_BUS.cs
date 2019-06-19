using System;
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
            viTriSQL.GetAvailableLocation().ForEach(t => {
                if (t.Id == viTri_DTO.Id) {
                    if ((t.SoCayToiDa + 1) <= viTri_DTO.SoCayToiDa) {
                        cayCanhSQL.InsertDataCayCanh(cayCanh_DTO, viTri_DTO);
                    } else {
                        throw new Exception("The Location Is Full");
                    }
                }
            });
        }

        public List<ViTri_DTO> GetValueViTri() => viTriSQL.GetDataViTri();

        public List<Loai_DTO> GetValueLoai() => loaiSQL.GetDataLoai();

        public List<TinhTrang_DTO> GetValueTinhTrang() => tinhTrangDTO.GetDataTinhTrang();

        public List<Tuple<CayCanh_DTO, ViTri_DTO>> GetValueCayCanhViTri() => cayCanhSQL.GetDataCayCanhViTri();
    }
}
