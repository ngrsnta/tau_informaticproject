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
        //sol panele signout butonu koyulacak
        LoginPage loginPage = new LoginPage();
        LoginInfos loginInfo = new LoginInfos();
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
            loginPage.passwordTextBox.KeyPress += loginPage_passwordTextBox_KeyPress;
        }
        

        private void loginPageButton_Click(object sender, EventArgs e)
        {
            formsPanel.Controls.Clear();
            formsPanel.Controls.Add(loginPage);
            headerLabel.Text = "Login";
        }
        private void loginPage_loginButton_Click(object sender, EventArgs e)
        {

            LoadingPage loadPage = new LoadingPage();
            Form loading = new Form();
            loading.StartPosition = FormStartPosition.CenterScreen;
            loading.FormBorderStyle = FormBorderStyle.None;
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

                Student student = new Student();
                if (loginInfo.get_password() == _password)
                {
                    student.id_number = loginInfo.get_loginId();
                    StudentPage studentPage = new StudentPage(student, 1);
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

                Company company = new Company();
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
                    AdminPage adminPage = new AdminPage();
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
            loginPage.passwordTextBox.Clear();
            loginPage.loginIdTextBox.Clear();
            loading.Close();
        }

        private void loginPage_passwordTextBox_KeyPress(object sender, KeyPressEventArgs ke)
        {
            if (ke.KeyChar == Convert.ToChar(Keys.Enter))
            {
                loginPage_loginButton_Click(sender, ke);
            }
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
