using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBookingService
    {
        List<Booking> GetBookings();
        List<Booking> GetBookingsByCustemerId(int customerId);
        List<Booking> GetBookingsByVehicle(int vehicleId);
        Booking GetBooking(int id);

        void Add(Booking booking);
        void Delete(Booking booking);
        void Update(Booking booking);
    }
}
