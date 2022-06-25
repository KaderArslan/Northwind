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
    public class SalesByCategoryRepository : GenericRepository<SalesByCategory>, ISalesByCategoryRepository
    {
        public SalesByCategoryRepository(DbContext context) : base(context)
        {

        }

    }
}
