namespace AlarmSystem
{
    partial class Alarm
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
            this.AlarmName = new System.Windows.Forms.Label();
            this.btnStopAlarm = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.NextAlarm = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AlarmName
            // 
            this.AlarmName.AutoSize = true;
            this.AlarmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmName.Location = new System.Drawing.Point(47, 46);
            this.AlarmName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AlarmName.Name = "AlarmName";
            this.AlarmName.Size = new System.Drawing.Size(233, 44);
            this.AlarmName.TabIndex = 0;
            this.AlarmName.Text = "Alarm Name";
            // 
            // btnStopAlarm
            // 
            this.btnStopAlarm.Location = new System.Drawing.Point(122, 295);
            this.btnStopAlarm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStopAlarm.Name = "btnStopAlarm";
            this.btnStopAlarm.Size = new System.Drawing.Size(56, 19);
            this.btnStopAlarm.TabIndex = 1;
            this.btnStopAlarm.Text = "Stop Alarm";
            this.btnStopAlarm.UseVisualStyleBackColor = true;
            this.btnStopAlarm.Click += new System.EventHandler(this.btnStopAlarm_Click);
            // 
            // btnMute
            // 
            this.btnMute.Location = new System.Drawing.Point(122, 262);
            this.btnMute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(56, 19);
            this.btnMute.TabIndex = 2;
            this.btnMute.Text = "Mute";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // NextAlarm
            // 
            this.NextAlarm.AutoSize = true;
            this.NextAlarm.Location = new System.Drawing.Point(88, 120);
            this.NextAlarm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NextAlarm.Name = "NextAlarm";
            this.NextAlarm.Size = new System.Drawing.Size(144, 13);
            this.NextAlarm.TabIndex = 3;
            this.NextAlarm.Text = "Next Alarm: 2022 3/27 12:00";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 344);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 366);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.NextAlarm);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnStopAlarm);
            this.Controls.Add(this.AlarmName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Alarm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Alarm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AlarmName;
        private System.Windows.Forms.Button btnStopAlarm;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Label NextAlarm;
        private System.Windows.Forms.Label lblStatus;
    }
}