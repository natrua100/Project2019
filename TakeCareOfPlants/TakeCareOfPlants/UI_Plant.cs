using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants
{
    public partial class UI_Plant : UserControl
    {
        private static UI_Plant uiPlant;
        private CayCanh_BUS cayCanhBUS = new CayCanh_BUS();
        private List<ViTri_DTO> listViTri;
        private List<Loai_DTO> listLoai;
        private List<TinhTrang_DTO> listTinhTrang;

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
            listViTri = cayCanhBUS.GetValueViTri();
            listLoai = cayCanhBUS.GetValueLoai();
            listTinhTrang = cayCanhBUS.GetValueTinhTrang();
            InitializeComponent();
        }

        private void UI_Home_Load(object sender, EventArgs e)
        {
            Update_Button.Enabled = false;
            Update_Button.BackColor = Color.LightSlateGray;

            foreach (ViTri_DTO viTriDTO in listViTri) {
                Planting_Location_ComboBox.AddItem(viTriDTO.TenViTri);
            }

            foreach (Loai_DTO loaiDTO in listLoai) {
                Type_Of_Plant_ComboBox.AddItem(loaiDTO.Loai);
            }

            foreach (TinhTrang_DTO tinhTrangDTO in listTinhTrang) {
                Status_ComboBox.AddItem(tinhTrangDTO.TinhTrang);
            }
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            Loai_DTO loaiDTO = listLoai.Find(r => r.Loai == Type_Of_Plant_ComboBox.selectedValue);

            ViTri_DTO viTriDTO = listViTri.Find(v => v.TenViTri == Planting_Location_ComboBox.selectedValue);

            TinhTrang_DTO tinhTrangDTO = listTinhTrang.Find(t => t.TinhTrang == Status_ComboBox.selectedValue);

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

            if (Create_Button.Enabled) {
                Create_Button.Enabled = false;
                Update_Button.Enabled = true;
            }
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Create_Button.Enabled = true;
            Create_Button.BackColor = Color.RoyalBlue;
            Update_Button.Enabled = false;
            Update_Button.BackColor = Color.LightSlateGray;

            Name_Plant_Text.Text = "";
            Type_Of_Plant_ComboBox.selectedIndex = 0;
            Planting_Location_ComboBox.selectedIndex = 0;
            Status_ComboBox.selectedIndex = 0;
            Planing_Data_DateTime.Value = DateTime.Now;
        }
    }
}
