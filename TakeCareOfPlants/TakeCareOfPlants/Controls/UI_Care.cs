using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants
{
    public partial class UI_Care : UserControl
    {
        private static UI_Care uiCare;
        private Lich_BUS lichBUS = new Lich_BUS();

        public UI_Care()
        {
            InitializeComponent();
        }

        public static UI_Care Instance
        {
            get {
                if (uiCare == null) {
                    uiCare = new UI_Care();
                }
                return uiCare;
            }
        }

        public BunifuCustomDataGrid TableCalender
        {
            get => List_Calender_DataGrid;

            set => List_Calender_DataGrid = value;
        }

        private void UI_Care_Load(object sender, EventArgs e)
        {
            uiCare = this;
        }

        private void List_Calender_DataGrid_CellPainting(object sender,
                                                         DataGridViewCellPaintingEventArgs e)
        {
            if (e == null) {
                throw new ArgumentNullException(nameof(e));
            }

            if (e.RowIndex != -1) {
                e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
                if (e.RowIndex < 1 || e.ColumnIndex < 0) {
                    return;
                }

                e.AdvancedBorderStyle.Top = Function_GUI.IsTheSameCellValue(List_Calender_DataGrid, e.ColumnIndex, e.RowIndex)
                                            && new List<int> { 0, 1, 6 }.Contains(e.ColumnIndex)
                    ? DataGridViewAdvancedCellBorderStyle.None
                    : List_Calender_DataGrid.AdvancedCellBorderStyle.Top;
            }
        }

        private void List_Calender_DataGrid_CellFormatting(object sender,
                                                           DataGridViewCellFormattingEventArgs e)
        {
            if (sender == null) {
                throw new ArgumentNullException(nameof(sender));
            }

            if (e.RowIndex == 0) {
                return;
            }

            if (Function_GUI.IsTheSameCellValue(List_Calender_DataGrid, e.ColumnIndex, e.RowIndex)) {
                if (new List<int> { 0, 1, 6 }.Contains(e.ColumnIndex)) {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            PageMain_GUI.Instance.TitlePage.Text = "Calender";
            UI_Calender.Instance.Update();

            Function_GUI.ShowControl(UI_Calender.Instance);
        }

        private void Get_All_Button_Click(object sender, EventArgs e)
        {
            int index = 1;
            try {
                List<Tuple<Lich_DTO, TimeSpan, string, string, int, string>> listCalender = lichBUS.GetValueLich();

                foreach (Tuple<Lich_DTO, TimeSpan, string, string, int, string> tuple in listCalender) {
                    List_Calender_DataGrid.Rows.Add(
                        index,
                        tuple.Item1.NgayLapLich.Date,
                        tuple.Item2,
                        tuple.Item3,
                        tuple.Item4,
                        tuple.Item5,
                        tuple.Item6);

                    if (List_Calender_DataGrid.Rows.Count > 1
                        && !List_Calender_DataGrid.Rows[List_Calender_DataGrid.Rows.Count - 1].Cells[1].Value.Equals(List_Calender_DataGrid.Rows[List_Calender_DataGrid.Rows.Count - 2].Cells[1].Value)) {
                        index++;
                        List_Calender_DataGrid.Rows[List_Calender_DataGrid.Rows.Count - 1].Cells[0].Value = index;
                    }
                }
            } catch (Exception ex) {
                Function_GUI.ShowErrorDialog(ex.Message);
            }
        }

        private void List_Calender_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List_Calender_DataGrid.MultiSelect = true;
            List_Calender_DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (e.RowIndex < 1 || e.ColumnIndex < 0) {
                return;
            }

            //if (..the top line is empty...)
            //{
            //    List_Calender_DataGrid[e.ColumnIndex, e.RowIndex - 1].Selected = true;
            //    List_Calender_DataGrid[e.ColumnIndex, e.RowIndex].Selected = true;
            //}
        }
    }
}
