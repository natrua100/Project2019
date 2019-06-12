namespace TakeCareOfPlants
{
    partial class UI_Calender
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Material_Title = new System.Windows.Forms.Label();
            this.Time_Title = new System.Windows.Forms.Label();
            this.Time_Pick = new Telerik.WinControls.UI.RadTimePicker();
            this.Note_Title = new System.Windows.Forms.Label();
            this.Note_Text = new Bunifu.Framework.BunifuCustomTextbox();
            this.List_Calender_DataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlantName_Title = new System.Windows.Forms.Label();
            this.List_Calender_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Create_Button = new System.Windows.Forms.Button();
            this.Create_Button_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PlantName_DropDown = new Telerik.WinControls.UI.RadCheckedDropDownList();
            this.object_6a402753_efe0_44cf_a82f_63d9c8b418a9 = new Telerik.WinControls.UI.RadDropDownListRootElement();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Update_Button_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Clear_Calender_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Material_DropDown = new Telerik.WinControls.UI.RadCheckedDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.Time_Pick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.List_Calender_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlantName_DropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Material_DropDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Material_Title
            // 
            this.Material_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Material_Title.AutoSize = true;
            this.Material_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Material_Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Material_Title.Location = new System.Drawing.Point(30, 120);
            this.Material_Title.Name = "Material_Title";
            this.Material_Title.Size = new System.Drawing.Size(87, 25);
            this.Material_Title.TabIndex = 16;
            this.Material_Title.Text = "Material:";
            // 
            // Time_Title
            // 
            this.Time_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Time_Title.AutoSize = true;
            this.Time_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Time_Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Time_Title.Location = new System.Drawing.Point(30, 28);
            this.Time_Title.Name = "Time_Title";
            this.Time_Title.Size = new System.Drawing.Size(62, 25);
            this.Time_Title.TabIndex = 22;
            this.Time_Title.Text = "Time:";
            // 
            // Time_Pick
            // 
            this.Time_Pick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Time_Pick.AutoSize = false;
            this.Time_Pick.BackColor = System.Drawing.Color.Transparent;
            this.Time_Pick.ClockPosition = Telerik.WinControls.UI.ClockPosition.HideClock;
            this.Time_Pick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Time_Pick.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Time_Pick.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Time_Pick.Location = new System.Drawing.Point(60, 56);
            this.Time_Pick.MaxValue = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Time_Pick.MinValue = new System.DateTime(((long)(0)));
            this.Time_Pick.Name = "Time_Pick";
            this.Time_Pick.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Time_Pick.Size = new System.Drawing.Size(356, 62);
            this.Time_Pick.Step = 30;
            this.Time_Pick.TabIndex = 26;
            this.Time_Pick.TabStop = false;
            this.Time_Pick.TimeTables = Telerik.WinControls.UI.TimeTables.HoursAndMinutesInOneTable;
            this.Time_Pick.Value = new System.DateTime(2019, 6, 10, 1, 39, 9, 549);
            ((Telerik.WinControls.UI.RadTimePickerElement)(this.Time_Pick.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            // 
            // Note_Title
            // 
            this.Note_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Note_Title.AutoSize = true;
            this.Note_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Note_Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Note_Title.Location = new System.Drawing.Point(30, 212);
            this.Note_Title.Name = "Note_Title";
            this.Note_Title.Size = new System.Drawing.Size(59, 25);
            this.Note_Title.TabIndex = 28;
            this.Note_Title.Text = "Note:";
            // 
            // Note_Text
            // 
            this.Note_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Note_Text.BackColor = System.Drawing.Color.White;
            this.Note_Text.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.Note_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Note_Text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Note_Text.Location = new System.Drawing.Point(60, 240);
            this.Note_Text.Multiline = true;
            this.Note_Text.Name = "Note_Text";
            this.Note_Text.Size = new System.Drawing.Size(356, 212);
            this.Note_Text.TabIndex = 27;
            // 
            // List_Calender_DataGrid
            // 
            this.List_Calender_DataGrid.AllowUserToAddRows = false;
            this.List_Calender_DataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.List_Calender_DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.List_Calender_DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.List_Calender_DataGrid.BackgroundColor = System.Drawing.Color.LightBlue;
            this.List_Calender_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List_Calender_DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.List_Calender_DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.List_Calender_DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.List_Calender_DataGrid.ColumnHeadersHeight = 30;
            this.List_Calender_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.List_Calender_DataGrid.DefaultCellStyle = dataGridViewCellStyle19;
            this.List_Calender_DataGrid.DoubleBuffered = true;
            this.List_Calender_DataGrid.EnableHeadersVisualStyles = false;
            this.List_Calender_DataGrid.HeaderBgColor = System.Drawing.Color.DeepSkyBlue;
            this.List_Calender_DataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.List_Calender_DataGrid.ImeMode = System.Windows.Forms.ImeMode.On;
            this.List_Calender_DataGrid.Location = new System.Drawing.Point(445, 90);
            this.List_Calender_DataGrid.Name = "List_Calender_DataGrid";
            this.List_Calender_DataGrid.ReadOnly = true;
            this.List_Calender_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.List_Calender_DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.List_Calender_DataGrid.RowHeadersVisible = false;
            this.List_Calender_DataGrid.RowTemplate.DividerHeight = 1;
            this.List_Calender_DataGrid.RowTemplate.Height = 30;
            this.List_Calender_DataGrid.RowTemplate.ReadOnly = true;
            this.List_Calender_DataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.List_Calender_DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.List_Calender_DataGrid.Size = new System.Drawing.Size(769, 395);
            this.List_Calender_DataGrid.TabIndex = 29;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column1.FillWeight = 30F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 55;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 86.92893F;
            this.Column2.HeaderText = "Thời Gian";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 86.92893F;
            this.Column3.HeaderText = "Vật Tư";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 86.92893F;
            this.Column4.HeaderText = "Đơn Vị Tính";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số Lượng";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ghi Chú";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // PlantName_Title
            // 
            this.PlantName_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlantName_Title.AutoSize = true;
            this.PlantName_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PlantName_Title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PlantName_Title.Location = new System.Drawing.Point(527, 28);
            this.PlantName_Title.Name = "PlantName_Title";
            this.PlantName_Title.Size = new System.Drawing.Size(62, 25);
            this.PlantName_Title.TabIndex = 30;
            this.PlantName_Title.Text = "Plant:";
            // 
            // List_Calender_Elipse
            // 
            this.List_Calender_Elipse.ElipseRadius = 10;
            this.List_Calender_Elipse.TargetControl = this.List_Calender_DataGrid;
            // 
            // Create_Button
            // 
            this.Create_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Create_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Create_Button.FlatAppearance.BorderSize = 0;
            this.Create_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Create_Button.ForeColor = System.Drawing.Color.Black;
            this.Create_Button.Location = new System.Drawing.Point(65, 511);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(167, 45);
            this.Create_Button.TabIndex = 32;
            this.Create_Button.Text = "New Calender";
            this.Create_Button.UseVisualStyleBackColor = false;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // Create_Button_Elipse
            // 
            this.Create_Button_Elipse.ElipseRadius = 20;
            this.Create_Button_Elipse.TargetControl = this.Create_Button;
            // 
            // PlantName_DropDown
            // 
            this.PlantName_DropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlantName_DropDown.AutoSize = false;
            this.PlantName_DropDown.BackColor = System.Drawing.Color.White;
            this.PlantName_DropDown.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.PlantName_DropDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlantName_DropDown.Location = new System.Drawing.Point(604, 24);
            this.PlantName_DropDown.Multiline = true;
            this.PlantName_DropDown.Name = "PlantName_DropDown";
            // 
            // 
            // 
            this.PlantName_DropDown.RootElement.ApplyShapeToControl = false;
            this.PlantName_DropDown.Size = new System.Drawing.Size(343, 51);
            this.PlantName_DropDown.TabIndex = 33;
            this.PlantName_DropDown.TextBlockFormatting += new Telerik.WinControls.UI.TextBlockFormattingEventHandler(this.PlantName_DropDown_TextBlockFormatting);
            this.PlantName_DropDown.VisualListItemFormatting += new Telerik.WinControls.UI.VisualListItemFormattingEventHandler(this.PlantName_DropDown_VisualListItemFormatting);
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.PlantName_DropDown.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.PlantName_DropDown.GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 15F);
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.PlantName_DropDown.GetChildAt(0))).CustomFont = "None";
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.PlantName_DropDown.GetChildAt(0))).CustomFontSize = 15F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.PlantName_DropDown.GetChildAt(0).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.UI.RadCheckedDropDownListEditableAreaElement)(this.PlantName_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 12F);
            ((Telerik.WinControls.UI.RadCheckedDropDownListEditableAreaElement)(this.PlantName_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(0))).CustomFontSize = 14F;
            ((Telerik.WinControls.UI.RadCheckedDropDownListEditableAreaElement)(this.PlantName_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.UI.RadCheckedDropDownListEditableAreaElement)(this.PlantName_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            // 
            // object_6a402753_efe0_44cf_a82f_63d9c8b418a9
            // 
            this.object_6a402753_efe0_44cf_a82f_63d9c8b418a9.ApplyShapeToControl = false;
            this.object_6a402753_efe0_44cf_a82f_63d9c8b418a9.Name = "object_6a402753_efe0_44cf_a82f_63d9c8b418a9";
            this.object_6a402753_efe0_44cf_a82f_63d9c8b418a9.StretchHorizontally = true;
            this.object_6a402753_efe0_44cf_a82f_63d9c8b418a9.StretchVertically = true;
            // 
            // Clear_Button
            // 
            this.Clear_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Clear_Button.FlatAppearance.BorderSize = 0;
            this.Clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Clear_Button.ForeColor = System.Drawing.Color.Black;
            this.Clear_Button.Location = new System.Drawing.Point(499, 511);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(173, 45);
            this.Clear_Button.TabIndex = 35;
            this.Clear_Button.TabStop = false;
            this.Clear_Button.Text = "Clear Calender";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Update_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Update_Button.FlatAppearance.BorderSize = 0;
            this.Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Update_Button.ForeColor = System.Drawing.Color.Black;
            this.Update_Button.Location = new System.Drawing.Point(278, 511);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(177, 45);
            this.Update_Button.TabIndex = 34;
            this.Update_Button.TabStop = false;
            this.Update_Button.Text = "Update Calender";
            this.Update_Button.UseVisualStyleBackColor = false;
            // 
            // Update_Button_Elipse
            // 
            this.Update_Button_Elipse.ElipseRadius = 20;
            this.Update_Button_Elipse.TargetControl = this.Update_Button;
            // 
            // Clear_Calender_Elipse
            // 
            this.Clear_Calender_Elipse.ElipseRadius = 20;
            this.Clear_Calender_Elipse.TargetControl = this.Clear_Button;
            // 
            // Material_DropDown
            // 
            this.Material_DropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Material_DropDown.AutoSize = false;
            this.Material_DropDown.BackColor = System.Drawing.Color.White;
            this.Material_DropDown.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Material_DropDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Material_DropDown.Location = new System.Drawing.Point(60, 148);
            this.Material_DropDown.Multiline = true;
            this.Material_DropDown.Name = "Material_DropDown";
            // 
            // 
            // 
            this.Material_DropDown.RootElement.ApplyShapeToControl = false;
            this.Material_DropDown.Size = new System.Drawing.Size(356, 62);
            this.Material_DropDown.TabIndex = 36;
            this.Material_DropDown.TextBlockFormatting += new Telerik.WinControls.UI.TextBlockFormattingEventHandler(this.Material_DropDown_TextBlockFormatting);
            this.Material_DropDown.ItemCheckedChanged += new Telerik.WinControls.UI.RadCheckedListDataItemEventHandler(this.Material_DropDown_ItemCheckedChanged);
            this.Material_DropDown.VisualListItemFormatting += new Telerik.WinControls.UI.VisualListItemFormattingEventHandler(this.Material_DropDown_VisualListItemFormatting);
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.Material_DropDown.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.Material_DropDown.GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 11F);
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.Material_DropDown.GetChildAt(0))).CustomFont = "None";
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.Material_DropDown.GetChildAt(0))).CustomFontSize = 12F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.Material_DropDown.GetChildAt(0).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.UI.RadCheckedDropDownListEditableAreaElement)(this.Material_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 12F);
            ((Telerik.WinControls.UI.RadCheckedDropDownListEditableAreaElement)(this.Material_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(0))).CustomFontSize = 14F;
            ((Telerik.WinControls.UI.RadCheckedDropDownListEditableAreaElement)(this.Material_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.UI.RadCheckedDropDownListEditableAreaElement)(this.Material_DropDown.GetChildAt(0).GetChildAt(2).GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            // 
            // UI_Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Material_DropDown);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.PlantName_DropDown);
            this.Controls.Add(this.Create_Button);
            this.Controls.Add(this.PlantName_Title);
            this.Controls.Add(this.List_Calender_DataGrid);
            this.Controls.Add(this.Note_Title);
            this.Controls.Add(this.Note_Text);
            this.Controls.Add(this.Time_Pick);
            this.Controls.Add(this.Time_Title);
            this.Controls.Add(this.Material_Title);
            this.Name = "UI_Calender";
            this.Size = new System.Drawing.Size(1254, 580);
            this.Load += new System.EventHandler(this.UI_Calender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Time_Pick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.List_Calender_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlantName_DropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Material_DropDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Material_Title;
        private System.Windows.Forms.Label Time_Title;
        private Telerik.WinControls.UI.RadTimePicker Time_Pick;
        private System.Windows.Forms.Label Note_Title;
        private Bunifu.Framework.BunifuCustomTextbox Note_Text;
        private Bunifu.Framework.UI.BunifuCustomDataGrid List_Calender_DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label PlantName_Title;
        private Bunifu.Framework.UI.BunifuElipse List_Calender_Elipse;
        private System.Windows.Forms.Button Create_Button;
        private Bunifu.Framework.UI.BunifuElipse Create_Button_Elipse;
        private Telerik.WinControls.UI.RadCheckedDropDownList PlantName_DropDown;
        private Telerik.WinControls.UI.RadDropDownListRootElement object_6a402753_efe0_44cf_a82f_63d9c8b418a9;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Update_Button;
        private Bunifu.Framework.UI.BunifuElipse Update_Button_Elipse;
        private Bunifu.Framework.UI.BunifuElipse Clear_Calender_Elipse;
        private Telerik.WinControls.UI.RadCheckedDropDownList Material_DropDown;
    }
}
