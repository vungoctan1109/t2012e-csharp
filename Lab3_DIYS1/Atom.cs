using System;

namespace Lab3_DIYS1
{
    public class Atom
    {
        private int atomNumber;
        private string atomSymbol;
        private string atomFullName;
        private float atomFloatingPoint;

        public bool Accept(int atomNumber, string atomSymbol, string atomFullName, float atomFloatingPoint)
        {
            if (atomNumber > 118)
            {
                Console.WriteLine("Invalid atomic number.");
                return false;
            }

            if (atomSymbol.Length > 2)
            {
                Console.WriteLine("Invalid atomic Symbol.");
                return false;
            }
            
            this.atomNumber = atomNumber;
            this.atomSymbol = atomSymbol;
            this.atomFullName = atomFullName;
            this.atomFloatingPoint = atomFloatingPoint;
            return true;
        }

        public void Display()
        {
            Console.WriteLine(this.atomNumber + " " +
                              this.atomSymbol + " " +
                              this.atomFullName + " " +
                              this.atomFloatingPoint);
        }
    }
}