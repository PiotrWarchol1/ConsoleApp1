using ConsoleApp1;

namespace ConsoleApp.TestProject1
{
    public class Type_tests
    {
        [Test]

        public void GetNumShouldReturnOneDiffrentObiects()
        {
            //arrange
            var num1 = 432141;
            var num2 = 324325;

            //act

            //assert
            Assert.AreNotEqual(num1, num2);

        }

        [Test]

        public void GetNumberShouldReturnDiffrentObiects()
        {
            //arrange
            int number1 = 1;
            int number2 = 3;

            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }


        [Test]

        public void GetNumShouldReturnDiffrentObiects()
        {
            //arrange
            float num1 = 1.43f;
            float num2 = 3.432f;

            //act

            //assert
            Assert.AreNotEqual(num1, num2);
        }

    public class Employee_tests
    {

         [Test]
         public void GetEmployeeShouldReturnDiffrentObiects()
         {

             //arrange
             string employee1 = ("Adam");
             string employee2 = ("Piotr");

                //act

                //assert
                Assert.AreNotEqual(employee1, employee2);
         }
         private Employee GetEmployee(string name)
         {
                return new Employee(name);
         }
        }
    }
}

