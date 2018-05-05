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

        #region Student Register

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
        private void reg_student_Click(object sender, EventArgs e)  //Register Student
        {
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
            //Experimental: Out of Bit, will be removed
            if (Int32.TryParse(textbox_studentnumber.Text, out i) != true)
            {
                MessageBox.Show("Maximum number limit!!! (Maximum: 2147483647)");
                Delete_Text();
                i = 0;
                return;
            }

            //Creating a new Student Class to store inputs in order to send them to the Database
            Student stu = new Student();
            
            //Storing inputs to Class
            stu.name = textbox_studentname.Text +" "+ textbox_studentsurname.Text;
            stu.id_number = Convert.ToInt32(textbox_studentnumber.Text);
            stu.password = textbox_studentpassword.Text;
            stu.dateofbirth = date_student.Value;// ("yyyy-MM-dd");
            stu.gender = comboBox_studentgender.Text;
            stu.faculty = textbox_studentfaculty.Text;
            stu.major = textbox_studentmajor.Text;
            stu.semester = Convert.ToInt32(textbox_studentsemester.Text);

            db.insert_toDatabase("students","studentId, studentPassword, studentName, studentGender, studentBirthday, " +
                                 "studentFaculty, studentMajor, studentSemester", stu.id_number+", '"+stu.password+"', '"+stu.name+"', '"+stu.gender+"', '" 
                                 +stu.dateofbirth.ToString("yyyy-MM-dd") + "', '"+stu.faculty+"', '"+stu.major+"', "+stu.semester);

  /*        db.insert_toDatabase("students", "studentId", Convert.ToString(stu.id_number));
            db.insert_toDatabase("students", "studentPassword", stu.password);
            db.insert_toDatabase("students", "studentName", stu.name);
            db.insert_toDatabase("students", "studentGender", stu.gender);
            db.insert_toDatabase("students", "studentBirthday", stu.dateofbirth.ToString("yyyy-MM-dd"));
            db.insert_toDatabase("students", "studentFaculty", stu.faculty);
            db.insert_toDatabase("students", "studentMajor", stu.major);
*/
            //Just to Check, will be removed

            label_test2.Text = stu.name;
            label_test3.Text = Convert.ToString(stu.id_number);
            label_test4.Text = stu.password;
        }

        #endregion


        #region Student Update



        private void button_studentshow_Click(object sender, EventArgs e)
        {
            
        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            label_date.Text = date_student.Value.ToShortDateString();
        }
    }
}

