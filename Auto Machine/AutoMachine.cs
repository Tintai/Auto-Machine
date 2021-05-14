using System;
using System.Resources;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;
namespace Auto_Machine
{
    public partial class AutoMachine : Form
    {
        #region Language
        public void SetLanguage()
        {
            ResourceManager appLanguage = new ResourceManager("Auto_Machine.Resources.language_" + language, Assembly.GetExecutingAssembly());

            time_groupBox.Text = appLanguage.GetString("Time");
            time_radioButton_type1.Text = appLanguage.GetString("StartTaskAt");
            time_radioButton_type2.Text = appLanguage.GetString("StartTaskIn");
            action_groupBox.Text = appLanguage.GetString("Action");
            action_label_info.Text = appLanguage.GetString("ActionDesc");
            action_checkBox_force.Text = appLanguage.GetString("ForceAction");
            action_checkBox_warnings.Text = appLanguage.GetString("ShowWarnings");

            action_comboBox.Items[0] = appLanguage.GetString("Shutdown");    // 0
            menu_action_shoutdown.Text = appLanguage.GetString("Shutdown");
            action_comboBox.Items[1] = appLanguage.GetString("Reboot");      // 1
            menu_action_restart.Text = appLanguage.GetString("Reboot");
            action_comboBox.Items[2] = appLanguage.GetString("Logout");      // 2
            menu_action_logout.Text = appLanguage.GetString("Logout");
            action_comboBox.Items[3] = appLanguage.GetString("Lock");        // 3
            menu_action_lock.Text = appLanguage.GetString("Lock");
            action_comboBox.Items[4] = appLanguage.GetString("Sleep");       // 4
            menu_action_sleep.Text = appLanguage.GetString("Sleep");
            action_comboBox.Items[5] = appLanguage.GetString("Hibernate");   // 5
            menu_action_hibernate.Text = appLanguage.GetString("Hibernate");

            menu_actions.Text = appLanguage.GetString("CMSAction");
            menu_settings.Text = appLanguage.GetString("CMSSettings");
            menu_about.Text = appLanguage.GetString("CMSAbout");
            menu_show.Text = appLanguage.GetString("CMSShow");
            menu_exit.Text = appLanguage.GetString("CMSExit");

            AM_notifyIcon.BalloonTipTitle = appLanguage.GetString("AbortTaskTip");
            AM_notifyIcon.BalloonTipText = appLanguage.GetString("AbortTaskTipDesc");

            WRN_Task = appLanguage.GetString("WRN_Task");
            WRN_TaskSec = appLanguage.GetString("WRN_TaskSec");
            WRN_ActionNow = appLanguage.GetString("WRN_ActionNow");
            WRN_ActionCancel = appLanguage.GetString("WRN_ActionCancel");

            language_at = appLanguage.GetString("At");


        }
        #endregion

        #region Settings
        [DllImport("user32")]
        public static extern void LockWorkStation();
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        DateTime timer_time;
        public RegistryKey mainkey = Registry.CurrentUser.CreateSubKey("Software\\AutoMachine");
        public bool savetoconfig;
        public bool showactionmenu;
        public int timer_action;
        public bool cancel = false;
        public bool start = false;
        public string language;
        public string language_at;
        public string actionTxt;
        bool timer_force;
        bool timer_warnings;
        int warning1 = 0;
        int warning2 = 0;
        public bool aboutopen = false;
        public bool settingopen = false;

        public string WRN_Task; public string WRN_TaskSec; public string WRN_ActionNow; public string WRN_ActionCancel;

        #endregion

