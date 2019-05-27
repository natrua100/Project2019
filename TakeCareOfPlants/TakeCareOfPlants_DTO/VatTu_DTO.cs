using System;
using System.Collections.Generic;
using System.Text;

namespace TakeCareOfPlants_DTO
{
    class VatTu_DTO
    {
        private String tenVatTu;
        private String donVi;
        private int soLuong;

        public VatTu_DTO()
        {
        }

        public VatTu_DTO(string tenVatTu, string donVi, int soLuong)
        {
            this.tenVatTu = tenVatTu;
            this.donVi = donVi;
            this.soLuong = soLuong;
        }

        public string TenVatTu { get => tenVatTu; set => tenVatTu = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
