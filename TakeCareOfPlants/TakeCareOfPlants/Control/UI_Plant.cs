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
        private int index;
        private List<string> listIDCayCanh = new List<string>();
        private List<string> listIDLoai = new List<string>();
        private List<string> listIDTinhTrang = new List<string>();

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
            Name_Plant_Text.Focus();
            Function_GUI.ChangeColorButton(Create_Button, Update_Button);

            try {
                foreach (ViTri_DTO viTriDTO in GlobalVariable_DTO.ViTri_DTOs) {
                    Planting_Location_ComboBox.AddItem(viTriDTO.TenViTri);
                }

                foreach (Loai_DTO loaiDTO in cayCanhBUS.GetValueLoai()) {
                    listIDLoai.Add(loaiDTO.Id);
                    Type_Of_Plant_ComboBox.AddItem(loaiDTO.Loai);
                }

                foreach (TinhTrang_DTO tinhTrangDTO in cayCanhBUS.GetValueTinhTrang()) {
                    listIDTinhTrang.Add(tinhTrangDTO.Id);
                    Status_ComboBox.AddItem(tinhTrangDTO.TinhTrang);
                }
            } catch (Exception ex) {
                Function_GUI.ShowErrorDialog(ex.Message);
            }

            Planing_Data_DateTime.Value = DateTime.Now;
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            bool createSuccess = true;
            ViTri_DTO viTriDTO = GlobalVariable_DTO.ViTri_DTOs[Planting_Location_ComboBox.selectedIndex];
            Loai_DTO loaiDTO = cayCanhBUS.GetValueLoaiWithId(listIDLoai[Type_Of_Plant_ComboBox.selectedIndex]);
            TinhTrang_DTO tinhTrangDTO = cayCanhBUS.GetValueTinhTrangWithId(listIDTinhTrang[Status_ComboBox.selectedIndex]);

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
                    cayCanhBUS.InsertValueCayCanh(cayCanhDTO, viTriDTO.Id);

                    listIDCayCanh.Add(cayCanhBUS.LastIDCayCanh());

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

                index = e.RowIndex;

                Name_Plant_Text.Text = List_Plant_DataGrid
                    .Rows[e.RowIndex]
                    .Cells["Column2"]
                    .FormattedValue.ToString();

                Type_Of_Plant_ComboBox.selectedIndex =
                    Type_Of_Plant_ComboBox.Items.IndexOf(
                        List_Plant_DataGrid
                        .Rows[e.RowIndex]
                        .Cells["Column3"]
                        .FormattedValue.ToString());

                Planting_Location_ComboBox.selectedIndex =
                    Planting_Location_ComboBox.Items.IndexOf(
                        List_Plant_DataGrid
                        .Rows[e.RowIndex]
                        .Cells["Column4"]
                        .FormattedValue.ToString());

                Status_ComboBox.selectedIndex =
                    Status_ComboBox.Items.IndexOf(
                        List_Plant_DataGrid
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
