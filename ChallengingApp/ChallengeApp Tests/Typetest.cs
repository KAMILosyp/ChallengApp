

using ChallengeApp;

namespace ChallengeApp_Tests
{
    public class Typetest
    {

        [Test]

        public void Employeescorecheckwhenpositive_shouldreturnCorrectsum()
        {

            var user1 = new Employee("Kamil", "Bolek", 33);

            user1.Addscore(4);
            user1.Addscore(3);
            user1.Addscore(6);

            var result1 = user1.Result;

            Assert.AreEqual(13, result1);
        }

        [Test]
        public void Employeescorecheckreduce_shouldreurtnCorrectsum()
        {

            var user2 = new Employee("monika", "gałka", 22);
            user2.Addscore(4);
            user2.Addscore(-6);
            user2.Addscore(-1);

            var result2 = user2.Result;

            Assert.AreEqual(-3, result2);
        }
    }
}
