namespace GE_Service
{
    public partial class Login
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
            this.PassWord = new System.Windows.Forms.TextBox();
            this.Passwor_label = new System.Windows.Forms.Label();
            this.CheckConn_label = new System.Windows.Forms.Label();
            this.Conn_Status = new System.Windows.Forms.Label();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // PassWord
            // 
            this.PassWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassWord.BackColor = System.Drawing.Color.White;
            this.PassWord.ForeColor = System.Drawing.Color.Black;
            this.PassWord.Location = new System.Drawing.Point(27, 239);
            this.PassWord.Name = "PassWord";
            this.PassWord.PasswordChar = '*';
            this.PassWord.Size = new System.Drawing.Size(196, 22);
            this.PassWord.TabIndex = 1;
            this.PassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Passwor_label
            // 
            this.Passwor_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Passwor_label.AutoSize = true;
            this.Passwor_label.BackColor = System.Drawing.Color.Transparent;
            this.Passwor_label.ForeColor = System.Drawing.Color.Black;
            this.Passwor_label.Location = new System.Drawing.Point(96, 216);
            this.Passwor_label.Name = "Passwor_label";
            this.Passwor_label.Size = new System.Drawing.Size(59, 15);
            this.Passwor_label.TabIndex = 12;
            this.Passwor_label.Text = "Password";
            // 
            // CheckConn_label
            // 
            this.CheckConn_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckConn_label.AutoSize = true;
            this.CheckConn_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckConn_label.ForeColor = System.Drawing.Color.Black;
            this.CheckConn_label.Location = new System.Drawing.Point(5, 510);
            this.CheckConn_label.Name = "CheckConn_label";
            this.CheckConn_label.Size = new System.Drawing.Size(123, 19);
            this.CheckConn_label.TabIndex = 12;
            this.CheckConn_label.Text = "Connection status :";
            // 
            // Conn_Status
            // 
            this.Conn_Status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Conn_Status.AutoSize = true;
            this.Conn_Status.ForeColor = System.Drawing.Color.Black;
            this.Conn_Status.Location = new System.Drawing.Point(134, 514);
            this.Conn_Status.Name = "Conn_Status";
            this.Conn_Status.Size = new System.Drawing.Size(41, 15);
            this.Conn_Status.TabIndex = 12;
            this.Conn_Status.Text = "Status";
            // 
            // Login_Btn
            // 
            this.Login_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Login_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Login_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Login_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Btn.ForeColor = System.Drawing.Color.Black;
            this.Login_Btn.Image = global::GE_Service.Properties.Resources.Dark_Account_18;
            this.Login_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login_Btn.Location = new System.Drawing.Point(27, 293);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(70, 30);
            this.Login_Btn.TabIndex = 2;
            this.Login_Btn.Text = "Login";
            this.Login_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Login_Btn.UseVisualStyleBackColor = false;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
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
            this.Exit_Btn.Image = global::GE_Service.Properties.Resources.Dark_Exit_18;
            this.Exit_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_Btn.Location = new System.Drawing.Point(153, 293);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(70, 30);
            this.Exit_Btn.TabIndex = 3;
            this.Exit_Btn.Text = "Exit";
            this.Exit_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exit_Btn.UseVisualStyleBackColor = false;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Login
            // 
            this.AcceptButton = this.Login_Btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.BackgroundImage = global::GE_Service.Properties.Resources.GE_Logo_40;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.Exit_Btn;
            this.ClientSize = new System.Drawing.Size(250, 538);
            this.ControlBox = false;
            this.Controls.Add(this.Passwor_label);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.Exit_Btn);
            this.Controls.Add(this.Conn_Status);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.CheckConn_label);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(500, 170);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit_Btn;
        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.TextBox PassWord;
        private System.Windows.Forms.Label Passwor_label;
        private System.Windows.Forms.Label CheckConn_label;
        private System.Windows.Forms.Label Conn_Status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

