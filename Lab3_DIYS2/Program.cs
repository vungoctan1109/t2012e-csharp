using System;

namespace Lab3_DIYS2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var employee = new Employee("Vu", "Tan", "Ha Noi", 199900, 2000000);
            var bonus = employee.CalculateBonus(30);
            Console.WriteLine($"Your info:\n{employee.ToString()}");
            Console.WriteLine($"Your bonus: {bonus}");
        }
    }
}