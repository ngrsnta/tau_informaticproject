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
    public partial class ProjectProfileNotAppliable : UserControl
    {
        string projectId, companyId;
        DataBase db = new DataBase();


        public ProjectProfileNotAppliable(string prjId)
        {
            InitializeComponent();
            projectId = prjId;

            Project prj = new Project();
            Company cmp = new Company();
            //acquiring info about project from the database
            prj.title = db.select_fromDatabase("projectTitle", "projects", "projectId", projectId);
            prj.areaofinterest = db.select_fromDatabase("projectArea", "projects", "projectId", projectId);
            prj.projectdesc = db.select_fromDatabase("projectDescription", "projects", "projectId", projectId);
            prj.skills = db.select_fromDatabase("projectReqments", "projects", "projectId", projectId);
            cmp.id_number = Convert.ToInt32(db.select_fromDatabase("companyId", "projects", "projectId", projectId));
            companyId = cmp.id_number.ToString();
            cmp.name = db.select_fromDatabase("companyName", "companies", "companyId", cmp.id_number.ToString());
            prj.deadline = Convert.ToDateTime(db.select_fromDatabase("projectApplydeadline", "projects", "projectId", projectId));
            //Writing info to the labels in list elements
            label_projectTitle.Text = prj.title;
            label_projectId.Text = projectId;
            label_projectArea.Text = prj.areaofinterest;
            richTextBox_projectDescription.Text = prj.projectdesc;
            richTextBox_projectRequirements.Text = prj.skills;
            richTextBox_companyName.Text = cmp.name;
            label_projectDeadline.Text = prj.deadline.ToShortDateString(); //CLASSTAN DATE TIME OLARAK DEĞİŞTİR
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form loading = new Form();
            LoadingPage loadPage = new LoadingPage();
            loading.StartPosition = FormStartPosition.CenterScreen;
            loading.FormBorderStyle = FormBorderStyle.None;
            loading.TopMost = true;
            loading.Size = loadPage.Size;
            loading.Controls.Add(loadPage);
            loading.Show();
            Form appliesWindow = new Form();
            AppliersListWindow alWindow = new AppliersListWindow();
            appliesWindow.Size = alWindow.Size;
            List<string> lst = new List<string>();

            lst = db.select_asArray("applies", "projectId", projectId, 0);

            for (int i = 0; i < lst.Count; i++)
            {
                Student st = new Student();
                //acquiring info about project from the database
                st.name = db.select_fromDatabase("studentName", "students", "studentId", lst[i]);
                st.semester = Convert.ToInt32(db.select_fromDatabase("studentSemester", "students", "studentId", lst[i]));
                st.major = db.select_fromDatabase("studentMajor", "students", "studentId", lst[i]);
                //Writing info to the labels in list elements
                StudentListItem slItem = new StudentListItem(companyId, projectId, lst[i]);
                slItem.labelName.Text = st.name;
                slItem.labelMajor.Text = st.major;
                slItem.labelSemester.Text = st.semester.ToString();
                slItem.Location = new Point(5, (i * 160) + 5);
                alWindow.Controls.Add(slItem);
                appliesWindow.Controls.Add(alWindow);
            }
            loading.Close();
            appliesWindow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form loading = new Form();
            LoadingPage loadPage = new LoadingPage();
            loading.StartPosition = FormStartPosition.CenterScreen;
            loading.FormBorderStyle = FormBorderStyle.None;
            loading.TopMost = true;
            loading.Size = loadPage.Size;
            loading.Controls.Add(loadPage);
            loading.Show();
            Form appliesWindow = new Form();
            AppliersListWindow alWindow = new AppliersListWindow();
            appliesWindow.Size = alWindow.Size;
            List<string> lst = new List<string>();

            lst = db.select_asArrayWithTwoElement("applies", "projectId", projectId, 0, "applyStatus", "Accepted");

            for (int i = 0; i < lst.Count; i++)
            {
                Student st = new Student();
                //acquiring info about project from the database
                st.name = db.select_fromDatabase("studentName", "students", "studentId", lst[i]);
                st.semester = Convert.ToInt32(db.select_fromDatabase("studentSemester", "students", "studentId", lst[i]));
                st.major = db.select_fromDatabase("studentMajor", "students", "studentId", lst[i]);
                //Writing info to the labels in list elements
                StudentListItem slItem = new StudentListItem(companyId, projectId, lst[i]);
                slItem.labelName.Text = st.name;
                slItem.labelMajor.Text = st.major;
                slItem.labelSemester.Text = st.semester.ToString();
                slItem.Location = new Point(5, (i * 160) + 5);
                alWindow.Controls.Add(slItem);
                appliesWindow.Controls.Add(alWindow);
            }
            loading.Close();
            appliesWindow.Show();

        }
    }
}
