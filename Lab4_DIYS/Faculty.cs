using System;

namespace Lab4_DIYS
{
    public class Faculty : Employee
    {
        protected double officeHours;
        protected string rank;

        public double OfficeHours
        {
            get => officeHours;
            set => officeHours = value;
        }

        public string Rank
        {
            get => rank;
            set => rank = value;
        }

        public string Department1
        {
            get => department;
            set => department = value;
        }

        public double Salary1
        {
            get => salary;
            set => salary = value;
        }

        public int DateHired1
        {
            get => dateHired;
            set => dateHired = value;
        }

        public string Name2
        {
            get => name;
            set => name = value;
        }

        public string PhoneNumber2
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public string Email2
        {
            get => email;
            set => email = value;
        }

        public override double CalculateBonus()
        {
            return 1000 * 0.05 * salary;
        }

        public override int CalculateVacation()
        {
            var vacation = 0;
            if (dateHired > 3)
            {
                vacation = 5;
                if (rank == "Senior Lecturer")
                {
                    vacation++;
                }
            }
            else
            {
                vacation = 4;
            }
            return vacation;
        }
    }
}