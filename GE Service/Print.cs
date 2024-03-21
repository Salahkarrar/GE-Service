using Microsoft.Reporting.WinForms;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GE_Service
{
    public partial class Print : Form
    {
        string _F, _T, _Status;
        int Id;
        public Print(string F, string T, string Status, int ID)
        {
            _F = F;
            _T = T;
            _Status = Status;
            Id = ID;
            InitializeComponent();
            Text = "GE Services - Print  |  " + $"{Login.Instance.UserName}  |  " + $"{Login.Instance.RoleName}";
        }

        public SqlConnection Conn { get; } = new SqlConnection(ConfigurationManager.ConnectionStrings["GE_Service.Properties.Settings.ConnString"].ConnectionString);
        public SqlCommand Cmd { get; set; } = new SqlCommand();

        private void Print_Load(object sender, EventArgs e)
        {
            if (Id == 2)
            {
                GEReport.Dock = DockStyle.Fill; GEReport.BringToFront();
                GEReportFun();
                ReportParameter[] p = new ReportParameter[]
                {
                new ReportParameter("A", _F),
                new ReportParameter("B", _T),
                new ReportParameter("C", _Status),

                };
                GEReport.LocalReport.SetParameters(p);
                GEReport.SetDisplayMode(DisplayMode.PrintLayout);
                GEReport.RefreshReport();
            }
            else if (Id == 1)
            {
                GeneralReport.Dock = DockStyle.Fill; GeneralReport.BringToFront();
                GeneralReportFun();
                ReportParameter[] p = new ReportParameter[]
                {
                new ReportParameter("A", _F),
                new ReportParameter("B", _T),
                };
                GeneralReport.LocalReport.SetParameters(p);
                GeneralReport.SetDisplayMode(DisplayMode.PrintLayout);
                GeneralReport.RefreshReport();
            }
        }

        private void GEReportFun()
        {
            try
            {
                {
                    if (Conn.State == ConnectionState.Closed)
                    {
                        Conn.Open();
                    }

                    Cmd.Connection = Conn;
                    Cmd.CommandText = "SELECT N_ID,N_CustName,N_ItemName,N_Model,N_ItemDes,N_SystemID,N_SONum,N_Date FROM T_Notification " +
                                       $"WHERE N_Date BETWEEN @0 AND @1 AND N_Status=@2";
                    Cmd.Parameters.AddWithValue("@0", _F);
                    Cmd.Parameters.AddWithValue("@1", _T);
                    Cmd.Parameters.AddWithValue("@2", _Status);

                    using (SqlDataAdapter Da = new SqlDataAdapter(Cmd))
                    {
                        DataTable Dt = new DataTable();
                        Da.Fill(Dt);
                        T_NotifyBindSour.DataSource = Dt;
                    }
                    Cmd.Parameters.Clear();
                    Conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Get Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Print-7000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GeneralReportFun()
        {
            try
            {
                {
                    if (Conn.State == ConnectionState.Closed)
                    {
                        Conn.Open();
                    }

                    Cmd.Connection = Conn;
                    Cmd.CommandText = "SELECT N_ID,N_CustName,N_ItemName,N_Model,N_Status,N_SystemID,N_SONum,N_Date FROM T_Notification " +
                                       $"WHERE N_Date BETWEEN @0 AND @1";
                    Cmd.Parameters.AddWithValue("@0", _F);
                    Cmd.Parameters.AddWithValue("@1", _T);

                    using (SqlDataAdapter Da = new SqlDataAdapter(Cmd))
                    {
                        DataTable Dt = new DataTable();
                        Da.Fill(Dt);
                        T_NotifyBindSour.DataSource = Dt;
                    }
                    Cmd.Parameters.Clear();
                    Conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Get Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Print-7001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
