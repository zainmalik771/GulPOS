namespace BroxPOSBackend.Models
{
    public class Item
    {
        public int ItemId { get; set; }          // Unique identifier for the item
        public string ItemName { get; set; }     // Name of the item
        public decimal Price { get; set; }       // Price of the item
        public string Description { get; set; }   // Description of the item (optional)

        public int OrderId { get; set; } // Foreign key to Order
        public Order Order { get; set; } // Navigation property to Order
    }
}
