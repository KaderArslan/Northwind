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
    public class OrderManager : GenericManager<Order, DtoOrder>, IOrderService
    {
        public readonly IOrderRepository orderRepository;

        public OrderManager(IServiceProvider service) : base(service)
        {
            orderRepository = service.GetService<IOrderRepository>();
        }

    }
}
