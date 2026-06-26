using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using static System.Net.Mime.MediaTypeNames;

namespace work_8
{
    internal class User
    {
        string name;
        string lastname;
        string middlename;
        public string login;
        string registrationDate;
        public string phone;
        Role role;
        public static HashSet<string> passwords = new HashSet<string>();
        public User(string name, string lastname, string middlename, string login, string phone, string registrationDate, Role role)
        {
            this.name = name;
            this.lastname = lastname;
            this.middlename = middlename;
            this.phone = phone;
            this.login = login;
            this.registrationDate = registrationDate;
            this.role = role;
            GeneratePasswords();
            //name = "Кверк";
            //lastname = "Кверков";
            //middlename = "Кверкович";
            //login = "12345";
            //password = "password";
            //registrationDate = "2.12.2012";
            //phone = "1234567890";
            //role = "Менеджер";
        }
        public void GeneratePasswords()
        {
            passwords.Clear();
            string validChars = "1234567890";
            List<char> charList = validChars.ToList();
            Random rnd = new Random();
            string res = default;
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    int index = rnd.Next(charList.Count);
                    res += charList[index];
                }
                passwords.Add(res);
                res = default;
            }
        }
    }
}
