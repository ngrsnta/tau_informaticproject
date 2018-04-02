using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant
{
    class Student
    {
//      string Name { get; set; } = "";
        string Name = "";
        string Surname = "";
        int ID_Number = 0;
        string Password= "";

        public string get_name()
        {
            return this.Name;
        }

        public void set_name(string _name)
        {
            this.Name = _name;
        }
    }

}
