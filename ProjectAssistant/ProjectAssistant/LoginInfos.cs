using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant
{
    class LoginInfos
    {
        int loginId;
        string password;

        public int get_loginId()
        {
            return this.loginId;
        }
        public void set_loginId(int _loginId)
        {
            this.loginId = _loginId;
        }
        public string get_password()
        {
            return this.password;
        }

        public void set_password(string _password)
        {
            this.password = _password;
        }
    }
}
