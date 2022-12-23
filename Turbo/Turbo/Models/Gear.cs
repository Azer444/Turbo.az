using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class Gear : BaseEntity
    {
        public string GearName { get; set; }
        public List<Advert> Adverts { get; set; }
    }
}
