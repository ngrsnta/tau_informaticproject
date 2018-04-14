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
    public partial class StudentPage : UserControl
    {
        public StudentPage()
        {
            InitializeComponent();


            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_studDateOfBirth_Click(object sender, EventArgs e)
        {
            
        }

        private void StudentPage_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox_studPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        

        

        private void richTextBox_studEducation_MouseHover(object sender, EventArgs e)
        {
            ToolTip tltip = new ToolTip();
            tltip.SetToolTip(this.richTextBox_studEducation, "Kadıköy Anatolian High School (2010-2014)");
            
        }

        private void richTextBox_studWork_MouseHover(object sender, EventArgs e)
        {
            ToolTip tltip = new ToolTip();
            tltip.SetToolTip(this.richTextBox_studWork, "Intern at Mercedes Benz Türk A.Ş (07.2015-08.2015)");
        }
    }
}
