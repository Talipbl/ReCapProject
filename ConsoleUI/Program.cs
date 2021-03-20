using Business.Concrete.Managers;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            GetBookings();
            //GetCustomers();
        }

        private static void GetCustomers()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetCustomers();
            foreach (var customer in result)
            {
                Console.WriteLine($"{customer.FirstName} {customer.LastName}");
            }
        }

        private static void GetBookings()
        {
            BookingManager bookingManager = new BookingManager(new EfBookingDal());
            var result = bookingManager.GetBookings();
            foreach (var booking in result)
            {
                //Console.WriteLine($"{booking.Customer.FirstName} {booking.FromDate} {booking.Vehicle.Brand.BrandName} {booking.Vehicle.Name}");
            }
        }
    }
}
