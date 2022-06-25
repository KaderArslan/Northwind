using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class ProductSalesFor1997Repository : GenericRepository<ProductSalesFor1997>, IProductSalesFor1997Repository
    {
        public ProductSalesFor1997Repository(DbContext context) : base(context)
        {

        }

    }
}
