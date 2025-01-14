using Otomasyon.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Entities.Model
{
    public class OdemeHareketleri : IEntity
    {

        public int Id { get; set; }

        public string SatisKodu { get; set; }

        public string OdemeTuru { get; set; }

        public decimal Odenen { get; set; }

        public string Aciklama { get; set; }

        public DateTime Tarih { get; set; }
    }
}
