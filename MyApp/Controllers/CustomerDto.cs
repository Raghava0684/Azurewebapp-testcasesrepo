using Microsoft.AspNetCore.Http;
using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Controllers
{
    public class CustomerDto
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public IFormFile Photo { get; set; }

        internal Customer ToCustomer()
        {
            return new Customer(
                FirstName,
                LastName,
                MiddleName,
                Age,
                new List<Address>());
        }
    }
}
