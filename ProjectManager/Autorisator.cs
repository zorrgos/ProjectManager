using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    class Autorisator
    {
        private List<User> users;

        public Autorisator(ref List<User> users)
        {
            this.users = users;
        }

        public bool checkUser(string name, string password)
        {
            return true;
        }
    }
}
