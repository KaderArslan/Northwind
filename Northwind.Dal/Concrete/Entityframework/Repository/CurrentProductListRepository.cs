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
    public class CurrentProductListRepository : GenericRepository<CurrentProductList>, ICurrentProductListRepository
    {
        public CurrentProductListRepository(DbContext context) : base(context)
        {

        }

    }
}
