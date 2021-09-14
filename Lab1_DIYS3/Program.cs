using System;

namespace Lab1_DIYS3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 7: ");
            var day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Day of the week: Monday");
                    break;
                case 2:
                    Console.WriteLine("Day of the week: Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Day of the week: Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Day of the week: Thursday");
                    break;
                case 5:
                    Console.WriteLine("Day of the week: Friday");
                    break;
                case 6:
                    Console.WriteLine("Day of the week: Saturday");
                    break;
                case 7:
                    Console.WriteLine("Day of the week: Sunday");
                    break;
                default:
                    Console.WriteLine("Wrong choice.");
                    break;
            }
        }
    }
}