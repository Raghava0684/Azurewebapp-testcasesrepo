namespace MyApp.Models
{
    public class Order
    {
        public Order(string customerName)
        {
            CustomerName = customerName;
        }

        public string CustomerName { get; private set; }
    }
}
