namespace Auto_Machine
{
    partial class AutoMachine
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoMachine));
            this.main_label = new System.Windows.Forms.Label();
            this.time_groupBox = new System.Windows.Forms.GroupBox();
            this.time_dateTimePicker_type2 = new System.Windows.Forms.DateTimePicker();
            this.time_dateTimePicker_type1 = new System.Windows.Forms.DateTimePicker();
            this.time_radioButton_type2 = new System.Windows.Forms.RadioButton();
            this.time_radioButton_type1 = new System.Windows.Forms.RadioButton();
            this.action_groupBox = new System.Windows.Forms.GroupBox();
            this.action_checkBox_force = new System.Windows.Forms.CheckBox();
            this.action_checkBox_warnings = new System.Windows.Forms.CheckBox();
            this.action_label_info = new System.Windows.Forms.Label();
            this.action_comboBox = new System.Windows.Forms.ComboBox();
            this.main_button = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.AM_notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.AM_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_actions = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_action_shoutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_action_restart = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_action_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_action_lock = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_action_sleep = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_action_hibernate = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_show = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.AM_timer = new System.Windows.Forms.Timer(this.components);
            this.time_groupBox.SuspendLayout();
            this.action_groupBox.SuspendLayout();
            this.AM_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.Location = new System.Drawing.Point(9, 14);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(73, 13);
            this.main_label.TabIndex = 0;
            this.main_label.Text = "Auto Machine";
            // 
            // time_groupBox
            // 
            this.time_groupBox.Controls.Add(this.time_dateTimePicker_type2);
            this.time_groupBox.Controls.Add(this.time_dateTimePicker_type1);
            this.time_groupBox.Controls.Add(this.time_radioButton_type2);
            this.time_groupBox.Controls.Add(this.time_radioButton_type1);
            this.time_groupBox.Location = new System.Drawing.Point(12, 34);
            this.time_groupBox.Name = "time_groupBox";
            this.time_groupBox.Size = new System.Drawing.Size(247, 68);
            this.time_groupBox.TabIndex = 1;
            this.time_groupBox.TabStop = false;
            this.time_groupBox.Text = "Czas";
            // 
            // time_dateTimePicker_type2
            // 
            this.time_dateTimePicker_type2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.time_dateTimePicker_type2.CustomFormat = "HH:mm:ss";
            this.time_dateTimePicker_type2.Enabled = false;
            this.time_dateTimePicker_type2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_dateTimePicker_type2.Location = new System.Drawing.Point(174, 39);
            this.time_dateTimePicker_type2.Name = "time_dateTimePicker_type2";
            this.time_dateTimePicker_type2.ShowUpDown = true;
            this.time_dateTimePicker_type2.Size = new System.Drawing.Size(67, 20);
            this.time_dateTimePicker_type2.TabIndex = 3;
            this.time_dateTimePicker_type2.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.time_dateTimePicker_type2_MouseWheel);
            // 
            // time_dateTimePicker_type1
            // 
            this.time_dateTimePicker_type1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.time_dateTimePicker_type1.CustomFormat = "HH:mm:ss";
            this.time_dateTimePicker_type1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_dateTimePicker_type1.Location = new System.Drawing.Point(174, 16);
            this.time_dateTimePicker_type1.Name = "time_dateTimePicker_type1";
            this.time_dateTimePicker_type1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.time_dateTimePicker_type1.ShowUpDown = true;
            this.time_dateTimePicker_type1.Size = new System.Drawing.Size(67, 20);
            this.time_dateTimePicker_type1.TabIndex = 1;
            this.time_dateTimePicker_type1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.time_dateTimePicker_type1_MouseWheel);
            // 
            // time_radioButton_type2
            // 
            this.time_radioButton_type2.AutoSize = true;
            this.time_radioButton_type2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.time_radioButton_type2.Location = new System.Drawing.Point(6, 42);
            this.time_radioButton_type2.Name = "time_radioButton_type2";
            this.time_radioButton_type2.Size = new System.Drawing.Size(125, 17);
            this.time_radioButton_type2.TabIndex = 2;
            this.time_radioButton_type2.TabStop = true;
            this.time_radioButton_type2.Text = "Uruchom zadanie za:";
            this.time_radioButton_type2.UseVisualStyleBackColor = true;
            this.time_radioButton_type2.CheckedChanged += new System.EventHandler(this.time_radioButton_type2_CheckedChanged);
            // 
            // time_radioButton_type1
            // 
            this.time_radioButton_type1.AutoSize = true;
            this.time_radioButton_type1.Checked = true;
            this.time_radioButton_type1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.time_radioButton_type1.Location = new System.Drawing.Point(6, 19);
            this.time_radioButton_type1.Name = "time_radioButton_type1";
            this.time_radioButton_type1.Size = new System.Drawing.Size(162, 17);
            this.time_radioButton_type1.TabIndex = 0;
            this.time_radioButton_type1.TabStop = true;
            this.time_radioButton_type1.Text = "Uruchom zadanie o godzinie:";
            this.time_radioButton_type1.UseVisualStyleBackColor = true;
            this.time_radioButton_type1.CheckedChanged += new System.EventHandler(this.time_radioButton_type1_CheckedChanged);
            // 
            // action_groupBox
            // 
            this.action_groupBox.Controls.Add(this.action_checkBox_force);
            this.action_groupBox.Controls.Add(this.action_checkBox_warnings);
            this.action_groupBox.Controls.Add(this.action_label_info);
            this.action_groupBox.Controls.Add(this.action_comboBox);
            this.action_groupBox.Location = new System.Drawing.Point(12, 108);
            this.action_groupBox.Name = "action_groupBox";
            this.action_groupBox.Size = new System.Drawing.Size(247, 112);
            this.action_groupBox.TabIndex = 2;
            this.action_groupBox.TabStop = false;
            this.action_groupBox.Text = "Akcja";
            // 
            // action_checkBox_force
            // 
            this.action_checkBox_force.AutoSize = true;
            this.action_checkBox_force.Checked = true;
            this.action_checkBox_force.CheckState = System.Windows.Forms.CheckState.Checked;
            this.action_checkBox_force.Cursor = System.Windows.Forms.Cursors.Hand;
            this.action_checkBox_force.Location = new System.Drawing.Point(6, 65);
            this.action_checkBox_force.Name = "action_checkBox_force";
            this.action_checkBox_force.Size = new System.Drawing.Size(90, 17);
            this.action_checkBox_force.TabIndex = 2;
            this.action_checkBox_force.Text = "Wymuś akcję";
            this.action_checkBox_force.UseVisualStyleBackColor = true;
            this.action_checkBox_force.CheckedChanged += new System.EventHandler(this.action_checkBox_force_CheckedChanged);
            // 
            // action_checkBox_warnings
            // 
            this.action_checkBox_warnings.AutoSize = true;
            this.action_checkBox_warnings.Checked = true;
            this.action_checkBox_warnings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.action_checkBox_warnings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.action_checkBox_warnings.Location = new System.Drawing.Point(6, 88);
            this.action_checkBox_warnings.Name = "action_checkBox_warnings";
            this.action_checkBox_warnings.Size = new System.Drawing.Size(124, 17);
            this.action_checkBox_warnings.TabIndex = 3;
            this.action_checkBox_warnings.Text = "Wyświetl ostrzeżenia";
            this.action_checkBox_warnings.UseVisualStyleBackColor = true;
            this.action_checkBox_warnings.CheckedChanged += new System.EventHandler(this.action_checkBox_warnings_CheckedChanged);
            // 
            // action_label_info
            // 
            this.action_label_info.AutoSize = true;
            this.action_label_info.Location = new System.Drawing.Point(3, 22);
            this.action_label_info.Name = "action_label_info";
            this.action_label_info.Size = new System.Drawing.Size(200, 13);
            this.action_label_info.TabIndex = 0;
            this.action_label_info.Text = "Zadanie wykonywane po upływie czasu:";
            // 
            // action_comboBox
            // 
            this.action_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.action_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.action_comboBox.FormattingEnabled = true;
            this.action_comboBox.Items.AddRange(new object[] {
            "Zamknij system",
            "Uruchom ponownie",
            "Wyloguj",
            "Zablokuj",
            "Uśpij",
            "Hibernacja"});
            this.action_comboBox.Location = new System.Drawing.Point(6, 38);
            this.action_comboBox.Name = "action_comboBox";
            this.action_comboBox.Size = new System.Drawing.Size(132, 21);
            this.action_comboBox.TabIndex = 1;
            this.action_comboBox.SelectedIndexChanged += new System.EventHandler(this.action_comboBox_SelectedIndexChanged);
            // 
            // main_button
            // 
            this.main_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_button.Location = new System.Drawing.Point(179, 191);
            this.main_button.Name = "main_button";
            this.main_button.Size = new System.Drawing.Size(75, 23);
            this.main_button.TabIndex = 4;
            this.main_button.Text = "Start";
            this.main_button.UseVisualStyleBackColor = true;
            this.main_button.Click += new System.EventHandler(this.main_button_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(84, 254);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 3;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // AM_notifyIcon
            // 
            this.AM_notifyIcon.ContextMenuStrip = this.AM_contextMenuStrip;
            this.AM_notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("AM_notifyIcon.Icon")));
            this.AM_notifyIcon.Text = "Auto Machine";
            this.AM_notifyIcon.Visible = true;
            this.AM_notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AM_notifyIcon_MouseClick);
            // 
            // AM_contextMenuStrip
            // 
            this.AM_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_actions,
            this.menu_separator2,
            this.menu_settings,
            this.menu_about,
            this.menu_separator1,
            this.menu_show,
            this.menu_exit});
            this.AM_contextMenuStrip.Name = "AM_contextMenuStrip";
            this.AM_contextMenuStrip.Size = new System.Drawing.Size(151, 126);
            this.AM_contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.AM_contextMenuStrip_Opening);
            // 
            // menu_actions
            // 
            this.menu_actions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_action_shoutdown,
            this.menu_action_restart,
            this.menu_action_logout,
            this.menu_action_lock,
            this.menu_action_sleep,
            this.menu_action_hibernate});
            this.menu_actions.Name = "menu_actions";
            this.menu_actions.Size = new System.Drawing.Size(150, 22);
            this.menu_actions.Text = "Wykonaj akcję";
            // 
            // menu_action_shoutdown
            // 
            this.menu_action_shoutdown.Name = "menu_action_shoutdown";
            this.menu_action_shoutdown.Size = new System.Drawing.Size(180, 22);
            this.menu_action_shoutdown.Text = "Zamknij system";
            this.menu_action_shoutdown.Click += new System.EventHandler(this.menu_action_shoutdown_Click);
            // 
            // menu_action_restart
            // 
            this.menu_action_restart.Name = "menu_action_restart";
            this.menu_action_restart.Size = new System.Drawing.Size(180, 22);
            this.menu_action_restart.Text = "Uruchom ponownie";
            this.menu_action_restart.Click += new System.EventHandler(this.menu_action_restart_Click);
            // 
            // menu_action_logout
            // 
            this.menu_action_logout.Name = "menu_action_logout";
            this.menu_action_logout.Size = new System.Drawing.Size(180, 22);
            this.menu_action_logout.Text = "Wyloguj";
            this.menu_action_logout.Click += new System.EventHandler(this.menu_action_logout_Click);
            // 
            // menu_action_lock
            // 
            this.menu_action_lock.Name = "menu_action_lock";
            this.menu_action_lock.Size = new System.Drawing.Size(180, 22);
            this.menu_action_lock.Text = "Zablokuj";
            this.menu_action_lock.Click += new System.EventHandler(this.menu_action_lock_Click);
            // 
            // menu_action_sleep
            // 
            this.menu_action_sleep.Name = "menu_action_sleep";
            this.menu_action_sleep.Size = new System.Drawing.Size(180, 22);
            this.menu_action_sleep.Text = "Uśpij";
            this.menu_action_sleep.Click += new System.EventHandler(this.menu_action_sleep_Click);
            // 
            // menu_action_hibernate
            // 
            this.menu_action_hibernate.Name = "menu_action_hibernate";
            this.menu_action_hibernate.Size = new System.Drawing.Size(180, 22);
            this.menu_action_hibernate.Text = "Hibernacja";
            this.menu_action_hibernate.Click += new System.EventHandler(this.menu_action_hibernate_Click);
            // 
            // menu_separator2
            // 
            this.menu_separator2.Name = "menu_separator2";
            this.menu_separator2.Size = new System.Drawing.Size(147, 6);
            // 
            // menu_settings
            // 
            this.menu_settings.Name = "menu_settings";
            this.menu_settings.Size = new System.Drawing.Size(150, 22);
            this.menu_settings.Text = "Opcje";
            this.menu_settings.Click += new System.EventHandler(this.menu_settings_Click);
            // 
            // menu_about
            // 
            this.menu_about.Name = "menu_about";
            this.menu_about.Size = new System.Drawing.Size(150, 22);
            this.menu_about.Text = "O programie";
            this.menu_about.Click += new System.EventHandler(this.menu_about_Click);
            // 
            // menu_separator1
            // 
            this.menu_separator1.Name = "menu_separator1";
            this.menu_separator1.Size = new System.Drawing.Size(147, 6);
            // 
            // menu_show
            // 
            this.menu_show.Name = "menu_show";
            this.menu_show.Size = new System.Drawing.Size(150, 22);
            this.menu_show.Text = "Pokaż";
            this.menu_show.Click += new System.EventHandler(this.menu_show_Click);
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(150, 22);
            this.menu_exit.Text = "Wyjście";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // AM_timer
            // 
            this.AM_timer.Enabled = true;
            this.AM_timer.Interval = 1000;
            this.AM_timer.Tick += new System.EventHandler(this.AM_timer_Tick);
            // 
            // AutoMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(270, 228);
            this.ControlBox = false;
            this.Controls.Add(this.time_groupBox);
            this.Controls.Add(this.main_button);
            this.Controls.Add(this.main_label);
            this.Controls.Add(this.action_groupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AutoMachine";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Deactivate += new System.EventHandler(this.AutoMachine_Deactivate);
            this.Load += new System.EventHandler(this.AutoMachine_Load);
            this.time_groupBox.ResumeLayout(false);
            this.time_groupBox.PerformLayout();
            this.action_groupBox.ResumeLayout(false);
            this.action_groupBox.PerformLayout();
            this.AM_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label main_label;
        private System.Windows.Forms.GroupBox time_groupBox;
        private System.Windows.Forms.GroupBox action_groupBox;
        private System.Windows.Forms.DateTimePicker time_dateTimePicker_type1;
        private System.Windows.Forms.RadioButton time_radioButton_type2;
        private System.Windows.Forms.RadioButton time_radioButton_type1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label action_label_info;
        private System.Windows.Forms.ComboBox action_comboBox;
        private System.Windows.Forms.CheckBox action_checkBox_force;
        private System.Windows.Forms.CheckBox action_checkBox_warnings;
        private System.Windows.Forms.NotifyIcon AM_notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem menu_show;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.Button main_button;
        private System.Windows.Forms.DateTimePicker time_dateTimePicker_type2;
        private System.Windows.Forms.Timer AM_timer;
        private System.Windows.Forms.ToolStripMenuItem menu_actions;
        private System.Windows.Forms.ToolStripSeparator menu_separator2;
        private System.Windows.Forms.ToolStripMenuItem menu_about;
        private System.Windows.Forms.ToolStripSeparator menu_separator1;
        private System.Windows.Forms.ToolStripMenuItem menu_action_shoutdown;
        private System.Windows.Forms.ToolStripMenuItem menu_action_restart;
        private System.Windows.Forms.ToolStripMenuItem menu_action_logout;
        private System.Windows.Forms.ToolStripMenuItem menu_action_lock;
        private System.Windows.Forms.ToolStripMenuItem menu_action_sleep;
        private System.Windows.Forms.ToolStripMenuItem menu_action_hibernate;
        public System.Windows.Forms.ContextMenuStrip AM_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menu_settings;
    }
}

