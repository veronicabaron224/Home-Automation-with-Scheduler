
namespace CAL_Lab5
{
    partial class Form1
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
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelStopTime = new System.Windows.Forms.Label();
            this.dateTimePickerStop = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBoxLogs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.ItemHeight = 16;
            this.listBoxLogs.Location = new System.Drawing.Point(21, 35);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(612, 180);
            this.listBoxLogs.TabIndex = 0;
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(18, 30);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(159, 17);
            this.labelStartTime.TabIndex = 3;
            this.labelStartTime.Text = "Start Time (HH:MM:SS):";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "HH:mm:ss";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(183, 28);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.ShowUpDown = true;
            this.dateTimePickerStart.Size = new System.Drawing.Size(450, 22);
            this.dateTimePickerStart.TabIndex = 5;
            this.dateTimePickerStart.Value = new System.DateTime(2023, 11, 11, 0, 0, 0, 0);
            // 
            // labelStopTime
            // 
            this.labelStopTime.AutoSize = true;
            this.labelStopTime.Location = new System.Drawing.Point(18, 58);
            this.labelStopTime.Name = "labelStopTime";
            this.labelStopTime.Size = new System.Drawing.Size(158, 17);
            this.labelStopTime.TabIndex = 6;
            this.labelStopTime.Text = "Stop Time (HH:MM:SS):";
            // 
            // dateTimePickerStop
            // 
            this.dateTimePickerStop.CustomFormat = "HH:mm:ss";
            this.dateTimePickerStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStop.Location = new System.Drawing.Point(182, 57);
            this.dateTimePickerStop.Name = "dateTimePickerStop";
            this.dateTimePickerStop.ShowUpDown = true;
            this.dateTimePickerStop.Size = new System.Drawing.Size(451, 22);
            this.dateTimePickerStop.TabIndex = 7;
            this.dateTimePickerStop.Value = new System.DateTime(2023, 11, 11, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelStartTime);
            this.groupBox1.Controls.Add(this.labelStopTime);
            this.groupBox1.Controls.Add(this.dateTimePickerStop);
            this.groupBox1.Controls.Add(this.dateTimePickerStart);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(64, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scheduling";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.listBoxLogs);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(64, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 244);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAL_Lab5.Properties.Resources.cyberlock;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLogs;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelStopTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

