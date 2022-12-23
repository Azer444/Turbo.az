using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class Fuel : BaseEntity
    {
        public string FuelName { get; set; }
        public List<Advert> Adverts { get; set; }
    }
}
