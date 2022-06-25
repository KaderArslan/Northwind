using Microsoft.AspNetCore.Http;
using Northwind.Dal.Abstract;
using Northwind.Entity.Base;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Bll
{
    public class ProductSalesFor1997Manager : GenericManager<ProductSalesFor1997, DtoProductSalesFor1997>, IProductSalesFor1997Service
    {
        public readonly IProductSalesFor1997Repository productSalesFor1997Repository;

        public ProductSalesFor1997Manager(IServiceProvider service) : base(service)
        {
            productSalesFor1997Repository = service.GetService<IProductSalesFor1997Repository>();
        }

    }
}
