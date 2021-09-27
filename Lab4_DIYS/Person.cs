using System;
using System.Runtime.InteropServices;

namespace Lab4_DIYS
{
    public abstract class Person
    {
        protected string name;
        protected string phoneNumber;
        protected string email;

        public Person()
        {
        }

        public Person(string name, string phoneNumber, string email)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
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

        public string ToString()
        {
            return (nameof(GetType) + " " + name + " " + email);
        }
    }
}