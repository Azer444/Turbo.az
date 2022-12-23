using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class Body : BaseEntity
    {
        public string BodyName { get; set; }
        public List<Advert> Adverts { get; set; }
    }
}
