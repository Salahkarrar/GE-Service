using System;
using System.Reflection;
using System.Windows.Forms;

namespace GE_Service
{
    internal partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            Text = String.Format("About {0}", GetAssemblyTitle());
            labelProductName.Text = GetAssemblyProduct();
            labelVersion.Text = String.Format("Version {0}", GetAssemblyVersion());
            labelCopyright.Text = GetAssemblyCopyright();
            labelCompanyName.Text = "Devoloper By: " + GetAssemblyCompany();
            textBoxDescription.Text = GetAssemblyDescription();
        }

        #region Assembly Attribute Accessors

        public string GetAssemblyTitle()
        {
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
            if (attributes.Length > 0)
            {
                AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                if (titleAttribute.Title != null)
                {
                    return titleAttribute.Title;
                }
            }
            return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
        }

        public string GetAssemblyVersion() => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public string GetAssemblyDescription()
        {
            if (Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false).Length == 0)
            {
                return "";
            }
            return ((AssemblyDescriptionAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false)[0]).Description;
        }

        public string GetAssemblyProduct()
        {
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
            if (attributes.Length == 0)
            {
                return "";
            }
            return ((AssemblyProductAttribute)attributes[0]).Product;
        }

        public string GetAssemblyCopyright()
        {
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            if (attributes.Length == 0)
            {
                return "";
            }
            return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
        }

        public string GetAssemblyCompany()
        {
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
            return attributes.Length != 0 ? ((AssemblyCompanyAttribute)attributes[0]).Company : "";
        }

        #endregion

        private void OkButton_Click(object sender, EventArgs e) => Close();
    }
}
