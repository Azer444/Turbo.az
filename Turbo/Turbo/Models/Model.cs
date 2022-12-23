using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class Model : BaseEntity
    {
        public string ModelName { get; set; }
        public Brand Brand { get; set; }
        public Advert Advert { get; set; }
    }
}
