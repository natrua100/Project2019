using System;
using System.Drawing;
using System.Windows.Forms;

namespace TakeCareOfPlants
{
    public partial class UI_Materials : UserControl
    {
        private static UI_Materials uiMaterials;
        private DateTimePicker dtp = new DateTimePicker();
        private Rectangle rectangle;
        private TextBox tb;
        private DataGridViewCell dataGridViewCell;

        public static UI_Materials Instance
        {
            get {
                if (uiMaterials == null) {
                    uiMaterials = new UI_Materials();
                }
                return uiMaterials;
            }
        }

        public UI_Materials()
        {
            InitializeComponent();
        }

        private void UI_Materials_Load(object sender, EventArgs e)
        {
            Coupon_DataGrid.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(Time_Purchase_TextChanged);
        }

        private void Purchase_Material_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Coupon_DataGrid.Columns[e.ColumnIndex].Name == "Time_Purchase") {
                rectangle = Coupon_DataGrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Size = new Size(rectangle.Width, rectangle.Height);
                dtp.Location = new Point(rectangle.X, rectangle.Y);
                dtp.Visible = true;
                dataGridViewCell = Coupon_DataGrid.CurrentCell;
            }
        }

        private void Time_Purchase_TextChanged(object sender, EventArgs e)
        {
            if (Coupon_DataGrid.CurrentCell == dataGridViewCell) {
                Coupon_DataGrid.CurrentCell.Value = dtp.Text;
            }
        }

        private void Purchase_Material_DataGrid_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtp.Visible = false;
        }

        private void Purchase_Material_DataGrid_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
        }

        private void Purchase_Material_DataGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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
                    tb = (TextBox)e.Control;
                    tb.TextChanged += new EventHandler(Money_TextChanged);
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
            if (tb.Text != "" && Coupon_DataGrid.CurrentCell.ColumnIndex == 5) {
                tb.Text = string.Format("{0:#,#}", double.Parse(tb.Text));
                tb.SelectionStart = tb.Text.Length;
            }
        }
    }
}
