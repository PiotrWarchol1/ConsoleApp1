using ConsoleApp1;

var employee = new Employee1("Piotr", "Warchoł");
employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(4);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average:  {statistics.Average:N2}");
Console.WriteLine($"Min:  {statistics.Min}");
Console.WriteLine($"Max:  {statistics.Max}");