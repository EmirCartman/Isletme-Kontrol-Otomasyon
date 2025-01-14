using Otomasyon.Entities.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Entities.Model
{
   
    public class Satislar : IEntity
    {

        public int Id { get; set; }

        public string SatisKodu { get; set; }

        public decimal Tutar { get; set; }

        public decimal Odenen { get; set; }

        public decimal Kalan { get; set; }

        public string Aciklama { get; set; }

        public DateTime SonIslemTarihi { get; set; }
    }
}
