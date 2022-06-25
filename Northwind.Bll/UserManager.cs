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
using Microsoft.Extensions.Configuration;

namespace Northwind.Bll
{
    public class UserManager : GenericManager<User, DtoUser>, IUserService
    {
        //Dal'la haberlesmiyor
        //IEmployeeRepository i dahil edecegiz
        public readonly IUserRepository userRepository;
        private IConfiguration configuration;

        public UserManager(IServiceProvider service, IConfiguration configuration) : base(service) //al sen bunu ust sinifa gonder
        {
            userRepository = service.GetService<IUserRepository>();
            this.configuration = configuration;
        }

        //token olusturma kontrol islemleri hep burda olacak 
        //DtoLogin bunda email ve parola tek var ya da yetki
        public IResponse<DtoUserToken> Login(DtoLogin login)
        {
            //Employee ye donusturecegiz neyi login datasini
            var user = userRepository.Login(ObjectMapper.Mapper.Map<User>(login));
            //employee ya bilgi gelecek ya da null gelecek
            if (user != null)//veri yani employee vardir
            {
                //employee var ise token uretmem gerekiyor, Bllîn altina yazdim metodunu TokenManager
                //TokenManageri ilgili parametreyi gonderecem, benim icin token uretecek ve buraya gonderecek
                //response geri donecek

                //DtoLoginEmployee donustur
                var dtoUser = ObjectMapper.Mapper.Map<DtoLoginUser>(user);
                //token tokenmanagerdan gelecek
                //token managera ben dtoEmploye yi gonderecem o ilgili tokeni uretip bana gonderecek
                //token oluşturuldu
                var token = new TokenManager(configuration).CreateAccessToken(dtoUser);

                var userToken = new DtoUserToken()
                {
                    DtoLoginUser = dtoUser,
                    //oluşturulan token access tokene verildi
                    AccessToken = token
                };
                return new Response<DtoUserToken>
                {
                    Message = "Token üretildi.",
                    StatusCode = StatusCodes.Status200OK,
                    Data = userToken
                };
            }
            else
            {
                return new Response<DtoUserToken>
                {
                    Message = "Kullanıcı maili ya da parolanız yanlış!",
                    StatusCode = StatusCodes.Status406NotAcceptable,
                    Data = null
                };
            }
        }
    }
}
