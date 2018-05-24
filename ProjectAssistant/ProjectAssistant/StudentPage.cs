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
    public partial class StudentPage : UserControl
    {
        Student st = new Student();
        DataBase db = new DataBase();

        public StudentPage(Student _st, int flag)
        {
            InitializeComponent();
            if(flag == 1)
            {
                st = _st;
                getStudentInfo();
                printInfosToPage();
                getAppliesList();
                getProjectsList();
            }
            else
            {
                return;
            }
        }

        private void textBox_studPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        #region MouseHover Functions
        private void richTextBox_studEducation_MouseHover(object sender, EventArgs e)
        {
            ToolTip tltip = new ToolTip();
            tltip.SetToolTip(this.richTextBox_studEducation, "Kadıköy Anatolian High School (2010-2014)");
            
        }

        private void richTextBox_studWork_MouseHover(object sender, EventArgs e)
        {
            ToolTip tltip = new ToolTip();
            tltip.SetToolTip(this.richTextBox_studWork, "Intern at Mercedes Benz Türk A.Ş (07.2015-08.2015)");
        }

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tltip = new ToolTip();
            tltip.SetToolTip(this.richTextBox_studCertificates, "DSH C1 Certificate(06.2015)");
        }

        private void richTextBox_studCurricular_MouseHover(object sender, EventArgs e)
        {
            ToolTip tltip = new ToolTip();
            tltip.SetToolTip(this.richTextBox_studCurricular, "Guitar, Working at the Orphanage...");
        }

        private void richTextBox_studProjects_MouseHover(object sender, EventArgs e)
        {
            ToolTip tltip = new ToolTip();
            tltip.SetToolTip(this.richTextBox_studProjects, "EEG Project (06.2017-08.2017) Controlling a Robot Arm with Brain Signals, " +
                "\nInnovation an der TDU 02.2017-06.2017 Creating a smart University by implementing smart surveillance systems, ...");
        }

        private void richTextBox_studProfessions_MouseHover(object sender, EventArgs e)
        {
            ToolTip tltip = new ToolTip();
            tltip.SetToolTip(this.richTextBox_studProfessions, "C++ Intermediate, Python Beginner,...");
        }

        private void richTextBox_studFurtherInfo_MouseHover(object sender, EventArgs e)
        {
            ToolTip tltip = new ToolTip();
            tltip.SetToolTip(this.richTextBox_studFurtherInfo, "I have also tried to improve myself in In-Team Communication, improving my teams success in projects, ... and so on");
        }
        #endregion

        public void button1_Click(object sender, EventArgs e)
        {
            Form loading = new Form();
            LoadingPage loadPage = new LoadingPage();
            loading.StartPosition = FormStartPosition.CenterScreen;
            loading.FormBorderStyle = FormBorderStyle.None;
            loading.Size = loadPage.Size;
            loading.Controls.Add(loadPage);
            loading.Show();
            Form Profile = new Form();
            StudentProfile studentProfile = new StudentProfile(st);
            Profile.Size = studentProfile.Size;
            Profile.Controls.Add(studentProfile);
            Profile.Show();
            loading.Close();
        }

        private void button_SaveChanges_Click(object sender, EventArgs e)
        {
            Form loading = new Form();
            LoadingPage loadPage = new LoadingPage();
            loading.StartPosition = FormStartPosition.CenterScreen;
            loading.FormBorderStyle = FormBorderStyle.None;
            loading.TopMost = true;
            loading.Size = loadPage.Size;
            loading.Controls.Add(loadPage);
            loading.Show();
            updateStudentInfo();
            loading.Close();
        }
        private void updateStudentInfo()
        {
            db.update_toDatabase("students", "studentTelnum", textBox_studPhoneNumber.Text, "studentId", st.id_number.ToString());
            db.update_toDatabase("students", "studentEmail", textBox_studMail.Text, "studentId", st.id_number.ToString());
            db.update_toDatabase("students", "studentAdress", richTextBox_studAdress.Text, "studentId", st.id_number.ToString());
            db.update_toDatabase("students", "studentHistory", richTextBox_studEducation.Text, "studentId", st.id_number.ToString());
            db.update_toDatabase("students", "studentExprience", richTextBox_studWork.Text, "studentId", st.id_number.ToString());
            db.update_toDatabase("students", "studentCertifcates", richTextBox_studCertificates.Text, "studentId", st.id_number.ToString());
            db.update_toDatabase("students", "studentActivities", richTextBox_studCurricular.Text, "studentId", st.id_number.ToString());
            db.update_toDatabase("students", "studentProjects", richTextBox_studProjects.Text, "studentId", st.id_number.ToString());
            db.update_toDatabase("students", "studentProfessions", richTextBox_studProfessions.Text, "studentId", st.id_number.ToString());
            db.update_toDatabase("students", "studentOther", richTextBox_studFurtherInfo.Text, "studentId", st.id_number.ToString());
        }
        private void getStudentInfo()
        {
            //Getting info From Database
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

        private void printInfosToPage()
        {
            //Printing info to the Labels
            label_studName.Text = st.name;
            label_studDateOfBirth.Text = st.dateofbirth.ToShortDateString();
            label_studFaculty.Text = st.faculty;
            label_studSemester.Text = st.semester.ToString();
            label_studID.Text = st.id_number.ToString();
            label_studGender.Text = st.gender;
            label_studMajor.Text = st.major;
            textBox_studPhoneNumber.Text = st.phone;
            textBox_studMail.Text = st.email;
            richTextBox_studAdress.Text = st.adress;
            richTextBox_studEducation.Text = st.education;
            richTextBox_studWork.Text = st.experience;
            richTextBox_studCertificates.Text = st.certificates;
            richTextBox_studCurricular.Text = st.hobbies;
            richTextBox_studProjects.Text = st.projects;
            richTextBox_studProfessions.Text = st.professions;
            richTextBox_studFurtherInfo.Text = st.other;
        }

        public void getAppliesList()
        {
            List<string> lst = new List<string>();

            lst = db.select_asArray("applies", "studentId", st.id_number.ToString(), 1);

            for (int i = 0; i < lst.Count; i++)
            {
                ProjectListItem projectList = new ProjectListItem(lst[i], 0, st.id_number.ToString(), this);
                Project prj = new Project();
                Company cmp = new Company();
                Label lbl = new Label();
                Label lbl2 = new Label();
                lbl.Text = "Application Status";
                lbl.Location = new Point(640, 60);
                lbl2.Location = new Point(665, 80);
                
                projectList.Controls.Add(lbl);
                
                //acquiring info about project from the database
                prj.title = db.select_fromDatabase("projectTitle", "projects", "projectId", lst[i]);
                prj.areaofinterest = db.select_fromDatabase("projectArea", "projects", "projectId", lst[i]);
                prj.projectdesc = db.select_fromDatabase("projectDescription", "projects", "projectId", lst[i]);
                cmp.id_number = Convert.ToInt32(db.select_fromDatabase("companyId", "projects", "projectId", lst[i]));
                cmp.name = db.select_fromDatabase("companyName", "companies", "companyId", cmp.id_number.ToString());
                lbl2.Text = db.select_fromDatabaseTwoElement("applyStatus", "applies", "projectId", lst[i], "studentId", st.id_number.ToString());
                projectList.Controls.Add(lbl2);
                prj.deadline = Convert.ToDateTime(db.select_fromDatabase("projectApplydeadline", "projects", "projectId", lst[i]));
                //Writing info to the labels in list elements
                projectList.richTextBox_projectTitle.Text = prj.title;
                projectList.richTextBox_projectArea.Text = prj.areaofinterest;
                projectList.richTextBox_description.Text = prj.projectdesc;
                projectList.richTextBox_companyName.Text = cmp.name;
                projectList.richTextBox_projectDeadline.Text = prj.deadline.ToShortDateString();
                projectList.Location = new Point(5, (i * 160) + 5);
                projectList.BackColor = SystemColors.Control;
                studPage_applications.Controls.Add(projectList);
            }
        }

        private void getProjectsList()
        {
            List<string> _lst = new List<string>();
            _lst = db.select_AllasArray("projects");
            for (int i = 0; i < _lst.Count; i++)
            {
                ProjectListItem projectList = new ProjectListItem(_lst[i], 1, st.id_number.ToString(), this);
                
                Project prj = new Project();
                Company cmp = new Company();
                //acquiring info about project from the database
                prj.title = db.select_fromDatabase("projectTitle", "projects", "projectId", _lst[i]);
                prj.areaofinterest = db.select_fromDatabase("projectArea", "projects", "projectId", _lst[i]);
                prj.projectdesc = db.select_fromDatabase("projectDescription", "projects", "projectId", _lst[i]);
                cmp.id_number = Convert.ToInt32(db.select_fromDatabase("companyId", "projects", "projectId", _lst[i]));
                cmp.name = db.select_fromDatabase("companyName", "companies", "companyId", cmp.id_number.ToString());
                prj.deadline = Convert.ToDateTime(db.select_fromDatabase("projectDeadline", "projects", "projectId", _lst[i]));
                //Writing info to the labels in list elements
                projectList.richTextBox_projectTitle.Text = prj.title;
                projectList.richTextBox_projectArea.Text = prj.areaofinterest;
                projectList.richTextBox_description.Text = prj.projectdesc;
                projectList.richTextBox_companyName.Text = cmp.name;
                projectList.richTextBox_projectDeadline.Text = prj.deadline.ToShortDateString();
                projectList.Location = new Point(5, (i * 160) + 5);
                projectList.BackColor = SystemColors.Control;
                studPage_projects.Controls.Add(projectList);
            }
        }
    }
}
