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

        public LoginPage()
        {
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

            db.set_studentId(loginInfo.get_loginId(), loginInfo.get_password());

            richTextBox1.Text = db.get_studentPass(loginInfo.get_loginId());

        }
    }
}
