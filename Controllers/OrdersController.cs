using BroxPOSBackend.DatabseContext;
using BroxPOSBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic; // Don't forget this for List<T>

namespace BroxPOSBackend.Controllers
{
    [ApiController] // This attribute makes it an API controller
    [Route("api/[controller]")] // This attribute sets the route for the controller
    public class OrdersController : ControllerBase
    {
        private readonly BroxPOSDbContext _context; // Your DB context

        public OrdersController(BroxPOSDbContext context)
        {
            _context = context; // Initialize the context
        }

        // GET: api/GetOrders
        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var orders = await _context.Orders.ToListAsync(); // Assuming you have a DbSet<Order> Orders

            return Ok(orders);
        }

        // POST: api/orders
        [HttpPost]
        public async Task<IActionResult> CreateOrder(Order order)
        {
            _context.Orders.Add(order); // Add the order to the context
            await _context.SaveChangesAsync(); // Save changes to the database

            return CreatedAtAction(nameof(GetOrders), new { id = order.OrderId }, order); // Return created order
        }

        [HttpPatch("{id}/status")]
        public async Task<IActionResult> UpdateOrderStatus(int id, [FromBody] string status)
        {
            // Your logic to update order status
            return NoContent();
        }
    }
}
