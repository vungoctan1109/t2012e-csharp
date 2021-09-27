namespace Lab4_DIYS
{
    public class Staff : Employee
    {
        protected string title;

        public string Title
        {
            get => title;
            set => title = value;
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
            return 0.06 * salary;
        }

        public override int CalculateVacation()
        {
            var vacation = 0;
            vacation = dateHired >= 5 ? 4 : 3;
            return vacation;
        }
    }
}