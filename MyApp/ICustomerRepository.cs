using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    public interface ICustomerRepository
    {
        public void Create(Customer customer);
    }
}
