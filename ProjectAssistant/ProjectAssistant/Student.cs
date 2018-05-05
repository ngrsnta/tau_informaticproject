using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant
{
    class Student
    {
        public string name { get; set; } = "";
        public int id_number { get; set; }
        public string password { get; set; } = "";
        public string dateofbirth { get; set; } = ""; //Must be type date
        public string gender { get; set; } = "";
        public string faculty { get; set; } = "";
        public string major { get; set; } = "";
        public int semester { get; set; }
        public string phone { get; set; } = "";
        public string email { get; set; } = "";
        public string adress { get; set; } = "";
        public string education { get; set; } = "";
        public string experience { get; set; } = "";
        public string certificates { get; set; } = "";
        public string hobbies { get; set; } = "";
        public string projects { get; set; } =  "";
        public string professions { get; set; } = "";
        public string other { get; set; } = "";
    }

}
