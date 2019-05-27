using System;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants
{
    public partial class PageLogin_GUI : Form
    {
        Login_BUS loginBUS = new Login_BUS();

        public PageLogin_GUI()
        {
            InitializeComponent();
        }

        private void PageLogin_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tai_Khoan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tai_khoan_Click(object sender, EventArgs e)
        {

        }

        private void sign_in_Click(object sender, EventArgs e)
        {

        }

        private void mat_khau_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void google_icon_Click(object sender, EventArgs e)
        {

        }

        private void facebook_icon_Click(object sender, EventArgs e)
        {

        }

        private void remember_password_check_OnChange(object sender, EventArgs e)
        {

        }

        private void remember_password_Click(object sender, EventArgs e)
        {
            if (remember_password_check.Checked == true) {
                remember_password_check.Checked = false;
            } else {
                remember_password_check.Checked = true;
            }
        }
    }
}
