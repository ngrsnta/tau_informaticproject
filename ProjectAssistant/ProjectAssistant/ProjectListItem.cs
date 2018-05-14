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
        StudentPage stPage;
        string projectId;
        string studentId;
        int pageDecider; // = 0 -> butonsuz
                         // = 1 -> appliable
                         // = 2 ? Bitir iptal et ?


        public ProjectListItem(string prjId, int pageDcd, string stuId, StudentPage _stPage)
        {
            InitializeComponent();
            projectId = prjId;
            studentId = stuId;
            pageDecider = pageDcd;
            stPage = _stPage;
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
                ProjectProfileAppliable projectWindow = new ProjectProfileAppliable(projectId, studentId, stPage);
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
