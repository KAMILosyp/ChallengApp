
namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname{get; }

         void AddGrade(char grade);
         void AddGrade(float grade);
        void AddGrade(string grade);
    
         void AddGrade(double grade);


         Statistics GetStatistics()
        {
        return new Statistics();
        }
    }
}
