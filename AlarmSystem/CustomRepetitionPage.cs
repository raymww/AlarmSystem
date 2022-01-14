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
    public partial class CustomRepetitionPage : Form
    {
        public CustomRepetitionPage()
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void CustomRepetitionPage_Load(object sender, EventArgs e)
        {

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
    }
}
