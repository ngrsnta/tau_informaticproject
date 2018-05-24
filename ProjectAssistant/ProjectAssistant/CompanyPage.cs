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
    public partial class CompanyPage : UserControl
    {
        DataBase db = new DataBase();
        Company comp = new Company();

        public CompanyPage(Company _comp)
        {
            comp = _comp;
            
            InitializeComponent();
            getProjectList();

        }

        private void buttonStartproject_Click(object sender, EventArgs e)
        {
            Form loading = new Form();
            LoadingPage loadPage = new LoadingPage();
            loading.StartPosition = FormStartPosition.CenterScreen;
            loading.FormBorderStyle = FormBorderStyle.None;
            loading.TopMost = true;
            loading.Size = loadPage.Size;
            loading.Controls.Add(loadPage);
            loading.Show();
            Project project = new Project();
            Company company = new Company();
           
            if (textProjecttitle.Text == "" && richTextBoxProjectdescription.Text == "" && dateTimePickerDeadline.Text == "")
            {
                MessageBox.Show("You must enter information to the required areas");
                return;                
            }

            project.title = textProjecttitle.Text;
            project.areaofinterest = textBoxAreaofinterest.Text;
            project.deadline = dateTimePickerDeadline.Value;
            project.end = dateTimePickerProjectend.Value;
            project.start = dateTimePickerProjectstart.Value;
            project.projectdesc = richTextBoxProjectdescription.Text;
            project.skills = richTextBoxSkillRequirements.Text;
            project.branchdec = richTextBoxCompanybranchdesicription.Text;

            Random rnd = new Random();
            int pid = rnd.Next(100000, 999999);
            int cid = comp.id_number;


           db.insert_toDatabase("projects", "projectId, companyId, projectTitle, projectDescription, projectArea, projectReqments, projectApplyDeadline, " 
                +"projectStartDate, projectEndDate", pid +", " + cid +", '" + project.title + "', '" + project.projectdesc + "', '" 
                + project.areaofinterest + "', '" + project.skills + "', '" + project.deadline.ToString("yyyy-MM-dd") + "', '" 
                + project.start.ToString("yyyy-MM-dd") + "', '" + project.end.ToString("yyyy-MM-dd")+ "'");





            db.update_toDatabase("projects", "projectTitle", project.title, "projectId", pid.ToString());
            db.update_toDatabase("projects", "projectDescription", project.projectdesc, "projectId", pid.ToString());
            db.update_toDatabase("projects", "projectArea", project.areaofinterest, "projectId", pid.ToString());
            db.update_toDatabase("projects", "projectReqments", project.skills, "projectId", pid.ToString());
            db.update_toDatabase("projects", "projectApplydeadline", project.deadline.ToString(), "projectId", pid.ToString());
            db.update_toDatabase("projects", "projectStart", project.start.ToString(), "projectId", pid.ToString());
            db.update_toDatabase("projects", "projectEnd", project.end.ToString(), "projectId", pid.ToString());
            db.update_toDatabase("projects", "projectBranch", comp.description, "projectId", pid.ToString());

            getProjectList();
            loading.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comp.email = textBoxCompanyemail.Text;
            comp.mission = richTextBoxCompanymission.Text;
            comp.history = richTextBoxCompanyhis.Text;
            comp.description = richTextBoxCompanydec.Text;

            int id = comp.id_number;
            db.update_toDatabase("companies", "companyDescription", comp.description, "companyId", id.ToString());
            db.update_toDatabase("companies", "companyEmail", comp.email, "companyId", id.ToString());
           
        }

        private void getProjectList()
        {
            tabProjectpage.Controls.Clear();
            List<string> _lst = new List<string>();
            _lst = db.select_ItemasArray("projects", "companyId", comp.id_number.ToString());
            for (int i = 0; i<_lst.Count; i++)
            {
                Student st = new Student();
                StudentPage stPage = new StudentPage(st, 0);
                ProjectListItem projectList = new ProjectListItem(_lst[i], 0,"130501105", stPage);
                Project prj = new Project();
                Company cmp = new Company();
                //acquiring info about project from the database
                prj.title = db.select_fromDatabase("projectTitle", "projects", "projectId", _lst[i]);
                prj.areaofinterest = db.select_fromDatabase("projectArea", "projects", "projectId", _lst[i]);
                prj.projectdesc = db.select_fromDatabase("projectDescription", "projects", "projectId", _lst[i]);
                cmp.id_number = Convert.ToInt32(db.select_fromDatabase("companyId", "projects", "projectId", _lst[i]));
                cmp.name = db.select_fromDatabase("companyName", "companies", "companyId", cmp.id_number.ToString());
                prj.deadline = Convert.ToDateTime(db.select_fromDatabase("projectApplydeadline", "projects", "projectId", _lst[i]));
                //Writing info to the labels in list elements
                projectList.richTextBox_projectTitle.Text = prj.title;
                projectList.richTextBox_projectArea.Text = prj.areaofinterest;
                projectList.richTextBox_description.Text = prj.projectdesc;
                projectList.richTextBox_companyName.Text = cmp.name;
                projectList.richTextBox_projectDeadline.Text = prj.deadline.ToShortDateString();
                projectList.Location = new Point(5, (i* 160) + 5);
                projectList.BackColor = SystemColors.Control;
                tabProjectpage.Controls.Add(projectList);
            }
        }
        
    }
}
