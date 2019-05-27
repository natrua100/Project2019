namespace TakeCareOfPlants
{
    partial class PageLogin_GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageLogin_GUI));
            this.BorderForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.sign_in = new System.Windows.Forms.Label();
            this.tai_khoan = new System.Windows.Forms.Label();
            this.mat_khau = new System.Windows.Forms.Label();
            this.Mat_Khau_Text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.remember_password_check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.remember_password = new System.Windows.Forms.Label();
            this.Facebook_icon = new Bunifu.Framework.UI.BunifuImageButton();
            this.Google_icon = new Bunifu.Framework.UI.BunifuImageButton();
            this.Twitter_icon = new Bunifu.Framework.UI.BunifuImageButton();
            this.GitHub_icon = new Bunifu.Framework.UI.BunifuImageButton();
            this.BorderButton = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sign_in_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Tai_Khoan_Text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.Facebook_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Google_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Twitter_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHub_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderForm
            // 
            this.BorderForm.ElipseRadius = 10;
            this.BorderForm.TargetControl = this;
            // 
            // DragForm
            // 
            this.DragForm.Fixed = true;
            this.DragForm.Horizontal = true;
            this.DragForm.TargetControl = this.panel1;
            this.DragForm.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 32);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sign_in
            // 
            this.sign_in.AutoSize = true;
            this.sign_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sign_in.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.sign_in.Location = new System.Drawing.Point(27, 84);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(103, 32);
            this.sign_in.TabIndex = 4;
            this.sign_in.Text = "Sign In";
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click);
            // 
            // tai_khoan
            // 
            this.tai_khoan.AutoSize = true;
            this.tai_khoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tai_khoan.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tai_khoan.Location = new System.Drawing.Point(44, 170);
            this.tai_khoan.Name = "tai_khoan";
            this.tai_khoan.Size = new System.Drawing.Size(116, 25);
            this.tai_khoan.TabIndex = 5;
            this.tai_khoan.Text = "User Name:";
            this.tai_khoan.Click += new System.EventHandler(this.tai_khoan_Click);
            // 
            // mat_khau
            // 
            this.mat_khau.AutoSize = true;
            this.mat_khau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mat_khau.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.mat_khau.Location = new System.Drawing.Point(44, 267);
            this.mat_khau.Name = "mat_khau";
            this.mat_khau.Size = new System.Drawing.Size(104, 25);
            this.mat_khau.TabIndex = 6;
            this.mat_khau.Text = "Password:";
            this.mat_khau.Click += new System.EventHandler(this.mat_khau_Click);
            // 
            // Mat_Khau_Text
            // 
            this.Mat_Khau_Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Mat_Khau_Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Mat_Khau_Text.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Mat_Khau_Text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Mat_Khau_Text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Mat_Khau_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Mat_Khau_Text.HintForeColor = System.Drawing.Color.Empty;
            this.Mat_Khau_Text.HintText = "Mật Khẩu Đăng Nhập";
            this.Mat_Khau_Text.isPassword = true;
            this.Mat_Khau_Text.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.Mat_Khau_Text.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.Mat_Khau_Text.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.Mat_Khau_Text.LineThickness = 3;
            this.Mat_Khau_Text.Location = new System.Drawing.Point(73, 300);
            this.Mat_Khau_Text.Margin = new System.Windows.Forms.Padding(4);
            this.Mat_Khau_Text.MaxLength = 32767;
            this.Mat_Khau_Text.Name = "Mat_Khau_Text";
            this.Mat_Khau_Text.Size = new System.Drawing.Size(264, 33);
            this.Mat_Khau_Text.TabIndex = 8;
            this.Mat_Khau_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // remember_password_check
            // 
            this.remember_password_check.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.remember_password_check.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.remember_password_check.ChechedOffColor = System.Drawing.Color.DeepSkyBlue;
            this.remember_password_check.Checked = false;
            this.remember_password_check.CheckedOnColor = System.Drawing.Color.DeepSkyBlue;
            this.remember_password_check.ForeColor = System.Drawing.Color.White;
            this.remember_password_check.Location = new System.Drawing.Point(73, 360);
            this.remember_password_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.remember_password_check.Name = "remember_password_check";
            this.remember_password_check.Size = new System.Drawing.Size(20, 20);
            this.remember_password_check.TabIndex = 9;
            this.remember_password_check.OnChange += new System.EventHandler(this.remember_password_check_OnChange);
            // 
            // remember_password
            // 
            this.remember_password.AutoSize = true;
            this.remember_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.remember_password.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.remember_password.Location = new System.Drawing.Point(132, 360);
            this.remember_password.Name = "remember_password";
            this.remember_password.Size = new System.Drawing.Size(192, 24);
            this.remember_password.TabIndex = 10;
            this.remember_password.Text = "Remember Password";
            this.remember_password.Click += new System.EventHandler(this.remember_password_Click);
            // 
            // Facebook_icon
            // 
            this.Facebook_icon.Image = ((System.Drawing.Image)(resources.GetObject("Facebook_icon.Image")));
            this.Facebook_icon.ImageActive = null;
            this.Facebook_icon.Location = new System.Drawing.Point(89, 536);
            this.Facebook_icon.Name = "Facebook_icon";
            this.Facebook_icon.Size = new System.Drawing.Size(41, 38);
            this.Facebook_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Facebook_icon.TabIndex = 11;
            this.Facebook_icon.TabStop = false;
            this.Facebook_icon.Zoom = 10;
            this.Facebook_icon.Click += new System.EventHandler(this.facebook_icon_Click);
            // 
            // Google_icon
            // 
            this.Google_icon.Image = ((System.Drawing.Image)(resources.GetObject("Google_icon.Image")));
            this.Google_icon.ImageActive = null;
            this.Google_icon.Location = new System.Drawing.Point(149, 536);
            this.Google_icon.Name = "Google_icon";
            this.Google_icon.Size = new System.Drawing.Size(41, 38);
            this.Google_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Google_icon.TabIndex = 12;
            this.Google_icon.TabStop = false;
            this.Google_icon.Zoom = 10;
            this.Google_icon.Click += new System.EventHandler(this.google_icon_Click);
            // 
            // Twitter_icon
            // 
            this.Twitter_icon.Image = ((System.Drawing.Image)(resources.GetObject("Twitter_icon.Image")));
            this.Twitter_icon.ImageActive = null;
            this.Twitter_icon.Location = new System.Drawing.Point(206, 536);
            this.Twitter_icon.Name = "Twitter_icon";
            this.Twitter_icon.Size = new System.Drawing.Size(41, 38);
            this.Twitter_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Twitter_icon.TabIndex = 13;
            this.Twitter_icon.TabStop = false;
            this.Twitter_icon.Zoom = 10;
            // 
            // GitHub_icon
            // 
            this.GitHub_icon.Image = ((System.Drawing.Image)(resources.GetObject("GitHub_icon.Image")));
            this.GitHub_icon.ImageActive = null;
            this.GitHub_icon.Location = new System.Drawing.Point(261, 536);
            this.GitHub_icon.Name = "GitHub_icon";
            this.GitHub_icon.Size = new System.Drawing.Size(41, 38);
            this.GitHub_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GitHub_icon.TabIndex = 14;
            this.GitHub_icon.TabStop = false;
            this.GitHub_icon.Zoom = 10;
            // 
            // BorderButton
            // 
            this.BorderButton.ElipseRadius = 15;
            this.BorderButton.TargetControl = this.sign_in_button;
            // 
            // sign_in_button
            // 
            this.sign_in_button.Active = false;
            this.sign_in_button.Activecolor = System.Drawing.Color.DeepSkyBlue;
            this.sign_in_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.sign_in_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sign_in_button.BorderRadius = 0;
            this.sign_in_button.ButtonText = "Sign In";
            this.sign_in_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sign_in_button.DisabledColor = System.Drawing.Color.Gray;
            this.sign_in_button.ForeColor = System.Drawing.Color.White;
            this.sign_in_button.Iconcolor = System.Drawing.Color.Transparent;
            this.sign_in_button.Iconimage = null;
            this.sign_in_button.Iconimage_right = null;
            this.sign_in_button.Iconimage_right_Selected = null;
            this.sign_in_button.Iconimage_Selected = null;
            this.sign_in_button.IconMarginLeft = 0;
            this.sign_in_button.IconMarginRight = 0;
            this.sign_in_button.IconRightVisible = true;
            this.sign_in_button.IconRightZoom = 0D;
            this.sign_in_button.IconVisible = true;
            this.sign_in_button.IconZoom = 90D;
            this.sign_in_button.IsTab = false;
            this.sign_in_button.Location = new System.Drawing.Point(39, 447);
            this.sign_in_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sign_in_button.Name = "sign_in_button";
            this.sign_in_button.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.sign_in_button.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.sign_in_button.OnHoverTextColor = System.Drawing.Color.White;
            this.sign_in_button.selected = false;
            this.sign_in_button.Size = new System.Drawing.Size(321, 43);
            this.sign_in_button.TabIndex = 15;
            this.sign_in_button.Text = "Sign In";
            this.sign_in_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sign_in_button.Textcolor = System.Drawing.Color.White;
            this.sign_in_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // Tai_Khoan_Text
            // 
            this.Tai_Khoan_Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Tai_Khoan_Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Tai_Khoan_Text.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Tai_Khoan_Text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tai_Khoan_Text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Tai_Khoan_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tai_Khoan_Text.HintForeColor = System.Drawing.Color.Empty;
            this.Tai_Khoan_Text.HintText = "Tên Đăng Nhập";
            this.Tai_Khoan_Text.isPassword = false;
            this.Tai_Khoan_Text.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.Tai_Khoan_Text.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.Tai_Khoan_Text.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.Tai_Khoan_Text.LineThickness = 3;
            this.Tai_Khoan_Text.Location = new System.Drawing.Point(73, 203);
            this.Tai_Khoan_Text.Margin = new System.Windows.Forms.Padding(4);
            this.Tai_Khoan_Text.MaxLength = 32767;
            this.Tai_Khoan_Text.Name = "Tai_Khoan_Text";
            this.Tai_Khoan_Text.Size = new System.Drawing.Size(264, 33);
            this.Tai_Khoan_Text.TabIndex = 7;
            this.Tai_Khoan_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PageLogin_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(399, 671);
            this.Controls.Add(this.sign_in_button);
            this.Controls.Add(this.GitHub_icon);
            this.Controls.Add(this.Twitter_icon);
            this.Controls.Add(this.Google_icon);
            this.Controls.Add(this.Facebook_icon);
            this.Controls.Add(this.remember_password);
            this.Controls.Add(this.remember_password_check);
            this.Controls.Add(this.Mat_Khau_Text);
            this.Controls.Add(this.Tai_Khoan_Text);
            this.Controls.Add(this.mat_khau);
            this.Controls.Add(this.tai_khoan);
            this.Controls.Add(this.sign_in);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageLogin_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageLogin";
            this.Load += new System.EventHandler(this.PageLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Facebook_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Google_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Twitter_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHub_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse BorderForm;
        private Bunifu.Framework.UI.BunifuDragControl DragForm;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Mat_Khau_Text;
        private System.Windows.Forms.Label mat_khau;
        private System.Windows.Forms.Label tai_khoan;
        private System.Windows.Forms.Label sign_in;
        private Bunifu.Framework.UI.BunifuCheckbox remember_password_check;
        private System.Windows.Forms.Label remember_password;
        private Bunifu.Framework.UI.BunifuImageButton GitHub_icon;
        private Bunifu.Framework.UI.BunifuImageButton Twitter_icon;
        private Bunifu.Framework.UI.BunifuImageButton Google_icon;
        private Bunifu.Framework.UI.BunifuImageButton Facebook_icon;
        private Bunifu.Framework.UI.BunifuElipse BorderButton;
        private Bunifu.Framework.UI.BunifuFlatButton sign_in_button;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Tai_Khoan_Text;
    }
}