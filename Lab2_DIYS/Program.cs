using System;

namespace Lab2_DIYS
{
    internal class Program
    {
        private static void checkValid(int sin)
        {
            var counter = 1;
            var sum = 0;
            var checkSumEven = 0;
            var checkSumOdd = 0;
            var total = 0;
            while (sin != 0)
            {
                if (counter % 2 == 0)
                {
                    var doubleNumEven = 2 *(sin % 10);
                    while (doubleNumEven != 0)
                    {
                        var num = doubleNumEven % 10;
                        sum += num;
                        doubleNumEven /= 10;
                    }
                    checkSumEven += sum;
                    sin /= 10;
                }
                else
                {
                    checkSumOdd += sin % 10;
                    sin /= 10; 
                }
            }

            total = checkSumEven + checkSumOdd;
            var multi = ((total + 9) / 10) * 10;
            if (multi - total == sin)
            {
                Console.WriteLine("This is a valid SIN.");
            }
            else
            {
                Console.WriteLine("This is not a valid SIN.");
            }
        }
        
        
        public static void Main(string[] args)
        {
            Console.WriteLine("SIN Validator");
            Console.WriteLine("=============");
            while (true)
            {
                Console.WriteLine("SIN (0 to quit): ");
                var sin = Convert.ToInt32(Console.ReadLine());
                if (sin == 0)
                {
                    Console.WriteLine("Have a Nice Day!");
                    break;
                }
                else
                {
                    Program.checkValid(sin);
                }
            }
        }
    }
}