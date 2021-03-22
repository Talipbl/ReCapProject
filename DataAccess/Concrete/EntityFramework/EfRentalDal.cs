using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,ReCapContext>,IRentalDal
    {
        //this area include Rental special process
        public List<Rental> GetRentalsWithJoin(Expression<Func<Rental, bool>> filter = null)
        {
            using (ReCapContext db = new ReCapContext())
            {
                if (filter == null)
                {
                    return db.Set<Rental>()/*.Include("Brand")*/.Include("Car").Include("User").ToList();
                }
                else
                {
                    return db.Set<Rental>()/*.Include("Brand")*/.Include("Car").Include("User").Where(filter).ToList();
                }
            }
        }
    }
}
