namespace ProjectAssistant
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
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.companyPageButton = new System.Windows.Forms.Button();
            this.studentPageButton = new System.Windows.Forms.Button();
            this.adminPageButton = new System.Windows.Forms.Button();
            this.loginPageButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.formsPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.sideMenuPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.Controls.Add(this.companyPageButton);
            this.sideMenuPanel.Controls.Add(this.studentPageButton);
            this.sideMenuPanel.Controls.Add(this.adminPageButton);
            this.sideMenuPanel.Controls.Add(this.loginPageButton);
            this.sideMenuPanel.Controls.Add(this.logoPanel);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(197, 568);
            this.sideMenuPanel.TabIndex = 7;
            // 
            // companyPageButton
            // 
            this.companyPageButton.Location = new System.Drawing.Point(60, 342);
            this.companyPageButton.Name = "companyPageButton";
            this.companyPageButton.Size = new System.Drawing.Size(75, 23);
            this.companyPageButton.TabIndex = 4;
            this.companyPageButton.Text = "Company";
            this.companyPageButton.UseVisualStyleBackColor = true;
            this.companyPageButton.Click += new System.EventHandler(this.companyPageButton_Click);
            // 
            // studentPageButton
            // 
            this.studentPageButton.Location = new System.Drawing.Point(60, 292);
            this.studentPageButton.Name = "studentPageButton";
            this.studentPageButton.Size = new System.Drawing.Size(75, 23);
            this.studentPageButton.TabIndex = 3;
            this.studentPageButton.Text = "Student Page";
            this.studentPageButton.UseVisualStyleBackColor = true;
            this.studentPageButton.Click += new System.EventHandler(this.studentPageButton_Click);
            // 
            // adminPageButton
            // 
            this.adminPageButton.Location = new System.Drawing.Point(60, 240);
            this.adminPageButton.Name = "adminPageButton";
            this.adminPageButton.Size = new System.Drawing.Size(75, 23);
            this.adminPageButton.TabIndex = 2;
            this.adminPageButton.Text = "Admin";
            this.adminPageButton.UseVisualStyleBackColor = true;
            this.adminPageButton.Click += new System.EventHandler(this.adminPageButton_Click);
            // 
            // loginPageButton
            // 
            this.loginPageButton.Location = new System.Drawing.Point(60, 185);
            this.loginPageButton.Name = "loginPageButton";
            this.loginPageButton.Size = new System.Drawing.Size(75, 23);
            this.loginPageButton.TabIndex = 1;
            this.loginPageButton.Text = "Login Page";
            this.loginPageButton.UseVisualStyleBackColor = true;
            this.loginPageButton.Click += new System.EventHandler(this.loginPageButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(197, 100);
            this.logoPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(197, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(674, 100);
            this.headerPanel.TabIndex = 8;
            // 
            // formsPanel
            // 
            this.formsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPanel.Location = new System.Drawing.Point(197, 100);
            this.formsPanel.Name = "formsPanel";
            this.formsPanel.Size = new System.Drawing.Size(674, 468);
            this.formsPanel.TabIndex = 9;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headerLabel.Location = new System.Drawing.Point(34, 68);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(74, 24);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 568);
            this.Controls.Add(this.formsPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sideMenuPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel formsPanel;
        private System.Windows.Forms.Button adminPageButton;
        private System.Windows.Forms.Button loginPageButton;
        private System.Windows.Forms.Button companyPageButton;
        private System.Windows.Forms.Button studentPageButton;
        private System.Windows.Forms.Label headerLabel;
    }
}

