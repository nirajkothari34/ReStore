using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[api/Controller]")]
    public class ProductCotrollers : ControllerBase 
    {

        private readonly StoreContext _Context;

        public ProductCotrollers(StoreContext Context)
        {
            _Context = Context;

            
        }
        [HttpGet]
        public async Task <ActionResult<List<Product>>>GetProducts()
        {
           return await _Context.Products.ToListAsync();
           
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>>GetProducts(int id)
        {
            return await _Context.Products.FindAsync(id);
        }

    }
}