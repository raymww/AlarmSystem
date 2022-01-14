
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
            this.btnCustRepetition = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.rbtnAM = new System.Windows.Forms.RadioButton();
            this.rbtnPM = new System.Windows.Forms.RadioButton();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.lblColon = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.lblRepetition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(282, 484);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 57);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCustRepetition
            // 
            this.btnCustRepetition.Location = new System.Drawing.Point(197, 355);
            this.btnCustRepetition.Name = "btnCustRepetition";
            this.btnCustRepetition.Size = new System.Drawing.Size(149, 57);
            this.btnCustRepetition.TabIndex = 1;
            this.btnCustRepetition.Text = "Custom Repetition";
            this.btnCustRepetition.UseVisualStyleBackColor = true;
            this.btnCustRepetition.Click += new System.EventHandler(this.btnCustRepetition_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(163, 87);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(242, 59);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(242, 132);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(58, 13);
            this.lblStartTime.TabIndex = 4;
            this.lblStartTime.Text = "Start Time:";
            // 
            // rbtnAM
            // 
            this.rbtnAM.AutoSize = true;
            this.rbtnAM.Location = new System.Drawing.Point(309, 157);
            this.rbtnAM.Name = "rbtnAM";
            this.rbtnAM.Size = new System.Drawing.Size(47, 17);
            this.rbtnAM.TabIndex = 5;
            this.rbtnAM.TabStop = true;
            this.rbtnAM.Text = "A.M.";
            this.rbtnAM.UseVisualStyleBackColor = true;
            // 
            // rbtnPM
            // 
            this.rbtnPM.AutoSize = true;
            this.rbtnPM.Location = new System.Drawing.Point(309, 180);
            this.rbtnPM.Name = "rbtnPM";
            this.rbtnPM.Size = new System.Drawing.Size(47, 17);
            this.rbtnPM.TabIndex = 6;
            this.rbtnPM.TabStop = true;
            this.rbtnPM.Text = "P.M.";
            this.rbtnPM.UseVisualStyleBackColor = true;
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(239, 167);
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
            this.numHour.Location = new System.Drawing.Point(175, 167);
            this.numHour.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(42, 20);
            this.numHour.TabIndex = 8;
            this.numHour.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // lblColon
            // 
            this.lblColon.AutoSize = true;
            this.lblColon.Location = new System.Drawing.Point(223, 169);
            this.lblColon.Name = "lblColon";
            this.lblColon.Size = new System.Drawing.Size(10, 13);
            this.lblColon.TabIndex = 9;
            this.lblColon.Text = ":";
            this.lblColon.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(197, 484);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(64, 57);
            this.btnSet.TabIndex = 10;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // lblRepetition
            // 
            this.lblRepetition.AutoSize = true;
            this.lblRepetition.Location = new System.Drawing.Point(242, 234);
            this.lblRepetition.Name = "lblRepetition";
            this.lblRepetition.Size = new System.Drawing.Size(58, 13);
            this.lblRepetition.TabIndex = 11;
            this.lblRepetition.Text = "Repetition:";
            // 
            // NewAlarmPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 577);
            this.Controls.Add(this.lblRepetition);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.numHour);
            this.Controls.Add(this.numMin);
            this.Controls.Add(this.rbtnPM);
            this.Controls.Add(this.rbtnAM);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnCustRepetition);
            this.Controls.Add(this.btnCancel);
            this.Name = "NewAlarmPage";
            this.Text = "CustomAlarm";
            this.Load += new System.EventHandler(this.NewAlarmPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCustRepetition;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.RadioButton rbtnAM;
        private System.Windows.Forms.RadioButton rbtnPM;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.Label lblColon;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblRepetition;
    }
}