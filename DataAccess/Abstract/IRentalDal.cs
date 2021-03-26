using Core.DataAccess;
using Entities.Concrete;
using Entities.Concrete.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRentalDal:IEntityRepository<Rental>
    {
        //this area include Rental special process
        List<RentalDTO> GetRentalsByCarWithJoin(int carId);
        List<RentalDTO> GetRentalByUserWithJoin(int userId);
        List<RentalDTO> GetRentals();
    }
}
