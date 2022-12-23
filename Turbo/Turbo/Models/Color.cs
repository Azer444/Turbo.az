using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class Color : BaseEntity
    {
        public string ColorName { get; set; }
        public List<Advert> Adverts { get; set; }
    }
}
