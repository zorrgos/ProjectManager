using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    abstract class User
    {
        protected string name;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public User(string name)
        {
            this.name = name;
        }
    }

    class ScrumMaster : User
    {
        public ScrumMaster(string name) : base(name)
        {
        }
    }

    class Developer : User
    {
        public Developer(string name) : base(name)
        {
        }
    }

    class Designer : User
    {
        public Designer(string name) : base(name)
        {
        }
    }
}
