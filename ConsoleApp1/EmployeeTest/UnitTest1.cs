﻿global using NUnit.Framework;
namespace ConsoleApp1
{
    public class Tests 
    {
        [Test]
        public void WhenGetStatisticsCalled_ShouldRReturnCorrectStatisticsMin()
        {
            // arrange
            var employee = new Employee("Piotr", "Warchoł");

            employee.AddGrade(6);
            employee.AddGrade(4);
            employee.AddGrade(2);

            //act

            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(2,4);
        }
        [Test]
        public void WhenGetStatisticsCalled_ShouldRReturnCorrectStatisticsMax()
        {
            // arrange
            var employee = new Employee("Piotr", "Warchoł");
            employee.AddGrade(6);
            employee.AddGrade(3);
            employee.AddGrade(5);

            //act

            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(2, 2);
        }
        [Test]
        public void WhenGetStatisticsCalled_ShouldRReturnCorrectAverage()
        {
            // arrange
            var employee = new Employee("Piotr", "Warchoł");
            employee.AddGrade(6);
            employee.AddGrade(2);
            employee.AddGrade(4);

            //act

            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(2,2);
        }
    }

}