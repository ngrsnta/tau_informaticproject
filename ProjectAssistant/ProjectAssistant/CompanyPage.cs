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
            project.companydesc = richTextBoxCompanydesicription.Text;
            project.deadline = dateTimePickerDeadline.Text;
            project.end = dateTimePickerProjectend.Text;
            project.start = dateTimePickerProjectstart.Text;
            project.projectdesc = richTextBoxProjectdescription.Text;
            project.skills = richTextBoxSkillRequirements.Text;


        }
    }
}
