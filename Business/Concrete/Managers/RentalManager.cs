using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete.Managers
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public void Add(Rental rental)
        {
            throw new NotImplementedException();
        }

        public void Delete(Rental rental)
        {
            throw new NotImplementedException();
        }

        public Rental GetRental(int id)
        {
            return _rentalDal.Get(x => x.RentID == id);

        }

        public List<Rental> GetRentals()
        {
            return _rentalDal.GetAll();
        }

        public List<Rental> GetRentalsByCar(int carId)
        {
            throw new NotImplementedException();
        }

        public List<Rental> GetRentalsByCustemerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public void Update(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
