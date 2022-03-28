using System;
using AlarmSystem.Models;
using AlarmSystem.Events;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmSystem
{
    public partial class NewAlarmPage : Form
    {

        public NewAlarmPage()
        {
            InitializeComponent();
        }
        private void NewAlarmPage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            //form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "CustomAlarm";
            //label
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            
            if (!this.PerformValidation())
            { 
                return;
            }

            ClassAlarm newAlarm = new ClassAlarm()
            {
                alarmName = this.txtNewAlarmName.Text.Trim(),
                date = this.dtStartDate.Text,
                time = this.numHour.Value.ToString() + " " + this.numMin.Value.ToString(),
                repeat = false,
                repetition = new List<int> {0}
            };

            if (radbtnDaily.Checked)
            {
                newAlarm.repeat = true;
                newAlarm.repetition = new List<int> {1};
            }

            else if (radbtnWeekly.Checked)
            {
                newAlarm.repeat = true;
                newAlarm.repetition = new List<int> {7};
            }

            else if (radbtnCustom.Checked)
            {
                CustomRepetitionPage customRepetition = new CustomRepetitionPage();
                customRepetition.ShowDialog();

                List<int> repeatOrder = customRepetition.getRepeat();

                newAlarm.repeat = true;
                newAlarm.repetition = repeatOrder;

            }

            MessageBox.Show(dtStartDate.Text + " " + numHour.Value.ToString() + ":" + numMin.Value.ToString() + " " + newAlarm.repetition.ToString(), TitlesModel.MessageBoxTitle,
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

            /*
            MessageBox.Show("Alarm Set!", TitlesModel.MessageBoxTitle,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            */
            //timer is set here!!

            Alarm CreatedAlarm = new Alarm(newAlarm);
            CreatedAlarm.ShowDialog();

            this.Close();

        }

        private void radbtnCustom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private bool PerformValidation()
        {
            //Verify that the textbox is not empty
            if (String.IsNullOrEmpty(this.txtNewAlarmName.Text.Trim()))
            {
                MessageBox.Show("A Name must be entered!", TitlesModel.MessageBoxTitle,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNewAlarmName.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(this.dtStartDate.Text.Trim()))
            {
                MessageBox.Show("A Date must be entered!", TitlesModel.MessageBoxTitle,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dtStartDate.Focus();
                return false;
            }

            return true;
        }

    }
}
