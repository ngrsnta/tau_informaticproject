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
    }
}
