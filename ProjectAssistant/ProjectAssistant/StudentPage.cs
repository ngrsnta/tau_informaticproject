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

        private void studPage_editInfo_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox_studWork_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox_studEducation_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tltip = new ToolTip();
            tltip.SetToolTip(this.richTextBox_studCertificates, "DSH C1 Certificate(06.2015)");
        }

        private void richTextBox_studCertificates_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox_studCurricular_MouseHover(object sender, EventArgs e)
        {
            ToolTip tltip = new ToolTip();
            tltip.SetToolTip(this.richTextBox_studCurricular, "Guitar, Working at the Orphanage...");
        }

        private void richTextBox_studProjects_MouseHover(object sender, EventArgs e)
        {
            ToolTip tltip = new ToolTip();
            tltip.SetToolTip(this.richTextBox_studProjects, "EEG Project (06.2017-08.2017) Controlling a Robot Arm with Brain Signals, " +
                "\nInnovation an der TDU 02.2017-06.2017 Creating a smart University by implementing smart surveillance systems, ...");
        }

        private void richTextBox_studProfessions_MouseHover(object sender, EventArgs e)
        {
            ToolTip tltip = new ToolTip();
            tltip.SetToolTip(this.richTextBox_studProfessions, "C++ Intermediate, Python Beginner,...");
        }

        private void richTextBox_studFurtherInfo_MouseHover(object sender, EventArgs e)
        {
            ToolTip tltip = new ToolTip();
            tltip.SetToolTip(this.richTextBox_studFurtherInfo, "I have also tried to improve myself in In-Team Communication, improving my teams success in projects, ... and so on");
        }
    }
}
