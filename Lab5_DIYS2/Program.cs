using System;

namespace Lab5_DIYS2
{
    internal class Program
    {
        class SeniorLecture
        {
            private string personName;
            private int salary;
            private int bonus;

            public string PersonName
            {
                get => personName;
                set => personName = value;
            }

            public int Salary
            {
                get => salary;
                set => salary = value;
            }

            public int Bonus
            {
                get => bonus;
                set => bonus = value;
            }
        }

        
    }
}