using System;
using System.Collections.Generic;
using System.Text;

namespace PolyPayroll
{
    public abstract class Employee :iPayable
    {
        public string FirstName { get; }
        public string LastName { get;}
        public string SocialSecurityNumber { get; }

        public Employee(string firstName, string lastName, string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }
        public override string ToString() => $"{FirstName} {LastName}\n" + $"Social Security Number: {SocialSecurityNumber}";
        public abstract decimal Earnings();
        public decimal GetPaymentAmount() => Earnings();
    }
}
