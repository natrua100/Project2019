using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;
using TakeCareOfPlants_DTO;
using Telerik.WinControls.UI;

namespace TakeCareOfPlants
{
    public partial class UI_Calender : UserControl
    {
        private static UI_Calender uiCalender;
        private Lich_BUS lichBUS = new Lich_BUS();
        private List<VatTu_DTO> vatTu_DTOs = new List<VatTu_DTO>();
        private List<Tuple<CayCanh_DTO, ViTri_DTO>> tupleCayCanhViTri;
        private List<Tuple<VatTu_DTO, DonVi_DTO>> tupleVatTuDonVi;

        public static UI_Calender Instance
        {
            get {
                if (uiCalender == null) {
                    uiCalender = new UI_Calender();
                }
                return uiCalender;
            }
        }

        public UI_Calender()
        {
            tupleCayCanhViTri = lichBUS.GetValueCayCanhViTri();
            tupleVatTuDonVi = lichBUS.GetValueVatTuDonVi();
            InitializeComponent();
        }

        private void UI_Calender_Load(object sender, EventArgs e)
        {
            Update_Button.Enabled = false;
            Update_Button.BackColor = Color.LightSlateGray;

            foreach (Tuple<VatTu_DTO, DonVi_DTO> tuple in tupleVatTuDonVi) {
                Material_DropDown.Items.Add(new DescriptionTextCheckedListDataItem {
                    Text = tuple.Item1.TenVatTu,
                    DescriptionText = tuple.Item2.DonVi
                });
                vatTu_DTOs.Add(tuple.Item1);
            }

            foreach (Tuple<CayCanh_DTO, ViTri_DTO> tuple in tupleCayCanhViTri) {
                PlantName_DropDown.Items.Add(new DescriptionTextCheckedListDataItem {
                    Text = tuple.Item1.Id,
                    DescriptionText = tuple.Item1.TenCay + ", " + tuple.Item2.TenViTri
                });
            }
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Create_Button.Enabled = true;
            Create_Button.BackColor = Color.RoyalBlue;
            Update_Button.Enabled = false;
            Update_Button.BackColor = Color.LightSlateGray;

            Time_Pick.Value = DateTime.Now;
            Material_DropDown.Text = "";
            Note_Text.Text = "";
            PlantName_DropDown.Text = "";
        }

        private void Material_DropDown_ItemCheckedChanged(object sender, RadCheckedListDataItemEventArgs e)
        {
            if (e.Item.Checked) {
                Amount_GUI.Instance.Title = e.Item.Text;
                Amount_GUI.Instance.ShowDialog();

                switch (Amount_GUI.Instance.DialogResult) {
                    case DialogResult.OK: {
                            vatTu_DTOs.Find(r => r.TenVatTu == e.Item.Text).SoLuong = Amount_GUI.Instance.Amount;
                            break;
                        }
                    case DialogResult.Cancel: {
                            e.Item.Checked = false;
                            new CancelEventArgs().Cancel = true;
                            break;
                        }
                }
            }
        }

        private void PlantName_DropDown_VisualListItemFormatting(object sender, VisualItemFormattingEventArgs args)
        {
            Function_GUI.VisualListItem(Material_DropDown, args);
        }

        private void PlantName_DropDown_TextBlockFormatting(object sender, TextBlockFormattingEventArgs e)
        {
            Function_GUI.TextBlock(e);
        }

        private void Material_DropDown_VisualListItemFormatting(object sender, VisualItemFormattingEventArgs args)
        {
            Function_GUI.VisualListItem(PlantName_DropDown, args);
        }

        private void Material_DropDown_TextBlockFormatting(object sender, TextBlockFormattingEventArgs e)
        {
            Function_GUI.TextBlock(e);
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            //Lich_DTO lichDTO = new Lich_DTO(
                //DateTime.Now,
                //Time_Pick.Value,
                //Note_Text.Text
            //);
                

            //List_Calender_DataGrid.Rows.Add(
                //List_Calender_DataGrid.Rows.Count + 1,
                //lichDTO.ThoiGian,
                
                //cayCanhDTO.NgayTrong.ToString("dd/MM/yyyy"));
        }
    }
}
