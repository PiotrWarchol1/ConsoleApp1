using ConsoleApp1;

Console.WriteLine("Witamy w Programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine(); 
 
var employee = new EmployeeInFile("Piotr", "Warchoł");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}


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
Console.WriteLine($"Wartość średnia: {statistics.Average}");
Console.WriteLine($"Wartiść Min: {statistics.Min}");
Console.WriteLine($"Wartość Max: {statistics.Max}");