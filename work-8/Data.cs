using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_8
{
    internal class Data
    {
        static public User user = new User("Кверк", "Кверков", "Кверкович", "12345", "89021363829", "password", "12.12.2025", "Администратор");
        static public Dictionary<string, User> users = new Dictionary<string, User>();
        static public Dictionary<string, User> usersPh = new Dictionary<string, User>();
        static public HashSet<string> logins = new HashSet<string>();
        static public Dictionary<string, string> passwords = new Dictionary<string, string>();
        static public HashSet<string> phones = new HashSet<string>();
        public Data ()
        {
            AddUser();
        }
        void AddUser()
        {
            users["12345"] = user;
            usersPh["89021354234"] = user;
            logins.Add(user.login);
            passwords[user.login] = user.password;
            phones.Add(user.phone);
        }
    }
}
