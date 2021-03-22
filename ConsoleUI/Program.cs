using Business.Concrete.Managers;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetRentals();
            //GetCustomers();
            GetRentalWithJoin();

        }

        private static void GetRentalWithJoin()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var rentals in rentalManager.GetRentalsByUserId(7))
            {
                Console.WriteLine($"{rentals.BrandName} {rentals.CarName}");
            }
        }

        private static void GetCustomers()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetCustomers();
            foreach (var customer in result)
            {
                //Console.WriteLine($"{customer.User.FirstName} {customer.User.LastName}");
            }
        }

        private static void GetRentals()
        {
            RentalManager RentalManager = new RentalManager(new EfRentalDal());
            var result = RentalManager.GetRentals();
            foreach (var rental in result)
            {
                Console.WriteLine($"{rental.CarId}");
            }
        }
    }
}
