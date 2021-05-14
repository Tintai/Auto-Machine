using System;
using System.Resources;
using System.Reflection;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Auto_Machine
{
    public partial class About : Form
    {
        #region Language
        private void SetLanguage(string language)
        {
            ResourceManager appLanguage = new ResourceManager("Auto_Machine.Resources.language_" + language, Assembly.GetExecutingAssembly());
            label_version.Text = appLanguage.GetString("Version");
            label_contact.Text = appLanguage.GetString("Contact");
        }
        #endregion

        #region Main
        private AutoMachine MainForm;
        public About(AutoMachine MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            SetLanguage(MainForm.language);
        }
        private void About_Load(object sender, EventArgs e)
        {
            MainForm.aboutopen = true;
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 8;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height - 7;
            this.Location = new Point(x, y);
            label_version.Text = label_version.Text + (": " + version);
            label_copyright.Text = copyright;
        }
        private void About_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.aboutopen = false;
        }
        private void linkLabel_contact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:tinexcs@gmail.com");
        }
        #endregion

        #region References
        public string version
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        public string copyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }
        #endregion

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
