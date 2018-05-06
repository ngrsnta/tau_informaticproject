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
        int id = 123; //Kaan id'yi yollayacak buraya, bu sadece geçici

        public StudentPage()
        {
            
 

            InitializeComponent();
            //Getting info From Database
            st.name = db.select_fromDatabase("studentName", "students", "studentId", id.ToString());
            st.dateofbirth = Convert.ToDateTime(db.select_fromDatabase("studentBirthday", "students", "studentId", id.ToString()));
            st.faculty = db.select_fromDatabase("studentFaculty", "students", "studentId", id.ToString());
            st.semester = Convert.ToInt32(db.select_fromDatabase("studentSemester", "students", "studentId", id.ToString()));
            st.id_number = Convert.ToInt32(db.select_fromDatabase("studentId", "students", "studentId", id.ToString()));
            st.gender = db.select_fromDatabase("studentGender", "students", "studentId", id.ToString());
            st.major = db.select_fromDatabase("studentMajor", "students", "studentId", id.ToString());
            st.phone = db.select_fromDatabase("studentTelNum", "students", "studentId", id.ToString());
            st.email = db.select_fromDatabase("studentEmail", "students", "studentId", id.ToString());
            st.adress = db.select_fromDatabase("studentAdress", "students", "studentId", id.ToString());
            st.education = db.select_fromDatabase("studentHistory","students", "studentId", id.ToString());
            st.experience = db.select_fromDatabase("studentExprience", "students", "studentId", id.ToString());
            st.certificates = db.select_fromDatabase("studentCertifcates", "students", "studentId", id.ToString());
            st.hobbies = db.select_fromDatabase("studentActivities", "students", "studentId", id.ToString());
            st.projects = db.select_fromDatabase("studentProjects", "students", "studentId", id.ToString());
            st.professions = db.select_fromDatabase("studentProfessions", "students", "studentId", id.ToString());
            st.other = db.select_fromDatabase("studentOther", "students", "studentId", id.ToString());
            
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

            List<string> lst = new List<string>();

            lst = db.select_asArray("applies", "studentId", "111111111");

            for (int i = 0; i < lst.Count; i++)
            {
                ProjectListItem projectList = new ProjectListItem();
                Project prj = new Project();

                prj.title = db.select_fromDatabase("projectTitle", "projects", "projectId", lst[i]);
                projectList.richTextBox_projectTitle.Text = prj.title;
                projectList.Location = new Point(5, (i * 160)+5);
                projectList.BackColor = SystemColors.Control;
                studPage_projects.Controls.Add(projectList);
            }


        }

        private void textBox_studPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        

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

        public void button1_Click(object sender, EventArgs e)
        {
            Form Profile = new Form();
            StudentProfile studentProfile = new StudentProfile();
            Label exitLabel = new Label();
            exitLabel.Text = "Close";
            exitLabel.Font = new Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            exitLabel.Location = new Point(1060, 15);
            exitLabel.Click += new EventHandler(this.exitLabel_Click);
            exitLabel.Cursor = Cursors.Hand;
            exitLabel.Size = new Size(new Point(45, 20));
            //Profile.FormBorderStyle = FormBorderStyle.None;
            Profile.Size = studentProfile.Size;
            Profile.Controls.Add(studentProfile);
            Profile.Controls.Add(exitLabel);
            exitLabel.BringToFront();
            Profile.Show();
        }
        private void exitLabel_Click(object sender, EventArgs e)
        {
            //Profile.Close();
        }

        private void label_studName_Click(object sender, EventArgs e)
        {

        }

        private void studPage_projects_Click(object sender, EventArgs e)
        {

        }

        private void button_SaveChanges_Click(object sender, EventArgs e)
        {
            db.update_toDatabase("students", "studentTelnum", textBox_studPhoneNumber.Text, "studentId", id.ToString());
            
        }
    }
}
