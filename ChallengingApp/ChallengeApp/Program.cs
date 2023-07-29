using ChallengeApp;

var employee = new Employee("Kamil", "Osypinski");
employee.AddGrade(2);
employee.AddGrade(2);
employee.AddGrade(6);


var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Average: {statistics.Min}");
Console.WriteLine($"Average: {statistics.Max}");

