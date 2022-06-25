using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Base;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;
using Northwind.WebApi.Base;
using System;
using System.Linq;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ApiBaseController<IProductService, Product, DtoProduct>
    {
        private readonly IProductService productService;
        public ProductController(IProductService productService) : base(productService)
        {
            this.productService = productService;
        }

    }
}
