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
            

            for (int i = 0; i < 20; i++)
            {
                ProjectListItem projectList = new ProjectListItem();

                
                projectList.Location = new Point(5, (i * 160)+5);
                projectList.BackColor = SystemColors.Control;
                studPage_projects.Controls.Add(projectList);
            }


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

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tltip = new ToolTip();
            tltip.SetToolTip(this.richTextBox_studCertificates, "DSH C1 Certificate(06.2015)");
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

        public void button1_Click(object sender, EventArgs e)
        {
            Form Profile = new Form();
            StudentProfile studentProfile = new StudentProfile();
            Label exitLabel = new Label();
            exitLabel.Text = "Close";
            exitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            exitLabel.Location = new Point(1060, 15);
            exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            exitLabel.Cursor = Cursors.Hand;
            exitLabel.Size = new Size(new Point(45, 20));

            //Profile.FormBorderStyle = FormBorderStyle.None;
            Profile.Size = studentProfile.Size;
            Profile.Controls.Add(studentProfile);
            Profile.Controls.Add(exitLabel);
            exitLabel.BringToFront();
            Profile.Show();
        }
        private void exitLabel_Click(object sender, EventArgs e)
        {
            //Profile.Close();
        }
    }
}
