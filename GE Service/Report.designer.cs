namespace GE_Service
{
    partial class Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Report_Group = new System.Windows.Forms.GroupBox();
            this.Search_Btn = new System.Windows.Forms.Button();
            this.Print_Btn = new System.Windows.Forms.Button();
            this.Status_Txt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.To_Txt = new System.Windows.Forms.DateTimePicker();
            this.From_Txt = new System.Windows.Forms.DateTimePicker();
            this.Grid_Group = new System.Windows.Forms.GroupBox();
            this.Report_Grid = new System.Windows.Forms.DataGridView();
            this.nIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCustNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nItemDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSystemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSONumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_NotifyBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.GESet = new GE_Service.GEdataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.T_NotifyTabAd = new GE_Service.GEdataSetTableAdapters.T_NotificationTableAdapter();
            this.Report_Group.SuspendLayout();
            this.Grid_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_NotifyBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GESet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Report_Group
            // 
            this.Report_Group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Report_Group.BackColor = System.Drawing.Color.Transparent;
            this.Report_Group.Controls.Add(this.Search_Btn);
            this.Report_Group.Controls.Add(this.Print_Btn);
            this.Report_Group.Controls.Add(this.Status_Txt);
            this.Report_Group.Controls.Add(this.label2);
            this.Report_Group.Controls.Add(this.label3);
            this.Report_Group.Controls.Add(this.label1);
            this.Report_Group.Controls.Add(this.To_Txt);
            this.Report_Group.Controls.Add(this.From_Txt);
            this.Report_Group.ForeColor = System.Drawing.Color.Black;
            this.Report_Group.Location = new System.Drawing.Point(372, 3);
            this.Report_Group.Name = "Report_Group";
            this.Report_Group.Size = new System.Drawing.Size(278, 120);
            this.Report_Group.TabIndex = 0;
            this.Report_Group.TabStop = false;
            this.Report_Group.Text = "Report";
            // 
            // Search_Btn
            // 
            this.Search_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Search_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Search_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Search_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Search_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Btn.ForeColor = System.Drawing.Color.Black;
            this.Search_Btn.Image = global::GE_Service.Properties.Resources.Dark_Search_18;
            this.Search_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Search_Btn.Location = new System.Drawing.Point(142, 85);
            this.Search_Btn.Name = "Search_Btn";
            this.Search_Btn.Size = new System.Drawing.Size(70, 25);
            this.Search_Btn.TabIndex = 3;
            this.Search_Btn.Text = "Search";
            this.Search_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Search_Btn.UseVisualStyleBackColor = true;
            this.Search_Btn.Click += new System.EventHandler(this.Search_Btn_Click);
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
            this.Print_Btn.Image = global::GE_Service.Properties.Resources.Dark_Print_18;
            this.Print_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Print_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Print_Btn.Location = new System.Drawing.Point(66, 85);
            this.Print_Btn.Name = "Print_Btn";
            this.Print_Btn.Size = new System.Drawing.Size(70, 25);
            this.Print_Btn.TabIndex = 4;
            this.Print_Btn.Text = "Print";
            this.Print_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Print_Btn.UseVisualStyleBackColor = true;
            this.Print_Btn.Click += new System.EventHandler(this.Print_Btn_Click);
            // 
            // Status_Txt
            // 
            this.Status_Txt.BackColor = System.Drawing.Color.White;
            this.Status_Txt.ForeColor = System.Drawing.Color.Black;
            this.Status_Txt.FormattingEnabled = true;
            this.Status_Txt.Items.AddRange(new object[] {
            "Pending",
            "Solved",
            "Waiting"});
            this.Status_Txt.Location = new System.Drawing.Point(52, 52);
            this.Status_Txt.Name = "Status_Txt";
            this.Status_Txt.Size = new System.Drawing.Size(219, 23);
            this.Status_Txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "From:";
            // 
            // To_Txt
            // 
            this.To_Txt.CustomFormat = "yyyy/MM/dd";
            this.To_Txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.To_Txt.Location = new System.Drawing.Point(178, 24);
            this.To_Txt.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.To_Txt.Name = "To_Txt";
            this.To_Txt.Size = new System.Drawing.Size(93, 22);
            this.To_Txt.TabIndex = 1;
            this.To_Txt.Value = new System.DateTime(2020, 2, 5, 0, 0, 0, 0);
            // 
            // From_Txt
            // 
            this.From_Txt.CustomFormat = "yyyy/MM/dd";
            this.From_Txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.From_Txt.Location = new System.Drawing.Point(52, 24);
            this.From_Txt.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.From_Txt.Name = "From_Txt";
            this.From_Txt.Size = new System.Drawing.Size(93, 22);
            this.From_Txt.TabIndex = 0;
            this.From_Txt.Value = new System.DateTime(2020, 2, 5, 0, 0, 0, 0);
            // 
            // Grid_Group
            // 
            this.Grid_Group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Grid_Group.BackColor = System.Drawing.Color.Transparent;
            this.Grid_Group.Controls.Add(this.Report_Grid);
            this.Grid_Group.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_Group.ForeColor = System.Drawing.Color.Black;
            this.Grid_Group.Location = new System.Drawing.Point(1, 137);
            this.Grid_Group.Margin = new System.Windows.Forms.Padding(2);
            this.Grid_Group.Name = "Grid_Group";
            this.Grid_Group.Padding = new System.Windows.Forms.Padding(2);
            this.Grid_Group.Size = new System.Drawing.Size(1020, 442);
            this.Grid_Group.TabIndex = 1;
            this.Grid_Group.TabStop = false;
            // 
            // Report_Grid
            // 
            this.Report_Grid.AllowUserToAddRows = false;
            this.Report_Grid.AllowUserToDeleteRows = false;
            this.Report_Grid.AllowUserToResizeColumns = false;
            this.Report_Grid.AllowUserToResizeRows = false;
            this.Report_Grid.AutoGenerateColumns = false;
            this.Report_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Report_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Report_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Report_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Report_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Report_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIDDataGridViewTextBoxColumn,
            this.nCustNameDataGridViewTextBoxColumn,
            this.nItemNameDataGridViewTextBoxColumn,
            this.nModelDataGridViewTextBoxColumn,
            this.nItemDesDataGridViewTextBoxColumn,
            this.nSystemIDDataGridViewTextBoxColumn,
            this.nSONumDataGridViewTextBoxColumn,
            this.nDateDataGridViewTextBoxColumn,
            this.nStatusDataGridViewTextBoxColumn});
            this.Report_Grid.DataSource = this.T_NotifyBindSour;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Report_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Report_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Report_Grid.EnableHeadersVisualStyles = false;
            this.Report_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Report_Grid.Location = new System.Drawing.Point(2, 17);
            this.Report_Grid.MultiSelect = false;
            this.Report_Grid.Name = "Report_Grid";
            this.Report_Grid.ReadOnly = true;
            this.Report_Grid.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Report_Grid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Report_Grid.RowTemplate.DividerHeight = 4;
            this.Report_Grid.RowTemplate.Height = 25;
            this.Report_Grid.RowTemplate.ReadOnly = true;
            this.Report_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Report_Grid.ShowCellErrors = false;
            this.Report_Grid.ShowCellToolTips = false;
            this.Report_Grid.ShowEditingIcon = false;
            this.Report_Grid.ShowRowErrors = false;
            this.Report_Grid.Size = new System.Drawing.Size(1016, 423);
            this.Report_Grid.TabIndex = 2;
            // 
            // nIDDataGridViewTextBoxColumn
            // 
            this.nIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nIDDataGridViewTextBoxColumn.DataPropertyName = "N_ID";
            this.nIDDataGridViewTextBoxColumn.FillWeight = 67.87527F;
            this.nIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.nIDDataGridViewTextBoxColumn.Name = "nIDDataGridViewTextBoxColumn";
            this.nIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.nIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // nCustNameDataGridViewTextBoxColumn
            // 
            this.nCustNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nCustNameDataGridViewTextBoxColumn.DataPropertyName = "N_CustName";
            this.nCustNameDataGridViewTextBoxColumn.FillWeight = 67.87527F;
            this.nCustNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.nCustNameDataGridViewTextBoxColumn.Name = "nCustNameDataGridViewTextBoxColumn";
            this.nCustNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nItemNameDataGridViewTextBoxColumn
            // 
            this.nItemNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nItemNameDataGridViewTextBoxColumn.DataPropertyName = "N_ItemName";
            this.nItemNameDataGridViewTextBoxColumn.FillWeight = 67.87527F;
            this.nItemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.nItemNameDataGridViewTextBoxColumn.Name = "nItemNameDataGridViewTextBoxColumn";
            this.nItemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nItemNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // nModelDataGridViewTextBoxColumn
            // 
            this.nModelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nModelDataGridViewTextBoxColumn.DataPropertyName = "N_Model";
            this.nModelDataGridViewTextBoxColumn.FillWeight = 67.87527F;
            this.nModelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.nModelDataGridViewTextBoxColumn.Name = "nModelDataGridViewTextBoxColumn";
            this.nModelDataGridViewTextBoxColumn.ReadOnly = true;
            this.nModelDataGridViewTextBoxColumn.Width = 120;
            // 
            // nItemDesDataGridViewTextBoxColumn
            // 
            this.nItemDesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nItemDesDataGridViewTextBoxColumn.DataPropertyName = "N_ItemDes";
            this.nItemDesDataGridViewTextBoxColumn.FillWeight = 67.87527F;
            this.nItemDesDataGridViewTextBoxColumn.HeaderText = "Item Description";
            this.nItemDesDataGridViewTextBoxColumn.Name = "nItemDesDataGridViewTextBoxColumn";
            this.nItemDesDataGridViewTextBoxColumn.ReadOnly = true;
            this.nItemDesDataGridViewTextBoxColumn.Width = 130;
            // 
            // nSystemIDDataGridViewTextBoxColumn
            // 
            this.nSystemIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nSystemIDDataGridViewTextBoxColumn.DataPropertyName = "N_SystemID";
            this.nSystemIDDataGridViewTextBoxColumn.FillWeight = 67.87527F;
            this.nSystemIDDataGridViewTextBoxColumn.HeaderText = "System ID";
            this.nSystemIDDataGridViewTextBoxColumn.Name = "nSystemIDDataGridViewTextBoxColumn";
            this.nSystemIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.nSystemIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // nSONumDataGridViewTextBoxColumn
            // 
            this.nSONumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nSONumDataGridViewTextBoxColumn.DataPropertyName = "N_SONum";
            this.nSONumDataGridViewTextBoxColumn.FillWeight = 67.87527F;
            this.nSONumDataGridViewTextBoxColumn.HeaderText = "S/O Number";
            this.nSONumDataGridViewTextBoxColumn.Name = "nSONumDataGridViewTextBoxColumn";
            this.nSONumDataGridViewTextBoxColumn.ReadOnly = true;
            this.nSONumDataGridViewTextBoxColumn.Width = 110;
            // 
            // nDateDataGridViewTextBoxColumn
            // 
            this.nDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nDateDataGridViewTextBoxColumn.DataPropertyName = "N_Date";
            this.nDateDataGridViewTextBoxColumn.FillWeight = 324.8731F;
            this.nDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.nDateDataGridViewTextBoxColumn.Name = "nDateDataGridViewTextBoxColumn";
            this.nDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.nDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // nStatusDataGridViewTextBoxColumn
            // 
            this.nStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nStatusDataGridViewTextBoxColumn.DataPropertyName = "N_Status";
            this.nStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.nStatusDataGridViewTextBoxColumn.Name = "nStatusDataGridViewTextBoxColumn";
            this.nStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.nStatusDataGridViewTextBoxColumn.Visible = false;
            this.nStatusDataGridViewTextBoxColumn.Width = 80;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.Report_Group);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 132);
            this.panel1.TabIndex = 0;
            // 
            // T_NotifyTabAd
            // 
            this.T_NotifyTabAd.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1022, 616);
            this.Controls.Add(this.Grid_Group);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1022, 600);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmReport";
            this.Load += new System.EventHandler(this.Search_Load);
            this.Report_Group.ResumeLayout(false);
            this.Report_Group.PerformLayout();
            this.Grid_Group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Report_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_NotifyBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GESet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Report_Group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker To_Txt;
        private System.Windows.Forms.DateTimePicker From_Txt;
        private System.Windows.Forms.ComboBox Status_Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Print_Btn;
        private System.Windows.Forms.Button Search_Btn;
        private System.Windows.Forms.GroupBox Grid_Group;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Report_Grid;
        private GEdataSet GESet;
        private System.Windows.Forms.BindingSource T_NotifyBindSour;
        private GEdataSetTableAdapters.T_NotificationTableAdapter T_NotifyTabAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCustNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nItemDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSystemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSONumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nStatusDataGridViewTextBoxColumn;
    }
}