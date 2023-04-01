using ConsoleApp1;

Employee employee1 = new Employee("Piotr ", "Kowalski ", 24, 0);
Employee employee2 = new Employee("Monika ", "Riko ", 26, 0);
Employee employee3 = new Employee("Kamil ", "Szeregowy ", 28, 0);

employee1.AddScore(63);
employee1.AddScore(52);
employee1.AddScore(7);
employee1.AddScore(9);
employee1.AddScore(1);

employee2.AddScore(3);
employee2.AddScore(5);
employee2.AddScore(3);
employee2.AddScore(2);
employee2.AddScore(7);

employee3.AddScore(11);
employee3.AddScore(22);
employee3.AddScore(3);
employee3.AddScore(4);
employee3.AddScore(5);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{   
    if(employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}
Console.WriteLine("Pracownik z największą liczbą ocen:");
Console.WriteLine(employeeWithMaxResult.Name + employeeWithMaxResult.Surname);
Console.WriteLine("Wiek " + employeeWithMaxResult.Age);
Console.WriteLine("Wynik " + maxResult);