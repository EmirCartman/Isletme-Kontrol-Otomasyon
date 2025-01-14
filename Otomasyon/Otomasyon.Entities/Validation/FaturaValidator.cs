using FluentValidation;
using Otomasyon.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Entities.Validation
{
    public class FaturaValidator : AbstractValidator<Fatura>
    {
        public FaturaValidator()
        {

            RuleFor(p => p.FaturaAdi).NotEmpty().WithMessage("Fatura alanı boş geçilemez. ");
            RuleFor(p => p.FaturaId).NotEmpty().WithMessage("Fatura alanı boş geçilemez. ");
            RuleFor(p => p.FaturaKodu).NotEmpty().WithMessage("Fatura kodu alanı boş geçilemez. ");
     
            RuleFor(p => p.BirimFiyati1).NotEmpty().WithMessage("BirimFiyati1 alanı boş geçilemez.");
            RuleFor(p => p.BirimFiyati2).NotEmpty().WithMessage("BirimFiyati2 boş geçilemez.");
            RuleFor(p => p.Aciklama).NotEmpty().WithMessage("BirimFiyati2 boş geçilemez.");

        }

    }
}
