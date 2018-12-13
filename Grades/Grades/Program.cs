using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("hello");

            GradeBook book =  new GradeBook();

            book.Name = "This is my book.";
            book.AddGrade(91);
            book.AddGrade(89.5f);

            Console.WriteLine(book.Name);

            GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine(stats.HighestGrade);

            WriteResult("Avg grade is", stats.AverageGrade,2,3,4,5);
            WriteResult("Highest grade is", (int)stats.HighestGrade);

        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, params float[] result)
        {
            foreach (float res in result)
            {
                Console.WriteLine(description + ": " + res);
            }
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }
    }
}
