using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class Year : BaseEntity
    {
        public int YearName { get; set; }
        public List<Advert> Adverts { get; set; }
    }
}
