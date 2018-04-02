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

        //Get Functions

        public string get_name()
        {
            return this.Name;
        }
        public string get_surname()
        {
            return this.Surname;
        }

        public int get_ID()
        {
            return this.ID_Number;
        }

        public string get_password()
        {
            return this.Password;
        }

        //Set Functions
        public void set_name(string _name)
        {
            this.Name = _name;
        }

        public void set_surname(string _surname)
        {
            this.Surname = _surname;
        }

        public void set_ID(int _ID)
        {
            this.ID_Number = _ID;
        }

        public void set_password(string _password)
        {
            this.Password = _password;
        }

    }

}
