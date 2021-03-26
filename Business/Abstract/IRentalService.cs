using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Entities.Concrete.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<RentalDTO>> GetRentals();
        IDataResult<List<RentalDTO>> GetRentalsByUserId(int customerId);
        IDataResult<List<RentalDTO>> GetRentalsByCarId(int carId);
        IDataResult<Rental> GetRental(int id);
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
    }
}
