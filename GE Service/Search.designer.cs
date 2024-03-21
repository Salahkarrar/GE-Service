namespace GE_Service
{
    partial class Search
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
            this.Search_Group = new System.Windows.Forms.GroupBox();
            this.Search_Grid = new System.Windows.Forms.DataGridView();
            this.T_NotifyBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.gEdataSet = new GE_Service.GEdataSet();
            this.T_NotifyTabAd = new GE_Service.GEdataSetTableAdapters.T_NotificationTableAdapter();
            this.So = new System.Windows.Forms.Panel();
            this.Header_Pan = new System.Windows.Forms.Panel();
            this.SearchData_Group = new System.Windows.Forms.GroupBox();
            this.Search_Lab = new System.Windows.Forms.Label();
            this.Search_Txt = new System.Windows.Forms.TextBox();
            this.N_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nItemDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSystemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSONumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_NotifyBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gEdataSet)).BeginInit();
            this.Header_Pan.SuspendLayout();
            this.SearchData_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search_Group
            // 
            this.Search_Group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search_Group.BackColor = System.Drawing.Color.Transparent;
            this.Search_Group.Controls.Add(this.Search_Grid);
            this.Search_Group.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Group.ForeColor = System.Drawing.Color.Black;
            this.Search_Group.Location = new System.Drawing.Point(0, 59);
            this.Search_Group.Margin = new System.Windows.Forms.Padding(2);
            this.Search_Group.Name = "Search_Group";
            this.Search_Group.Padding = new System.Windows.Forms.Padding(2);
            this.Search_Group.Size = new System.Drawing.Size(1020, 541);
            this.Search_Group.TabIndex = 3;
            this.Search_Group.TabStop = false;
            this.Search_Group.Text = "Notifications List";
            // 
            // Search_Grid
            // 
            this.Search_Grid.AllowUserToAddRows = false;
            this.Search_Grid.AllowUserToDeleteRows = false;
            this.Search_Grid.AllowUserToResizeColumns = false;
            this.Search_Grid.AllowUserToResizeRows = false;
            this.Search_Grid.AutoGenerateColumns = false;
            this.Search_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Search_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Search_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Search_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Search_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Search_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_ID,
            this.nItemNameDataGridViewTextBoxColumn,
            this.nModelDataGridViewTextBoxColumn,
            this.nItemDesDataGridViewTextBoxColumn,
            this.nSystemIDDataGridViewTextBoxColumn,
            this.nSONumDataGridViewTextBoxColumn,
            this.nDateDataGridViewTextBoxColumn,
            this.nStatusDataGridViewTextBoxColumn});
            this.Search_Grid.DataSource = this.T_NotifyBindSour;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Search_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Search_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Search_Grid.EnableHeadersVisualStyles = false;
            this.Search_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Search_Grid.Location = new System.Drawing.Point(2, 21);
            this.Search_Grid.MultiSelect = false;
            this.Search_Grid.Name = "Search_Grid";
            this.Search_Grid.ReadOnly = true;
            this.Search_Grid.RowHeadersVisible = false;
            this.Search_Grid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Search_Grid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Search_Grid.RowTemplate.DividerHeight = 4;
            this.Search_Grid.RowTemplate.Height = 25;
            this.Search_Grid.RowTemplate.ReadOnly = true;
            this.Search_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Search_Grid.ShowCellErrors = false;
            this.Search_Grid.ShowCellToolTips = false;
            this.Search_Grid.ShowEditingIcon = false;
            this.Search_Grid.ShowRowErrors = false;
            this.Search_Grid.Size = new System.Drawing.Size(1016, 518);
            this.Search_Grid.TabIndex = 1;
            this.Search_Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Search_Grid_CellDoubleClick);
            // 
            // T_NotifyBindSour
            // 
            this.T_NotifyBindSour.DataMember = "T_Notification";
            this.T_NotifyBindSour.DataSource = this.gEdataSet;
            // 
            // gEdataSet
            // 
            this.gEdataSet.DataSetName = "GEdataSet";
            this.gEdataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // T_NotifyTabAd
            // 
            this.T_NotifyTabAd.ClearBeforeFill = true;
            // 
            // So
            // 
            this.So.Location = new System.Drawing.Point(375, 144);
            this.So.Name = "So";
            this.So.Size = new System.Drawing.Size(200, 80);
            this.So.TabIndex = 8;
            // 
            // Header_Pan
            // 
            this.Header_Pan.Controls.Add(this.SearchData_Group);
            this.Header_Pan.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Pan.Location = new System.Drawing.Point(0, 0);
            this.Header_Pan.Name = "Header_Pan";
            this.Header_Pan.Size = new System.Drawing.Size(1020, 54);
            this.Header_Pan.TabIndex = 7;
            // 
            // SearchData_Group
            // 
            this.SearchData_Group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchData_Group.Controls.Add(this.Search_Lab);
            this.SearchData_Group.Controls.Add(this.Search_Txt);
            this.SearchData_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchData_Group.Location = new System.Drawing.Point(375, 4);
            this.SearchData_Group.Name = "SearchData_Group";
            this.SearchData_Group.Size = new System.Drawing.Size(270, 47);
            this.SearchData_Group.TabIndex = 8;
            this.SearchData_Group.TabStop = false;
            // 
            // Search_Lab
            // 
            this.Search_Lab.ForeColor = System.Drawing.Color.Black;
            this.Search_Lab.Location = new System.Drawing.Point(5, 18);
            this.Search_Lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Search_Lab.Name = "Search_Lab";
            this.Search_Lab.Size = new System.Drawing.Size(46, 15);
            this.Search_Lab.TabIndex = 5;
            this.Search_Lab.Text = "Search:";
            // 
            // Search_Txt
            // 
            this.Search_Txt.BackColor = System.Drawing.SystemColors.Window;
            this.Search_Txt.ForeColor = System.Drawing.Color.Black;
            this.Search_Txt.Location = new System.Drawing.Point(55, 15);
            this.Search_Txt.Margin = new System.Windows.Forms.Padding(2);
            this.Search_Txt.Name = "Search_Txt";
            this.Search_Txt.Size = new System.Drawing.Size(209, 26);
            this.Search_Txt.TabIndex = 6;
            this.Search_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_Txt_KeyDown);
            // 
            // N_ID
            // 
            this.N_ID.DataPropertyName = "N_ID";
            this.N_ID.HeaderText = "N_ID";
            this.N_ID.MinimumWidth = 6;
            this.N_ID.Name = "N_ID";
            this.N_ID.ReadOnly = true;
            this.N_ID.Visible = false;
            // 
            // nItemNameDataGridViewTextBoxColumn
            // 
            this.nItemNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nItemNameDataGridViewTextBoxColumn.DataPropertyName = "N_ItemName";
            this.nItemNameDataGridViewTextBoxColumn.FillWeight = 42.22973F;
            this.nItemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.nItemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nItemNameDataGridViewTextBoxColumn.Name = "nItemNameDataGridViewTextBoxColumn";
            this.nItemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nModelDataGridViewTextBoxColumn
            // 
            this.nModelDataGridViewTextBoxColumn.DataPropertyName = "N_Model";
            this.nModelDataGridViewTextBoxColumn.FillWeight = 42.22973F;
            this.nModelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.nModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nModelDataGridViewTextBoxColumn.Name = "nModelDataGridViewTextBoxColumn";
            this.nModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nItemDesDataGridViewTextBoxColumn
            // 
            this.nItemDesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nItemDesDataGridViewTextBoxColumn.DataPropertyName = "N_ItemDes";
            this.nItemDesDataGridViewTextBoxColumn.FillWeight = 42.22973F;
            this.nItemDesDataGridViewTextBoxColumn.HeaderText = "Item Descrpition";
            this.nItemDesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nItemDesDataGridViewTextBoxColumn.Name = "nItemDesDataGridViewTextBoxColumn";
            this.nItemDesDataGridViewTextBoxColumn.ReadOnly = true;
            this.nItemDesDataGridViewTextBoxColumn.Width = 130;
            // 
            // nSystemIDDataGridViewTextBoxColumn
            // 
            this.nSystemIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nSystemIDDataGridViewTextBoxColumn.DataPropertyName = "N_SystemID";
            this.nSystemIDDataGridViewTextBoxColumn.FillWeight = 229.7297F;
            this.nSystemIDDataGridViewTextBoxColumn.HeaderText = "System ID";
            this.nSystemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nSystemIDDataGridViewTextBoxColumn.Name = "nSystemIDDataGridViewTextBoxColumn";
            this.nSystemIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.nSystemIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // nSONumDataGridViewTextBoxColumn
            // 
            this.nSONumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nSONumDataGridViewTextBoxColumn.DataPropertyName = "N_SONum";
            this.nSONumDataGridViewTextBoxColumn.FillWeight = 143.5811F;
            this.nSONumDataGridViewTextBoxColumn.HeaderText = "S/O Number";
            this.nSONumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nSONumDataGridViewTextBoxColumn.Name = "nSONumDataGridViewTextBoxColumn";
            this.nSONumDataGridViewTextBoxColumn.ReadOnly = true;
            this.nSONumDataGridViewTextBoxColumn.Width = 110;
            // 
            // nDateDataGridViewTextBoxColumn
            // 
            this.nDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nDateDataGridViewTextBoxColumn.DataPropertyName = "N_Date";
            this.nDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.nDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nDateDataGridViewTextBoxColumn.Name = "nDateDataGridViewTextBoxColumn";
            this.nDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.nDateDataGridViewTextBoxColumn.Width = 77;
            // 
            // nStatusDataGridViewTextBoxColumn
            // 
            this.nStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nStatusDataGridViewTextBoxColumn.DataPropertyName = "N_Status";
            this.nStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.nStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nStatusDataGridViewTextBoxColumn.Name = "nStatusDataGridViewTextBoxColumn";
            this.nStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.nStatusDataGridViewTextBoxColumn.Width = 80;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1020, 600);
            this.Controls.Add(this.Search_Group);
            this.Controls.Add(this.Header_Pan);
            this.Controls.Add(this.So);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1020, 600);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSearch";
            this.Load += new System.EventHandler(this.Search_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_Txt_KeyDown);
            this.Search_Group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Search_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_NotifyBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gEdataSet)).EndInit();
            this.Header_Pan.ResumeLayout(false);
            this.SearchData_Group.ResumeLayout(false);
            this.SearchData_Group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Search_Group;
        private GEdataSet gEdataSet;
        private System.Windows.Forms.BindingSource T_NotifyBindSour;
        private GEdataSetTableAdapters.T_NotificationTableAdapter T_NotifyTabAd;
        private System.Windows.Forms.DataGridView Search_Grid;
        private System.Windows.Forms.Panel So;
        private System.Windows.Forms.Panel Header_Pan;
        private System.Windows.Forms.GroupBox SearchData_Group;
        private System.Windows.Forms.Label Search_Lab;
        private System.Windows.Forms.TextBox Search_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nItemDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSystemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSONumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nStatusDataGridViewTextBoxColumn;
    }
}