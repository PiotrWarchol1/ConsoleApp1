global using NUnit.Framework;
namespace ConsoleApp1
{
    public class Tests
    {
        [Test]
        public void WhenGetStatisticsCalled_ShouldRReturnCorrectStatisticsMin()
        {
            // arrange
            var employee = new Employee("Piotr", "Warcho³");

            employee.AddGrade(6);
            employee.AddGrade(4);
            employee.AddGrade(2);

            //act

            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(2,statistics.Min);
        }
        [Test]
        public void WhenGetStatisticsCalled_ShouldRReturnCorrectStatisticsMax()
        {
            // arrange
            var employee = new Employee("Piotr", "Warcho³");
            employee.AddGrade(6);
            employee.AddGrade(3);
            employee.AddGrade(5);

            //act

            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(2, statistics.Max);
        }
        [Test]
        public void WhenGetStatisticsCalled_ShouldRReturnCorrectAverage()
        {
            // arrange
            var employee = new Employee("Piotr", "Warcho³");
            employee.AddGrade(6);
            employee.AddGrade(2);
            employee.AddGrade(4);

            //act

            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(4), Math.Round(statistics.Average, 2));
        }
    }

}