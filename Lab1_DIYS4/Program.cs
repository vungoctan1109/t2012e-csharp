using System;

namespace Lab1_DIYS4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            var num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The first 9 multiples of {num} is: ");
            for (int i = 1; i < 10; i++)
            {
                var value = num * i;
                Console.WriteLine($"{num} * {i} = {value}");
            }
            Console.ReadLine();
        }
    }
}