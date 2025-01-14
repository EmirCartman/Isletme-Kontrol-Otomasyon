using FluentValidation;
using Otomasyon.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Entities.Validation
{
   public class KullanicilarValidator:AbstractValidator<Kullanicilar>
    {
        public KullanicilarValidator()
        {
            RuleFor(p => p.AdSoyad).NotEmpty().WithMessage("Ad Soyad alanı boş geçilemez.");
            RuleFor(p => p.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı Adı alanı boş geçilemez.");
            RuleFor(p => p.Parola).NotEmpty().WithMessage("Parola alanı boş geçilemez.");
            RuleFor(p => p.Telefon).NotEmpty().WithMessage("Telefon alanı boş geçilemez.");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email alanı boş geçilemez.");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Yanlış Email adres formatı.");
        }

    }
}
