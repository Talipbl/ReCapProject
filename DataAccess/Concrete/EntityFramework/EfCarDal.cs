using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DataTransferObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {

        private static List<CarDTO> GetCarsWithJoin(ReCapContext context)
        {
            return context.Cars.Include("Brand").Include("Color").Select(x => new CarDTO
            {
                CarID = x.CarID,
                BrandName = x.Brand.BrandName,
                CarName = x.CarName,
                ColorName = x.Color.ColorName,
                DailyPrice = x.DailyPrice
            }).ToList();

            //return from c in context.Cars
            //       join b in context.Brands on c.BrandId equals b.BrandID
            //       join cl in context.Colors on c.ColorId equals cl.ColorID

            //       select new CarDTO
            //       {
            //           BrandName = b.BrandName,
            //           CarName = c.CarName,
            //           DailyPrice = c.DailyPrice
            //       };
        }

        public List<CarDTO> GetCarsWithJoin()
        {
            using (ReCapContext context = new ReCapContext())
            {
                return GetCarsWithJoin(context);

                //return GetCarsWithJoin(context).ToList();
            }
        }
    }
}
