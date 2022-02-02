
namespace AlarmSystem
{
    partial class NewAlarmPage
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.lblColon = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.lblRepetition = new System.Windows.Forms.Label();
            this.txtNewAlarmName = new System.Windows.Forms.TextBox();
            this.lblAlarmName = new System.Windows.Forms.Label();
            this.radbtnDaily = new System.Windows.Forms.RadioButton();
            this.radbtnWeekly = new System.Windows.Forms.RadioButton();
            this.radbtnCustom = new System.Windows.Forms.RadioButton();
            this.grpBoxRepetition = new System.Windows.Forms.GroupBox();
            this.radbtnNoRep = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            this.grpBoxRepetition.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(282, 434);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 57);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(165, 139);
            this.dtStartDate.MinDate = new System.DateTime(2022, 1, 21, 11, 58, 46, 0);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(227, 20);
            this.dtStartDate.TabIndex = 2;
            this.dtStartDate.Value = new System.DateTime(2022, 1, 21, 11, 58, 46, 0);
            this.dtStartDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(244, 106);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(244, 184);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(58, 13);
            this.lblStartTime.TabIndex = 4;
            this.lblStartTime.Text = "Start Time:";
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(282, 226);
            this.numMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(42, 20);
            this.numMin.TabIndex = 7;
            // 
            // numHour
            // 
            this.numHour.Location = new System.Drawing.Point(218, 226);
            this.numHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(42, 20);
            this.numHour.TabIndex = 8;
            // 
            // lblColon
            // 
            this.lblColon.AutoSize = true;
            this.lblColon.Location = new System.Drawing.Point(266, 228);
            this.lblColon.Name = "lblColon";
            this.lblColon.Size = new System.Drawing.Size(10, 13);
            this.lblColon.TabIndex = 9;
            this.lblColon.Text = ":";
            this.lblColon.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(196, 434);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(64, 57);
            this.btnSet.TabIndex = 10;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lblRepetition
            // 
            this.lblRepetition.AutoSize = true;
            this.lblRepetition.Location = new System.Drawing.Point(244, 274);
            this.lblRepetition.Name = "lblRepetition";
            this.lblRepetition.Size = new System.Drawing.Size(58, 13);
            this.lblRepetition.TabIndex = 11;
            this.lblRepetition.Text = "Repetition:";
            // 
            // txtNewAlarmName
            // 
            this.txtNewAlarmName.Location = new System.Drawing.Point(221, 75);
            this.txtNewAlarmName.Name = "txtNewAlarmName";
            this.txtNewAlarmName.Size = new System.Drawing.Size(100, 20);
            this.txtNewAlarmName.TabIndex = 12;
            this.txtNewAlarmName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAlarmName
            // 
            this.lblAlarmName.AutoSize = true;
            this.lblAlarmName.Location = new System.Drawing.Point(240, 46);
            this.lblAlarmName.Name = "lblAlarmName";
            this.lblAlarmName.Size = new System.Drawing.Size(67, 13);
            this.lblAlarmName.TabIndex = 13;
            this.lblAlarmName.Text = "Alarm Name:";
            // 
            // radbtnDaily
            // 
            this.radbtnDaily.AutoSize = true;
            this.radbtnDaily.Location = new System.Drawing.Point(35, 19);
            this.radbtnDaily.Name = "radbtnDaily";
            this.radbtnDaily.Size = new System.Drawing.Size(48, 17);
            this.radbtnDaily.TabIndex = 14;
            this.radbtnDaily.TabStop = true;
            this.radbtnDaily.Text = "Daily";
            this.radbtnDaily.UseVisualStyleBackColor = true;
            // 
            // radbtnWeekly
            // 
            this.radbtnWeekly.AutoSize = true;
            this.radbtnWeekly.Location = new System.Drawing.Point(96, 19);
            this.radbtnWeekly.Name = "radbtnWeekly";
            this.radbtnWeekly.Size = new System.Drawing.Size(61, 17);
            this.radbtnWeekly.TabIndex = 15;
            this.radbtnWeekly.TabStop = true;
            this.radbtnWeekly.Text = "Weekly";
            this.radbtnWeekly.UseVisualStyleBackColor = true;
            // 
            // radbtnCustom
            // 
            this.radbtnCustom.AutoSize = true;
            this.radbtnCustom.Location = new System.Drawing.Point(35, 64);
            this.radbtnCustom.Name = "radbtnCustom";
            this.radbtnCustom.Size = new System.Drawing.Size(60, 17);
            this.radbtnCustom.TabIndex = 16;
            this.radbtnCustom.TabStop = true;
            this.radbtnCustom.Text = "Custom";
            this.radbtnCustom.UseVisualStyleBackColor = true;
            this.radbtnCustom.CheckedChanged += new System.EventHandler(this.radbtnCustom_CheckedChanged);
            // 
            // grpBoxRepetition
            // 
            this.grpBoxRepetition.Controls.Add(this.radbtnNoRep);
            this.grpBoxRepetition.Controls.Add(this.radbtnWeekly);
            this.grpBoxRepetition.Controls.Add(this.radbtnCustom);
            this.grpBoxRepetition.Controls.Add(this.radbtnDaily);
            this.grpBoxRepetition.Location = new System.Drawing.Point(192, 308);
            this.grpBoxRepetition.Name = "grpBoxRepetition";
            this.grpBoxRepetition.Size = new System.Drawing.Size(200, 100);
            this.grpBoxRepetition.TabIndex = 17;
            this.grpBoxRepetition.TabStop = false;
            this.grpBoxRepetition.Text = "Options:";
            // 
            // radbtnNoRep
            // 
            this.radbtnNoRep.AutoSize = true;
            this.radbtnNoRep.Location = new System.Drawing.Point(96, 64);
            this.radbtnNoRep.Name = "radbtnNoRep";
            this.radbtnNoRep.Size = new System.Drawing.Size(90, 17);
            this.radbtnNoRep.TabIndex = 17;
            this.radbtnNoRep.TabStop = true;
            this.radbtnNoRep.Text = "No Repetition";
            this.radbtnNoRep.UseVisualStyleBackColor = true;
            // 
            // NewAlarmPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 577);
            this.Controls.Add(this.grpBoxRepetition);
            this.Controls.Add(this.lblAlarmName);
            this.Controls.Add(this.txtNewAlarmName);
            this.Controls.Add(this.lblRepetition);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.numHour);
            this.Controls.Add(this.numMin);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.btnCancel);
            this.Name = "NewAlarmPage";
            this.Text = "CustomAlarm";
            this.Load += new System.EventHandler(this.NewAlarmPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            this.grpBoxRepetition.ResumeLayout(false);
            this.grpBoxRepetition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.Label lblColon;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblRepetition;
        private System.Windows.Forms.TextBox txtNewAlarmName;
        private System.Windows.Forms.Label lblAlarmName;
        private System.Windows.Forms.RadioButton radbtnDaily;
        private System.Windows.Forms.RadioButton radbtnWeekly;
        private System.Windows.Forms.RadioButton radbtnCustom;
        private System.Windows.Forms.GroupBox grpBoxRepetition;
        private System.Windows.Forms.RadioButton radbtnNoRep;
    }
}