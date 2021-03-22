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

        /*
         * KOD TEKRARINI ÖNLEMEK İÇİN
         * FİLTRELEME İŞLEME RENTALDTO ÜZERİNDEN JOIN YAPILDIKTAN SONRA OLUŞTURIULAN TABLO ÜZERİNDEN METHOD İLE YAPILACAK
         */


        public List<RentalDTO> GetRentalsByCarWithJoin(int carId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                             join p in context.Cars on r.CarId equals p.CarID
                             join u in context.Users on r.UserId equals u.UserID
                             where r.CarId == p.CarID

                             select new RentalDTO
                             {
                                 RentID = r.RentID,
                                 CarId = r.CarId,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 BrandName = p.Brand.BrandName,
                                 CarName = p.CarName,
                                 RentDate = r.RentDate,
                                 ReturnDate = (DateTime)r.ReturnDate,
                                 TotalPrice = (decimal)r.TotalPrice
                             };

                return result.ToList();
            }
        }
        public List<RentalDTO> GetRentalByUserWithJoin(int userId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                             join p in context.Cars on r.CarId equals p.CarID
                             join u in context.Users on r.UserId equals u.UserID
                             where r.UserId == userId

                             select new RentalDTO
                             {
                                 RentID = r.RentID,
                                 CarId = r.CarId,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 BrandName = p.Brand.BrandName,
                                 CarName = p.CarName,
                                 RentDate = r.RentDate,
                                 ReturnDate = (DateTime)r.ReturnDate,
                                 TotalPrice = (decimal)r.TotalPrice
                             };

                return result.ToList();
            }
        }
    }
}
