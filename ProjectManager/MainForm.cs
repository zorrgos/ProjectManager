using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    partial class MainForm : Form
    {
        private List<User> users;
        private List<Task> tasks;

        User currentUser;

        private StyleConfigurator styleConfig;
        private FileHandler fileHandler;
        private TaskManager taskCreator;

        public MainForm(User currentUser, ref List<User> users, FileHandler fileHandler)
        {
            InitializeComponent();

            this.currentUser = currentUser;
            this.users = users;
            this.fileHandler = fileHandler;
        }
    }
}
