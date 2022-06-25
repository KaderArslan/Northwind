using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Dal.Abstract
{
    public interface IUserRepository
    {
        //bana user dondurur
        User Login(User login);
    }
}
