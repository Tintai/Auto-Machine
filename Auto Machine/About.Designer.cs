namespace Auto_Machine
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label_version = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label_copyright = new System.Windows.Forms.Label();
            this.label_contact = new System.Windows.Forms.Label();
            this.linkLabel_contact = new System.Windows.Forms.LinkLabel();
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(118, 20);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(43, 13);
            this.label_version.TabIndex = 0;
            this.label_version.Text = "Wersja:";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackgroundImage = global::Auto_Machine.Properties.Resources.Auto_Machine;
            this.pictureBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_logo.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // label_copyright
            // 
            this.label_copyright.AutoSize = true;
            this.label_copyright.Location = new System.Drawing.Point(118, 43);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.Size = new System.Drawing.Size(51, 13);
            this.label_copyright.TabIndex = 1;
            this.label_copyright.Text = "Copyright";
            // 
            // label_contact
            // 
            this.label_contact.AutoSize = true;
            this.label_contact.Location = new System.Drawing.Point(118, 72);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(47, 13);
            this.label_contact.TabIndex = 2;
            this.label_contact.Text = "Kontakt:\r";
            // 
            // linkLabel_contact
            // 
            this.linkLabel_contact.AutoSize = true;
            this.linkLabel_contact.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_contact.Location = new System.Drawing.Point(118, 89);
            this.linkLabel_contact.Name = "linkLabel_contact";
            this.linkLabel_contact.Size = new System.Drawing.Size(98, 13);
            this.linkLabel_contact.TabIndex = 3;
            this.linkLabel_contact.TabStop = true;
            this.linkLabel_contact.Text = "tinexcs@gmail.com";
            this.linkLabel_contact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_contact_LinkClicked);
            // 
            // button_exit
            // 
            this.button_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_exit.BackgroundImage")));
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Location = new System.Drawing.Point(238, 1);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(25, 25);
            this.button_exit.TabIndex = 4;
            this.button_exit.TabStop = false;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(264, 124);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.linkLabel_contact);
            this.Controls.Add(this.label_contact);
            this.Controls.Add(this.label_copyright);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.pictureBox_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.About_FormClosing);
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_copyright;
        private System.Windows.Forms.Label label_contact;
        private System.Windows.Forms.LinkLabel linkLabel_contact;
        private System.Windows.Forms.Button button_exit;
    }
}