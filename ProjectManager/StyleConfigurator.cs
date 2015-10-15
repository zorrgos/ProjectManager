using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    class StyleConfigurator
    {
        private System.Drawing.Color color;

        public void configureStyle(System.Drawing.Color color)
        {
            this.color = color;
        }

        public void setStyle(ref System.Windows.Forms.Form form)
        {
            form.BackColor = color;
        }
    }
}
