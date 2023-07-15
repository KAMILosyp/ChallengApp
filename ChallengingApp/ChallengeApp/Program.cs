using ChallengeApp;

Employee employee1 = new Employee("Kamil", "Bart", 33);
Employee employee2 = new Employee("Monika", "Kot", 22);
Employee employee3 = new Employee("Kuba", "Jeż", 45);

employee1.Addscore(2);
employee1.Addscore(5);
employee1.Addscore(3);
employee1.Addscore(6);

employee2.Addscore(1);
employee2.Addscore(2);
employee2.Addscore(3);
employee2.Addscore(4);

employee3.Addscore(5);
employee3.Addscore(5);
employee3.Addscore(6);
employee3.Addscore(2);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};
var maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine(employeeWithMaxResult.Name + " " + employeeWithMaxResult.surname + " " + "ma" + " " + employeeWithMaxResult.age + "lata" + " i" + employeeWithMaxResult.Result + "" + "punktów");