namespace Auto_Machine
{
    partial class Warning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warning));
            this.pictureBox_exclamation = new System.Windows.Forms.PictureBox();
            this.label_info = new System.Windows.Forms.Label();
            this.button_action = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.timer_update = new System.Windows.Forms.Timer(this.components);
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exclamation)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_exclamation
            // 
            this.pictureBox_exclamation.Image = global::Auto_Machine.Properties.Resources.Exclamation_icon;
            this.pictureBox_exclamation.Location = new System.Drawing.Point(12, 22);
            this.pictureBox_exclamation.Name = "pictureBox_exclamation";
            this.pictureBox_exclamation.Size = new System.Drawing.Size(72, 72);
            this.pictureBox_exclamation.TabIndex = 0;
            this.pictureBox_exclamation.TabStop = false;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(104, 22);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(99, 13);
            this.label_info.TabIndex = 0;
            this.label_info.Text = "{Action} in seconds";
            // 
            // button_action
            // 
            this.button_action.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_action.Location = new System.Drawing.Point(107, 71);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(172, 23);
            this.button_action.TabIndex = 1;
            this.button_action.TabStop = false;
            this.button_action.Text = "{action} now";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancel.Location = new System.Drawing.Point(291, 71);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(108, 23);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.TabStop = false;
            this.button_cancel.Text = "Abort task";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // timer_update
            // 
            this.timer_update.Enabled = true;
            this.timer_update.Interval = 1000;
            this.timer_update.Tick += new System.EventHandler(this.timer_update_Tick);
            // 
            // button_exit
            // 
            this.button_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_exit.BackgroundImage")));
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_exit.Location = new System.Drawing.Point(385, 1);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(25, 25);
            this.button_exit.TabIndex = 4;
            this.button_exit.TabStop = false;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 115);
            this.ControlBox = false;
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_action);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.pictureBox_exclamation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Warning";
            this.Text = "{Akcja}";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Warning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exclamation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_exclamation;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button button_action;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Timer timer_update;
        private System.Windows.Forms.Button button_exit;
    }
}