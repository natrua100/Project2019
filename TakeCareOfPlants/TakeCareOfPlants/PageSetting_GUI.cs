using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants
{
    public partial class PageSetting_GUI : Form
    {
        private static PageSetting_GUI pageSetting;

        public PageSetting_GUI()
        {
            InitializeComponent();
        }

        public static PageSetting_GUI Instance
        {
            get {
                if (pageSetting == null) {
                    pageSetting = new PageSetting_GUI();
                }
                return pageSetting;
            }
        }

        private void PageSetting_GUI_Load(object sender, EventArgs e)
        {
            NumberPlant_Text.Text = QuyDinh_BUS.QuyDinh_DTOs[1].SoCayToiDa.ToString();
            TypeMaterial_Text.Text = QuyDinh_BUS.QuyDinh_DTOs[1].SoLoaiVatTu.ToString();
            AmountMoney_Text.Text = string.Format("{0:#,#}", QuyDinh_BUS.QuyDinh_DTOs[1].SoTienToiDa);
        }

        private void Default_Button_Click(object sender, EventArgs e)
        {
            NumberPlant_Text.Text = QuyDinh_BUS.QuyDinh_DTOs[0].SoCayToiDa.ToString();
            TypeMaterial_Text.Text = QuyDinh_BUS.QuyDinh_DTOs[0].SoLoaiVatTu.ToString();
            AmountMoney_Text.Text = string.Format("{0:#,#}", QuyDinh_BUS.QuyDinh_DTOs[0].SoTienToiDa);
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            QuyDinh_DTO quyDinhDTO = new QuyDinh_DTO {
                SoCayToiDa = int.Parse(NumberPlant_Text.Text),
                SoLoaiVatTu = int.Parse(TypeMaterial_Text.Text),
                SoTienToiDa = (long)decimal.Parse(AmountMoney_Text.Text, NumberStyles.Currency)
            };

            switch (MessageBox.Show("Are you sure you want to Save?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)) {
                case DialogResult.OK: {
                        try {
                            QuyDinh_BUS.UpdateValueQuyDinh(quyDinhDTO);
                            DialogSuccess_GUI.Instance.ShowDialog();
                        } catch (Exception ex) {
                            Function_GUI.ShowErrorDialog(ex.ToString());
                        }
                        break;
                    }
                case DialogResult.Cancel: {
                        new CancelEventArgs().Cancel = true;
                        break;
                    }
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            pageSetting = this;
            Function_GUI.HidePage(pageSetting);
        }

        private void AmountMoney_Text_TextChanged(object sender, EventArgs e)
        {
            if (AmountMoney_Text.Text != "") {
                AmountMoney_Text.Text = string.Format("{0:#,#}", double.Parse(AmountMoney_Text.Text));
                AmountMoney_Text.SelectionStart = AmountMoney_Text.Text.Length;
            }
        }

        private void NumberPlant_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function_GUI.IsNumberic(e);
            NumberPlant_Text.MaxLength = 2;
        }

        private void TypeMaterial_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function_GUI.IsNumberic(e);
            TypeMaterial_Text.MaxLength = 2;
        }

        private void AmountMoney_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            Function_GUI.IsNumberic(e);
        }

        protected override CreateParams CreateParams
        {
            get {
                CreateParams cp = base.CreateParams;
                if (!Function_GUI.CheckAeroEnabled()) {
                    cp.ClassStyle |= (int)Function_GUI.ShadowBorder.CS_DROPSHADOW;
                }
                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg) {
                case (int)Function_GUI.ShadowBorder.WM_NCPAINT:
                    if (Function_GUI.CheckAeroEnabled()) {
                        int v = 2;
                        Function_GUI.DwmSetWindowAttribute(Handle, 2, ref v, 4);
                        Function_GUI.MARGINS margins = new Function_GUI.MARGINS() {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        };
                        Function_GUI.DwmExtendFrameIntoClientArea(Handle, ref margins);
                    }
                    break;
                default:
                    break;
            }

            if (m.Msg == (int)Function_GUI.ShadowBorder.WM_NCLBUTTONDBLCLK) {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);
            if (m.Msg == (int)Function_GUI.ShadowBorder.WM_NCHITTEST && (int)m.Result == (int)Function_GUI.ShadowBorder.HTCLIENT) {
                m.Result = (IntPtr)Function_GUI.ShadowBorder.HTCAPTION;
            }
        }
    }
}
