using FluentValidation;
using Otomasyon.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Entities.Validation
{
   public class UrunValidator:AbstractValidator<Urun>
    {
        public UrunValidator()
        {

            RuleFor(p => p.UrunKodu).NotEmpty().WithMessage("Ürün kodu alanı boş geçilemez.");
            RuleFor(p => p.UrunAdi).NotEmpty().WithMessage("Ürün adı alanı boş geçilemez.");
            

            RuleFor(p => p.BirimFiyati1).NotEmpty().WithMessage("BirimFiyati1 alanı boş geçilemez.");
            RuleFor(p => p.BirimFiyati2).NotEmpty().WithMessage("BirimFiyati2 boş geçilemez.");
            
        }
    }
}
