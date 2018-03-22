using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAssistant
{
    public partial class Form1 : Form
    {
        Student student = new Student();
        LoginPage loginPage = new LoginPage();
        StudentPage studentPage = new StudentPage();
        AdminPage adminPage = new AdminPage();
        CompanyPage companyPage = new CompanyPage();

        public Form1()
        {
            InitializeComponent();
        }
        

        private void loginPageButton_Click(object sender, EventArgs e)
        {
            formsPanel.Controls.Clear();
            formsPanel.Controls.Add(loginPage);
            headerLabel.Text = "Login";
        }

        private void adminPageButton_Click(object sender, EventArgs e)
        {
            formsPanel.Controls.Clear();
            formsPanel.Controls.Add(adminPage);
            headerLabel.Text = "Admin";

        }

        private void studentPageButton_Click(object sender, EventArgs e)
        {
            formsPanel.Controls.Clear();
            formsPanel.Controls.Add(studentPage);
            headerLabel.Text = "Student";
        }

        private void companyPageButton_Click(object sender, EventArgs e)
        {
            formsPanel.Controls.Clear();
            formsPanel.Controls.Add(companyPage);
            headerLabel.Text = "Company";
        }
    }
}
