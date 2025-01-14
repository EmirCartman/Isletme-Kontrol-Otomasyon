using Otomasyon.Entities.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Entities.Mapping
{
   public class UrunMap:EntityTypeConfiguration<Urun>
    {
        public UrunMap()
        {
            this.ToTable("Urun");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.UrunKodu).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.UrunAdi).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(300);
            this.Property(p => p.BirimFiyati1).HasPrecision(28, 2);

            this.HasRequired(x => x.Depo).WithMany(x => x.Urun).HasForeignKey(x => x.DepoId);


        }




    }
}
