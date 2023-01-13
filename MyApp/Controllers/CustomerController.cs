using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Controllers
{
    public class CustomerController
    {
        public ICustomerRepository Repository { get; }

        public CustomerController(
            ICustomerRepository repository)
        {
            Repository = repository;
        }

        public void CreateCustomer(CustomerDto dto)
        {
            if (dto.Photo != null)
                Repository.Create(dto.ToCustomer());
        }
    }
}
