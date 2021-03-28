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
        private IResult BaseProccess(int affectedRow, string messages)
        {
            if (affectedRow > 0)
            {
                return new SuccessResult(messages);
            }
            return new ErrorResult();
        }

        public IResult Add(Rental rental)
        {
            return BaseProccess(_rentalDal.Add(rental),Messages.Rental.RentalAdded);
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
