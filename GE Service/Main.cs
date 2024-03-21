using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GE_Service

{
    public partial class Main : Form
    {
        public Main() => InitializeComponent();

        private void SetIsLogout(bool value)
        {
            IsLogout = value;
        }

        public Color Tran { get => Color.Transparent; }
        public Color Blue { get => Color.FromArgb(59, 115, 185); }
        public bool IsLogout { get; set; }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic dialog = MessageBox.Show("Do You Really Want to Closing The Program?", "Exit", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    var connectionString = ConfigurationManager.ConnectionStrings["GE_Service.Properties.Settings.ConnString"].ConnectionString;

                    var backupFolder = ConfigurationManager.AppSettings["BackupFolder"];

                    var sqlConStrBuilder = new SqlConnectionStringBuilder(connectionString);

                    var backupFileName = String.Format("{0}{1}~{2}.bak",
                        backupFolder, sqlConStrBuilder.InitialCatalog,
                        DateTime.Now.ToString("yyyy-MM-dd"));

                    using (var connection = new SqlConnection(sqlConStrBuilder.ConnectionString))
                    {
                        var query = String.Format("BACKUP DATABASE {0} TO DISK='{1}'",
                            sqlConStrBuilder.InitialCatalog, backupFileName);

                        using (var command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }
                    string backupDir = @"Backup\";
                    var DeletionDays = 10;
                    if(DeletionDays > 0)
                    {
                        try
                        {
                            string[] files = Directory.GetFiles(backupDir);

                            foreach (string file in files)
                            {
                                FileInfo fi = new FileInfo(file);
                                if (fi.CreationTime < DateTime.Now.AddDays(-DeletionDays))
                                    fi.Delete();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                    e.Cancel = false;
                    Application.Exit();
                }
                else if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Login.Instance.Check(Login.Instance.UserName);
            foreach (var obj in Login.Instance.List)
            {
                Login.Instance.RoleName = obj.RoleName;
                Text = "GE Services  |  " + $"{Login.Instance.UserName}  |  "+ ""+obj.RoleName+"";
                if (Home_Btn.Text == obj.FunctionName)
                {
                    Home_Btn.Enabled = true;
                    Home_Btn.Tag = obj.FunctionName;
                }
                else if (Notification_Btn.Text == obj.FunctionName)
                {
                    Notification_Btn.Enabled = true;
                    HNotification_Btn.Enabled = true;
                    Notification_Btn.Tag = obj.FunctionName;
                }
                else if (Search_Btn.Text == obj.FunctionName)
                {
                    Search_Btn.Enabled = true;
                    HSearch_Btn.Enabled = true;
                    Search_Btn.Tag = obj.FunctionName;
                }
                else if (Report_Btn.Text == obj.FunctionName)
                {
                    Report_Btn.Enabled = true;
                    HReport_Btn.Enabled = true;
                    Report_Btn.Tag = obj.FunctionName;
                }
                else if (Settings_Btn.Text == obj.FunctionName)
                {
                    Settings_Btn.Enabled = true;
                    HSettings_Btn.Enabled = true;
                    Settings_Btn.Tag = obj.FunctionName;
                }
            }

            Home_Btn.Click += Home_Btn_Click;
            HomeBtnEnter(sender, e);
        }

        private void Singout_Btn_Click(object sender, EventArgs e)
        {
            SetIsLogout(true);
            Login.Instance.Show();
            Hide();
        }

        /*Side Panel*/

        //Home;
        public void Home_Btn_Click(object sender, EventArgs e)
        {
            ActiveForm.Text = "GE Services  |  " + $"{Login.Instance.UserName}  |  " + $"{Login.Instance.RoleName}";
            Side_Pan.Height = Home_Btn.Height;
            Side_Pan.Top = Home_Btn.Top;
            Main_Pan.Controls.Clear();
            Main_Pan.Controls.Add(Sub_Pan);
        }
        public void HomeBtnEnter(object sender, EventArgs e)
        {
            Home_Btn.Focus();
            Home_Btn.BackColor = Blue;
        }

        public void HomeBtnLeave(object sender, EventArgs e) => Home_Btn.BackColor = Tran;

        //Notification;
        public void NotificationBtnClick(object sender, EventArgs e)
        {
            Side_Pan.Height = Notification_Btn.Height;
            Side_Pan.Top = Notification_Btn.Top;
                Notification myForm = new Notification
                {
                    TopLevel = false

                };
                {
                    Main_Pan.Controls.Clear();
                    Main_Pan.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();
                }
        }
        public void Notification_Btn_Enter(object sender, EventArgs e)
        {
            Notification_Btn.Focus();
            Notification_Btn.BackColor = Blue;
        }

        public void Notification_Btn_Leave(object sender, EventArgs e) => Notification_Btn.BackColor = Tran;

        //Search;
        public void Search_Btn_Click(object sender, EventArgs e)
        {
            Side_Pan.Height = Search_Btn.Height;
            Side_Pan.Top = Search_Btn.Top;
          
                Search myForm = new Search
                {
                    TopLevel = false
                };
                {
                    Main_Pan.Controls.Clear();
                    Main_Pan.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();
                }
        }
        public void Search_Btn_Enter(object sender, EventArgs e)
        {
            Search_Btn.Focus();
            Search_Btn.BackColor = Blue;
        }

        public void Search_Btn_Leave(object sender, EventArgs e) => Search_Btn.BackColor = Tran;

        //Report;
        public void Report_Btn_Click(object sender, EventArgs e)
        {
            Side_Pan.Height = Report_Btn.Height;
            Side_Pan.Top = Report_Btn.Top;
                Report myForm = new Report
                {
                    TopLevel = false
                };
                {
                    Main_Pan.Controls.Clear();
                    Main_Pan.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();
                }
        }
        public void Report_Btn_Enter(object sender, EventArgs e)
        {
            Report_Btn.Focus();
            Report_Btn.BackColor = Blue;
        }

        public void Report_Btn_Leave(object sender, EventArgs e) => Report_Btn.BackColor = Tran;

        //Settings;
        public void Settings_Btn_Click(object sender, EventArgs e)
        {
                Side_Pan.Height = Settings_Btn.Height;
                Side_Pan.Top = Settings_Btn.Top;
                Settings myForm = new Settings
                {
                    TopLevel = false
                };
                {
                    Main_Pan.Controls.Clear();
                    Main_Pan.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();
                }
        }
        public void Settings_Btn_Enter(object sender, EventArgs e)
        {
            Settings_Btn.Focus();
            Settings_Btn.BackColor = Blue;
        }

        public void Settings_Btn_Leave(object sender, EventArgs e) => Settings_Btn.BackColor = Tran;

        //About;
        public void About_Btn_Click(object sender, EventArgs e)
        {
            Side_Pan.Height = About_Btn.Height;
            Side_Pan.Top = About_Btn.Top;
            using (About myForm = new About())
            {
                myForm.ShowDialog();
            }
        }
        public void About_Btn_Enter(object sender, EventArgs e)
        {
            About_Btn.Focus();
            About_Btn.BackColor = Blue;
        }

        public void About_Btn_Leave(object sender, EventArgs e) => About_Btn.BackColor = Tran;

        /*End Side Panel*/

        private void Label1_Click(object sender, EventArgs e)
        {
            SetIsLogout(true);
            Login.Instance.Show();
            Hide();
        }
    }
}
