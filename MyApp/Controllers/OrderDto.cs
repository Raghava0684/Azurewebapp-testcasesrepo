using MyApp.Models;

namespace MyApp.Controllers
{
    public class OrderDto
    {
        public string CustomerName { get; set; }
        public object ToOrder()
        {
            return new Order(CustomerName); 
        }
    }
}