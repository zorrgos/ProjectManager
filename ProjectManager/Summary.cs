using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    class Summary
    {
        public void save(FileHandler fh)
        {
            fh.saveSummary(this);
        }

        public Summary getSummary()
        {
            return new Summary();
        }
    }
}
