using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ÖrnekProje2.Models.ModelMetaDataTypes
{
    public class ProductMMDT
    {
        /*
           VIEWMODEL
           ENTITY
           PRODUCTZ NESNESİ
           entity kısmında validation önerilmez
         */
        [Required(ErrorMessage = "ProductName Gir")]
        [StringLength(100, ErrorMessage = "maks. 100 karakter")]
        public string ProductName { get; set; }
        [EmailAddress(ErrorMessage = "Email gir")]
        public string Email { get; set; }
        /*[StringLength(11, ErrorMessage = "Doğru bir tc gir")]*/
        [RegularExpression(@".{10}", ErrorMessage = "{0} field must be 10 characters")]

        public int KeyN { get; set; }


    }
}
