using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;

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
            _rentalDal.Add(rental);
        }

        public void Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
        }

        public Rental GetRental(int id)
        {
            return _rentalDal.Get(x => x.RentID == id);

        }

        public List<RentalDTO> GetRentals()
        {
            //return _rentalDal.GetAll();
            return _rentalDal.GetRentalsByCarWithJoin();
        }

        public List<RentalDTO> GetRentalsByCar(int carId)
        {
            //return _rentalDal.GetRentalsWithJoin(c => c.CarId == carId).Select(x => new RentalDTO
            //{
            //    RentID = x.RentID,
            //    CarId = x.CarId,
            //    UserId = x.UserId,
            //    CarName = x.Car.CarName,
            //    BrandName = x.Car.Brand.BrandName,
            //    FirstName = x.User.FirstName,
            //    LastName = x.User.LastName,
            //    RentDate = x.RentDate,
            //    ReturnDate = x.ReturnDate,
            //    TotalPrice = (decimal)x.TotalPrice
            //}).ToList();
            return new List<RentalDTO>();
        }

        public List<RentalDTO> GetRentalsByUserId(int userId)
        {
            //var result = _rentalDal.GetRentalsWithJoin().Select(x => new RentalDTO
            //{
            //    RentID = x.RentID,
            //    CarId = x.CarId,
            //    UserId = x.UserId,
            //    CarName = x.Car.CarName,
            //    BrandName = x.Car.Brand.BrandName,
            //    FirstName = x.User.FirstName,
            //    LastName = x.User.LastName,
            //    RentDate = x.RentDate,
            //    ReturnDate = x.ReturnDate,
            //    TotalPrice = (decimal)x.TotalPrice
            //}).ToList();

            //return result;
            return new List<RentalDTO>();

        }

        public void Update(Rental rental)
        {
            _rentalDal.Update(rental);
        }
    }
}
