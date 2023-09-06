using NUnit.Framework;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void CheckingMaxGradeofEmployee()
        {
            var employee = new Employee();
            employee.AddGrade(4);
            employee.AddGrade(7);
            employee.AddGrade(22);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(22, statistics.Max);
            Assert.AreEqual(4, statistics.Min);
            Assert.AreEqual(11, statistics.Average);


        }

        [Test]
        public void CheckingAverageLetterGradeTest()
        {
            var employee = new Employee();
            employee.AddGrade(4);
            employee.AddGrade(7);
            employee.AddGrade(22);

            var statistics = employee.GetStatistics();

            Assert.AreEqual('E', statistics.AverageLetter);
        }

        [Test]
        public void CheckingAverageGradeTest()
        {
            var employee = new Employee();
            employee.AddGrade(4);
            employee.AddGrade(7);
            employee.AddGrade(22);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(11, statistics.Average);
        }

        [Test]
        public void CheckingMinGradeTest()
        {
            var employee = new Employee();
            employee.AddGrade(4);
            employee.AddGrade(7);
            employee.AddGrade(22);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(4, statistics.Min);
        }

    }
}