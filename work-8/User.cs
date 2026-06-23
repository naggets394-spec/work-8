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
        string role;
        HashSet<string> passwords = new HashSet<string>();
        public User(string name, string lastname, string middlename, string login, string phone, string password, string registrationDate, string pole)
        {
            this.name = name;
            this.lastname = lastname;
            this.middlename = middlename;
            this.phone = phone;
            this.login = login;
            this.password = password;
            this.registrationDate = registrationDate;
            this.role = role;
            //name = "Кверк";
            //lastname = "Кверков";
            //middlename = "Кверкович";
            //login = "12345";
            //password = "password";
            //registrationDate = "2.12.2012";
            //phone = "1234567890";
            //role = "Менеджер";
        }
        void GeneratePasswords()
        {
            string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+";
            Random rnd = new Random();
            string res = default;
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 16; i++)
                {
                    int index = rnd.Next(validChars.Length);
                    res += validChars[index];
                }
                passwords.Add(res);
            }
        }
    }
}
