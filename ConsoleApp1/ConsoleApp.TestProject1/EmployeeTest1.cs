using ConsoleApp1;

namespace ConsoleApp.TestProject1
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectResult()
        {
            var employee = new Employee("Piotr", "asdsad", 23, 0);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(2);
            employee.AddScore(-8);
            employee.AddScore(-1);

            var result = employee.Result;

            Assert.AreEqual(4, result);

        }
    }
}