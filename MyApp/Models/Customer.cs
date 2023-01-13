using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class Customer
    {
        public Customer(
            string firstName, string lastName, string middleName,
            int age, List<Address> addresses)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            MiddleName = middleName ?? throw new ArgumentNullException(nameof(middleName));
            Age = age;
            Addresses = addresses ?? throw new ArgumentNullException(nameof(addresses));
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {MiddleName} {LastName}"; } }
        public int Age { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
