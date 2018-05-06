using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectAssistant
{
    public partial class LoginPage : UserControl
    {

        LoginInfos loginInfo = new LoginInfos();
        DataBase db = new DataBase();
        string _password = "";
        Panel mainPanel = new Panel();
        StudentPage stuPage = new StudentPage();

        public LoginPage()
        {
            this.AutoScroll = true;
            InitializeComponent();
        }
        

        private void loginButton_Click(object sender, EventArgs e)
        {

            try
            {
                loginInfo.set_loginId(Convert.ToInt32(loginIdTextBox.Text));
            }
            
            catch (FormatException)
            {
                MessageBox.Show("Login Id can only contain numbers");
                return;
            }

            loginInfo.set_password(passwordTextBox.Text);
            if(loginInfo.get_loginId() > 100000000)
            {
                _password = db.select_fromDatabase("studentPassword", "students", "studentId", loginInfo.get_loginId().ToString());
                if (loginInfo.get_password() == _password)
                {
                }
                else
                {
                    this.Dispose();
                    mainPanel.Controls.Add(stuPage);
                    MessageBox.Show("sa");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> list = new List<string>();

            list = db.select_asArray("students", "studentId", loginIdTextBox.Text);
            label4.Text = list.Count.ToString();

            for(int i = 0; i < list.Count; i++)
            {
                Label lbl = new Label();
                lbl.Location = new Point(5, (i * 50));
                lbl.Text = list[i];
                this.Controls.Add(lbl);
            }
        }
    }
}
