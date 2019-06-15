﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace TakeCareOfPlants
{
    public partial class UI_Materials : UserControl
    {
        private static UI_Materials uiMaterials;
        private DateTimePicker dtp = new DateTimePicker();

        public static UI_Materials Instance
        {
            get {
                if (uiMaterials == null) {
                    uiMaterials = new UI_Materials();
                }
                return uiMaterials;
            }
        }

        private Rectangle Rectangle { get; set; }
        private TextBox Tb { get; set; }
        private DataGridViewCell DataGridViewCell { get; set; }

        public UI_Materials()
        {
            InitializeComponent();
        }

        private void UI_Materials_Load(object sender, EventArgs e)
        {
            Coupon_DataGrid.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += Time_Purchase_TextChanged;
            dtp.PreviewKeyDown += Time_Purchase_PreviewKeyDown;
        }

        private void Coupon_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && Coupon_DataGrid.Columns[e.ColumnIndex].Name == "Time_Purchase") {
                Rectangle = Coupon_DataGrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                if (Coupon_DataGrid.CurrentCell.Value == null) {
                    dtp.Value = DateTime.Now;
                } else {
                    dtp.Text = Coupon_DataGrid.CurrentCell.Value.ToString();
                }
                dtp.Size = new Size(Rectangle.Width, Rectangle.Height);
                dtp.Location = new Point(Rectangle.X, Rectangle.Y);
                dtp.Visible = true;
                DataGridViewCell = Coupon_DataGrid.CurrentCell;
            } else {
                dtp.Visible = false;
            }
        }

        private void Coupon_DataGrid_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtp.Visible = false;
        }

        private void Coupon_DataGrid_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
        }

        private void Coupon_DataGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            switch (Coupon_DataGrid.CurrentCell.ColumnIndex) {
                case 0:
                    e.Control.KeyPress -= Amount_KeyPress;
                    e.Control.KeyPress -= Money_KeyPress;
                    e.Control.KeyPress += Material_KeyPress;
                    break;
                case 4:
                    e.Control.KeyPress -= Money_KeyPress;
                    e.Control.KeyPress -= Material_KeyPress;
                    e.Control.KeyPress += Amount_KeyPress;
                    break;
                case 5:
                    e.Control.KeyPress -= Amount_KeyPress;
                    e.Control.KeyPress -= Material_KeyPress;
                    e.Control.KeyPress += Money_KeyPress;
                    Tb = (TextBox)e.Control;
                    Tb.TextChanged += new EventHandler(Money_TextChanged);
                    break;
            }
        }

        private void Material_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function_GUI.IsLetter(e);
        }

        private void Money_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function_GUI.IsNumberic(e);
        }

        private void Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function_GUI.IsNumberic(e);
        }

        private void Money_TextChanged(object sender, EventArgs e)
        {
            if (Tb.Text != "" && Coupon_DataGrid.CurrentCell.ColumnIndex == 5) {
                Tb.Text = string.Format("{0:#,#}", double.Parse(Tb.Text));
                Tb.SelectionStart = Tb.Text.Length;
            }
        }

        private void Time_Purchase_TextChanged(object sender, EventArgs e)
        {
            if (Coupon_DataGrid.CurrentCell == DataGridViewCell) {
                Coupon_DataGrid.CurrentCell.Value = dtp.Text;
            }
        }

        private void Time_Purchase_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter) {
                Coupon_DataGrid.CurrentCell.Value = dtp.Text;
                dtp.Visible = false;
            }
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Coupon_DataGrid.Rows.Clear();
            Coupon_DataGrid.Refresh();
        }
    }
}
