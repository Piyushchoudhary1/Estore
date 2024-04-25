using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace EStore.Web.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly string connectionString;
       public ProductsController(IConfiguration configuration)
        {
            connectionString = configuration["ConnectionStrings:DefaultConnection"] ?? "";
        }
        

        // POST: api/products/1
     /*   public IActionResult CreateProduct(ProductDto productDto) {

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO Products" + "(Name, Price, Description, Image)" + "(@Name, @Price, @Description, @Image)";

                    using (var command = new SqlCommand(sql, connection)) {

                        command.Parameters.AddWithValue("@Name", ProductDto.Name);
                        command.Parameters.AddWithValue("@Price", ProductDto.Price);
                        command.Parameters.AddWithValue("@Description", ProductDto.Description);
                        command.Parameters.AddWithValue("@Image", ProductDto.Image);
                    
                        command.ExecuteNonQuery();
                    }
                }
            } catch (Exception ex) {

                ModelState.AddModelError("Product", "Sorry, but we have an exception");          
                return BadRequest(ModelState);
            }

            return Ok();
        
        } */

    }

}
