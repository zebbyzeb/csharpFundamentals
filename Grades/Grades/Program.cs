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

            //GradeBook book =  new GradeBook();
            GradeTracker book = new ThrowAwayGradeBook();
            book.NameChanged += new NameChangedDelegate(OnNameChanged); //use += to point delegates to many methods. / add subscription

        //    book.NameChanged += new NameChangedDelegate(OnNameChanged2);
        //    book.NameChanged -= new NameChangedDelegate(OnNameChanged2); //-= remove subscription

           // book.NameChanged = null; //this will point the delegate to null. removing subsriptions of all the above methods.
                                     //use events to prevent this.


            book.Name = "This is my book";
            book.Name = null; //this is not set because of the logic on the setter for Name.
            book.AddGrade(91);
            book.AddGrade(89.5f);

            Console.WriteLine(book.Name);

            GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine(stats.HighestGrade);

        //    WriteResult("Avg grade is", stats.AverageGrade,2,3,4,5);
            WriteResult("Highest grade is", (int)stats.HighestGrade);

        }

        /*        static void OnNameChanged(string existingName, string newName)
                {
                    Console.WriteLine("Name changed from "+existingName+" to "+newName);
                }
        */
        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("Name changed from " + args.ExistingName + " to " + args.NewName);
        }

        static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine("***");
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
