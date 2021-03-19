using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfBookingDal:EfEntityRepositoryBase<Booking,ReCapContext>,IBookingDal
    {
        //this area include booking special process
    }
}
