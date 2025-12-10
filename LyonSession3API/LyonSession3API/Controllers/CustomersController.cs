using LyonSession3API.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LyonSession3API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private BelleCroissantLyonnaisContext db = new BelleCroissantLyonnaisContext();

        [HttpGet]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return db.Customers;
        }

        [HttpGet("{id}")]
        public object GetCustomersById(int id)
        {
            try
            {
                var customer = db.Customers.Find(id);
                
                if (customer == null)
                {
                    throw new Exception();
                }

                return customer;
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(Customer customer, int id)
        {
            try
            {
                if (customer.CustomerId != id)
                {
                    throw new Exception();
                }

                if (!db.Customers.Any(c => c.CustomerId == id))
                {
                    return NotFound();
                }

                db.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
