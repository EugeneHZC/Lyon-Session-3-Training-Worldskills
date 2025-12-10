using LyonSession3API.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LyonSession3API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private BelleCroissantLyonnaisContext db = new BelleCroissantLyonnaisContext();

        [HttpGet]
        public IEnumerable<Order> GetAllOrders()
        {
            return db.Orders
                .Include(o => o.Customer)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product);
        }

        [HttpGet("customer/{id}")]
        public IEnumerable<Order> GetAllOrdersByCustomerId(int id)
        {
            return db.Orders
                .Include(o => o.OrderItems)
                .Where(o => o.CustomerId == id);
        }

        [HttpGet("{id}")]
        public object GetOrderById(int id)
        {
            try
            {
                var order = db.Orders
                    .Include(o => o.Customer)
                    .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Product)
                    .FirstOrDefault(o => o.TransactionId == id) ?? throw new Exception();
                return order;
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            try
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}/{status}")]
        public IActionResult CompleteOrder(int id, string status)
        {
            try
            {
                var order = db.Orders.Find(id);

                if (order == null)
                {
                    return NotFound();
                }

                switch (status)
                {
                    case "complete":
                        order.Status = "Completed";
                        break;
                    case "cancel":
                        order.Status = "Cancelled";
                        break;
                    case "processing":
                        order.Status = "Processing";
                        break;
                    case "pending":
                        order.Status = "Pending";
                        break;
                    default:
                        throw new Exception();
                }
                
                db.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
