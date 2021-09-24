using System;

namespace Lab3_DIYS2
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private string address;
        private long sin;
        private double salary;

        public Employee()
        {
        }

        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }

        public override string ToString()
        {
            return
                ($"First name: {firstName}\nLast name: {lastName}\nAddress: {address}\nSin: {sin}\nSalary: {salary}");
        }

        public double CalculateBonus(int percentage)
        {
            double bonus = salary * percentage * 0.01;
            return bonus;
        }
    }
}