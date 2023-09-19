
namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {          
        }         
        public override void AddGrade(char grade)
        {
            switch (grade)
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
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value");

            }
        }

        public override void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;
                case "-6":
                case "6-":
                    this.AddGrade(95);
                    break;
                case "5":
                    this.AddGrade(80);
                    break;
                case "+5":
                case "5+":
                    this.AddGrade(85);
                    break;
                case "-5":
                case "5-":
                    this.AddGrade(75);
                    break;
                case "4":
                    this.AddGrade(60);
                    break;
                case "+4":
                case "4+":
                    this.AddGrade(65);
                    break;
                case "-4":
                case "4-":
                    this.AddGrade(55);
                    break;
                case "3":
                    this.AddGrade(40);
                    break;
                case "+3":
                case "3+":
                    this.AddGrade(45);
                    break;
                case "-3":
                case "3-":
                    this.AddGrade(35);
                    break;
                case "2":
                    this.AddGrade(20);
                    break;
                case "+2":
                case "2+":
                    this.AddGrade(25);
                    break;
                case "-2":
                case "2-":
                    this.AddGrade(15);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;
                default:
                    throw new Exception("Grades only from 1 to 6 ");

            }
        }

        public override void AddGrade(int grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            
            foreach( var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
          
            return statistics;
        }

    }
}
