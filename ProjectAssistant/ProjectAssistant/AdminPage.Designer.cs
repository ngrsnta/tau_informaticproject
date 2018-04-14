﻿namespace ProjectAssistant
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
            this.reg_student = new System.Windows.Forms.Button();
            this.Admin_MainTab = new System.Windows.Forms.TabControl();
            this.tab_reg_student = new System.Windows.Forms.TabPage();
            this.label_test4 = new System.Windows.Forms.Label();
            this.label_studentpassword = new System.Windows.Forms.Label();
            this.textbox_studentpassword = new System.Windows.Forms.TextBox();
            this.label_studentsurname = new System.Windows.Forms.Label();
            this.textbox_studentsurname = new System.Windows.Forms.TextBox();
            this.label_studentname = new System.Windows.Forms.Label();
            this.textbox_studentname = new System.Windows.Forms.TextBox();
            this.label_test3 = new System.Windows.Forms.Label();
            this.label_test2 = new System.Windows.Forms.Label();
            this.label_test1 = new System.Windows.Forms.Label();
            this.label_studentnumber = new System.Windows.Forms.Label();
            this.textbox_studentnumber = new System.Windows.Forms.TextBox();
            this.label_reg_student = new System.Windows.Forms.Label();
            this.tab_update_student = new System.Windows.Forms.TabPage();
            this.label_upt_student = new System.Windows.Forms.Label();
            this.tab_reg_firma = new System.Windows.Forms.TabPage();
            this.label_reg_firma = new System.Windows.Forms.Label();
            this.tab_update_firma = new System.Windows.Forms.TabPage();
            this.label_update_firma = new System.Windows.Forms.Label();
            this.adminPageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Admin_MainTab.SuspendLayout();
            this.tab_reg_student.SuspendLayout();
            this.tab_update_student.SuspendLayout();
            this.tab_reg_firma.SuspendLayout();
            this.tab_update_firma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminPageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reg_student
            // 
            this.reg_student.Location = new System.Drawing.Point(514, 331);
            this.reg_student.Name = "reg_student";
            this.reg_student.Size = new System.Drawing.Size(172, 54);
            this.reg_student.TabIndex = 0;
            this.reg_student.Text = "Register";
            this.reg_student.UseVisualStyleBackColor = true;
            this.reg_student.Click += new System.EventHandler(this.reg_student_Click);
            // 
            // Admin_MainTab
            // 
            this.Admin_MainTab.Controls.Add(this.tab_reg_student);
            this.Admin_MainTab.Controls.Add(this.tab_update_student);
            this.Admin_MainTab.Controls.Add(this.tab_reg_firma);
            this.Admin_MainTab.Controls.Add(this.tab_update_firma);
            this.Admin_MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Admin_MainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Admin_MainTab.Location = new System.Drawing.Point(0, 0);
            this.Admin_MainTab.Multiline = true;
            this.Admin_MainTab.Name = "Admin_MainTab";
            this.Admin_MainTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Admin_MainTab.SelectedIndex = 0;
            this.Admin_MainTab.Size = new System.Drawing.Size(1236, 864);
            this.Admin_MainTab.TabIndex = 1;
            this.Admin_MainTab.SelectedIndexChanged += new System.EventHandler(this.Admin_MainTab_SelectedIndexChanged);
            // 
            // tab_reg_student
            // 
            this.tab_reg_student.Controls.Add(this.label_test4);
            this.tab_reg_student.Controls.Add(this.label_studentpassword);
            this.tab_reg_student.Controls.Add(this.textbox_studentpassword);
            this.tab_reg_student.Controls.Add(this.label_studentsurname);
            this.tab_reg_student.Controls.Add(this.textbox_studentsurname);
            this.tab_reg_student.Controls.Add(this.label_studentname);
            this.tab_reg_student.Controls.Add(this.textbox_studentname);
            this.tab_reg_student.Controls.Add(this.label_test3);
            this.tab_reg_student.Controls.Add(this.label_test2);
            this.tab_reg_student.Controls.Add(this.label_test1);
            this.tab_reg_student.Controls.Add(this.label_studentnumber);
            this.tab_reg_student.Controls.Add(this.textbox_studentnumber);
            this.tab_reg_student.Controls.Add(this.label_reg_student);
            this.tab_reg_student.Controls.Add(this.reg_student);
            this.tab_reg_student.Location = new System.Drawing.Point(4, 38);
            this.tab_reg_student.Name = "tab_reg_student";
            this.tab_reg_student.Padding = new System.Windows.Forms.Padding(3);
            this.tab_reg_student.Size = new System.Drawing.Size(1228, 822);
            this.tab_reg_student.TabIndex = 0;
            this.tab_reg_student.Text = "Student Registration";
            this.tab_reg_student.UseVisualStyleBackColor = true;
            // 
            // label_test4
            // 
            this.label_test4.AutoSize = true;
            this.label_test4.Location = new System.Drawing.Point(893, 259);
            this.label_test4.Name = "label_test4";
            this.label_test4.Size = new System.Drawing.Size(153, 29);
            this.label_test4.TabIndex = 10;
            this.label_test4.Text = "Place Holder";
            // 
            // label_studentpassword
            // 
            this.label_studentpassword.AutoSize = true;
            this.label_studentpassword.Location = new System.Drawing.Point(61, 264);
            this.label_studentpassword.Name = "label_studentpassword";
            this.label_studentpassword.Size = new System.Drawing.Size(208, 29);
            this.label_studentpassword.TabIndex = 9;
            this.label_studentpassword.Text = "Student Password";
            // 
            // textbox_studentpassword
            // 
            this.textbox_studentpassword.Location = new System.Drawing.Point(423, 259);
            this.textbox_studentpassword.Name = "textbox_studentpassword";
            this.textbox_studentpassword.Size = new System.Drawing.Size(366, 34);
            this.textbox_studentpassword.TabIndex = 8;
            this.textbox_studentpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_studentpassword_KeyPress);
            // 
            // label_studentsurname
            // 
            this.label_studentsurname.AutoSize = true;
            this.label_studentsurname.Location = new System.Drawing.Point(61, 163);
            this.label_studentsurname.Name = "label_studentsurname";
            this.label_studentsurname.Size = new System.Drawing.Size(198, 29);
            this.label_studentsurname.TabIndex = 7;
            this.label_studentsurname.Text = "Student Surname";
            // 
            // textbox_studentsurname
            // 
            this.textbox_studentsurname.Location = new System.Drawing.Point(423, 158);
            this.textbox_studentsurname.Name = "textbox_studentsurname";
            this.textbox_studentsurname.Size = new System.Drawing.Size(366, 34);
            this.textbox_studentsurname.TabIndex = 6;
            this.textbox_studentsurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_studentsurname_KeyPress);
            // 
            // label_studentname
            // 
            this.label_studentname.AutoSize = true;
            this.label_studentname.Location = new System.Drawing.Point(61, 116);
            this.label_studentname.Name = "label_studentname";
            this.label_studentname.Size = new System.Drawing.Size(166, 29);
            this.label_studentname.TabIndex = 5;
            this.label_studentname.Text = "Student Name";
            // 
            // textbox_studentname
            // 
            this.textbox_studentname.Location = new System.Drawing.Point(423, 111);
            this.textbox_studentname.Name = "textbox_studentname";
            this.textbox_studentname.Size = new System.Drawing.Size(366, 34);
            this.textbox_studentname.TabIndex = 4;
            this.textbox_studentname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_studentname_KeyPress);
            // 
            // label_test3
            // 
            this.label_test3.AutoSize = true;
            this.label_test3.Location = new System.Drawing.Point(893, 213);
            this.label_test3.Name = "label_test3";
            this.label_test3.Size = new System.Drawing.Size(153, 29);
            this.label_test3.TabIndex = 3;
            this.label_test3.Text = "Place Holder";
            // 
            // label_test2
            // 
            this.label_test2.AutoSize = true;
            this.label_test2.Location = new System.Drawing.Point(893, 163);
            this.label_test2.Name = "label_test2";
            this.label_test2.Size = new System.Drawing.Size(153, 29);
            this.label_test2.TabIndex = 3;
            this.label_test2.Text = "Place Holder";
            // 
            // label_test1
            // 
            this.label_test1.AutoSize = true;
            this.label_test1.Location = new System.Drawing.Point(893, 114);
            this.label_test1.Name = "label_test1";
            this.label_test1.Size = new System.Drawing.Size(153, 29);
            this.label_test1.TabIndex = 3;
            this.label_test1.Text = "Place Holder";
            // 
            // label_studentnumber
            // 
            this.label_studentnumber.AutoSize = true;
            this.label_studentnumber.Location = new System.Drawing.Point(61, 213);
            this.label_studentnumber.Name = "label_studentnumber";
            this.label_studentnumber.Size = new System.Drawing.Size(188, 29);
            this.label_studentnumber.TabIndex = 3;
            this.label_studentnumber.Text = "Student Number";
            // 
            // textbox_studentnumber
            // 
            this.textbox_studentnumber.Location = new System.Drawing.Point(423, 208);
            this.textbox_studentnumber.MaxLength = 9;
            this.textbox_studentnumber.Name = "textbox_studentnumber";
            this.textbox_studentnumber.Size = new System.Drawing.Size(366, 34);
            this.textbox_studentnumber.TabIndex = 2;
            this.textbox_studentnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_studentnumber_KeyPress);
            // 
            // label_reg_student
            // 
            this.label_reg_student.AutoSize = true;
            this.label_reg_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_reg_student.Location = new System.Drawing.Point(21, 33);
            this.label_reg_student.Name = "label_reg_student";
            this.label_reg_student.Size = new System.Drawing.Size(261, 31);
            this.label_reg_student.TabIndex = 1;
            this.label_reg_student.Text = "Student Registration";
            // 
            // tab_update_student
            // 
            this.tab_update_student.Controls.Add(this.label_upt_student);
            this.tab_update_student.Location = new System.Drawing.Point(4, 38);
            this.tab_update_student.Name = "tab_update_student";
            this.tab_update_student.Padding = new System.Windows.Forms.Padding(3);
            this.tab_update_student.Size = new System.Drawing.Size(1228, 822);
            this.tab_update_student.TabIndex = 1;
            this.tab_update_student.Text = "Student Update";
            this.tab_update_student.UseVisualStyleBackColor = true;
            // 
            // label_upt_student
            // 
            this.label_upt_student.AutoSize = true;
            this.label_upt_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_upt_student.Location = new System.Drawing.Point(20, 33);
            this.label_upt_student.Name = "label_upt_student";
            this.label_upt_student.Size = new System.Drawing.Size(203, 31);
            this.label_upt_student.TabIndex = 2;
            this.label_upt_student.Text = "Student Update";
            // 
            // tab_reg_firma
            // 
            this.tab_reg_firma.Controls.Add(this.label_reg_firma);
            this.tab_reg_firma.Location = new System.Drawing.Point(4, 38);
            this.tab_reg_firma.Name = "tab_reg_firma";
            this.tab_reg_firma.Padding = new System.Windows.Forms.Padding(3);
            this.tab_reg_firma.Size = new System.Drawing.Size(1228, 822);
            this.tab_reg_firma.TabIndex = 2;
            this.tab_reg_firma.Text = "Firma Registration";
            this.tab_reg_firma.UseVisualStyleBackColor = true;
            // 
            // label_reg_firma
            // 
            this.label_reg_firma.AutoSize = true;
            this.label_reg_firma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_reg_firma.Location = new System.Drawing.Point(20, 33);
            this.label_reg_firma.Name = "label_reg_firma";
            this.label_reg_firma.Size = new System.Drawing.Size(236, 31);
            this.label_reg_firma.TabIndex = 3;
            this.label_reg_firma.Text = "Firma Registration";
            // 
            // tab_update_firma
            // 
            this.tab_update_firma.Controls.Add(this.label_update_firma);
            this.tab_update_firma.Location = new System.Drawing.Point(4, 38);
            this.tab_update_firma.Name = "tab_update_firma";
            this.tab_update_firma.Padding = new System.Windows.Forms.Padding(3);
            this.tab_update_firma.Size = new System.Drawing.Size(1228, 822);
            this.tab_update_firma.TabIndex = 3;
            this.tab_update_firma.Text = "Firma Update";
            this.tab_update_firma.UseVisualStyleBackColor = true;
            // 
            // label_update_firma
            // 
            this.label_update_firma.AutoSize = true;
            this.label_update_firma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_update_firma.Location = new System.Drawing.Point(20, 33);
            this.label_update_firma.Name = "label_update_firma";
            this.label_update_firma.Size = new System.Drawing.Size(178, 31);
            this.label_update_firma.TabIndex = 4;
            this.label_update_firma.Text = "Firma Update";
            // 
            // adminPageBindingSource
            // 
            this.adminPageBindingSource.DataSource = typeof(ProjectAssistant.AdminPage);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Admin_MainTab);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminPage";
            this.Size = new System.Drawing.Size(1236, 864);
            this.Admin_MainTab.ResumeLayout(false);
            this.tab_reg_student.ResumeLayout(false);
            this.tab_reg_student.PerformLayout();
            this.tab_update_student.ResumeLayout(false);
            this.tab_update_student.PerformLayout();
            this.tab_reg_firma.ResumeLayout(false);
            this.tab_reg_firma.PerformLayout();
            this.tab_update_firma.ResumeLayout(false);
            this.tab_update_firma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminPageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource adminPageBindingSource;
        private System.Windows.Forms.Button reg_student;
        private System.Windows.Forms.TabControl Admin_MainTab;
        private System.Windows.Forms.TabPage tab_reg_student;
        private System.Windows.Forms.Label label_reg_student;
        private System.Windows.Forms.TabPage tab_update_student;
        private System.Windows.Forms.TabPage tab_reg_firma;
        private System.Windows.Forms.TabPage tab_update_firma;
        private System.Windows.Forms.Label label_upt_student;
        private System.Windows.Forms.Label label_reg_firma;
        private System.Windows.Forms.Label label_update_firma;
        private System.Windows.Forms.Label label_studentnumber;
        private System.Windows.Forms.TextBox textbox_studentnumber;
        private System.Windows.Forms.Label label_studentsurname;
        private System.Windows.Forms.TextBox textbox_studentsurname;
        private System.Windows.Forms.Label label_studentname;
        private System.Windows.Forms.TextBox textbox_studentname;
        private System.Windows.Forms.Label label_test1;
        private System.Windows.Forms.Label label_test3;
        private System.Windows.Forms.Label label_test2;
        private System.Windows.Forms.Label label_test4;
        private System.Windows.Forms.Label label_studentpassword;
        private System.Windows.Forms.TextBox textbox_studentpassword;
    }
}