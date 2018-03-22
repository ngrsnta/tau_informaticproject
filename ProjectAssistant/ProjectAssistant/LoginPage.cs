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
    public partial class LoginPage : UserControl
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginInfos loginInfo = new LoginInfos();
            try
            {
                loginInfo.set_loginId(System.Convert.ToInt32(loginIdTextBox.Text));
            }

            catch (System.FormatException)
            {
                MessageBox.Show("Login Id can only contain numbers");
                return;
            }

            loginInfo.set_password(passwordTextBox.Text);

            richTextBox1.Text = loginInfo.get_loginId() + loginInfo.get_password();
        }
    }
}
