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
            this.lblNextAlarm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AlarmName
            // 
            this.AlarmName.AutoSize = true;
            this.AlarmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmName.Location = new System.Drawing.Point(12, 9);
            this.AlarmName.Name = "AlarmName";
            this.AlarmName.Size = new System.Drawing.Size(282, 54);
            this.AlarmName.TabIndex = 0;
            this.AlarmName.Text = "Alarm Name";
            // 
            // btnStopAlarm
            // 
            this.btnStopAlarm.Location = new System.Drawing.Point(124, 136);
            this.btnStopAlarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStopAlarm.Name = "btnStopAlarm";
            this.btnStopAlarm.Size = new System.Drawing.Size(75, 23);
            this.btnStopAlarm.TabIndex = 1;
            this.btnStopAlarm.Text = "Stop Alarm";
            this.btnStopAlarm.UseVisualStyleBackColor = true;
            this.btnStopAlarm.Click += new System.EventHandler(this.btnStopAlarm_Click);
            // 
            // btnMute
            // 
            this.btnMute.Location = new System.Drawing.Point(21, 136);
            this.btnMute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(75, 23);
            this.btnMute.TabIndex = 2;
            this.btnMute.Text = "Mute";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // lblNextAlarm
            // 
            this.lblNextAlarm.AutoSize = true;
            this.lblNextAlarm.Location = new System.Drawing.Point(18, 86);
            this.lblNextAlarm.Name = "lblNextAlarm";
            this.lblNextAlarm.Size = new System.Drawing.Size(75, 16);
            this.lblNextAlarm.TabIndex = 3;
            this.lblNextAlarm.Text = "Next Alarm:";
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 187);
            this.Controls.Add(this.lblNextAlarm);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnStopAlarm);
            this.Controls.Add(this.AlarmName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label lblNextAlarm;
    }
}