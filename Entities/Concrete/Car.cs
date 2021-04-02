using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class Car :IEntity
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        [ForeignKey("BrandId")]
        public int BrandId { get; set; }
        [ForeignKey("ColorId")]
        public int ColorId { get; set; }
        public int? ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

        public virtual Brand Brand{ get; set; }
        public virtual Color Color { get; set; }


    }
}
