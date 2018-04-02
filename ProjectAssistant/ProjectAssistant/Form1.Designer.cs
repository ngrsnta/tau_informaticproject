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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.companyPageButton = new System.Windows.Forms.Button();
            this.studentPageButton = new System.Windows.Forms.Button();
            this.adminPageButton = new System.Windows.Forms.Button();
            this.loginPageButton = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.formsPanel = new System.Windows.Forms.Panel();
            this.sideMenuPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(133)))));
            this.sideMenuPanel.Controls.Add(this.companyPageButton);
            this.sideMenuPanel.Controls.Add(this.studentPageButton);
            this.sideMenuPanel.Controls.Add(this.adminPageButton);
            this.sideMenuPanel.Controls.Add(this.loginPageButton);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 100);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(197, 468);
            this.sideMenuPanel.TabIndex = 7;
            // 
            // companyPageButton
            // 
            this.companyPageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.companyPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.companyPageButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.companyPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.companyPageButton.Location = new System.Drawing.Point(0, 150);
            this.companyPageButton.Name = "companyPageButton";
            this.companyPageButton.Size = new System.Drawing.Size(197, 50);
            this.companyPageButton.TabIndex = 4;
            this.companyPageButton.Text = "  Company";
            this.companyPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.companyPageButton.UseVisualStyleBackColor = true;
            this.companyPageButton.Click += new System.EventHandler(this.companyPageButton_Click);
            // 
            // studentPageButton
            // 
            this.studentPageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentPageButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.studentPageButton.Location = new System.Drawing.Point(0, 100);
            this.studentPageButton.Name = "studentPageButton";
            this.studentPageButton.Size = new System.Drawing.Size(197, 50);
            this.studentPageButton.TabIndex = 3;
            this.studentPageButton.Text = "  Student Page";
            this.studentPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentPageButton.UseVisualStyleBackColor = true;
            this.studentPageButton.Click += new System.EventHandler(this.studentPageButton_Click);
            // 
            // adminPageButton
            // 
            this.adminPageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminPageButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.adminPageButton.Location = new System.Drawing.Point(0, 50);
            this.adminPageButton.Name = "adminPageButton";
            this.adminPageButton.Size = new System.Drawing.Size(197, 50);
            this.adminPageButton.TabIndex = 2;
            this.adminPageButton.Text = "  Admin";
            this.adminPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminPageButton.UseVisualStyleBackColor = true;
            this.adminPageButton.Click += new System.EventHandler(this.adminPageButton_Click);
            // 
            // loginPageButton
            // 
            this.loginPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(133)))));
            this.loginPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginPageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginPageButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.loginPageButton.Location = new System.Drawing.Point(0, 0);
            this.loginPageButton.Margin = new System.Windows.Forms.Padding(0);
            this.loginPageButton.Name = "loginPageButton";
            this.loginPageButton.Size = new System.Drawing.Size(197, 50);
            this.loginPageButton.TabIndex = 1;
            this.loginPageButton.Text = "  Login Page";
            this.loginPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginPageButton.UseVisualStyleBackColor = false;
            this.loginPageButton.Click += new System.EventHandler(this.loginPageButton_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.headerPanel.Controls.Add(this.exitButton);
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(871, 100);
            this.headerPanel.TabIndex = 8;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.home_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.home_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.home_MouseUp);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.exitButton.Location = new System.Drawing.Point(839, 9);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(23, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headerLabel.ForeColor = System.Drawing.Color.Black;
            this.headerLabel.Location = new System.Drawing.Point(737, 64);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(74, 24);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "label1";
            // 
            // formsPanel
            // 
            this.formsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.formsPanel.Location = new System.Drawing.Point(197, 100);
            this.formsPanel.Name = "formsPanel";
            this.formsPanel.Size = new System.Drawing.Size(674, 468);
            this.formsPanel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 568);
            this.Controls.Add(this.sideMenuPanel);
            this.Controls.Add(this.formsPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.sideMenuPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel formsPanel;
        private System.Windows.Forms.Button adminPageButton;
        private System.Windows.Forms.Button loginPageButton;
        private System.Windows.Forms.Button companyPageButton;
        private System.Windows.Forms.Button studentPageButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitButton;
    }
}

