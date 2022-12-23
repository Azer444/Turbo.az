using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class City : BaseEntity
    {
        public string CityName { get; set; }
        public List<Advert> Adverts { get; set; }
    }
}
