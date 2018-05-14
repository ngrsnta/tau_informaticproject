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
    public partial class ProjectProfileAppliable : UserControl
    {
        string projectId;
        string studentId;
        StudentPage stPage;
        DataBase db = new DataBase();

        public ProjectProfileAppliable(string prjId, string stuId, StudentPage _stPage)
        {
            InitializeComponent();
            projectId = prjId;
            studentId = stuId;
            stPage = _stPage;

            Project prj = new Project();
            Company cmp = new Company();
            //acquiring info about project from the database
            prj.title = db.select_fromDatabase("projectTitle", "projects", "projectId", projectId);
            prj.areaofinterest = db.select_fromDatabase("projectArea", "projects", "projectId", projectId);
            prj.projectdesc = db.select_fromDatabase("projectDescription", "projects", "projectId", projectId);
            cmp.id_number = Convert.ToInt32(db.select_fromDatabase("companyId", "projects", "projectId", projectId));
            cmp.name = db.select_fromDatabase("companyName", "companies", "companyId", cmp.id_number.ToString());
            //prj.deadline = Convert.ToDateTime(db.select_fromDatabase("projectDeadline", "projects", "projectId", projectId));
            //Writing info to the labels in list elements
            label_projectTitle.Text = prj.title;
            label_projectId.Text = projectId;
            label_projectArea.Text = prj.areaofinterest;
            richTextBox_projectDescription.Text = prj.projectdesc;
            richTextBox_companyName.Text = cmp.name;
            //label_projectDeadline.Text = prj.deadline.ToShortDateString(); //CLASSTAN DATE TIME OLARAK DEĞİŞTİR
            //
        }
        private void button_projectApply_Click(object sender, EventArgs e)
        {
            LoadingPage loadPage = new LoadingPage();
            Form loading = new Form();
            loading.StartPosition = FormStartPosition.CenterScreen;
            loading.FormBorderStyle = FormBorderStyle.None;
            loading.TopMost = true;
            loading.Size = loadPage.Size;
            loading.Controls.Add(loadPage);
            loading.Show();
            db.insert_toDatabase("applies", "projectId, studentId, applyStatus", projectId + ", " + studentId+", Ongoing");
            loading.Close();
        }
    }
}
