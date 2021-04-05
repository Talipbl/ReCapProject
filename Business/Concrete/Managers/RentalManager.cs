using Business.Abstract;
using Business.Constants;
using Core.DataAccess;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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
        private IResult BaseProccess(bool state, string messages)
        {
            if (state)
            {
                return new SuccessResult(messages);
            }
            return new ErrorResult();
        }

        public IResult Add(Rental rental)
        {
            if (_rentalDal.Get(x => x.CarId == rental.CarId && x.ReturnDate == null) != null)
            {
                return BaseProccess(_rentalDal.Add(rental), Messages.Rental.RentalAdded);
            }
            return new ErrorResult();
        }
        public IResult Delete(Rental rental)
        {
            return BaseProccess(_rentalDal.Delete(rental), Messages.Rental.RentalDeleted);
        }

        public IDataResult<Rental> GetRental(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(x => x.RentID == id),Messages.Rental.RentalListed);
        }

        public IDataResult<List<RentalDTO>> GetRentals()
        {
            if (DateTime.Now.Hour == 19)
            {
                return new ErrorDataResult<List<RentalDTO>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<RentalDTO>>(_rentalDal.GetRentals(),Messages.Rental.RentalsListed);
        }

        public IDataResult<List<RentalDTO>> GetRentalsByCarId(int carId)
        {
            return new SuccessDataResult<List<RentalDTO>>(_rentalDal.GetRentalsByCarWithJoin(carId),Messages.Rental.RentalsListed);
        }

        public IDataResult<List<RentalDTO>> GetRentalsByUserId(int userId)
        {
            return new SuccessDataResult<List<RentalDTO>>(_rentalDal.GetRentalByUserWithJoin(userId), Messages.Rental.RentalsListed);
        }

        public IResult Update(Rental rental)
        {
            return BaseProccess(_rentalDal.Update(rental), Messages.Rental.RentalUpdated);
        }
    }
}
