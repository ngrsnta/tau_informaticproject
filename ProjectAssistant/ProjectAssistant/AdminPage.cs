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
  
    public partial class AdminPage : UserControl //Main
    {

        public AdminPage() //Start
        {
            InitializeComponent();
            

        }
        void Delete_Text()
        {
            var selectedTab = Admin_MainTab.SelectedTab;

            foreach (Control ctrl in selectedTab.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = string.Empty;
                }

                if (ctrl is Label)
                {
                    if ((ctrl != label_studentname ||
                        ctrl != label_studentnumber ||
                        ctrl != label_studentsurname ||
                        ctrl != label_studentpassword) == false)
                        (ctrl as Label).Text = string.Empty;
                }

                // Other Controls....
            }
        }

        private void reg_student_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (textbox_studentname.Text.Length == 0 ||
                textbox_studentsurname.Text.Length == 0 ||
                textbox_studentnumber.Text.Length == 0 ||
                textbox_studentpassword.Text.Length == 0)
            {
                MessageBox.Show("Please fill all the blankets.");
                return;
            }

            if (textbox_studentname.Text.Length < 2)
                i = 1;
            else if (textbox_studentsurname.Text.Length < 2)
                i = 2;
            else if (textbox_studentnumber.Text.Length < 9)
                i = 3;
            else if (textbox_studentpassword.Text.Length < 6)
                i = 4;

            switch (i)
            {
                default:
                    break;
                case 1:
                    {
                        MessageBox.Show("Please enter longer name (Minimum Length = 2)");
                        Delete_Text();
                        return;
                    }

                case 2:
                    {
                        MessageBox.Show("Please enter longer surname (Minimum Length = 2)");
                        Delete_Text();
                        return;
                    }
                case 3:
                    {
                        MessageBox.Show("Please enter a 9 digit number.");
                        Delete_Text();
                        return;
                    }
                case 4:
                    {
                        MessageBox.Show("Please enter longer password. (Minimum Length = 6)");
                        Delete_Text();
                        return;
                    }
            }

            i=0;
            //Experimental: Out of Bit, will be removed
            if (Int32.TryParse(textbox_studentnumber.Text, out i) != true) { 
                MessageBox.Show("Maximum number limit!!! (Maximum: 2147483647)");
                Delete_Text();
                i = 0;
                return;
            }

            Student stu = new Student();
            
            stu.name = textbox_studentname.Text;
            stu.id_number = Convert.ToInt32(textbox_studentnumber.Text);
            stu.password = textbox_studentpassword.Text;

            //Just to Check, will be removed
            label_test1.Text= stu.name;
            label_test3.Text = Convert.ToString(stu.id_number);
            label_test4.Text = stu.password;
        }

        private void textbox_studentnumber_KeyPress(object sender, KeyPressEventArgs keypress)
        {
            if (!char.IsControl(keypress.KeyChar) && !char.IsDigit(keypress.KeyChar) )
            {
                keypress.Handled = true;
            }
        }

        private void textbox_studentsurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textbox_studentname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textbox_studentpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Admin_MainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get Selected Tab
            var selectedTab = Admin_MainTab.SelectedTab;

            foreach (Control ctrl in selectedTab.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = string.Empty;
                }

                if (ctrl is Label)
                {
                    if( (ctrl != label_studentname    ||
                        ctrl != label_studentnumber   ||
                        ctrl != label_studentsurname  ||
                        ctrl != label_studentpassword)==false )
                    (ctrl as Label).Text = string.Empty;
                }

                // Other Controls....
            }
        }

        private void button_studentshow_Click(object sender, EventArgs e)
        {
            
        }
    }
}

