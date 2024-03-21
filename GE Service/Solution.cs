using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using GE_Service.Properties;
using System.Globalization;

namespace GE_Service
{
    public partial class Solution : Form
    {
        public object Id { get; set; }

        public Solution(object ID)
        {
            InitializeComponent();
            ActiveForm.Text = "GE Services - Solution  |  " + $"{Login.Instance.UserName}  |  " + $"{Login.Instance.RoleName}";
            Id = ID;
        }

        public SqlConnection Con { get; } = new SqlConnection(ConfigurationManager.ConnectionStrings["GE_Service.Properties.Settings.ConnString"].ConnectionString);
        public SqlCommand Cmd { get; set; } = new SqlCommand();

        private void Solution_Load(object sender, EventArgs e)
        {
            Enabled = false;
            Delete_Btn.Enabled = false;
            Login.Instance.Check(Login.Instance.UserName);
            foreach (var obj in Login.Instance.List)
            {
                if (Text == obj.FunctionName)
                {
                    Enabled = true;
                    Edit(true, false);
                    Fill();
                }
                else if (Delete_Btn.Text == obj.FunctionName)
                {
                    Delete_Btn.Enabled = true;
                }
            }
            if (Enabled != true)
            {
                MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
        }

        private void New_Btn_Click(object sender, EventArgs e)
        {
            if (SStatus_Txt.Text == "Pending")
            {
                Edit(false, true);
                SDate_Txt.Text = null;
                SStatus_Txt.Text = null;
                SDetails_Txt.Clear();
                Responded_Txt.Text = $"{Login.Instance.UserName}";
            }
            else
            {
                MessageBox.Show("It's Not Null, Please Recheck Data.", Resources.M00, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            Edit(true, false);
            if (!string.IsNullOrEmpty(SStatus_Txt.Text) && !string.IsNullOrEmpty(SDetails_Txt.Text)
                && SDate_Txt.Checked == true && !string.IsNullOrEmpty(Responded_Txt.Text))
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }

                    using (SqlCommand Cmd = new SqlCommand
                    {
                        Connection = Con
                    })
                    {
                        Cmd.CommandText = "UPDATE T_Notification SET N_SDate=@0,N_SDetails=@1," +
                                          "N_Status=@2,N_SUserName=@3 WHERE N_ID=@4";
                        Cmd.Parameters.AddWithValue("@0", Convert.ToDateTime(SDate_Txt.Text));
                        Cmd.Parameters.AddWithValue("@1", SDetails_Txt.Text);
                        Cmd.Parameters.AddWithValue("@2", SStatus_Txt.Text);
                        Cmd.Parameters.AddWithValue("@3", $"{Login.Instance.UserName}");
                        Cmd.Parameters.AddWithValue("@4", ID_Txt.Text);
                        Cmd.ExecuteNonQuery();
                        Cmd.Parameters.Clear();
                        Con.Close();
                        Fill();
                    }
                    PDF();
                    MessageBoxEx.Show("Data Saved", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Store Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Solution-6000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Recheck Your Data.", Resources.M00, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ID_Txt.Text) && !string.IsNullOrEmpty(Responded_Txt.Text)
                    && Edit_Btn.Text == "Edit" && Status_Txt.Text != "Pending" && Status_Txt.Text != "Solved")
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
                if (Status_Txt.Text == "Solved")
                {
                    DateTime D = Convert.ToDateTime(Date_Txt.Text);
                    string S = SStatus_Txt.Text;
                    string d = SDetails_Txt.Text;
                    DeleteCase("Modify");

                    Date_Txt.Text = D.ToString();
                    SStatus_Txt.Text = S;
                    SDetails_Txt.Text = d;

                    EditCase();
                }
                else
                {
                    EditCase();
                }
            }
            else if (Status_Txt.Text == "Solved" && (Login.Instance.RoleID == "1" || Login.Instance.RoleID == "2"))
            {
                Edit(false, true);
                New_Btn.Enabled = false;
                Save_Btn.Enabled = false;

                Login.Instance.Edit_Ico(Edit_Btn, "Update", Resources.Dark_Send_18);
            }
            else
            {
                MessageBox.Show("Can't Editing Because it's Solved or You aren't The Real Responded." + "\r\n" + "Please Contact to Your Supervisor.", Resources.M00, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Edit(true, false);
            }
            
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.Dark_Edit_18);
            New_Btn.Enabled = true;
            if (!string.IsNullOrEmpty(ID_Txt.Text))
            {
                Edit(true, false);
                Fill();
            }
            else
            {
                Edit(true, false);
            }
        }

        private void Print_Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ID_Txt.Text) && !string.IsNullOrEmpty(Responded_Txt.Text)
                && !string.IsNullOrEmpty(SStatus_Txt.Text) && !string.IsNullOrEmpty(SDetails_Txt.Text))
            {
                string DestFileName = @"GE Data\Solution\" + ID_Txt.Text + ".pdf";
                if (SStatus_Txt.Text == "Solved")
                {
                    System.Diagnostics.Process.Start(DestFileName);
                }
                else
                {
                    MessageBox.Show("File Not Exist Because it's Not Solved, Please Solved The Problem And Try Again.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Reckeck Entry Data.", Resources.M00, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SUserName_Txt_Enter(object sender, EventArgs e)
        {
            if(Responded_Txt.ReadOnly == false) Responded_Txt.Text = Login.Instance.UserName;
        }

        /* Function*/
        private void Edit(bool Value, bool Value2)
        {
            Save_Btn.Enabled = Value2;
            SDate_Txt.Enabled = Value2;
            SDetails_Txt.ReadOnly = Value;
            SStatus_Txt.Enabled = Value2;
        }

        void Fill()
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                Cmd.Connection = Con;
                Cmd.CommandText = "SELECT * FROM T_Notification WHERE N_ID = @0";
                Cmd.Parameters.AddWithValue("@0", Id);

                SqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    I_Txt.Text = Reader["ID"].ToString();
                    ID_Txt.Text = Reader["N_ID"].ToString();
                    CustomerName_Txt.Text = Reader["N_CustName"].ToString();
                    ItemName_Txt.Text = Reader["N_ItemName"].ToString();
                    Model_Txt.Text = Reader["N_Model"].ToString();
                    ItemDes_Txt.Text = Reader["N_ItemDes"].ToString();
                    SystemID_Txt.Text = Reader["N_SystemID"].ToString();
                    SONumber_Txt.Text = Reader["N_SONum"].ToString();
                    Date_Txt.Text = Reader["N_Date"].ToString();
                    ContactNumber_Txt.Text = Reader["N_ConNum"].ToString();
                    Details_Txt.Text = Reader["N_Details"].ToString();
                    Status_Txt.Text = Reader["N_Status"].ToString();
                    SDate_Txt.Text = Reader["N_SDate"].ToString();
                    SDetails_Txt.Text = Reader["N_SDetails"].ToString();
                    SStatus_Txt.Text = Reader["N_Status"].ToString();
                    Responded_Txt.Text = Reader["N_SUserName"].ToString();
                }
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Get Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Solution-6002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            dynamic dialog = MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(ID_Txt.Text) && !string.IsNullOrEmpty(Responded_Txt.Text)
                    && !string.IsNullOrEmpty(SStatus_Txt.Text) && !string.IsNullOrEmpty(SDetails_Txt.Text)
                    && Login.Instance.UserName == Responded_Txt.Text || Login.Instance.RoleID == "1"
                    || Login.Instance.RoleID == "2")
                {
                    DeleteCase("Deleted");
                }
            }
            else if (dialog == DialogResult.No)
            {
                return;
            }
            else
            {
                MessageBox.Show("You Can't Deleted Because You're not The Same User", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void PDF()
        {
            try
            {

                string SourceFileName = @"GE Data\Solution\" + ID_Txt.Text + ".pdf";
                string DestFileName = @"GE Data\Solution\" + ID_Txt.Text + ".pdf";

                if (SStatus_Txt.Text == "Solved")
                {

                    Document document = new Document(PageSize.A4, 43, 43, 43, 43);
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(DestFileName, FileMode.Create));
                    document.Open();
                    Chunk glue = new Chunk(new VerticalPositionMark());
                    Paragraph para = new Paragraph();
                    Phrase ph1 = new Phrase();

                    Paragraph mm = new Paragraph();
                    ph1.Add(new Chunk(Environment.NewLine));
                    ph1.Add(new Chunk("Customer Name : " + CustomerName_Txt.Text, FontFactory.GetFont("Times New Roman", 10, 1)));
                    ph1.Add(glue);
                    ph1.Add(new Chunk("Contact Number : " + ContactNumber_Txt.Text, FontFactory.GetFont("Times New Roman", 10, 1)));
                    ph1.Add(new Chunk(Environment.NewLine));
                    ph1.Add(new Chunk("Item Name : " + ItemName_Txt.Text, FontFactory.GetFont("Times New Roman", 10, 1)));
                    ph1.Add(glue);
                    ph1.Add(new Chunk("Model : " + Model_Txt.Text, FontFactory.GetFont("Times New Roman", 10, 1)));
                    ph1.Add(new Chunk(Environment.NewLine));
                    ph1.Add(new Chunk("Item Descripiton : " + ItemDes_Txt.Text, FontFactory.GetFont("Times New Roman", 10, 1)));
                    ph1.Add(glue);
                    ph1.Add(new Chunk("SystemID : " + SystemID_Txt.Text, FontFactory.GetFont("Times New Roman", 10, 1)));
                    ph1.Add(glue);
                    ph1.Add(new Chunk("S/O Number : " + SONumber_Txt.Text, FontFactory.GetFont("Times New Roman", 10, 1)));
                    ph1.Add(new Chunk(Environment.NewLine));
                    ph1.Add(new Chunk("Date : " + Date_Txt.Text, FontFactory.GetFont("Times New Roman", 10, 1)));
                    ph1.Add(new Chunk(Environment.NewLine));
                    ph1.Add(new LineSeparator());
                    ph1.Add(new Chunk(Environment.NewLine));
                    ph1.Add(new Chunk(Environment.NewLine));
                    ph1.Add(new Chunk(Environment.NewLine));

                    ph1.Add(new Chunk("Details:- ", FontFactory.GetFont("Times New Roman", 10, 1, BaseColor.BLUE)));
                    ph1.Add(new Chunk(Environment.NewLine));
                    ph1.Add(new Chunk(Environment.NewLine));
                    ph1.Add(new Chunk(Details_Txt.Text, FontFactory.GetFont("Times New Roman", 10, 1)));
                    ph1.Add(new Chunk(Environment.NewLine));
                    ph1.Add(new LineSeparator());
                    ph1.Add(new Chunk(Environment.NewLine));
                    ph1.Add(new Chunk(Environment.NewLine));

                    ph1.Add(new Chunk("Solution:- ", FontFactory.GetFont("Times New Roman", 10, 1, BaseColor.BLUE)));
                    ph1.Add(new Chunk(Environment.NewLine));
                    ph1.Add(new Chunk("Date : " + SDate_Txt.Text, FontFactory.GetFont("Times New Roman", 10, 1)));
                    ph1.Add(glue);
                    ph1.Add(new Chunk("Responded By : " + Responded_Txt.Text, FontFactory.GetFont("Times New Roman", 10, 1)));
                    ph1.Add(new Chunk(Environment.NewLine));
                    ph1.Add(new Chunk(Environment.NewLine));
                    ph1.Add(new Chunk("The Solution :- ", FontFactory.GetFont("Times New Roman", 10, 3, BaseColor.BLUE)));
                    ph1.Add(new Chunk(Environment.NewLine));
                    ph1.Add(new Chunk(Environment.NewLine));
                    ph1.Add(new Chunk(SDetails_Txt.Text, FontFactory.GetFont("Times New Roman", 10, 1)));

                    mm.Add(ph1);
                    para.Add(mm);
                    document.Add(para);
                    document.Close();

                    string WatermarkLocation = @"GE Data\GE Logo.PNG";

                    byte[] bytes = File.ReadAllBytes(DestFileName);
                    var img = Image.GetInstance(WatermarkLocation);
                    img.SetAbsolutePosition(50, 150);
                    PdfContentByte waterMark;

                    using (MemoryStream stream = new MemoryStream())
                    {
                        PdfReader reader = new PdfReader(bytes);
                        using (PdfStamper stamper = new PdfStamper(reader, stream))
                        {
                            int pages = reader.NumberOfPages;
                            for (int i = 1; i <= pages; i++)
                            {
                                waterMark = stamper.GetUnderContent(i);
                                waterMark.AddImage(img);
                            }
                        }
                        bytes = stream.ToArray();
                    }
                    File.WriteAllBytes(DestFileName, bytes);

                    System.Diagnostics.Process.Start(DestFileName);
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in PDF File." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Solution-6004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditCase()
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                using (SqlCommand Cmd = new SqlCommand
                {
                    Connection = Con
                })
                {
                    Cmd.CommandText = "UPDATE T_Notification SET N_SDate=@0,N_SDetails=@1," +
                                        "N_Status=@2,N_SUserName=@3 WHERE N_ID=@4";
                    Cmd.Parameters.AddWithValue("@0", Convert.ToDateTime(SDate_Txt.Text));
                    Cmd.Parameters.AddWithValue("@1", SDetails_Txt.Text);
                    Cmd.Parameters.AddWithValue("@2", SStatus_Txt.Text);
                    Cmd.Parameters.AddWithValue("@3", $"{Login.Instance.UserName}");
                    Cmd.Parameters.AddWithValue("@4", ID_Txt.Text);
                    Cmd.ExecuteNonQuery();
                }
                PDF();
                MessageBoxEx.Show("Updated", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                Fill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Change Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Solution-6001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteCase(string Value)
        {
            try
            {
                string SourceFile = @"GE Data\Solution\" + ID_Txt.Text + ".pdf";
                string DesFile = @"GE Data\SolutionRecycle\" + I_Txt.Text + "~" + ID_Txt.Text + "~" + DateTime.Now.ToString("yyyy-MM-dd~hh-mm-ss tt", CultureInfo.CreateSpecificCulture("en-us")) + "~" + Value + ".pdf";
                File.Move(SourceFile, DesFile);
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                Cmd.Connection = Con;
                Cmd.CommandText = "INSERT INTO T_SolutionRecycle (ID,N_ID, N_CustName, N_ItemName, N_Model, N_ItemDes, N_SystemID, N_SONum, N_Date, N_ConNum, N_Details, N_Status, N_SDate, N_SUserName, N_SDetails)" +
                                    "SELECT ID,N_ID, N_CustName, N_ItemName, N_Model, N_ItemDes, N_SystemID, N_SONum, N_Date, N_ConNum, N_Details, N_Status, N_SDate, N_SUserName, N_SDetails FROM T_Notification WHERE N_ID=@0;" +
                                    "UPDATE T_Notification SET N_SDate=@1, N_Status ='" + "Pending" + "', N_SUserName='" + null + "', N_SDetails='" + null + "' WHERE N_ID=@0;" +
                                    "UPDATE T_SolutionRecycle SET DDate = @2, DUserName= @3, DStatus= @4 WHERE N_ID = @0";
                Cmd.Parameters.AddWithValue("@0", ID_Txt.Text);
                Cmd.Parameters.AddWithValue("@1", Convert.ToDateTime(SDate_Txt.Text));
                Cmd.Parameters.AddWithValue("@2", DateTime.Now);
                Cmd.Parameters.AddWithValue("@3", Login.Instance.UserName);
                Cmd.Parameters.AddWithValue("@4", Value);
                Cmd.ExecuteNonQuery();
                Cmd.Parameters.Clear();
                Con.Close();
                Fill();
                MessageBoxEx.Show("Data Deleted", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Delete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Solution-6003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
