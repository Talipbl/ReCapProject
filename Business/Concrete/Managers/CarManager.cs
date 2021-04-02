using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete.Managers
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        private IResult BaseProccess(bool state, string message=null)
        {
            if (state)
            {
                return new SuccessResult(message);
            }
            return new ErrorResult();
        }

        public IResult Add(Car car)
        {
            return BaseProccess(_carDal.Add(car));
        }

        public IResult Delete(Car car)
        {
            return BaseProccess(_carDal.Delete(car));
        }

        public IDataResult<Car> GetCarById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(x => x.CarID == carId));
        }

        public IDataResult<List<Car>> GetCars()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<CarDTO>> GetCarsWithJoin()
        {
            return new SuccessDataResult<List<CarDTO>>(_carDal.GetCarsWithJoin());
        }

        public IResult Update(Car car)
        {
            return BaseProccess(_carDal.Update(car));
        }
    }
}
