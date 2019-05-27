using System;
using System.Windows.Forms;

namespace TakeCareOfPlants
{
    public partial class PageMain_GUI : Form
    {
        static PageMain_GUI _obj;

        public static PageMain_GUI Instance
        {
            get {
                if (_obj == null) {
                    _obj = new PageMain_GUI();
                }
                return _obj;
            }
        }

        public PageMain_GUI()
        {
            InitializeComponent();
        }

        public Panel PanelController
        {
            get {
                return Panel_Center_Controller;
            }

            set {
                Panel_Center_Controller = value;
            }
        }

        public Button BackButton
        {
            get {
                return null;
            }

            set {
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (Panel_Menu.Width == 150) {
                Panel_Menu.Width = 50;
            } else {
                Panel_Menu.Width = 150;
            }
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {

            _obj = this;

            UI_Home uiHome = new UI_Home {
                Dock = DockStyle.Fill
            };
            PanelController.Controls.Add(uiHome);
        }

        private void Plant_Click(object sender, EventArgs e)
        {

        }

        private void Calender_Click(object sender, EventArgs e)
        {

        }

        private void Materials_Button_Click(object sender, EventArgs e)
        {

        }

        private void Reports_Button_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PageMain_GUI_Load(object sender, EventArgs e)
        {

        }

        private void Close_Windows_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mini_Windows_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Restore_Windows_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Normal;
            } else {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
