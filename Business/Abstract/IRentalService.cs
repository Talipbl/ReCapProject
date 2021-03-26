using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Concrete.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        List<RentalDTO> GetRentals();
        List<RentalDTO> GetRentalsByUserId(int customerId);
        List<RentalDTO> GetRentalsByCarId(int carId);
        Rental GetRental(int id);
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
    }
}
