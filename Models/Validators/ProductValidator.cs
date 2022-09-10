using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ÖrnekProje2.Models.Validators
{
    public class ProductValidator : AbstractValidator<Productz>
    {
/*
        abstract class ile ctorladığımız için startuptada girdiğimiz için sistem otomatik çağırıcak validasyonları.*/
        public ProductValidator()
        { /*
            fluent akıcı demek akıcı olması .lama ile fonksiyonları birleştirmesinden geliyor*/
            RuleFor(x => x.Email).NotNull().WithMessage("Email boş olamaz");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen Doğru bir email gir");
            RuleFor(x => x.ProductName).NotNull().NotEmpty().WithMessage("lütfen product name gir");
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage("100 den fazla karakter girme");
        }
    }
}
