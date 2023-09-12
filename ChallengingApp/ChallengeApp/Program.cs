

using ChallengeApp;


Console.WriteLine(" HI WELCOME IN OUR PROGRAMM GRADESTAT2.0");
Console.WriteLine("****************************************");
Console.WriteLine();
Console.WriteLine("Please choose your grade from 1 to 6");
Console.WriteLine("Every grade have assigned value");
Console.WriteLine("For Example:6 = 100, 5 = 80, 4 = 60, 3 = 40 evry +/- is +5 -5 points");
//Console.WriteLine("You can also type grade from 0-100 ");
//Console.WriteLine("or choose letter A=100, B=80, C=60, D=40, E=20");
//Console.WriteLine("");
Console.WriteLine("for summary press Q/q");
Console.WriteLine("*****************************************");

var employee = new EmployeeInFile("Kamil", "Kolo");
employee.AddGrade(0.5f);
while (true)
{
    Console.WriteLine("Provide another grade:");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched:{ex.Message}");

    }
}
    var statistics = employee.GetStatistics();
    Console.WriteLine($"Average: {statistics.Average}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
