using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text.pdf.draw;
using GE_Service.Properties;
using System.Globalization;
using Org.BouncyCastle.Asn1.Cms;

namespace GE_Service
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
            ActiveForm.Text = "GE Services - Notification  |  " + $"{Login.Instance.UserName}  |  " + $"{Login.Instance.RoleName}";
        }

        public SqlConnection Con { get; } = new SqlConnection(ConfigurationManager.ConnectionStrings["GE_Service.Properties.Settings.ConnString"].ConnectionString);
        public SqlCommand Cmd { get; set; } = new SqlCommand();
        
        private void Notification_Load(object sender, EventArgs e)
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
                    T_NotifyTabAd.Fill(GESet.T_Notification);
                    T_SysTabAd.Fill(GESet.T_System);
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

                            /*  System Info  */

        private void New_Btn_Click(object sender, EventArgs e)
        {
            Edit(false, true);
            GESet.T_Notification.AddT_NotificationRow(GESet.T_Notification.NewT_NotificationRow());
            T_NotifyBindSour.MoveLast();
            CustomerName_Txt.Focus();
            Date_Txt.ResetText();
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            //Status_Txt.Text = "Pending";
            if (!string.IsNullOrEmpty(CustomerName_Txt.Text)      && !string.IsNullOrEmpty(ItemName_Txt.Text)  && Date_Txt.Checked == true 
                && !string.IsNullOrEmpty(ContactNumber_Txt.Text)  && !string.IsNullOrEmpty(Details_Txt.Text)   && !string.IsNullOrEmpty(Status_Txt.Text))
            {
                
                Edit(true, false);
                try
                {
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "INSERT INTO T_Notification (N_CustName, N_ItemName, N_Model, N_ItemDes, N_SystemID, N_SONum, N_Date, N_ConNum, N_Details, N_Status) VALUES" +
                                      "(@0,@1,@2,@3,@4,@5,@6,@7,@8,@9)";
                    Cmd.Parameters.AddWithValue("@0", CustomerName_Txt.Text);
                    Cmd.Parameters.AddWithValue("@1", ItemName_Txt.Text);
                    Cmd.Parameters.AddWithValue("@2", Model_Txt.Text);
                    Cmd.Parameters.AddWithValue("@3", ItemDes_Txt.Text);
                    Cmd.Parameters.AddWithValue("@4", SystemID_Txt.Text);
                    Cmd.Parameters.AddWithValue("@5", SONumber_Txt.Text);
                    Cmd.Parameters.AddWithValue("@6", Convert.ToDateTime(Date_Txt.Text));
                    Cmd.Parameters.AddWithValue("@7", ContactNumber_Txt.Text);
                    Cmd.Parameters.AddWithValue("@8", Details_Txt.Text);
                    Cmd.Parameters.AddWithValue("@9", Status_Txt.Text);
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                    T_NotifyTabAd.Fill(GESet.T_Notification);
                    T_NotifyBindSour.MoveLast();
                    PDF();
                    MessageBoxEx.Show("Data Saved and PDF Created", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Store Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Notification-2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBoxEx.Show("Please Check Your Data and Try Again", Resources.M00, MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ID_Txt.Text) && !string.IsNullOrEmpty(ItemName_Txt.Text)
                && Edit_Btn.Text == "Edit" && Status_Txt.Text == "Pending" )
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
                try
                {
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();
                    using (SqlCommand Cmd = new SqlCommand
                    {
                        Connection = Con
                    })
                    {
                        Cmd.CommandText = "UPDATE T_Notification SET N_CustName=@0,N_ItemName=@1,N_Model =@2,N_ItemDes=@3,N_SystemID=@4," +
                                            "N_SONum=@5,N_Date=@6,N_ConNum=@7,N_Details=@8 WHERE N_ID=@9";
                        Cmd.Parameters.AddWithValue("@0", CustomerName_Txt.Text);
                        Cmd.Parameters.AddWithValue("@1", ItemName_Txt.Text);
                        Cmd.Parameters.AddWithValue("@2", Model_Txt.Text);
                        Cmd.Parameters.AddWithValue("@3", ItemDes_Txt.Text);
                        Cmd.Parameters.AddWithValue("@4", SystemID_Txt.Text);
                        Cmd.Parameters.AddWithValue("@5", SONumber_Txt.Text);
                        Cmd.Parameters.AddWithValue("@6", Convert.ToDateTime(Date_Txt.Text));
                        Cmd.Parameters.AddWithValue("@7", ContactNumber_Txt.Text);
                        Cmd.Parameters.AddWithValue("@8", Details_Txt.Text);
                        Cmd.Parameters.AddWithValue("@9", ID_Txt.Text);
                        Cmd.ExecuteNonQuery();
                    }
                    PDF();
                    MessageBoxEx.Show("Data and PDF File Updated ", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                    SysList_Grid.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Change Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Notification-2001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Cmd.Parameters.Clear();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Can't Editing Because it Solved or Waiting Spare Part. " + "\r\n" + "Please Recheck Your Data.", Resources.M00, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.Dark_Edit_18);
                Edit(true, false);
                New_Btn.Enabled = true;
                T_NotifyBindSour.CancelEdit();
                T_NotifyTabAd.Fill(GESet.T_Notification);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Get Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Notification-2002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Print_Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ID_Txt.Text))
            {
                string Path = @"GE Data\Report\" + ID_Txt.Text + ".pdf";
                if (File.Exists(Path))
                {
                    System.Diagnostics.Process.Start(Path);
                }
                else
                {
                    MessageBox.Show("File Not Exist.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            dynamic dialog = MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(ID_Txt.Text) && Status_Txt.Text == "Pending" && dialog == DialogResult.Yes)
            {
                string id = ID_Txt.Text;
                string i = I_Txt.Text;
                try
                {
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "INSERT INTO T_NotificationRecycle (ID,N_ID, N_CustName, N_ItemName, N_Model, N_ItemDes, N_SystemID, N_SONum, N_Date, N_ConNum, N_Details, N_Status)" +
                                        "SELECT ID,N_ID, N_CustName, N_ItemName, N_Model, N_ItemDes, N_SystemID, N_SONum, N_Date, N_ConNum, N_Details, N_Status FROM T_Notification WHERE N_ID=@0;" +
                                        "DELETE FROM T_Notification WHERE N_ID=@0;" +
                                        "UPDATE T_NotificationRecycle SET DDate = @1, DUserName= 2 WHERE N_ID = @0";
                    Cmd.Parameters.AddWithValue("@0", ID_Txt.Text);
                    Cmd.Parameters.AddWithValue("@1", DateTime.Now);
                    Cmd.Parameters.AddWithValue("@2", Login.Instance.UserName);
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                    T_NotifyTabAd.Fill(GESet.T_Notification);
                    T_NotifyBindSour.MoveLast();
                    MessageBoxEx.Show("Data Deleted", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Delete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Notification-2004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string SourceFile = @"GE Data\Report\" + id + ".pdf";
                string DesFile = @"GE Data\ReportRecycle\" + i + "~" + id + "~" + DateTime.Now.ToString("yyyy-MM-dd~hh-mm-ss tt", CultureInfo.CreateSpecificCulture("en-us")) + ".pdf";
                File.Move(SourceFile, DesFile);
            }
            else if (dialog == DialogResult.No)
            {
                return;
            }
            else
            {
                MessageBox.Show("Can't Editing Because it Solved or Waiting Spare Part. " + "\r\n" + "Please Recheck Your Data.", Resources.M00, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Name_Txt_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                Cmd.Connection = Con;
                Cmd.CommandText = "SELECT S_Model,S_ItemDesc,S_SysID,S_SONum FROM T_System WHERE S_ItemName = @0";
                Cmd.Parameters.AddWithValue("@0", ItemName_Txt.Text);

                SqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Model_Txt.Text          = Reader["S_Model"].ToString();
                    ItemDes_Txt.Text        = Reader["S_ItemDesc"].ToString();
                    SystemID_Txt.Text       = Reader["S_SysID"].ToString();
                    SONumber_Txt.Text       = Reader["S_SONum"].ToString();
                }
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Get Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Notification-2003", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void English_Enter(object sender, EventArgs e)
        {
            SwitchInput(GetInput("english"));
        }


        /* Function*/
        private void Edit(bool Value, bool Value2)
        {
            Save_Btn.Enabled = Value2;
            CustomerName_Txt.ReadOnly = Value;
            ItemName_Txt.Enabled = Value2;
            Model_Txt.Enabled = Value;
            ItemDes_Txt.Enabled = Value;
            SystemID_Txt.Enabled = Value;
            SONumber_Txt.Enabled = Value;
            Date_Txt.Enabled = Value2;
            ContactNumber_Txt.ReadOnly = Value;
            Details_Txt.ReadOnly = Value;
            Status_Txt.Enabled = Value2;
        }

        public static InputLanguage GetInput(string inputName)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.Culture.EnglishName.StartsWith(inputName, StringComparison.CurrentCultureIgnoreCase))
                {
                    return lang;
                }
            }
            return null;
        }

        private void SwitchInput(InputLanguage layout) => InputLanguage.CurrentInputLanguage = layout;

        public void PDF()
        {
            string Path = @"GE Data\Report\" + ID_Txt.Text + ".pdf";
            try
            {
                Document document = new Document(PageSize.A4, 43, 43, 43, 43);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(Path, FileMode.Create));
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
                mm.Add(ph1);
                para.Add(mm);
                document.Add(para);
                document.Close();

                string WatermarkLocation = @"GE Data\GE Logo.PNG";
                byte[] bytes = File.ReadAllBytes(Path);
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
                File.WriteAllBytes(Path, bytes);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Saving The PDF File." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Notification-2005", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
