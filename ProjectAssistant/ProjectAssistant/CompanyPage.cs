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
            for (int i = 0; i < 20; i++)
            {
                Label lbl = new Label();
                lbl.Text = "a-" + i;
                lbl.Location = new Point(18, 20);

                GroupBox grupbox = new GroupBox();
                
                if (i % 2 == 0)
                {
                    grupbox.Location = new Point(0, panelProject.Controls.Count * 60);
                    grupbox.Size = new Size(panelProject.Size.Width-20, 120);
                    grupbox.BackColor = SystemColors.ControlLightLight;
                    grupbox.Controls.Add(lbl);
                }
                else
                {
                    grupbox.Location = new Point(0, panelProject.Controls.Count * 60);
                    grupbox.Size = new Size(panelProject.Size.Width-20, 5);
                    grupbox.BackColor = SystemColors.Control;
                }
                panelProject.Controls.Add(grupbox);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CompanyPage_Load(object sender, EventArgs e)
        {

        }

        private void buttonStartproject_Click(object sender, EventArgs e)
        {
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

            int id = 11111;
            int cid = 11111;
            int pid = 22222;


            db.insert_toDatabase("projects", "projectId, companyId, projectTitle, projectDescription, projectArea, projectReqments, projectApplyDeadline, " 
                +"projectStartDate, projectEndDate", pid +", " + cid +", '" + project.title + "', '" + project.projectdesc + "', '" 
                + project.areaofinterest + "', '" + project.skills + "', '" + project.deadline.ToString("yyyy-MM-dd") + "', '" 
                + project.start.ToString("yyyy-MM-dd") + "', '" + project.end.ToString("yyyy-MM-dd")+ "'");





            db.update_toDatabase("projects", "projectTitle", project.title, "projectId", id.ToString());
            db.update_toDatabase("projects", "projectDescription", project.projectdesc, "projectId", id.ToString());
            db.update_toDatabase("projects", "projectArea", project.areaofinterest, "projectId", id.ToString());
            db.update_toDatabase("projects", "projectReqments", project.skills, "projectId", id.ToString());
            //db.update_toDatabase("projects", "projectApplydeadlines", project.deadline, "projectId", id.ToString());
            //db.update_toDatabase("projects", "projectStart", project.start, "projectId", id.ToString());
            //db.update_toDatabase("projects", "projectEnd", project.end, "projectId", id.ToString());
            // db.update_toDatabase("projects", "projectBranch", comp.description, "projectId", id.ToString());




        }

        private void panelProject_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comp.email = textBoxCompanyemail.Text;
            comp.mission = richTextBoxCompanymission.Text;
            comp.history = richTextBoxCompanyhis.Text;
            comp.description = richTextBoxCompanydec.Text;

            int id = 11111;
            db.update_toDatabase("companies", "companyDescription", comp.description, "companyId", id.ToString());
            db.update_toDatabase("companies", "companyEmail", comp.email, "companyId", id.ToString());
           
        }
    }
}
