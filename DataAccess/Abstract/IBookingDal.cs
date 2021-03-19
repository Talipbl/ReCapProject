using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBookingDal:IEntityRepository<Booking>
    {
        //this area include booking special process
    }
}
