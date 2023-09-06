

using ChallengeApp;

Console.WriteLine(" Witamy w Programie 123 który ocenia Pracowników ");
Console.WriteLine("=================================================");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika:");
    var input = Console.ReadLine();
    if ( input == "q" )
    {
        break;
    }
    employee.AddGrade( input );
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
