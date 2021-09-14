using System;

namespace Lab1_DIYS2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter third number: ");
            var num3 = Convert.ToInt32(Console.ReadLine());
            var max = num1;
            if (max < num2)
            {
                max = num2;
            }
            if (max < num3)
            {
                max = num3;
            }
            Console.WriteLine($"Max of 3 numbers is: {max}");
            Console.ReadLine();
        }
    }
}