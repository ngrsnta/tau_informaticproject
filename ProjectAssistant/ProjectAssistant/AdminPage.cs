using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAssistant
{
  
    public partial class AdminPage : UserControl //Main
    {
        DataBase db = new DataBase();
        Student stu = new Student();
        Company comp = new Company();
        public AdminPage() //Start
        {
            InitializeComponent();

        }
        /// <summary>
        /// When changed to a Tab, delete all Text Boxes
        /// </summary>
 /*       void Delete_Text()  
        {
            var selectedTab = Admin_MainTab.SelectedTab;

            foreach (Control ctrl in selectedTab.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = string.Empty;
                }

                if (ctrl is Label)
                {
                    if ((ctrl != label_studentname ||
                        ctrl != label_studentnumber ||
                        ctrl != label_studentsurname ||
                        ctrl != label_studentpassword) == false)
                        (ctrl as Label).Text = string.Empty;
                }

                // Other Controls....
            }
        }
*/
        
        /// <summary>
        /// Storing Inputs from Register Panel to Student Class
        /// </summary>
        /// <param name="stu">Output Student</param>
        void AdminToStudent(Student stu)
        {
            stu.name = textbox_studentname.Text + " " + textbox_studentsurname.Text;
            stu.id_number = Convert.ToInt32(textbox_studentnumber.Text);
            stu.password = textbox_studentpassword.Text;
            stu.dateofbirth = datepicker_student.Value; // ("yyyy-MM-dd"); 
                                                        //stu.gender = comboBox_studentgender.Text;
            if (radioButton_male_reg.Checked)
                stu.gender = radioButton_male_reg.Text;
            else if (radioButton_female_reg.Checked)
                stu.gender = radioButton_female_reg.Text;
            stu.faculty = textbox_studentfaculty.Text;
            stu.major = textbox_studentmajor.Text;
            //stu.semester = Convert.ToInt32(textbox_studentsemester.Text);
            stu.semester = Convert.ToInt32(comboBox_studentsemester.Text);
        }
        
        /// <summary>
        /// Makes Student Update Panel Visible
        /// </summary>
        void Show_Student_Upt_Panel(bool visible)
        {
            groupBox_student_upt.Visible = visible;
            groupBox_studentID_show.Visible = visible;
            groupBox_studentinfo_del.Visible = visible;
        }

        /// <summary>
        /// Takes info from Database to Student Class by Student ID
        /// </summary>
        /// <param name="db">Input DataBase</param>
        /// <param name="student_ID">Input Student ID</param>
        /// <param name="stu">Output Class</param>
        void DbToStudent(DataBase db,string student_ID, Student stu)
        {
            stu.id_number = Convert.ToInt32(db.select_fromDatabase("studentId", "students", "studentId", student_ID));
            stu.name = db.select_fromDatabase("studentName", "students", "studentId", student_ID);
            stu.dateofbirth = Convert.ToDateTime(db.select_fromDatabase("studentBirthday", "students", "studentId", student_ID));
            stu.gender = db.select_fromDatabase("studentGender", "students", "studentId", student_ID);
            stu.faculty = db.select_fromDatabase("studentFaculty", "students", "studentId", student_ID);
            stu.major = db.select_fromDatabase("studentMajor", "students", "studentId", student_ID);
            stu.semester = Convert.ToInt32(db.select_fromDatabase("studentSemester", "students", "studentId", student_ID));
        }

        /// <summary>
        /// Brings Student info from Class to Update Panel
        /// </summary>
        /// <param name="stu">Input Class</param>
        void StudentToUpt(Student stu)
        {
            textbox_studentname_upt.Text = stu.name;
            datepicker_student_upt.Value = stu.dateofbirth;
            if (stu.gender == radioButton_male_upt.Text)
                radioButton_male_upt.Checked = true;
            else if (stu.gender == radioButton_female_upt.Text)
                radioButton_female_upt.Checked = true;
            else
            {
                radioButton_male_upt.Checked = false;
                radioButton_female_upt.Checked = false;
            }
            textbox_studentfaculty_upt.Text = stu.faculty;
            textbox_studentmajor_upt.Text = stu.major;
            comboBox_studentsemester_upt.Text = stu.semester.ToString();
        }

        /// <summary>
        /// Print Student Infos from Class to Labels
        /// </summary>
        /// <param name="stu">Input Student Class</param>
        void Show_Student_Info(Student stu)
        {
            label_studentnumber_show.Text = stu.id_number.ToString();
            label_studentname_show.Text = stu.name;
            label_studentdate_show.Text = stu.dateofbirth.ToString("dd.MM.yyyy");
            label_studentgender_show.Text = stu.gender;
            label_studentfaculty_show.Text = stu.faculty;
            label_studentmajor_show.Text = stu.major;
            label_studentsemester_show.Text = stu.semester.ToString();
        }

        /// <summary>
        /// Bring Infos from Update Panel to Student Class
        /// </summary>
        /// <param name="stu_upt">Output Student Class</param>
        void UptToStudent(Student stu_upt)
        {
            foreach (Control ctrl in Admin_MainTab.SelectedTab.Controls)
                foreach (Control ctrl_sub in ctrl.Controls)
                    foreach (Control ctrl_sub_sub in ctrl_sub.Controls)
                        if (ctrl_sub_sub is TextBox)
                            if ((ctrl_sub_sub as TextBox).TextLength != 0)
                            {
                                if (ctrl_sub_sub == textbox_studentname_upt)
                                    stu_upt.name = ctrl_sub_sub.Text;
                                else if (ctrl_sub_sub == textbox_studentfaculty_upt)
                                    stu_upt.faculty = ctrl_sub_sub.Text;
                                else if (ctrl_sub_sub == textbox_studentmajor_upt)
                                    stu_upt.major = ctrl_sub_sub.Text;
                                else if (ctrl_sub_sub == textbox_studentpassword_upt)
                                    stu_upt.password = ctrl_sub_sub.Text;
                            }
            stu_upt.dateofbirth = datepicker_student_upt.Value;
            if (radioButton_male_upt.Checked)
                stu_upt.gender = radioButton_male_upt.Text;
            else if (radioButton_female_upt.Checked)
                stu_upt.gender = radioButton_female_upt.Text;
            stu_upt.semester = Convert.ToInt32(comboBox_studentsemester_upt.Text);
            /*           stu_upt.faculty = textbox_studentfaculty_upt.Text;
                         stu_upt.major = textbox_studentmajor_upt.Text;
                         if(textbox_studentpassword_upt.Text.Length>0)
                            stu_upt.password = textbox_studentpassword_upt.Text;
                         stu_upt.name = textbox_studentname_upt.Text;                      */
        }

        /// <summary>
        /// Compares the old and the new Student Infos and sends only the changes to Database
        /// </summary>
        /// <param name="stu">Current Info Student</param>
        /// <param name="stu_upt">Changed Info Student</param>
        /// <param name="db">Output to DataBase</param>
        /// <param name="student_ID">Student ID</param>
        void Student_UptToDb(Student stu, Student stu_upt, DataBase db, string student_ID)
        {
            if (stu.name != stu_upt.name)
                db.update_toDatabase("students", "studentName", stu_upt.name, "studentId", student_ID);
            if (stu.dateofbirth != stu_upt.dateofbirth)
                db.update_toDatabase("students", "studentBirthday", stu_upt.dateofbirth.ToString("yyyy-MM-dd"), "studentId", student_ID);
            if (stu.gender != stu_upt.gender)
                db.update_toDatabase("students", "studentGender", stu_upt.gender, "studentId", student_ID);
            if (stu.faculty != stu_upt.faculty)
                db.update_toDatabase("students", "studentFaculty", stu_upt.faculty, "studentId", student_ID);
            if (stu.major != stu_upt.major)
                db.update_toDatabase("students", "studentMajor", stu_upt.major, "studentId", student_ID);
            if (stu.semester != stu_upt.semester)
                db.update_toDatabase("students", "studentSemester", stu_upt.semester.ToString(), "studentId", student_ID);
            if (stu.password != stu_upt.password)
                db.update_toDatabase("students", "studentPassword", stu_upt.password, "studentId", student_ID);
        }

        /// <summary>
        /// Resets Labels of Showed Student Infos
        /// </summary>
        void Reset_Label_Stu_Upt()
        {
            label_studentnumber_show.Text = "Student ID";
            label_studentname_show.Text = "Name";
            label_studentdate_show.Text = "Date of Birth";
            label_studentgender_show.Text = "Gender";
            label_studentfaculty_show.Text = "Faculty";
            label_studentmajor_show.Text = "Major";
            label_studentsemester_show.Text = "Semester";
        }

        /// <summary>
        /// Resets TextBoxes in the current Tab
        /// </summary>
        void Reset_TextBox()
        {
            var selectedTab = Admin_MainTab.SelectedTab;

            foreach (Control ctrl in selectedTab.Controls)  //For each Control in Selected Tab 
            {
                foreach (Control ctrl_sub in ctrl.Controls) //For each Control in Table Layout Panel
                {
                    foreach (Control ctrl_sub_sub in ctrl_sub.Controls) //For each Control in Group Box
                    {
                        if (ctrl_sub_sub is TextBox)
                        {
                            (ctrl_sub_sub as TextBox).Text = string.Empty;
                        }
                        else if (ctrl_sub_sub is ComboBox)
                            (ctrl_sub_sub as ComboBox).SelectedIndex = 0;
                    }
                }
            }
        }

        /// <summary>
        /// Makes Company Update Panel Visible
        /// </summary>
        void Show_Company_Upt_Panel(bool visible)
        {
            groupBox_companyinfo_del.Visible = visible;
            groupBox_companyID.Visible = visible;
            groupBox_company_upt.Visible = visible;
        }

        private void Admin_MainTab_SelectedIndexChanged(object sender, EventArgs e)
        {

            Reset_TextBox();
        }

        #region TextBox Limitations KeypressEvent

        private void textbox_studentnumber_KeyPress(object sender, KeyPressEventArgs keypress)
        {
            if (!char.IsControl(keypress.KeyChar) && !char.IsDigit(keypress.KeyChar))
            {
                keypress.Handled = true;
            }
        }

        private void textbox_studentsurname_KeyPress(object sender, KeyPressEventArgs keypress)
        {
            if (!char.IsControl(keypress.KeyChar) && !char.IsLetter(keypress.KeyChar))
            {
                keypress.Handled = true;
            }
        }

        private void textbox_studentname_KeyPress(object sender, KeyPressEventArgs keypress)
        {
            if (!char.IsControl(keypress.KeyChar) && !char.IsLetter(keypress.KeyChar))
            {
                keypress.Handled = true;
            }
        }

        private void textbox_studentpassword_KeyPress(object sender, KeyPressEventArgs keypress)
        {
            if (!char.IsControl(keypress.KeyChar) && !char.IsLetterOrDigit(keypress.KeyChar))
            {
                keypress.Handled = true;
            }
        }

        #endregion
 
        

        #region Student Register

        //Register a new Student
        private void reg_student_Click(object sender, EventArgs e)  //Register Student
        {   
            #region Error Catch @ Student Register

            int i = 0;
            
            if (textbox_studentname.Text.Length == 0        ||
                textbox_studentsurname.Text.Length == 0     ||
                textbox_studentnumber.Text.Length == 0      ||
                textbox_studentpassword.Text.Length == 0    ||
                textbox_studentfaculty.Text.Length==0       ||
                textbox_studentmajor.Text.Length==0         )
            {
                MessageBox.Show("Please fill all the blankets.");
                return;
            }

            if (textbox_studentname.Text.Length < 2)
                i = 1;
            else if (textbox_studentsurname.Text.Length < 2)
                i = 2;
            else if (textbox_studentnumber.Text.Length < 9)
                i = 3;
            else if (textbox_studentpassword.Text.Length < 6)
                i = 4;

            switch (i)
            {
                default:
                    break;
                case 1:
                    {
                        MessageBox.Show("Please enter longer name (Minimum Length = 2)");
                   //     Delete_Text();
                        return;
                    }

                case 2:
                    {
                        MessageBox.Show("Please enter longer surname (Minimum Length = 2)");
                    //    Delete_Text();
                        return;
                    }
                case 3:
                    {
                        MessageBox.Show("Please enter a 9 digit number.");
                    //    Delete_Text();
                        return;
                    }
                case 4:
                    {
                        MessageBox.Show("Please enter longer password. (Minimum Length = 6)");
                    //    Delete_Text();
                        return;
                    }
            }

            i = 0;

            //Experimental: Maximum Limit of Integer
            if (Int32.TryParse(textbox_studentnumber.Text, out i) != true)
            {
                MessageBox.Show("Maximum number limit!!! (Maximum: 2147483647)");
            //    Delete_Text();
                i = 0;
                return;
            }

            #endregion

            //Storing inputs to Class
            AdminToStudent(stu);
           
           //Insert Registration Infos from Class to Database
            db.insert_toDatabase("students","studentId, studentPassword, studentName, studentGender, studentBirthday, " +
                                 "studentFaculty, studentMajor, studentSemester", stu.id_number+", '"+stu.password+"', '"+stu.name+"', '"+stu.gender+"', '" 
                                 +stu.dateofbirth.ToString("yyyy-MM-dd") + "', '"+stu.faculty+"', '"+stu.major+"', "+stu.semester);

        }

        #endregion

        #region Student Update: 1. Show Student - 2. Update Student - 3. Delete Student

        //1. Show Student Information
        private void button_studentshow_Click(object sender, EventArgs e)
        {
            string student_ID = textbox_studentnumber_show.Text;

            //From Database to Student Class
            DbToStudent(db,student_ID, stu);

            //Make the update panels visible
            Show_Student_Upt_Panel(true);

            //Show Student Info from Class to Labels
            Show_Student_Info(stu);

            //Bring Student Info from Class to Update Panel
            StudentToUpt(stu);

            

        }

        //2. Update Student Informations
        private void button_student_upt_Click(object sender, EventArgs e)
        {
            #region Error @ Student Update

            if (textbox_studentname_upt.Text.Length < 2)
            {
                MessageBox.Show("Please enter a longer name (Minimum Length = 2)");
                return;
            }
 //           elseif(textbox_studentfaculty_upt.Text.Length < 3)
            
            #endregion



            Student stu_upt = new Student();
            string student_ID = stu.id_number.ToString();

            //Bring new informations to the temporary Student Class
            UptToStudent(stu_upt);

            //Compare the updated infos from the temporary class with the current info
            Student_UptToDb(stu, stu_upt, db, student_ID);

            #region Db Update Codes (Commented)
            /*            db.update_toDatabase("students", "studentName", stu_upt.name, "studentId", student_ID);
                        db.update_toDatabase("students", "studentBirthday", stu_upt.dateofbirth.ToString("yyyy-MM-dd"), "studentId", student_ID);
                        db.update_toDatabase("students", "studentGender",  stu_upt.gender , "studentId", student_ID);
                        db.update_toDatabase("students", "studentFaculty",  stu_upt.faculty , "studentId", student_ID);
                        db.update_toDatabase("students", "studentMajor", stu_upt.major, "studentId", student_ID);
                        db.update_toDatabase("students", "studentSemester", stu_upt.semester.ToString(), "studentId", student_ID);
                        db.update_toDatabase("students", "studentPassword", stu_upt.password , "studentId", student_ID);
            */
            #endregion

            //Reset Show Student Info Labels
            Reset_Label_Stu_Upt();

            //Hide Student Update Panels
            Show_Student_Upt_Panel(false);

            //Reset the Textboxes
            Reset_TextBox();
        }

        //3. Delete Student
        private void button_student_del_Click(object sender, EventArgs e)
        {
            string student_ID = label_studentnumber_show.Text;

            //Warning Dialog
            DialogResult res = MessageBox.Show("Are you sure to delete this user?", "Warning", 
                                                MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning,
                                                MessageBoxDefaultButton.Button2
                                               );
            switch (res)
            {
                case DialogResult.Yes:
                    {
                        db.delete_fromDatabase("students", "studentId", student_ID);
                        break;
                    }
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    {
                        //Reset Show Student Info Labels
                        Reset_Label_Stu_Upt();

                        //Hide Student Update Panels
                        Show_Student_Upt_Panel(false);

                        //Reset the Textboxes
                        Reset_TextBox();
                        break;
                    } 
            }
        }

        #endregion

        #region Company Register

        private void button_company_reg_Click(object sender, EventArgs e)
        {
            #region Error Catch @ Company Register

            int i = 0;

            if (textbox_companyID.Text.Length == 0 ||
                textbox_companyname.Text.Length == 0 ||
                textbox_companypassword.Text.Length == 0)
            {
                MessageBox.Show("Please fill all the blankets.");
                return;
            }

            if (textbox_companyID.Text.Length < 6)
                i = 1;
            else if (textbox_companyname.Text.Length < 2)
                i = 2;
            else if (textbox_companypassword.Text.Length < 6)
                i = 3;


            switch (i)
            {
                default:
                    break;
                case 1:
                    {
                        MessageBox.Show("Please enter a 6 digit ID ");
                        return;
                    }

                case 2:
                    {
                        MessageBox.Show("Please enter longer name (Minimum Length = 2)");
                        return;
                    }
                case 3:
                    {
                        MessageBox.Show("Please enter longer password (Minimum Length = 6");
                        return;
                    }
            }

            i = 0;

            #endregion

            //Storing inputs to Class
            comp.id_number = Convert.ToInt32(textbox_companyID.Text);
            comp.name = textbox_companyname.Text;
            comp.password = textbox_companypassword.Text;

            //Insert Registration Infos from Class to Database
            db.insert_toDatabase("companies", "companyId, companyPassword, companyName",
                                comp.id_number + ", '" + comp.password + "', '" + comp.name + "'");

        }

        #endregion

        #region Firma Update: 1. Show Firma - 2. Update Firma - 3. Delete Firma

        private void button_company_show_Click(object sender, EventArgs e)
        {
            #region Error Catch @ Company Show

            if (textbox_company_show.Text.Length==0)
            {
                MessageBox.Show("Please enter a company ID");
                return;
            }
            else if (0 < textbox_company_show.Text.Length && textbox_company_show.Text.Length < 6)
            {
                MessageBox.Show("Please enter a 6 digit ID");
                return;
            }

            #endregion

            string company_ID = textbox_company_show.Text;

            //From Database to Student Class
            comp.id_number = Convert.ToInt32(db.select_fromDatabase("companyId", "companies", "companyId", company_ID));
            comp.name = db.select_fromDatabase("companyName", "companies", "companyId", company_ID);
            comp.password = db.select_fromDatabase("companyPassword", "companies", "companyId", company_ID);

            //Make the update panels visible
            Show_Company_Upt_Panel(true);

            //Show Student Info from Class to Labels
            label_companyID_show.Text = comp.id_number.ToString();
            label_companyname_show.Text = comp.name;

            //Bring Student Info from Class to Update Panel
            textbox_companyname_upt.Text = comp.name;
            
        }

        //2. Update Student Informations
        private void button_company_update_Click(object sender, EventArgs e)
        {
            #region Error Catch @ Company Update
            if (0 < textbox_companypassword_upt.Text.Length && textbox_companypassword_upt.Text.Length < 6)
            {
                MessageBox.Show("Please enter a longer password (Minimum Length = 6 )");
                return;
            }
           
            #endregion

            Company comp_upt = new Company();
            string company_ID = comp.id_number.ToString();

            //Bring new informations to Student Class &  //Update infos from Class to Database
            if (textbox_companyname_upt.Text.Length != 0)
            {
                comp_upt.name = textbox_companyname_upt.Text;
                if (comp_upt.name != comp.name)
                    db.update_toDatabase("companies", "companyName", comp_upt.name, "companyId", company_ID); 
            }
            if (textbox_companypassword_upt.Text.Length!=0)
            {
                comp_upt.password = textbox_companypassword_upt.Text;
                if (comp_upt.password != comp.password)
                db.update_toDatabase("companies", "companyPassword", comp_upt.password, "companyId", company_ID);
            }

            //Make Company Update Panels Invisible
            Show_Company_Upt_Panel(false);

            //Reset Company Info Show Labels
            label_companyID_show.Text = "Company ID";
            label_companyname_show.Text = "Name";

            Reset_TextBox();

        }


        //3. Delete Company
        private void button_company_del_Click(object sender, EventArgs e)
        {
            string company_ID =label_companyID_show.Text;

            DialogResult res = MessageBox.Show("Are you sure to delete this user?", "Warning",
                                               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning,
                                               MessageBoxDefaultButton.Button2
                                              );
            switch (res)
            {
                case DialogResult.Yes:
                    {
                        db.delete_fromDatabase("companies", "companyId", company_ID);

                        //Reset Company Info Show Labels
                        label_companyID_show.Text = "Company ID";
                        label_companyname_show.Text = "Name";

                        //Hide Student Update Panels
                        Show_Company_Upt_Panel(false);

                        //Reset the Textboxes
                        Reset_TextBox();
                        break;
                    }
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    {
                        //Reset Company Info Show Labels
                        label_companyID_show.Text = "Company ID";
                        label_companyname_show.Text = "Name";

                        //Hide Student Update Panels
                        Show_Company_Upt_Panel(false);

                        //Reset the Textboxes
                        Reset_TextBox();
                        break;
                    }
            }
        }




        #endregion
    }
}

