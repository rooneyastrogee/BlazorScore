using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Score.BusinessLogic.Services;
using Stripe;

namespace Score.API.Controllers


{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService = null;

        public ProductController(IProductService _productService)
        {
            this._productService = _productService;
        }
         
        [HttpGet]
        [Route("getProducts")]
        public IActionResult getProducts()
        {

            var data = _productService.getProducts();
            return Ok(data);

        }
            
    }
}
