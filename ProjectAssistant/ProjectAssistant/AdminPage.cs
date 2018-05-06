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
        public AdminPage() //Start
        {
            InitializeComponent();

        }

        void Delete_Text()  //When changed to a Tab, delete all Text Boxes
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

        private void Admin_MainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get Selected Tab
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
/*
                        if (ctrl_sub_sub is Label)
                        {
                            if (ctrl_sub_sub==label_studentdate_show    ||
                                ctrl_sub_sub==label_studentfaculty_show ||
                                ctrl_sub_sub==label_studentgender_show  ||
                                ctrl_sub_sub==label_studentmajor_show   ||
                                ctrl_sub_sub==label_studentname_show    ||
                                ctrl_sub_sub==label_studentsemester_show    ||
                                ctrl_sub_sub==label_companyID_show      ||
                                ctrl_sub_sub==label_companyname_show
                                )
                                (ctrl_sub_sub as Label).Text = string.Empty;
                        }*/
                    }
                }
            /*
                if (ctrl is GroupBox)
                    if (ctrl == groupBox_student_upt ||
                        ctrl == groupBox_student_del ||
                        ctrl == groupBox_company_upt ||
                        ctrl == groupBox_firma_del)
                        ctrl.Visible = false;
                */
                // Other Controls....
            }
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
            #region Error Catch

            int i = 0;

            if (textbox_studentname.Text.Length == 0 ||
                textbox_studentsurname.Text.Length == 0 ||
                textbox_studentnumber.Text.Length == 0 ||
                textbox_studentpassword.Text.Length == 0)
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
                        Delete_Text();
                        return;
                    }

                case 2:
                    {
                        MessageBox.Show("Please enter longer surname (Minimum Length = 2)");
                        Delete_Text();
                        return;
                    }
                case 3:
                    {
                        MessageBox.Show("Please enter a 9 digit number.");
                        Delete_Text();
                        return;
                    }
                case 4:
                    {
                        MessageBox.Show("Please enter longer password. (Minimum Length = 6)");
                        Delete_Text();
                        return;
                    }
            }

            i = 0;

            //Experimental: Maximum Limit of Integer
            if (Int32.TryParse(textbox_studentnumber.Text, out i) != true)
            {
                MessageBox.Show("Maximum number limit!!! (Maximum: 2147483647)");
                Delete_Text();
                i = 0;
                return;
            }

            #endregion
            
            //Storing inputs to Class
            stu.name = textbox_studentname.Text +" "+ textbox_studentsurname.Text;
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

            //Insert Registration Infos from Class to Database
            db.insert_toDatabase("students","studentId, studentPassword, studentName, studentGender, studentBirthday, " +
                                 "studentFaculty, studentMajor, studentSemester", stu.id_number+", '"+stu.password+"', '"+stu.name+"', '"+stu.gender+"', '" 
                                 +stu.dateofbirth.ToString("yyyy-MM-dd") + "', '"+stu.faculty+"', '"+stu.major+"', "+stu.semester);

            //Just to Check, will be removed
            label_test2.Text = stu.name;
            label_test3.Text = Convert.ToString(stu.id_number);
            label_test4.Text = stu.password;
        }

        #endregion

        #region Student Update: 1. Show Student - 2. Update Student - 3. Delete Student

        //1. Show Student Information
        private void button_studentshow_Click(object sender, EventArgs e)
        {
            string student_ID = textbox_studentnumber_show.Text;
            
            //From Database to Student Class
            stu.id_number= Convert.ToInt32(db.select_fromDatabase("studentId", "students", "studentId", student_ID));
            stu.name=db.select_fromDatabase("studentName", "students", "studentId", student_ID);
            stu.dateofbirth= Convert.ToDateTime(db.select_fromDatabase("studentBirthday", "students", "studentId", student_ID));
            stu.gender=db.select_fromDatabase("studentGender", "students", "studentId", student_ID);
            stu.faculty = db.select_fromDatabase("studentFaculty", "students", "studentId", student_ID);
            stu.major= db.select_fromDatabase("studentMajor", "students", "studentId", student_ID);
            stu.semester = Convert.ToInt32(db.select_fromDatabase("studentSemester", "students", "studentId", student_ID));
            
            //Make the update panels visible
            groupBox_student_upt.Visible = true;
            groupBox_studentID_show.Visible = true;
            groupBox_studentinfo_del.Visible = true;

            //Show Student Info from Class to Labels
            label_studentnumber_show.Text = stu.id_number.ToString();
            label_studentname_show.Text = stu.name;
            label_studentdate_show.Text = stu.dateofbirth.ToString("dd.MM.yyyy");
            label_studentgender_show.Text = stu.gender;
            label_studentfaculty_show.Text = stu.faculty;
            label_studentmajor_show.Text = stu.major;
            label_studentsemester_show.Text = stu.semester.ToString();

            //Bring Student Info from Class to Update Panel
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

        //2. Update Student Informations
        private void button_student_upt_Click(object sender, EventArgs e)
        {
            Student stu_upt = new Student();
            string student_ID = label_studentnumber_show.Text;

            //Bring new informations to the temporary Student Class
            foreach (Control ctrl in Admin_MainTab.SelectedTab.Controls)
                foreach(Control ctrl_sub in ctrl.Controls)
                    foreach(Control ctrl_sub_sub in ctrl_sub.Controls)
                    {
                        if (ctrl_sub_sub is TextBox)
                        {
                            if((ctrl_sub_sub as TextBox).TextLength != 0)
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
                            
                        }
                            
                    }
//            stu_upt.name = textbox_studentname_upt.Text;
            stu_upt.dateofbirth = datepicker_student_upt.Value;
            if (radioButton_male_upt.Checked)
                stu_upt.gender = radioButton_male_upt.Text;
            else if (radioButton_female_upt.Checked)
                stu_upt.gender = radioButton_female_upt.Text;
 //           stu_upt.faculty = textbox_studentfaculty_upt.Text;
 //           stu_upt.major = textbox_studentmajor_upt.Text;
            stu_upt.semester = Convert.ToInt32(comboBox_studentsemester_upt.Text);
//            if(textbox_studentpassword_upt.Text.Length>0)
//                stu_upt.password = textbox_studentpassword_upt.Text;

            //Compare the updated infos from the temporary class with the current info
            if(stu.name!=stu_upt.name)
                db.update_toDatabase("students", "studentName", stu_upt.name, "studentId", student_ID);
            if(stu.dateofbirth!=stu_upt.dateofbirth)
                db.update_toDatabase("students", "studentBirthday", stu_upt.dateofbirth.ToString("yyyy-MM-dd"), "studentId", student_ID);
            if(stu.gender!=stu_upt.gender)
                db.update_toDatabase("students", "studentGender", stu_upt.gender, "studentId", student_ID);
            if(stu.faculty!=stu_upt.faculty)
                db.update_toDatabase("students", "studentFaculty", stu_upt.faculty, "studentId", student_ID);
            if(stu.major!=stu_upt.major)
                db.update_toDatabase("students", "studentMajor", stu_upt.major, "studentId", student_ID);
            if(stu.semester!=stu_upt.semester)
                db.update_toDatabase("students", "studentSemester", stu_upt.semester.ToString(), "studentId", student_ID);
            if(stu.password!=stu_upt.password)
                db.update_toDatabase("students", "studentPassword", stu_upt.password, "studentId", student_ID);

            /*            db.update_toDatabase("students", "studentName", stu_upt.name, "studentId", student_ID);
                        db.update_toDatabase("students", "studentBirthday", stu_upt.dateofbirth.ToString("yyyy-MM-dd"), "studentId", student_ID);
                        db.update_toDatabase("students", "studentGender",  stu_upt.gender , "studentId", student_ID);
                        db.update_toDatabase("students", "studentFaculty",  stu_upt.faculty , "studentId", student_ID);
                        db.update_toDatabase("students", "studentMajor", stu_upt.major, "studentId", student_ID);
                        db.update_toDatabase("students", "studentSemester", stu_upt.semester.ToString(), "studentId", student_ID);
                        db.update_toDatabase("students", "studentPassword", stu_upt.password , "studentId", student_ID);
            */
        }

        //3. Delete Student
        private void button_student_del_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Firma Register

        private void button_company_reg_Click(object sender, EventArgs e)
        {
            //Creating a new Student Class to store inputs in order to send them to the Database
            Company comp = new Company();

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
                Company comp = new Company();
                string company_ID = textbox_company_show.Text;

                //From Database to Student Class
                comp.id_number = Convert.ToInt32(db.select_fromDatabase("companyId", "companies", "companyId", company_ID));
                comp.name = db.select_fromDatabase("companyName", "companies", "companyId", company_ID);
                
                //Make the update panels visible
                groupBox_company_upt.Visible = true;
                groupBox_companyID.Visible = true;
                groupBox_companyinfo_del.Visible = true;

                //Show Student Info from Class to Labels
                label_companyID_show.Text = comp.id_number.ToString();
                label_companyname_show.Text = comp.name;

                //Bring Student Info from Class to Update Panel
                textbox_studentname_upt.Text = comp.name;
            
        }

        //2. Update Student Informations
        private void button_company_update_Click(object sender, EventArgs e)
        {
           
            Company comp = new Company();
            string company_ID = label_studentnumber_show.Text;

            //Bring new informations to Student Class
            comp.name = textbox_companyname_upt.Text;
            comp.password = textbox_companypassword_upt.Text;
       
            //Update infos from Class to Database
            db.update_toDatabase("companies", "companyName", "'" + comp.name + "'", "companyId", company_ID);
            db.update_toDatabase("companies", "companyPassword", "'"+ comp.password, "companyId", company_ID);

        }


        //3. Delete Company
        private void button_company_del_Click(object sender, EventArgs e)
        {

        }


        #endregion
    }
}

