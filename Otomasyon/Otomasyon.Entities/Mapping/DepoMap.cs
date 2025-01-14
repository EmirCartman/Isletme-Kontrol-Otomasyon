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
    public class DepoMap: EntityTypeConfiguration<Depo>
    {

        public DepoMap()
        {
            this.ToTable("Depo");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.DepoAdi).HasColumnType("varchar").HasMaxLength(60);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(300);

            this.Property(p => p.Aciklama).HasColumnName("Description");

        }



    }
}