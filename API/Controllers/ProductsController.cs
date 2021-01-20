using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Shop()
        {
            //string fi = "only";
            //string final = "Are Left!!";
            //string final1 = "Out of STOCK!!!";
            var products = await _context.Product.OrderBy(d => d.ProductName).ToListAsync();
            
            return Ok(products);
        }
    }
}
