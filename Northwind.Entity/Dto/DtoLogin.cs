using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Dto
{
    public class DtoLogin : DtoBase
    {
        [Required(ErrorMessage = "Kullanıcı kodu boş bırakılamaz.")] //zorunlu
        [StringLength(maximumLength: 40)]//uzunlugunu da belirtebilirsin
        [DataType(DataType.Text)]
        public string UserCode { get; set; }

        [Required(ErrorMessage = "Parola alanı boş bırakılamaz!")]
        [StringLength(maximumLength: 12)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //bu parolayı alip sifrelicegiz, logine parametre gonderecegiz
    }
}
