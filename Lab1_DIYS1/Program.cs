using System;

namespace Lab1_DIYS1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter your address: ");
            var address = Console.ReadLine();
            Console.WriteLine("Please enter your phone number: ");
            var phone = Console.ReadLine();
            Console.WriteLine($"Your name: {name}\nYour address: {address}\nYour phone number: {phone}");
            Console.ReadLine();
        }
    }
}