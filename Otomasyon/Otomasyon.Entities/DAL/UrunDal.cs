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
   public class UrunDal: EntityRepositoryBase<OtomasyonContext, Urun, UrunValidator>
    {
        public object UrunListele(OtomasyonContext context)
        {
            var liste = (from u in context.Urun
                         select new
                         {
                             u.Id,
                             u.DepoId,
                             Depo = u.Depo.DepoAdi,
                             u.UrunKodu,
                             u.UrunAdi,
                             u.BirimFiyati1,
                             u.BirimFiyati2,
                             u.Aciklama,
                             u.Tarih

                          }).ToList();
            return liste;

        }

    }
}
