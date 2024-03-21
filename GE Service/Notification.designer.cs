namespace GE_Service
{
    partial class Notification
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SystemInfo_Group = new System.Windows.Forms.GroupBox();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Print_Btn = new System.Windows.Forms.Button();
            this.ID_Lab = new System.Windows.Forms.Label();
            this.CustomerName_Lab = new System.Windows.Forms.Label();
            this.Status_Lab = new System.Windows.Forms.Label();
            this.SystemID_Lab = new System.Windows.Forms.Label();
            this.ItemDes_Txt = new System.Windows.Forms.TextBox();
            this.T_NotifyBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.GESet = new GE_Service.GEdataSet();
            this.Name_Lab = new System.Windows.Forms.Label();
            this.Status_Txt = new System.Windows.Forms.ComboBox();
            this.SysName_Lab = new System.Windows.Forms.Label();
            this.SystemID_Txt = new System.Windows.Forms.TextBox();
            this.Date_Lab = new System.Windows.Forms.Label();
            this.ID_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Model_Txt = new System.Windows.Forms.TextBox();
            this.SONumber_Lab = new System.Windows.Forms.Label();
            this.CustomerName_Txt = new System.Windows.Forms.TextBox();
            this.Date_Txt = new System.Windows.Forms.DateTimePicker();
            this.SONumber_Txt = new System.Windows.Forms.TextBox();
            this.New_Btn = new System.Windows.Forms.Button();
            this.ItemName_Txt = new System.Windows.Forms.ComboBox();
            this.T_SysBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.ContactNumber_Lab = new System.Windows.Forms.Label();
            this.ContactNumber_Txt = new System.Windows.Forms.TextBox();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Details_Lab = new System.Windows.Forms.Label();
            this.Details_Txt = new System.Windows.Forms.RichTextBox();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SysList_Grid = new System.Windows.Forms.DataGridView();
            this.nItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_SysTabAd = new GE_Service.GEdataSetTableAdapters.T_SystemTableAdapter();
            this.T_NotifyTabAd = new GE_Service.GEdataSetTableAdapters.T_NotificationTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.I_Txt = new System.Windows.Forms.TextBox();
            this.SystemInfo_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_NotifyBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GESet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_SysBindSour)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SysList_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // SystemInfo_Group
            // 
            this.SystemInfo_Group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SystemInfo_Group.BackColor = System.Drawing.Color.Transparent;
            this.SystemInfo_Group.Controls.Add(this.Delete_Btn);
            this.SystemInfo_Group.Controls.Add(this.Print_Btn);
            this.SystemInfo_Group.Controls.Add(this.ID_Lab);
            this.SystemInfo_Group.Controls.Add(this.CustomerName_Lab);
            this.SystemInfo_Group.Controls.Add(this.Status_Lab);
            this.SystemInfo_Group.Controls.Add(this.SystemID_Lab);
            this.SystemInfo_Group.Controls.Add(this.ItemDes_Txt);
            this.SystemInfo_Group.Controls.Add(this.Name_Lab);
            this.SystemInfo_Group.Controls.Add(this.Status_Txt);
            this.SystemInfo_Group.Controls.Add(this.SysName_Lab);
            this.SystemInfo_Group.Controls.Add(this.SystemID_Txt);
            this.SystemInfo_Group.Controls.Add(this.Date_Lab);
            this.SystemInfo_Group.Controls.Add(this.ID_Txt);
            this.SystemInfo_Group.Controls.Add(this.label1);
            this.SystemInfo_Group.Controls.Add(this.Model_Txt);
            this.SystemInfo_Group.Controls.Add(this.SONumber_Lab);
            this.SystemInfo_Group.Controls.Add(this.CustomerName_Txt);
            this.SystemInfo_Group.Controls.Add(this.Date_Txt);
            this.SystemInfo_Group.Controls.Add(this.SONumber_Txt);
            this.SystemInfo_Group.Controls.Add(this.New_Btn);
            this.SystemInfo_Group.Controls.Add(this.ItemName_Txt);
            this.SystemInfo_Group.Controls.Add(this.ContactNumber_Lab);
            this.SystemInfo_Group.Controls.Add(this.ContactNumber_Txt);
            this.SystemInfo_Group.Controls.Add(this.Edit_Btn);
            this.SystemInfo_Group.Controls.Add(this.Cancel_Btn);
            this.SystemInfo_Group.Controls.Add(this.Details_Lab);
            this.SystemInfo_Group.Controls.Add(this.Details_Txt);
            this.SystemInfo_Group.Controls.Add(this.Save_Btn);
            this.SystemInfo_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemInfo_Group.ForeColor = System.Drawing.Color.Black;
            this.SystemInfo_Group.Location = new System.Drawing.Point(248, 0);
            this.SystemInfo_Group.Name = "SystemInfo_Group";
            this.SystemInfo_Group.Size = new System.Drawing.Size(760, 615);
            this.SystemInfo_Group.TabIndex = 0;
            this.SystemInfo_Group.TabStop = false;
            this.SystemInfo_Group.Text = "System Info";
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Delete_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Delete_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Delete_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Btn.ForeColor = System.Drawing.Color.Black;
            this.Delete_Btn.Image = global::GE_Service.Properties.Resources.Dark_Delete_18;
            this.Delete_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Delete_Btn.Location = new System.Drawing.Point(661, 567);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(70, 25);
            this.Delete_Btn.TabIndex = 15;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Print_Btn
            // 
            this.Print_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Print_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Print_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Print_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Print_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_Btn.ForeColor = System.Drawing.Color.Black;
            this.Print_Btn.Image = global::GE_Service.Properties.Resources.Dark_Folder_18;
            this.Print_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Print_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Print_Btn.Location = new System.Drawing.Point(485, 567);
            this.Print_Btn.Name = "Print_Btn";
            this.Print_Btn.Size = new System.Drawing.Size(70, 25);
            this.Print_Btn.TabIndex = 14;
            this.Print_Btn.Text = " PDF";
            this.Print_Btn.UseVisualStyleBackColor = true;
            this.Print_Btn.Click += new System.EventHandler(this.Print_Btn_Click);
            // 
            // ID_Lab
            // 
            this.ID_Lab.AutoSize = true;
            this.ID_Lab.ForeColor = System.Drawing.Color.Black;
            this.ID_Lab.Location = new System.Drawing.Point(110, 16);
            this.ID_Lab.Name = "ID_Lab";
            this.ID_Lab.Size = new System.Drawing.Size(31, 19);
            this.ID_Lab.TabIndex = 18;
            this.ID_Lab.Text = "ID:";
            // 
            // CustomerName_Lab
            // 
            this.CustomerName_Lab.AutoSize = true;
            this.CustomerName_Lab.ForeColor = System.Drawing.Color.Black;
            this.CustomerName_Lab.Location = new System.Drawing.Point(387, 16);
            this.CustomerName_Lab.Name = "CustomerName_Lab";
            this.CustomerName_Lab.Size = new System.Drawing.Size(125, 19);
            this.CustomerName_Lab.TabIndex = 13;
            this.CustomerName_Lab.Text = "Customer Name:";
            // 
            // Status_Lab
            // 
            this.Status_Lab.AutoSize = true;
            this.Status_Lab.ForeColor = System.Drawing.Color.Black;
            this.Status_Lab.Location = new System.Drawing.Point(437, 129);
            this.Status_Lab.Name = "Status_Lab";
            this.Status_Lab.Size = new System.Drawing.Size(55, 19);
            this.Status_Lab.TabIndex = 21;
            this.Status_Lab.Text = "Status:";
            // 
            // SystemID_Lab
            // 
            this.SystemID_Lab.AutoSize = true;
            this.SystemID_Lab.ForeColor = System.Drawing.Color.Black;
            this.SystemID_Lab.Location = new System.Drawing.Point(416, 101);
            this.SystemID_Lab.Name = "SystemID_Lab";
            this.SystemID_Lab.Size = new System.Drawing.Size(85, 19);
            this.SystemID_Lab.TabIndex = 13;
            this.SystemID_Lab.Text = "System ID:";
            // 
            // ItemDes_Txt
            // 
            this.ItemDes_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_NotifyBindSour, "N_ItemDes", true));
            this.ItemDes_Txt.Enabled = false;
            this.ItemDes_Txt.Location = new System.Drawing.Point(134, 98);
            this.ItemDes_Txt.Name = "ItemDes_Txt";
            this.ItemDes_Txt.ReadOnly = true;
            this.ItemDes_Txt.Size = new System.Drawing.Size(221, 26);
            this.ItemDes_Txt.TabIndex = 6;
            this.ItemDes_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_NotifyBindSour
            // 
            this.T_NotifyBindSour.DataMember = "T_Notification";
            this.T_NotifyBindSour.DataSource = this.GESet;
            // 
            // GESet
            // 
            this.GESet.DataSetName = "GEdataSet";
            this.GESet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Name_Lab
            // 
            this.Name_Lab.AutoSize = true;
            this.Name_Lab.ForeColor = System.Drawing.Color.Black;
            this.Name_Lab.Location = new System.Drawing.Point(61, 72);
            this.Name_Lab.Name = "Name_Lab";
            this.Name_Lab.Size = new System.Drawing.Size(89, 19);
            this.Name_Lab.TabIndex = 13;
            this.Name_Lab.Text = "Item Name:";
            // 
            // Status_Txt
            // 
            this.Status_Txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Status_Txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Status_Txt.BackColor = System.Drawing.SystemColors.Window;
            this.Status_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_NotifyBindSour, "N_Status", true));
            this.Status_Txt.Enabled = false;
            this.Status_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_Txt.ForeColor = System.Drawing.Color.Black;
            this.Status_Txt.Items.AddRange(new object[] {
            "Pending"});
            this.Status_Txt.Location = new System.Drawing.Point(486, 126);
            this.Status_Txt.Name = "Status_Txt";
            this.Status_Txt.Size = new System.Drawing.Size(245, 27);
            this.Status_Txt.TabIndex = 9;
            // 
            // SysName_Lab
            // 
            this.SysName_Lab.AutoSize = true;
            this.SysName_Lab.ForeColor = System.Drawing.Color.Black;
            this.SysName_Lab.Location = new System.Drawing.Point(29, 101);
            this.SysName_Lab.Name = "SysName_Lab";
            this.SysName_Lab.Size = new System.Drawing.Size(130, 19);
            this.SysName_Lab.TabIndex = 13;
            this.SysName_Lab.Text = "Item Description:";
            // 
            // SystemID_Txt
            // 
            this.SystemID_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_NotifyBindSour, "N_SystemID", true));
            this.SystemID_Txt.Enabled = false;
            this.SystemID_Txt.Location = new System.Drawing.Point(485, 98);
            this.SystemID_Txt.Name = "SystemID_Txt";
            this.SystemID_Txt.ReadOnly = true;
            this.SystemID_Txt.Size = new System.Drawing.Size(246, 26);
            this.SystemID_Txt.TabIndex = 7;
            this.SystemID_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Date_Lab
            // 
            this.Date_Lab.AutoSize = true;
            this.Date_Lab.ForeColor = System.Drawing.Color.Black;
            this.Date_Lab.Location = new System.Drawing.Point(446, 44);
            this.Date_Lab.Name = "Date_Lab";
            this.Date_Lab.Size = new System.Drawing.Size(46, 19);
            this.Date_Lab.TabIndex = 13;
            this.Date_Lab.Text = "Date:";
            // 
            // ID_Txt
            // 
            this.ID_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_NotifyBindSour, "N_ID", true));
            this.ID_Txt.Location = new System.Drawing.Point(134, 13);
            this.ID_Txt.Name = "ID_Txt";
            this.ID_Txt.ReadOnly = true;
            this.ID_Txt.Size = new System.Drawing.Size(221, 26);
            this.ID_Txt.TabIndex = 19;
            this.ID_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(436, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Model:";
            // 
            // Model_Txt
            // 
            this.Model_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_NotifyBindSour, "N_Model", true));
            this.Model_Txt.Enabled = false;
            this.Model_Txt.Location = new System.Drawing.Point(485, 69);
            this.Model_Txt.Name = "Model_Txt";
            this.Model_Txt.ReadOnly = true;
            this.Model_Txt.Size = new System.Drawing.Size(246, 26);
            this.Model_Txt.TabIndex = 5;
            this.Model_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SONumber_Lab
            // 
            this.SONumber_Lab.AutoSize = true;
            this.SONumber_Lab.ForeColor = System.Drawing.Color.Black;
            this.SONumber_Lab.Location = new System.Drawing.Point(56, 129);
            this.SONumber_Lab.Name = "SONumber_Lab";
            this.SONumber_Lab.Size = new System.Drawing.Size(99, 19);
            this.SONumber_Lab.TabIndex = 13;
            this.SONumber_Lab.Text = "S/O Number:";
            // 
            // CustomerName_Txt
            // 
            this.CustomerName_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_NotifyBindSour, "N_CustName", true));
            this.CustomerName_Txt.Location = new System.Drawing.Point(485, 13);
            this.CustomerName_Txt.MaxLength = 50;
            this.CustomerName_Txt.Name = "CustomerName_Txt";
            this.CustomerName_Txt.ReadOnly = true;
            this.CustomerName_Txt.Size = new System.Drawing.Size(246, 26);
            this.CustomerName_Txt.TabIndex = 1;
            this.CustomerName_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerName_Txt.Enter += new System.EventHandler(this.English_Enter);
            // 
            // Date_Txt
            // 
            this.Date_Txt.Checked = false;
            this.Date_Txt.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.Date_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_NotifyBindSour, "N_Date", true));
            this.Date_Txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_Txt.Location = new System.Drawing.Point(485, 41);
            this.Date_Txt.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.Date_Txt.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.Date_Txt.Name = "Date_Txt";
            this.Date_Txt.ShowCheckBox = true;
            this.Date_Txt.Size = new System.Drawing.Size(246, 26);
            this.Date_Txt.TabIndex = 3;
            // 
            // SONumber_Txt
            // 
            this.SONumber_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_NotifyBindSour, "N_SONum", true));
            this.SONumber_Txt.Enabled = false;
            this.SONumber_Txt.Location = new System.Drawing.Point(134, 126);
            this.SONumber_Txt.Name = "SONumber_Txt";
            this.SONumber_Txt.ReadOnly = true;
            this.SONumber_Txt.Size = new System.Drawing.Size(221, 26);
            this.SONumber_Txt.TabIndex = 8;
            this.SONumber_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // New_Btn
            // 
            this.New_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.New_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.New_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.New_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.New_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Btn.ForeColor = System.Drawing.Color.Black;
            this.New_Btn.Image = global::GE_Service.Properties.Resources.Dark_Add_18;
            this.New_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.New_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.New_Btn.Location = new System.Drawing.Point(134, 567);
            this.New_Btn.Name = "New_Btn";
            this.New_Btn.Size = new System.Drawing.Size(70, 25);
            this.New_Btn.TabIndex = 0;
            this.New_Btn.Text = "New";
            this.New_Btn.UseVisualStyleBackColor = true;
            this.New_Btn.Click += new System.EventHandler(this.New_Btn_Click);
            // 
            // ItemName_Txt
            // 
            this.ItemName_Txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ItemName_Txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ItemName_Txt.BackColor = System.Drawing.SystemColors.Window;
            this.ItemName_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_NotifyBindSour, "N_ItemName", true));
            this.ItemName_Txt.DataSource = this.T_SysBindSour;
            this.ItemName_Txt.DisplayMember = "S_ItemName";
            this.ItemName_Txt.Enabled = false;
            this.ItemName_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName_Txt.ForeColor = System.Drawing.Color.Black;
            this.ItemName_Txt.FormattingEnabled = true;
            this.ItemName_Txt.Location = new System.Drawing.Point(134, 69);
            this.ItemName_Txt.Name = "ItemName_Txt";
            this.ItemName_Txt.Size = new System.Drawing.Size(221, 27);
            this.ItemName_Txt.TabIndex = 4;
            this.ItemName_Txt.ValueMember = "S_ItemName";
            this.ItemName_Txt.SelectedIndexChanged += new System.EventHandler(this.Name_Txt_SelectionChangeCommitted);
            this.ItemName_Txt.SelectionChangeCommitted += new System.EventHandler(this.Name_Txt_SelectionChangeCommitted);
            // 
            // T_SysBindSour
            // 
            this.T_SysBindSour.DataMember = "T_System";
            this.T_SysBindSour.DataSource = this.GESet;
            // 
            // ContactNumber_Lab
            // 
            this.ContactNumber_Lab.AutoSize = true;
            this.ContactNumber_Lab.ForeColor = System.Drawing.Color.Black;
            this.ContactNumber_Lab.Location = new System.Drawing.Point(33, 44);
            this.ContactNumber_Lab.Name = "ContactNumber_Lab";
            this.ContactNumber_Lab.Size = new System.Drawing.Size(126, 19);
            this.ContactNumber_Lab.TabIndex = 15;
            this.ContactNumber_Lab.Text = "Contact Number:";
            // 
            // ContactNumber_Txt
            // 
            this.ContactNumber_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_NotifyBindSour, "N_ConNum", true));
            this.ContactNumber_Txt.Location = new System.Drawing.Point(134, 41);
            this.ContactNumber_Txt.MaxLength = 15;
            this.ContactNumber_Txt.Name = "ContactNumber_Txt";
            this.ContactNumber_Txt.ReadOnly = true;
            this.ContactNumber_Txt.Size = new System.Drawing.Size(221, 26);
            this.ContactNumber_Txt.TabIndex = 2;
            this.ContactNumber_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ContactNumber_Txt.Enter += new System.EventHandler(this.English_Enter);
            this.ContactNumber_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // Edit_Btn
            // 
            this.Edit_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Edit_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Edit_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Edit_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Edit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Btn.ForeColor = System.Drawing.Color.Black;
            this.Edit_Btn.Image = global::GE_Service.Properties.Resources.Dark_Edit_18;
            this.Edit_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Edit_Btn.Location = new System.Drawing.Point(286, 567);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(70, 25);
            this.Edit_Btn.TabIndex = 12;
            this.Edit_Btn.Text = "Edit";
            this.Edit_Btn.UseVisualStyleBackColor = true;
            this.Edit_Btn.Click += new System.EventHandler(this.Edit_Btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Cancel_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Cancel_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Cancel_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Btn.ForeColor = System.Drawing.Color.Black;
            this.Cancel_Btn.Image = global::GE_Service.Properties.Resources.Dark_Cancel_18;
            this.Cancel_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cancel_Btn.Location = new System.Drawing.Point(362, 567);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(70, 25);
            this.Cancel_Btn.TabIndex = 13;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // Details_Lab
            // 
            this.Details_Lab.AutoSize = true;
            this.Details_Lab.ForeColor = System.Drawing.Color.Black;
            this.Details_Lab.Location = new System.Drawing.Point(80, 165);
            this.Details_Lab.Name = "Details_Lab";
            this.Details_Lab.Size = new System.Drawing.Size(63, 19);
            this.Details_Lab.TabIndex = 15;
            this.Details_Lab.Text = "Details:";
            this.Details_Lab.Visible = false;
            // 
            // Details_Txt
            // 
            this.Details_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Details_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_NotifyBindSour, "N_Details", true));
            this.Details_Txt.Location = new System.Drawing.Point(134, 165);
            this.Details_Txt.Name = "Details_Txt";
            this.Details_Txt.ReadOnly = true;
            this.Details_Txt.Size = new System.Drawing.Size(597, 385);
            this.Details_Txt.TabIndex = 10;
            this.Details_Txt.Text = "";
            // 
            // Save_Btn
            // 
            this.Save_Btn.Enabled = false;
            this.Save_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Save_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Save_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Save_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Btn.ForeColor = System.Drawing.Color.Black;
            this.Save_Btn.Image = global::GE_Service.Properties.Resources.Dark_Save_18;
            this.Save_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Save_Btn.Location = new System.Drawing.Point(210, 567);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(70, 25);
            this.Save_Btn.TabIndex = 11;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.SysList_Grid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 615);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System List";
            // 
            // SysList_Grid
            // 
            this.SysList_Grid.AllowUserToAddRows = false;
            this.SysList_Grid.AllowUserToDeleteRows = false;
            this.SysList_Grid.AllowUserToResizeColumns = false;
            this.SysList_Grid.AllowUserToResizeRows = false;
            this.SysList_Grid.AutoGenerateColumns = false;
            this.SysList_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SysList_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.SysList_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SysList_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.SysList_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SysList_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nItemNameDataGridViewTextBoxColumn});
            this.SysList_Grid.DataSource = this.T_NotifyBindSour;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SysList_Grid.DefaultCellStyle = dataGridViewCellStyle26;
            this.SysList_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SysList_Grid.EnableHeadersVisualStyles = false;
            this.SysList_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.SysList_Grid.Location = new System.Drawing.Point(3, 22);
            this.SysList_Grid.MultiSelect = false;
            this.SysList_Grid.Name = "SysList_Grid";
            this.SysList_Grid.ReadOnly = true;
            this.SysList_Grid.RowHeadersVisible = false;
            this.SysList_Grid.RowHeadersWidth = 51;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            this.SysList_Grid.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.SysList_Grid.RowTemplate.DividerHeight = 4;
            this.SysList_Grid.RowTemplate.Height = 25;
            this.SysList_Grid.RowTemplate.ReadOnly = true;
            this.SysList_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SysList_Grid.ShowCellErrors = false;
            this.SysList_Grid.ShowCellToolTips = false;
            this.SysList_Grid.ShowEditingIcon = false;
            this.SysList_Grid.ShowRowErrors = false;
            this.SysList_Grid.Size = new System.Drawing.Size(242, 590);
            this.SysList_Grid.TabIndex = 1;
            // 
            // nItemNameDataGridViewTextBoxColumn
            // 
            this.nItemNameDataGridViewTextBoxColumn.DataPropertyName = "N_ItemName";
            this.nItemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.nItemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nItemNameDataGridViewTextBoxColumn.Name = "nItemNameDataGridViewTextBoxColumn";
            this.nItemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // T_SysTabAd
            // 
            this.T_SysTabAd.ClearBeforeFill = true;
            // 
            // T_NotifyTabAd
            // 
            this.T_NotifyTabAd.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(258, 617);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // I_Txt
            // 
            this.I_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_NotifyBindSour, "ID", true));
            this.I_Txt.Location = new System.Drawing.Point(400, 296);
            this.I_Txt.Name = "I_Txt";
            this.I_Txt.ReadOnly = true;
            this.I_Txt.Size = new System.Drawing.Size(221, 26);
            this.I_Txt.TabIndex = 20;
            this.I_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.I_Txt.Visible = false;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1020, 615);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SystemInfo_Group);
            this.Controls.Add(this.I_Txt);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1020, 600);
            this.Name = "Notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmNotification";
            this.Load += new System.EventHandler(this.Notification_Load);
            this.SystemInfo_Group.ResumeLayout(false);
            this.SystemInfo_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_NotifyBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GESet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_SysBindSour)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SysList_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox SystemInfo_Group;
        private System.Windows.Forms.Label CustomerName_Lab;
        private System.Windows.Forms.Label Name_Lab;
        private System.Windows.Forms.Label Date_Lab;
        private System.Windows.Forms.Button New_Btn;
        private System.Windows.Forms.Button Edit_Btn;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.ComboBox ItemName_Txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker Date_Txt;
        private System.Windows.Forms.Label Details_Lab;
        private System.Windows.Forms.Label ContactNumber_Lab;
        private System.Windows.Forms.Label SystemID_Lab;
        private System.Windows.Forms.Label SONumber_Lab;
        private System.Windows.Forms.TextBox CustomerName_Txt;
        private System.Windows.Forms.TextBox ContactNumber_Txt;
        private System.Windows.Forms.Label SysName_Lab;
        private System.Windows.Forms.TextBox SystemID_Txt;
        private System.Windows.Forms.TextBox SONumber_Txt;
        private System.Windows.Forms.TextBox ItemDes_Txt;
        private GEdataSet GESet;
        private System.Windows.Forms.BindingSource T_SysBindSour;
        private GEdataSetTableAdapters.T_SystemTableAdapter T_SysTabAd;
        private System.Windows.Forms.BindingSource T_NotifyBindSour;
        private GEdataSetTableAdapters.T_NotificationTableAdapter T_NotifyTabAd;
        private System.Windows.Forms.DataGridView SysList_Grid;
        private System.Windows.Forms.Button Print_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Model_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn nItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox ID_Txt;
        private System.Windows.Forms.Label ID_Lab;
        private System.Windows.Forms.Label Status_Lab;
        private System.Windows.Forms.ComboBox Status_Txt;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox I_Txt;
        private System.Windows.Forms.RichTextBox Details_Txt;
    }
}