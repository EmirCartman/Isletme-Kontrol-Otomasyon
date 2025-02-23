﻿using Otomasyon.Entities.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Entities.Mapping
{
   public class SatislarMap: EntityTypeConfiguration<Satislar>
    {
        public SatislarMap()
        {
            this.ToTable("Satislar");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SatisKodu).HasColumnType("varchar").HasMaxLength(60);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(300);



        }
    }
}