        #region Main
        public AutoMachine()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message message)
        {
            const int WM_NCHITTEST = 0x0084;
            switch (message.Msg)
            {
                case WM_NCHITTEST:
                    return;
            }
            base.WndProc(ref message);
        }
        private void AutoMachine_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 8;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height - 7;
            this.Location = new Point(x, y);
            string time = "00:01";
            time_dateTimePicker_type2.Value = DateTime.ParseExact(time, "HH:mm", null);
            opensettings();
            SetLanguage();
            AM_contextMenuStrip.Items[0].Visible = showactionmenu;
            AM_contextMenuStrip.Items[1].Visible = showactionmenu;
        }
        private void AutoMachine_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void main_button_Click(object sender, EventArgs e)
        {
            actionTxt = action_comboBox.Text;

            if (start == false)
            {
                start = true;
                time_groupBox.Enabled = false;
                action_groupBox.Enabled = false;
                start_action(time_radioButton_type1.Checked, time_radioButton_type2.Checked, time_dateTimePicker_type1.Value, time_dateTimePicker_type2.Value,
                    action_comboBox.SelectedIndex + 1, action_checkBox_force.Checked, action_checkBox_warnings.Checked);
            }
            else
            {
                stop_action(false);
                start = false;
            }
        }
        #endregion

        #region Time
        private void time_radioButton_type1_CheckedChanged(object sender, EventArgs e)
        {
            time_dateTimePicker_type1.Enabled = true;
            time_dateTimePicker_type2.Enabled = false;
            mainkey.SetValue("DefaultType", "type1");
        }
        private void time_radioButton_type2_CheckedChanged(object sender, EventArgs e)
        {
            time_dateTimePicker_type1.Enabled = false;
            time_dateTimePicker_type2.Enabled = true;
            mainkey.SetValue("DefaultType", "type2");
        }
        #endregion

        #region Contex menu
        private void CloseForms()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "AutoMachine")
                    Application.OpenForms[i].Close();
            }
        }
        private void menu_exit_Click(object sender, EventArgs e)
        {
            AM_notifyIcon.Visible = false;
            Application.Exit();
        }
        private void menu_show_Click(object sender, EventArgs e)
        {
            CloseForms();
            this.Show();
            this.Activate();
        }    
        private void menu_about_Click(object sender, EventArgs e)
        {
            var about = new About(this);
            if (aboutopen == false && settingopen == false)
            {
                about.Show();
            }
            else if (aboutopen == false && settingopen == true)
            {
                Settings settings = (Settings)Application.OpenForms["Settings"];
                settings.Close();
                about.Show();
            }
        }
        private void menu_settings_Click(object sender, EventArgs e)
        {
            var settings = new Settings(this);
            if (aboutopen == false && settingopen == false)
            {
                settings.Show();
            }
            else if (aboutopen == true && settingopen == false)
            {
                About about = (About)Application.OpenForms["About"];
                about.Close();
                settings.Show();
            }
        }
        private void menu_action_shoutdown_Click(object sender, EventArgs e)
        {
            timer_force = true;
            action(1);
        }
        private void menu_action_restart_Click(object sender, EventArgs e)
        {
            timer_force = true;
            action(2);
        }
        private void menu_action_logout_Click(object sender, EventArgs e)
        {
            action(3);
        }
        private void menu_action_lock_Click(object sender, EventArgs e)
        {
            action(4);
        }
        private void menu_action_sleep_Click(object sender, EventArgs e)
        {
            action(5);
        }
        private void menu_action_hibernate_Click(object sender, EventArgs e)
        {
            action(6);
        }
        #endregion

        #region Others
        private void AM_contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            menu_settings.Enabled = !settingopen;
            menu_about.Enabled = !aboutopen;
        }
        private void AM_notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CloseForms();
                this.Show();
                this.Activate();
            }
        }
        private void AM_timer_Tick(object sender, EventArgs e)
        {
            if (timer_warnings == true)
            {
                if (DateTime.Now.ToLongTimeString() == timer_time.AddMinutes(-2).ToLongTimeString())
                {
                    while(warning1 == 0)
                    {
                        AM_notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                        AM_notifyIcon.BalloonTipTitle = action_comboBox.Text;
                        AM_notifyIcon.BalloonTipText = WRN_Task + " 2 " + WRN_TaskSec;
                        AM_notifyIcon.ShowBalloonTip(10);
                        warning1 = 1;
                    }
                }
                if (DateTime.Now.ToLongTimeString() == timer_time.AddMinutes(-1).ToLongTimeString())
                {
                    while (warning2 == 0)
                    {
                        Warning warningform = new Warning(this);
                        warningform.ShowDialog();
                        warning2 = 1;
                    }
                }
            }
            if (cancel == false)
            {
                if (DateTime.Now.ToLongTimeString() == timer_time.ToLongTimeString())
                {
                    action(timer_action);
                    stop_action(false);
                }
            }
            else
            {
                stop_action(true);
            }
        }
        private void time_dateTimePicker_type1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0) SendKeys.Send("{UP}");
            else SendKeys.Send("{DOWN}");
        }
        private void time_dateTimePicker_type2_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0) SendKeys.Send("{UP}");
            else SendKeys.Send("{DOWN}");
        }
        private void action_checkBox_force_CheckedChanged(object sender, EventArgs e)
        {
            mainkey.SetValue("Force", action_checkBox_force.Checked.ToString().ToLower());
        }
        private void action_checkBox_warnings_CheckedChanged(object sender, EventArgs e)
        {
            mainkey.SetValue("Warnings", action_checkBox_warnings.Checked.ToString().ToLower());
        }
        private void action_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string action;
            if (action_comboBox.SelectedIndex == 0)
                action = "shoutdown";
            else if (action_comboBox.SelectedIndex == 1)
                action = "reboot";
            else if (action_comboBox.SelectedIndex == 2)
                action = "logout";
            else if (action_comboBox.SelectedIndex == 3)
                action = "lock";
            else if (action_comboBox.SelectedIndex == 4)
                action = "sleep";
            else if (action_comboBox.SelectedIndex == 5)
                action = "hibernate";
            else
                action = "shoutdown";
            mainkey.SetValue("DefaultAction", action);
        }
        #endregion

        #region References
        private void start_action(bool type1, bool type2, DateTime type1time, DateTime type2time, int action, bool force, bool warnings)
        {
            if (type1 == true)
            {
                main_label.Text = String.Format("{0} {1} {2}", actionTxt, language_at, type1time.ToLongTimeString());
                AM_notifyIcon.Text = main_label.Text;
                timer_time = type1time; timer_action = action; timer_force = force; timer_warnings = warnings;
                AM_timer.Start();
            }
            if (type2 == true)
            {
                type2time = type2time + DateTime.Now.TimeOfDay;
                main_label.Text = String.Format("{0} {1} {2}", actionTxt, language_at, type2time.ToLongTimeString());
                AM_notifyIcon.Text = main_label.Text;
                timer_time = type2time; timer_action = action; timer_force = force; timer_warnings = warnings;
                AM_timer.Start();
            }
            main_button.Text = "Stop";
        }
        public void stop_action(bool balloon)
        {
            AM_timer.Stop();
            time_groupBox.Enabled = true;
            action_groupBox.Enabled = true;
            main_button.Text = "Start";
            main_label.Text = "Auto Machine";
            AM_notifyIcon.Text = main_label.Text;
            if (balloon == true)
            {
                AM_notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                
                AM_notifyIcon.ShowBalloonTip(5);
            }
            warning1 = 0;
            warning2 = 0;
            cancel = false;
        }
        public void action(int type)
        {
            if (type == 1)
            {
                if (timer_force == true)
                    Process.Start("shutdown", "/s /t 0 /f");
                else
                    Process.Start("shutdown", "/s /t 0");
            }
            if (type == 2)
            {
                if (timer_force == true)
                    Process.Start("shutdown", "/r /t 0 /f");
                else
                    Process.Start("shutdown", "/r /t 0");
            }
            if (type == 3)
            {
                ExitWindowsEx(4, 0);
            }
            if (type == 4)
            {
                LockWorkStation(); 
            }
            if (type == 5)
            {
                bool retVal = Application.SetSuspendState(PowerState.Suspend, true, false);
            }
            if (type == 6)
            {
                bool retVal = Application.SetSuspendState(PowerState.Hibernate, true, false);
            }
        }
        private void opensettings()
        {
            if (mainkey.ValueCount != 7)
                registry_reset();
            object reg1 = mainkey.GetValue("SaveToConfig");
            if (reg1.ToString() == "true")
                savetoconfig = true;
            else if (reg1.ToString() == "false")
                savetoconfig = false;
            else
            {
                savetoconfig = true;
                mainkey.SetValue("SaveToConfig", "true");
            }
            if (savetoconfig == true)
            {
                object reg2 = mainkey.GetValue("DefaultType");
                if (reg2.ToString() == "type1")
                    time_radioButton_type1.Checked = true;
                else if (reg2.ToString() == "type2")
                    time_radioButton_type2.Checked = true;
                else
                {
                    time_radioButton_type1.Checked = true;
                    mainkey.SetValue("DefaultType", "type1");
                }
                object reg3 = mainkey.GetValue("DefaultAction");
                if (reg3.ToString() == "shutdown")
                    action_comboBox.SelectedIndex = 0;
                else if (reg3.ToString() == "reboot")
                    action_comboBox.SelectedIndex = 1;
                else if (reg3.ToString() == "logout")
                    action_comboBox.SelectedIndex = 2;
                else if (reg3.ToString() == "lock")
                    action_comboBox.SelectedIndex = 3;
                else if (reg3.ToString() == "sleep")
                    action_comboBox.SelectedIndex = 4;
                else if (reg3.ToString() == "hibernate")
                    action_comboBox.SelectedIndex = 6;
                else
                {
                    action_comboBox.SelectedIndex = 0;
                    mainkey.SetValue("DefaultAction", "shutdown");
                }
                object reg4 = mainkey.GetValue("Force");
                if (reg4.ToString() == "true")
                    action_checkBox_force.Checked = true;
                else if (reg4.ToString() == "false")
                    action_checkBox_force.Checked = false;
                else
                {
                    action_checkBox_force.Checked = true;
                    mainkey.SetValue("Force", "true");
                }
                object reg5 = mainkey.GetValue("Warnings");
                if (reg5.ToString() == "true")
                    action_checkBox_warnings.Checked = true;
                else if (reg5.ToString() == "false")
                    action_checkBox_warnings.Checked = false;
                else
                {
                    action_checkBox_warnings.Checked = true;
                    mainkey.SetValue("Warnings", "true");
                }
                object reg6 = mainkey.GetValue("ShowActionMenu");
                if (reg6.ToString() == "true")
                    showactionmenu = true;
                else if (reg6.ToString() == "false")
                    showactionmenu = false;
                else
                {
                    showactionmenu = true;
                    mainkey.SetValue("ShowActionMenu", "true");
                }
            }
            else
            {
                action_comboBox.SelectedIndex = 0;
                showactionmenu = true;
            }
            language = mainkey.GetValue("Language").ToString();
        }
        public void registry_reset()
        {
            mainkey.SetValue("SaveToConfig", "true");
            mainkey.SetValue("DefaultType", "type1");
            mainkey.SetValue("DefaultAction", "shutdown");
            mainkey.SetValue("Force", "true");
            mainkey.SetValue("Warnings", "true");
            mainkey.SetValue("ShowActionMenu", "true");
            mainkey.SetValue("Language", "en");
        }
        #endregion
    }
}