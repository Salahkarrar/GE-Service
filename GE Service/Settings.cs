using GE_Service.Properties;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GE_Service
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        int index = 1;

        public SqlConnection Con { get; } = new SqlConnection(ConfigurationManager.ConnectionStrings["GE_Service.Properties.Settings.ConnString"].ConnectionString);
        public SqlCommand Cmd { get; set; } = new SqlCommand();

        private void Settings_Load(object sender, EventArgs e)
        {
            User_Page_Enter(sender, e);
        }

        /* Add User Begin */

        private void User_Page_Enter(object sender, EventArgs e)
        {
            ActiveForm.Text = "GE Services - Settings - Users  |  " + $"{Login.Instance.UserName}  |  " + $"{Login.Instance.RoleName}";
            Login.Instance.Check(Login.Instance.UserName);
            foreach (var obj in Login.Instance.List)
            {
                if (User_Page.Text == obj.FunctionName)
                {
                    User_Page.Enabled = true;
                    Edit(true, false);
                    T_UsersTabAd.Fill(GESet.T_Users);
                    T_RolesTabAd.Fill(GESet.T_Roles);
                }
            }
            if (Convert.ToInt32(Login.Instance.RoleID) == 1 || Convert.ToInt32(Login.Instance.RoleID) == 2)
            {
                Delete_Btn.Enabled = true;
            }
            else
            {
                Delete_Btn.Enabled = false;
            }
            if (User_Page.Enabled != true)
            {
                MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
        }

        private void New_Btn_Click(object sender, EventArgs e)
        {
            Edit(false, true);
            GESet.T_Users.AddT_UsersRow(GESet.T_Users.NewT_UsersRow());
            T_UsersBindSour.MoveLast();
            Name_Txt.Focus();
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Name_Txt.Text) && !string.IsNullOrEmpty(Phone_Txt.Text) && !string.IsNullOrEmpty(Password_Txt.Text) &&
                    !string.IsNullOrEmpty(Auth_Txt.Text))
                {
                    Edit(true, false);

                    try
                    {
                        T_UsersTabAd.Insert(Convert.ToInt32(Auth_Txt.SelectedValue), Name_Txt.Text, Password_Txt.Text, Phone_Txt.Text);
                        MessageBoxEx.Show("Data Saved", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                        T_UsersTabAd.Fill(GESet.T_Users);
                        T_UsersBindSour.MoveLast();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The Name,Password and Phone Can't Duplicated, Please Recheck The Entery Data. OR" + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Se_User-1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        T_UsersTabAd.Fill(GESet.T_Users);
                    }
                }
                else
                {
                    MessageBoxEx.Show("Please Check Your Data and Try Again", Resources.M00, MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Store Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Se_User-5000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Edit_Btn.Text == "Edit")
                {
                    Edit(false, true);
                    New_Btn.Enabled = false;
                    Save_Btn.Enabled = false;

                    Login.Instance.Edit_Ico(Edit_Btn, "Update", Resources.Dark_Send_18);
                }
                else if (Edit_Btn.Text == "Update")
                {
                    Edit(true, false);
                    New_Btn.Enabled = true;

                    Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.Dark_Edit_18);
                    T_UsersBindSour.EndEdit();
                    T_UsersTabAd.Update(GESet.T_Users);
                    MessageBoxEx.Show("Updated", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
                else
                {
                    Edit(true, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is Some Problem." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Se_User-5001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            Login.Instance.Edit_Ico(Edit_Btn, "Edit", Properties.Resources.Dark_Edit_18);
            Edit(true, false);
            New_Btn.Enabled = true;
            T_UsersBindSour.CancelEdit();
            T_UsersTabAd.Fill(GESet.T_Users);
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            dynamic dialog = MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }

                    Cmd.Connection = Con;
                    Cmd.CommandText = "INSERT INTO T_UsersRecycle (UserID, RoleID, Username, Password, Phone)" +
                                      "SELECT UserID, RoleID, Username, Password, Phone FROM T_Users WHERE UserID=@0;" +
                                      "DELETE FROM T_Users WHERE UserID=@0";
                    Cmd.Parameters.AddWithValue("@0", User_Grid.CurrentRow.Cells[0].Value);
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                    T_UsersTabAd.Fill(GESet.T_Users);
                    T_UsersBindSour.MoveFirst();
                    MessageBoxEx.Show("Data Deleted", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Delete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Se_User-5002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void User_Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsNumber(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        // User Function //

        private void Edit(bool Value, bool Value2)
        {
            Save_Btn.Enabled = Value2;
            Name_Txt.ReadOnly = Value;
            Password_Txt.ReadOnly = Value;
            Phone_Txt.ReadOnly = Value;
            Auth_Txt.Enabled = Value2;
        }

        /* Add User End */


        /* System Begin */

        private void System_Page_Enter(object sender, EventArgs e)
        {
            ActiveForm.Text = "GE Services - Settings - System  |  " + $"{Login.Instance.UserName}  |  " + $"{Login.Instance.RoleName}";
            System_Page.Enabled = false;
            SDelete_Btn.Enabled = false;
            Login.Instance.Check(Login.Instance.UserName);
            foreach (var obj in Login.Instance.List)
            {
                if (System_Page.Text == obj.FunctionName)
                {
                    System_Page.Enabled = true;
                    SysEdit(true, false);
                    T_SysTabAd.Fill(GESet.T_System);
                }
                else if (SDelete_Btn.Text == obj.FunctionName)
                {
                    SDelete_Btn.Enabled = true;
                }
            }
            if (System_Page.Enabled != true)
            {
                MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
        }

        private void SNew_Btn_Click(object sender, EventArgs e)
        {
            SysEdit(false, true);
            GESet.T_System.AddT_SystemRow(GESet.T_System.NewT_SystemRow());
            T_SysBindSour.MoveLast();
            ItemName_Txt.Focus();
        }

        private void SSave_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(ItemName_Txt.Text) && !string.IsNullOrEmpty(Model_Txt.Text) && !string.IsNullOrEmpty(SystemID_Txt.Text) &&
                    !string.IsNullOrEmpty(SONum_Txt.Text) && !string.IsNullOrEmpty(ItemDesc_Txt.Text))
                {
                    SysEdit(true, false);
                    try
                    {
                        T_SysTabAd.Insert(ItemName_Txt.Text, Model_Txt.Text, ItemDesc_Txt.Text, SystemID_Txt.Text, SONum_Txt.Text);
                        MessageBoxEx.Show("Data Saved", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                        T_SysTabAd.Fill(GESet.T_System);
                        T_SysBindSour.MoveLast();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problem in Database, Can't Store Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Se_System-5100", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        T_SysTabAd.Fill(GESet.T_System);
                    }
                }
                else
                {
                    MessageBoxEx.Show("Please Check Your Data and Try Again", Resources.M00, MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Store Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Se_System-5002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SEdit_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SEdit_Btn.Text == "Edit")
                {
                    SysEdit(false, true);
                    SNew_Btn.Enabled = false;
                    SSave_Btn.Enabled = false;

                    Login.Instance.Edit_Ico(SEdit_Btn, "Update", Properties.Resources.Dark_Send_18);
                }
                else if (SEdit_Btn.Text == "Update")
                {
                    SysEdit(true, false);
                    SNew_Btn.Enabled = true;

                    Login.Instance.Edit_Ico(SEdit_Btn, "Edit", Properties.Resources.Dark_Edit_18);
                    T_SysBindSour.EndEdit();
                    T_SysTabAd.Update(GESet.T_System);
                    MessageBoxEx.Show("Updated", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
                else
                {
                    SysEdit(true, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Change Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Se_System-5101", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SCancel_Btn_Click(object sender, EventArgs e)
        {
            Login.Instance.Edit_Ico(SEdit_Btn, "Edit", Properties.Resources.Dark_Edit_18);
            SysEdit(true, false);
            SNew_Btn.Enabled = true;
            T_SysBindSour.CancelEdit();
            T_SysTabAd.Fill(GESet.T_System);
        }

        private void SDelete_Btn_Click(object sender, EventArgs e)
        {
            dynamic dialog = MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }

                    Cmd.Connection = Con;
                    Cmd.CommandText = "INSERT INTO T_SystemRecycle (S_ID, S_ItemName, S_Model, S_ItemDesc, S_SysID, S_SONum)" +
                                      "SELECT S_ID, S_ItemName, S_Model, S_ItemDesc, S_SysID, S_SONum FROM T_System WHERE S_ID=@0;" +
                                      "DELETE FROM T_System WHERE S_ID=@0";
                    Cmd.Parameters.AddWithValue("@0", Sys_Grid.CurrentRow.Cells[5].Value);
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                    T_SysTabAd.Fill(GESet.T_System);
                    T_SysBindSour.MoveFirst();
                    MessageBoxEx.Show("Data Deleted", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Delete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Se_System-5102", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // System Function

        void SysEdit(bool value, bool Value2)
        {
            SSave_Btn.Enabled = Value2;
            ItemName_Txt.ReadOnly = value;
            Model_Txt.ReadOnly = value;
            ItemDesc_Txt.ReadOnly = value;
            SystemID_Txt.ReadOnly = value;
            SONum_Txt.ReadOnly = value;
        }

        /* System End */


        /* Permission Begin */

        private void Authority_Page_Enter(object sender, EventArgs e)
        {
            ActiveForm.Text = "GE Services - Settings - Authority  |  " + $"{Login.Instance.UserName}  |  " + $"{Login.Instance.RoleName}";
            Authority_Page.Enabled = false;
            Login.Instance.Check(Login.Instance.UserName);
            foreach (var obj in Login.Instance.List)
            {
                if (Authority_Page.Text == obj.FunctionName)
                {
                    Authority_Page.Enabled = true;
                    index = 1;
                    T_FunTabAd.Fill(GESet.T_Function);
                    //T_RolesTabAd2.SetAuth(GESet.T_Roles);
                    Fill(index);
                    FunFill(index);
                }
            }
            if (Authority_Page.Enabled != true)
            {
                MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Fun_Grid.SelectedCells.Count; i++)
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }

                    Cmd.Connection = Con;
                    Cmd.CommandText = "INSERT INTO T_FunctionRole (RoleID, FunctionID) SELECT RoleID, FunctionID " +
                                        "FROM T_Roles t1 full join T_Function t3 on FunctionName = @0 WHERE NOT EXISTS" +
                                        "(SELECT FunctionID, RoleID FROM T_FunctionRole t2 WHERE t2.FunctionID = t3.FunctionID AND t2.RoleID = t1.RoleID) and RoleID =@1";
                    Cmd.Parameters.AddWithValue("@0", Fun_Grid.SelectedCells[i].Value);
                    Cmd.Parameters.AddWithValue("@1", MAuthority_Txt.SelectedValue);

                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                }
                Fill(index);
                FunFill(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Store Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Se_Permission-5200", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Remove_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < FunRole_Grid.SelectedCells.Count; i++)
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }

                    Cmd.Connection = Con;
                    Cmd.CommandText = " DELETE FROM T_FunctionRole WHERE RoleID=@1 AND FunctionID=@0";
                    Cmd.Parameters.AddWithValue("@0", FunRole_Grid.SelectedCells[i].Value);
                    Cmd.Parameters.AddWithValue("@1", MAuthority_Txt.SelectedValue);
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                }
                Fill(index);
                FunFill(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Detete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Se_Permission-5201", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MAuthority_Txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = Convert.ToInt32(MAuthority_Txt.SelectedValue);
            Fill(index);
            FunFill(index);
        }

        private void Fun_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Add_Btn_Click(sender, e);
        }

        private void FunRole_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Remove_Btn_Click(sender, e);
        }
        // Permission Function //

        void Fill(int Value)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                Cmd.Connection = Con;
                Cmd.CommandText = "SELECT * FROM T_FunctionRole WHERE RoleID=@0";
                Cmd.Parameters.AddWithValue("@0", Value);

                using (SqlDataAdapter Da = new SqlDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    T_FunRoleBindSour.DataSource = Dt;
                    FunRole_Grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Get Your Data.." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Se_Perimission-5202", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Fill(index);
            }
        }

        void FunFill(int Value)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                Cmd.Connection = Con;
                Cmd.CommandText = "SELECT * FROM T_Function WHERE FunctionID NOT IN (Select FunctionID FROM T_FunctionRole WHERE RoleID=@0)";
                Cmd.Parameters.AddWithValue("@0", Value);

                using (SqlDataAdapter Da = new SqlDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    FunBindSour2.DataSource = Dt;
                    Fun_Grid.DataSource = FunBindSour2;

                }
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Get Your Data.." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Se_Perimission-5203", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FunTabAd2.Fill(GESet.T_Function);
            }
        }



        /* Permission End */
    }
}
