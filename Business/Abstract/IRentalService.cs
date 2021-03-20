using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        List<Rental> GetRentals();
        List<Rental> GetRentalsByCustemerId(int customerId);
        List<Rental> GetRentalsByCar(int carId);
        Rental GetRental(int id);

        void Add(Rental rental);
        void Delete(Rental rental);
        void Update(Rental rental);
    }
}
