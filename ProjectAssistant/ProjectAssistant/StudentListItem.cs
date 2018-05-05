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
    public partial class StudentListItem : UserControl
    {
        public StudentListItem()
        {
            InitializeComponent();
        }

        private void StudentListItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label1.Text);
        }
    }
}
