using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Dto
{
    public class DtoLoginUser : DtoBase
    {
        //tokena gommeden ek bilgi olarak geri gonderme
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public ClaimsIdentity UserCode { get; set; }
    }
}
