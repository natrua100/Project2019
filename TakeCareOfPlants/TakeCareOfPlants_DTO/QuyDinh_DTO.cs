using System;
using System.Collections.Generic;
using System.Text;

namespace TakeCareOfPlants_DTO
{
    class QuyDinh_DTO
    {
        private int viTri;
        private int soCayToiDa;
        private int soLoaiVatTu;
        private long soTien;

        public QuyDinh_DTO()
        {
        }

        public QuyDinh_DTO(int viTri, int soCayToiDa, int soLoaiVatTu, long soTien)
        {
            this.viTri = viTri;
            this.soCayToiDa = soCayToiDa;
            this.soLoaiVatTu = soLoaiVatTu;
            this.soTien = soTien;
        }

        public int ViTri { get => viTri; set => viTri = value; }
        public int SoCayToiDa { get => soCayToiDa; set => soCayToiDa = value; }
        public int SoLoaiVatTu { get => soLoaiVatTu; set => soLoaiVatTu = value; }
        public long SoTien { get => soTien; set => soTien = value; }
    }
}
