using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using GE_Service.Properties;


namespace GE_Service
{
    public partial class ChangePass : Form
    {
        public ChangePass() => InitializeComponent();

        public SqlConnection Con { get; } = new SqlConnection(ConfigurationManager.ConnectionStrings["GE_Service.Properties.Settings.ConnString"].ConnectionString);

        public string UserName { get; set; }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            if (UserName_Txt.Text != null && New_Txt.Text == Confirm_Txt.Text)
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }

                    using (SqlCommand Cmd = new SqlCommand
                    {
                        Connection = Con,
                        CommandText = "UPDATE T_Users SET Password = @1 WHERE UserName= @2 AND Password= @0"
                    })
                    {
                        Cmd.Parameters.AddWithValue("@0", PassWord.Text);
                        Cmd.Parameters.AddWithValue("@1", New_Txt.Text);
                        Cmd.Parameters.AddWithValue("@2", UserName_Txt.Text);
                        Cmd.ExecuteNonQuery();
                        Cmd.Parameters.Clear();
                        Con.Close();
                        MessageBoxEx.Show("Data Saved", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                        PassWord.Clear();
                        New_Txt.Clear();
                        Confirm_Txt.Clear();
                        UserName_Txt.Clear();
                        groupBox1.Enabled = false;
                        PassWord.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter Another Password" + "\r\n" + ex.Message, "Error ChangePass-1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The User Name Can't be Empty or Your New Password & Confirm Password not Equal, Please Try Again.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }

                    using (SqlCommand Cmd = new SqlCommand
                    {

                        Connection = Con,

                        CommandText = "SELECT UserName FROM T_Users WHERE Password= @0"
                    })
                    {
                        Cmd.Parameters.AddWithValue("@0", PassWord.Text);
                        SqlDataReader Reader = Cmd.ExecuteReader();
                        var c = 0;
                        while (Reader.Read())
                        {
                            c += 1;
                            UserName = Reader[0].ToString();
                        }
                        Cmd.Parameters.Clear();
                        Con.Close();
                        if (c == 1)
                        {
                            groupBox1.Enabled = true;
                            UserName_Txt.Text = UserName;
                            New_Txt.Focus();
                        }
                        else
                        {
                            MessageBoxEx.Show("Password Not Correct.", Resources.M00, MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
                            PassWord.Text = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't Connect to Database, Please Recheck The Server or Call System Administrator" + "\r\n" + ex.Message, "Error Login-1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
