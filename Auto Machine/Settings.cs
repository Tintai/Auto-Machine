using System;
using System.Resources;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Microsoft.Win32;

namespace Auto_Machine
{
    public partial class Settings : Form
    {
        #region Language
        private void SetLanguage(string language)
        {
            ResourceManager appLanguage = new ResourceManager("Auto_Machine.Resources.language_" + language, Assembly.GetExecutingAssembly());

            groupBox_language.Text = appLanguage.GetString("Language");
            label_language.Text = appLanguage.GetString("ApplicationLanguage");
            groupBox_basic.Text = appLanguage.GetString("Basic");
            checkBox_showonstartup.Text = appLanguage.GetString("StartAtWindowsStartup");
            checkBox_savetoconfig.Text = appLanguage.GetString("SaveSettingsToSystemRegistry");
            checkBox_actionmenu.Text = appLanguage.GetString("ShowDoActionInMenu");
            groupBox_reseting.Text = appLanguage.GetString("Reset");
            label_reseting.Text = appLanguage.GetString("ResetDesc");
            button_resetsettings.Text = appLanguage.GetString("ResetButton");
        }
        #endregion

        #region Main
        private AutoMachine MainForm;
        RegistryKey run = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public Settings(AutoMachine MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            SetLanguage(MainForm.language);
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            if (MainForm.language == "en")
                comboBox_language.SelectedIndex = 0;
            else if (MainForm.language == "pl")
                comboBox_language.SelectedIndex = 1;
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 8;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height - 7;
            this.Location = new Point(x, y);
            if (run.GetValue(Application.ProductName) != null)
                checkBox_showonstartup.Checked = true;
            else
                checkBox_showonstartup.Checked = false;
            object savetoconfig = MainForm.mainkey.GetValue("SaveToConfig");
            if (savetoconfig.ToString() == "true")
                checkBox_savetoconfig.Checked = true;
            else if (savetoconfig.ToString() == "false")
                checkBox_savetoconfig.Checked = false;
            if (MainForm.savetoconfig == true)
            {
                object actionmenu = MainForm.mainkey.GetValue("ShowActionMenu");
                if (actionmenu.ToString() == "true")
                    MainForm.showactionmenu = true;
                else if (actionmenu.ToString() == "false")
                    MainForm.showactionmenu = false;
                if (MainForm.showactionmenu == true)
                    checkBox_actionmenu.Checked = true;
                else
                    checkBox_actionmenu.Checked = false;
            }
            MainForm.settingopen = true;
        }
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.settingopen = false;
        }
        private void button_resetsettings_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz przywrócić wszystkie ustawienia do domyślnych wartości?", "Resetowanie ustawień", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MainForm.registry_reset();
            }
        }
        #endregion

        #region CheckBoxes
        private void checkBox_showonstartup_CheckedChanged(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(Application.ExecutablePath) + "\\";
            string app = Application.ProductName;
            string ext = Path.GetExtension(Application.ExecutablePath).ToLower();
            run.DeleteValue(Application.ProductName, false);
            if (checkBox_showonstartup.Checked == true)
                run.SetValue(Application.ProductName, dir + app + ext + " /autorun", RegistryValueKind.String);
        }
        private void checkBox_savetoconfig_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.mainkey.SetValue("SaveToConfig", checkBox_savetoconfig.Checked.ToString().ToLower());
        }
        private void checkBox_actionmenu_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.mainkey.SetValue("ShowActionMenu", checkBox_actionmenu.Checked.ToString().ToLower());
            MainForm.AM_contextMenuStrip.Items[0].Visible = checkBox_actionmenu.Checked;
            MainForm.AM_contextMenuStrip.Items[1].Visible = checkBox_actionmenu.Checked;
        }

        private void comboBox_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lang;
            switch (comboBox_language.SelectedIndex + 1)
            {
                case 1:
                    lang = "en";
                    break;
                case 2:
                    lang = "pl";
                    break;
                default:
                    lang = "en";
                    break;
            }
            MainForm.mainkey.SetValue("Language", lang);
            MainForm.language = lang;
            SetLanguage(lang);
            MainForm.SetLanguage();
        }
        #endregion

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
