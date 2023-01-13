using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Controllers
{
    public class OrderController
    {
        public IOrderRepository Repository { get; }

        public OrderController(
            IOrderRepository repository)
        {
            Repository = repository;
        }

        public void CreateOrder(OrderDto dto)
        {
            Repository.Create(dto.ToOrder());
        }
    }
}
