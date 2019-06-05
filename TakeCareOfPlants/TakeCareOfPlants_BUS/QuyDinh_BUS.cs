using System.Collections.Generic;
using TakeCareOfPlants_DAL;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_BUS
{
    public static class QuyDinh_BUS
    {
        private static QuyDinh_DTO quyDinhDTO;
        private static QuyDinh_SQL quyDinhSQL = new QuyDinh_SQL();

        public static QuyDinh_DTO QuyDinhDTO { get => quyDinhDTO; set => quyDinhDTO = value; }

        public static List<QuyDinh_DTO> GetValueQuyDinh()
        {
            List<QuyDinh_DTO> quyDinh_DTOs = quyDinhSQL.GetDataQuyDinh();
            quyDinhDTO = quyDinh_DTOs[1];
            return quyDinh_DTOs;
        }

        public static void InsertValueQuyDinh(QuyDinh_DTO quyDinh_DTO)
        {
            quyDinhDTO = quyDinh_DTO;
            quyDinhSQL.InsertDataQuyDinh(quyDinh_DTO);
        }
    }
}
