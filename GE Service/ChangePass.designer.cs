namespace GE_Service
{
    partial class ChangePass
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
            this.PassWord = new System.Windows.Forms.TextBox();
            this.Passwor_label = new System.Windows.Forms.Label();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.New_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Confirm_Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserName_Txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PassWord
            // 
            this.PassWord.AcceptsReturn = true;
            this.PassWord.AcceptsTab = true;
            this.PassWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassWord.BackColor = System.Drawing.Color.White;
            this.PassWord.ForeColor = System.Drawing.Color.Black;
            this.PassWord.Location = new System.Drawing.Point(34, 40);
            this.PassWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PassWord.Name = "PassWord";
            this.PassWord.PasswordChar = '*';
            this.PassWord.Size = new System.Drawing.Size(244, 26);
            this.PassWord.TabIndex = 0;
            this.PassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassWord_KeyDown);
            // 
            // Passwor_label
            // 
            this.Passwor_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Passwor_label.AutoSize = true;
            this.Passwor_label.BackColor = System.Drawing.Color.Transparent;
            this.Passwor_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwor_label.ForeColor = System.Drawing.Color.Black;
            this.Passwor_label.Location = new System.Drawing.Point(105, 11);
            this.Passwor_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Passwor_label.Name = "Passwor_label";
            this.Passwor_label.Size = new System.Drawing.Size(113, 19);
            this.Passwor_label.TabIndex = 12;
            this.Passwor_label.Text = "Old Password";
            // 
            // Save_Btn
            // 
            this.Save_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Save_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Save_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Save_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Btn.ForeColor = System.Drawing.Color.Black;
            this.Save_Btn.Image = global::GE_Service.Properties.Resources.Dark_Save_18;
            this.Save_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_Btn.Location = new System.Drawing.Point(34, 289);
            this.Save_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(88, 38);
            this.Save_Btn.TabIndex = 2;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save_Btn.UseVisualStyleBackColor = false;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Exit_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Exit_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Exit_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Exit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Btn.ForeColor = System.Drawing.Color.Black;
            this.Exit_Btn.Image = global::GE_Service.Properties.Resources.Dark_Close_18;
            this.Exit_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_Btn.Location = new System.Drawing.Point(191, 289);
            this.Exit_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(88, 38);
            this.Exit_Btn.TabIndex = 3;
            this.Exit_Btn.Text = "Close";
            this.Exit_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exit_Btn.UseVisualStyleBackColor = false;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // New_Txt
            // 
            this.New_Txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.New_Txt.BackColor = System.Drawing.Color.White;
            this.New_Txt.ForeColor = System.Drawing.Color.Black;
            this.New_Txt.Location = new System.Drawing.Point(9, 112);
            this.New_Txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.New_Txt.Name = "New_Txt";
            this.New_Txt.PasswordChar = '*';
            this.New_Txt.Size = new System.Drawing.Size(244, 26);
            this.New_Txt.TabIndex = 1;
            this.New_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(79, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "New Password";
            // 
            // Confirm_Txt
            // 
            this.Confirm_Txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Confirm_Txt.BackColor = System.Drawing.Color.White;
            this.Confirm_Txt.ForeColor = System.Drawing.Color.Black;
            this.Confirm_Txt.Location = new System.Drawing.Point(9, 176);
            this.Confirm_Txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Confirm_Txt.Name = "Confirm_Txt";
            this.Confirm_Txt.PasswordChar = '*';
            this.Confirm_Txt.Size = new System.Drawing.Size(244, 26);
            this.Confirm_Txt.TabIndex = 2;
            this.Confirm_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Confirm Password";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Confirm_Txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.UserName_Txt);
            this.groupBox1.Controls.Add(this.New_Txt);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(25, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(264, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(90, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "User Name";
            // 
            // UserName_Txt
            // 
            this.UserName_Txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserName_Txt.BackColor = System.Drawing.Color.White;
            this.UserName_Txt.ForeColor = System.Drawing.Color.Black;
            this.UserName_Txt.Location = new System.Drawing.Point(10, 48);
            this.UserName_Txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserName_Txt.Name = "UserName_Txt";
            this.UserName_Txt.ReadOnly = true;
            this.UserName_Txt.Size = new System.Drawing.Size(244, 26);
            this.UserName_Txt.TabIndex = 0;
            this.UserName_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.BackgroundImage = global::GE_Service.Properties.Resources.GE_Logo_40;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(312, 345);
            this.ControlBox = false;
            this.Controls.Add(this.Passwor_label);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.Exit_Btn);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(500, 170);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePass";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit_Btn;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.TextBox PassWord;
        private System.Windows.Forms.Label Passwor_label;
        private System.Windows.Forms.TextBox New_Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Confirm_Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserName_Txt;
    }
}

