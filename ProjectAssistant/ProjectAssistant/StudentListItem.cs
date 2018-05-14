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
    public partial class StudentListItem : UserControl
    {
        string companyId, projectId, studentId;
        public StudentListItem(string compId, string prjId, string stuId)
        {
            InitializeComponent();
            companyId = compId;
            projectId = prjId;
            studentId = stuId;
        }

        private void StudentListItem_Click(object sender, EventArgs e)
        {
            Form loading = new Form();
            LoadingPage loadPage = new LoadingPage();
            loading.StartPosition = FormStartPosition.CenterScreen;
            loading.FormBorderStyle = FormBorderStyle.None;
            loading.TopMost = true;
            loading.Size = loadPage.Size;
            loading.Controls.Add(loadPage);
            loading.Show();
            Form stuProfileWindow = new Form();
            StudentProfileforCompanies spComp = new StudentProfileforCompanies(companyId,projectId,studentId);
            stuProfileWindow.Size = spComp.Size;
            stuProfileWindow.Controls.Add(spComp);
            loading.Close();
            stuProfileWindow.Show();
        }
    }
}
