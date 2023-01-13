using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    public class CustomerShippingCondition
    {
        public bool Check(Customer customer)
        {
            return customer.Addresses.Any() &&
                customer.Age > 21;
        }
    }
}
