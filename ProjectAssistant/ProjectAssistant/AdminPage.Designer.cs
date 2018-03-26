namespace ProjectAssistant
{
    partial class AdminPage
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
            this.components = new System.ComponentModel.Container();
            this.adminPageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminPageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adminPageBindingSource
            // 
            this.adminPageBindingSource.DataSource = typeof(ProjectAssistant.AdminPage);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminPage";
            this.Size = new System.Drawing.Size(1236, 864);
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminPageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource adminPageBindingSource;
        private System.Windows.Forms.Button button1;
    }
}
