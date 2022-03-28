using System;
using System.Collections.Generic;
using AlarmSystem.Models;
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
        List<int> repeatOrder = new List<int>();

        public CustomRepetitionPage()
        {
            InitializeComponent();
            RepeatList.Text = "";
        }

        private void CustomRepetition_Load(object sender, EventArgs e)
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            repeatOrder.Add((int)updownRepetition.Value);
            RepeatList.Text += " " + updownRepetition.Value + ",";
            MessageBox.Show("Added!", TitlesModel.MessageBoxTitle,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<int> getRepeat()
        {
            return repeatOrder;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Repetition Added!", TitlesModel.MessageBoxTitle,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
