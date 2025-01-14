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
    public class KullaniciHareketleriDal : EntityRepositoryBase<OtomasyonContext, KullaniciHareketleri, KullaniciHareketleriValidator>
    {
       // public static int kullaniciId { get; set; }
        public void KullaniciHareketleriEkle(OtomasyonContext context,KullaniciHareketleri kullaniciHareketleri,string aciklama)
        {
            KullaniciHareketleriDal kullaniciHareketleriDal = new KullaniciHareketleriDal();
            kullaniciHareketleri.Aciklama = aciklama;
            kullaniciHareketleri.Tarih = DateTime.Now;
            if (kullaniciHareketleriDal.AddOrUpdate(context, kullaniciHareketleri))
            {
                kullaniciHareketleriDal.Save(context);
            }
        }
    }
}
