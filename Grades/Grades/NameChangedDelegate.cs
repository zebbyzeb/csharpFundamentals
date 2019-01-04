using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    //public delegate void NameChangedDelegate(string ExistingName, string NewName);
    public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args); //when type of a parameter is object, you can pass anything to it

}
