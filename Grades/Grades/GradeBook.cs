using System;
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
        public string Name
        {
            get;
            set;
        }


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
