using Otomasyon.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Entities.Model
{
    public class Fatura : IEntity
    {
        public int Id { get; set; }


        public int FaturaId { get; set; }


        public string FaturaKodu { get; set; }

        public string FaturaAdi { get; set; }

        public decimal BirimFiyati1 { get; set; }

        public decimal BirimFiyati2 { get; set; }

        public string Aciklama { get; set; }

        public DateTime Tarih { get; set; }



    }
}
