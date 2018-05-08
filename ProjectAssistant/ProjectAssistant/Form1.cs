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
        Company company = new Company();
        LoginPage loginPage = new LoginPage();
        AdminPage adminPage = new AdminPage();
        LoginInfos loginInfo = new LoginInfos();
        LoadingPage loadPage = new LoadingPage();
        DataBase db = new DataBase();

        bool homeDragging;
        Point homeStartpoint;
        string _password;


        public Form1()
        {
            InitializeComponent();
            formsPanel.Controls.Add(loginPage);
            loginPage.loginIdTextBox.MaxLength = 9;
            loginPage.loginButton.Click += loginPage_loginButton_Click;
        }
        

        private void loginPageButton_Click(object sender, EventArgs e)
        {
            formsPanel.Controls.Clear();
            formsPanel.Controls.Add(loginPage);
            headerLabel.Text = "Login";
        }
        private void loginPage_loginButton_Click(object sender, EventArgs e)
        {
            Form loading = new Form();
            loading.StartPosition = FormStartPosition.CenterScreen;
            loading.FormBorderStyle = FormBorderStyle.None;
            loading.TopMost = true;
            loading.Size = loadPage.Size;
            loading.Controls.Add(loadPage);
            loading.Show();

            try
            {
                loginInfo.set_loginId(Convert.ToInt32(loginPage.loginIdTextBox.Text));
            }

            catch (FormatException)
            {
                MessageBox.Show("Login Id can only contain numbers");
                return;
            }

            loginInfo.set_password(loginPage.passwordTextBox.Text);
            if (loginInfo.get_loginId() > 100000000)
            {
                _password = db.select_fromDatabase("studentPassword", "students", "studentId", loginInfo.get_loginId().ToString());
                if (loginInfo.get_password() == _password)
                {
                    student.id_number = loginInfo.get_loginId();
                    StudentPage studentPage = new StudentPage(student);
                    formsPanel.Controls.Clear();
                    formsPanel.Controls.Add(studentPage);
                    headerLabel.Text = "Student";
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                    loginPage.loginIdTextBox.Clear();
                    loginPage.passwordTextBox.Clear();
                    return;

                }
            }
            else if(loginInfo.get_loginId() < 100000000 && loginInfo.get_loginId() > 10000)
            {
                _password = db.select_fromDatabase("companyPassword", "companies", "companyId", loginInfo.get_loginId().ToString());
                if (loginInfo.get_password() == _password)
                {
                    company.id_number = loginInfo.get_loginId();
                    CompanyPage companyPage = new CompanyPage(company);
                    formsPanel.Controls.Clear();
                    formsPanel.Controls.Add(companyPage);
                    headerLabel.Text = "Company";
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                    loginPage.loginIdTextBox.Clear();
                    loginPage.passwordTextBox.Clear();
                    return;

                }
            }
            else if (loginInfo.get_loginId() == 9876)
            {
                _password = "9876";
                if (loginInfo.get_password() == _password)
                {
                    formsPanel.Controls.Clear();
                    formsPanel.Controls.Add(adminPage);
                    headerLabel.Text = "Admin";
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                    loginPage.loginIdTextBox.Clear();
                    loginPage.passwordTextBox.Clear();
                    return;

                }
            }
            loading.Close();
        }

        private void adminPageButton_Click(object sender, EventArgs e)
        {
            formsPanel.Controls.Clear();
            formsPanel.Controls.Add(adminPage);
            headerLabel.Text = "Admin";

        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void home_MouseDown(object sender, MouseEventArgs e)
        {
            homeDragging = true;
            homeStartpoint = new Point(e.X, e.Y);
        }
        private void home_MouseUp(object sender, MouseEventArgs e)
        {
            homeDragging = false;
        }
        private void home_MouseMove(object sender, MouseEventArgs e)
        {
            if (homeDragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.homeStartpoint.X, p.Y - this.homeStartpoint.Y);
            }
        }
    }
}
