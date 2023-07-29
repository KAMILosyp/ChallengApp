
using ChallengeApp;
using NUnit.Framework;

namespace ChallengeApp_Tests
{
    public class Teststat
    {
        [Test]

        public void maxValueTest()
        {
            var employee = new Employee ("Kamil", "Osyp");
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(-1);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(5, statistics.Max);
        }

        [Test]

        public void minValueTest()
        {
            var employee = new Employee("Kamil", "Osyp");
            employee.AddGrade(4);
            employee.AddGrade(4);
            employee.AddGrade(4);
            

            var statistics = employee.GetStatistics();

            Assert.AreEqual(4, statistics.Min);
            Assert.AreEqual(4, statistics.Max);
            Assert.AreEqual(4, statistics.Average);

        }
    }
}
