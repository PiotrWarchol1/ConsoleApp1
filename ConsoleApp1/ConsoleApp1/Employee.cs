namespace ConsoleApp1

{
    public class Employee
    {
        public List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        private string Name { get; set; }
        private string Surname { get; set; }

        public void AddGrade(float grade)

        {
            //3.33
            //3

            int valueInInt = (int)grade;

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }
        public void AddGrade(double grade)

        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }
    
        public void AddGrade(long grade)
        {
            float gradeIsFloat = (long)grade;
            this.AddGrade(gradeIsFloat);
        }
        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String in not floaat");
            }
            
        }
            public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;


            return statistics;
        }

    }    
}