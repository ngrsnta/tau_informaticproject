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

        private void reg_student_Click(object sender, EventArgs e)
        {
            //this.label_test = textbox_studentname.Text;
            this.label_test1.Text = textbox_studentname.Text;
            this.label_test2.Text = textbox_studentsurname.Text;
            this.label_test3.Text = textbox_studentnumber.Text;
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
    }
}

