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
    public partial class StudentProfileforCompanies : UserControl
    {
        Student st = new Student();
        DataBase db = new DataBase();
        string companyId, projectId;

        public StudentProfileforCompanies(string compId, string prjId, string stuId)
        {
            InitializeComponent();
            st.id_number = Convert.ToInt32(stuId);
            companyId = compId;
            projectId = prjId;
            getStudentInfo();
            printStudentInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //apply accept
            db.update_ApplytoDatabase("Accepted", projectId, st.id_number.ToString());
            MessageBox.Show("Done!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //decline
            db.update_ApplytoDatabase("Declined", projectId, st.id_number.ToString());
            MessageBox.Show("Done!");
        }

        private void printStudentInfo()
        {
            label_studNameCompany.Text = st.name;
            label_studBirthdayCompany.Text = st.dateofbirth.ToShortDateString();
            label_studFacultyCompany.Text = st.faculty;
            label_studSemesterCompany.Text = st.semester.ToString();
            label_studIdCompany.Text = st.id_number.ToString();
            label_studGenderCompany.Text = st.gender;
            label_studMajorCompany.Text = st.major;
            label_studentTelNumCompany.Text = st.phone;
            label_studEmailCompany.Text = st.email;
            richTextBox_studAdressCompany.Text = st.adress;
            richTextBox_studEducationCompany.Text = st.education;
            richTextBox_studExperienceCompany.Text = st.experience;
            richTextBoxstudCertificatesCompany.Text = st.certificates;
            richTextBox_studActivitiesCompany.Text = st.hobbies;
            richTextBox_studProjectsCompany.Text = st.projects;
            richTextBox_studProfessionsCompany.Text = st.professions;
            richTextBox_studOtherCompany.Text = st.other;
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
