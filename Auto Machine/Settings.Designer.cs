namespace Auto_Machine
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.groupBox_basic = new System.Windows.Forms.GroupBox();
            this.checkBox_showonstartup = new System.Windows.Forms.CheckBox();
            this.checkBox_savetoconfig = new System.Windows.Forms.CheckBox();
            this.checkBox_actionmenu = new System.Windows.Forms.CheckBox();
            this.groupBox_reseting = new System.Windows.Forms.GroupBox();
            this.label_reseting = new System.Windows.Forms.Label();
            this.button_resetsettings = new System.Windows.Forms.Button();
            this.groupBox_language = new System.Windows.Forms.GroupBox();
            this.label_language = new System.Windows.Forms.Label();
            this.comboBox_language = new System.Windows.Forms.ComboBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.groupBox_basic.SuspendLayout();
            this.groupBox_reseting.SuspendLayout();
            this.groupBox_language.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_basic
            // 
            this.groupBox_basic.Controls.Add(this.checkBox_showonstartup);
            this.groupBox_basic.Controls.Add(this.checkBox_savetoconfig);
            this.groupBox_basic.Controls.Add(this.checkBox_actionmenu);
            resources.ApplyResources(this.groupBox_basic, "groupBox_basic");
            this.groupBox_basic.Name = "groupBox_basic";
            this.groupBox_basic.TabStop = false;
            // 
            // checkBox_showonstartup
            // 
            resources.ApplyResources(this.checkBox_showonstartup, "checkBox_showonstartup");
            this.checkBox_showonstartup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_showonstartup.Name = "checkBox_showonstartup";
            this.checkBox_showonstartup.UseVisualStyleBackColor = true;
            this.checkBox_showonstartup.CheckedChanged += new System.EventHandler(this.checkBox_showonstartup_CheckedChanged);
            // 
            // checkBox_savetoconfig
            // 
            resources.ApplyResources(this.checkBox_savetoconfig, "checkBox_savetoconfig");
            this.checkBox_savetoconfig.Checked = true;
            this.checkBox_savetoconfig.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_savetoconfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_savetoconfig.Name = "checkBox_savetoconfig";
            this.checkBox_savetoconfig.UseVisualStyleBackColor = true;
            this.checkBox_savetoconfig.CheckedChanged += new System.EventHandler(this.checkBox_savetoconfig_CheckedChanged);
            // 
            // checkBox_actionmenu
            // 
            resources.ApplyResources(this.checkBox_actionmenu, "checkBox_actionmenu");
            this.checkBox_actionmenu.Checked = true;
            this.checkBox_actionmenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_actionmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_actionmenu.Name = "checkBox_actionmenu";
            this.checkBox_actionmenu.UseVisualStyleBackColor = true;
            this.checkBox_actionmenu.CheckedChanged += new System.EventHandler(this.checkBox_actionmenu_CheckedChanged);
            // 
            // groupBox_reseting
            // 
            this.groupBox_reseting.Controls.Add(this.label_reseting);
            this.groupBox_reseting.Controls.Add(this.button_resetsettings);
            resources.ApplyResources(this.groupBox_reseting, "groupBox_reseting");
            this.groupBox_reseting.Name = "groupBox_reseting";
            this.groupBox_reseting.TabStop = false;
            // 
            // label_reseting
            // 
            resources.ApplyResources(this.label_reseting, "label_reseting");
            this.label_reseting.Name = "label_reseting";
            // 
            // button_resetsettings
            // 
            this.button_resetsettings.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button_resetsettings, "button_resetsettings");
            this.button_resetsettings.Name = "button_resetsettings";
            this.button_resetsettings.UseVisualStyleBackColor = true;
            this.button_resetsettings.Click += new System.EventHandler(this.button_resetsettings_Click);
            // 
            // groupBox_language
            // 
            this.groupBox_language.Controls.Add(this.label_language);
            this.groupBox_language.Controls.Add(this.comboBox_language);
            resources.ApplyResources(this.groupBox_language, "groupBox_language");
            this.groupBox_language.Name = "groupBox_language";
            this.groupBox_language.TabStop = false;
            // 
            // label_language
            // 
            resources.ApplyResources(this.label_language, "label_language");
            this.label_language.Name = "label_language";
            // 
            // comboBox_language
            // 
            this.comboBox_language.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_language.FormattingEnabled = true;
            this.comboBox_language.Items.AddRange(new object[] {
            resources.GetString("comboBox_language.Items"),
            resources.GetString("comboBox_language.Items1")});
            resources.ApplyResources(this.comboBox_language, "comboBox_language");
            this.comboBox_language.Name = "comboBox_language";
            this.comboBox_language.SelectedIndexChanged += new System.EventHandler(this.comboBox_language_SelectedIndexChanged);
            // 
            // button_exit
            // 
            resources.ApplyResources(this.button_exit, "button_exit");
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Name = "button_exit";
            this.button_exit.TabStop = false;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.groupBox_language);
            this.Controls.Add(this.groupBox_reseting);
            this.Controls.Add(this.groupBox_basic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox_basic.ResumeLayout(false);
            this.groupBox_basic.PerformLayout();
            this.groupBox_reseting.ResumeLayout(false);
            this.groupBox_reseting.PerformLayout();
            this.groupBox_language.ResumeLayout(false);
            this.groupBox_language.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_basic;
        private System.Windows.Forms.CheckBox checkBox_actionmenu;
        private System.Windows.Forms.GroupBox groupBox_reseting;
        private System.Windows.Forms.CheckBox checkBox_savetoconfig;
        private System.Windows.Forms.CheckBox checkBox_showonstartup;
        private System.Windows.Forms.Button button_resetsettings;
        private System.Windows.Forms.Label label_reseting;
        private System.Windows.Forms.GroupBox groupBox_language;
        private System.Windows.Forms.Label label_language;
        private System.Windows.Forms.ComboBox comboBox_language;
        private System.Windows.Forms.Button button_exit;
    }
}