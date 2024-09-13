namespace windowsform
{
    partial class SlotForm
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
            btnSave = new Button();
            btnCancel = new Button();
            btnShow = new Button();
            EndTime = new Label();
            DatePick = new Label();
            txtStartTime = new TextBox();
            txtEndTime = new TextBox();
            txtDatePick = new TextBox();
            StartTime = new Label();
            btnNext = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.MenuHighlight;
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(251, 305);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaption;
            btnCancel.ForeColor = SystemColors.ButtonFace;
            btnCancel.Location = new Point(356, 305);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(457, 305);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 2;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            // 
            // EndTime
            // 
            EndTime.AutoSize = true;
            EndTime.Location = new Point(222, 170);
            EndTime.Name = "EndTime";
            EndTime.Size = new Size(54, 15);
            EndTime.TabIndex = 4;
            EndTime.Text = "EndTime";
            // 
            // DatePick
            // 
            DatePick.AutoSize = true;
            DatePick.Location = new Point(222, 246);
            DatePick.Name = "DatePick";
            DatePick.Size = new Size(53, 15);
            DatePick.TabIndex = 5;
            DatePick.Text = "DatePick";
            // 
            // txtStartTime
            // 
            txtStartTime.Location = new Point(316, 97);
            txtStartTime.Name = "txtStartTime";
            txtStartTime.Size = new Size(100, 23);
            txtStartTime.TabIndex = 6;
            // 
            // txtEndTime
            // 
            txtEndTime.Location = new Point(316, 162);
            txtEndTime.Name = "txtEndTime";
            txtEndTime.Size = new Size(100, 23);
            txtEndTime.TabIndex = 7;
            // 
            // txtDatePick
            // 
            txtDatePick.Location = new Point(316, 238);
            txtDatePick.Name = "txtDatePick";
            txtDatePick.Size = new Size(100, 23);
            txtDatePick.TabIndex = 8;
            // 
            // StartTime
            // 
            StartTime.AutoSize = true;
            StartTime.Location = new Point(222, 105);
            StartTime.Name = "StartTime";
            StartTime.Size = new Size(58, 15);
            StartTime.TabIndex = 9;
            StartTime.Text = "StartTime";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(457, 238);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 10;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(316, 209);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // SlotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnNext);
            Controls.Add(StartTime);
            Controls.Add(txtDatePick);
            Controls.Add(txtEndTime);
            Controls.Add(txtStartTime);
            Controls.Add(DatePick);
            Controls.Add(EndTime);
            Controls.Add(btnShow);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "SlotForm";
            Text = "SlotForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Button btnShow;
        private Label EndTime;
        private Label DatePick;
        private TextBox txtStartTime;
        private TextBox txtEndTime;
        private TextBox txtDatePick;
        private Label StartTime;
        private Button btnNext;
        private DateTimePicker dateTimePicker1;
    }
}