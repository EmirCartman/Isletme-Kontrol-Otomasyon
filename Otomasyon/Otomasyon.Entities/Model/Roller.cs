using Otomasyon.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Entities.Model
{
    public class Roller : IEntity
    {
        public int Id { get; set; }

        public int KullaniciId { get; set; }

        public string FormName { get; set; }

        public string ControlName { get; set; }

        public string ControlCaption { get; set; } 

    }
}
