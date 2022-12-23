using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class Brand : BaseEntity
    {
        public string BrandName { get; set; }
        public List<Model> Models { get; set; }
        public List<Advert> Adverts { get; set; }
    }
}
