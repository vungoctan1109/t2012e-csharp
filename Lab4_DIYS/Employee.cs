namespace Lab4_DIYS
{
    public abstract class Employee : Person
    {
        protected string department;
        protected double salary;
        protected int dateHired;

        public string Department
        {
            get => department;
            set => department = value;
        }

        public double Salary
        {
            get => salary;
            set => salary = value;
        }

        public int DateHired
        {
            get => dateHired;
            set => dateHired = value;
        }

        public string Name1
        {
            get => name;
            set => name = value;
        }

        public string PhoneNumber1
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public string Email1
        {
            get => email;
            set => email = value;
        }

        public abstract double CalculateBonus();
        public abstract  int CalculateVacation();
    }
}