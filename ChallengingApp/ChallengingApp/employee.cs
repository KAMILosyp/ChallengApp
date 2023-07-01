
namespace ChallengingApp
{
 public class Employee
    {
        private List<int> score = new List<int>();
        public Employee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public string name { get; private set; }
        public string surname { get; private set; }
        public int age { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void Addscore(int number)
        {
            this.score.Add(number);
        }
    }
}
