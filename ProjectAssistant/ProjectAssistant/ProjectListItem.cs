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
    public partial class ProjectListItem : UserControl
    {
        Project prj = new Project();
        DataBase db = new DataBase();
        string projectId;
        int pageDecider; // = 0 -> butonsuz
                         // = 1 -> appliable
                         // = 2 ? Bitir iptal et ?


        public ProjectListItem(string prjId, int pageDcd)
        {
            InitializeComponent();
            projectId = prjId;
            pageDecider = pageDcd;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label_projectDurationSign_Click(object sender, EventArgs e)
        {

        }

        private void ProjectListItem_Load(object sender, EventArgs e)
        {

        }

        private void label_projectStart_Click(object sender, EventArgs e)
        {

        }

        private void ProjectListItem_MouseHover(object sender, EventArgs e)
        {
        }

        private void richTextBox_projectTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectListItem_Click(object sender, EventArgs e)
        {
            LoadingPage loadPage = new LoadingPage();
            Form loading = new Form();
            loading.StartPosition = FormStartPosition.CenterScreen;
            loading.FormBorderStyle = FormBorderStyle.None;
            loading.TopMost = true;
            loading.Size = loadPage.Size;
            loading.Controls.Add(loadPage);
            loading.Show();
            Form projects = new Form();
            if(pageDecider == 1)
            {
                ProjectProfileAppliable projectWindow = new ProjectProfileAppliable(projectId);
                projects.Size = projectWindow.Size;
                projects.Controls.Add(projectWindow);
                loading.Close();
                projects.Show();
            }
            else if(pageDecider == 0)
            {
                ProjectProfileNotAppliable projectWindow = new ProjectProfileNotAppliable(projectId);
                projects.Size = projectWindow.Size;
                projects.Controls.Add(projectWindow);
                loading.Close();
                projects.Show();
            }
        }
    }
}
