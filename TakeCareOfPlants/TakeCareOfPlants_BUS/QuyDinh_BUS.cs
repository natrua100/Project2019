using System;
using System.Collections.Generic;
using TakeCareOfPlants_DAL;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_BUS
{
    public static class QuyDinh_BUS
    {
        private static List<QuyDinh_DTO> quyDinh_DTOs;
        private static List<ViTri_DTO> viTri_DTOs;
        private static QuyDinh_SQL quyDinhSQL = new QuyDinh_SQL();
        private static ViTri_SQL viTriSQL = new ViTri_SQL();

        public static List<QuyDinh_DTO> QuyDinh_DTOs { get => quyDinh_DTOs; set => quyDinh_DTOs = value; }
        public static List<ViTri_DTO> ViTri_DTOs { get => viTri_DTOs; set => viTri_DTOs = value; }

        public static List<QuyDinh_DTO> GetValueQuyDinh()
        {
            return quyDinhSQL.GetDataQuyDinh();
        }

        public static List<ViTri_DTO> GetValueViTri()
        {
            return viTriSQL.GetDataViTri();
        }

        public static List<ViTri_DTO> GetAvailableViTri()
        {
            return viTriSQL.GetAvailableLocation();
        }

        public static void UpdateValueQuyDinh(List<ViTri_DTO> viTri_DTOs)
        {
            quyDinhSQL.UpdateDataQuyDinh(viTri_DTOs, quyDinh_DTOs[1]);
        }
    }
}
