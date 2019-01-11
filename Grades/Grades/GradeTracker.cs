using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        protected string _name;
        public abstract IEnumerator GetEnumerator();
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value)) //if (!String.IsNullOrEmpty(value)){}
                {
                    if (_name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;
                        //NameChanged(_name, value);
                        NameChanged(this, args);    //"this" will reference the object that im inside of.
                    }
                    _name = value; //'value' is the implicit variable inside a setter.
                }
            }
        }
        public event NameChangedDelegate NameChanged;
    }
}
