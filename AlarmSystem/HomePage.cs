using System;
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
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
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

        private void btnNewAlarm_Click(object sender, EventArgs e)
        {
            NewAlarmPage newAlarm = new NewAlarmPage();
            newAlarm.ShowDialog();
        }

        private void btnViewAlarm_Click(object sender, EventArgs e)
        {
            ViewAlarmPage viewAlarms= new ViewAlarmPage();
            viewAlarms.ShowDialog();
        }

        private void lblNextAlarm_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
