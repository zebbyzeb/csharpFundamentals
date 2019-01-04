using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    //this class is created to consolidate string ExistingName, string NewName
    public class NameChangedEventArgs : EventArgs //inheritance
    {
        public string ExistingName { get; set; }
        public string NewName { get; set; }

    }
}
