﻿using System;
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

            for (int i = 0; i < 20; i++)
            {
                Label lbl = new Label();
                lbl.Text = "a" + i;
                lbl.Location = new Point(18, 2);

                Panel pnl = new Panel();
                pnl.Location = new Point(0, panel1.Controls.Count * 30);
                pnl.Size = new Size(panel1.Size.Width, 30);
                if (i % 2 == 0)
                {
                    pnl.Location = new Point(0, panel1.Controls.Count * 30);
                    pnl.Size = new Size(panel1.Size.Width, 50);
                    pnl.BackColor = SystemColors.ControlLightLight;
                    pnl.Controls.Add(lbl);
                }
                else
                {
                    pnl.Location = new Point(0, panel1.Controls.Count * 30);
                    pnl.Size = new Size(panel1.Size.Width, 5);
                    pnl.BackColor = SystemColors.Control;
                }
                panel1.Controls.Add(pnl);

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

            db.set_studentId(loginInfo.get_loginId(), loginInfo.get_password());

            richTextBox1.Text = db.get_studentPass(loginInfo.get_loginId());

        }

        
    }
}
