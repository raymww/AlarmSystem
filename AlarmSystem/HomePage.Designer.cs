
namespace AlarmSystem
{
    partial class HomePage
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblNextAlarm = new System.Windows.Forms.Label();
            this.btnNewAlarm = new System.Windows.Forms.Button();
            this.btnViewAlarm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(316, 19);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(131, 36);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNextAlarm
            // 
            this.lblNextAlarm.AutoSize = true;
            this.lblNextAlarm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextAlarm.Location = new System.Drawing.Point(247, 67);
            this.lblNextAlarm.Name = "lblNextAlarm";
            this.lblNextAlarm.Size = new System.Drawing.Size(278, 21);
            this.lblNextAlarm.TabIndex = 1;
            this.lblNextAlarm.Text = "Next Alarm: XX:XX AM on XX/XX";
            // 
            // btnNewAlarm
            // 
            this.btnNewAlarm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAlarm.Location = new System.Drawing.Point(325, 120);
            this.btnNewAlarm.Name = "btnNewAlarm";
            this.btnNewAlarm.Size = new System.Drawing.Size(119, 34);
            this.btnNewAlarm.TabIndex = 2;
            this.btnNewAlarm.Text = "Set New Alarm";
            this.btnNewAlarm.UseVisualStyleBackColor = true;
            this.btnNewAlarm.Click += new System.EventHandler(this.btnNewAlarm_Click);
            // 
            // btnViewAlarm
            // 
            this.btnViewAlarm.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAlarm.Location = new System.Drawing.Point(325, 177);
            this.btnViewAlarm.Name = "btnViewAlarm";
            this.btnViewAlarm.Size = new System.Drawing.Size(119, 34);
            this.btnViewAlarm.TabIndex = 3;
            this.btnViewAlarm.Text = "View Current Alarms";
            this.btnViewAlarm.UseVisualStyleBackColor = true;
            this.btnViewAlarm.Click += new System.EventHandler(this.btnViewAlarm_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewAlarm);
            this.Controls.Add(this.btnNewAlarm);
            this.Controls.Add(this.lblNextAlarm);
            this.Controls.Add(this.lblWelcome);
            this.Name = "HomePage";
            this.Text = "CustomAlarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblNextAlarm;
        private System.Windows.Forms.Button btnNewAlarm;
        private System.Windows.Forms.Button btnViewAlarm;
    }
}

