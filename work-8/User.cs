using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_8
{
    internal class User
    {
        string name;
        string lastname;
        string middlename;
        public string login;
        public string password;
        string registrationDate;
        string phone;
        public User()
        {
            name = "Кверк";
            lastname = "Кверков";
            middlename = "Кверкович";
            login = "12345";
            password = "password";
            registrationDate = "2.12.2012";
            phone = "1234567890";
        }
    }
}
