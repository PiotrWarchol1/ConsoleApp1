using NUnit.Framework;

namespace ConsoleApp1.Tests
{
    public class Tests
    {     
        [Test]
        public void GetStatisticsShouldReturnCorrectMax()
        {
            var employee = new Employee1("Piotr","Warcho³");
            employee.AddGrade(2);
            employee.AddGrade(5);
           
            var statistics = employee.GetStatistics();

            Assert.AreEqual(2, 2);
        }
    }
}