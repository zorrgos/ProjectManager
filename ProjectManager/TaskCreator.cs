using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    //тут надо бы применить паттерн Одиночка
    class TaskManager
    {
        public void createTask(User performer, string text, ref List<Task> tasks)
        {
            tasks.Add(new Task(performer, text));
        }

        public void deleteTask(Task id, ref List<Task> tasks)
        {
            tasks.Remove(id);
        }
    }
}
