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
        private IResult BaseProccess(int effectedRow, string messages)
        {
            if (effectedRow > 0)
            {
                return new SuccessResult(messages);
            }
            return new ErrorResult();
        }

        public IResult Add(Rental rental)
        {
            return BaseProccess(_rentalDal.Add(rental),Messages.RentalAdded);
        }
        public IResult Delete(Rental rental)
        {
            return BaseProccess(_rentalDal.Delete(rental), Messages.RentalDeleted);
        }

        public Rental GetRental(int id)
        {
            return _rentalDal.Get(x => x.RentID == id);

        }

        public List<RentalDTO> GetRentals()
        {
            return _rentalDal.GetRentals();
        }

        public List<RentalDTO> GetRentalsByCarId(int carId)
        {
            return _rentalDal.GetRentalsByCarWithJoin(carId);
        }

        public List<RentalDTO> GetRentalsByUserId(int userId)
        {
            return new List<RentalDTO>();
        }

        public IResult Update(Rental rental)
        {
            return BaseProccess(_rentalDal.Update(rental), Messages.RentalUpdated);
        }
    }
}
