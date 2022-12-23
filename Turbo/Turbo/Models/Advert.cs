using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class Advert : BaseEntity
    {
        public int CityId { get; set; }
        public City City { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int ModelId { get; set; }
        public Model Model { get; set; }

        public int BodyId { get; set; }
        public Body Body { get; set; }

        public int ColorId { get; set; }
        public Color Color { get; set; }

      
        public int FuelId { get; set; }
        public Fuel Fuel { get; set; }

        public int GearId { get; set; }
        public Gear Gear { get; set; }

        public int? EngineId { get; set; }
        public Engine Engine { get; set; }

        public int YearId { get; set; }
        public Year Year { get; set; }

        //public virtual ICollection<Image> Images { get; set; }

        public double Price { get; set; }
        public int Hp { get; set; }
        public int Walk { get; set; }
        public bool Credit { get; set; }
        public bool Barter { get; set; }
        public string Desc { get; set; }
        public bool CentralClosure { get; set; }
        public bool LeatherSalon { get; set; }
        public bool SeatVent { get; set; }
        public bool Abs { get; set; }
        public bool ParkRadar { get; set; }
        public bool XenonLamps { get; set; }
        public bool Lyuk { get; set; }
        public bool Conditioner { get; set; }
        public bool RearCamera { get; set; }
        public bool RainSensor { get; set; }
        public bool SeatHeating { get; set; }
        public bool SideCurtains { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
