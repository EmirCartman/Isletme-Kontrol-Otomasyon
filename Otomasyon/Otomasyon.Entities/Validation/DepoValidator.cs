using FluentValidation;
using Otomasyon.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Entities.Validation
{
   public class DepoValidator:AbstractValidator<Depo>
    {
        public DepoValidator()
        {

            RuleFor(p => p.DepoAdi).NotEmpty().WithMessage("Satış kodu alanı boş geçilemez. ");
            RuleFor(p => p.DepoAdi).MinimumLength(3).WithMessage("Menü Adı alanı en az 3 karakterden oluşmalıdır. ");

        }


    }
}
