using Otomasyon.Entities.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Entities.Model
{
    public class OtomasyonContext:DbContext
    {
        public OtomasyonContext() : base("Data Source=CARTMAN;Initial Catalog=Otomasyon;Integrated Security=True")
        {


        }

        public DbSet<Depo> Depo { get; set; }

        public DbSet<Urun> Urun { get; set; }

        public DbSet<Kullanicilar> Kullanicilar { get; set; }

        public DbSet<KullaniciHareketleri> KullaniciHareketleri { get; set; }

        public DbSet<Satislar> Satislar { get; set; }

        public DbSet<Roller> Roller { get; set; }

        public DbSet<Fatura> Fatura { get; set; }


        public DbSet<OdemeHareketleri> OdemeHareketleri { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new KullaniciHareketleriMap());
            modelBuilder.Configurations.Add(new KullanicilarMap());
            modelBuilder.Configurations.Add(new OdemeHareketleriMap());
            modelBuilder.Configurations.Add(new RollerMap());
            modelBuilder.Configurations.Add(new SatislarMap());
            modelBuilder.Configurations.Add(new UrunMap());
            modelBuilder.Configurations.Add(new DepoMap());
            modelBuilder.Configurations.Add(new FaturaMap());



        }






    }

   




}
