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
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }

        public User Login(User login)
        {
            //SingleOrDefault herhangi bir veri yoksa null donderir
            //tekil veri girecegimizi on kosul koyuyorsak bu ideal yontem, hic veride olmasa null donderir, 
            //coklu veri gelirse hata verir o zamanda veritabanindan veriyi cozmek gerek 
            var user = dbset.Where(x => x.UserCode == login.UserCode && x.Password == login.Password).SingleOrDefault();

            //FirstOrDefault coklu gelebilir hicte gelmeyebilir, hic gelmeyen bir seyin firstunu alamayiz
            //gelen verinin ilkini al ya da boşsa default donder
            //var user = dbset.FirstOrDefault(x=>x.EmployeeEmail == login.EmployeeEmail && x.EmployeePassword == login.EmployeePassword);

            //tek al ya da boş gonder
            //var user = dbset.SingleOrDefault(x=>x.EmployeeEmail == login.EmployeeEmail && x.EmployeePassword == login.EmployeePassword);
            return user;
        }

    }
}
