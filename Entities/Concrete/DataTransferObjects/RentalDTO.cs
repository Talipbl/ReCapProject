using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.DataTransferObjects
{
    public class RentalDTO
    {
        public int RentID { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}
