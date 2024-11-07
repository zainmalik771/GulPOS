namespace BroxPOSBackend.Models
{
    public class Order
    {
        public int OrderId { get; set; }                 // Unique identifier for the order
        public string OrderType { get; set; }             // Type of item ordered (e.g., Burger, Fries)
        public decimal Amount { get; set; }               // Total amount of the order
        public string Status { get; set; }                // Current status of the order (e.g., Pending, Completed)
        public DateTime OrderDate { get; set; }           // Date and time when the order was placed
        public string CustomerName { get; set; }          // Name of the customer
        public string OrderMethod { get; set; }           // Method of order (e.g., Dine-in, Takeaway, Delivery)
        public string Notes { get; set; }                 // Any special notes for the order
        public List<Item> Items { get; set; }

        public Order()
        {
            Items = new List<Item>(); // Initialize the items list
        }
    }
}
