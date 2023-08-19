using static ConsoleApp1.EmployeeBase;

namespace ConsoleApp1
{
    public interface IEmployee 
    {
        event GradeAddedDelegate GradeAdded;
        string Name { get; }
        string Surname { get; } 
        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(char grade);
        void AddGrade(string grade);
        Statistics GetStatistics();
    } 
}
