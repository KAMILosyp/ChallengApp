

using ChallengeApp;
using System;



Console.WriteLine(" HI WELCOME IN OUR PROGRAMM GRADESTAT2.0");
Console.WriteLine("****************************************");
Console.WriteLine();
Console.WriteLine("Please choose your grade from 1 to 6");


var employee = new EmployeeInMemory("Kamil", "lolo");

employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

employee.AddGrade(0.6f);


while (true)
{Console.WriteLine("Provide another grade:");
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
