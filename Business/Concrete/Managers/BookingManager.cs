using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete.Managers
{
    public class BookingManager : IBookingService
    {
        IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void Add(Booking booking)
        {
            throw new NotImplementedException();
        }

        public void Delete(Booking booking)
        {
            throw new NotImplementedException();
        }

        public Booking GetBooking(int id)
        {
            return _bookingDal.Get(x => x.ID == id);

        }

        public Booking GetBookingByCustemerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public Booking GetBookingByVehicle(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public List<Booking> GetBookings()
        {
            return _bookingDal.GetAll();
        }

        public List<Booking> GetBookingsByCustemerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public List<Booking> GetBookingsByVehicle(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public void Update(Booking booking)
        {
            throw new NotImplementedException();
        }
    }
}
