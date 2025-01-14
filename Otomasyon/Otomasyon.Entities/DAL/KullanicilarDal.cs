using Otomasyon.Entities.Model;
using Otomasyon.Entities.Repository;
using Otomasyon.Entities.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Entities.DAL
{
   public class KullanicilarDal:EntityRepositoryBase<OtomasyonContext, Kullanicilar, KullanicilarValidator>
    {
    }
}
