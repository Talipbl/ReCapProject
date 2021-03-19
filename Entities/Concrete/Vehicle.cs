using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Vehicle :IEntity
    {
        public int VehicleID { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public decimal DailyPrice { get; set; }
        public short Amount { get; set; }

        public virtual Brand Brand{ get; set; }
        public virtual Color Color { get; set; }


    }
}
