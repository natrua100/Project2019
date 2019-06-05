using System;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants
{
    public partial class UI_Plant : UserControl
    {
        private static UI_Plant uiPlant;
        private CayCanh_BUS cayCanhBUS = new CayCanh_BUS();

        public static UI_Plant Instance
        {
            get {
                if (uiPlant == null) {
                    uiPlant = new UI_Plant();
                }
                return uiPlant;
            }
        }

        public UI_Plant()
        {
            InitializeComponent();
        }

        private void UI_Home_Load(object sender, EventArgs e)
        {
            foreach (ViTri_DTO viTriDTO in cayCanhBUS.GetValueViTri()) {
                Planting_Location_ComboBox.Items.Add(viTriDTO.TenViTri);
            }

            foreach (Loai_DTO loaiDTO in cayCanhBUS.GetValueLoai()) {
                Type_Of_Plant_ComboBox.Items.Add(loaiDTO.Loai);
            }

            foreach (TinhTrang_DTO tinhTrangDTO in cayCanhBUS.GetValueTinhTrang()) {
                Status_ComboBox.Items.Add(tinhTrangDTO.TinhTrang);
            }
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            Loai_DTO loaiDTO = new Loai_DTO(
                Type_Of_Plant_ComboBox.selectedIndex.ToString(),
                Type_Of_Plant_ComboBox.selectedValue);

            ViTri_DTO viTriDTO = new ViTri_DTO(
                Planting_Location_ComboBox.selectedIndex.ToString(),
                Planting_Location_ComboBox.selectedValue);

            TinhTrang_DTO tinhTrangDTO = new TinhTrang_DTO(
                Status_ComboBox.selectedIndex.ToString(),
                Status_ComboBox.selectedValue);

            CayCanh_DTO cayCanhDTO = new CayCanh_DTO(
                Name_Plant_Text.Text,
                loaiDTO,
                tinhTrangDTO,
                Planing_Data_DateTime.Value);

            cayCanhBUS.InsertValueCayCanh(cayCanhDTO, viTriDTO);

            List_Plant_DataGrid.Rows.Add(
                List_Plant_DataGrid.Rows.Count + 1,
                cayCanhDTO.TenCay,
                cayCanhDTO.Loai_DTO.Loai,
                viTriDTO.TenViTri,
                cayCanhDTO.TinhTrang_DTO.TinhTrang,
                cayCanhDTO.NgayTrong.ToString("dd/MM/yyyy"));
        }

        private void List_Plant_DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (List_Plant_DataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) {
                List_Plant_DataGrid.CurrentRow.Selected = true;
                Name_Plant_Text.Text =
                    List_Plant_DataGrid
                    .Rows[e.RowIndex]
                    .Cells["Column2"]
                    .FormattedValue.ToString();
                Type_Of_Plant_ComboBox.selectedIndex =
                    Type_Of_Plant_ComboBox.Items.IndexOf(List_Plant_DataGrid
                    .Rows[e.RowIndex]
                    .Cells["Column3"]
                    .FormattedValue.ToString());
                Planting_Location_ComboBox.selectedIndex =
                    Planting_Location_ComboBox.Items.IndexOf(List_Plant_DataGrid
                    .Rows[e.RowIndex]
                    .Cells["Column4"]
                    .FormattedValue.ToString());
                Status_ComboBox.selectedIndex =
                    Status_ComboBox.Items.IndexOf(List_Plant_DataGrid
                    .Rows[e.RowIndex]
                    .Cells["Column5"]
                    .FormattedValue.ToString());
                string time = List_Plant_DataGrid
                    .Rows[e.RowIndex]
                    .Cells["Column6"]
                    .FormattedValue.ToString();
                Planing_Data_DateTime.Value = DateTime.ParseExact(time, "dd/MM/yyyy", null);
            }
        }
    }
}
