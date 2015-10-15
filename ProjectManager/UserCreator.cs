using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    //тут надо бы применить какую-то фабрику (например, Фабричный метод) и Одиночку
    class UserCreator
    {
        public void createUser(string userType, string name, ref List<User> users)
        {
            users.Add(new Developer(name));
        }
    }
}
