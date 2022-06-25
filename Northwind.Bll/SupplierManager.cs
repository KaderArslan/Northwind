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
    public class SupplierManager : GenericManager<Supplier, DtoSupplier>, ISupplierService
    {
        public readonly ISupplierRepository supplierRepository;

        public SupplierManager(IServiceProvider service) : base(service)
        {
            supplierRepository = service.GetService<ISupplierRepository>();
        }

    }
}
