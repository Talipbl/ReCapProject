using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBookingService
    {
        List<Booking> GetBookings();
        Booking GetBookingByCustemerId(int customerId);
        Booking GetBookingByVehicle(int vehicleId);
        void Add(Booking booking);
        void Delete(Booking booking);
        void Update(Booking booking);
    }
}
