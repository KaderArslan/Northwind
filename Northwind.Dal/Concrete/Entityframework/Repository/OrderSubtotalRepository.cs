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
    public class OrderSubtotalRepository : GenericRepository<OrderSubtotal>, IOrderSubtotalRepository
    {
        public OrderSubtotalRepository(DbContext context) : base(context)
        {

        }

    }
}
