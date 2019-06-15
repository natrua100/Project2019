using System.Collections.Generic;
using TakeCareOfPlants_DAL;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_BUS
{
    public static class QuyDinh_BUS
    {
        private static List<QuyDinh_DTO> quyDinh_DTOs;
        private static QuyDinh_SQL quyDinhSQL = new QuyDinh_SQL();

        public static List<QuyDinh_DTO> QuyDinh_DTOs { get => quyDinh_DTOs; set => quyDinh_DTOs = value; }

        public static List<QuyDinh_DTO> GetValueQuyDinh()
        {
            return quyDinhSQL.GetDataQuyDinh();
        }

        public static void UpdateValueQuyDinh(QuyDinh_DTO quyDinh_DTO)
        {
            quyDinh_DTOs[1] = quyDinh_DTO;
            quyDinhSQL.UpdateDataQuyDinh(quyDinh_DTO);
        }
    }
}
