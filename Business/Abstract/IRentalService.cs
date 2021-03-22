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
        List<RentalDTO> GetRentalsByCar(int carId);
        Rental GetRental(int id);

        void Add(Rental rental);
        void Delete(Rental rental);
        void Update(Rental rental);
    }
}
