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
            try {
                listViTri = QuyDinh_BUS.ViTri_DTOs;
                listLoai = cayCanhBUS.GetValueLoai();
                listTinhTrang = cayCanhBUS.GetValueTinhTrang();
            } catch (Exception ex) {
                Function_GUI.ShowErrorDialog(ex.Message);
            }
            InitializeComponent();
        }

        private void UI_Home_Load(object sender, EventArgs e)
        {
            Name_Plant_Text.Focus();
            Function_GUI.ChangeColorButton(Create_Button, Update_Button);

            foreach (ViTri_DTO viTriDTO in listViTri) {
                Planting_Location_ComboBox.AddItem(viTriDTO.TenViTri);
            }

            foreach (Loai_DTO loaiDTO in listLoai) {
                Type_Of_Plant_ComboBox.AddItem(loaiDTO.Loai);
            }

            foreach (TinhTrang_DTO tinhTrangDTO in listTinhTrang) {
                Status_ComboBox.AddItem(tinhTrangDTO.TinhTrang);
            }

            Planing_Data_DateTime.Value = DateTime.Now;
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            bool createSuccess = true;
            Loai_DTO loaiDTO = listLoai[Type_Of_Plant_ComboBox.selectedIndex];
            ViTri_DTO viTriDTO = listViTri[Planting_Location_ComboBox.selectedIndex];
            TinhTrang_DTO tinhTrangDTO = listTinhTrang[Status_ComboBox.selectedIndex];

            if (string.IsNullOrEmpty(Name_Plant_Text.Text)) {
                Name_Plant_Text.HintForeColor = Color.Red;
                createSuccess = false;
            }

            if (Type_Of_Plant_ComboBox.selectedIndex == 0) {
                Type_Of_Plant_ComboBox.ForeColor = Color.Red;
                createSuccess = false;
            }

            if (Planting_Location_ComboBox.selectedIndex == 0) {
                Planting_Location_ComboBox.ForeColor = Color.Red;
                createSuccess = false;
            }

            if (Status_ComboBox.selectedIndex == 0) {
                Status_ComboBox.ForeColor = Color.Red;
                createSuccess = false;
            }

            CayCanh_DTO cayCanhDTO = new CayCanh_DTO(
                Name_Plant_Text.Text,
                loaiDTO,
                tinhTrangDTO,
                Planing_Data_DateTime.Value);

            try {
                if (createSuccess) {
                    cayCanhBUS.InsertValueCayCanh(cayCanhDTO, viTriDTO);

                    List_Plant_DataGrid.Rows.Add(
                        List_Plant_DataGrid.Rows.Count + 1,
                        cayCanhDTO.TenCay,
                        cayCanhDTO.Loai_DTO.Loai,
                        viTriDTO.TenViTri,
                        cayCanhDTO.TinhTrang_DTO.TinhTrang,
                        cayCanhDTO.NgayTrong.ToString("dd/MM/yyyy"));
                }
            } catch (Exception ex) {
                Function_GUI.ShowErrorDialog(ex.Message);
            }
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

            Function_GUI.ChangeColorButton(Update_Button, Create_Button);
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Function_GUI.ChangeColorButton(Create_Button, Update_Button);

            Name_Plant_Text.Text = "";
            Name_Plant_Text.Focus();
            Type_Of_Plant_ComboBox.selectedIndex = 0;
            Planting_Location_ComboBox.selectedIndex = 0;
            Status_ComboBox.selectedIndex = 0;
            Planing_Data_DateTime.Value = DateTime.Now;
        }

        private void Name_Plant_Text_OnValueChanged(object sender, EventArgs e)
        {
            Name_Plant_Text.HintForeColor = Color.Black;
            if (string.IsNullOrEmpty(Name_Plant_Text.Text)) {
                Name_Plant_Text.Focus();
            }
        }

        private void Type_Of_Plant_ComboBox_onItemSelected(object sender, EventArgs e)
        {
            Type_Of_Plant_ComboBox.ForeColor = Color.Black;
        }

        private void Planting_Location_ComboBox_onItemSelected(object sender, EventArgs e)
        {
            Planting_Location_ComboBox.ForeColor = Color.Black;
        }

        private void Status_ComboBox_onItemSelected(object sender, EventArgs e)
        {
            Status_ComboBox.ForeColor = Color.Black;
        }
    }
}
