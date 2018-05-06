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
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.richTextBox_projectDeadline = new System.Windows.Forms.RichTextBox();
            this.label_projectRemainingDays = new System.Windows.Forms.Label();
            this.richTextBox_companyName = new System.Windows.Forms.RichTextBox();
            this.label_projectDurationSign = new System.Windows.Forms.Label();
            this.label_projectStart = new System.Windows.Forms.Label();
            this.label_projectEnd = new System.Windows.Forms.Label();
            this.label_dontTouch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox_projectTitle
            // 
            this.richTextBox_projectTitle.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_projectTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_projectTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox_projectTitle.Enabled = false;
            this.richTextBox_projectTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox_projectTitle.Location = new System.Drawing.Point(16, 15);
            this.richTextBox_projectTitle.Name = "richTextBox_projectTitle";
            this.richTextBox_projectTitle.ReadOnly = true;
            this.richTextBox_projectTitle.Size = new System.Drawing.Size(292, 24);
            this.richTextBox_projectTitle.TabIndex = 0;
            this.richTextBox_projectTitle.Text = "Project Title here";
            this.richTextBox_projectTitle.TextChanged += new System.EventHandler(this.richTextBox_projectTitle_TextChanged);
            // 
            // richTextBox_projectArea
            // 
            this.richTextBox_projectArea.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_projectArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_projectArea.Enabled = false;
            this.richTextBox_projectArea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox_projectArea.Location = new System.Drawing.Point(16, 46);
            this.richTextBox_projectArea.Name = "richTextBox_projectArea";
            this.richTextBox_projectArea.Size = new System.Drawing.Size(292, 25);
            this.richTextBox_projectArea.TabIndex = 1;
            this.richTextBox_projectArea.Text = "Area of Interest here";
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_description.Enabled = false;
            this.richTextBox_description.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox_description.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox_description.Location = new System.Drawing.Point(16, 77);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(312, 73);
            this.richTextBox_description.TabIndex = 2;
            this.richTextBox_description.Text = "Description here";
            // 
            // richTextBox_projectDeadline
            // 
            this.richTextBox_projectDeadline.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_projectDeadline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_projectDeadline.Enabled = false;
            this.richTextBox_projectDeadline.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox_projectDeadline.Location = new System.Drawing.Point(665, 3);
            this.richTextBox_projectDeadline.Name = "richTextBox_projectDeadline";
            this.richTextBox_projectDeadline.Size = new System.Drawing.Size(111, 25);
            this.richTextBox_projectDeadline.TabIndex = 3;
            this.richTextBox_projectDeadline.Text = "DEADLINE";
            // 
            // label_projectRemainingDays
            // 
            this.label_projectRemainingDays.AutoSize = true;
            this.label_projectRemainingDays.Enabled = false;
            this.label_projectRemainingDays.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_projectRemainingDays.Location = new System.Drawing.Point(651, 25);
            this.label_projectRemainingDays.Name = "label_projectRemainingDays";
            this.label_projectRemainingDays.Size = new System.Drawing.Size(111, 16);
            this.label_projectRemainingDays.TabIndex = 4;
            this.label_projectRemainingDays.Text = "XX Days Remaining";
            // 
            // richTextBox_companyName
            // 
            this.richTextBox_companyName.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_companyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_companyName.Enabled = false;
            this.richTextBox_companyName.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox_companyName.Location = new System.Drawing.Point(334, 37);
            this.richTextBox_companyName.Name = "richTextBox_companyName";
            this.richTextBox_companyName.ReadOnly = true;
            this.richTextBox_companyName.Size = new System.Drawing.Size(234, 92);
            this.richTextBox_companyName.TabIndex = 5;
            this.richTextBox_companyName.Text = "COMPANY NAME BIG";
            // 
            // label_projectDurationSign
            // 
            this.label_projectDurationSign.AutoSize = true;
            this.label_projectDurationSign.Enabled = false;
            this.label_projectDurationSign.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_projectDurationSign.Location = new System.Drawing.Point(651, 113);
            this.label_projectDurationSign.Name = "label_projectDurationSign";
            this.label_projectDurationSign.Size = new System.Drawing.Size(94, 16);
            this.label_projectDurationSign.TabIndex = 6;
            this.label_projectDurationSign.Text = "Project Duration";
            this.label_projectDurationSign.Click += new System.EventHandler(this.label_projectDurationSign_Click);
            // 
            // label_projectStart
            // 
            this.label_projectStart.AutoSize = true;
            this.label_projectStart.Enabled = false;
            this.label_projectStart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_projectStart.Location = new System.Drawing.Point(621, 129);
            this.label_projectStart.Name = "label_projectStart";
            this.label_projectStart.Size = new System.Drawing.Size(72, 17);
            this.label_projectStart.TabIndex = 7;
            this.label_projectStart.Text = "15.15.2017";
            this.label_projectStart.Click += new System.EventHandler(this.label_projectStart_Click);
            // 
            // label_projectEnd
            // 
            this.label_projectEnd.AutoSize = true;
            this.label_projectEnd.Enabled = false;
            this.label_projectEnd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_projectEnd.Location = new System.Drawing.Point(704, 129);
            this.label_projectEnd.Name = "label_projectEnd";
            this.label_projectEnd.Size = new System.Drawing.Size(72, 17);
            this.label_projectEnd.TabIndex = 8;
            this.label_projectEnd.Text = "20.15.2017";
            // 
            // label_dontTouch
            // 
            this.label_dontTouch.AutoSize = true;
            this.label_dontTouch.Enabled = false;
            this.label_dontTouch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_dontTouch.Location = new System.Drawing.Point(688, 129);
            this.label_dontTouch.Name = "label_dontTouch";
            this.label_dontTouch.Size = new System.Drawing.Size(12, 17);
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
            this.Controls.Add(this.richTextBox_companyName);
            this.Controls.Add(this.label_projectRemainingDays);
            this.Controls.Add(this.richTextBox_projectDeadline);
            this.Controls.Add(this.richTextBox_description);
            this.Controls.Add(this.richTextBox_projectArea);
            this.Controls.Add(this.richTextBox_projectTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ProjectListItem";
            this.Size = new System.Drawing.Size(779, 153);
            this.Load += new System.EventHandler(this.ProjectListItem_Load);
            this.MouseHover += new System.EventHandler(this.ProjectListItem_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBox_projectTitle;
        public System.Windows.Forms.RichTextBox richTextBox_projectArea;
        public System.Windows.Forms.RichTextBox richTextBox_description;
        public System.Windows.Forms.RichTextBox richTextBox_projectDeadline;
        public System.Windows.Forms.Label label_projectRemainingDays;
        public System.Windows.Forms.RichTextBox richTextBox_companyName;
        public System.Windows.Forms.Label label_projectDurationSign;
        public System.Windows.Forms.Label label_projectStart;
        public System.Windows.Forms.Label label_projectEnd;
        public System.Windows.Forms.Label label_dontTouch;
    }
}
