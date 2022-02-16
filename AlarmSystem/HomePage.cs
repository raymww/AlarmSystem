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
            //Use LINQ to get customers from the CustomersModel
            var alarms = (from c in ClassAlarmsCollection
                             select c.alarmName).ToList();

            //Set the DataSource of the listbox to the customers collection
            this.lstbxCurrentAlarms.DataSource = alarms;
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

            //Access the Event which is used by the Delegate
            //Pass in a method on THIS FORM 
            //This will cause the Deletegate on the Form2 Form
            //To access the method on this Form
            //UpdateCustomers is the Variable declared in Form2
            //CustomersHandler is the delegate declared in Form2
            newAlarm.UpdateTimers += new NewAlarmPage.TimerHandler(TimersUpdate);

            newAlarm.ShowDialog();


        }

        private void lblNextAlarm_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void setAlarm(string name, string date, string time)
        {
            

        }

        private void TimersUpdate(object s, UpdateTimerEventArgs e)
        {
            //Get the customers from Form2 which was passed to the
            //UpdateCustomersEventArg class that we created for this
            ClassAlarmsCollection = e.GetTimers;

            this.PopulateTimers();
        }

        private void lstbxCurrentAlarms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
