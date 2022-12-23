using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class Engine : BaseEntity
    {
        public double EngineVolumeName { get; set; }
        public List<Advert> Adverts { get; set; }
    }
}
