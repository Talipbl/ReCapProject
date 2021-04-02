using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Concrete.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetCars();
        IDataResult<Car> GetCarById(int carId);
        IDataResult<List<CarDTO>> GetCarsWithJoin();
    }
}
