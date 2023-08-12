namespace ConsoleApp1
{
    public class EmployeeInMemory : EmployeeBase
    {
        public delegate void WriteMessage(string message);

        private List<float> grades = new List<float>();
        private string fileName;

        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        {
        }

        private void WriteMessageInConsole(string message)
        {
            Console.WriteLine(message);
        }
        private void WriteMessageInConsole2(string message)
        {
            Console.WriteLine(message.ToUpper());
        }
        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.Write(grade); 
            }
        }

        public override void AddGrade(double grade)
        {
        }

        public override void AddGrade(int grade)
        {
        }

        public override void AddGrade(char grade)
        {
        }

        public override void AddGrade(string grade)
        {
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return result;
        }
    }
}
