using ConsoleApp1;

var employee = new Employee("Piotr", "Warchoł");
employee.AddGrade("Piotr");
employee.AddGrade("4333");
employee.AddGrade(6.44);
employee.AddGrade(4.54);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average:{statistics.Average:N2}");
Console.WriteLine($"Min:  {statistics.Min}");
Console.WriteLine($"Max:  {statistics.Max}");