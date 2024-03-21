using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using GE_Service.Properties;

namespace GE_Service
{
    public partial class Report : Form
    {

        public Report()
        {
            InitializeComponent();
            ActiveForm.Text = "GE Services - Report  |  " + $"{Login.Instance.UserName}  |  " + $"{Login.Instance.RoleName}";
        }

        public SqlConnection Con { get; } = new SqlConnection(ConfigurationManager.ConnectionStrings["GE_Service.Properties.Settings.ConnString"].ConnectionString);
        public SqlCommand Cmd { get; set; } = new SqlCommand();

        public string F { get; set; }
        public string T { get; set; }
        public string Status { get; set; }
        public int ID { get; set; }

        private void Search_Load(object sender, EventArgs e)
        {
            Enabled = false;
            Login.Instance.Check(Login.Instance.UserName);
            foreach (var obj in Login.Instance.List)
            {
                if (Text == obj.FunctionName)
                {
                    Enabled = true;
                    From_Txt.Value = DateTime.Today;
                    To_Txt.Value = DateTime.Today;
                    Grid_Group.Dock = DockStyle.Fill;
                }
            }
            if (Enabled != true)
            {
                MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
            }
            
        }

        private void Search_Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(From_Txt.Text) && !string.IsNullOrEmpty(To_Txt.Text) && string.IsNullOrEmpty(Status_Txt.Text))
            {
                ID = 1;
                try
                {
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();


                    Cmd.Connection = Con;
                    Cmd.CommandText = "SELECT * FROM T_Notification WHERE N_Date BETWEEN @0 AND @1 ";
                    Cmd.Parameters.AddWithValue("@0", From_Txt.Text);
                    Cmd.Parameters.AddWithValue("@1", To_Txt.Text);
                    
                    using (SqlDataAdapter Da = new SqlDataAdapter(Cmd))
                    {
                        DataTable Dt = new DataTable();
                        Da.Fill(Dt);
                        Report_Grid.DataSource = Dt;
                    }
                    Cmd.Parameters.Clear();
                    Con.Close();
                    if (Report_Grid.Rows.Count > 0)
                    {
                        MessageBoxEx.Show("Show Done.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                    }
                    else
                    {
                        MessageBoxEx.Show("No Data Founded", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Get Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Report-4000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!string.IsNullOrEmpty(From_Txt.Text) && !string.IsNullOrEmpty(To_Txt.Text) && !string.IsNullOrEmpty(Status_Txt.Text))
            {
                ID = 2;
                try
                {
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();


                    Cmd.Connection = Con;
                    Cmd.CommandText = "SELECT * FROM T_Notification WHERE N_Date BETWEEN @0 AND @1 AND N_Status=@2";
                    Cmd.Parameters.AddWithValue("@0", From_Txt.Text);
                    Cmd.Parameters.AddWithValue("@1", To_Txt.Text);
                    Cmd.Parameters.AddWithValue("@2", Status_Txt.Text);

                    using (SqlDataAdapter Da = new SqlDataAdapter(Cmd))
                    {
                        DataTable Dt = new DataTable();
                        Da.Fill(Dt);
                        Report_Grid.DataSource = Dt;
                    }
                    Cmd.Parameters.Clear();
                    Con.Close();
                    if (Report_Grid.Rows.Count > 0)
                    {
                        MessageBoxEx.Show("Show Done.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                    }
                    else
                    {
                        MessageBoxEx.Show("No Data Founded", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Get Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Report-4001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBoxEx.Show("Please Check Your Data & Try again.", Resources.M00, MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
            }
        }

        private void Print_Btn_Click(object sender, EventArgs e)
        {

            if (Report_Grid.Rows.Count > 0)
            {
                F = From_Txt.Text;
                T = To_Txt.Text;

                using (Print frm = new Print(F, T, Status_Txt.Text, ID))

                {
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBoxEx.Show("Please Search for Data First.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information,1000);
            }
        }

    }
}
