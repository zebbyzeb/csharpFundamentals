﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        private List<float> grades;
        public GradeBook()
        {
            _name = "empty";
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        //List<float> grades = new List<float>();

        //atm, Name is just a field.
        //public string Name;

        //this is now a property
        /*public string Name
        {
            get;
            set;
        }*/

        
        //another way of writing a property with conditions in set
        private string _name;
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
                    if(_name != value)
                    {
                        NameChanged(_name, value);
                    }
                    _name = value; //'value' is the implicit variable inside a setter.
                }
            }
        }
        public NameChangedDelegate NameChanged;





        public GradeStatistics ComputeStatistics()
        {

            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {
                sum += grade;
            }
            float averageGrade = sum / grades.Count();
            stats.AverageGrade = averageGrade;

            float highestGrade = grades.Max();
            stats.HighestGrade = highestGrade;

            float lowestGrade = grades.Min();
            stats.LowestGrade = lowestGrade;

            return stats;
        }
    }
}
