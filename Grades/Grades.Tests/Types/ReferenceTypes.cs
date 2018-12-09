using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grades;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void RefernceTypes()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);

            Assert.AreEqual("A Gradebook",book2.Name);
        }

        public void GiveBookAName(GradeBook book)
        {
            book = new GradeBook();
            book.Name = "A Gradebook";
        }
    }
}
