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
    public partial class HomePage : Form
    {
        List<ClassAlarm> ClassAlarmsCollection = new List<ClassAlarm>();

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();

            ClassAlarmsCollection = ClassAlarm.GetAlarms();

            this.PopulateTimers();
        }

        private void PopulateTimers()
        {
            this.lstbxCurrentAlarms.DataSource = null;

            if (ClassAlarmsCollection != null)
            {
                var alarms = (from c in ClassAlarmsCollection
                              select c.alarmName).ToList();

                //Set the DataSource of the listbox to the customers collection
                this.lstbxCurrentAlarms.DataSource = alarms;
            }
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

        private void btnNewAlarm_Click(object sender, EventArgs e)
        {
            NewAlarmPage newAlarm = new NewAlarmPage();
            newAlarm.ClassAlarmsCollection = this.ClassAlarmsCollection;
            newAlarm.UpdateTimers += new NewAlarmPage.TimerHandler(TimersUpdate);
            newAlarm.ShowDialog();
            // set the alarm here

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TimersUpdate(object s, UpdateTimerEventArgs e)
        {
            //Get the customers from Form2 which was passed to the
            //UpdateCustomersEventArg class that we created for this
            ClassAlarmsCollection = e.GetTimers;

            this.PopulateTimers();
        }

        private void btnDeleteAlarm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alarm Deleted!", TitlesModel.MessageBoxTitle,
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

            var test = (from c in ClassAlarmsCollection
                        select c).ToArray();


            var result = ClassAlarmsCollection.FindIndex(x => x.alarmName.Equals(this.lstbxCurrentAlarms.SelectedValue));

            if (result > -1)
                ClassAlarmsCollection.RemoveAt(result);

            this.PopulateTimers();
        }
    }
}
