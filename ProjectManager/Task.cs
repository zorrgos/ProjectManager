using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    class Task
    {
        private User performer;
        private string text;
        private double progress;

        public Task(User performer, string text)
        {
            this.performer = performer;
            this.text = text;
        }
    }
}
