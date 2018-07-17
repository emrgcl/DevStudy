using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Grades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookTests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void TestHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(60);
            book.AddGrade(30);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }
    }
}
