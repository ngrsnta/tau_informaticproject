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
        Panel mainPanel = new Panel();

        public LoginPage()
        {
            this.AutoScroll = true;
            InitializeComponent();
        }
        /*
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
        */
    }
}
