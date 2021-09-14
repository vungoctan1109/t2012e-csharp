using System;

namespace Lab1_07
{
    internal class AnonTypes
    {
        public static void Main(string[] args)
        {
            var p1 = new {Name = "A", price = "3"};
            Console.WriteLine("Name = {0} \nPrice = {1}", p1.Name, p1.price);
            Console.ReadLine();
        }
    }
}