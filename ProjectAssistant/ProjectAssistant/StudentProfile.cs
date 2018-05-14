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
    public partial class StudentProfile: UserControl
    {
        Student st = new Student();
        DataBase db = new DataBase();

        public StudentProfile(Student _st)
        {
            st = _st;

            InitializeComponent();
            getStudentInfo();
            printStudentInfo();
        }
        private void printStudentInfo()
        {
            label_studName.Text = st.name;
            label_studBirthday.Text = st.dateofbirth.ToShortDateString();
            label_studFaculty.Text = st.faculty;
            label_studSemester.Text = st.semester.ToString();
            label_studId.Text = st.id_number.ToString();
            label_studGender.Text = st.gender;
            label_studMajor.Text = st.major;
            label_studTelNum.Text = st.phone;
            label_studEmail.Text = st.email;
            richTextBox_studAdress.Text = st.adress;
            richTextBox_edu.Text = st.education;
            richTextBox_studExperience.Text = st.experience;
            richTextBox_studCertificates.Text = st.certificates;
            richTextBox_studActivities.Text = st.hobbies;
            richTextBox_studProjects.Text = st.projects;
            richTextBox_studProfessions.Text = st.professions;
            richTextBox_studFurtherInfo.Text = st.other;
        }
        private void getStudentInfo()
        {
            st.name = db.select_fromDatabase("studentName", "students", "studentId", st.id_number.ToString());
            st.dateofbirth = Convert.ToDateTime(db.select_fromDatabase("studentBirthday", "students", "studentId", st.id_number.ToString()));
            st.faculty = db.select_fromDatabase("studentFaculty", "students", "studentId", st.id_number.ToString());
            st.semester = Convert.ToInt32(db.select_fromDatabase("studentSemester", "students", "studentId", st.id_number.ToString()));
            st.id_number = Convert.ToInt32(db.select_fromDatabase("studentId", "students", "studentId", st.id_number.ToString()));
            st.gender = db.select_fromDatabase("studentGender", "students", "studentId", st.id_number.ToString());
            st.major = db.select_fromDatabase("studentMajor", "students", "studentId", st.id_number.ToString());
            st.phone = db.select_fromDatabase("studentTelNum", "students", "studentId", st.id_number.ToString());
            st.email = db.select_fromDatabase("studentEmail", "students", "studentId", st.id_number.ToString());
            st.adress = db.select_fromDatabase("studentAdress", "students", "studentId", st.id_number.ToString());
            st.education = db.select_fromDatabase("studentHistory", "students", "studentId", st.id_number.ToString());
            st.experience = db.select_fromDatabase("studentExprience", "students", "studentId", st.id_number.ToString());
            st.certificates = db.select_fromDatabase("studentCertifcates", "students", "studentId", st.id_number.ToString());
            st.hobbies = db.select_fromDatabase("studentActivities", "students", "studentId", st.id_number.ToString());
            st.projects = db.select_fromDatabase("studentProjects", "students", "studentId", st.id_number.ToString());
            st.professions = db.select_fromDatabase("studentProfessions", "students", "studentId", st.id_number.ToString());
            st.other = db.select_fromDatabase("studentOther", "students", "studentId", st.id_number.ToString());
        }

    }
}
