using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Rental :IEntity
    {
        [Key]
        public int RentID { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual User User { get; set; }
        public virtual Car Car { get; set; }
    }
}
