using EStore.Web.ProductAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EStore.Web.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductContext _dbContext;
       public ProductsController(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }


        // GET: api/products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {

            if(_dbContext.Products == null) { return NotFound(); }

            return await _dbContext.Products.ToListAsync();

            
        }

        // GET: api/products/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {

            if (_dbContext.Products == null) { return NotFound(); }

            var product = await _dbContext.Products.FindAsync(id);

            if(product == null) { return NotFound(); };

            return product;
        }

        // POST: api/products/1
        [HttpPost]

        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            _dbContext.Products.Add(product);  
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProductById), new {id = product.Id}, product);
        }


        // PUT : api/products/1
       /*   [HttpPut("{id}")]
        public async Task<ActionResult<Product>> UpdateProductById(int id)
          {
              if()
          } */

        // to check availability of a product 
       /* public bool isProductAvailable(int id)
        {
            return (_dbContext.Products?.Any(x => x.Id == id)).GetValueOrDefault();
        } */


        // DELETE : api/products/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductById(int id)
        {

            var product =await _dbContext.Products.FindAsync(id);

            if(product == null) { return NotFound(); }
            
                _dbContext.Products.Remove(product);
                await _dbContext.SaveChangesAsync();

            return Ok();

        }

    }

}
