

using ChallengeApp;

Console.WriteLine(" Witamy w Programie 123 który ocenia Pracowników ");
Console.WriteLine("=================================================");
Console.WriteLine();

var employee = new Employee("Wojtek", "Booo");


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika:");
    var input = Console.ReadLine();
    if ( input == "q" )
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
