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
            this.AutoScroll = true;
            InitializeComponent();

            

            for (int i = 0; i < 100; i++)
            {
                Panel pnl = new Panel();
                StudentListItem sList = new StudentListItem();

                if (i % 2 == 0)
                {
                    sList.Location = new Point(0, panel1.Controls.Count * 30);
                    sList.Size = new Size(panel1.Size.Width, 50);
                    sList.BackColor = SystemColors.ControlLightLight;
                    sList.label1.Text = "a-" + i;
                }
                else
                {
                    pnl.Location = new Point(0, panel1.Controls.Count * 30);
                    pnl.Size = new Size(panel1.Size.Width, 5);
                    pnl.BackColor = SystemColors.Control;
                }
                panel1.Controls.Add(sList);
            }

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

            label4.Text = db.select_fromDatabase("studentName", "students", "studentId", loginInfo.get_loginId().ToString());
           

        }

        
    }
}
