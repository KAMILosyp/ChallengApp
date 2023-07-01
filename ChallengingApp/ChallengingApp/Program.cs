using ChallengingApp;

Employee employee1 = new Employee("kamil", "Mors", 33);
Employee employee2 = new Employee("Adam", "buła", 43);
Employee employee3 = new Employee("Karina", "Kos", 23);

employee1.Addscore(3);
employee1.Addscore(7);
employee1.Addscore(11);

employee2.Addscore(2);
employee2.Addscore(6);
employee2.Addscore(7);

employee3.Addscore(5);
employee3.Addscore(8);
employee3.Addscore(9);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3,
};
int maxResult = -1;
Employee employeewithmaxresult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
       employeewithmaxresult = employee;
       maxResult = employee.Result;
    }
}
Console.WriteLine(employeewithmaxresult.name + employeewithmaxresult.surname);
Console.WriteLine("Ma" + employeewithmaxresult.age + "lata" + "i" + employeewithmaxresult.Result + "punktów");