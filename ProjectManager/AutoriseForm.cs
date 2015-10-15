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
    partial class AutoriseForm : Form
    {
        private Autorisator autorisator;
        private UserCreator userCreator;

        private FileHandler fileHandler;

        private List<User> users;

        public AutoriseForm()
        {
            InitializeComponent();

            fileHandler = new FileHandler();
            users = fileHandler.openUsers();
        }

        private void openForm()
        {
            if(autorisator.checkUser("name", "password"))
            {
                User currentUser = null;

                foreach(User user in users)
                {
                    if(user.Name == "name")
                    {
                        currentUser = user;
                        break;
                    }
                }

                new MainForm(currentUser, ref users, fileHandler);
                Close();
            }
        }
    }
}
