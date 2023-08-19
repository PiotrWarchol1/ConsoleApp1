using ConsoleApp1;

Console.WriteLine("Witamy w Programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine(); 
 
var employee = new EmployeeInFile("Piotr", "Warchoł");
employee.AddGrade(34.0f);
employee.AddGrade(20);
employee.AddGrade(25);
employee.AddGrade(5);

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}


var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");