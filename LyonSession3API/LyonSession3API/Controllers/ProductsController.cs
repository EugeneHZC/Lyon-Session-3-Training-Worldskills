using LyonSession3API.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace LyonSession3API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private BelleCroissantLyonnaisContext db = new BelleCroissantLyonnaisContext();

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return db.Products;
        }

        [HttpGet("{id}")]
        public object GetProductById(int id)
        {
            try
            {
                var product = db.Products.Find(id);

                if (product == null)
                {
                    throw new Exception();
                }

                return product;
            } 
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            try
            {
                db.Products.Add(product);
                db.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(Product product, int id)
        {
            try
            {
                if (product.ProductId != id)
                {
                    throw new Exception();
                }

                if (!db.Products.Any(p => p.ProductId == id))
                {
                    return NotFound();
                }

                db.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                var product = db.Products.Find(id);

                if (product == null)
                {
                    return NotFound();
                }

                db.Products.Remove(product);
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
