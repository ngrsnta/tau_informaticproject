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
        public CompanyPage()
        {

            
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
            project.companybranchdec = richTextBoxCompanybranchdesicription.Text;
            project.deadline = dateTimePickerDeadline.Text;
            project.end = dateTimePickerProjectend.Text;
            project.start = dateTimePickerProjectstart.Text;
            project.projectdesc = richTextBoxProjectdescription.Text;
            project.skills = richTextBoxSkillRequirements.Text;
            


        }
    }
}
