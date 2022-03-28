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
            this.SuspendLayout();
            // 
            // AlarmName
            // 
            this.AlarmName.AutoSize = true;
            this.AlarmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmName.Location = new System.Drawing.Point(63, 56);
            this.AlarmName.Name = "AlarmName";
            this.AlarmName.Size = new System.Drawing.Size(282, 54);
            this.AlarmName.TabIndex = 0;
            this.AlarmName.Text = "Alarm Name";
            // 
            // btnStopAlarm
            // 
            this.btnStopAlarm.Location = new System.Drawing.Point(163, 363);
            this.btnStopAlarm.Name = "btnStopAlarm";
            this.btnStopAlarm.Size = new System.Drawing.Size(75, 23);
            this.btnStopAlarm.TabIndex = 1;
            this.btnStopAlarm.Text = "Stop Alarm";
            this.btnStopAlarm.UseVisualStyleBackColor = true;
            this.btnStopAlarm.Click += new System.EventHandler(this.btnStopAlarm_Click);
            // 
            // btnMute
            // 
            this.btnMute.Location = new System.Drawing.Point(163, 323);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(75, 23);
            this.btnMute.TabIndex = 2;
            this.btnMute.Text = "Mute";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // NextAlarm
            // 
            this.NextAlarm.AutoSize = true;
            this.NextAlarm.Location = new System.Drawing.Point(118, 148);
            this.NextAlarm.Name = "NextAlarm";
            this.NextAlarm.Size = new System.Drawing.Size(168, 16);
            this.NextAlarm.TabIndex = 3;
            this.NextAlarm.Text = "Next Alarm: 2022 3/27 12:00";
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 450);
            this.Controls.Add(this.NextAlarm);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnStopAlarm);
            this.Controls.Add(this.AlarmName);
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
    }
}