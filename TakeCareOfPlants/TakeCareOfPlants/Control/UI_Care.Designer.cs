namespace TakeCareOfPlants
{
    partial class UI_Care
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
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Get_All_Button = new System.Windows.Forms.Button();
            this.Create_Button = new System.Windows.Forms.Button();
            this.List_Calender_DataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Calender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Create_Button_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Get_Button_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.List_Calender_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.List_Calender_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Get_All_Button
            // 
            this.Get_All_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Get_All_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Get_All_Button.FlatAppearance.BorderSize = 0;
            this.Get_All_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Get_All_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Get_All_Button.ForeColor = System.Drawing.Color.White;
            this.Get_All_Button.Location = new System.Drawing.Point(730, 516);
            this.Get_All_Button.Name = "Get_All_Button";
            this.Get_All_Button.Size = new System.Drawing.Size(173, 45);
            this.Get_All_Button.TabIndex = 49;
            this.Get_All_Button.TabStop = false;
            this.Get_All_Button.Text = "All Calender";
            this.Get_All_Button.UseVisualStyleBackColor = false;
            this.Get_All_Button.Click += new System.EventHandler(this.Get_All_Button_Click);
            // 
            // Create_Button
            // 
            this.Create_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Create_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Create_Button.FlatAppearance.BorderSize = 0;
            this.Create_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Create_Button.ForeColor = System.Drawing.Color.White;
            this.Create_Button.Location = new System.Drawing.Point(282, 516);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(167, 45);
            this.Create_Button.TabIndex = 48;
            this.Create_Button.Text = "New Calender";
            this.Create_Button.UseVisualStyleBackColor = false;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // List_Calender_DataGrid
            // 
            this.List_Calender_DataGrid.AllowUserToAddRows = false;
            this.List_Calender_DataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.List_Calender_DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.List_Calender_DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List_Calender_DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.List_Calender_DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.List_Calender_DataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.List_Calender_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List_Calender_DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.List_Calender_DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.List_Calender_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_Calender_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Date_Calender,
            this.Time,
            this.Material,
            this.Unit,
            this.Amount,
            this.Note});
            this.List_Calender_DataGrid.DoubleBuffered = true;
            this.List_Calender_DataGrid.EnableHeadersVisualStyles = false;
            this.List_Calender_DataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.List_Calender_DataGrid.HeaderBgColor = System.Drawing.Color.DeepSkyBlue;
            this.List_Calender_DataGrid.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.List_Calender_DataGrid.Location = new System.Drawing.Point(19, 19);
            this.List_Calender_DataGrid.MultiSelect = false;
            this.List_Calender_DataGrid.Name = "List_Calender_DataGrid";
            this.List_Calender_DataGrid.ReadOnly = true;
            this.List_Calender_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.List_Calender_DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.List_Calender_DataGrid.RowHeadersVisible = false;
            this.List_Calender_DataGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.List_Calender_DataGrid.RowTemplate.Height = 24;
            this.List_Calender_DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.List_Calender_DataGrid.Size = new System.Drawing.Size(1216, 479);
            this.List_Calender_DataGrid.TabIndex = 47;
            this.List_Calender_DataGrid.TabStop = false;
            this.List_Calender_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.List_Calender_DataGrid_CellClick);
            this.List_Calender_DataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.List_Calender_DataGrid_CellFormatting);
            this.List_Calender_DataGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.List_Calender_DataGrid_CellPainting);
            // 
            // STT
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle3;
            this.STT.FillWeight = 35.533F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // Date_Calender
            // 
            this.Date_Calender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Date_Calender.DefaultCellStyle = dataGridViewCellStyle4;
            this.Date_Calender.FillWeight = 110.7445F;
            this.Date_Calender.HeaderText = "Ngày Lập Lịch";
            this.Date_Calender.Name = "Date_Calender";
            this.Date_Calender.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Time.FillWeight = 110.7445F;
            this.Time.HeaderText = "Thời Gian";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Material
            // 
            this.Material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Material.FillWeight = 110.7445F;
            this.Material.HeaderText = "Vật Tư";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Format = "G";
            dataGridViewCellStyle5.NullValue = null;
            this.Unit.DefaultCellStyle = dataGridViewCellStyle5;
            this.Unit.FillWeight = 110.7445F;
            this.Unit.HeaderText = "Đơn Vị";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle6;
            this.Amount.FillWeight = 110.7445F;
            this.Amount.HeaderText = "Số Lượng";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Format = "C0";
            dataGridViewCellStyle7.NullValue = null;
            this.Note.DefaultCellStyle = dataGridViewCellStyle7;
            this.Note.FillWeight = 110.7445F;
            this.Note.HeaderText = "Ghi Chú";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // Create_Button_Elipse
            // 
            this.Create_Button_Elipse.ElipseRadius = 20;
            this.Create_Button_Elipse.TargetControl = this.Create_Button;
            // 
            // Get_Button_Elipse
            // 
            this.Get_Button_Elipse.ElipseRadius = 20;
            this.Get_Button_Elipse.TargetControl = this.Get_All_Button;
            // 
            // List_Calender_Elipse
            // 
            this.List_Calender_Elipse.ElipseRadius = 10;
            this.List_Calender_Elipse.TargetControl = this.List_Calender_DataGrid;
            // 
            // UI_Care
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Get_All_Button);
            this.Controls.Add(this.Create_Button);
            this.Controls.Add(this.List_Calender_DataGrid);
            this.Name = "UI_Care";
            this.Size = new System.Drawing.Size(1254, 580);
            ((System.ComponentModel.ISupportInitialize)(this.List_Calender_DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Get_All_Button;
        private System.Windows.Forms.Button Create_Button;
        private Bunifu.Framework.UI.BunifuCustomDataGrid List_Calender_DataGrid;
        private Bunifu.Framework.UI.BunifuElipse Create_Button_Elipse;
        private Bunifu.Framework.UI.BunifuElipse Get_Button_Elipse;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Calender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private Bunifu.Framework.UI.BunifuElipse List_Calender_Elipse;
    }
}
