using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.DataTransferObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        //this area include Rental special process

        private static IQueryable<RentalDTO> GetRentalsWithJoin(ReCapContext context)
        {
            return from r in context.Rentals
                   join p in context.Cars on r.CarId equals p.CarID
                   join u in context.Users on r.UserId equals u.UserID

                   select new RentalDTO
                   {
                       RentID = r.RentID,
                       CarId = r.CarId,
                       UserId = r.UserId,
                       FirstName = u.FirstName,
                       LastName = u.LastName,
                       BrandName = p.Brand.BrandName,
                       CarName = p.CarName,
                       RentDate = r.RentDate,
                       ReturnDate = (DateTime)r.ReturnDate,
                       TotalPrice = (decimal)r.TotalPrice
                   };
        }

        public List<RentalDTO> GetRentalsByCarWithJoin(int carId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                IQueryable<RentalDTO> result = GetRentalsWithJoin(context).Where(x => x.CarId == carId);
                return result.ToList();
            }
        }

        public List<RentalDTO> GetRentalByUserWithJoin(int userId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                IQueryable<RentalDTO> result = GetRentalsWithJoin(context).Where(x => x.UserId == userId);
                return result.ToList();
            }
        }

        public List<RentalDTO> GetRentals()
        {
            using (ReCapContext context = new ReCapContext())
            {
                IQueryable<RentalDTO> result = GetRentalsWithJoin(context);
                return result.ToList();
            }
        }
    }
}
