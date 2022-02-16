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
        public List<ClassAlarm> Timers;
        //Delegate
        public delegate void TimerHandler(object sender, UpdateTimerEventArgs e);

        //Event for Delegate 
        //Type CustomersHandler matches the Delegate above
        //UpdateCustomers is the variable used by Form1
        public event TimerHandler UpdateTimers;

        //ArrayList - Updated by Form1
        public List<ClassAlarm> ClassAlarmsCollection;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCustRepetition_Click(object sender, EventArgs e)
        {
            CustomRepetitionPage customRepetition = new CustomRepetitionPage();
            customRepetition.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            
            if (!this.PerformValidation())
            { 
                return;
            }

            if (radbtnNoRep.Checked)
            {
                ClassAlarmsCollection.Add(new ClassAlarm()
                {
                    alarmName = this.txtNewAlarmName.Text.Trim(),
                    date = this.dtStartDate.Text,
                    time = this.numHour.Value.ToString() + ":" + this.numMin.Value.ToString(),
                    repeat = true
                }) ;
            }

            if (radbtnDaily.Checked)
            {
                ClassAlarmsCollection.Add(new ClassAlarm()
                {
                    alarmName = this.txtNewAlarmName.Text.Trim(),
                    date = this.dtStartDate.Text,
                    time = this.numHour.Value.ToString() + ":" + this.numMin.Value.ToString(),
                    repeat = true,
                    repetition = {1}
                });
            }

            if (radbtnWeekly.Checked)
            {
                ClassAlarmsCollection.Add(new ClassAlarm()
                {
                    alarmName = this.txtNewAlarmName.Text.Trim(),
                    date = this.dtStartDate.Text,
                    time = this.numHour.Value.ToString() + ":" + this.numMin.Value.ToString(),
                    repeat = true,
                    repetition = {7}
                });
            }

            if (radbtnCustom.Checked)
            {
                CustomRepetitionPage customRepetition = new CustomRepetitionPage();
                customRepetition.ShowDialog();

                List<int> repeatOrder = customRepetition.getRepeat();
                
                ClassAlarmsCollection.Add(new ClassAlarm()
                {
                    alarmName = this.txtNewAlarmName.Text.Trim(),
                    date = this.dtStartDate.Text,
                    time = this.numHour.Value.ToString() + ":" + this.numMin.Value.ToString(),
                    repeat = true,
                    repetition = repeatOrder
                });

            }

            MessageBox.Show("Alarm Set!", TitlesModel.MessageBoxTitle,
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void radbtnCustom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private bool PerformValidation()
        {
            //Verify that the textbox is not empty
            if (String.IsNullOrEmpty(this.txtNewAlarmName.Text.Trim()))
            {
                MessageBox.Show("A Customer must be entered!", TitlesModel.MessageBoxTitle,
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
