using Otomasyon.Entities.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Entities.Model
{
    
    public class Urun:IEntity
    {
       
        public int Id { get; set; }

       
        public int DepoId { get; set; }

      
        public string UrunKodu { get; set; } 

        public string UrunAdi { get; set; }

        public decimal BirimFiyati1 { get; set; }

        public decimal BirimFiyati2 { get; set; }

        public string Aciklama { get; set; }

        public DateTime Tarih { get; set; }

        public  Depo Depo { get; set; }
    }
}
