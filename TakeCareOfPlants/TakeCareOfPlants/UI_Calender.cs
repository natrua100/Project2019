using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
            try {
                tupleCayCanhViTri = lichBUS.GetValueCayCanhViTri();
                tupleVatTuDonVi = lichBUS.GetValueVatTuDonVi();
            } catch (Exception ex) {
                Function_GUI.ShowErrorDialog(ex.Message);
            }
            InitializeComponent();
        }

        private void UI_Calender_Load(object sender, EventArgs e)
        {
            Function_GUI.ChangeColorButton(Create_Button, Update_Button);
            Time_Pick.Value = DateTime.Now;

            foreach (Tuple<CayCanh_DTO, ViTri_DTO> tuple in tupleCayCanhViTri) {
                PlantName_DropDown.Items.Add(new DescriptionTextCheckedListDataItem {
                    Text = tuple.Item1.Id,
                    DescriptionText = tuple.Item1.TenCay + ", " + tuple.Item2.TenViTri
                });
            }

            foreach (Tuple<VatTu_DTO, DonVi_DTO> tuple in tupleVatTuDonVi) {
                Material_DropDown.Items.Add(new DescriptionTextCheckedListDataItem {
                    Text = tuple.Item1.TenVatTu,
                    DescriptionText = tuple.Item2.DonVi
                });
            }
        }
        
        private void Material_DropDown_ItemCheckedChanged(object sender, RadCheckedListDataItemEventArgs e)
        {
            if (e.Item.Checked) {
                Amount_GUI.Instance.Title = e.Item.Text;
                Amount_GUI.Instance.Amount = tupleVatTuDonVi[e.Item.RowIndex].Item1.SoLuong == 0
                    ? 0
                    : tupleVatTuDonVi[e.Item.RowIndex].Item1.SoLuong;
                Amount_GUI.Instance.ShowDialog();

                switch (Amount_GUI.Instance.DialogResult) {
                    case DialogResult.OK: {
                            tupleVatTuDonVi[e.Item.RowIndex].Item1.SoLuong = Amount_GUI.Instance.Amount;
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
            Function_GUI.VisualListItem(PlantName_DropDown, args);
        }

        private void PlantName_DropDown_TextBlockFormatting(object sender, TextBlockFormattingEventArgs e)
        {
            Function_GUI.TextBlock(e);
        }

        private void Material_DropDown_VisualListItemFormatting(object sender, VisualItemFormattingEventArgs args)
        {
            Function_GUI.VisualListItem(Material_DropDown, args);
        }

        private void Material_DropDown_TextBlockFormatting(object sender, TextBlockFormattingEventArgs e)
        {
            Function_GUI.TextBlock(e);
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            List<string> listIDCayCanh = new List<string>();
            List<Tuple<VatTu_DTO, DonVi_DTO>> listVatTuDoVi = new List<Tuple<VatTu_DTO, DonVi_DTO>>();
            DateTime dt = Time_Pick.Value ?? DateTime.Now;

            Lich_DTO lichDTO = new Lich_DTO(
                DateTime.Now,
                dt.TimeOfDay,
                Note_Text.Text
            );

            foreach (DescriptionTextCheckedListDataItem checkItems in PlantName_DropDown.CheckedItems) {
                listIDCayCanh.Add(tupleCayCanhViTri[checkItems.RowIndex].Item1.Id);
            }

            foreach (DescriptionTextCheckedListDataItem checkItems in Material_DropDown.CheckedItems) {
                listVatTuDoVi.Add(tupleVatTuDonVi[checkItems.RowIndex]);
            }

            listIDCayCanh.Sort();
            listVatTuDoVi = listVatTuDoVi.OrderBy(x => x.Item1.Id).ToList();

            try {
                lichBUS.InsertValueLich(
                    lichDTO, 
                    listIDCayCanh,
                    listVatTuDoVi);

                for (int i = 0; i < Material_DropDown.CheckedItems.Count; i++) {
                    List_Calender_DataGrid.Rows.Add(
                        List_Calender_DataGrid.Rows.Count + 1,
                        lichDTO.ThoiGian.ToString(@"hh\:mm"),
                        listVatTuDoVi[i].Item1.TenVatTu,
                        listVatTuDoVi[i].Item2.DonVi,
                        listVatTuDoVi[i].Item1.SoLuong,
                        lichDTO.GhiChu
                    );
                }
            } catch (Exception ex) {
                Function_GUI.ShowErrorDialog(ex.Message);
            }
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Function_GUI.ChangeColorButton(Create_Button, Update_Button);

            Time_Pick.Value = DateTime.Now;
            Material_DropDown.Text = "";
            Note_Text.Text = "";
            PlantName_DropDown.Text = "";
        }
    }
}
