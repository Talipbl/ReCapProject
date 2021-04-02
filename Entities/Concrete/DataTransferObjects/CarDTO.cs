using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.DataTransferObjects
{
    public class CarDTO
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
