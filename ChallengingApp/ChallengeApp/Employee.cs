
using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname, char sex)
            : base(name, surname, sex)
        {
        }
        public Employee(string name, string surname)
            : this(name, surname,'x')
        { 
        }
        public Employee(string name)
          : this(name, "no surname", 'x')
        { 
        }
        public Employee()
          : this("no name", "no surname", 'x')
        {
        }
        public void AddGrade(char grade)
        {
           switch(grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100); 
                    break;
                case 'B':
                    this.AddGrade(80);
                    break;
                case 'C':
                    this.AddGrade(60);
                    break;
                case 'D':
                    this.AddGrade(40);
                    break;
                case 'E':
                    this.AddGrade(20);
                    break;
                default:
                    this.AddGrade(0);
                    break;
            }             
        }
        public void AddGrade(float grade)
        {
            if( grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
                
            }
        } 
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }
        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average = statistics.Average / this.grades.Count;

            switch(statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    throw new Exception("Invalid grade value");
                    break;
            }
            return statistics;
        }

    }
}
