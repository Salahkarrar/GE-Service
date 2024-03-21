using GE_Service.Properties;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GE_Service
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            ActiveForm.Text = "GE Services - Search  |  " + $"{Login.Instance.UserName}  |  " + $"{Login.Instance.RoleName}";
        }

        public SqlConnection Conn { get; } = new SqlConnection(ConfigurationManager.ConnectionStrings["GE_Service.Properties.Settings.ConnString"].ConnectionString);
        public SqlCommand Cmd { get; set; } = new SqlCommand();


        public object ID { get; set; }

        private void Search_Load(object sender, EventArgs e)
        {
            Enabled = false;
            Login.Instance.Check(Login.Instance.UserName);
            foreach (var obj in Login.Instance.List)
            {
                if (Text == obj.FunctionName)
                {
                    Enabled = true;
                    T_NotifyTabAd.Fill(gEdataSet.T_Notification);
                    Search_Group.Dock = DockStyle.Fill;
                }
            }
            if (Enabled != true)
            {
                MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
        }

        private void Search_Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(Search_Txt.Text))
                {
                    T_NotifyTabAd.FillByVa(gEdataSet.T_Notification, Search_Txt.Text);
                }
                else
                {
                    T_NotifyTabAd.FillByAll(gEdataSet.T_Notification);
                }
            }
        }

        private void Search_Grid_CellDoubleClick(object sender, EventArgs e)
        {

            ID = Search_Grid.CurrentRow.Cells[0].Value;
            Solution myForm = new Solution(ID)
            {
                TopLevel = false
            };
            {
                Header_Pan.Hide();
                So.Dock = DockStyle.Fill;
                So.BringToFront();
                So.Controls.Clear();
                So.Controls.Add(myForm);
                myForm.Show();
                myForm.Dock = DockStyle.Fill;
            }
        }

        //void Fill(string Value)
        //{
        //        try
        //        {
        //            if (Conn.State == ConnectionState.Closed)
        //            {
        //                Conn.Open();
        //            }

        //            Cmd.Connection = Conn;
        //            Cmd.CommandText = "SELECT * FROM T_Notification WHERE N_ItemName LIKE @0 OR N_Model LIKE @0 " +
        //                              "OR N_ItemDes LIKE @0 OR N_SystemID LIKE @0 OR N_SONum LIKE @0 " +
        //                              "OR N_Date LIKE @0 OR N_Status LIKE @0";
        //            Cmd.Parameters.AddWithValue("@0", Value);

        //            using (SqlDataAdapter Da = new SqlDataAdapter(Cmd))
        //            {
        //                DataTable Dt = new DataTable();
        //                Da.Fill(Dt);
        //                Search_Grid.DataSource = Dt;
        //            }
        //            Cmd.Parameters.Clear();
        //            Conn.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Problem in Database, Can't Searching." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Search-3000", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //}

    }
}
