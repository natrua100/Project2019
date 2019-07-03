using System;
using System.Collections.Generic;
using System.Linq;
using TakeCareOfPlants_DAL;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_BUS
{
    public class Lich_BUS
    {
        private Lich_SQL lich_SQL = new Lich_SQL();
        private ThoiGian_SQL thoiGianSQL = new ThoiGian_SQL();

        public string InsertAndGetLastIdValueLich() => lich_SQL.InsertAndGetLastIdDataLich();

        public void InsertValueThoiGian(string idLich,
                                        TimeSpan thoiGian,
                                        List<string> listCayCanh,
                                        List<Tuple<string, string, int>> tuples,
                                        string ghiChu)
        {
            thoiGianSQL.InsertDataThoiGian(
                idLich,
                thoiGian,
                listCayCanh,
                tuples,
                ghiChu
            );
        }

        public List<Tuple<Lich_DTO, TimeSpan, string, string, int, string>> GetValueLich() => lich_SQL.GetDataLichThoiGianVatTu();
    }
}
