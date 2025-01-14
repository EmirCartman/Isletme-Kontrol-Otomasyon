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
   
    public class Depo : IEntity
    {
       
        public int Id { get; set; }

       
        public string DepoAdi { get; set; }

        
        public string Aciklama { get; set; }

        public ICollection<Urun> Urun { get; set; }
 
    }
}
