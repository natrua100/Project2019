using System;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants
{
    public partial class UI_Home : UserControl
    {
        public UI_Home()
        {
            InitializeComponent();
        }

        CayCanh_BUS cayCanhBUS = new CayCanh_BUS();
        private void UI_Home_Load(object sender, EventArgs e)
        {
            foreach(ViTri_DTO viTriDTO in cayCanhBUS.GetValueViTri()) {
                Locate_ComboBox.Items.Add(viTriDTO.TenViTri);
            }

            foreach (Loai_DTO loaiDTO in cayCanhBUS.GetValueLoai()) {
                Type_Of_Plant_ComboBox.Items.Add(loaiDTO.Loai);
            }
        }

        private void Name_Plant_Text_Leave(object sender, EventArgs e)
        {
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            Loai_DTO loaiDTO = new Loai_DTO(Type_Of_Plant_ComboBox.selectedIndex.ToString(), Type_Of_Plant_ComboBox.selectedValue);
            ViTri_DTO viTriDTO = new ViTri_DTO(Locate_ComboBox.selectedIndex.ToString(), Locate_ComboBox.selectedValue);
            CayCanh_DTO cayCanhDTO = new CayCanh_DTO(Name_Plant_Text.Text, loaiDTO, Planing_Data_DateTime.Value);
            cayCanhBUS.InsertValueCayCanh(cayCanhDTO, viTriDTO);
            List_Plant_DataGrid.Rows.Add();
        }
    }
}
