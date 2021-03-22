using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRentalDal:IEntityRepository<Rental>
    {
        //this area include Rental special process
        List<Rental> GetRentalsWithJoin(Expression<Func<Rental, bool>> filter = null);

    }
}
