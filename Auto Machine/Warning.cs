using System;
using System.Drawing;
using System.Windows.Forms;

namespace Auto_Machine
{
    public partial class Warning : Form
    {
        #region Main
        int counter = 59;
        private AutoMachine MainForm;
        public Warning(AutoMachine MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            button_cancel.Text = MainForm.WRN_ActionCancel;
            TextSet();
        }
        private void Warning_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 8;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height - 7;
            this.Location = new Point(x, y);

            timer_update.Start();
        }

        private void TextSet()
        {
            label_info.Text = String.Format("{0} {1} {2}", MainForm.WRN_Task, counter, MainForm.WRN_TaskSec);
            button_action.Text = String.Format("{0} {1}", MainForm.actionTxt, MainForm.WRN_ActionNow);

            this.Text = MainForm.actionTxt.ToUpper() + " (" + counter + "s)";
        }

        private void timer_update_Tick(object sender, EventArgs e)
        {
            counter--;
            TextSet();
            if (counter == 0)
            {
                this.Close();
            }
        }
        private void button_action_Click(object sender, EventArgs e)
        {
            MainForm.action(MainForm.timer_action);
            this.Close();
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            MainForm.stop_action(true);
            MainForm.start = false;
            this.Close();
        }
        #endregion

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}