namespace Lab4_DIYS
{
    public class Student : Person
    {
        protected string enrolled;

        public string Enrolled
        {
            get => enrolled;
            set => enrolled = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }
    }
}