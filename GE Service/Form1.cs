using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GE_Service.Properties;

namespace GE_Service
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SqlConnection Con { get; set; } = new SqlConnection(ConfigurationManager.ConnectionStrings["GE_Service.Properties.Settings.ConnString"].ConnectionString);



        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Authority { get; set; }
        public string RoleID { get; set; }
        public string RoleName { get; set; }
        public List<PROAuth> List { get; set; }
        private static Form1 _instance;

        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Form1();
                }

                return _instance;
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

            _instance = this;
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                    MessageBox.Show("Done");
                }

                Conn_Status.ForeColor = Color.Lime;
                Conn_Status.Text = Resources.L01;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Connect to Server Please Recheck It or Call The System Administrator" + "\r\n" + ex.Message, Resources.EL1000, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conn_Status.ForeColor = Color.Red;
                Conn_Status.Text = Resources.L02;
            }
        }

        private void Login_Btn_Click(object sender, EventArgs e)
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

                    CommandText = "SELECT * FROM T_Users WHERE Password= @0"
                })
                {
                    Cmd.Parameters.AddWithValue("@0", PassWord.Text);
                    SqlDataReader Reader = Cmd.ExecuteReader();
                    var c = 0;
                    while (Reader.Read())
                    {
                        c += 1;
                        UserID = Reader[0].ToString();
                        RoleID = Reader[1].ToString();
                        UserName = Reader[2].ToString();
                    }
                    Cmd.Parameters.Clear();
                    Con.Close();
                    if (c == 1)
                    {
                        Hide();
                        PassWord.Text = null;
                        using (Main D = new Main())
                        {
                            D.ShowDialog();
                        }
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

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show("GoodBye", "Exit", 700);
            Application.Exit();
        }

        public void Edit_Ico(Button Value, string Value2, Image Value3)
        {
            Value.Text = Value2;
            Value.Image = Value3;
            Value.ImageAlign = ContentAlignment.TopLeft;
            Value.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        public void Check(string Value)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["GE_Service.Properties.Settings.ConnString"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                    }

                    string query = "Select F.FunctionName,R.RoleName From T_Users Ur JOIN T_FunctionRole fr on ur.RoleID = fr.RoleID JOIN T_Function f on fr.FunctionID = f.FunctionID JOIN T_Roles R on ur.RoleID = R.RoleID where ur.Username = '" + Value + "'";
                    List = db.Query<PROAuth>(query, commandType: CommandType.Text).ToList();
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Get Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Login-1002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ChangePass D = new ChangePass())
            {
                D.ShowDialog();
            }
        }
    }
}
