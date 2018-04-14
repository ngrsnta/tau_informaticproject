namespace ProjectAssistant
{
    partial class StudentPage
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
            this.student_mainTab = new System.Windows.Forms.TabControl();
            this.studPage_projects = new System.Windows.Forms.TabPage();
            this.studPage_applications = new System.Windows.Forms.TabPage();
            this.studPage_editInfo = new System.Windows.Forms.TabPage();
            this.student_mainTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // student_mainTab
            // 
            this.student_mainTab.Controls.Add(this.studPage_projects);
            this.student_mainTab.Controls.Add(this.studPage_applications);
            this.student_mainTab.Controls.Add(this.studPage_editInfo);
            this.student_mainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.student_mainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.student_mainTab.ItemSize = new System.Drawing.Size(132, 21);
            this.student_mainTab.Location = new System.Drawing.Point(0, 0);
            this.student_mainTab.Margin = new System.Windows.Forms.Padding(2);
            this.student_mainTab.Name = "student_mainTab";
            this.student_mainTab.SelectedIndex = 0;
            this.student_mainTab.Size = new System.Drawing.Size(1640, 960);
            this.student_mainTab.TabIndex = 0;
            // 
            // studPage_projects
            // 
            this.studPage_projects.Location = new System.Drawing.Point(4, 25);
            this.studPage_projects.Name = "studPage_projects";
            this.studPage_projects.Padding = new System.Windows.Forms.Padding(3);
            this.studPage_projects.Size = new System.Drawing.Size(1632, 931);
            this.studPage_projects.TabIndex = 0;
            this.studPage_projects.Text = "Projects";
            this.studPage_projects.UseVisualStyleBackColor = true;
            // 
            // studPage_applications
            // 
            this.studPage_applications.Location = new System.Drawing.Point(4, 25);
            this.studPage_applications.Name = "studPage_applications";
            this.studPage_applications.Padding = new System.Windows.Forms.Padding(3);
            this.studPage_applications.Size = new System.Drawing.Size(666, 439);
            this.studPage_applications.TabIndex = 1;
            this.studPage_applications.Text = "Applications";
            this.studPage_applications.UseVisualStyleBackColor = true;
            // 
            // studPage_editInfo
            // 
            this.studPage_editInfo.Location = new System.Drawing.Point(4, 25);
            this.studPage_editInfo.Name = "studPage_editInfo";
            this.studPage_editInfo.Size = new System.Drawing.Size(666, 439);
            this.studPage_editInfo.TabIndex = 2;
            this.studPage_editInfo.Text = "Edit Info";
            this.studPage_editInfo.UseVisualStyleBackColor = true;
            // 
            // StudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.student_mainTab);
            this.Name = "StudentPage";
            this.Size = new System.Drawing.Size(1640, 960);
            this.student_mainTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl student_mainTab;
        private System.Windows.Forms.TabPage studPage_projects;
        private System.Windows.Forms.TabPage studPage_applications;
        private System.Windows.Forms.TabPage studPage_editInfo;
    }
}
