using System;
using System.Collections.Generic;

namespace Lab3_DIYS1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Atom> atoms = new List<Atom>();
            
            Console.WriteLine("Atomic Information");
            Console.WriteLine("==================");
            while (true)
            {
                Console.WriteLine("Enter atomic number: ");
                var atomNumber = Convert.ToInt32(Console.ReadLine());
                if (atomNumber == 0)
                {
                    Console.WriteLine("No Sym Name Weight");
                    Console.WriteLine("-----------------------------------");
                    foreach (var t in atoms)
                    {
                        t.Display();
                    }       
                    break;
                }
                else
                {
                    Console.WriteLine("Enter symbol: ");
                    var atomSymbol = Console.ReadLine();
                    Console.WriteLine("Enter full name: ");
                    var atomFullName = Console.ReadLine();
                    Console.WriteLine("Enter atomic weight: ");
                    var atomFloatingPoint = Convert.ToSingle(Console.ReadLine());
                    Atom atom = new Atom();
                    if (atom.Accept(atomNumber, atomSymbol, atomFullName, atomFloatingPoint))
                    {
                        atoms.Add(atom);
                        if (atoms.Count > 10)
                        {
                            foreach (var t in atoms)
                            {
                                t.Display();
                            }
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter again.");
                    }        
                }
            }
        }
    }
}