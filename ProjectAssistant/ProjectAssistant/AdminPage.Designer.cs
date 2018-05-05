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
            this.button_student_reg = new System.Windows.Forms.Button();
            this.Admin_MainTab = new System.Windows.Forms.TabControl();
            this.tab_student_reg = new System.Windows.Forms.TabPage();
            this.label_test4 = new System.Windows.Forms.Label();
            this.label_studentpassword = new System.Windows.Forms.Label();
            this.textbox_studentpassword = new System.Windows.Forms.TextBox();
            this.label_studentsurname = new System.Windows.Forms.Label();
            this.textbox_studentsurname = new System.Windows.Forms.TextBox();
            this.label_studentname = new System.Windows.Forms.Label();
            this.textbox_studentname = new System.Windows.Forms.TextBox();
            this.label_test3 = new System.Windows.Forms.Label();
            this.label_test2 = new System.Windows.Forms.Label();
            this.label_studentnumber = new System.Windows.Forms.Label();
            this.textbox_studentnumber = new System.Windows.Forms.TextBox();
            this.label_reg_student = new System.Windows.Forms.Label();
            this.tab_student_upt = new System.Windows.Forms.TabPage();
            this.button_student_show = new System.Windows.Forms.Button();
            this.groupBox_upt = new System.Windows.Forms.GroupBox();
            this.button_student_upt = new System.Windows.Forms.Button();
            this.label_studentpassword_upt = new System.Windows.Forms.Label();
            this.label_studentsurname_upt = new System.Windows.Forms.Label();
            this.label_studentname_upt = new System.Windows.Forms.Label();
            this.label_studentnumber_show = new System.Windows.Forms.Label();
            this.label_studentsurname_show = new System.Windows.Forms.Label();
            this.textbox_studentpassword_upt = new System.Windows.Forms.TextBox();
            this.textbox_studentsurname_upt = new System.Windows.Forms.TextBox();
            this.textbox_studentname_upt = new System.Windows.Forms.TextBox();
            this.label_studentname_show = new System.Windows.Forms.Label();
            this.label_student_show = new System.Windows.Forms.Label();
            this.textbox_studentnumber_show = new System.Windows.Forms.TextBox();
            this.label_upt_student = new System.Windows.Forms.Label();
            this.tab_firma_reg = new System.Windows.Forms.TabPage();
            this.label_test7 = new System.Windows.Forms.Label();
            this.label_firmaID = new System.Windows.Forms.Label();
            this.textbox_firmaID = new System.Windows.Forms.TextBox();
            this.label_test6 = new System.Windows.Forms.Label();
            this.label_test5 = new System.Windows.Forms.Label();
            this.button_firma_reg = new System.Windows.Forms.Button();
            this.label_firma_surname = new System.Windows.Forms.Label();
            this.label_firma_name = new System.Windows.Forms.Label();
            this.textbox_firmapassword = new System.Windows.Forms.TextBox();
            this.textbox_firmaname = new System.Windows.Forms.TextBox();
            this.label_reg_firma = new System.Windows.Forms.Label();
            this.tab_firma_upt = new System.Windows.Forms.TabPage();
            this.button_firma_show = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_firmaID_show = new System.Windows.Forms.Label();
            this.button_firma_update = new System.Windows.Forms.Button();
            this.label_firmapassword_upt = new System.Windows.Forms.Label();
            this.label_firmaname_upt = new System.Windows.Forms.Label();
            this.label_firmaname_show = new System.Windows.Forms.Label();
            this.textbox_firmapassword_upt = new System.Windows.Forms.TextBox();
            this.textbox_firmaname_upt = new System.Windows.Forms.TextBox();
            this.label_firma_show = new System.Windows.Forms.Label();
            this.textbox_firma_show = new System.Windows.Forms.TextBox();
            this.label_update_firma = new System.Windows.Forms.Label();
            this.adminPageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Admin_MainTab.SuspendLayout();
            this.tab_student_reg.SuspendLayout();
            this.tab_student_upt.SuspendLayout();
            this.groupBox_upt.SuspendLayout();
            this.tab_firma_reg.SuspendLayout();
            this.tab_firma_upt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminPageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_student_reg
            // 
            this.button_student_reg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_student_reg.Location = new System.Drawing.Point(926, 610);
            this.button_student_reg.Name = "button_student_reg";
            this.button_student_reg.Size = new System.Drawing.Size(172, 54);
            this.button_student_reg.TabIndex = 10;
            this.button_student_reg.Text = "Register";
            this.button_student_reg.UseVisualStyleBackColor = true;
            this.button_student_reg.Click += new System.EventHandler(this.reg_student_Click);
            // 
            // Admin_MainTab
            // 
            this.Admin_MainTab.Controls.Add(this.tab_student_reg);
            this.Admin_MainTab.Controls.Add(this.tab_student_upt);
            this.Admin_MainTab.Controls.Add(this.tab_firma_reg);
            this.Admin_MainTab.Controls.Add(this.tab_firma_upt);
            this.Admin_MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Admin_MainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Admin_MainTab.Location = new System.Drawing.Point(0, 0);
            this.Admin_MainTab.Multiline = true;
            this.Admin_MainTab.Name = "Admin_MainTab";
            this.Admin_MainTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Admin_MainTab.SelectedIndex = 0;
            this.Admin_MainTab.Size = new System.Drawing.Size(1993, 1233);
            this.Admin_MainTab.TabIndex = 0;
            this.Admin_MainTab.SelectedIndexChanged += new System.EventHandler(this.Admin_MainTab_SelectedIndexChanged);
            // 
            // tab_student_reg
            // 
            this.tab_student_reg.Controls.Add(this.label_test4);
            this.tab_student_reg.Controls.Add(this.label_studentpassword);
            this.tab_student_reg.Controls.Add(this.textbox_studentpassword);
            this.tab_student_reg.Controls.Add(this.label_studentsurname);
            this.tab_student_reg.Controls.Add(this.textbox_studentsurname);
            this.tab_student_reg.Controls.Add(this.label_studentname);
            this.tab_student_reg.Controls.Add(this.textbox_studentname);
            this.tab_student_reg.Controls.Add(this.label_test3);
            this.tab_student_reg.Controls.Add(this.label_test2);
            this.tab_student_reg.Controls.Add(this.label_studentnumber);
            this.tab_student_reg.Controls.Add(this.textbox_studentnumber);
            this.tab_student_reg.Controls.Add(this.label_reg_student);
            this.tab_student_reg.Controls.Add(this.button_student_reg);
            this.tab_student_reg.Location = new System.Drawing.Point(4, 38);
            this.tab_student_reg.Name = "tab_student_reg";
            this.tab_student_reg.Padding = new System.Windows.Forms.Padding(3);
            this.tab_student_reg.Size = new System.Drawing.Size(1985, 1191);
            this.tab_student_reg.TabIndex = 0;
            this.tab_student_reg.Text = "Student Registration";
            this.tab_student_reg.UseVisualStyleBackColor = true;
            // 
            // label_test4
            // 
            this.label_test4.AutoSize = true;
            this.label_test4.Location = new System.Drawing.Point(1310, 400);
            this.label_test4.Name = "label_test4";
            this.label_test4.Size = new System.Drawing.Size(153, 29);
            this.label_test4.TabIndex = 103;
            this.label_test4.Text = "Place Holder";
            // 
            // label_studentpassword
            // 
            this.label_studentpassword.AutoSize = true;
            this.label_studentpassword.Location = new System.Drawing.Point(460, 421);
            this.label_studentpassword.Name = "label_studentpassword";
            this.label_studentpassword.Size = new System.Drawing.Size(208, 29);
            this.label_studentpassword.TabIndex = 8;
            this.label_studentpassword.Text = "Student Password";
            // 
            // textbox_studentpassword
            // 
            this.textbox_studentpassword.Location = new System.Drawing.Point(822, 416);
            this.textbox_studentpassword.MaxLength = 18;
            this.textbox_studentpassword.Name = "textbox_studentpassword";
            this.textbox_studentpassword.Size = new System.Drawing.Size(366, 34);
            this.textbox_studentpassword.TabIndex = 9;
            this.textbox_studentpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_studentpassword_KeyPress);
            // 
            // label_studentsurname
            // 
            this.label_studentsurname.AutoSize = true;
            this.label_studentsurname.Location = new System.Drawing.Point(460, 303);
            this.label_studentsurname.Name = "label_studentsurname";
            this.label_studentsurname.Size = new System.Drawing.Size(198, 29);
            this.label_studentsurname.TabIndex = 4;
            this.label_studentsurname.Text = "Student Surname";
            // 
            // textbox_studentsurname
            // 
            this.textbox_studentsurname.Location = new System.Drawing.Point(822, 300);
            this.textbox_studentsurname.Name = "textbox_studentsurname";
            this.textbox_studentsurname.Size = new System.Drawing.Size(366, 34);
            this.textbox_studentsurname.TabIndex = 5;
            this.textbox_studentsurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_studentsurname_KeyPress);
            // 
            // label_studentname
            // 
            this.label_studentname.AutoSize = true;
            this.label_studentname.Location = new System.Drawing.Point(460, 241);
            this.label_studentname.Name = "label_studentname";
            this.label_studentname.Size = new System.Drawing.Size(166, 29);
            this.label_studentname.TabIndex = 2;
            this.label_studentname.Text = "Student Name";
            // 
            // textbox_studentname
            // 
            this.textbox_studentname.Location = new System.Drawing.Point(822, 238);
            this.textbox_studentname.Name = "textbox_studentname";
            this.textbox_studentname.Size = new System.Drawing.Size(366, 34);
            this.textbox_studentname.TabIndex = 3;
            this.textbox_studentname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_studentname_KeyPress);
            // 
            // label_test3
            // 
            this.label_test3.AutoSize = true;
            this.label_test3.Location = new System.Drawing.Point(1310, 343);
            this.label_test3.Name = "label_test3";
            this.label_test3.Size = new System.Drawing.Size(153, 29);
            this.label_test3.TabIndex = 102;
            this.label_test3.Text = "Place Holder";
            // 
            // label_test2
            // 
            this.label_test2.AutoSize = true;
            this.label_test2.Location = new System.Drawing.Point(1310, 286);
            this.label_test2.Name = "label_test2";
            this.label_test2.Size = new System.Drawing.Size(153, 29);
            this.label_test2.TabIndex = 101;
            this.label_test2.Text = "Place Holder";
            // 
            // label_studentnumber
            // 
            this.label_studentnumber.AutoSize = true;
            this.label_studentnumber.Location = new System.Drawing.Point(460, 361);
            this.label_studentnumber.Name = "label_studentnumber";
            this.label_studentnumber.Size = new System.Drawing.Size(188, 29);
            this.label_studentnumber.TabIndex = 6;
            this.label_studentnumber.Text = "Student Number";
            // 
            // textbox_studentnumber
            // 
            this.textbox_studentnumber.Location = new System.Drawing.Point(822, 358);
            this.textbox_studentnumber.MaxLength = 9;
            this.textbox_studentnumber.Name = "textbox_studentnumber";
            this.textbox_studentnumber.Size = new System.Drawing.Size(366, 34);
            this.textbox_studentnumber.TabIndex = 7;
            this.textbox_studentnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_studentnumber_KeyPress);
            // 
            // label_reg_student
            // 
            this.label_reg_student.AutoSize = true;
            this.label_reg_student.Font = new System.Drawing.Font("MetaPro-Bold", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_reg_student.Location = new System.Drawing.Point(21, 33);
            this.label_reg_student.Name = "label_reg_student";
            this.label_reg_student.Size = new System.Drawing.Size(262, 40);
            this.label_reg_student.TabIndex = 1;
            this.label_reg_student.Text = "Student Registration";
            // 
            // tab_student_upt
            // 
            this.tab_student_upt.Controls.Add(this.button_student_show);
            this.tab_student_upt.Controls.Add(this.groupBox_upt);
            this.tab_student_upt.Controls.Add(this.label_student_show);
            this.tab_student_upt.Controls.Add(this.textbox_studentnumber_show);
            this.tab_student_upt.Controls.Add(this.label_upt_student);
            this.tab_student_upt.Location = new System.Drawing.Point(4, 38);
            this.tab_student_upt.Name = "tab_student_upt";
            this.tab_student_upt.Padding = new System.Windows.Forms.Padding(3);
            this.tab_student_upt.Size = new System.Drawing.Size(1985, 1191);
            this.tab_student_upt.TabIndex = 1;
            this.tab_student_upt.Text = "Student Update";
            this.tab_student_upt.UseVisualStyleBackColor = true;
            // 
            // button_student_show
            // 
            this.button_student_show.Location = new System.Drawing.Point(1280, 214);
            this.button_student_show.Name = "button_student_show";
            this.button_student_show.Size = new System.Drawing.Size(172, 54);
            this.button_student_show.TabIndex = 4;
            this.button_student_show.Text = "Show";
            this.button_student_show.UseVisualStyleBackColor = true;
            this.button_student_show.Click += new System.EventHandler(this.button_studentshow_Click);
            // 
            // groupBox_upt
            // 
            this.groupBox_upt.Controls.Add(this.button_student_upt);
            this.groupBox_upt.Controls.Add(this.label_studentpassword_upt);
            this.groupBox_upt.Controls.Add(this.label_studentsurname_upt);
            this.groupBox_upt.Controls.Add(this.label_studentname_upt);
            this.groupBox_upt.Controls.Add(this.label_studentnumber_show);
            this.groupBox_upt.Controls.Add(this.label_studentsurname_show);
            this.groupBox_upt.Controls.Add(this.textbox_studentpassword_upt);
            this.groupBox_upt.Controls.Add(this.textbox_studentsurname_upt);
            this.groupBox_upt.Controls.Add(this.textbox_studentname_upt);
            this.groupBox_upt.Controls.Add(this.label_studentname_show);
            this.groupBox_upt.Location = new System.Drawing.Point(449, 308);
            this.groupBox_upt.Name = "groupBox_upt";
            this.groupBox_upt.Size = new System.Drawing.Size(1058, 547);
            this.groupBox_upt.TabIndex = 5;
            this.groupBox_upt.TabStop = false;
            // 
            // button_student_upt
            // 
            this.button_student_upt.Location = new System.Drawing.Point(409, 344);
            this.button_student_upt.Name = "button_student_upt";
            this.button_student_upt.Size = new System.Drawing.Size(172, 54);
            this.button_student_upt.TabIndex = 15;
            this.button_student_upt.Text = "Update";
            this.button_student_upt.UseVisualStyleBackColor = true;
            // 
            // label_studentpassword_upt
            // 
            this.label_studentpassword_upt.AutoSize = true;
            this.label_studentpassword_upt.Location = new System.Drawing.Point(48, 268);
            this.label_studentpassword_upt.Name = "label_studentpassword_upt";
            this.label_studentpassword_upt.Size = new System.Drawing.Size(208, 29);
            this.label_studentpassword_upt.TabIndex = 13;
            this.label_studentpassword_upt.Text = "Student Password";
            // 
            // label_studentsurname_upt
            // 
            this.label_studentsurname_upt.AutoSize = true;
            this.label_studentsurname_upt.Location = new System.Drawing.Point(48, 205);
            this.label_studentsurname_upt.Name = "label_studentsurname_upt";
            this.label_studentsurname_upt.Size = new System.Drawing.Size(198, 29);
            this.label_studentsurname_upt.TabIndex = 11;
            this.label_studentsurname_upt.Text = "Student Surname";
            // 
            // label_studentname_upt
            // 
            this.label_studentname_upt.AutoSize = true;
            this.label_studentname_upt.Location = new System.Drawing.Point(48, 143);
            this.label_studentname_upt.Name = "label_studentname_upt";
            this.label_studentname_upt.Size = new System.Drawing.Size(166, 29);
            this.label_studentname_upt.TabIndex = 9;
            this.label_studentname_upt.Text = "Student Name";
            // 
            // label_studentnumber_show
            // 
            this.label_studentnumber_show.AutoSize = true;
            this.label_studentnumber_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_studentnumber_show.Location = new System.Drawing.Point(48, 44);
            this.label_studentnumber_show.Name = "label_studentnumber_show";
            this.label_studentnumber_show.Size = new System.Drawing.Size(202, 29);
            this.label_studentnumber_show.TabIndex = 6;
            this.label_studentnumber_show.Text = "Student Number";
            // 
            // label_studentsurname_show
            // 
            this.label_studentsurname_show.AutoSize = true;
            this.label_studentsurname_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_studentsurname_show.Location = new System.Drawing.Point(536, 44);
            this.label_studentsurname_show.Name = "label_studentsurname_show";
            this.label_studentsurname_show.Size = new System.Drawing.Size(213, 29);
            this.label_studentsurname_show.TabIndex = 8;
            this.label_studentsurname_show.Text = "Student Surname";
            // 
            // textbox_studentpassword_upt
            // 
            this.textbox_studentpassword_upt.Location = new System.Drawing.Point(299, 265);
            this.textbox_studentpassword_upt.MaxLength = 18;
            this.textbox_studentpassword_upt.Name = "textbox_studentpassword_upt";
            this.textbox_studentpassword_upt.Size = new System.Drawing.Size(366, 34);
            this.textbox_studentpassword_upt.TabIndex = 14;
            // 
            // textbox_studentsurname_upt
            // 
            this.textbox_studentsurname_upt.Location = new System.Drawing.Point(299, 205);
            this.textbox_studentsurname_upt.MaxLength = 20;
            this.textbox_studentsurname_upt.Name = "textbox_studentsurname_upt";
            this.textbox_studentsurname_upt.Size = new System.Drawing.Size(366, 34);
            this.textbox_studentsurname_upt.TabIndex = 12;
            // 
            // textbox_studentname_upt
            // 
            this.textbox_studentname_upt.Location = new System.Drawing.Point(299, 143);
            this.textbox_studentname_upt.MaxLength = 20;
            this.textbox_studentname_upt.Name = "textbox_studentname_upt";
            this.textbox_studentname_upt.Size = new System.Drawing.Size(366, 34);
            this.textbox_studentname_upt.TabIndex = 10;
            // 
            // label_studentname_show
            // 
            this.label_studentname_show.AutoSize = true;
            this.label_studentname_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_studentname_show.Location = new System.Drawing.Point(294, 44);
            this.label_studentname_show.Name = "label_studentname_show";
            this.label_studentname_show.Size = new System.Drawing.Size(178, 29);
            this.label_studentname_show.TabIndex = 7;
            this.label_studentname_show.Text = "Student Name";
            // 
            // label_student_show
            // 
            this.label_student_show.AutoSize = true;
            this.label_student_show.Location = new System.Drawing.Point(497, 227);
            this.label_student_show.Name = "label_student_show";
            this.label_student_show.Size = new System.Drawing.Size(188, 29);
            this.label_student_show.TabIndex = 2;
            this.label_student_show.Text = "Student Number";
            // 
            // textbox_studentnumber_show
            // 
            this.textbox_studentnumber_show.Location = new System.Drawing.Point(778, 224);
            this.textbox_studentnumber_show.MaxLength = 9;
            this.textbox_studentnumber_show.Name = "textbox_studentnumber_show";
            this.textbox_studentnumber_show.Size = new System.Drawing.Size(366, 34);
            this.textbox_studentnumber_show.TabIndex = 3;
            // 
            // label_upt_student
            // 
            this.label_upt_student.AutoSize = true;
            this.label_upt_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_upt_student.Location = new System.Drawing.Point(20, 33);
            this.label_upt_student.Name = "label_upt_student";
            this.label_upt_student.Size = new System.Drawing.Size(203, 31);
            this.label_upt_student.TabIndex = 1;
            this.label_upt_student.Text = "Student Update";
            // 
            // tab_firma_reg
            // 
            this.tab_firma_reg.Controls.Add(this.label_test7);
            this.tab_firma_reg.Controls.Add(this.label_firmaID);
            this.tab_firma_reg.Controls.Add(this.textbox_firmaID);
            this.tab_firma_reg.Controls.Add(this.label_test6);
            this.tab_firma_reg.Controls.Add(this.label_test5);
            this.tab_firma_reg.Controls.Add(this.button_firma_reg);
            this.tab_firma_reg.Controls.Add(this.label_firma_surname);
            this.tab_firma_reg.Controls.Add(this.label_firma_name);
            this.tab_firma_reg.Controls.Add(this.textbox_firmapassword);
            this.tab_firma_reg.Controls.Add(this.textbox_firmaname);
            this.tab_firma_reg.Controls.Add(this.label_reg_firma);
            this.tab_firma_reg.Location = new System.Drawing.Point(4, 38);
            this.tab_firma_reg.Name = "tab_firma_reg";
            this.tab_firma_reg.Padding = new System.Windows.Forms.Padding(3);
            this.tab_firma_reg.Size = new System.Drawing.Size(1985, 1191);
            this.tab_firma_reg.TabIndex = 2;
            this.tab_firma_reg.Text = "Firma Registration";
            this.tab_firma_reg.UseVisualStyleBackColor = true;
            // 
            // label_test7
            // 
            this.label_test7.AutoSize = true;
            this.label_test7.Location = new System.Drawing.Point(1332, 367);
            this.label_test7.Name = "label_test7";
            this.label_test7.Size = new System.Drawing.Size(153, 29);
            this.label_test7.TabIndex = 11;
            this.label_test7.Text = "Place Holder";
            // 
            // label_firmaID
            // 
            this.label_firmaID.AutoSize = true;
            this.label_firmaID.Location = new System.Drawing.Point(460, 241);
            this.label_firmaID.Name = "label_firmaID";
            this.label_firmaID.Size = new System.Drawing.Size(104, 29);
            this.label_firmaID.TabIndex = 2;
            this.label_firmaID.Text = "Firma ID";
            // 
            // textbox_firmaID
            // 
            this.textbox_firmaID.Location = new System.Drawing.Point(822, 238);
            this.textbox_firmaID.MaxLength = 18;
            this.textbox_firmaID.Name = "textbox_firmaID";
            this.textbox_firmaID.Size = new System.Drawing.Size(366, 34);
            this.textbox_firmaID.TabIndex = 3;
            // 
            // label_test6
            // 
            this.label_test6.AutoSize = true;
            this.label_test6.Location = new System.Drawing.Point(1332, 307);
            this.label_test6.Name = "label_test6";
            this.label_test6.Size = new System.Drawing.Size(153, 29);
            this.label_test6.TabIndex = 7;
            this.label_test6.Text = "Place Holder";
            // 
            // label_test5
            // 
            this.label_test5.AutoSize = true;
            this.label_test5.Location = new System.Drawing.Point(1332, 243);
            this.label_test5.Name = "label_test5";
            this.label_test5.Size = new System.Drawing.Size(153, 29);
            this.label_test5.TabIndex = 4;
            this.label_test5.Text = "Place Holder";
            // 
            // button_firma_reg
            // 
            this.button_firma_reg.Location = new System.Drawing.Point(923, 611);
            this.button_firma_reg.Name = "button_firma_reg";
            this.button_firma_reg.Size = new System.Drawing.Size(172, 54);
            this.button_firma_reg.TabIndex = 8;
            this.button_firma_reg.Text = "Register";
            this.button_firma_reg.UseVisualStyleBackColor = true;
            // 
            // label_firma_surname
            // 
            this.label_firma_surname.AutoSize = true;
            this.label_firma_surname.Location = new System.Drawing.Point(460, 361);
            this.label_firma_surname.Name = "label_firma_surname";
            this.label_firma_surname.Size = new System.Drawing.Size(188, 29);
            this.label_firma_surname.TabIndex = 6;
            this.label_firma_surname.Text = "Firma Password";
            // 
            // label_firma_name
            // 
            this.label_firma_name.AutoSize = true;
            this.label_firma_name.Location = new System.Drawing.Point(460, 303);
            this.label_firma_name.Name = "label_firma_name";
            this.label_firma_name.Size = new System.Drawing.Size(146, 29);
            this.label_firma_name.TabIndex = 4;
            this.label_firma_name.Text = "Firma Name";
            // 
            // textbox_firmapassword
            // 
            this.textbox_firmapassword.Location = new System.Drawing.Point(822, 358);
            this.textbox_firmapassword.MaxLength = 18;
            this.textbox_firmapassword.Name = "textbox_firmapassword";
            this.textbox_firmapassword.Size = new System.Drawing.Size(366, 34);
            this.textbox_firmapassword.TabIndex = 7;
            // 
            // textbox_firmaname
            // 
            this.textbox_firmaname.Location = new System.Drawing.Point(822, 298);
            this.textbox_firmaname.MaxLength = 9;
            this.textbox_firmaname.Name = "textbox_firmaname";
            this.textbox_firmaname.Size = new System.Drawing.Size(366, 34);
            this.textbox_firmaname.TabIndex = 5;
            // 
            // label_reg_firma
            // 
            this.label_reg_firma.AutoSize = true;
            this.label_reg_firma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_reg_firma.Location = new System.Drawing.Point(20, 33);
            this.label_reg_firma.Name = "label_reg_firma";
            this.label_reg_firma.Size = new System.Drawing.Size(236, 31);
            this.label_reg_firma.TabIndex = 1;
            this.label_reg_firma.Text = "Firma Registration";
            // 
            // tab_firma_upt
            // 
            this.tab_firma_upt.Controls.Add(this.button_firma_show);
            this.tab_firma_upt.Controls.Add(this.groupBox1);
            this.tab_firma_upt.Controls.Add(this.label_firma_show);
            this.tab_firma_upt.Controls.Add(this.textbox_firma_show);
            this.tab_firma_upt.Controls.Add(this.label_update_firma);
            this.tab_firma_upt.Location = new System.Drawing.Point(4, 38);
            this.tab_firma_upt.Name = "tab_firma_upt";
            this.tab_firma_upt.Padding = new System.Windows.Forms.Padding(3);
            this.tab_firma_upt.Size = new System.Drawing.Size(1985, 1191);
            this.tab_firma_upt.TabIndex = 3;
            this.tab_firma_upt.Text = "Firma Update";
            this.tab_firma_upt.UseVisualStyleBackColor = true;
            // 
            // button_firma_show
            // 
            this.button_firma_show.Location = new System.Drawing.Point(1280, 217);
            this.button_firma_show.Name = "button_firma_show";
            this.button_firma_show.Size = new System.Drawing.Size(172, 54);
            this.button_firma_show.TabIndex = 4;
            this.button_firma_show.Text = "Show";
            this.button_firma_show.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_firmaID_show);
            this.groupBox1.Controls.Add(this.button_firma_update);
            this.groupBox1.Controls.Add(this.label_firmapassword_upt);
            this.groupBox1.Controls.Add(this.label_firmaname_upt);
            this.groupBox1.Controls.Add(this.label_firmaname_show);
            this.groupBox1.Controls.Add(this.textbox_firmapassword_upt);
            this.groupBox1.Controls.Add(this.textbox_firmaname_upt);
            this.groupBox1.Location = new System.Drawing.Point(449, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 547);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label_firmaID_show
            // 
            this.label_firmaID_show.AutoSize = true;
            this.label_firmaID_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_firmaID_show.Location = new System.Drawing.Point(48, 44);
            this.label_firmaID_show.Name = "label_firmaID_show";
            this.label_firmaID_show.Size = new System.Drawing.Size(112, 29);
            this.label_firmaID_show.TabIndex = 4;
            this.label_firmaID_show.Text = "Firma ID";
            // 
            // button_firma_update
            // 
            this.button_firma_update.Location = new System.Drawing.Point(409, 344);
            this.button_firma_update.Name = "button_firma_update";
            this.button_firma_update.Size = new System.Drawing.Size(172, 54);
            this.button_firma_update.TabIndex = 10;
            this.button_firma_update.Text = "Update";
            this.button_firma_update.UseVisualStyleBackColor = true;
            // 
            // label_firmapassword_upt
            // 
            this.label_firmapassword_upt.AutoSize = true;
            this.label_firmapassword_upt.Location = new System.Drawing.Point(48, 205);
            this.label_firmapassword_upt.Name = "label_firmapassword_upt";
            this.label_firmapassword_upt.Size = new System.Drawing.Size(188, 29);
            this.label_firmapassword_upt.TabIndex = 8;
            this.label_firmapassword_upt.Text = "Firma Password";
            // 
            // label_firmaname_upt
            // 
            this.label_firmaname_upt.AutoSize = true;
            this.label_firmaname_upt.Location = new System.Drawing.Point(48, 143);
            this.label_firmaname_upt.Name = "label_firmaname_upt";
            this.label_firmaname_upt.Size = new System.Drawing.Size(146, 29);
            this.label_firmaname_upt.TabIndex = 6;
            this.label_firmaname_upt.Text = "Firma Name";
            // 
            // label_firmaname_show
            // 
            this.label_firmaname_show.AutoSize = true;
            this.label_firmaname_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_firmaname_show.Location = new System.Drawing.Point(292, 44);
            this.label_firmaname_show.Name = "label_firmaname_show";
            this.label_firmaname_show.Size = new System.Drawing.Size(156, 29);
            this.label_firmaname_show.TabIndex = 5;
            this.label_firmaname_show.Text = "Firma Name";
            // 
            // textbox_firmapassword_upt
            // 
            this.textbox_firmapassword_upt.Location = new System.Drawing.Point(299, 205);
            this.textbox_firmapassword_upt.MaxLength = 18;
            this.textbox_firmapassword_upt.Name = "textbox_firmapassword_upt";
            this.textbox_firmapassword_upt.Size = new System.Drawing.Size(366, 34);
            this.textbox_firmapassword_upt.TabIndex = 9;
            // 
            // textbox_firmaname_upt
            // 
            this.textbox_firmaname_upt.Location = new System.Drawing.Point(299, 143);
            this.textbox_firmaname_upt.Name = "textbox_firmaname_upt";
            this.textbox_firmaname_upt.Size = new System.Drawing.Size(366, 34);
            this.textbox_firmaname_upt.TabIndex = 7;
            // 
            // label_firma_show
            // 
            this.label_firma_show.AutoSize = true;
            this.label_firma_show.Location = new System.Drawing.Point(497, 230);
            this.label_firma_show.Name = "label_firma_show";
            this.label_firma_show.Size = new System.Drawing.Size(104, 29);
            this.label_firma_show.TabIndex = 2;
            this.label_firma_show.Text = "Firma ID";
            // 
            // textbox_firma_show
            // 
            this.textbox_firma_show.Location = new System.Drawing.Point(778, 227);
            this.textbox_firma_show.Name = "textbox_firma_show";
            this.textbox_firma_show.Size = new System.Drawing.Size(366, 34);
            this.textbox_firma_show.TabIndex = 3;
            // 
            // label_update_firma
            // 
            this.label_update_firma.AutoSize = true;
            this.label_update_firma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_update_firma.Location = new System.Drawing.Point(20, 33);
            this.label_update_firma.Name = "label_update_firma";
            this.label_update_firma.Size = new System.Drawing.Size(178, 31);
            this.label_update_firma.TabIndex = 1;
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
            this.Size = new System.Drawing.Size(1993, 1233);
            this.Admin_MainTab.ResumeLayout(false);
            this.tab_student_reg.ResumeLayout(false);
            this.tab_student_reg.PerformLayout();
            this.tab_student_upt.ResumeLayout(false);
            this.tab_student_upt.PerformLayout();
            this.groupBox_upt.ResumeLayout(false);
            this.groupBox_upt.PerformLayout();
            this.tab_firma_reg.ResumeLayout(false);
            this.tab_firma_reg.PerformLayout();
            this.tab_firma_upt.ResumeLayout(false);
            this.tab_firma_upt.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminPageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource adminPageBindingSource;
        private System.Windows.Forms.Button button_student_reg;
        private System.Windows.Forms.TabControl Admin_MainTab;
        private System.Windows.Forms.TabPage tab_student_reg;
        private System.Windows.Forms.Label label_reg_student;
        private System.Windows.Forms.TabPage tab_student_upt;
        private System.Windows.Forms.TabPage tab_firma_reg;
        private System.Windows.Forms.TabPage tab_firma_upt;
        private System.Windows.Forms.Label label_upt_student;
        private System.Windows.Forms.Label label_reg_firma;
        private System.Windows.Forms.Label label_update_firma;
        private System.Windows.Forms.Label label_studentnumber;
        private System.Windows.Forms.TextBox textbox_studentnumber;
        private System.Windows.Forms.Label label_studentsurname;
        private System.Windows.Forms.TextBox textbox_studentsurname;
        private System.Windows.Forms.Label label_studentname;
        private System.Windows.Forms.TextBox textbox_studentname;
        private System.Windows.Forms.Label label_test3;
        private System.Windows.Forms.Label label_test2;
        private System.Windows.Forms.Label label_test4;
        private System.Windows.Forms.Label label_studentpassword;
        private System.Windows.Forms.TextBox textbox_studentpassword;
        private System.Windows.Forms.Label label_student_show;
        private System.Windows.Forms.TextBox textbox_studentnumber_show;
        private System.Windows.Forms.Label label_studentnumber_show;
        private System.Windows.Forms.Label label_studentname_show;
        private System.Windows.Forms.TextBox textbox_studentname_upt;
        private System.Windows.Forms.GroupBox groupBox_upt;
        private System.Windows.Forms.Label label_studentsurname_show;
        private System.Windows.Forms.Button button_student_show;
        private System.Windows.Forms.Label label_studentpassword_upt;
        private System.Windows.Forms.Label label_studentsurname_upt;
        private System.Windows.Forms.Label label_studentname_upt;
        private System.Windows.Forms.TextBox textbox_studentpassword_upt;
        private System.Windows.Forms.TextBox textbox_studentsurname_upt;
        private System.Windows.Forms.Button button_student_upt;
        private System.Windows.Forms.Label label_firma_surname;
        private System.Windows.Forms.Label label_firma_name;
        private System.Windows.Forms.TextBox textbox_firmapassword;
        private System.Windows.Forms.TextBox textbox_firmaname;
        private System.Windows.Forms.Label label_test6;
        private System.Windows.Forms.Label label_test5;
        private System.Windows.Forms.Button button_firma_reg;
        private System.Windows.Forms.Button button_firma_show;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_firma_update;
        private System.Windows.Forms.Label label_firmapassword_upt;
        private System.Windows.Forms.Label label_firmaname_upt;
        private System.Windows.Forms.Label label_firmaname_show;
        private System.Windows.Forms.TextBox textbox_firmapassword_upt;
        private System.Windows.Forms.TextBox textbox_firmaname_upt;
        private System.Windows.Forms.Label label_firma_show;
        private System.Windows.Forms.TextBox textbox_firma_show;
        private System.Windows.Forms.Label label_test7;
        private System.Windows.Forms.Label label_firmaID;
        private System.Windows.Forms.TextBox textbox_firmaID;
        private System.Windows.Forms.Label label_firmaID_show;
    }
}
