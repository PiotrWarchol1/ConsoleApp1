﻿namespace ConsoleApp1
{
    internal class Employee 
    {
        private string v1;
        private string v2;

        public Employee(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        internal void AddGrade(int v)
        {
            throw new NotImplementedException();
        }

        internal object GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}