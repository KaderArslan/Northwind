using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Dto
{
    public class DtoCategorySalesFor1997 : DtoBase
    {
        public string CategoryName { get; set; }
        public decimal? CategorySales { get; set; }
    }
}
