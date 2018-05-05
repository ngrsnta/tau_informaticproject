namespace ProjectAssistant
{
    partial class ProjectListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox_projectTitle = new System.Windows.Forms.RichTextBox();
            this.richTextBox_projectArea = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_projectDeadline = new System.Windows.Forms.RichTextBox();
            this.label_projectRemainingDays = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label_projectDurationSign = new System.Windows.Forms.Label();
            this.label_projectStart = new System.Windows.Forms.Label();
            this.label_projectEnd = new System.Windows.Forms.Label();
            this.label_dontTouch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox_projectTitle
            // 
            this.richTextBox_projectTitle.Location = new System.Drawing.Point(16, 15);
            this.richTextBox_projectTitle.Name = "richTextBox_projectTitle";
            this.richTextBox_projectTitle.Size = new System.Drawing.Size(176, 24);
            this.richTextBox_projectTitle.TabIndex = 0;
            this.richTextBox_projectTitle.Text = "Project Title here";
            // 
            // richTextBox_projectArea
            // 
            this.richTextBox_projectArea.Location = new System.Drawing.Point(16, 46);
            this.richTextBox_projectArea.Name = "richTextBox_projectArea";
            this.richTextBox_projectArea.Size = new System.Drawing.Size(292, 25);
            this.richTextBox_projectArea.TabIndex = 1;
            this.richTextBox_projectArea.Text = "Area of Interest here";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(428, 73);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Area of Interest here";
            // 
            // richTextBox_projectDeadline
            // 
            this.richTextBox_projectDeadline.Location = new System.Drawing.Point(886, 4);
            this.richTextBox_projectDeadline.Name = "richTextBox_projectDeadline";
            this.richTextBox_projectDeadline.Size = new System.Drawing.Size(111, 25);
            this.richTextBox_projectDeadline.TabIndex = 3;
            this.richTextBox_projectDeadline.Text = "DEADLINE";
            // 
            // label_projectRemainingDays
            // 
            this.label_projectRemainingDays.AutoSize = true;
            this.label_projectRemainingDays.Location = new System.Drawing.Point(896, 26);
            this.label_projectRemainingDays.Name = "label_projectRemainingDays";
            this.label_projectRemainingDays.Size = new System.Drawing.Size(101, 13);
            this.label_projectRemainingDays.TabIndex = 4;
            this.label_projectRemainingDays.Text = "XX Days Remaining";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(564, 26);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(234, 92);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "COMPANY NAME BIG";
            // 
            // label_projectDurationSign
            // 
            this.label_projectDurationSign.AutoSize = true;
            this.label_projectDurationSign.Location = new System.Drawing.Point(883, 124);
            this.label_projectDurationSign.Name = "label_projectDurationSign";
            this.label_projectDurationSign.Size = new System.Drawing.Size(83, 13);
            this.label_projectDurationSign.TabIndex = 6;
            this.label_projectDurationSign.Text = "Project Duration";
            this.label_projectDurationSign.Click += new System.EventHandler(this.label_projectDurationSign_Click);
            // 
            // label_projectStart
            // 
            this.label_projectStart.AutoSize = true;
            this.label_projectStart.Location = new System.Drawing.Point(853, 137);
            this.label_projectStart.Name = "label_projectStart";
            this.label_projectStart.Size = new System.Drawing.Size(61, 13);
            this.label_projectStart.TabIndex = 7;
            this.label_projectStart.Text = "15.15.2017";
            // 
            // label_projectEnd
            // 
            this.label_projectEnd.AutoSize = true;
            this.label_projectEnd.Location = new System.Drawing.Point(936, 137);
            this.label_projectEnd.Name = "label_projectEnd";
            this.label_projectEnd.Size = new System.Drawing.Size(61, 13);
            this.label_projectEnd.TabIndex = 8;
            this.label_projectEnd.Text = "20.15.2017";
            // 
            // label_dontTouch
            // 
            this.label_dontTouch.AutoSize = true;
            this.label_dontTouch.Location = new System.Drawing.Point(920, 137);
            this.label_dontTouch.Name = "label_dontTouch";
            this.label_dontTouch.Size = new System.Drawing.Size(10, 13);
            this.label_dontTouch.TabIndex = 9;
            this.label_dontTouch.Text = "-";
            this.label_dontTouch.Click += new System.EventHandler(this.label4_Click);
            // 
            // ProjectListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_dontTouch);
            this.Controls.Add(this.label_projectEnd);
            this.Controls.Add(this.label_projectStart);
            this.Controls.Add(this.label_projectDurationSign);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label_projectRemainingDays);
            this.Controls.Add(this.richTextBox_projectDeadline);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTextBox_projectArea);
            this.Controls.Add(this.richTextBox_projectTitle);
            this.Name = "ProjectListItem";
            this.Size = new System.Drawing.Size(1000, 153);
            this.Load += new System.EventHandler(this.ProjectListItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_projectTitle;
        private System.Windows.Forms.RichTextBox richTextBox_projectArea;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox_projectDeadline;
        private System.Windows.Forms.Label label_projectRemainingDays;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label_projectDurationSign;
        private System.Windows.Forms.Label label_projectStart;
        private System.Windows.Forms.Label label_projectEnd;
        private System.Windows.Forms.Label label_dontTouch;
    }
}
